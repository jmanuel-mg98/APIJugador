using Dal;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl
{
    public class ClsManejadoraBl
    {
        /// <summary>
        /// llama a la dal para actualizar un caballo
        /// </summary>
        /// <param name="jugador"></param>
        /// <returns>entero de numero de filas afectadas</returns>
        public static int insertarJugadorBl(ClsJugador jugador)
        {
            return ClsManejadoraDal.insertarCaballoDal(jugador);
        }
    }
}
