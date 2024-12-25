using System.Configuration;


namespace DAL
{
    public class ConexionDB
    {

        public string ObtenerConexion()
        {
            return ConfigurationManager.ConnectionStrings["ParcialLUG2"].ConnectionString;
        }
    }



}