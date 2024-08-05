using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGuiado
{
    internal class Agenda
    {
        private List<Contacto> _contactos;
        private int _index;
        public int NumContactos
        {
            get
            {
                return _index;
            }
        }
        public Agenda()
        {
            _index = 0;
            _contactos = new List<Contacto>();
        }
        public void AgregarContacto(Contacto contacto)
        {
            _contactos.Add(contacto);
            _index++;
        }
        public void BorrarUltimoContacto()
        {
            if (_index > 0)
            {
                _contactos.RemoveAt(_index);
                _index--;
            }
            else
            {
                Console.WriteLine("La agenda ya está vacía");
            }
        }
        private bool HayContactos()
        {
            if (_index != 0) return true;
            Console.WriteLine("No hay contactos");
            return false;
        }
        public void MostrarOrdenados()
        {
            if (HayContactos())
            {
                List<Contacto> ordenados = new List<Contacto>();
                ordenados.AddRange(_contactos);
                ordenados.Sort();
                Console.WriteLine(CadenaContactos(ordenados));
            }
            else
            {
                return;
            }

        }
        public void MostrarOrdenadosDesc()
        {
            if (HayContactos())
            {
                List<Contacto> ordenados = new List<Contacto>();
                ordenados.AddRange(_contactos);
                ordenados.Sort();
                ordenados.Reverse();
                Console.WriteLine(CadenaContactos(ordenados));
            }
            else
            {
                return;
            }

        }
        public List<Contacto> BuscarPorNombre(string nombre)
        {
            List<Contacto> encontrados = new List<Contacto>();
            if (HayContactos())
            {
                
                foreach (var contacto in _contactos)
                {
                    if (contacto.Nombre == nombre)
                    {
                        encontrados.Add(contacto);
                    }
                    
                }
                return encontrados;
            }
            else
            {
                Console.WriteLine("No hay contactos con este nombre");
                return null;
            }
        }
        public void MostrarContactos()
        {
            Console.WriteLine(this);
        }
        public override string ToString()
        {
            return CadenaContactos(_contactos);
        }
        private string CadenaContactos(List<Contacto> contactos)
        {
            int i = 0;
            StringBuilder sb = new StringBuilder();
            foreach (Contacto contacto in contactos)
            {

                string dato = string.Format("{0}. {1}", i + 1, contactos.ElementAt(i));
                sb.AppendLine(dato);
            }
            return sb.ToString();
        }
    }
}
