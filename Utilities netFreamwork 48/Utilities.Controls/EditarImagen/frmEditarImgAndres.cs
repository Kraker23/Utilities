//sing ARQ.Tools.AltaInc.FE.AltaScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilities.Controls.EditarImagen
{
    public partial class frmEditarImgAndres : Form
    {

        #region Variables

        // Herramientas
        enum eTools { None, Recortar, Linea, Rectangulo, Flecha }

        // indador si el fomulario
        bool onlyEdit = false;

        // Captura de pantalla original sin modificaciones
        Bitmap imgOriginal = null;

        //Bitmap ant = null;
        // Img de trabajo 
        Bitmap img = null;
        // Img temporal para mostrar los preview de las herramientas
        Bitmap imgTmp = null;

        // Puntos de la imagen para edición 
        Point pStart,pEnd;
        // Indicador para saber si se ha iniciado una acción de edición
        bool editStart = false;

        // herramienta activa
        eTools activeTool = eTools.None;

        // Color de las líneas
        Color drawColor = Color.Red;
        // Pincel con el color seleccionado por el usuario
        Brush drawBrush = Brushes.Red;

        #region Zoom
        // variables para el control del zoom realizado a la imagen y posición del ratón
        double zoomRatio = 1;
        bool maxZoomVertical = false;
        int borde = 0;

        int relImgPosX, relImgPosY;
        bool dentroImagen = false;

        #endregion

        /// <summary>Imagen editada resultante </summary>
        public Bitmap ImagenResultado { get { return img; } }

        #endregion


        #region Constructro

        public frmEditarImgAndres()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            
            crearIconos();

            //this.onlyEdit = false;


            Image Imagen = new Bitmap(Screen.AllScreens[0].WorkingArea.Width, Screen.AllScreens[0].WorkingArea.Height);
            this.onlyEdit = true;
            this.img = new Bitmap(Imagen);
            this.pck.Image = img;
            calcularZoom();
        }

        public frmEditarImgAndres(Bitmap Imagen)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            
            crearIconos();

            this.onlyEdit = true;
            this.img = Imagen;
            this.pck.Image = img;
            calcularZoom();
            
        }

        #endregion


        #region Eventos

        private void frmEditarImg_Load(object sender, EventArgs e)
        {
            this.Visible = onlyEdit;
        }

        private void frmEditarImg_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.TaskManagerClosing && e.CloseReason != CloseReason.WindowsShutDown)
            {
                e.Cancel = true;
                this.ShowInTaskbar = false;
                this.Visible = false;
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void frmEditarImg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && editStart)
            {
                this.cambiarHerramienta(null, eTools.None);
                editStart = false;
                pck.Image = img;
                pck.Refresh();
            }
        }


        private void ni_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // realizar el screenshot de todas las pantallas y unirlas en una sola imagen.
            try
            {
                int w = 0; //Screen.PrimaryScreen.Bounds.Width;
                int h = Screen.PrimaryScreen.Bounds.Height;

                // calculo del tamaño de la imagen
                foreach (var scr in Screen.AllScreens)
                {
                    w += scr.Bounds.Width;
                    if (h < scr.Bounds.Height) h = scr.Bounds.Height;
                }

                // creación del bitmap final y adición de las captiras
                img = new Bitmap(w, h);
                using (Graphics g = Graphics.FromImage(img))
                {
                    var x = 0;
                    foreach (var scr in Screen.AllScreens)
                    {
                        g.CopyFromScreen(scr.Bounds.Location, new Point(x, 0), scr.Bounds.Size);
                        x += scr.Bounds.Width;
                    }
                }

                // guardamos la copia origial
                this.imgOriginal = (Bitmap)img.Clone();

                // establecemos la imagen
                pck.Image = img;
                pck.Refresh();

                // mostramos la ventana oculta
                this.Visible = true;
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
                this.Refresh();

                // calculo de variables de zoom 
                calcularZoom();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (onlyEdit)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.imgOriginal.Dispose();
                this.Close();
            }
            else
            {
                // upload image
                this.uploadImageCache();

                this.img.Dispose();
                this.imgOriginal.Dispose();

                this.ShowInTaskbar = false;
                this.WindowState = FormWindowState.Minimized;
                this.Visible = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (onlyEdit)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.Close();
            }
            else
            {
                this.img.Dispose();
                this.imgOriginal.Dispose();

                this.ShowInTaskbar = false;
                this.WindowState = FormWindowState.Minimized;
                this.Visible = false;

            }
        }


        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = this.drawColor;
            cd.SolidColorOnly = true;

            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.drawColor = cd.Color;
                this.drawBrush = new SolidBrush(drawColor);
                crearIconos();
            }
        }


        private void tsbRecortar_Click(object sender, EventArgs e)
        {
            cambiarHerramienta(tsbRecortar, eTools.Recortar);
        }

        private void tsbLine_Click(object sender, EventArgs e)
        {
            cambiarHerramienta(tsbLine, eTools.Linea);
        }

        private void tsbRect_Click(object sender, EventArgs e)
        {
            cambiarHerramienta(tsbRect, eTools.Rectangulo);
        }

        private void tsbArrow_Click(object sender, EventArgs e)
        {
            cambiarHerramienta(tsbArrow, eTools.Flecha);
        }


        private void pck_Resize(object sender, EventArgs e)
        {
            calcularZoom();
        }

        private void pck_MouseMove(object sender, MouseEventArgs e)
        {
            if (activeTool != eTools.None && editStart)
            {
                calcularPosOnImage(e.Location);
                if (dentroImagen)
                {
                    pEnd = new Point(this.relImgPosX, this.relImgPosY);

                    switch (activeTool)
                    {
                        case eTools.Flecha: this.flecha(true); break;
                        case eTools.Linea: this.line(true); break;
                        case eTools.Recortar: this.recortar(true); break;
                        case eTools.Rectangulo: this.rectangulo(true); break;
                    }

                    pck.Image = imgTmp;
                    pck.Refresh();
                }
            }
        }

        private void pck_MouseDown(object sender, MouseEventArgs e)
        {
            if (activeTool != eTools.None)
            {
                calcularPosOnImage(e.Location);
                if (dentroImagen)
                {
                    pStart = new Point(this.relImgPosX, this.relImgPosY);
                    pEnd = Point.Empty;
                    editStart = true;
                }
            }
            else
            {
                editStart = false;
            }
        }

        private void pck_MouseUp(object sender, MouseEventArgs e)
        {
            if (activeTool != eTools.None)
            {
                calcularPosOnImage(e.Location);
                if (!dentroImagen || !editStart)
                {
                    activeTool = eTools.None;
                    pStart = Point.Empty;
                    pEnd = Point.Empty;
                    editStart = false;
                }
                else
                {
                    pEnd = new Point(this.relImgPosX, this.relImgPosY);

                    switch (activeTool)
                    {
                        case eTools.Flecha: this.flecha(false); break;
                        case eTools.Linea: this.line(false); break;
                        case eTools.Recortar: this.recortar(false); break;
                        case eTools.Rectangulo: this.rectangulo(false); break;
                    }

                    imgTmp.Dispose();
                    imgTmp = null;

                    pck.Image = img;
                    pck.Refresh();
                    calcularZoom();

                    //activeTool = eTools.None;
                    pStart = Point.Empty;
                    pEnd = Point.Empty;
                    editStart = false;
                }
            }
        }

        #endregion


        #region Funciones imagen
      
        /// <summary>Crea los icónos de acciones de los</summary>
        private void crearIconos()
        {
            Pen pen = new Pen(this.drawBrush);

            // selector color
            Bitmap bmp = new Bitmap(16, 16);
            using (var g = Graphics.FromImage(bmp))
            {
                g.FillRectangle(this.drawBrush, 1, 1, 14, 14);
                g.DrawRectangle(Pens.White, 2, 2, 12, 12);
                g.FillRectangle(Brushes.White, 12, 12, 2, 2);
                g.DrawRectangle(Pens.DarkGray, 1, 1, 14, 14);
            }
            btnColor.Image = bmp;

            // recortar
            bmp = new Bitmap(16, 16);
            using (var g = Graphics.FromImage(bmp))
            {
                var p = new Pen(Brushes.Black);
                p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                g.DrawRectangle(p, 1, 1, 14, 14);
            }
            tsbRecortar.Image = bmp;

            // rect
            bmp = new Bitmap(16, 16);
            using (var g = Graphics.FromImage(bmp))
            {
                g.DrawRectangle(pen, 1, 1, 14, 14);
            }
            tsbRect.Image = bmp;

            // line
            bmp = new Bitmap(16, 16);
            using (var g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.DrawLine(pen, 1, 1, 14, 14);
            }
            tsbLine.Image = bmp;

            // arrow
            bmp = new Bitmap(16, 16);
            using (var g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                pen.CustomEndCap = new System.Drawing.Drawing2D.AdjustableArrowCap(3, 3);

                g.DrawLine(pen, 1, 1, 14, 14);
            }
            tsbArrow.Image = bmp;


        }

        /// <summary>Cálculo del zoom de la imagen, margenes y ratio para el cálculo de la posición del ratón en la imagen </summary>
        private void calcularZoom()
        {
            var zW = pck.Width / (double)pck.Image.Width;
            var zH = pck.Height / (double)pck.Image.Height;

            zoomRatio = Math.Min(zW, zH);
            maxZoomVertical = zW > zH;

            borde = 0;
            if (maxZoomVertical)
            {
                borde = (pck.Width - (int)(pck.Image.Width * zoomRatio)) / 2;
            }
            else
            {
                borde = (pck.Height - (int)(pck.Image.Height * zoomRatio)) / 2;
            }

            /*tsLBL.Text = string.Format("w:{0} h:{1} zi:{2} zvert:{3} border:{4}",
                pck.Width, pck.Height, zoomRatio, maxZoomVertical, borde);*/
        }

        /// <summary>Calculo de la posición dentro de la imagen, dada la posición del ratón dentro del control picturebox</summary>
        /// <param name="p"></param>
        private void calcularPosOnImage(Point p)
        {
            // ((maxZoomVertical && point.X > borde && point.X < pck.Width - borde) || (!maxZoomVertical && point.Y > borde && point.Y < pck.Height - borde))
            if (maxZoomVertical)
            {
                if (p.X > borde && p.X < pck.Width - borde)
                {
                    relImgPosX = (int)((p.X - borde) / zoomRatio);
                    relImgPosY = (int)(p.Y / zoomRatio);
                    dentroImagen = true;
                }
                else
                {
                    relImgPosX = relImgPosY = -1;
                    dentroImagen = false;
                }
            }
            else
            {
                if (p.Y > borde && p.Y < pck.Height - borde)
                {
                    relImgPosX = (int)(p.X / zoomRatio);
                    relImgPosY = (int)((p.Y - borde) / zoomRatio);
                    dentroImagen = true;
                }
                else
                {
                    relImgPosX = relImgPosY = -1;
                    dentroImagen = false;
                }
            }
        }

        /// <summary>Cabio de herramienta. Estable los chechs y herramienta activa</summary>
        /// <param name="tsb">botón pulsado. Puede ser nulo al esteablecer la herramienta a None</param>
        /// <param name="newTool">herramienta a selecciónar o desseleccionar.</param>
        private void cambiarHerramienta(ToolStripButton tsb, eTools newTool)
        {
            if (tsb == null || tsb.Checked) activeTool = eTools.None;
            else activeTool = newTool;
            
            foreach (ToolStripItem b in toolStrip1.Items) 
            {
                if (b is ToolStripButton)
                {
                    ((ToolStripButton)b).Checked = false;
                }
            }

            if (tsb != null && activeTool != eTools.None) tsb.Checked = true;
        }


        /// <summary>Recorta una area de la imagen</summary>
        /// <param name="preview">Indica si la acción es el preview o la acción final</param>
        private void recortar(bool preview)
        {
            var rec = new Rectangle(Math.Min(pStart.X, pEnd.X), Math.Min(pStart.Y, pEnd.Y),
                        Math.Abs(pStart.X - pEnd.X), Math.Abs(pStart.Y - pEnd.Y));

            if (preview) 
            {
                if (imgTmp != null) imgTmp.Dispose();
                imgTmp = (Bitmap)img.Clone();
                using (var g = Graphics.FromImage(imgTmp))
                {
                    var fb = new SolidBrush(Color.FromArgb(100, Color.White));
                    var p = new Pen(Brushes.Black);
                    p.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;

                    g.FillRectangle(fb, rec);
                    g.DrawRectangle(p, rec);
                }
            }
            else
            {
                Bitmap bmp = new Bitmap(rec.Width, rec.Height);
                using (var g = Graphics.FromImage(bmp))
                {
                    g.DrawImage(img, new Rectangle(0, 0, rec.Width, rec.Height), rec, GraphicsUnit.Pixel);
                }
            
                img = bmp;

                this.tsbRecortar.Checked = false;
                this.activeTool = eTools.None;
            }
        }

        /// <summary>Dibuja un rectanculo (solo bode)</summary>
        /// <param name="preview">Indica si la acción es el preview o la acción final</param>
        private void rectangulo(bool preview)
        {
            var rec = new Rectangle(Math.Min(pStart.X, pEnd.X), Math.Min(pStart.Y, pEnd.Y),
                                    Math.Abs(pStart.X - pEnd.X), Math.Abs(pStart.Y - pEnd.Y));
            Pen p = new Pen(this.drawBrush, 3);

            Bitmap i;
            if (preview)
            {
                if (imgTmp != null) imgTmp.Dispose();
                imgTmp = (Bitmap)img.Clone();
                i = imgTmp;
            }
            else
            {
                i = img;
            }

            using (var g = Graphics.FromImage(i)) { g.DrawRectangle(p, rec); }

        }

        /// <summary>Dibuja una línea</summary>
        /// <param name="preview">Indica si la acción es el preview o la acción final</param>
        private void line(bool preview)
        {
            Pen p = new Pen(this.drawBrush, 2);

            Bitmap i;
            if (preview)
            {
                if (imgTmp != null) imgTmp.Dispose();
                imgTmp = (Bitmap)img.Clone();
                i = imgTmp;
            }
            else
            {
                i = img;
            }

            using (var g = Graphics.FromImage(i))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.DrawLine(p, pStart, pEnd);
            }

        }

        /// <summary>Dibuja una flecha</summary>
        /// <param name="preview">Indica si la acción es el preview o la acción final</param>
        private void flecha(bool preview)
        {
            Pen p = new Pen(this.drawBrush, 3);
            //p.StartCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
            //p.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            //p.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            p.CustomEndCap = new System.Drawing.Drawing2D.AdjustableArrowCap(4, 4);

            Bitmap i;
            if (preview)
            {
                if (imgTmp != null) imgTmp.Dispose();
                imgTmp = (Bitmap)img.Clone();
                i = imgTmp;
            }
            else
            {
                i = img;
            }

            using (var g = Graphics.FromImage(i))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.DrawLine(p, pStart, pEnd);
            }

        }


        /// <summary>Sube la imagen editada a la cache</summary>
        private void uploadImageCache()
        {
            //try
            //{
            //    // recuperamos los bytes con compresión png
            //    byte[] result = null;
            //    using (MemoryStream stream = new MemoryStream())
            //    {
            //        img.Save(stream, ImageFormat.Png);
            //        result = stream.ToArray();
            //    }

            //    // objetos de cache
            //    var md = new Metadata() { Name = Guid.NewGuid().ToString() + ".png", ContentType = "application/png" };
            //    var data = new CacheData() { Metadata = md, Binario = result };

            //    // cache y subida del fichero
            //    var cache = new Cache();
            //    var id = cache.Upload(data);

            //    if (string.IsNullOrEmpty(id))
            //    {
            //        MessageBox.Show("Error al subir el archivo");
            //    }
            //    else
            //    {
            //        // recuperamos la url de alta de incidencias y le agregamos el identificador del fichero
            //        var url = string.Format(Configuracion.FEALTAINCIDENCIA, id);
            //        System.Diagnostics.Process.Start(url);

            //        /*var doc = cache.Download(id);
            //        System.IO.File.WriteAllBytes(@"C:\"+id+".p doc.Binario*/
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
        }

        #endregion

    }
}
