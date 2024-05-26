using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitzone.Controller.Interfaces
{
    interface IControllersABM<Entity>
    {
        bool Insert(Entity entidad);
        bool Update(Entity entidad, int id);
        bool Delete(int id);
        bool Anular(int id);
    }
}
