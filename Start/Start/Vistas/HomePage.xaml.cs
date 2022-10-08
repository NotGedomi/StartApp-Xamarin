using Start.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Start.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }
        ///Para la carga dinámica
        protected override void OnAppearing()
        {
            base.OnAppearing();
            CargarActividades();
        }

        private async void CargarActividades()
        {
            var Actividades = await App.db.GetActividadAsync();
            lstActividad.ItemsSource = Actividades;
        }

        ///Evento Guardar
        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                Actividad activ = new Actividad
                {
                    Descripcion = txtDescripcion.Text,
                    Fecha = lblResultadoFecha.Text,
                    Hora = lblResultadoHora.Text,
                };
                await App.SQLiteDB.SaveActividadAsync(activ);
                txtDescripcion.Text = "";
                lblResultadoFecha.Text = "";
                lblResultadoHora.Text = "";
                await DisplayAlert("Nueva Actividad", "Tu nueva actividad se ha guardado correctamente", "Ok");
                var actividadList = await App.SQLiteDB.GetActividadAsync();
                if (actividadList!=null)
                {
                    lstActividad.ItemsSource = actividadList;
                }
            }
            else
            {
                await DisplayAlert("Advertencia", "Rellenar todos los campos", "Ok");
            }
        }

        public bool validarDatos() ///Valida que los campos no esten en blanco
        {
            bool respuesta;
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(lblResultadoFecha.Text))
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(lblResultadoHora.Text))
            {
                respuesta = false;
            }
            else
            {
                respuesta = true;
            }
            return respuesta;
        }

        private void txtFecha_DateSelected(object sender, DateChangedEventArgs e)
        {
            lblResultadoFecha.Text = txtFecha.Date.ToString("MMM dd, yyyy");
        }

        private void txtHora_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            lblResultadoHora.Text = txtHora.Time.ToString();
        }
    }
}