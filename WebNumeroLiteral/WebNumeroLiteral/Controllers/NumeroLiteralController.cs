using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebNumeroLiteral.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NumeroLiteralController : Controller
    {
        [HttpGet]
        public string ConversionGet(string num)
        {
            string respuesta = ""; //1.568.768
            if (num.Length > 7)
            { return "Numero muy grande"; }
            if (num.Length == 0)
            {
                return "vacio";
            }

            if (num.Length == 7)
            {
                respuesta += Millon(num[0]);
                respuesta += Centena(num[1]);
                respuesta += Decena(num[2]);
                if (num[2] != '0')  //1.902.000
                { respuesta += "y "; }
                respuesta += Unidad(num[3]);
                if (num[1] != '0' || num[2] != '0' || num[3] != '0')
                {//1.000.500
                    respuesta += " mil ";
                }
                //1.050.600
                respuesta += Centena(num[4]);
                respuesta += Decena(num[5]);
                if (num[6] != '0')
                { respuesta += "y "; }
                respuesta += Unidad(num[6]);
            }

            if (num.Length == 6)
            {

                respuesta += Centena(num[0]);
                respuesta += Decena(num[1]);
                if (num[2] != '0')
                { respuesta += "y "; }
                respuesta += Unidad(num[2]);
                if (num[0] != '0' || num[1] != '0' || num[2] != '0')
                {
                    respuesta += " mil ";
                }

                respuesta += Centena(num[3]);
                respuesta += Decena(num[4]);
                if (num[5] != '0')
                { respuesta += "y "; }
                respuesta += Unidad(num[5]);


            }

            if (num.Length == 5)
            {


                respuesta += Decena(num[0]);
                if (num[1] != '0')
                { respuesta += "y "; }
                respuesta += Unidad(num[1]);
                if (num[0] != '0' || num[1] != '0')
                {
                    respuesta += " mil ";
                }

                respuesta += Centena(num[2]);
                respuesta += Decena(num[3]);
                if (num[4] != '0')
                { respuesta += "y "; }
                respuesta += Unidad(num[4]);


            }

            if (num.Length == 4)
            {

                respuesta += Unidad(num[0]);
                if (num[0] != '0')
                {
                    respuesta += " mil ";
                }

                respuesta += Centena(num[1]);
                respuesta += Decena(num[2]);
                if (num[3] != '0')
                { respuesta += "y "; }
                respuesta += Unidad(num[3]);


            }


            if (num.Length == 3)
            {

                respuesta += Centena(num[0]);
                respuesta += Decena(num[1]);
                if (num[2] != '0')
                { respuesta += "y "; }
                respuesta += Unidad(num[2]);


            }

            if (num.Length == 2)
            {

                respuesta += Decena(num[0]);
                if (num[1] != '0')
                { respuesta += "y "; }
                respuesta += Unidad(num[1]);


            }

            if (num.Length == 1 && num != "0")
            {
                respuesta += Unidad(num[0]);
            }
            if (num.Length == 1 && num == "0")
                return "cero";


            return respuesta;


        }


        private string Millon(char x)
        {
            if (x == '1')
            { return "Millon "; }
            if (x == '2')
            { return "Dos Millones "; }
            if (x == '3')
            { return "Tres Millones "; }
            if (x == '4')
            { return "Cuatro Millones "; }
            if (x == '5')
            { return "Cinco Millones "; }
            if (x == '6')
            { return "Seis Millones "; }
            if (x == '7')
            { return "Siete Millones "; }
            if (x == '8')
            { return "Ocho Millones "; }

            return "Nueve Millones ";

        }

        private string Centena(char x)
        {

            if (x == '1')
            { return "Cien "; }
            if (x == '2')
            { return "Doscientos "; }
            if (x == '3')
            { return "Trescientos "; }
            if (x == '4')
            { return "Cuatrocientos "; }
            if (x == '5')
            { return "Quinientos "; }
            if (x == '6')
            { return "Seiscientos "; }
            if (x == '7')
            { return "Sietecientos "; }
            if (x == '8')
            { return "Ochocientos "; }
            if (x == '9')
            { return "Novecientos "; }
            return " ";

        }

        private string Decena(char x)
        {
            if (x == '1')
            { return "Diez "; }
            if (x == '2')
            { return "Veinte "; }
            if (x == '3')
            { return "Treinta "; }
            if (x == '4')
            { return "Cuarenta "; }
            if (x == '5')
            { return "Cincuenta "; }
            if (x == '6')
            { return "Sesenta "; }
            if (x == '7')
            { return "Setenta "; }
            if (x == '8')
            { return "Ochenta "; }
            if (x == '9')
            { return "Noventa "; }
            return " ";
        }

        private string Unidad(char x)
        {
            if (x == '1')
            { return "Uno"; }
            if (x == '2')
            { return "Dos"; }
            if (x == '3')
            { return "Tres"; }
            if (x == '4')
            { return "Cuatro"; }
            if (x == '5')
            { return "Cinco"; }
            if (x == '6')
            { return "Seis"; }
            if (x == '7')
            { return "Siete"; }
            if (x == '8')
            { return "Ocho"; }
            if (x == '9')
            { return "Nueve"; }
            return " ";
        }





        





    }
}
