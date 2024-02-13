using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("E04")]
    public class E04Petlje : ControllerBase
    {




        // Ovdje počinje ruta
        [HttpGet]
        [Route("zad1")]
        public int Zad1(int a, int b)
        {
            //ruta prima dva cijela broja i vraca zbroj svih parnih brojeva izmedju
            int zbroj = 0;
            for (int i = a; i < b; i++)
            
            {
                if ( i % 2 == 0)
                {
                    zbroj += i;
                }
            }
            return zbroj;







        }
        // Ovdje završava ruta






    }
}
