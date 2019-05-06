using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Platform.Windows;

namespace Графичекский_редактор_v2._0
{
    public partial class Form1 : Form
    {
        static int width, height; //Разеры поля для рисования 
        static Color color; //Выбранный цвет
        static int depth;   //Координата по z активного слоя
        static int old_X, old_Y, new_X, new_Y; //Для координат
        static Vertex[] vertexes;
        static Items tool;
        static int lineWidth;
        static byte activeLay;
        static Lay firstLay, secondLay;
        static bool isSaved;
        enum Items { brush, ellipse, rectangle, straight, eraser }


        //Считывать координаты
        private void glControl1_MouseMove(object sender, MouseEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            new_X = e.X;
            new_Y = e.Y;

            switch (tool)
            {
                case (Items.brush):
                    {
                        if (e.Button == MouseButtons.Left)
                        {
                            DrawActiveLay();
                            Brush();
                        }
                        break;
                    }
                case (Items.ellipse):
                    {
                        if (e.Button == MouseButtons.Left)
                        {
                            DrawActiveLay();
                            Ellipse();
                        }
                        break;
                    }
                case (Items.straight):
                    {
                        if (e.Button == MouseButtons.Left)
                        {
                            DrawActiveLay();
                            Straight();
                        }
                        break;
                    }
                case (Items.rectangle):
                    {
                        if (e.Button == MouseButtons.Left)
                        {
                            DrawActiveLay();
                            Rectangle();
                        }
                        break;
                    }
                case Items.eraser:
                    {
                        if (e.Button == MouseButtons.Left)
                        {
                            DrawActiveLay();
                            Eraser();
                        }
                        break;
                    }
            }
        }

        private void Rectangle()
        {
            GL.LineWidth(lineWidth);
            GL.Begin(BeginMode.LineLoop);
            GL.Color3(color);

            GL.Vertex3(new_X, old_Y, depth - 1);
            GL.Vertex3(old_X, old_Y, depth - 1);
            GL.Vertex3(old_X, new_Y, depth - 1);
            GL.Vertex3(new_X, new_Y, depth - 1);

            GL.End();
            GL.Flush();
            glControl1.SwapBuffers();
            glControl1.Invalidate();

        }
        private void Straight()
        {
            GL.LineWidth(lineWidth);
            GL.Begin(BeginMode.Lines);

            GL.Color3(color);
            GL.Vertex3(old_X, old_Y, depth - 1);
            GL.Vertex3(new_X, new_Y, depth - 1);

            GL.End();
            GL.Flush();
            glControl1.SwapBuffers();
            glControl1.Invalidate();
        }

        private void Ellipse()
        {
            GL.Color3(color);
            GL.LineWidth(lineWidth);
            GL.Begin(BeginMode.LineLoop);

            int xc = old_X / 2 + new_X / 2;
            int yc = old_Y / 2 + new_Y / 2;
            int a = Math.Abs(xc - new_X);
            int b = Math.Abs(yc - new_Y);

            for (double i = 0; i < 2 * Math.PI; i += 0.1)
            {
                GL.Vertex3(xc + a * Math.Cos(i), yc + b * Math.Sin(i), depth - 1);
            }

            GL.End();
            GL.Flush();
            glControl1.SwapBuffers();
            glControl1.Invalidate();
        }

