using System.Text;

namespace ProyectoGuiado
{
    class Program
    {
        static ControlAgenda control = new ControlAgenda(new Agenda());
        static void ImprimeMenu()
        {
            StringBuilder sb=new StringBuilder();
            sb.AppendLine("1. Ver Contactos");
            sb.AppendLine("2. Agregar Contacto");
            sb.AppendLine("3. Borrar último contacto");
            sb.AppendLine("4. Buscar contacto por nombre");
            sb.AppendLine("5. Acerca de");
            sb.AppendLine("6. Salir");
        }
    }
}