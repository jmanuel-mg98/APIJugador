using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Dal
{
    public class ClsManejadoraDal
    {
        /// <summary>
        /// esta funcion introduce un nuevo registro en la bbdd
        /// </summary>
        /// <param name="jugador"></param>
        /// <returns>un entero que indica el numero de filas afectadas</returns>
        public static int insertarCaballoDal(ClsJugador jugador)
        {
            int filasAfectadas = 0;
            SqlConnection miConexion = new SqlConnection();
            SqlCommand miComando = new SqlCommand();

            try
            {
                miConexion = ClsConexionBD.abrirConexion();
                miComando.CommandText = "INSERT INTO Jugador (nombreJugador, puntuacionJugador) VALUES ( @nombre, @puntuacion)";
                miComando.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar).Value = jugador.Nombre;
                miComando.Parameters.Add("@puntuacion", System.Data.SqlDbType.Int).Value = jugador.Puntuacion;

                miComando.Connection = miConexion;


                filasAfectadas = miComando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                ClsConexionBD.cerrarConexion(ref miConexion);
            }

            return filasAfectadas;
        }
    }
}
