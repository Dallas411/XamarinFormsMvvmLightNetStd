using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XfMvvmLnetStd.Interface;
using XfMvvmLnetStd.Model;
using XfMvvmLnetStd.Util;

namespace XfMvvmLnetStd.Service
{
    public class PeopleServiceStub : IPeopleService
    {
        public Task<IEnumerable<Person>> GetPeople()
        {
            const int numberOfPeopleToGenerate = 100;
            return Task.Run(() => GeneratePeople(numberOfPeopleToGenerate));
        }

        private IEnumerable<Person> GeneratePeople(int personCount)
        {
            var people = new List<Person>(personCount);

            for (int i = 0; i < personCount; ++i)
            {
                people.Add(new Person(NameGenerator.GenRandomFirstName(), NameGenerator.GenRandomLastName()));
            }

            return people;
        }
    }
}
