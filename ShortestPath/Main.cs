using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShortestPath
{
    public partial class Main : Form
    {
        Bitmap bitmap;
        Graphics graphics;
        Graphics graphicsOverride;
        Color backgroundColor = Color.FromArgb(250, 250, 250);
        Pen pen = new Pen(Color.Red, 3.0F);
        Random ran = new Random();
        int[] placesPositionX;
        int[] placesPositionY;


        public Main()
        {
            InitializeComponent();
            
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Instance();
            DrawNewFrame();
        }

        void DrawNewFrame()
        {
            graphics.Clear(backgroundColor);

            int amount = 0;
            while(amount < placesPositionX.Length - 1)
            {
                graphics.DrawEllipse(pen, placesPositionX[amount], placesPositionY[amount], 20, 20);
                amount++;
            }

            graphicsOverride.DrawImage(bitmap, 0, 0, pictureBox.Width, pictureBox.Height);
        }

        void Instance()
        {
            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphicsOverride = pictureBox.CreateGraphics();
            placesPositionX = new int[10];
            placesPositionY = new int[10];

            int amount = 0;
            foreach(int num in placesPositionX)
            {
                placesPositionX[amount] = RandomNumber();
                amount++;
            }

            amount = 0;
            foreach (int num in placesPositionY)
            {
                placesPositionY[amount] = RandomNumber();
                amount++;
            }


        }

        int RandomNumber()
        {
            int ranNum = ran.Next(10, 400);
            return ranNum;
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            Instance();
            DrawNewFrame();
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            
        }
    }
}
