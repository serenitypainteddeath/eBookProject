using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Forms.UI.Controls;
using System.Windows.Ink;

namespace book
{
    public partial class EmptyPage : Form
    {
        private bool isEraserActive = false;
        private bool isPenActive = false;
        private bool isDrawing = false;
        private bool isErasing = false;
        private Point lastPoint;
        private int penSize = 5;
        private int eraserSize = 20;
        Color selectedColor = Color.Black;

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            // Kullanıcı fareyle tıkladığında çağrılır.
            lastPoint = e.Location;
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (isEraserActive == true)
                {
                    using (SolidBrush eraserBrush = new SolidBrush(canvas.BackColor))
                    {
                        using (Graphics g = canvas.CreateGraphics())
                        {
                            g.FillEllipse(eraserBrush, e.X - eraserSizeTrackBar.Value / 2, e.Y - eraserSizeTrackBar.Value / 2, eraserSizeTrackBar.Value, eraserSizeTrackBar.Value);
                        }
                    }
                }
                else if(isPenActive == true)
                {
                    using (Pen pen = new Pen(selectedColor, penSizeTrackBar.Value))
                    {
                        using (Graphics g = canvas.CreateGraphics())
                        {
                            g.DrawLine(pen, lastPoint, e.Location);
                        }
                    }
                    lastPoint = e.Location;
                }
            }
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            // Kullanıcı fareyle tıklamayı bıraktığında çağrılır.
            if (isDrawing)
            {
                isDrawing = false;
            }
            else if (isErasing)
            {
                isErasing = false;
            }
        }

        private void penSizeTrackBar_Scroll(object sender, EventArgs e)
        {
            // Kalem boyutu kaydırıcısı değeri değiştirildiğinde çağrılır.
            penSize = penSizeTrackBar.Value;
        }

        private void eraserSizeTrackBar_Scroll(object sender, EventArgs e)
        {
            // Silgi boyutu kaydırıcısı değeri değiştirildiğinde çağrılır.
            eraserSize = eraserSizeTrackBar.Value;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Temizle düğmesine tıklandığında çağrılır.
            Graphics g = canvas.CreateGraphics();
            g.Clear(Color.White);
        }
        private void eraserButton_Click(object sender, EventArgs e)
        {
            isPenActive = false;
            isEraserActive = true;
        }

        private void pencilButton_Click(object sender, EventArgs e)
        {
            isEraserActive = false;
            isPenActive = true;
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                selectedColor = colorDialog.Color;
            }
        }



    }
}
