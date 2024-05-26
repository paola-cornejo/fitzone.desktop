using Fitzone.EF;
using Fitzone.Entidades;

namespace Fitzone.Controller
{
    public static class SociosController
    {
        static Contexto? contexto = new Contexto();

        public static List<Socio> Get()
        {
            return contexto.Socio.ToList();
        }
    }
}
