using System.Drawing;
using System;
using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using BarcodeLib;
using System.Linq;

namespace Utilities.Clases.QR_CodigoBarras
{
    public static class CodigoBarras
    {
        /// <summary>Generar Codigo de Barras de tipo Code128</summary>
        /// <param name="Texto">Texto del cual se va a generar el codigo de Barras</param>
        /// <returns>Imagen del codigo de Barras</returns>
        public static Image GenerarCodigoBarrasTipoCODE128(string Texto)
        {
            Image img = null;
            try
            {
                // Crea una instancia de la API
                Barcode barcodeAPI = new Barcode();

                // Definir la configuración básica de la imagen.
                int imageWidth = 290;
                int imageHeight = 120;
                Color foreColor = Color.Black;
                Color backColor = Color.Transparent;

                // Genera el código de barras con tu configuración
                img = barcodeAPI.Encode(TYPE.CODE128, Texto, foreColor, backColor, imageWidth, imageHeight);
            }
            catch (Exception ex)
            {
                new Exception(ex.Message, ex.InnerException);
            }
            return img;
        }

        /// <summary> Validar si el texto contiene caracteres no validos para el Tipo Code128</summary>
        /// <param name="text">Texto a revisar</param>
        /// <returns>Mensaje de error si hay caracteres no validos</returns>
        public static string ValidarTexto(string text)
        {
            string error = string.Empty;
            if (!string.IsNullOrEmpty(text))
            {
                if (text.Any(x => !Char.IsLetterOrDigit(x) && !char.IsWhiteSpace(x)))
                {
                    error = "El texto del Codigo Barras contiene Caracteres no validos." + Environment.NewLine;

                    foreach (char letra in text)
                    {
                        if (!Char.IsLetterOrDigit(letra) && !char.IsWhiteSpace(letra))
                        {
                            error += $"El caracter '{letra}' no esta permitido." + Environment.NewLine;
                        }
                    }
                }
            }
            else
            {
                error= "El texto del Codigo Barras no puede estar vacio";
            }
            return error;
        }

        #region  Ejemplo de USO de diferentes Tipos de Codigo Barras

        private static void EjemplosDiferentesTipos()
        {
            
            // Crea una instancia de la API
            Barcode barcodeAPI = new Barcode();

            // Definir la configuración básica de la imagen.
            int imageWidth = 290;
            int imageHeight = 120;
            Color foreColor = Color.Black;
            Color backColor = Color.Transparent;
            string data = "CI2F1PIG-6531LLL";

            // Genera el código de barras con tu configuración
            Image barcodeImage = barcodeAPI.Encode(TYPE.CODE128, data, foreColor, backColor, imageWidth, imageHeight);
            //pictureBox1.Image = barcodeImage;

            Image barcodeImage1 = barcodeAPI.Encode(TYPE.UPCA, "12346531123", foreColor, backColor, imageWidth, imageHeight);//Numeric Data Only', Data length invalid. (Length must be 11 or 12)'
         //   pictureBox2.Image = barcodeImage1;
            Image barcodeImage2 = barcodeAPI.Encode(TYPE.CODE11, "123-6531", foreColor, backColor, imageWidth, imageHeight);//solo numeros y -
          //  pictureBox3.Image = barcodeImage2;
            Image barcodeImage3 = barcodeAPI.Encode(TYPE.ISBN, "9781236531", foreColor, backColor, imageWidth, imageHeight);//Numeric Data Only'Must start with 978 and be length must be 9, 10, 12, 13 characters.'
           // pictureBox4.Image = barcodeImage3;
            Image barcodeImage4 = barcodeAPI.Encode(TYPE.ITF14, "12345678912345", foreColor, backColor, imageWidth, imageHeight);//solo numeros y Data length invalid. (Length must be 13 or 14)'
           // pictureBox5.Image = barcodeImage4;
            Image barcodeImage5 = barcodeAPI.Encode(TYPE.EAN13, "978020137962", foreColor, backColor, imageWidth, imageHeight);
            //pictureBox6.Image = barcodeImage5;

        }

        #endregion
    }

}