        private void Eraser()
        {
            GL.LineWidth(lineWidth);
            GL.Begin(BeginMode.LineStrip);
            GL.Color3(Color.White);
            Array.Resize<Vertex>(ref vertexes, vertexes.Length + 1);
            vertexes[vertexes.Length - 1] = new Vertex(new_X, new_Y, depth);
            for (int i = 0; i < vertexes.Length; i++)
            {
                //BasicFigures.DrawCircle((int)vertexes[i].x,(int)vertexes[i].y,5,2, Color.Black);
                GL.Vertex3(vertexes[i].x, vertexes[i].y, depth - 1);
            }

            GL.End();
            GL.Flush();
            glControl1.SwapBuffers();
            glControl1.Invalidate();
        }
        private void DrawActiveLay()
        {
            switch (activeLay)
            {
                case 0:
                    {
                        firstLay.DrawLay();
                        secondLay.DrawLay();
                        break;
                    }
                case 1:
                    {
                        firstLay.DrawLay();
                        break;
                    }
                case 2:
                    {
                        secondLay.DrawLay();
                        break;
                    }
            }
        }
        private void Brush()
        {
            GL.LineWidth(lineWidth);
            GL.Begin(BeginMode.LineStrip);
            GL.Color3(color);
            Array.Resize<Vertex>(ref vertexes, vertexes.Length + 1);
            vertexes[vertexes.Length - 1] = new Vertex(new_X, new_Y, depth);
            for (int i = 0; i < vertexes.Length; i++)
            {
                //BasicFigures.DrawCircle((int)vertexes[i].x,(int)vertexes[i].y,5,2, Color.Black);
                GL.Vertex3(vertexes[i].x, vertexes[i].y, vertexes[i].z - 1);
            }

            GL.End();
            GL.Flush();
            glControl1.SwapBuffers();
            glControl1.Invalidate();

        }
        private void glControl1_MouseUp(object sender, MouseEventArgs e)
        {
            switch (tool)
            {
                case Items.brush:
                    {
                        Brush b = new Brush(vertexes, lineWidth, color);
                        if (activeLay == 1 || activeLay == 0)
                            firstLay.GetFigures.Add(b);
                        else
                            secondLay.GetFigures.Add(b);
                        vertexes = new Vertex[0];
                        break;
                    }
                case Items.ellipse:
                    {
                        int xc = old_X / 2 + new_X / 2;
                        int yc = old_Y / 2 + new_Y / 2;
                        int a = Math.Abs(xc - new_X);
                        int b = Math.Abs(yc - new_Y);

                        Ellipse el = new Ellipse(xc, yc, a, b, lineWidth, color);
                        if (activeLay == 1 || activeLay == 0)
                            firstLay.GetFigures.Add(el);
                        else
                            secondLay.GetFigures.Add(el);
                        break;
                    }
                case Items.rectangle:
                    {
                        Rectangle r = new _0.Rectangle(old_X, old_Y, new_X, new_Y, lineWidth, color);
                        if (activeLay == 1 || activeLay == 0)
                            firstLay.GetFigures.Add(r);
                        else
                            secondLay.GetFigures.Add(r);
                        break;
                    }
                case Items.straight:
                    {
                        Straight str = new _0.Straight(lineWidth, color, old_X, old_Y, new_X, new_Y);
                        if (activeLay == 1 || activeLay == 0)
                            firstLay.GetFigures.Add(str);
                        else
                            secondLay.GetFigures.Add(str);
                        break;
                    }
                case Items.eraser:
                    {
                        Brush eraser = new _0.Brush(vertexes, lineWidth, Color.White);
                        if (activeLay == 1)
                            firstLay.GetFigures.Add(eraser);
                        else
                            if (activeLay == 2)
                            secondLay.GetFigures.Add(eraser);
                        else
                        {
                            secondLay.GetFigures.Add(eraser);
                            firstLay.GetFigures.Add(eraser);
                        }
                        vertexes = new Vertex[0];
                            break;
                    }
            }
        }

        private void BrushButton_Click(object sender, EventArgs e)
        {
            tool = Items.brush;
        }

        private void glControl1_Load(object sender, EventArgs e)
        {
            GL.ClearColor(Color.White);
            GL.Enable(EnableCap.DepthTest);

            width = glControl1.Width;
            height = glControl1.Height;

            Camera.ChoseLay(0, width, height);  //Сначала показываем все слои
            Camera.SetModelView(width, height); //Настраиваем камеру для просмотра в центр
            firstLay = new Lay(5);
            secondLay = new Lay(15);

            color = Color.MediumSpringGreen;
            depth = 5;
            lineWidth = 1;

            vertexes = new Vertex[0];

        }
        private void RectButton_Click(object sender, EventArgs e)
        {
            tool = Items.rectangle;
        }
        private void СircleButton_Click(object sender, EventArgs e)
        {
            tool = Items.ellipse;
        }
        private void StraightButton_Click(object sender, EventArgs e)
        {
            tool = Items.straight;
        }
        private void glControl1_MouseDown(object sender, MouseEventArgs e)
        {
            old_X = e.X;
            old_Y = e.Y;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ok = colorDialog1.ShowDialog();
            if (ok.Equals(DialogResult.OK))
            {
                color = colorDialog1.Color;
            }

        }

        private void ChoseThickness_Scroll(object sender, EventArgs e)
        {
            lineWidth = ChoseThickness.Value;
        }

        private void showSecondLayButton_CheckedChanged(object sender, EventArgs e)
        {
            Camera.ChoseLay(2, width, height);
            Camera.SetModelView(width, height);

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            //DrawTriangle();
            activeLay = 2;
            DrawActiveLay();

            GL.Flush();
            glControl1.SwapBuffers();
            glControl1.Invalidate();
            depth = 15;               //Устанавливаем глубину слоя, на котором рисуем
        }

