using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using System.Drawing.Imaging;
using System.IO;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;



namespace CodigoQRSaew
{
    public partial class Form1 : Form
    {
        string sValor;
        public Form1()
        {
            InitializeComponent();
        }

        private void qrCodeImgControl1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLeer.Enabled = false;
            btnPrueba.Hide();
            
        }
        public void generarCodigo()
        {
            if(txtUrl.Text!="")
            {
                QrEncoder codigo = new QrEncoder(ErrorCorrectionLevel.H);
                QrCode cod = codigo.Encode(txtUrl.Text);
                GraphicsRenderer renderer = new GraphicsRenderer(new FixedModuleSize(5, QuietZoneModules.Two), Brushes.Black, Brushes.White);
                using (FileStream stream = new FileStream(@"C:\Users\Daniel\Pictures\CodigosQR\codigo.png", FileMode.Create))
                {
                    renderer.WriteToStream(cod.Matrix, ImageFormat.Png, stream);
                }
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            generarCodigo();
            MessageBox.Show("Exitoso");
            txtUrl.Clear();
        }

        private void txtUrl_TextChanged(object sender, EventArgs e)
        {
            qrCodigo.Text = txtUrl.Text;
        }

        private void btnArchivo_Click(object sender, EventArgs e)
        {
            string file_name = string.Empty;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string dir = openFileDialog1.FileName;
                string destino = Path.GetFileName(dir);
                txtruta.Text = dir;
                btnLeer.Enabled = true;
            }
            
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //abrimos el dialogo para poder obtener el nombre la ubicacion del archivo
            string sArchivo = txtruta.Text;
            
            //declaramos las variables que necesitamos para poder abrir un archivo excel
            Excel._Application exlApp = new Excel.Application();
            Workbook exlWbook;
            Worksheet exlWsheet;
            
            //Asignamos el libro que sera abierot
            exlWbook = exlApp.Workbooks.Open(sArchivo, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            exlWsheet = (Worksheet)exlWbook.Worksheets.get_Item(1);
            Range exlRange;

            //Definimos el el rango de celdas que seran leidas
            exlRange = exlWsheet.UsedRange;
            sValor = "";
            //Recorremos el archivo excel como si fuera una matriz
            for (int i = 2; i <= exlRange.Rows.Count; i++)
            {
                for (int j = 8; j <= 13; j++)
                {
                    string valor=(exlRange.Cells[i,j] as Range).Text;
                    if ( valor!= "")
                    {
                        sValor +=(exlRange.Cells[i, 3] as Range).Value + "%" + (exlRange.Cells[1, j] as Range).Value
                            + "%" + (exlRange.Cells[i, j] as Range).Value+"%";
                    }
                }
                //sValor += "$";
            }
                
            lstDatos.Items.Add(sValor);
            //cerramos el libro y la aplicacion
            exlWbook.Close();
            exlApp.Quit();
            txtUrl.Text = sValor;
        }

        private void btnQRHorario_Click(object sender, EventArgs e)
        {
            QrEncoder codigo = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode cod;
            GraphicsRenderer renderer;
            FileStream stream ;
                foreach (var iter in lstDatos.Items)
                {
                    cod = codigo.Encode(iter.ToString());
                    renderer= new GraphicsRenderer(new FixedModuleSize(5, QuietZoneModules.Two), Brushes.Black, Brushes.White);
                    using (stream= new FileStream(@"C:\Users\Daniel\Pictures\CodigosQR\codigo.png", FileMode.OpenOrCreate))
                    {
                        renderer.WriteToStream(cod.Matrix, ImageFormat.Png, stream);
                    }
                }
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            
        }
        public void formatoDatos()
        {
            
        }
    }
}
