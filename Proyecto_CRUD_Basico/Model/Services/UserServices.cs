using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Proyecto_CRUD_Basico.Controllers;
using Proyecto_CRUD_Basico.Model.Entities;

namespace Proyecto_CRUD_Basico.Model.Services
{
    public class UserServices
    {
        private List<User> tablaUsuarios;

        public UserServices()
        {
            // Inicializar la lista de usuarios
            tablaUsuarios = new List<User>();
        }

        public List<User> GetAllUsers()
        {
            return tablaUsuarios;
        }

        public User? GetUserById(int id)
        {
            return tablaUsuarios.Find(u => u.Id == id);
        }

        public User? GetUserByEmail(string email)
        {
            return tablaUsuarios.Find(u => u.Email == email);
        }

        public bool CreateUser(User user)
        {
            try
            {
                tablaUsuarios.Add(user);
                return true;
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                Console.WriteLine($"Error al crear el usuario: {ex.Message}");
                return false;
            }
        }

        public bool UpdateUser(User user) {
            try
            {
                var userUpdate = GetUserById(user.Id);
                if (userUpdate != null)
                {
                    userUpdate.Nombre = user.Nombre;
                    userUpdate.Email = user.Email;
                    userUpdate.Password = user.Password;
                    userUpdate.IsActive = user.IsActive;
                    return true;
                }
                return false;
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar el usuario: {ex.Message}");
                return false;
            }
        }

        public bool DeleteUser(int userID)
        {
            try
            {
                var userToDelete = GetUserById(userID);
                tablaUsuarios.Remove(userToDelete);
                return true;
            }
            catch (Exception ex)
            {
                // Manejo de errores
                Console.WriteLine($"Error al eliminar el usuario: {ex.Message}");
                return false;
            }
        }
    }
}
