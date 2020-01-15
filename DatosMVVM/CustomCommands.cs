using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DatosMVVM
{
    public static class CustomCommands
    {
        public static readonly RoutedUICommand Actualizar = new RoutedUICommand(
            "Delete",
            "Delete",
            typeof(CustomCommands),
            new InputGestureCollection() { new KeyGesture(Key.O, ModifierKeys.Control)}
            );
    }
}
