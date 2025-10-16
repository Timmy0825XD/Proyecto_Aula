using System.Data;

namespace DAL
{
    public class OracleConexion : IConexion
    {
        public bool Conectar()
        {
            throw new NotImplementedException();
        }

        public bool Desconectar()
        {
            throw new NotImplementedException();
        }

        public bool EjecutarComando(string sql)
        {
            throw new NotImplementedException();
        }

        public DataTable EjecutarConsulta(string query)
        {
            throw new NotImplementedException();
        }
    }
}
