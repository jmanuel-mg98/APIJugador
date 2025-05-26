using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Dal
{
    public class ClsListadoJugadorDal
    {
        /// <summary>
        /// esta funcion estatica devolvera el atributo privado de listado de jugadores traido de la bd
        /// pre: nadena 
        /// pos: nadena
        /// </summary>
        /// <returns>list<clsCaballo></clsCaballo></returns>
        public static List<ClsJugador> obtenerListadoJugadorCompletoDal()
        {
            List<ClsJugador> ListadoCompletoJugadorDAl = new List<ClsJugador>();
            SqlConnection miConexion = null;
            SqlDataReader miLector;
            SqlCommand miComando = new SqlCommand();

            try
            {
                miConexion = ClsConexionBD.abrirConexion();
                miComando.CommandText = "SELECT * FROM Jugador";
                miComando.Connection = miConexion;

                miLector = miComando.ExecuteReader();

                while (miLector.Read())
                {
                    ClsJugador nuevoJugador = new ClsJugador((int)miLector["idJugador"]);
                    if (miLector["nombreJugador"] != DBNull.Value)
                        nuevoJugador.Nombre = (string)miLector["nombreJugador"];
                    if (miLector["puntuacionJugador"] != DBNull.Value)
                        nuevoJugador.Puntuacion=((int)miLector["puntuacionJugador"]);

                    ListadoCompletoJugadorDAl.Add(nuevoJugador);
                }

                miLector.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                ClsConexionBD.cerrarConexion(ref miConexion);
            }

            return ListadoCompletoJugadorDAl;
        }
    }
}