        private void showFirstLayButton_CheckedChanged(object sender, EventArgs e)
        {
            Camera.ChoseLay(1, width, height);
            Camera.SetModelView(width, height);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            //DrawTriangle();
            activeLay = 1;
            DrawActiveLay();

            GL.Flush();
            glControl1.SwapBuffers();
            glControl1.Invalidate();
            depth = 5;               //Устанавливаемглубину слоя, на котором рисуем
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void EraserButton_Click(object sender, EventArgs e)
        {
            tool = Items.eraser;
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(image);
            g.CopyFromScreen(PointToScreen(glControl1.Location), Point.Empty, glControl1.Size);
            if (!isSaved)
            {
                saveFileDialog1.Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif |JPG Image (.jpg)|*.jpg |Png Image (.png)|*.png ";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    image.Save(saveFileDialog1.FileName);
                    isSaved = true;
                }
            }
            else
            {
                image.Save(saveFileDialog1.FileName);
            }

        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(image);
            g.CopyFromScreen(PointToScreen(glControl1.Location), Point.Empty, glControl1.Size);
            saveFileDialog1.Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif |JPG Image (.jpg)|*.jpg |Png Image (.png)|*.png ";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                image.Save(saveFileDialog1.FileName, ImageFormat.Png);
                isSaved = true;
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Images (*.gif,*.tif,*.jpg,*.bpm)|*.gif;*.tif;*.jpg;*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap open = new Bitmap(openFileDialog1.FileName);
                Picture p = new Picture(1, Color.Transparent, open);

                firstLay.Clear();
                secondLay.Clear();

                if (activeLay == 1 || activeLay == 0)
                    firstLay.GetFigures.Add(p);
                else
                    secondLay.GetFigures.Add(p);
                DrawActiveLay();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void очиститьТекущийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (activeLay)
            {
                case 0:
                    {
                        firstLay.Clear();
                        break;
                    }
                case 1:
                    {
                        firstLay.Clear();
                        break;
                    }
                case 2:
                    {
                        secondLay.Clear();
                        break;
                    }
            }

            activeLay = 0;
            DrawActiveLay();
            GL.Flush();
            glControl1.SwapBuffers();
            glControl1.Invalidate();
        }

        private void очиститьОбаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            firstLay.Clear();
            secondLay.Clear();

            activeLay = 0;
            DrawActiveLay();
            GL.Flush();
            glControl1.SwapBuffers();
            glControl1.Invalidate();
        }

        private void showAllLaysButton_CheckedChanged(object sender, EventArgs e)
        {
            Camera.ChoseLay(0, width, height);
            Camera.SetModelView(width, height);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            //DrawTriangle();
            activeLay = 0;
            DrawActiveLay();

            GL.Flush();
            glControl1.SwapBuffers();
            glControl1.Invalidate();


            depth = 5;                 //Устанавливаем глубину слоя, на котором рисуем
        }

        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
        }

        public Form1()
        {
            InitializeComponent();
            //RenderTimer.Start();

        }


        private void RenderTimer_Tick(object sender, EventArgs e)
        {

        }

        private void DrawTriangle()
        {

            GL.Begin(BeginMode.Lines);

            GL.Color3(Color.Red); GL.Vertex3(0, 5, 5); GL.Vertex3(500, 5, 5);   //x - axis
            GL.Color3(Color.Green); GL.Vertex3(5, 0, 5); GL.Vertex3(5, 500, 5); //y - axis
            GL.Color3(Color.Blue); GL.Vertex3(0, 0, 5); GL.Vertex3(0, 0, 5);  //z - axis

            GL.Color3(Color.Red); GL.Vertex3(0, 495, 5); GL.Vertex3(500, 495, 5);
            GL.Color3(Color.Green); GL.Vertex3(495, 500, 5); GL.Vertex3(495, 0, 5);
            GL.End();

            GL.Begin(BeginMode.Triangles);
            GL.Color3(Color.Blue); GL.Vertex3(250, 50, 15);
            GL.Color3(Color.Red); GL.Vertex3(50, 500, 15);
            GL.Color3(Color.Green); GL.Vertex3(450, 500, 15);
            GL.End();

            GL.Flush();
            //glControl1.SwapBuffers();
            //glControl1.Invalidate();


        }

    }
}
