using Aspose.Pdf.Devices;
//using Aspose.Pdf;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.VisualStyles;
using GdPicture14;
using LicenseManager = GdPicture14.LicenseManager;
//using PdfSharp.Pdf.IO;
//using PdfSharp.Pdf;
//using iTextSharp.text.api;
//using iTextSharp.text;
//using iTextSharp.text.pdf;
//using Image = iTextSharp.text.Image;
//using iTextSharp.text.pdf.parser;
using org.apache.pdfbox.pdmodel;
using org.apache.pdfbox.pdfparser;
//using org.apache.pdfbox.rendering;
//using org.apache.pdfbox.rendering.ImageType;
//using java.awt;
using java.awt.image;
//using Aspose.Pdf.Devices;
//using UglyToad.PdfPig;
using UglyToad.PdfPig.Rendering;
using sun.net.www.content.image;
using javax.swing;
//using PdfiumViewer;
using Ghostscript.NET.Rasterizer;
using com.sun.servicetag;
using org.junit;

namespace book
{

        /*
    public class ImageRenderListener : IRenderListener
    {
        
        public List<System.Drawing.Image> Images { get; } = new List<System.Drawing.Image>();

        public void BeginTextBlock() { }

        public void EndTextBlock() { }

        public void RenderImage(ImageRenderInfo renderInfo)
        {
            var imageObject = renderInfo.GetImage();
            var image = imageObject.GetDrawingImage();
            Images.Add(image);
        }

        public void RenderText(TextRenderInfo renderInfo) { }
        
    }
        */


    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }
        string filepath;
        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse PDF Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "pdf",
                Filter = "PDF Files (*.pdf)|*.pdf",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                 textBox1.Text = openFileDialog1.SafeFileName;
                 filepath = openFileDialog1.FileName;
            }
        }
        public void fileCreate(string filepath) {
               
        
        
        }
        public void convertpdf(string inputPath, string outputPath)
        {
            GdPictureImaging oGdPictureImaging = new GdPictureImaging();
            GdPicturePDF oGdPicturePDF = new GdPicturePDF();
 
            GdPictureStatus status = oGdPicturePDF.LoadFromFile(inputPath, false); // pdf seçimi

            if (status != GdPictureStatus.OK) // pdf dosyası doğru şekilde yüklendi mi?
            {
                MessageBox.Show("PDF yüklenemiyor.. Error: " + status.ToString(), "Rasterization Example", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 1; i <= oGdPicturePDF.GetPageCount(); i++)
                {
                    
                    oGdPicturePDF.SelectPage(i); // sayfa seçimi
                    
                    int imageId = oGdPicturePDF.RenderPageToGdPictureImage(200, true); // seçilen sayfa renderlanma

                    if (oGdPicturePDF.GetStat() == GdPictureStatus.OK) // render kontrolü
                    {
                        string outputFilePath = Path.Combine(outputPath, $"output_page_{i}.png");

                        if (oGdPictureImaging.SaveAsPNG(imageId, outputFilePath) != GdPictureStatus.OK) // save işlemi
                        {
                            MessageBox.Show("PNG kaydedilirken hata oluştu. Error: " + oGdPicturePDF.GetStat().ToString(), "Rasterization Example", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            Console.WriteLine($"Kaydedilen dosya yolu ->{outputPath} ---- Kaydedilen png -> 'output_page_{i}.png' ");
                            //MessageBox.Show("tamamlandı", "Rasterization Example", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            oGdPictureImaging.ReleaseGdPictureImage(imageId);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Render işleminde hata oluştu. Error: " + oGdPicturePDF.GetStat().ToString(), "Rasterization Example", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
            oGdPictureImaging.Dispose();
            oGdPicturePDF.Dispose();
        }

        public void ConvertPdfToPng(string pdfFilePath, string pngFilePath, int dpi)
        {
            // PDF dosyasının var olup olmadığını kontrol edin
            if (!File.Exists(pdfFilePath))
            {
                throw new FileNotFoundException("PDF dosyası bulunamadı.", pdfFilePath);
            }
            /*
            // PNG dosyasının var olup olmadığını kontrol edin
            if (File.Exists(pngFilePath))
            {
                throw new IOException("PNG dosyası zaten var.");
            */

            // PDF dosyasını Ghostscript.NET kütüphanesi kullanarak yükleyin
            using (var rasterizer = new GhostscriptRasterizer())
            {
                rasterizer.Open(pdfFilePath);

                // PDF sayfa boyutunu alın
                var page = rasterizer.GetPage(dpi, 1);
                var width = page.Width;
                var height = page.Height;

                // PNG dosyasını oluşturun
                using (var bmp = new Bitmap((int)width, (int)height, PixelFormat.Format32bppArgb))
                {
                    // BMP görüntüsünü oluşturun
                    bmp.SetResolution(dpi, dpi);

                    // BMP görüntüsünü PNG'ye dönüştürmek için Graphics nesnesini kullanın
                    using (var gr = Graphics.FromImage(bmp))
                    {
                        gr.Clear(Color.Transparent);
                        gr.DrawImageUnscaled(page, 0, 0);
                    }

                    // PNG dosyasına kaydedin
                    bmp.Save(pngFilePath, ImageFormat.Png);
                }
            }
        }
        
        public void ConvertPdfToPngCALISIYORasposepdf(string inputFilePath, string outputFilePath)
        {
        /*
            // Load PDF document
            Document pdfDocument = new Document(inputFilePath);

            // Create Resolution object
            Resolution resolution = new Resolution(300);

            // Create PngDevice object with specified attributes
            PngDevice pngDevice = new PngDevice(resolution);

            // Convert each page of PDF document to PNG format
            for (int pageCount = 1; pageCount <= pdfDocument.Pages.Count; pageCount++)
            {
                // Set output file name with page number
                string outputFile = $"{outputFilePath}\\page_{pageCount}.png";

                // Convert page to PNG format
                pngDevice.Process(pdfDocument.Pages[pageCount], outputFile);
            }
        */
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            //bool v = true;
            var folderBrowserDialog1 = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string folderName = folderBrowserDialog1.SelectedPath;
            }

            Console.WriteLine(folderBrowserDialog1.SelectedPath + @"\pages"); 
            string dir = folderBrowserDialog1.SelectedPath + @"\pages";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            var fileName = filepath;
            convertpdf(filepath, dir);

        }

        private void EmptyPageOpen_Click(object sender, EventArgs e)
        {
            EmptyPage emptyPage = new EmptyPage();
            emptyPage.Show();
        }
    }
}
