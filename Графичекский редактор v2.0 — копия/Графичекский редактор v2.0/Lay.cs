using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Графичекский_редактор_v2._0
{
    class Lay
    {
        int depth;
        List<Shape> figures;

        public List<Shape> GetFigures
        {
            get { return figures;}
            set { figures = value;}
        }

        public void DrawLay()
        {
            figures.Reverse();
            foreach (Shape sh in figures)
                sh.Draw(depth);
            figures.Reverse();
            
        }

        public Lay(int depth)
        {
            this.figures = new List<Shape>();
            this.depth = depth; 
        }

        public void Clear()
        {
            this.figures = new List<Shape>();
        } 
    }

    public class Vertex
    {
        public float x;
        public float y;
        public float z;

        public Vertex(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}
