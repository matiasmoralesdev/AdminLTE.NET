using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AdminLTE.NET.Pages.Administracion
{
    public class Ejemplo1Model : PageModel
    {

        public List<EjemploTabla>? Tabla { get; set; }

        public void OnGet()
        {
            Tabla = BuildEjemplo();
        }

        List<EjemploTabla> BuildEjemplo()
        {
            return new List<EjemploTabla>
            {
                new EjemploTabla{Nombre="Alfa",Apellido="Apellido1",Fecha=DateTime.Now},
                new EjemploTabla{Nombre="Beta",Apellido="Apellido2",Fecha=DateTime.Now},
                new EjemploTabla{Nombre="Gama",Apellido="Apellido3",Fecha=DateTime.Now},
            };
        }
    }

    public class EjemploTabla
    {
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public DateTime Fecha { get; set; }
    }
}
