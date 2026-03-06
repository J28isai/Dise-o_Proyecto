using Diseño_Proyecto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseño_Proyecto.Repository
{
    public partial interface IMenuRepo
    {
       public List<MenuOp> GetMenuOptions();

    }
}
