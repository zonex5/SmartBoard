namespace SmartBoard
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tool_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bt_Rectangle = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_Circle = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_Arrow = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_Arrow2 = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_Line = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_Line2 = new System.Windows.Forms.ToolStripMenuItem();
            this.color_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_toolbar = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_windows = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.points = new System.Windows.Forms.Panel();
            this.bt_window = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.bt_Eraser = new System.Windows.Forms.Button();
            this.bt_Pencil = new System.Windows.Forms.Button();
            this.bt_Tool = new System.Windows.Forms.Button();
            this.bt_Brush = new System.Windows.Forms.Button();
            this.bt_Color = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.brush_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.top = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tool_menu.SuspendLayout();
            this.color_menu.SuspendLayout();
            this.panel_toolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.brush_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tool_menu
            // 
            this.tool_menu.AutoSize = false;
            this.tool_menu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tool_menu.DropShadowEnabled = false;
            this.tool_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bt_Rectangle,
            this.bt_Circle,
            this.bt_Arrow,
            this.bt_Arrow2,
            this.bt_Line,
            this.bt_Line2});
            this.tool_menu.Name = "tool_menu";
            this.tool_menu.ShowItemToolTips = false;
            this.tool_menu.Size = new System.Drawing.Size(28, 140);
            // 
            // bt_Rectangle
            // 
            this.bt_Rectangle.AutoSize = false;
            this.bt_Rectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_Rectangle.Image = global::SmartBoard.Properties.Resources.square;
            this.bt_Rectangle.Name = "bt_Rectangle";
            this.bt_Rectangle.Size = new System.Drawing.Size(27, 22);
            this.bt_Rectangle.Tag = "square";
            this.bt_Rectangle.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.bt_Rectangle.Click += new System.EventHandler(this.bt_Rectangle_Click);
            // 
            // bt_Circle
            // 
            this.bt_Circle.AutoSize = false;
            this.bt_Circle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_Circle.Image = global::SmartBoard.Properties.Resources.cerc;
            this.bt_Circle.Name = "bt_Circle";
            this.bt_Circle.Size = new System.Drawing.Size(27, 22);
            this.bt_Circle.Tag = "circle";
            this.bt_Circle.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.bt_Circle.Click += new System.EventHandler(this.bt_Rectangle_Click);
            // 
            // bt_Arrow
            // 
            this.bt_Arrow.AutoSize = false;
            this.bt_Arrow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_Arrow.Image = global::SmartBoard.Properties.Resources.arrow;
            this.bt_Arrow.Name = "bt_Arrow";
            this.bt_Arrow.Size = new System.Drawing.Size(27, 22);
            this.bt_Arrow.Tag = "arrow";
            this.bt_Arrow.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.bt_Arrow.Click += new System.EventHandler(this.bt_Rectangle_Click);
            // 
            // bt_Arrow2
            // 
            this.bt_Arrow2.AutoSize = false;
            this.bt_Arrow2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_Arrow2.Image = global::SmartBoard.Properties.Resources.arrow2;
            this.bt_Arrow2.Name = "bt_Arrow2";
            this.bt_Arrow2.Size = new System.Drawing.Size(27, 22);
            this.bt_Arrow2.Tag = "arrow2";
            this.bt_Arrow2.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.bt_Arrow2.Click += new System.EventHandler(this.bt_Rectangle_Click);
            // 
            // bt_Line
            // 
            this.bt_Line.AutoSize = false;
            this.bt_Line.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_Line.Image = global::SmartBoard.Properties.Resources.line;
            this.bt_Line.Name = "bt_Line";
            this.bt_Line.Size = new System.Drawing.Size(27, 22);
            this.bt_Line.Tag = "line";
            this.bt_Line.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.bt_Line.Click += new System.EventHandler(this.bt_Rectangle_Click);
            // 
            // bt_Line2
            // 
            this.bt_Line2.AutoSize = false;
            this.bt_Line2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_Line2.Image = global::SmartBoard.Properties.Resources.line2;
            this.bt_Line2.Name = "bt_Line2";
            this.bt_Line2.Size = new System.Drawing.Size(27, 22);
            this.bt_Line2.Tag = "line2";
            this.bt_Line2.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.bt_Line2.Click += new System.EventHandler(this.bt_Rectangle_Click);
            // 
            // color_menu
            // 
            this.color_menu.AutoSize = false;
            this.color_menu.DropShadowEnabled = false;
            this.color_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem1,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8});
            this.color_menu.Name = "color_menu";
            this.color_menu.ShowImageMargin = false;
            this.color_menu.Size = new System.Drawing.Size(28, 180);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.AutoSize = false;
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.Black;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(27, 22);
            this.toolStripMenuItem2.Click += new System.EventHandler(this.Color_changed);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.AutoSize = false;
            this.toolStripMenuItem3.BackColor = System.Drawing.Color.DarkGray;
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.DimGray;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(27, 22);
            this.toolStripMenuItem3.Click += new System.EventHandler(this.Color_changed);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.AutoSize = false;
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.OrangeRed;
            this.toolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(27, 22);
            this.toolStripMenuItem1.Click += new System.EventHandler(this.Color_changed);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.AutoSize = false;
            this.toolStripMenuItem4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(202)))), ((int)(((byte)(24)))));
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(27, 22);
            this.toolStripMenuItem4.Click += new System.EventHandler(this.Color_changed);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.AutoSize = false;
            this.toolStripMenuItem5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(91)))));
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(27, 22);
            this.toolStripMenuItem5.Click += new System.EventHandler(this.Color_changed);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.AutoSize = false;
            this.toolStripMenuItem6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(216)))), ((int)(((byte)(139)))));
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(27, 22);
            this.toolStripMenuItem6.Click += new System.EventHandler(this.Color_changed);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.AutoSize = false;
            this.toolStripMenuItem7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(131)))), ((int)(((byte)(215)))));
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(27, 22);
            this.toolStripMenuItem7.Click += new System.EventHandler(this.Color_changed);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.AutoSize = false;
            this.toolStripMenuItem8.BackColor = System.Drawing.Color.SkyBlue;
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(27, 22);
            this.toolStripMenuItem8.Click += new System.EventHandler(this.Color_changed);
            // 
            // panel_toolbar
            // 
            this.panel_toolbar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_toolbar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_toolbar.BackgroundImage = global::SmartBoard.Properties.Resources.panel2;
            this.panel_toolbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_toolbar.Controls.Add(this.button3);
            this.panel_toolbar.Controls.Add(this.button2);
            this.panel_toolbar.Controls.Add(this.bt_windows);
            this.panel_toolbar.Controls.Add(this.button4);
            this.panel_toolbar.Controls.Add(this.button1);
            this.panel_toolbar.Controls.Add(this.points);
            this.panel_toolbar.Controls.Add(this.bt_window);
            this.panel_toolbar.Controls.Add(this.button6);
            this.panel_toolbar.Controls.Add(this.button12);
            this.panel_toolbar.Controls.Add(this.button9);
            this.panel_toolbar.Controls.Add(this.button5);
            this.panel_toolbar.Controls.Add(this.button11);
            this.panel_toolbar.Controls.Add(this.bt_Eraser);
            this.panel_toolbar.Controls.Add(this.bt_Pencil);
            this.panel_toolbar.Controls.Add(this.bt_Tool);
            this.panel_toolbar.Controls.Add(this.bt_Brush);
            this.panel_toolbar.Controls.Add(this.bt_Color);
            this.panel_toolbar.Location = new System.Drawing.Point(12, 361);
            this.panel_toolbar.Name = "panel_toolbar";
            this.panel_toolbar.Size = new System.Drawing.Size(340, 36);
            this.panel_toolbar.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::SmartBoard.Properties.Resources.exit;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(291, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 26);
            this.button3.TabIndex = 15;
            this.button3.Tag = "eraser";
            this.toolTip1.SetToolTip(this.button3, "Завершить работу");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::SmartBoard.Properties.Resources.delim;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(285, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(5, 26);
            this.button2.TabIndex = 14;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // bt_windows
            // 
            this.bt_windows.BackColor = System.Drawing.Color.Transparent;
            this.bt_windows.BackgroundImage = global::SmartBoard.Properties.Resources.windows;
            this.bt_windows.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_windows.FlatAppearance.BorderSize = 0;
            this.bt_windows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_windows.Location = new System.Drawing.Point(258, 5);
            this.bt_windows.Name = "bt_windows";
            this.bt_windows.Size = new System.Drawing.Size(26, 26);
            this.bt_windows.TabIndex = 13;
            this.bt_windows.Tag = "eraser";
            this.toolTip1.SetToolTip(this.bt_windows, "Окрыть историю");
            this.bt_windows.UseVisualStyleBackColor = false;
            this.bt_windows.Click += new System.EventHandler(this.bt_windows_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::SmartBoard.Properties.Resources.delim;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.Enabled = false;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(226, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(5, 26);
            this.button4.TabIndex = 13;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::SmartBoard.Properties.Resources.delim;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(81, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(5, 26);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // points
            // 
            this.points.BackgroundImage = global::SmartBoard.Properties.Resources.points;
            this.points.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.points.Location = new System.Drawing.Point(319, 2);
            this.points.Name = "points";
            this.points.Size = new System.Drawing.Size(16, 32);
            this.points.TabIndex = 1;
            this.points.MouseDown += new System.Windows.Forms.MouseEventHandler(this.points_MouseDown);
            this.points.MouseMove += new System.Windows.Forms.MouseEventHandler(this.points_MouseMove);
            this.points.MouseUp += new System.Windows.Forms.MouseEventHandler(this.points_MouseUp);
            // 
            // bt_window
            // 
            this.bt_window.BackColor = System.Drawing.Color.Transparent;
            this.bt_window.BackgroundImage = global::SmartBoard.Properties.Resources.window;
            this.bt_window.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_window.FlatAppearance.BorderSize = 0;
            this.bt_window.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_window.Location = new System.Drawing.Point(232, 5);
            this.bt_window.Name = "bt_window";
            this.bt_window.Size = new System.Drawing.Size(26, 26);
            this.bt_window.TabIndex = 11;
            this.bt_window.Tag = "eraser";
            this.toolTip1.SetToolTip(this.bt_window, "Очистить доску");
            this.bt_window.UseVisualStyleBackColor = false;
            this.bt_window.Click += new System.EventHandler(this.bt_window_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::SmartBoard.Properties.Resources.save;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(199, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(26, 26);
            this.button6.TabIndex = 6;
            this.toolTip1.SetToolTip(this.button6, "Сохранить");
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button12
            // 
            this.button12.BackgroundImage = global::SmartBoard.Properties.Resources.delim;
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button12.Enabled = false;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(167, 5);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(5, 26);
            this.button12.TabIndex = 11;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.BackgroundImage = global::SmartBoard.Properties.Resources.open;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(173, 5);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(26, 26);
            this.button9.TabIndex = 9;
            this.toolTip1.SetToolTip(this.button9, "Открыть");
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::SmartBoard.Properties.Resources.back;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(140, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(26, 26);
            this.button5.TabIndex = 5;
            this.toolTip1.SetToolTip(this.button5, "Шаг назад");
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button11
            // 
            this.button11.BackgroundImage = global::SmartBoard.Properties.Resources.delim;
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button11.Enabled = false;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(134, 5);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(5, 26);
            this.button11.TabIndex = 10;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // bt_Eraser
            // 
            this.bt_Eraser.BackColor = System.Drawing.Color.Transparent;
            this.bt_Eraser.BackgroundImage = global::SmartBoard.Properties.Resources.eraser;
            this.bt_Eraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_Eraser.FlatAppearance.BorderSize = 0;
            this.bt_Eraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Eraser.Location = new System.Drawing.Point(2, 5);
            this.bt_Eraser.Name = "bt_Eraser";
            this.bt_Eraser.Size = new System.Drawing.Size(26, 26);
            this.bt_Eraser.TabIndex = 10;
            this.bt_Eraser.Tag = "eraser";
            this.toolTip1.SetToolTip(this.bt_Eraser, "Ластик");
            this.bt_Eraser.UseVisualStyleBackColor = false;
            this.bt_Eraser.Click += new System.EventHandler(this.bt_Eraser_Click);
            // 
            // bt_Pencil
            // 
            this.bt_Pencil.BackgroundImage = global::SmartBoard.Properties.Resources.pencil;
            this.bt_Pencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_Pencil.FlatAppearance.BorderSize = 0;
            this.bt_Pencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Pencil.Location = new System.Drawing.Point(28, 5);
            this.bt_Pencil.Name = "bt_Pencil";
            this.bt_Pencil.Size = new System.Drawing.Size(26, 26);
            this.bt_Pencil.TabIndex = 8;
            this.bt_Pencil.Tag = "pencil";
            this.toolTip1.SetToolTip(this.bt_Pencil, "Карандаш");
            this.bt_Pencil.UseVisualStyleBackColor = true;
            this.bt_Pencil.Click += new System.EventHandler(this.ToolButton_Click);
            // 
            // bt_Tool
            // 
            this.bt_Tool.BackgroundImage = global::SmartBoard.Properties.Resources.square;
            this.bt_Tool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_Tool.FlatAppearance.BorderSize = 0;
            this.bt_Tool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Tool.Location = new System.Drawing.Point(54, 5);
            this.bt_Tool.Name = "bt_Tool";
            this.bt_Tool.Size = new System.Drawing.Size(26, 26);
            this.bt_Tool.TabIndex = 1;
            this.bt_Tool.Tag = "square";
            this.toolTip1.SetToolTip(this.bt_Tool, "Фигура");
            this.bt_Tool.UseVisualStyleBackColor = false;
            this.bt_Tool.Click += new System.EventHandler(this.Figure_click);
            // 
            // bt_Brush
            // 
            this.bt_Brush.BackgroundImage = global::SmartBoard.Properties.Resources.brush;
            this.bt_Brush.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_Brush.FlatAppearance.BorderSize = 0;
            this.bt_Brush.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Brush.Location = new System.Drawing.Point(107, 5);
            this.bt_Brush.Name = "bt_Brush";
            this.bt_Brush.Size = new System.Drawing.Size(26, 26);
            this.bt_Brush.TabIndex = 3;
            this.bt_Brush.Tag = "arrow";
            this.toolTip1.SetToolTip(this.bt_Brush, "Толщина кисти");
            this.bt_Brush.UseVisualStyleBackColor = true;
            this.bt_Brush.Click += new System.EventHandler(this.Brush_click);
            // 
            // bt_Color
            // 
            this.bt_Color.BackColor = System.Drawing.Color.OrangeRed;
            this.bt_Color.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Color.Location = new System.Drawing.Point(87, 8);
            this.bt_Color.Name = "bt_Color";
            this.bt_Color.Size = new System.Drawing.Size(20, 20);
            this.bt_Color.TabIndex = 2;
            this.bt_Color.Tag = "";
            this.toolTip1.SetToolTip(this.bt_Color, "Цвет кисти");
            this.bt_Color.UseVisualStyleBackColor = false;
            this.bt_Color.Click += new System.EventHandler(this.Color_click);
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.White;
            this.picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture.ContextMenuStrip = this.tool_menu;
            this.picture.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture.Location = new System.Drawing.Point(0, 0);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(627, 409);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 2;
            this.picture.TabStop = false;
            this.picture.Paint += new System.Windows.Forms.PaintEventHandler(this.picture_Paint);
            this.picture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picture_MouseDown);
            this.picture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picture_MouseMove);
            this.picture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picture_MouseUp);
            // 
            // brush_menu
            // 
            this.brush_menu.AutoSize = false;
            this.brush_menu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.brush_menu.DropShadowEnabled = false;
            this.brush_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11,
            this.toolStripMenuItem12,
            this.toolStripMenuItem13});
            this.brush_menu.Name = "tool_menu";
            this.brush_menu.ShowItemToolTips = false;
            this.brush_menu.Size = new System.Drawing.Size(28, 120);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.AutoSize = false;
            this.toolStripMenuItem9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuItem9.Image = global::SmartBoard.Properties.Resources.brush1;
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(27, 22);
            this.toolStripMenuItem9.Tag = "3";
            this.toolStripMenuItem9.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolStripMenuItem9.Click += new System.EventHandler(this.Width_changed);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.AutoSize = false;
            this.toolStripMenuItem10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuItem10.Image = global::SmartBoard.Properties.Resources.brush2;
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(27, 22);
            this.toolStripMenuItem10.Tag = "7";
            this.toolStripMenuItem10.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolStripMenuItem10.Click += new System.EventHandler(this.Width_changed);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.AutoSize = false;
            this.toolStripMenuItem11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuItem11.Image = global::SmartBoard.Properties.Resources.brush3;
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(27, 22);
            this.toolStripMenuItem11.Tag = "12";
            this.toolStripMenuItem11.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolStripMenuItem11.Click += new System.EventHandler(this.Width_changed);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.AutoSize = false;
            this.toolStripMenuItem12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuItem12.Image = global::SmartBoard.Properties.Resources.brush4;
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(27, 22);
            this.toolStripMenuItem12.Tag = "18";
            this.toolStripMenuItem12.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolStripMenuItem12.Click += new System.EventHandler(this.Width_changed);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.AutoSize = false;
            this.toolStripMenuItem13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuItem13.Image = global::SmartBoard.Properties.Resources.brush5;
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(27, 22);
            this.toolStripMenuItem13.Tag = "25";
            this.toolStripMenuItem13.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolStripMenuItem13.Click += new System.EventHandler(this.Width_changed);
            // 
            // top
            // 
            this.top.BackColor = System.Drawing.Color.SteelBlue;
            this.top.Dock = System.Windows.Forms.DockStyle.Top;
            this.top.Location = new System.Drawing.Point(0, 0);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(627, 8);
            this.top.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 409);
            this.Controls.Add(this.top);
            this.Controls.Add(this.panel_toolbar);
            this.Controls.Add(this.picture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tool_menu.ResumeLayout(false);
            this.color_menu.ResumeLayout(false);
            this.panel_toolbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.brush_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_toolbar;
        private System.Windows.Forms.Button bt_Tool;
        private System.Windows.Forms.Button bt_Color;
        private System.Windows.Forms.Button bt_Brush;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button bt_Pencil;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button bt_Eraser;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Panel points;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.ContextMenuStrip tool_menu;
        private System.Windows.Forms.ToolStripMenuItem bt_Rectangle;
        private System.Windows.Forms.ToolStripMenuItem bt_Circle;
        private System.Windows.Forms.ToolStripMenuItem bt_Arrow;
        private System.Windows.Forms.ToolStripMenuItem bt_Line;
        private System.Windows.Forms.ToolStripMenuItem bt_Arrow2;
        private System.Windows.Forms.ToolStripMenuItem bt_Line2;
        private System.Windows.Forms.ContextMenuStrip color_menu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ContextMenuStrip brush_menu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_window;
        private System.Windows.Forms.Button bt_windows;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel top;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

