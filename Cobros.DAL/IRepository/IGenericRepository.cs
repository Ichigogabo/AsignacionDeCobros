using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobros.DAL.IRepository
{
    public interface IGenericRepository 
    {
        DataTable ListarbySP();
    }
}
