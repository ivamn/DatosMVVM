using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosMVVM
{
    class DatabaseInformes
    {
        private InformesEntities Contexto { get; }

        public DatabaseInformes()
        {
            Contexto = new InformesEntities();
        }

        public ObservableCollection<CLIENTE> ObtenerClientes()
        {
            Contexto.CLIENTES.Load();
            return Contexto.CLIENTES.Local;
        }

        public void GuardarCambios()
        {
            Contexto.SaveChanges();
        }
    }
}
