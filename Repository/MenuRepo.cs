using Diseño_Proyecto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseño_Proyecto.Repository
{
    public class MenuRepo : IMenuRepo
    {
        public List<MenuOp> GetMenuOptions()
        {
            return new List<MenuOp>
        {
            new() { name="Inicio", route="Inicio" },
            new() { name="Inventario", route="Inventario" },
             new() { name="Ventas", route="Ventas"}, 

        };
        }
    }
}

