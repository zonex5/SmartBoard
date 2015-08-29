using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace SmartBoard
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            width = 7;
            bt_Color.BackColor = Color.Black;
            Set_Sellected_Button(bt_Pencil, null);
            figure = bt_Pencil.Tag.ToString();

            eraser = new Cursor(Properties.Resources.ball.Handle);
            defaultCursor = picture.Cursor;
        }

        Cursor defaultCursor, eraser;

        /*** перетаскивание панели ***/
        bool MouseState = false;
        Point PrevMousePos;

        /*** рисование ***/
        private Figures.Shape _currentFigure;
        private List<Figures.Shape> _shapes = new List<Figures.Shape>();
        //private List<HistoryItem> history = new List<HistoryItem>();
        private List<Image> history = new List<Image>();
        private bool _isDrawing;
        private int width;
        private string figure;

        Figures.BackImage img;

        //*******************************************//
        private void points_MouseDown(object sender, MouseEventArgs e)
        {
            PrevMousePos = new Point(e.X, e.Y);
            if (e.Button == MouseButtons.Left) { this.MouseState = true; }
        }

        private void points_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) { this.MouseState = false; }
        }

        private void points_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.MouseState)
            {
                int dx = e.X - PrevMousePos.X;
                int dy = e.Y - PrevMousePos.Y;
                panel_toolbar.Location = new Point(panel_toolbar.Location.X + dx, panel_toolbar.Location.Y + dy);
                picture.Invalidate();
            }
        }

        /** Установка фона выбранной кнопки */
        private void Set_Sellected_Button(object sender, EventArgs e)
        {
            bt_Eraser.BackColor = Color.WhiteSmoke;
            bt_Pencil.BackColor = Color.WhiteSmoke;
            bt_Tool.BackColor = Color.WhiteSmoke;
            (sender as Button).BackColor = Color.FromArgb(144, 202, 249);
            figure = (sender as Button).Tag.ToString();
        }

        private void ToolButton_Click(object sender, EventArgs e)
        {
            Set_Sellected_Button(sender, e);
        }

        private void picture_MouseDown(object sender, MouseEventArgs e)
        {
            _isDrawing = true;

            switch (figure)
            {
                case "pencil":
                    _currentFigure = new Figures.Pencil(e.X, e.Y, bt_Color.BackColor, width);
                    picture.Invalidate();
                    break;
                case "eraser":
                    picture.Cursor = eraser;
                    _currentFigure = new Figures.Eraser(e.X, e.Y, Color.White, 30);
                    picture.Invalidate();
                    break;
                case "square":
                    _currentFigure = new Figures.Rectangle(e.X, e.Y, bt_Color.BackColor, width);
                    break;
                case "circle":
                    _currentFigure = new Figures.Circle(e.X, e.Y, bt_Color.BackColor, width);
                    break;
                case "line":
                    _currentFigure = new Figures.Line(e.X, e.Y, bt_Color.BackColor, width);
                    break;
                case "line2":
                    _currentFigure = new Figures.Line2(e.X, e.Y, bt_Color.BackColor, width);
                    break;
                case "arrow":
                    _currentFigure = new Figures.Arrow(e.X, e.Y, bt_Color.BackColor, width);
                    break;
                case "arrow2":
                    _currentFigure = new Figures.Arrow2(e.X, e.Y, bt_Color.BackColor, width);
                    break;
            }
        }

        private void picture_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDrawing)
            {
                _currentFigure.X2 = e.X;
                _currentFigure.Y2 = e.Y;
                _currentFigure.AddPoints(e.X, e.Y);
                picture.Invalidate();
            }
        }

        private void picture_MouseUp(object sender, MouseEventArgs e)
        {
            if (_isDrawing)
            {
                _shapes.Add(_currentFigure);
                _isDrawing = false;
                picture.Cursor = defaultCursor;
            }
        }

        private void bt_Rectangle_Click(object sender, EventArgs e)
        {
            bt_Tool.BackgroundImage = (sender as ToolStripMenuItem).Image;
            figure = (sender as ToolStripMenuItem).Tag.ToString();
        }

        private void Color_click(object sender, EventArgs e)
        {
            color_menu.Show(bt_Color, new Point(0, -color_menu.Height - 5));
            picture.Focus();
        }

        private void Color_changed(object sender, EventArgs e)
        {
            bt_Color.BackColor = (sender as ToolStripMenuItem).BackColor;
        }

        private void Brush_click(object sender, EventArgs e)
        {
            brush_menu.Show(bt_Brush, new Point(0, -brush_menu.Height - 5));
        }

        private void Figure_click(object sender, EventArgs e)
        {
            tool_menu.Show(bt_Tool, new Point(0, -tool_menu.Height - 5));
            Set_Sellected_Button(sender, e);
        }

        private void bt_Eraser_Click(object sender, EventArgs e)
        {
            Set_Sellected_Button(sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "*.JPG, *.PNG|*.jpg;*.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                //добавить в историю
                bt_window_Click(null, null);
                img = new Figures.BackImage(Image.FromFile(open.FileName));
                picture.Image = null;
                picture.Invalidate();
            }
        }

        private void Width_changed(object sender, EventArgs e)
        {
            width = Convert.ToInt32((sender as ToolStripMenuItem).Tag);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "*.PNG|*.png";
            save.FileName = "Picture";
            if (save.ShowDialog() == DialogResult.OK)
            {
                Bitmap canvas = new Bitmap(picture.ClientSize.Width, picture.ClientSize.Height);
                Graphics g = Graphics.FromImage(canvas);
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.CompositingQuality = CompositingQuality.HighQuality;
                //заливаем белым холст
                g.FillRectangle(new SolidBrush(Color.White), 0, 0, picture.Width, picture.Height);
                //проектируем фоновый рисунок
                if (img != null) img.Draw(g);
                //перерисуем всё на canvas
                foreach (var shape in _shapes)
                    shape.Draw(g);
                _currentFigure.Draw(g);
                canvas.Save(save.FileName, System.Drawing.Imaging.ImageFormat.Png);
                g.Dispose();
            }
        }

        /*** undo ***/
        private void button5_Click(object sender, EventArgs e)
        {
            if (_shapes.Count == 0) return;
            _shapes.RemoveAt(_shapes.Count - 1);
            picture.Invalidate();
        }

        /**Добавить в историю текущий рисунок */
        private void bt_window_Click(object sender, EventArgs e)
        {
            //проверим если есть хоть одна фигура кроме резинки
            bool allIsEraser = true;
            foreach (Figures.Shape sh in _shapes)
                if (!(sh is Figures.Eraser)) allIsEraser = false;

            //добавим в историю
            if (_shapes.Count > 0 && !allIsEraser)
            {
                Bitmap canvas = new Bitmap(picture.ClientSize.Width, picture.ClientSize.Height);
                Graphics g = Graphics.FromImage(canvas);
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.CompositingQuality = CompositingQuality.HighQuality;
                //заливаем белым холст
                g.FillRectangle(new SolidBrush(Color.White), 0, 0, picture.Width, picture.Height);
                //проектируем фоновый рисунок
                if (img != null) img.Draw(g);
                //перерисуем всё на canvas
                foreach (var shape in _shapes)
                    shape.Draw(g);
                _currentFigure.Draw(g);
                history.Insert(0, canvas);
                canvas.Tag = DateTime.Now.ToString("d-MM-yyyy HH-mm-ss");
            }
            if (history.Count > 15)
            {
                Image image = history[history.Count-1];
                image.Save(Application.LocalUserAppDataPath + "\\" + image.Tag.ToString() + ".png", ImageFormat.Png);
                history.RemoveAt(history.Count-1);
            }

            //сотрём холст
            _shapes.Clear();
            img = null;
            picture.Invalidate();
        }

        private void bt_windows_Click(object sender, EventArgs e)
        {
            HistoryForm form = new HistoryForm(history);
            form.ShowDialog();
            if (form.ResultImage != null)
            {
                // выбран рисунок, сохраняем старый, показываем новый
                bt_window_Click(null, null);
                img = new Figures.BackImage(form.ResultImage);
                form.Dispose();
                picture.Invalidate();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Завершить работу программы?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void picture_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            if (img != null) img.Draw(e.Graphics);

            foreach (var shape in _shapes)
                shape.Draw(e.Graphics);
            if (_isDrawing)
                _currentFigure.Draw(e.Graphics);
        }
    }
}
