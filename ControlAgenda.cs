using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGuiado
{
    internal class ControlAgenda
    {
        private Agenda _agenda;
        public ControlAgenda(Agenda agenda)
        {
            _agenda = agenda;
        }


        public void VerContactos()
        {
            Limpiar();
            MostrarMenu();
            string opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Contactos Orden Ascendente");
                    _agenda.MostrarOrdenados();
                    break;
                case "2":
                    Console.WriteLine("Contactos Orden Descendente");
                    _agenda.MostrarOrdenadosDesc();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
                PresionaParaContinuar();
            }
        }
        public void AgregarContacto()
        {
            Limpiar();
            Console.WriteLine("Nuevo contacto");
            Contacto contacto=new Contacto();
            Console.Write("Nombre: ");
            contacto.Nombre = Console.ReadLine();
            Console.Write("Teléfono: ");
            contacto.Telefono = Console.ReadLine();
            Console.Write("Email: ");
            contacto.Email = Console.ReadLine();

            _agenda.AgregarContacto(contacto);
            Console.WriteLine("Contacto agregado exitosamente");
            //Presiona una tecla para continuar
            PresionaParaContinuar();

        }
        public void BorrarUltimoContacto()
        {
            Limpiar();
            _agenda.BorrarUltimoContacto();
            Console.WriteLine("Contacto borrado exitosamente");
            PresionaParaContinuar();
        }
        public void BuscarPorNombre()
        {
            Limpiar();
            Console.WriteLine("Buscar contacto");
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            _agenda.BuscarPorNombre(nombre);
            PresionaParaContinuar() ;
        }
        public static void AcercaDe()
        {
            Limpiar();
            Console.WriteLine("Nombre: Iris Vilaseca");
            PresionaParaContinuar();
        }
        public void MostrarMenu()
        {
            StringBuilder sb=new StringBuilder();
            sb.AppendLine("1. Mostrar orden ascendente");
            sb.AppendLine("2. Mostrar orden descendente");
            sb.AppendLine("3. Volver al menú principal");
            sb.Append("Selecciones una opción: ");
            Console.WriteLine(sb.ToString());
        }
        private static void PresionaParaContinuar()
        {
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();
        }
        private static void Limpiar()
        {
            Console.Clear();
        }
    }
}
