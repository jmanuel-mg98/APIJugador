using Microsoft.Data.SqlClient;

namespace Dal
{
    public class ClsConexionBD
    {
        /// <summary>
        /// Función que realiza la conexion con la bbdd

        /// </summary>
        /// <returns> SqlConnection 'miConexion.Open()' </returns>
        public static SqlConnection abrirConexion()
        {


            SqlConnection miConexion = new SqlConnection();
            try
            {
                miConexion.ConnectionString =
                                        "server=alvaro-salvador.database.windows.net;database=alvaroDB;uid=usuario;pwd=LaCampana123;trustServerCertificate=true;";
                miConexion.Open();
            }
            catch (Exception ex)
            {

                throw new Exception(" error al abrir la conexion con la bbdd", ex);
            }

            return miConexion;
        }
        /// <summary>
        /// funcion que cierra la conexion
        /// </summary>
        /// <param name="miConexion"></param>
        /// <exception cref="Exception"></exception>
        public static void cerrarConexion(ref SqlConnection miConexion)
        {
            try
            {
                miConexion.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("error al CERRAR la conexión con la bbdd", ex);

            }
        }

    }
}
