using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartBoard
{
    public partial class HistoryForm : Form
    {
        List<PictureBox> pictures = new List<PictureBox>();
        List<Image> history;

        Point oldPosition = new Point();
        Point originalPosition = new Point();
        PictureBox currentBox;
        Boolean drag;
        Boolean moved;

        public Image ResultImage { get; set; }

        public HistoryForm(List<Image> h)
        {
            InitializeComponent();

            history = h;
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            pictures.Add(picture1);
            pictures.Add(picture2);
            pictures.Add(picture3);
            pictures.Add(picture4);
            pictures.Add(picture5);
            pictures.Add(picture6);
            pictures.Add(picture7);
            pictures.Add(picture8);
            pictures.Add(picture9);
            pictures.Add(picture10);
            pictures.Add(picture11);
            pictures.Add(picture12);
            pictures.Add(picture13);
            pictures.Add(picture14);
            pictures.Add(picture15);

            foreach (PictureBox p in pictures)
            {
                p.Image = null;
                p.BorderStyle = BorderStyle.None;
            }

            int i = 0;
            foreach (Image img in history)
            {
                pictures[i++].Image = img;
            }
        }

        private void HistoryForm_Leave(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResultImage = null;
            Close();
        }

        private void picture1_Click(object sender, EventArgs e)
        {
            if (moved) return;
            ResultImage = (sender as PictureBox).Image;
            //удалить из истории выбранный
            //history.RemoveAt(Convert.ToInt32(currentBox.Tag) - 1);

            Close();
        }

        private void picture8_MouseDown(object sender, MouseEventArgs e)
        {
            currentBox = sender as PictureBox;
            if (currentBox.Image == null) return;

            oldPosition = new Point(e.X, e.Y);
            originalPosition = new Point(currentBox.Location.X, currentBox.Location.Y);
            currentBox.BringToFront();
            drag = true;
            moved = false;
        }

        private void picture8_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                int dx = e.X - oldPosition.X;
                int dy = e.Y - oldPosition.Y;
                currentBox.Location = new Point(currentBox.Location.X + dx, currentBox.Location.Y + dy);

                if (Math.Abs(originalPosition.X - currentBox.Location.X) > 2 || Math.Abs(originalPosition.Y - currentBox.Location.Y) > 2)
                    moved = true;
                if (currentBox.Bounds.IntersectsWith(bt_Delete.Bounds))
                    currentBox.BackColor = Color.Red;
                else currentBox.BackColor = Color.White;
            }
        }

        private void picture8_MouseUp(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                if (currentBox.BackColor == Color.Red)
                {
                    Image image = history[Convert.ToInt32(currentBox.Tag) - 1];
                    image.Save(Application.LocalUserAppDataPath + "\\" + image.Tag.ToString()+".png", ImageFormat.Png);

                    //удалить                    
                    history.RemoveAt(Convert.ToInt32(currentBox.Tag) - 1);

                    //перечитать данные
                    foreach (PictureBox p in pictures)
                    {
                        p.Image = null;
                    }

                    int i = 0;
                    foreach (Image img in history)
                    {
                        pictures[i++].Image = img;
                    }
                }
                drag = false;
                moved = false;
                currentBox.Location = originalPosition;
                currentBox.BackColor = Color.White;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (history.Count > 0)
            {
                if (folder.ShowDialog() == DialogResult.OK)
                {
                    foreach (Image img in history)
                    {
                        img.Save(folder.SelectedPath + "\\" + img.Tag.ToString() + ".png", ImageFormat.Png);
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
