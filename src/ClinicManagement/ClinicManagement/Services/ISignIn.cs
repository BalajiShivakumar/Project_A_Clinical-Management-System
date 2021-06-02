using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagement.Services
{
    public interface ISignIn<T>
    {
        IEnumerable<T> GetAll();
        void Add(T t);
        int SignIn(T t);
    }
}