using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System.Drawing;

namespace Графичекский_редактор_v2._0
{
    public abstract class Shape
    {
        public int lineWidth;
        public Color color;
        public abstract void Draw(int depth);
        public Shape(int lineWidth, Color color)
        {
            this.lineWidth = lineWidth;
            this.color = color;
        }
    }

    class Brush : Shape
    {
        Vertex[] vertexes;

        public Brush(Vertex[] vertexes, int lineWidth, Color color) : base(lineWidth, color)
        {
            this.vertexes = vertexes;

        }
        public override void Draw(int depth)
        {
            GL.LineWidth(lineWidth);
            GL.Color3(color);
            GL.Begin(BeginMode.LineStrip);
            for (int i = 0; i < vertexes.Length; i++)
            {
                GL.Vertex3(vertexes[i].x, vertexes[i].y, depth);
            }
            GL.End();
        }
    }

    class Straight : Shape
    {
        int beg_X, beg_Y, end_X, end_Y;

        public Straight(int lineWidth, Color color, int bx, int by, int ex, int ey) : base(lineWidth, color)
        {
            beg_X = bx;
            beg_Y = by;
            end_X = ex;
            end_Y = ey;
        }
        public override void Draw(int depth)
        {
            GL.Color3(color);
            GL.LineWidth(lineWidth);
            GL.Begin(BeginMode.Lines);
            GL.Vertex3(beg_X, beg_Y, depth);
            GL.Vertex3(end_X, end_Y, depth);
            GL.End();
        }
    }

    class Ellipse : Shape
    {
        int xc, yc; 
        int a, b;

        public Ellipse(int xc, int yc, int a, int b, int lineWidth, Color color) : base(lineWidth, color)
        {
            this.xc = xc;
            this.yc = yc;
            this.a = a;
            this.b = b;
        }

        public override void Draw(int depth)
        {
            GL.Color3(color);
            GL.LineWidth(lineWidth);
            GL.Begin(BeginMode.LineLoop);
            for (double i = 0; i < 2 * Math.PI; i += 0.1)
            {
                GL.Vertex3(xc + a * Math.Cos(i), yc + b * Math.Sin(i), depth);
            }
            GL.End();

        }
    }

    class Rectangle : Shape
    {
        int old_X;
        int old_Y;
        int new_X;
        int new_Y;

        public Rectangle(int old_X, int old_Y, int new_X, int new_Y, int lineWidth, Color color) : base(lineWidth, color)
        {
            this.old_X = old_X;
            this.old_Y = old_Y;
            this.new_X = new_X;
            this.new_Y = new_Y;
        }
        public override void Draw(int depth)
        {
            GL.Color3(color);
            GL.LineWidth(lineWidth);
            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(new_X, old_Y, depth);
            GL.Vertex3(old_X, old_Y, depth);
            GL.Vertex3(old_X, new_Y, depth);
            GL.Vertex3(new_X, new_Y, depth);
            GL.End();
        }
    }

    class Picture : Shape
    {
        Color[,] pixels;
         
        public Picture(int lineWidth, Color color, Bitmap bmp) : base(lineWidth, color)
        {
            pixels = new Color[bmp.Width, bmp.Height];
            for (int x = 0; x < bmp.Width; x++)
                for (int y = 0; y < bmp.Height; y++)
                    pixels[x, y] = bmp.GetPixel(x, y);
        }

        public override void Draw(int depth)
        {
            GL.Begin(BeginMode.Points);
            for (int x = 0; x < pixels.GetLength(0); x++)
                for (int y = 0; y < pixels.GetLength(1); y++)
                {
                    GL.Color3(pixels[x, y]);
                    GL.Vertex3(x, y, depth);
                }
            GL.End();
        }
    }
}
