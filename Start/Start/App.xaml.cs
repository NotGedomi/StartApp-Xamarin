using Start.Data;
using Start.Vistas;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Start
{
    public partial class App : Application
    {
        public static SQLiteHelper db { get; set; }
        public App()
        {
            InitializeComponent();
            InitializeDatabase();
            MainPage = new NavigationPage(new HomePage());
        }

        private void InitializeDatabase()
        {
            var folderApp = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var dbPath = System.IO.Path.Combine(folderApp, "Start.db3");
            db = new SQLiteHelper(dbPath);
        }

        public static SQLiteHelper SQLiteDB
        {
            get
            {
                if (db==null) ///Si la base de datos no existe, la crea.
                {
                    db = new SQLiteHelper(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"Start.db3"));
                }
                return db; ///Si la base datos existe, no es necesario crearla.
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
