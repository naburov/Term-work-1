using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Графичекский_редактор_v2._0
{
    class Camera
    {
        public  static void ChoseLay(int layNunber, float width, float height)
        {
            int zNear, zFar;
            switch (layNunber)
            {
                
                //Отобразить все слои
                case 0:
                    {
                        zFar = 20; zNear = 0;
                        break;
                    }
                //Показать все слои
                case 1:
                    {
                        zFar = 10; zNear = 0;
                        break;
                    }
                case 2:
                    {
                        zFar = 20; zNear = 10;
                        break;
                    }
                default:
                    {
                        zFar = 20; zNear = 0;
                        break;
                    }
            }
            Matrix4 projection = Matrix4.CreateOrthographic(width, height, zNear, zFar);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref projection);
            GL.MatrixMode(MatrixMode.Projection);
            GL.Rotate(225, 0, 0, 1);
        }

        public static void SetModelView(int width, int height)
        {
            Matrix4 modelview = Matrix4.LookAt(width / 2, height / 2, -1, width / 2, height / 2, 30, 1, 1, 0);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref modelview);
        }
    }
}
