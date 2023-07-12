using NServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Caja_Sistema_bancario.DataSet1TableAdapters;

namespace Caja_Sistema_bancario.Clases
{
    public class LoginCommand : ICommand
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public bool comprobar()
        {
            usersTableAdapter users = new usersTableAdapter();
            foreach (var item in users.GetData().Where(c=> c.UserName == UserName && c.Password == Password))
            {
                return true;
            }
            return false;
        }
    }

}
