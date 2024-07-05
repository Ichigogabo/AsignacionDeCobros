using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cobros.DAL.IRepository;
using System.Data.SqlClient;
using System.Data;

namespace Cobros.DAL.Repository
{
    public class GenericRepository : IGenericRepository 
    {        
        private SqlConnection _conexion = new SqlConnection("Data source=.;initial catalog=PruebaTecnicaNetForemostBD;Integrated Security=true");

        public DataTable ListarbySP()
        {
            _conexion.Open();
            SqlCommand cmd = new SqlCommand("Cobros.AsignacionDeSaldos", _conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            _conexion.Close();

            return dt;
        }
    }
}
