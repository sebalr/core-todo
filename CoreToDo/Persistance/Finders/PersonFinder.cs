using CoreBase.Persistance;
using CoreToDo.Entities;

namespace CoreToDo.Persistance.Finders
{
    public interface IPersonFinder : IBaseFinder<Person> { }

    public class PersonFinder : BaseFinder<Person>, IPersonFinder
    {
        public PersonFinder(DatabaseContext baseContext) : base(baseContext) { }

    }
}
