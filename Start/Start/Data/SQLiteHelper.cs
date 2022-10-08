using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Start.Modelos;

namespace Start.Data
{
    public class SQLiteHelper
    {
        SQLiteAsyncConnection db;
        public SQLiteHelper(string dbPath) ///Creación de nuestra tabla y conexión
        {
            db = new SQLiteAsyncConnection(dbPath);
            db.CreateTableAsync<Actividad>().Wait();
        }

        public Task <int> SaveActividadAsync(Actividad activ)
        {
            if (activ.IdActividad==0)
            {
                return db.InsertAsync(activ);
            }
            else
            {
                return null;
            }
        }

        ///Mostrar Actividad
        public async Task<List<Actividad>> GetActividadAsync()
        {
            return await db.Table<Actividad>().ToListAsync();
        }

        ///Mostrar Actividad por ID
        public Task<Actividad> GetActividadByIdAsync(int idActividad)
        {
            return db.Table<Actividad>().Where(a => a.IdActividad == idActividad).FirstOrDefaultAsync();
        }

        ///Mantener los datos cargador al abrir la app
    }
}
