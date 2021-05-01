namespace Paint
{
    partial class MainApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApp));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chkFill = new System.Windows.Forms.CheckBox();
            this.btnCanvasColor = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnOrange = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.btnBrown = new System.Windows.Forms.Button();
            this.btnCrimson = new System.Windows.Forms.Button();
            this.btnIndogo = new System.Windows.Forms.Button();
            this.btnTeal = new System.Windows.Forms.Button();
            this.btnAqua = new System.Windows.Forms.Button();
            this.btnFuchsia = new System.Windows.Forms.Button();
            this.btnWhite = new System.Windows.Forms.Button();
            this.btnBlack = new System.Windows.Forms.Button();
            this.btnViolet = new System.Windows.Forms.Button();
            this.btnDarkBlue = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnPenColor = new System.Windows.Forms.Button();
            this.btnBrushColor = new System.Windows.Forms.Button();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.comboBoxThick = new System.Windows.Forms.ComboBox();
            this.labelThick = new System.Windows.Forms.Label();
            this.groupBoxThick = new System.Windows.Forms.GroupBox();
            this.groupBoxShapes = new System.Windows.Forms.GroupBox();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.groupBoxOther = new System.Windows.Forms.GroupBox();
            this.groupBoxCanvasColor = new System.Windows.Forms.GroupBox();
            this.labelCanvasColor = new System.Windows.Forms.Label();
            this.btnRedo = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnPencil = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            this.panel.SuspendLayout();
            this.groupBoxColors.SuspendLayout();
            this.groupBoxThick.SuspendLayout();
            this.groupBoxShapes.SuspendLayout();
            this.groupBoxColor.SuspendLayout();
            this.groupBoxOther.SuspendLayout();
            this.groupBoxCanvasColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1516, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.OpenToolStripMenuItem.Text = "Открыть";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // chkFill
            // 
            this.chkFill.AutoSize = true;
            this.chkFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkFill.Location = new System.Drawing.Point(79, 102);
            this.chkFill.Name = "chkFill";
            this.chkFill.Size = new System.Drawing.Size(159, 24);
            this.chkFill.TabIndex = 7;
            this.chkFill.Text = "Прозрачный фон";
            this.chkFill.UseVisualStyleBackColor = true;
            this.chkFill.CheckedChanged += new System.EventHandler(this.chkFill_CheckedChanged);
            // 
            // btnCanvasColor
            // 
            this.btnCanvasColor.BackColor = System.Drawing.Color.White;
            this.btnCanvasColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCanvasColor.Location = new System.Drawing.Point(6, 12);
            this.btnCanvasColor.Name = "btnCanvasColor";
            this.btnCanvasColor.Size = new System.Drawing.Size(121, 28);
            this.btnCanvasColor.TabIndex = 10;
            this.btnCanvasColor.UseVisualStyleBackColor = false;
            this.btnCanvasColor.Click += new System.EventHandler(this.btnCanvaColor_Click);
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRed.Location = new System.Drawing.Point(45, 6);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(34, 32);
            this.btnRed.TabIndex = 15;
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.changeColor);
            // 
            // btnOrange
            // 
            this.btnOrange.BackColor = System.Drawing.Color.Orange;
            this.btnOrange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrange.Location = new System.Drawing.Point(85, 6);
            this.btnOrange.Name = "btnOrange";
            this.btnOrange.Size = new System.Drawing.Size(34, 32);
            this.btnOrange.TabIndex = 16;
            this.btnOrange.UseVisualStyleBackColor = false;
            this.btnOrange.Click += new System.EventHandler(this.changeColor);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.btnBrown);
            this.panel.Controls.Add(this.btnCrimson);
            this.panel.Controls.Add(this.btnIndogo);
            this.panel.Controls.Add(this.btnTeal);
            this.panel.Controls.Add(this.btnAqua);
            this.panel.Controls.Add(this.btnFuchsia);
            this.panel.Controls.Add(this.btnColor);
            this.panel.Controls.Add(this.btnWhite);
            this.panel.Controls.Add(this.btnBlack);
            this.panel.Controls.Add(this.btnViolet);
            this.panel.Controls.Add(this.btnDarkBlue);
            this.panel.Controls.Add(this.btnBlue);
            this.panel.Controls.Add(this.btnGreen);
            this.panel.Controls.Add(this.btnYellow);
            this.panel.Controls.Add(this.btnRed);
            this.panel.Controls.Add(this.btnOrange);
            this.panel.Location = new System.Drawing.Point(74, 14);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(329, 84);
            this.panel.TabIndex = 17;
            // 
            // btnBrown
            // 
            this.btnBrown.BackColor = System.Drawing.Color.Brown;
            this.btnBrown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrown.Location = new System.Drawing.Point(245, 44);
            this.btnBrown.Name = "btnBrown";
            this.btnBrown.Size = new System.Drawing.Size(34, 32);
            this.btnBrown.TabIndex = 29;
            this.btnBrown.UseVisualStyleBackColor = false;
            this.btnBrown.Click += new System.EventHandler(this.changeColor);
            // 
            // btnCrimson
            // 
            this.btnCrimson.BackColor = System.Drawing.Color.Crimson;
            this.btnCrimson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrimson.Location = new System.Drawing.Point(205, 44);
            this.btnCrimson.Name = "btnCrimson";
            this.btnCrimson.Size = new System.Drawing.Size(34, 32);
            this.btnCrimson.TabIndex = 28;
            this.btnCrimson.UseVisualStyleBackColor = false;
            this.btnCrimson.Click += new System.EventHandler(this.changeColor);
            // 
            // btnIndogo
            // 
            this.btnIndogo.BackColor = System.Drawing.Color.Indigo;
            this.btnIndogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIndogo.Location = new System.Drawing.Point(165, 44);
            this.btnIndogo.Name = "btnIndogo";
            this.btnIndogo.Size = new System.Drawing.Size(34, 32);
            this.btnIndogo.TabIndex = 27;
            this.btnIndogo.UseVisualStyleBackColor = false;
            this.btnIndogo.Click += new System.EventHandler(this.changeColor);
            // 
            // btnTeal
            // 
            this.btnTeal.BackColor = System.Drawing.Color.Teal;
            this.btnTeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeal.Location = new System.Drawing.Point(125, 44);
            this.btnTeal.Name = "btnTeal";
            this.btnTeal.Size = new System.Drawing.Size(34, 32);
            this.btnTeal.TabIndex = 26;
            this.btnTeal.UseVisualStyleBackColor = false;
            this.btnTeal.Click += new System.EventHandler(this.changeColor);
            // 
            // btnAqua
            // 
            this.btnAqua.BackColor = System.Drawing.Color.Aqua;
            this.btnAqua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAqua.Location = new System.Drawing.Point(85, 44);
            this.btnAqua.Name = "btnAqua";
            this.btnAqua.Size = new System.Drawing.Size(34, 32);
            this.btnAqua.TabIndex = 25;
            this.btnAqua.UseVisualStyleBackColor = false;
            this.btnAqua.Click += new System.EventHandler(this.changeColor);
            // 
            // btnFuchsia
            // 
            this.btnFuchsia.BackColor = System.Drawing.Color.Fuchsia;
            this.btnFuchsia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuchsia.Location = new System.Drawing.Point(45, 44);
            this.btnFuchsia.Name = "btnFuchsia";
            this.btnFuchsia.Size = new System.Drawing.Size(34, 32);
            this.btnFuchsia.TabIndex = 24;
            this.btnFuchsia.UseVisualStyleBackColor = false;
            this.btnFuchsia.Click += new System.EventHandler(this.changeColor);
            // 
            // btnWhite
            // 
            this.btnWhite.BackColor = System.Drawing.Color.White;
            this.btnWhite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWhite.Location = new System.Drawing.Point(5, 44);
            this.btnWhite.Name = "btnWhite";
            this.btnWhite.Size = new System.Drawing.Size(34, 32);
            this.btnWhite.TabIndex = 23;
            this.btnWhite.UseVisualStyleBackColor = false;
            this.btnWhite.Click += new System.EventHandler(this.changeColor);
            // 
            // btnBlack
            // 
            this.btnBlack.BackColor = System.Drawing.Color.Black;
            this.btnBlack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlack.Location = new System.Drawing.Point(5, 6);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(34, 32);
            this.btnBlack.TabIndex = 22;
            this.btnBlack.UseVisualStyleBackColor = false;
            this.btnBlack.Click += new System.EventHandler(this.changeColor);
            // 
            // btnViolet
            // 
            this.btnViolet.BackColor = System.Drawing.Color.Violet;
            this.btnViolet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViolet.Location = new System.Drawing.Point(285, 6);
            this.btnViolet.Name = "btnViolet";
            this.btnViolet.Size = new System.Drawing.Size(34, 32);
            this.btnViolet.TabIndex = 21;
            this.btnViolet.UseVisualStyleBackColor = false;
            this.btnViolet.Click += new System.EventHandler(this.changeColor);
            // 
            // btnDarkBlue
            // 
            this.btnDarkBlue.BackColor = System.Drawing.Color.DarkBlue;
            this.btnDarkBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDarkBlue.Location = new System.Drawing.Point(245, 6);
            this.btnDarkBlue.Name = "btnDarkBlue";
            this.btnDarkBlue.Size = new System.Drawing.Size(34, 32);
            this.btnDarkBlue.TabIndex = 20;
            this.btnDarkBlue.UseVisualStyleBackColor = false;
            this.btnDarkBlue.Click += new System.EventHandler(this.changeColor);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlue.Location = new System.Drawing.Point(205, 6);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(34, 32);
            this.btnBlue.TabIndex = 19;
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.changeColor);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.Green;
            this.btnGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGreen.Location = new System.Drawing.Point(165, 6);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(34, 32);
            this.btnGreen.TabIndex = 18;
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.changeColor);
            // 
            // btnYellow
            // 
            this.btnYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnYellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYellow.Location = new System.Drawing.Point(125, 6);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(34, 32);
            this.btnYellow.TabIndex = 17;
            this.btnYellow.UseVisualStyleBackColor = false;
            this.btnYellow.Click += new System.EventHandler(this.changeColor);
            // 
            // btnPenColor
            // 
            this.btnPenColor.BackColor = System.Drawing.Color.Black;
            this.btnPenColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPenColor.Location = new System.Drawing.Point(7, 13);
            this.btnPenColor.Name = "btnPenColor";
            this.btnPenColor.Size = new System.Drawing.Size(34, 32);
            this.btnPenColor.TabIndex = 18;
            this.btnPenColor.UseVisualStyleBackColor = false;
            this.btnPenColor.Click += new System.EventHandler(this.btnPen_Click);
            // 
            // btnBrushColor
            // 
            this.btnBrushColor.BackColor = System.Drawing.Color.White;
            this.btnBrushColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrushColor.Location = new System.Drawing.Point(20, 19);
            this.btnBrushColor.Name = "btnBrushColor";
            this.btnBrushColor.Size = new System.Drawing.Size(34, 32);
            this.btnBrushColor.TabIndex = 19;
            this.btnBrushColor.UseVisualStyleBackColor = false;
            this.btnBrushColor.Click += new System.EventHandler(this.btnBrush_Click);
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.btnPenColor);
            this.groupBoxColors.Controls.Add(this.btnBrushColor);
            this.groupBoxColors.Location = new System.Drawing.Point(6, 25);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(62, 55);
            this.groupBoxColors.TabIndex = 20;
            this.groupBoxColors.TabStop = false;
            // 
            // comboBoxThick
            // 
            this.comboBoxThick.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxThick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxThick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxThick.FormattingEnabled = true;
            this.comboBoxThick.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxThick.Location = new System.Drawing.Point(6, 13);
            this.comboBoxThick.Name = "comboBoxThick";
            this.comboBoxThick.Size = new System.Drawing.Size(121, 28);
            this.comboBoxThick.TabIndex = 25;
            // 
            // labelThick
            // 
            this.labelThick.AutoSize = true;
            this.labelThick.BackColor = System.Drawing.Color.Transparent;
            this.labelThick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelThick.ForeColor = System.Drawing.Color.Black;
            this.labelThick.Location = new System.Drawing.Point(26, 44);
            this.labelThick.Name = "labelThick";
            this.labelThick.Size = new System.Drawing.Size(77, 20);
            this.labelThick.TabIndex = 26;
            this.labelThick.Text = "Толщина";
            // 
            // groupBoxThick
            // 
            this.groupBoxThick.Controls.Add(this.comboBoxThick);
            this.groupBoxThick.Controls.Add(this.labelThick);
            this.groupBoxThick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxThick.Location = new System.Drawing.Point(6, 7);
            this.groupBoxThick.Name = "groupBoxThick";
            this.groupBoxThick.Size = new System.Drawing.Size(134, 66);
            this.groupBoxThick.TabIndex = 27;
            this.groupBoxThick.TabStop = false;
            // 
            // groupBoxShapes
            // 
            this.groupBoxShapes.Controls.Add(this.btnPencil);
            this.groupBoxShapes.Controls.Add(this.btnLine);
            this.groupBoxShapes.Controls.Add(this.btnEllipse);
            this.groupBoxShapes.Controls.Add(this.btnRectangle);
            this.groupBoxShapes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxShapes.Location = new System.Drawing.Point(1071, 104);
            this.groupBoxShapes.Name = "groupBoxShapes";
            this.groupBoxShapes.Size = new System.Drawing.Size(337, 90);
            this.groupBoxShapes.TabIndex = 28;
            this.groupBoxShapes.TabStop = false;
            this.groupBoxShapes.Text = "Фигуры";
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.groupBoxColors);
            this.groupBoxColor.Controls.Add(this.panel);
            this.groupBoxColor.Controls.Add(this.chkFill);
            this.groupBoxColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxColor.Location = new System.Drawing.Point(1071, 197);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(414, 133);
            this.groupBoxColor.TabIndex = 29;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Цвета";
            // 
            // groupBoxOther
            // 
            this.groupBoxOther.Controls.Add(this.groupBoxCanvasColor);
            this.groupBoxOther.Controls.Add(this.groupBoxThick);
            this.groupBoxOther.Controls.Add(this.btnClean);
            this.groupBoxOther.Location = new System.Drawing.Point(1071, 336);
            this.groupBoxOther.Name = "groupBoxOther";
            this.groupBoxOther.Size = new System.Drawing.Size(414, 86);
            this.groupBoxOther.TabIndex = 30;
            this.groupBoxOther.TabStop = false;
            // 
            // groupBoxCanvasColor
            // 
            this.groupBoxCanvasColor.Controls.Add(this.labelCanvasColor);
            this.groupBoxCanvasColor.Controls.Add(this.btnCanvasColor);
            this.groupBoxCanvasColor.Location = new System.Drawing.Point(170, 7);
            this.groupBoxCanvasColor.Name = "groupBoxCanvasColor";
            this.groupBoxCanvasColor.Size = new System.Drawing.Size(134, 66);
            this.groupBoxCanvasColor.TabIndex = 31;
            this.groupBoxCanvasColor.TabStop = false;
            // 
            // labelCanvasColor
            // 
            this.labelCanvasColor.AutoSize = true;
            this.labelCanvasColor.BackColor = System.Drawing.Color.Transparent;
            this.labelCanvasColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCanvasColor.ForeColor = System.Drawing.Color.Black;
            this.labelCanvasColor.Location = new System.Drawing.Point(21, 42);
            this.labelCanvasColor.Name = "labelCanvasColor";
            this.labelCanvasColor.Size = new System.Drawing.Size(94, 20);
            this.labelCanvasColor.TabIndex = 32;
            this.labelCanvasColor.Text = "Цвет фона";
            // 
            // btnRedo
            // 
            this.btnRedo.BackColor = System.Drawing.Color.Transparent;
            this.btnRedo.FlatAppearance.BorderSize = 0;
            this.btnRedo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRedo.Image = global::Paint.Properties.Resources.redo;
            this.btnRedo.Location = new System.Drawing.Point(1139, 30);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(62, 62);
            this.btnRedo.TabIndex = 32;
            this.btnRedo.UseVisualStyleBackColor = false;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.Color.Transparent;
            this.btnUndo.FlatAppearance.BorderSize = 0;
            this.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUndo.ForeColor = System.Drawing.Color.White;
            this.btnUndo.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.Image")));
            this.btnUndo.Location = new System.Drawing.Point(1071, 30);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(62, 62);
            this.btnUndo.TabIndex = 31;
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnClean
            // 
            this.btnClean.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnClean.FlatAppearance.BorderSize = 0;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Image = global::Paint.Properties.Resources.clean;
            this.btnClean.Location = new System.Drawing.Point(331, 11);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(62, 62);
            this.btnClean.TabIndex = 12;
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Transparent;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.Image = global::Paint.Properties.Resources.images;
            this.btnColor.Location = new System.Drawing.Point(285, 44);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(34, 32);
            this.btnColor.TabIndex = 5;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnPencil
            // 
            this.btnPencil.BackColor = System.Drawing.Color.Transparent;
            this.btnPencil.FlatAppearance.BorderSize = 0;
            this.btnPencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPencil.Image = global::Paint.Properties.Resources.pencil;
            this.btnPencil.Location = new System.Drawing.Point(6, 19);
            this.btnPencil.Name = "btnPencil";
            this.btnPencil.Size = new System.Drawing.Size(62, 62);
            this.btnPencil.TabIndex = 21;
            this.btnPencil.UseVisualStyleBackColor = false;
            this.btnPencil.Click += new System.EventHandler(this.btnPencil_Click);
            // 
            // btnLine
            // 
            this.btnLine.BackColor = System.Drawing.Color.Transparent;
            this.btnLine.FlatAppearance.BorderSize = 0;
            this.btnLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLine.Image = global::Paint.Properties.Resources.line;
            this.btnLine.Location = new System.Drawing.Point(93, 19);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(62, 62);
            this.btnLine.TabIndex = 22;
            this.btnLine.UseVisualStyleBackColor = false;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.BackColor = System.Drawing.Color.Transparent;
            this.btnEllipse.FlatAppearance.BorderSize = 0;
            this.btnEllipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEllipse.Image = global::Paint.Properties.Resources.ellipse;
            this.btnEllipse.Location = new System.Drawing.Point(267, 19);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(62, 62);
            this.btnEllipse.TabIndex = 24;
            this.btnEllipse.UseVisualStyleBackColor = false;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.BackColor = System.Drawing.Color.Transparent;
            this.btnRectangle.FlatAppearance.BorderSize = 0;
            this.btnRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRectangle.Image = global::Paint.Properties.Resources.rectangle;
            this.btnRectangle.Location = new System.Drawing.Point(180, 19);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(62, 62);
            this.btnRectangle.TabIndex = 23;
            this.btnRectangle.UseVisualStyleBackColor = false;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.SystemColors.Window;
            this.Canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Canvas.Dock = System.Windows.Forms.DockStyle.Left;
            this.Canvas.Location = new System.Drawing.Point(0, 24);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(1065, 748);
            this.Canvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Canvas.TabIndex = 0;
            this.Canvas.TabStop = false;
            this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1516, 772);
            this.Controls.Add(this.btnRedo);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.groupBoxOther);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.groupBoxShapes);
            this.Controls.Add(this.Canvas);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel.ResumeLayout(false);
            this.groupBoxColors.ResumeLayout(false);
            this.groupBoxThick.ResumeLayout(false);
            this.groupBoxThick.PerformLayout();
            this.groupBoxShapes.ResumeLayout(false);
            this.groupBoxColor.ResumeLayout(false);
            this.groupBoxColor.PerformLayout();
            this.groupBoxOther.ResumeLayout(false);
            this.groupBoxCanvasColor.ResumeLayout(false);
            this.groupBoxCanvasColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.CheckBox chkFill;
        private System.Windows.Forms.Button btnCanvasColor;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnOrange;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnFuchsia;
        private System.Windows.Forms.Button btnWhite;
        private System.Windows.Forms.Button btnBlack;
        private System.Windows.Forms.Button btnViolet;
        private System.Windows.Forms.Button btnDarkBlue;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnBrown;
        private System.Windows.Forms.Button btnCrimson;
        private System.Windows.Forms.Button btnIndogo;
        private System.Windows.Forms.Button btnTeal;
        private System.Windows.Forms.Button btnAqua;
        private System.Windows.Forms.Button btnPenColor;
        private System.Windows.Forms.Button btnBrushColor;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.Button btnPencil;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.ComboBox comboBoxThick;
        private System.Windows.Forms.Label labelThick;
        private System.Windows.Forms.GroupBox groupBoxThick;
        private System.Windows.Forms.GroupBox groupBoxShapes;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.GroupBox groupBoxOther;
        private System.Windows.Forms.GroupBox groupBoxCanvasColor;
        private System.Windows.Forms.Label labelCanvasColor;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnRedo;
    }
}

