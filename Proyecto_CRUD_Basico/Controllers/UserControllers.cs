using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Proyecto_CRUD_Basico.Model.Entities;
using Proyecto_CRUD_Basico.Model.Services;

namespace Proyecto_CRUD_Basico.Controllers
{
    public class UserControllers
    {
        private readonly UserServices _userServices;

        public UserControllers()
        {
            _userServices = new UserServices();
        }

        public List<User> GetAllUsers()
        {
            return _userServices.GetAllUsers();
        }

        public bool CreateUser(User user)
        {
            if (!ValidatePassword(user.Password))
                return false;
            if (user == null)
                return false;
            return _userServices.CreateUser(user);
        }

        public bool ValidatePassword(string password) { 
            int minLength = 8;
            Regex HasUpper = new Regex(@"[A-Z]+");
            Regex HasNumbner = new Regex(@"[0-9]+");

            if (!HasUpper.IsMatch(password))
                return false;
            if (!HasNumbner.IsMatch(password))
                return false;
            if (password.Length < minLength)
                return false;
            return true;
        }

        private bool emailExist(string email) { 
            var user = _userServices.GetUserByEmail(email);
            if (user != null)
                return true;
            return false;
        }

        public bool UpdateUser(User user)
        {
            if (user == null)
                return false;
            if (!ValidatePassword(user.Password))
                return false;
            if (emailExist(user.Email))
                return false;
            return _userServices.UpdateUser(user);
        }

        public User GetUserById(int id)
        {
            return _userServices.GetUserById(id);
        }

        public bool DeleteUser(int id)
        {
            return _userServices.DeleteUser(id);
        }


    }
}
