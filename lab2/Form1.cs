using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        private UCDLRAOCI myclass = new UCDLRAOCI();
        public Form1()
        {
            InitializeComponent();
        }
        //открыть картинку

        private string OpenFile()
        {
            string fileName = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = ("Файлы изображений | *.jpg; *.jpeg; *.jpe; *.jfif; *.png");
            var result = openFileDialog.ShowDialog(); // открытие диалога выбора файла            
            if (result == DialogResult.OK) // открытие выбранного файла
            {
                fileName = openFileDialog.FileName;                
            }
            return fileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myclass.Source(OpenFile());
            imageBox1.Image = myclass.sourceImage;
            imageBox2.Image = myclass.sourceImage;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            myclass.SourceSecond(OpenFile());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            imageBox2.Image = myclass.Chanel(0);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            imageBox2.Image = myclass.Chanel(1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            imageBox2.Image = myclass.Chanel(2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            imageBox2.Image = myclass.Monochrome();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            imageBox2.Image = myclass.Brightness_Contrast(trackBar2.Value, trackBar1.Value / 10);
        }       
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            imageBox2.Image = myclass.Brightness_Contrast(trackBar2.Value, trackBar1.Value/ 10);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            imageBox2.Image = myclass.Sepia();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            imageBox2.Image = myclass.ConvertToHsv();
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            imageBox2.Image = myclass.Addition(trackBar6.Value,trackBar7.Value);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            imageBox2.Image = myclass.Subtraction(trackBar6.Value, trackBar7.Value);
        }


        private void button11_Click(object sender, EventArgs e)
        {
            imageBox2.Image = myclass.IDK();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            imageBox2.Image = myclass.median();            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            imageBox2.Image = myclass.Sharp();
            //int[,] w = new int[3, 3]
            //{
            //    { -1, -1, -1},
            //    { -1,  9, -1},
            //    { -1, -1, -1},
            //};
            //imageBox2.Image = myclass.MatFlt(w);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            imageBox2.Image = myclass.embos();
            //int[,] w = new int[3, 3]
            //{
            //    { -4, -2, 0},
            //    { -2,  1, 2},
            //    { 0, 2, 4},
            //};
            //imageBox2.Image = myclass.MatFlt(w);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            myclass.MainImage();
            trackBar1.Value = 10;
            trackBar2.Value = 0;
            trackBar3.Value = 1;
            trackBar6.Value = 5;
            trackBar7.Value = 5;
            imageBox2.Image = myclass.MainImageExp;
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            imageBox2.Image = myclass.Nars();
            //int[,] w = new int[3, 3]
            //{
            //    { 0, -2, 0},
            //    { -2, 4, 0},
            //    { 0, 0, 0},
            //};
            //imageBox2.Image = myclass.MatFlt(w);
        }

        private void button17_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = ("Файлы изображений | *.jpg; *.jpeg; *.jpe; *.jfif; *.png");
            var result = saveFileDialog.ShowDialog(); // открытие диалога выбора файла            
            if (result == DialogResult.OK) // открытие выбранного файла
            {
                string fileName = saveFileDialog.FileName;
                myclass.saveJpeg(fileName); 
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            imageBox2.Image = myclass.MatFlt(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox1.Text),
                                             Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox1.Text),
                                             Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox1.Text));
        }

        private void button19_Click(object sender, EventArgs e)
        {
            myclass.median();
            myclass.SourceSecond(OpenFile());
            imageBox2.Image = myclass.Addition(trackBar6.Value, trackBar7.Value);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            myclass.Monochrome();
            myclass.median();
            myclass.BinarPrg(trackBar8.Value);
            myclass.SourceSecond(myclass.MainImageExp);
            myclass.MainImage();
            imageBox2.Image = myclass.Addition(trackBar6.Value, trackBar7.Value);
        }


        private void button21_Click_1(object sender, EventArgs e)
        {
            trackBar1.Value = 10;
            trackBar2.Value = 0;
            myclass.confirm();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            
            myclass.SourceSecond("C:\\Users\\игорь\\Desktop\\top1.jpg");
            myclass.Monochrome();
            myclass.median();
            imageBox2.Image = myclass.Addition(7, 3);
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            imageBox2.Image = myclass.ConvertToHsv(trackBar3.Value);
        }
    }
}