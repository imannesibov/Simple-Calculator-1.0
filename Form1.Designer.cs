namespace Simple_Calculator_1._0
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
            this.components = new System.ComponentModel.Container();
            this.header = new System.Windows.Forms.Label();
            this.clcwindragcontrol = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.formtext = new System.Windows.Forms.Label();
            this.minimizebtn = new Bunifu.Framework.UI.BunifuTileButton();
            this.exitbtn = new Bunifu.Framework.UI.BunifuTileButton();
            this.resultscreen = new System.Windows.Forms.TextBox();
            this.three = new Bunifu.Framework.UI.BunifuTileButton();
            this.two = new Bunifu.Framework.UI.BunifuTileButton();
            this.one = new Bunifu.Framework.UI.BunifuTileButton();
            this.divide = new Bunifu.Framework.UI.BunifuTileButton();
            this.multiply = new Bunifu.Framework.UI.BunifuTileButton();
            this.six = new Bunifu.Framework.UI.BunifuTileButton();
            this.five = new Bunifu.Framework.UI.BunifuTileButton();
            this.four = new Bunifu.Framework.UI.BunifuTileButton();
            this.minus = new Bunifu.Framework.UI.BunifuTileButton();
            this.nine = new Bunifu.Framework.UI.BunifuTileButton();
            this.eight = new Bunifu.Framework.UI.BunifuTileButton();
            this.seven = new Bunifu.Framework.UI.BunifuTileButton();
            this.clear = new Bunifu.Framework.UI.BunifuTileButton();
            this.plus = new Bunifu.Framework.UI.BunifuTileButton();
            this.equal = new Bunifu.Framework.UI.BunifuTileButton();
            this.zero = new Bunifu.Framework.UI.BunifuTileButton();
            this.dot = new Bunifu.Framework.UI.BunifuTileButton();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.header.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.header.ForeColor = System.Drawing.SystemColors.ControlText;
            this.header.Location = new System.Drawing.Point(-5, -4);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(404, 35);
            this.header.TabIndex = 0;
            // 
            // clcwindragcontrol
            // 
            this.clcwindragcontrol.Fixed = true;
            this.clcwindragcontrol.Horizontal = true;
            this.clcwindragcontrol.TargetControl = this.header;
            this.clcwindragcontrol.Vertical = true;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // formtext
            // 
            this.formtext.AutoSize = true;
            this.formtext.Enabled = false;
            this.formtext.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formtext.Location = new System.Drawing.Point(4, 3);
            this.formtext.Name = "formtext";
            this.formtext.Size = new System.Drawing.Size(107, 13);
            this.formtext.TabIndex = 6;
            this.formtext.Text = "Simple Calculator 1.0";
            // 
            // minimizebtn
            // 
            this.minimizebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.minimizebtn.color = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.minimizebtn.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.minimizebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizebtn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(104)))), ((int)(((byte)(106)))));
            this.minimizebtn.Image = null;
            this.minimizebtn.ImagePosition = 13;
            this.minimizebtn.ImageZoom = 50;
            this.minimizebtn.LabelPosition = 25;
            this.minimizebtn.LabelText = "_";
            this.minimizebtn.Location = new System.Drawing.Point(292, -2);
            this.minimizebtn.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.minimizebtn.Name = "minimizebtn";
            this.minimizebtn.Size = new System.Drawing.Size(52, 31);
            this.minimizebtn.TabIndex = 5;
            this.minimizebtn.Click += new System.EventHandler(this.minimizebtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.exitbtn.color = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.exitbtn.colorActive = System.Drawing.Color.Red;
            this.exitbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitbtn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(104)))), ((int)(((byte)(106)))));
            this.exitbtn.Image = null;
            this.exitbtn.ImagePosition = 13;
            this.exitbtn.ImageZoom = 50;
            this.exitbtn.LabelPosition = 25;
            this.exitbtn.LabelText = "X";
            this.exitbtn.Location = new System.Drawing.Point(345, 0);
            this.exitbtn.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(52, 31);
            this.exitbtn.TabIndex = 4;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // resultscreen
            // 
            this.resultscreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.resultscreen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultscreen.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultscreen.ForeColor = System.Drawing.SystemColors.InfoText;
            this.resultscreen.Location = new System.Drawing.Point(-2, 31);
            this.resultscreen.Multiline = true;
            this.resultscreen.Name = "resultscreen";
            this.resultscreen.Size = new System.Drawing.Size(391, 134);
            this.resultscreen.TabIndex = 7;
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.three.color = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.three.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.three.Cursor = System.Windows.Forms.Cursors.Hand;
            this.three.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.ForeColor = System.Drawing.Color.Black;
            this.three.Image = null;
            this.three.ImagePosition = 20;
            this.three.ImageZoom = 50;
            this.three.LabelPosition = 38;
            this.three.LabelText = "3";
            this.three.Location = new System.Drawing.Point(168, 169);
            this.three.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(71, 54);
            this.three.TabIndex = 11;
            this.three.Click += new System.EventHandler(this.NumpadItem_Click);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.two.color = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.two.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.two.Cursor = System.Windows.Forms.Cursors.Hand;
            this.two.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.ForeColor = System.Drawing.Color.Black;
            this.two.Image = null;
            this.two.ImagePosition = 20;
            this.two.ImageZoom = 50;
            this.two.LabelPosition = 38;
            this.two.LabelText = "2";
            this.two.Location = new System.Drawing.Point(90, 169);
            this.two.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(71, 54);
            this.two.TabIndex = 10;
            this.two.Click += new System.EventHandler(this.NumpadItem_Click);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.one.color = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.one.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.one.Cursor = System.Windows.Forms.Cursors.Hand;
            this.one.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.ForeColor = System.Drawing.Color.Black;
            this.one.Image = null;
            this.one.ImagePosition = 20;
            this.one.ImageZoom = 50;
            this.one.LabelPosition = 38;
            this.one.LabelText = "1";
            this.one.Location = new System.Drawing.Point(11, 169);
            this.one.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(71, 54);
            this.one.TabIndex = 9;
            this.one.Click += new System.EventHandler(this.NumpadItem_Click);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.divide.color = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.divide.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.divide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.divide.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.ForeColor = System.Drawing.Color.Black;
            this.divide.Image = null;
            this.divide.ImagePosition = 20;
            this.divide.ImageZoom = 50;
            this.divide.LabelPosition = 38;
            this.divide.LabelText = "/";
            this.divide.Location = new System.Drawing.Point(244, 169);
            this.divide.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(71, 54);
            this.divide.TabIndex = 19;
            this.divide.Click += new System.EventHandler(this.CalculateThat);
            // 
            // multiply
            // 
            this.multiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.multiply.color = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.multiply.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.multiply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.multiply.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply.ForeColor = System.Drawing.Color.Black;
            this.multiply.Image = null;
            this.multiply.ImagePosition = 20;
            this.multiply.ImageZoom = 50;
            this.multiply.LabelPosition = 38;
            this.multiply.LabelText = "x";
            this.multiply.Location = new System.Drawing.Point(244, 229);
            this.multiply.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(71, 54);
            this.multiply.TabIndex = 23;
            this.multiply.Click += new System.EventHandler(this.CalculateThat);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.six.color = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.six.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.six.Cursor = System.Windows.Forms.Cursors.Hand;
            this.six.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.ForeColor = System.Drawing.Color.Black;
            this.six.Image = null;
            this.six.ImagePosition = 20;
            this.six.ImageZoom = 50;
            this.six.LabelPosition = 38;
            this.six.LabelText = "6";
            this.six.Location = new System.Drawing.Point(168, 229);
            this.six.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(71, 54);
            this.six.TabIndex = 22;
            this.six.Click += new System.EventHandler(this.NumpadItem_Click);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.five.color = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.five.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.five.Cursor = System.Windows.Forms.Cursors.Hand;
            this.five.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.ForeColor = System.Drawing.Color.Black;
            this.five.Image = null;
            this.five.ImagePosition = 20;
            this.five.ImageZoom = 50;
            this.five.LabelPosition = 38;
            this.five.LabelText = "5";
            this.five.Location = new System.Drawing.Point(90, 229);
            this.five.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(71, 54);
            this.five.TabIndex = 21;
            this.five.Click += new System.EventHandler(this.NumpadItem_Click);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.four.color = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.four.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.four.Cursor = System.Windows.Forms.Cursors.Hand;
            this.four.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.ForeColor = System.Drawing.Color.Black;
            this.four.Image = null;
            this.four.ImagePosition = 20;
            this.four.ImageZoom = 50;
            this.four.LabelPosition = 38;
            this.four.LabelText = "4";
            this.four.Location = new System.Drawing.Point(7, 229);
            this.four.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(71, 54);
            this.four.TabIndex = 20;
            this.four.Click += new System.EventHandler(this.NumpadItem_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.minus.color = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.minus.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minus.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.ForeColor = System.Drawing.Color.Black;
            this.minus.Image = null;
            this.minus.ImagePosition = 20;
            this.minus.ImageZoom = 50;
            this.minus.LabelPosition = 38;
            this.minus.LabelText = "-";
            this.minus.Location = new System.Drawing.Point(244, 291);
            this.minus.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(71, 54);
            this.minus.TabIndex = 27;
            this.minus.Click += new System.EventHandler(this.CalculateThat);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.nine.color = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.nine.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.nine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nine.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.ForeColor = System.Drawing.Color.Black;
            this.nine.Image = null;
            this.nine.ImagePosition = 20;
            this.nine.ImageZoom = 50;
            this.nine.LabelPosition = 38;
            this.nine.LabelText = "9";
            this.nine.Location = new System.Drawing.Point(168, 291);
            this.nine.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(71, 54);
            this.nine.TabIndex = 26;
            this.nine.Click += new System.EventHandler(this.NumpadItem_Click);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.eight.color = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.eight.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.eight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eight.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.ForeColor = System.Drawing.Color.Black;
            this.eight.Image = null;
            this.eight.ImagePosition = 20;
            this.eight.ImageZoom = 50;
            this.eight.LabelPosition = 38;
            this.eight.LabelText = "8";
            this.eight.Location = new System.Drawing.Point(90, 291);
            this.eight.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(71, 54);
            this.eight.TabIndex = 25;
            this.eight.Click += new System.EventHandler(this.NumpadItem_Click);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.seven.color = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.seven.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.seven.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seven.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.ForeColor = System.Drawing.Color.Black;
            this.seven.Image = null;
            this.seven.ImagePosition = 20;
            this.seven.ImageZoom = 50;
            this.seven.LabelPosition = 38;
            this.seven.LabelText = "7";
            this.seven.Location = new System.Drawing.Point(11, 291);
            this.seven.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(71, 54);
            this.seven.TabIndex = 24;
            this.seven.Click += new System.EventHandler(this.NumpadItem_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.clear.color = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.clear.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.Color.Black;
            this.clear.Image = null;
            this.clear.ImagePosition = 20;
            this.clear.ImageZoom = 50;
            this.clear.LabelPosition = 38;
            this.clear.LabelText = "C";
            this.clear.Location = new System.Drawing.Point(325, 169);
            this.clear.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(64, 114);
            this.clear.TabIndex = 31;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.plus.color = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.plus.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plus.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.ForeColor = System.Drawing.Color.Black;
            this.plus.Image = null;
            this.plus.ImagePosition = 20;
            this.plus.ImageZoom = 50;
            this.plus.LabelPosition = 38;
            this.plus.LabelText = "+";
            this.plus.Location = new System.Drawing.Point(244, 353);
            this.plus.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(71, 54);
            this.plus.TabIndex = 30;
            this.plus.Click += new System.EventHandler(this.CalculateThat);
            // 
            // equal
            // 
            this.equal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.equal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.equal.color = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.equal.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.equal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.equal.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal.ForeColor = System.Drawing.Color.Black;
            this.equal.Image = null;
            this.equal.ImagePosition = 20;
            this.equal.ImageZoom = 50;
            this.equal.LabelPosition = 38;
            this.equal.LabelText = "=";
            this.equal.Location = new System.Drawing.Point(325, 291);
            this.equal.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(64, 116);
            this.equal.TabIndex = 29;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.zero.color = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.zero.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.zero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zero.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.ForeColor = System.Drawing.Color.Black;
            this.zero.Image = null;
            this.zero.ImagePosition = 20;
            this.zero.ImageZoom = 50;
            this.zero.LabelPosition = 38;
            this.zero.LabelText = "0";
            this.zero.Location = new System.Drawing.Point(11, 353);
            this.zero.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(150, 54);
            this.zero.TabIndex = 28;
            this.zero.Click += new System.EventHandler(this.NumpadItem_Click);
            // 
            // dot
            // 
            this.dot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.dot.color = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.dot.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.dot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dot.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dot.ForeColor = System.Drawing.Color.Black;
            this.dot.Image = null;
            this.dot.ImagePosition = 20;
            this.dot.ImageZoom = 50;
            this.dot.LabelPosition = 38;
            this.dot.LabelText = ".";
            this.dot.Location = new System.Drawing.Point(168, 353);
            this.dot.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(71, 54);
            this.dot.TabIndex = 32;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 421);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.resultscreen);
            this.Controls.Add(this.formtext);
            this.Controls.Add(this.minimizebtn);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header;
        private Bunifu.Framework.UI.BunifuDragControl clcwindragcontrol;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label formtext;
        private Bunifu.Framework.UI.BunifuTileButton minimizebtn;
        private Bunifu.Framework.UI.BunifuTileButton exitbtn;
        private System.Windows.Forms.TextBox resultscreen;
        private Bunifu.Framework.UI.BunifuTileButton three;
        private Bunifu.Framework.UI.BunifuTileButton two;
        private Bunifu.Framework.UI.BunifuTileButton one;
        private Bunifu.Framework.UI.BunifuTileButton divide;
        private Bunifu.Framework.UI.BunifuTileButton multiply;
        private Bunifu.Framework.UI.BunifuTileButton six;
        private Bunifu.Framework.UI.BunifuTileButton five;
        private Bunifu.Framework.UI.BunifuTileButton four;
        private Bunifu.Framework.UI.BunifuTileButton minus;
        private Bunifu.Framework.UI.BunifuTileButton nine;
        private Bunifu.Framework.UI.BunifuTileButton eight;
        private Bunifu.Framework.UI.BunifuTileButton seven;
        private Bunifu.Framework.UI.BunifuTileButton clear;
        private Bunifu.Framework.UI.BunifuTileButton plus;
        private Bunifu.Framework.UI.BunifuTileButton equal;
        private Bunifu.Framework.UI.BunifuTileButton zero;
        private Bunifu.Framework.UI.BunifuTileButton dot;
    }
}

