
using Cinepolis.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Cinepolis
{ 
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell(int id, string ciudad)
        {
            int idCiudad = id;
            string nombreCiudad = ciudad;
            InitializeComponent();
            SendValuesToCarteleraPage(idCiudad, nombreCiudad);
        }

        void SendValuesToCarteleraPage(int id, string ciudad)
        {
            CarteleraPage.ReceiveValues(id, ciudad);
        }




    }
}
