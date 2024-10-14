namespace SpecialProject2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbX = new System.Windows.Forms.TextBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.bDraw = new System.Windows.Forms.Button();
            this.tbLength = new System.Windows.Forms.TextBox();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbThickness = new System.Windows.Forms.ComboBox();
            this.bClear = new System.Windows.Forms.Button();
            this.cbFillSelect = new System.Windows.Forms.ComboBox();
            this.bEraser = new System.Windows.Forms.Button();
            this.bColor = new System.Windows.Forms.Button();
            this.cbModeSelect = new System.Windows.Forms.ComboBox();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(29, 185);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(32, 20);
            this.tbX.TabIndex = 0;
            this.tbX.TextChanged += new System.EventHandler(this.tbX_TextChanged);
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(29, 211);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(32, 20);
            this.tbY.TabIndex = 1;
            this.tbY.TextChanged += new System.EventHandler(this.tbY_TextChanged);
            // 
            // bDraw
            // 
            this.bDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDraw.Location = new System.Drawing.Point(12, 298);
            this.bDraw.Name = "bDraw";
            this.bDraw.Size = new System.Drawing.Size(49, 23);
            this.bDraw.TabIndex = 4;
            this.bDraw.Text = "Create";
            this.bDraw.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bDraw.UseVisualStyleBackColor = true;
            this.bDraw.Click += new System.EventHandler(this.bDraw_Click);
            // 
            // tbLength
            // 
            this.tbLength.Location = new System.Drawing.Point(29, 237);
            this.tbLength.Name = "tbLength";
            this.tbLength.Size = new System.Drawing.Size(32, 20);
            this.tbLength.TabIndex = 2;
            this.tbLength.TextChanged += new System.EventHandler(this.tbLength_TextChanged);
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(29, 263);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(32, 20);
            this.tbHeight.TabIndex = 3;
            this.tbHeight.TextChanged += new System.EventHandler(this.tbHeight_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(13, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(13, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(13, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(9, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "l";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(13, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "h";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.cbThickness);
            this.panel1.Controls.Add(this.bClear);
            this.panel1.Controls.Add(this.cbFillSelect);
            this.panel1.Controls.Add(this.bEraser);
            this.panel1.Controls.Add(this.bColor);
            this.panel1.Controls.Add(this.cbModeSelect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 461);
            this.panel1.TabIndex = 9;
            // 
            // cbThickness
            // 
            this.cbThickness.FormattingEnabled = true;
            this.cbThickness.Items.AddRange(new object[] {
            "1px",
            "2px",
            "3px",
            "4px",
            "5px"});
            this.cbThickness.Location = new System.Drawing.Point(12, 68);
            this.cbThickness.Name = "cbThickness";
            this.cbThickness.Size = new System.Drawing.Size(78, 21);
            this.cbThickness.TabIndex = 14;
            this.cbThickness.Text = "2px";
            this.cbThickness.SelectedIndexChanged += new System.EventHandler(this.cbThickness_SelectedIndexChanged);
            // 
            // bClear
            // 
            this.bClear.BackColor = System.Drawing.SystemColors.Control;
            this.bClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClear.Location = new System.Drawing.Point(12, 426);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(49, 23);
            this.bClear.TabIndex = 11;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = false;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // cbFillSelect
            // 
            this.cbFillSelect.FormattingEnabled = true;
            this.cbFillSelect.Items.AddRange(new object[] {
            "Outline",
            "Fill"});
            this.cbFillSelect.Location = new System.Drawing.Point(12, 40);
            this.cbFillSelect.Name = "cbFillSelect";
            this.cbFillSelect.Size = new System.Drawing.Size(78, 21);
            this.cbFillSelect.TabIndex = 12;
            this.cbFillSelect.Text = "Outline";
            this.cbFillSelect.SelectedIndexChanged += new System.EventHandler(this.cbFillSelect_SelectedIndexChanged);
            // 
            // bEraser
            // 
            this.bEraser.BackColor = System.Drawing.SystemColors.Control;
            this.bEraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEraser.Location = new System.Drawing.Point(12, 124);
            this.bEraser.Margin = new System.Windows.Forms.Padding(2);
            this.bEraser.Name = "bEraser";
            this.bEraser.Size = new System.Drawing.Size(78, 21);
            this.bEraser.TabIndex = 13;
            this.bEraser.Text = "Eraser";
            this.bEraser.UseVisualStyleBackColor = false;
            this.bEraser.Click += new System.EventHandler(this.bEraser_Click);
            // 
            // bColor
            // 
            this.bColor.BackColor = System.Drawing.SystemColors.Control;
            this.bColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bColor.Location = new System.Drawing.Point(12, 96);
            this.bColor.Margin = new System.Windows.Forms.Padding(2);
            this.bColor.Name = "bColor";
            this.bColor.Size = new System.Drawing.Size(78, 21);
            this.bColor.TabIndex = 12;
            this.bColor.Text = "Color";
            this.bColor.UseVisualStyleBackColor = false;
            this.bColor.Click += new System.EventHandler(this.bColor_Click);
            // 
            // cbModeSelect
            // 
            this.cbModeSelect.FormattingEnabled = true;
            this.cbModeSelect.Items.AddRange(new object[] {
            "Rectangle",
            "Ellipse",
            "Triangle",
            "Line",
            "Free Draw"});
            this.cbModeSelect.Location = new System.Drawing.Point(12, 12);
            this.cbModeSelect.Name = "cbModeSelect";
            this.cbModeSelect.Size = new System.Drawing.Size(78, 21);
            this.cbModeSelect.TabIndex = 11;
            this.cbModeSelect.Text = "Rectangle";
            this.cbModeSelect.SelectedIndexChanged += new System.EventHandler(this.cbModeSelect_SelectedIndexChanged);
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(100, 0);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(634, 461);
            this.canvas.TabIndex = 10;
            this.canvas.TabStop = false;
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.tbLength);
            this.Controls.Add(this.bDraw);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.TextBox tbLength;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Button bDraw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.ComboBox cbModeSelect;
        private System.Windows.Forms.Button bColor;
        private System.Windows.Forms.Button bEraser;
        private System.Windows.Forms.ComboBox cbFillSelect;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.ComboBox cbThickness;
    }
}

