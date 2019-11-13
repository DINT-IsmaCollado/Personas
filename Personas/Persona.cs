using System.Collections.ObjectModel;

namespace Personas
{
    public class Persona
    {
        private int _id;
        public int Id { get; set; }

        private string _nombre;
        public string Nombre { get; set; }

        private string _foto;
        public string Foto { get; set; }

        private string _sexo;
        public string Sexo { get; set; }

        public Persona(int id, string nombre, string foto, string sexo)
        {
            _id = id;
            _nombre = nombre;
            _foto = foto;
            _sexo = sexo;
        }

        public static ObservableCollection<Persona> GetPersonas()
        {
            ObservableCollection<Persona> lista = new ObservableCollection<Persona>();

            lista.Add(new Persona(1, "Pepe", "1.jpg", "Hombre"));
            lista.Add(new Persona(2, "Antonio", "2.jpg", "Hombre"));
            lista.Add(new Persona(3, "Sara", "3.jpg", "Mujer"));

            return lista;
        }
    }
}