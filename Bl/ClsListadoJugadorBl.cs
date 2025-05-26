using Dal;
using Entidades;

namespace Bl
{
    public class ClsListadoJugadorBl
    {
        /// <summary>
        /// esta funcion llama a la dal devolvera un listadocompleto de jugadores con las reglas de negocio aplicadas
        /// pre: nada
        /// pos: nada
        /// </summary>
        /// <returns></returns>
        public static List<ClsJugador> obtenerListadoJugadorCompletoBl()
        {
            return ClsListadoJugadorDal.obtenerListadoJugadorCompletoDal();
        }


    }
}
