using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

/// <summary>
/// Cameron Cardiff, Corona Borelias Constelltion Greeting Card 
/// September 21st, 2016
/// </summary>
namespace Cameron_Summitive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {   // setting graphics
            Graphics formGraphics = this.CreateGraphics();
            Pen drawPen = new Pen(Color.White, 10);
            SolidBrush titleBrush = new SolidBrush(Color.Black);
            Font titleFont = new Font("Arial", 16, FontStyle.Bold);

            // creating foreground for greeting
            formGraphics.Clear(Color.Black);
            formGraphics.DrawImage(Properties.Resources.crown, 0, 0, 500, 390);

            // titles
            formGraphics.DrawString("Constelltion: Corona Borelias", titleFont, titleBrush, 15, 30);
            formGraphics.DrawString("By: Cameron Cardiff", titleFont, titleBrush, 15, 350);
            // titles
            formGraphics.TranslateTransform(240, 35);
            formGraphics.RotateTransform(90);
            formGraphics.DrawString("Unit 1: Final Summitive", titleFont, titleBrush, -10, -250);
            formGraphics.ResetTransform();

            Thread.Sleep(4000);
            Refresh();

            // new pen and brush for constellation and clean background
            Pen conPen = new Pen(Color.White, 5);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            formGraphics.Clear(Color.Black);

            // Drawing dots for constellation and plating ding.wav
            SoundPlayer ding = new SoundPlayer(Properties.Resources.ding);
            ding.Play();
            Thread.Sleep(100);
            formGraphics.FillEllipse(whiteBrush, 140, 39, 15, 15);
            Thread.Sleep(1000);
            ding.Play();
            formGraphics.FillEllipse(whiteBrush, 140, 134, 15, 15);
            Thread.Sleep(1000);
            ding.Play();
            formGraphics.FillEllipse(whiteBrush, 191, 176, 15, 15);
            Thread.Sleep(1000);
            ding.Play();
            formGraphics.FillEllipse(whiteBrush, 242, 176, 15, 15);
            Thread.Sleep(1000);
            ding.Play();
            formGraphics.FillEllipse(whiteBrush, 297, 170, 15, 15);
            Thread.Sleep(1000);
            ding.Play();
            formGraphics.FillEllipse(whiteBrush, 360, 117, 15, 15);
            Thread.Sleep(1000);
            ding.Play();
            formGraphics.FillEllipse(whiteBrush, 348, 39, 15, 15);
            Thread.Sleep(1000);

            // Lines showing constellation 
            formGraphics.DrawLine(conPen, 146, 39, 144, 138);
            Thread.Sleep(500);
            formGraphics.DrawLine(conPen, 144, 138, 191, 179);
            Thread.Sleep(500);
            formGraphics.DrawLine(conPen, 191, 185, 242, 185);
            Thread.Sleep(500);
            formGraphics.DrawLine(conPen, 242, 185  , 299, 179);
            Thread.Sleep(500);
            formGraphics.DrawLine(conPen, 299, 179, 368, 125);
            Thread.Sleep(500);
            formGraphics.DrawLine(conPen, 368, 119, 353, 39);

            SolidBrush descBrush = new SolidBrush(Color.White);
            Font descFont = new Font("Times New Roman", 9, FontStyle.Bold);
            
            formGraphics.DrawString("Corona Borealis is a small constellation in the Northern Celestial Hemisphere. It is one of the 48 ", descFont, descBrush, 0, 250);
            formGraphics.DrawString("constellations listed by the 2nd - century astronomer Ptolemy, and remains one of the 88 modern", descFont, descBrush, 0, 260);
            formGraphics.DrawString("constellations. Its brightest stars form a semicircular arc. Its Latin name, inspired by its shape,", descFont, descBrush, 0, 270);
            formGraphics.DrawString("means northern crown.  In classical mythology Corona Borealis generally represented the crown given", descFont, descBrush, 0, 280);
            formGraphics.DrawString("by the god Dionysus to the Cretan princess Ariadne and set by him in the heavens. Other cultures ", descFont, descBrush, 0, 290);
            formGraphics.DrawString("likened the pattern to a circle of elders, an eagle's nest, a bear's den, or even a smokehole. ", descFont, descBrush, 0, 300);
            formGraphics.DrawString("Ptolemy also listed a southern counterpart, Corona Australis, with a similar pattern. ", descFont, descBrush, 0,310);
        }

    }
}

