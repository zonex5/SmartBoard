using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace SmartBoard
{
    public abstract class Figures
    {
        public abstract class Shape
        {
            protected Pen pen;

            public Shape(float x1, float y1, Color color, float width)
            {
                X1 = x1;
                Y1 = y1;

                pen = new Pen(color, width);
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;
            }

            public virtual void AddPoints(float x, float y)
            {
            }

            public float X1 { get; set; }

            public float X2 { get; set; }

            public float Y1 { get; set; }

            public float Y2 { get; set; }

            public abstract void Draw(Graphics gr);
        }

        public class Rectangle : Shape
        {
            public Rectangle(float x1, float y1, Color color, float width) : base(x1, y1, color, width)
            {
            }

            public override void Draw(Graphics gr)
            {
                gr.DrawRectangle(pen, X1, Y1, X2 - X1, Y2 - Y1);
            }
        }

        public class Circle : Shape
        {
            public Circle(float x1, float y1, Color color, float width) : base(x1, y1, color, width)
            {
            }

            public override void Draw(Graphics gr)
            {
                gr.DrawEllipse(pen, X1, Y1, X2 - X1, Y2 - Y1);
            }
        }

        public class Line : Shape
        {
            public Line(float x1, float y1, Color color, float width) : base(x1, y1, color, width)
            {
            }

            public override void Draw(Graphics gr)
            {
                gr.DrawLine(pen, X1, Y1, X2, Y2);
            }
        }

        public class Line2 : Shape
        {
            public Line2(float x1, float y1, Color color, float width) : base(x1, y1, color, width)
            {
                pen.DashStyle = DashStyle.Dash;
            }

            public override void Draw(Graphics gr)
            {
                gr.DrawLine(pen, X1, Y1, X2, Y2);
            }
        }

        public class Arrow : Shape
        {
            public Arrow(float x1, float y1, Color color, float width) : base(x1, y1, color, width)
            {
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.ArrowAnchor;
            }

            public override void Draw(Graphics gr)
            {
                gr.DrawLine(pen, X1, Y1, X2, Y2);
            }
        }

        public class Arrow2 : Shape
        {
            public Arrow2(float x1, float y1, Color color, float width) : base(x1, y1, color, width)
            {
                pen.StartCap = LineCap.ArrowAnchor;
                pen.EndCap = LineCap.ArrowAnchor;
            }

            public override void Draw(Graphics gr)
            {
                gr.DrawLine(pen, X1, Y1, X2, Y2);
            }
        }

        public class Pencil : Shape
        {
            private List<PointF> points = new List<PointF>();

            public Pencil(float x1, float y1, Color color, float width) : base(x1, y1, color, width)
            {
                AddPoints(x1, y1);
                AddPoints(x1 + 0.1f, y1);
                pen.LineJoin = LineJoin.Round;
            }

            public override void AddPoints(float x, float y)
            {                
                points.Add(new PointF(x, y));
            }

            public override void Draw(Graphics gr)
            {                
                if (points.Count > 1)
                    gr.DrawLines(pen, points.ToArray());
            }
        }

        public class Eraser : Shape
        {
            private List<PointF> points = new List<PointF>();

            public Eraser(float x1, float y1, Color color, float width) : base(x1, y1, color, width)
            {
                AddPoints(x1, y1);
                AddPoints(x1 + 0.1f, y1);
                pen.LineJoin = LineJoin.Round;
            }

            public override void AddPoints(float x, float y)
            {
                points.Add(new PointF(x, y));
            }

            public override void Draw(Graphics gr)
            {
                if (points.Count > 1)
                    gr.DrawLines(pen, points.ToArray());
            }
        }

        public class BackImage
        {
            Image img;

            public BackImage(string filename)
            {
                img = Image.FromFile(filename);
            }

            public BackImage(Image image)
            {
                img = (Image) image.Clone();
            }

            public void Draw(Graphics g)
            {
                g.DrawImage(img, 0, 0, g.VisibleClipBounds.Width, g.VisibleClipBounds.Height);                
            }

            public Image getImage()
            {
                return img;
            }
        }
    }
}
