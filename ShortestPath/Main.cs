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
        Color backgroundColor = Color.FromArgb(100, 100, 100);
        Pen penLightGray = new Pen(Color.LightGray, 2.0F);
        Pen penGreen = new Pen(Color.LightGreen, 2.0F);
        Pen penRed = new Pen(Color.PaleVioletRed, 2.0F);
        Pen penMinIndex = new Pen(Color.Blue, 2.0F);
        Pen penWhite = new Pen(Color.White, 2.0F);
        Font fontText = new Font("Impact", 12.0F);
        Random ran = new Random();
        int[] placesPositionX;
        int[] placesPositionY;
        int currentMoveCircle;
        bool mouseDown = false;
        bool allowMoveCircle = false;


        public Main()
        {
            InitializeComponent();
        }

        void DrawNewFrame2()
        {
            graphics.Clear(backgroundColor);

            double[] distance = new double[10];
            distance[0] = 10000;
            int amount = 1;

            while (amount <= placesPositionX.Length - 1)
            {
                distance[amount] = Math.Sqrt(Math.Pow(placesPositionX[amount] - placesPositionX[0], 2) + Math.Pow(placesPositionY[amount] - placesPositionY[0], 2));
                amount++;
            }

            double smallestPath = distance.Min();
            int minIndex = distance.ToList().IndexOf(smallestPath);

            // LINE
            graphics.DrawLine(penWhite,
                    placesPositionX[0],
                    placesPositionY[0],
                    placesPositionX[minIndex],
                    placesPositionY[minIndex]);

            //amount = 0;
            //// LINES
            //while(amount < placesPositionX.Length - 1)
            //{

            //    graphics.DrawLine(penWhite,
            //        placesPositionX[amount],
            //        placesPositionY[amount],
            //        placesPositionX[amount + 1],
            //        placesPositionY[amount + 1]);

            //    amount++;
            //}

            amount = 0;
            // DOTS
            while (amount <= placesPositionX.Length - 1)
            {
                if (amount == 0)
                {
                    graphics.DrawEllipse(penGreen, placesPositionX[amount], placesPositionY[amount], 1, 1);
                }
                else
                {
                    graphics.DrawEllipse(penLightGray, placesPositionX[amount], placesPositionY[amount], 1, 1);

                }
                amount++;
            }

            amount = 0;
            // CIRCLES
            while (amount <= placesPositionX.Length - 1)
            {
                if (amount == 0)
                {
                    // Start Circle (Green)
                    graphics.DrawEllipse(penGreen, placesPositionX[amount] - 9, placesPositionY[amount] - 9, 20, 20);
                }
                else
                {
                    if (amount == 9)
                    {
                        // End Circle (Red-ish)
                        graphics.DrawEllipse(penRed, placesPositionX[amount] - 9, placesPositionY[amount] - 9, 20, 20);
                    }
                    else
                    {
                        if (amount != minIndex)
                        {
                            graphics.DrawEllipse(penLightGray, placesPositionX[amount] - 9, placesPositionY[amount] - 9, 20, 20);
                        }
                        else
                        {
                            graphics.DrawEllipse(penMinIndex, placesPositionX[amount] - 9, placesPositionY[amount] - 9, 20, 20);
                        }
                    }
                }
                amount++;
            }

            graphicsOverride.DrawImage(bitmap, 0, 0, pictureBox.Width, pictureBox.Height);
        }

        void DrawNewFrame()
        {
            graphics.Clear(backgroundColor);

            
            double[] distance = new double[10];
            distance[0] = 10000;
            int amount = 1;

            while(amount <= placesPositionX.Length - 1)
            {
                distance[amount] = Math.Sqrt(Math.Pow(placesPositionX[amount] - placesPositionX[0], 2) + Math.Pow(placesPositionY[amount] - placesPositionY[0], 2));
                amount++;
            }

            List<double> distanceList = distance.OfType<double>().ToList();
            int[] minIndex = new int[3]; 
            amount = 0;
            while(amount < 3)
            {
                double smallestPath = distance.Min();
                minIndex[amount] = distanceList.IndexOf(smallestPath);
                distance[minIndex[amount]] = 10000;
                //distanceList.RemoveAt(minIndex[amount]);
                amount++;
            }

            //graphics.DrawString("BABA", fontText, Brushes.GreenYellow, 200, 200);

            // LINE
            //amount = 0;
            //while(amount < 3)
            //{
            //    graphics.DrawLine(penWhite,
            //        placesPositionX[0],
            //        placesPositionY[0],
            //        placesPositionX[minIndex[amount]],
            //        placesPositionY[minIndex[amount]]);
            //    amount++;
            //}

            amount = 0;
            while (amount < 10)
            {
                int amount2 = 0;
                while(amount2 < 10)
                {
                    graphics.DrawLine(penWhite,
                    placesPositionX[amount],
                    placesPositionY[amount],
                    placesPositionX[amount2],
                    placesPositionY[amount2]);
                    amount2++;
                }
                amount++;
            }

            //amount = 0;
            //// LINES
            //while(amount < placesPositionX.Length - 1)
            //{

            //    graphics.DrawLine(penWhite,
            //        placesPositionX[amount],
            //        placesPositionY[amount],
            //        placesPositionX[amount + 1],
            //        placesPositionY[amount + 1]);

            //    amount++;
            //}

            amount = 0;
            // DOTS
            while(amount <= placesPositionX.Length - 1)
            {
                if (amount == 0)
                {
                    graphics.DrawEllipse(penGreen, placesPositionX[amount], placesPositionY[amount], 1, 1);
                }
                else
                {
                    graphics.DrawEllipse(penLightGray, placesPositionX[amount], placesPositionY[amount], 1, 1);

                }
                amount++;
            }

            amount = 0;
            // CIRCLES
            while (amount <= placesPositionX.Length - 1)
            {
                if (amount == 0)
                {
                    // Start Circle (Green)
                    graphics.DrawEllipse(penGreen, placesPositionX[amount] - 9, placesPositionY[amount] - 9, 20, 20);
                }
                else
                {
                    if(amount == 9)
                    {
                        // End Circle (Red-ish)
                        graphics.DrawEllipse(penRed, placesPositionX[amount] - 9, placesPositionY[amount] - 9, 20, 20);
                    }
                    else
                    {
                        graphics.DrawEllipse(penLightGray, placesPositionX[amount] - 9, placesPositionY[amount] - 9, 20, 20);
                    }
                }
                amount++;
            }

            amount = 0;
            while(amount < 10)
            {
                graphics.DrawString(amount.ToString(), fontText, Brushes.GreenYellow, placesPositionX[amount] + 15, placesPositionY[amount]);
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
            if(allowMoveCircle == true)
            {
                int amount = 0;
                while (amount < 10)
                {
                    if (e.X > placesPositionX[amount] - 10 && e.X < placesPositionX[amount] + 10 && e.Y > placesPositionY[amount] - 10 && e.Y < placesPositionY[amount] + 10)
                    {
                        this.Text = "True " + amount;
                        currentMoveCircle = amount;
                        mouseDown = true;
                        break;
                    }
                    else
                    {
                        this.Text = "Not true";
                    }
                    amount++;
                }
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown == true)
            {
                if(currentMoveCircle <= 10 && currentMoveCircle >= 0)
                {
                    placesPositionX[currentMoveCircle] = e.X;
                    placesPositionY[currentMoveCircle] = e.Y;
                    DrawNewFrame();
                }
            }
            
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(keyData == Keys.E)
            {
                allowMoveCircle = true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        
        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Modifiers == Keys.E)
            {
                allowMoveCircle = true;
            }
        }

        private void Main_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Modifiers == Keys.E)
            {
                allowMoveCircle = false;
            }
        }

        private void pictureBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        }

        private void Main_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}
