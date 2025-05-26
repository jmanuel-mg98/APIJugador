using System.Text.Json.Serialization;

namespace Entidades
{
    public class ClsJugador
    {
        #region atributos
        private int id;
        private string nombre;
        private int puntuacion;
        #endregion
        #region propiedades
        public int Id
        {
            get { return id; }
        }
        [JsonPropertyName("nombreJugador")]
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        [JsonPropertyName("puntuacionJugador")]
        public int Puntuacion
        {
            get { return puntuacion; }
            set {  puntuacion = value; }
        }
        #endregion
        #region constructores
        public ClsJugador()
        {
    
        }

        public ClsJugador(int id)
        {
            this.id = id;
        }
        public ClsJugador(int id, string nombre, int puntuacion)
        {
            this.id = id;
            this.nombre = nombre;
            this.puntuacion = puntuacion;
        }
        #endregion
       
    }
}
