using System.Windows.Forms;

namespace CompProject_Reflect
{
    public class Canvas : Panel
    {
        public Canvas()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;
        }
    }
}