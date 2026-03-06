using Diseño_Proyecto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseño_Proyecto.Repository
{
    public class MenuRepo
    {
        public List<MenuOp> GetMenuOptions()
        {
            return new List<MenuOp>
        {
            new() { Name="Inicio", route="Inicio" },
            new() { Name="Inventario", route="Inventario" },
             new() { Name="Ventas", route="Ventas"}, 

        };
        }
    }
}

