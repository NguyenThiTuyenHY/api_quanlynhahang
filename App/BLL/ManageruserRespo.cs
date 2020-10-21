using api_quanlynhahang.Entities;
using App.BLL.Interfaces;
using Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.BLL
{
    public class ManageruserRespo : IManageruserRespo
    {
        private CommonContext _context;
        public ManageruserRespo(CommonContext context)
        {
            _context = context;
        }
        public bool changepass(int id)
        {
            throw new NotImplementedException();
        }

        public bool createUser(user kh)
        {
            throw new NotImplementedException();
        }

        public bool disableUser(int id)
        {
            throw new NotImplementedException();
        }

        public bool editUser(int id, user kh)
        {
            throw new NotImplementedException();
        }

        public user getUser(string email, string pass)
        {
            user result = _context.users.SingleOrDefault(x => x.email == email && x.password == pass);
            if (result == null)
            {
                return null;
            }
            return result;
        }
    }
}
