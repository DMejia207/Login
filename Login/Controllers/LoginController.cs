using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Login.Models;
using System.Threading.Tasks;

namespace Login.Controllers
{
    public class LoginController
    {
        readonly SQLiteAsyncConnection connection;

        //Constructor de clase
        public LoginController(string dbpath)
        {
            // Crear una nueva conexion hacia la base de dato
            connection = new SQLiteAsyncConnection(dbpath);

            // Crear los objetos de base de datos que vamos a ocupar
            connection.CreateTableAsync<Info>().Wait();
        }

        // Creacion de las operaciones CRUD - DB
        // Create

        public Task<int> SaveListaa(Info info)
        {
            if (info.id != 0)
                return connection.UpdateAsync(info);
            else
                return connection.InsertAsync(info);
        }
        // Read

        public Task<List<Info>> GetListaa()
        {
            return connection.Table<Info>().ToListAsync();
        }


        public Task<Info> GetListaa(int pid)
        {
            return connection.Table<Info>()
            .Where(i => i.id == pid)
            .FirstOrDefaultAsync();
        }

        // Delete

        public Task<int> DeleteListaa(Info info)
        {
            return connection.DeleteAsync(info);
        }
    }
}
