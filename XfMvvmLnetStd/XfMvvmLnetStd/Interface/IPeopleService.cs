using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XfMvvmLnetStd.Model;

namespace XfMvvmLnetStd.Interface
{
    public interface IPeopleService
    {
        Task<IEnumerable<Person>> GetPeople();
    }
}
