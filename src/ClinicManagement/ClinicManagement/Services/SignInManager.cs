using ClinicManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace ClinicManagement.Services
{
    public class SignInManager : ISignIn<SignIn>
    {
        public ClinicContext _context;
        public ILogger<SignInManager> _logger;
        public SignInManager(ClinicContext context, ILogger<SignInManager> logger)
        {
            _context = context;
            _logger = logger;
        }
        public void Add(SignIn t)
        {
            try
            {
                _context.SignInTable.Add(t);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
        }
        public IEnumerable<SignIn> GetAll()
        {
            try
            {
                if ((_context.SignInTable) == null)
                    return null;
                return _context.SignInTable.ToList();
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return null;
        }

        //public bool SignIn(SignIn t)
        //{
        //    throw new NotImplementedException();
        //}

        public int SignIn(SignIn t)
        {
            var obj = _context.SignUpTable.Where(i => i.Username.Equals(t.UserName) && i.Password.Equals(t.Password)).FirstOrDefault();
            try
            {
                if (obj != null)
                {
                    return 1;
                }
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return 0;
        }

        //int ISignIn<SignIn>.SignIn(SignIn t)
        //{
        //    throw new NotImplementedException();
        //}
    }
}

