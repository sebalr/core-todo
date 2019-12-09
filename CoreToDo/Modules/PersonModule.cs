using System;
using basiTodo.Infraestructure.DTOs;
using Carter.ModelBinding;
using Carter.Request;
using CoreBase.Entities;
using CoreBase.Extensions;
using CoreBase.Helpers;
using CoreBase.Modules;
using CoreBase.Persistance.finders;
using CoreBase.Services;
using CoreToDo.DTOs;
using CoreToDo.Entities;
using CoreToDo.Persistance.Finders;
using Microsoft.AspNetCore.Routing;

namespace CoreToDo.Modules
{
    public class PersonModule : BaseApiModule<Person, PersonDTO>
    {
        public PersonModule(IBaseModuleService baseModuleService, IPersonFinder personFinder, IUserFinder userFinder, IUserService userService) : base("person", baseModuleService, personFinder)
        {
            Post("/register", async ctx =>
            {
                var userDTO = await ctx.Request.Bind<UserDTO>();

                var person = new Person()
                {
                    Email = userDTO.Username
                };

                personFinder.Insert(person);

                var user = new User()
                {
                    Username = userDTO.Username,
                    Password = HashHandle.CalculateHash(userDTO.Password),
                    UserTypeId = person.Id
                };

                userFinder.Insert(user);

                userDTO = userService.Authenticate(userDTO.Username, userDTO.Password);

                await baseModuleService.RespondWithEntitiyDTO(ctx, userDTO);
            });

            Post("/{id:int}/addItem", async ctx =>
            {
                var person = this.GetById<Person>(ctx.GetRouteData().As<int>("id"), personFinder);

                var itemDTO = await ctx.Request.Bind<ItemDTO>();

                var item = baseModuleService.ConvertToEntity<ItemDTO, Item>(itemDTO);

                item.Creation = DateTime.Now;

                item.ItemState = new ItemState()
                {
                    State = State.New,
                    Changed = DateTime.Now
                };

                person.Items.Add(item);

                personFinder.Update(person);

                await baseModuleService.RespondWithEntitiyDTO<Item, ItemDTO>(ctx, item);
            });
        }
    }
}
