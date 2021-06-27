using System;
using Xunit; 
using angular.Web.Controllers;

namespace UnitTesting
{
    public class ValidaFechaDeberia
    {
        [Theory]
        [InlineData("54425387",false)]
        [InlineData("20200219",true)]
        public void ValidarFecha(string fecha, bool resultadoEsperado)
        {
            bool esValido = CuadreSaldoController.validaFecha(fecha);

            Assert.Equal(esValido,resultadoEsperado);
        }

        [Theory]
        [InlineData("54425387",false)]
        [InlineData("20200219",true)]
        public void ValidarFechaPago(string fecha, bool resultadoEsperado)
        {
            bool esValido = PagoController.validaFecha(fecha);

            Assert.Equal(esValido,resultadoEsperado);
        }
    }
}
