using api_quanlynhahang.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.BLL.Interfaces
{
    public interface IManageruserRespo
    {
        public bool getUser (string email, string pass);
        public bool disableUser (int id);
        public bool editUser(int id, user kh);
        public bool createUser(user kh);
        public bool changepass(int id);
    }
}
