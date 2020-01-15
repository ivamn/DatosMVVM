using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosMVVM
{
    class MainWindowVM :INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<CLIENTE> Clientes { get; }
        public CLIENTE ClienteSeleccionado { get; set; }

        private DatabaseInformes Informes { get; }

        public MainWindowVM()
        {
            Informes = new DatabaseInformes();
            Clientes = Informes.ObtenerClientes();
        }

        public void ActualizarCambios()
        {
            Informes.GuardarCambios();
            ClienteSeleccionado = null;
        }

        public bool PuedeActualizar()
        {
            return ClienteSeleccionado != null;
        }
    }
}
