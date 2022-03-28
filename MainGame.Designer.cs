namespace WindowsFormsApp1
{
    partial class MainGame
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ayarlar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEnterMatrix = new System.Windows.Forms.Label();
            this.txtColm = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.Label();
            this.txtRow = new System.Windows.Forms.TextBox();
            this.difRdBtn4 = new System.Windows.Forms.RadioButton();
            this.difRdBtn3 = new System.Windows.Forms.RadioButton();
            this.difRdBtn2 = new System.Windows.Forms.RadioButton();
            this.difRdBtn1 = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.shapeTriangle = new System.Windows.Forms.RadioButton();
            this.shapeSquare = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.shapeTxt = new System.Windows.Forms.TextBox();
            this.shapeRoundShapes = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.ayarlar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(122, 450);
            this.panel1.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 210);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Menu Item";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 177);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Menu Item";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Menu Item";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ayarlar
            // 
            this.ayarlar.Location = new System.Drawing.Point(13, 93);
            this.ayarlar.Name = "ayarlar";
            this.ayarlar.Size = new System.Drawing.Size(75, 40);
            this.ayarlar.TabIndex = 1;
            this.ayarlar.Text = "Ayarlar";
            this.ayarlar.UseVisualStyleBackColor = true;
            this.ayarlar.Click += new System.EventHandler(this.ayarlar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(4, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(115, 61);
            this.panel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.difRdBtn4);
            this.groupBox1.Controls.Add(this.difRdBtn3);
            this.groupBox1.Controls.Add(this.difRdBtn2);
            this.groupBox1.Controls.Add(this.difRdBtn1);
            this.groupBox1.Location = new System.Drawing.Point(188, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 200);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Difficulty";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEnterMatrix);
            this.groupBox2.Controls.Add(this.txtColm);
            this.groupBox2.Controls.Add(this.txtX);
            this.groupBox2.Controls.Add(this.txtRow);
            this.groupBox2.Location = new System.Drawing.Point(132, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 52);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enter Matrix";
            // 
            // txtEnterMatrix
            // 
            this.txtEnterMatrix.AutoSize = true;
            this.txtEnterMatrix.Location = new System.Drawing.Point(17, 19);
            this.txtEnterMatrix.Name = "txtEnterMatrix";
            this.txtEnterMatrix.Size = new System.Drawing.Size(66, 13);
            this.txtEnterMatrix.TabIndex = 10;
            this.txtEnterMatrix.Text = "Enter Matrix:";
            // 
            // txtColm
            // 
            this.txtColm.Location = new System.Drawing.Point(214, 15);
            this.txtColm.Name = "txtColm";
            this.txtColm.Size = new System.Drawing.Size(100, 20);
            this.txtColm.TabIndex = 8;
            // 
            // txtX
            // 
            this.txtX.AutoSize = true;
            this.txtX.Location = new System.Drawing.Point(195, 19);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(12, 13);
            this.txtX.TabIndex = 7;
            this.txtX.Text = "x";
            // 
            // txtRow
            // 
            this.txtRow.Location = new System.Drawing.Point(89, 16);
            this.txtRow.Name = "txtRow";
            this.txtRow.Size = new System.Drawing.Size(100, 20);
            this.txtRow.TabIndex = 6;
            // 
            // difRdBtn4
            // 
            this.difRdBtn4.AutoSize = true;
            this.difRdBtn4.Location = new System.Drawing.Point(24, 141);
            this.difRdBtn4.Name = "difRdBtn4";
            this.difRdBtn4.Size = new System.Drawing.Size(60, 17);
            this.difRdBtn4.TabIndex = 9;
            this.difRdBtn4.TabStop = true;
            this.difRdBtn4.Text = "Custom";
            this.difRdBtn4.UseVisualStyleBackColor = true;
            this.difRdBtn4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // difRdBtn3
            // 
            this.difRdBtn3.AutoSize = true;
            this.difRdBtn3.Location = new System.Drawing.Point(24, 106);
            this.difRdBtn3.Name = "difRdBtn3";
            this.difRdBtn3.Size = new System.Drawing.Size(48, 17);
            this.difRdBtn3.TabIndex = 5;
            this.difRdBtn3.TabStop = true;
            this.difRdBtn3.Text = "Hard";
            this.difRdBtn3.UseVisualStyleBackColor = true;
            // 
            // difRdBtn2
            // 
            this.difRdBtn2.AutoSize = true;
            this.difRdBtn2.Location = new System.Drawing.Point(24, 70);
            this.difRdBtn2.Name = "difRdBtn2";
            this.difRdBtn2.Size = new System.Drawing.Size(58, 17);
            this.difRdBtn2.TabIndex = 4;
            this.difRdBtn2.TabStop = true;
            this.difRdBtn2.Text = "Normal";
            this.difRdBtn2.UseVisualStyleBackColor = true;
            // 
            // difRdBtn1
            // 
            this.difRdBtn1.AutoSize = true;
            this.difRdBtn1.Location = new System.Drawing.Point(24, 31);
            this.difRdBtn1.Name = "difRdBtn1";
            this.difRdBtn1.Size = new System.Drawing.Size(48, 17);
            this.difRdBtn1.TabIndex = 3;
            this.difRdBtn1.TabStop = true;
            this.difRdBtn1.Text = "Easy";
            this.difRdBtn1.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(646, 377);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // shapeTriangle
            // 
            this.shapeTriangle.AutoSize = true;
            this.shapeTriangle.Location = new System.Drawing.Point(12, 30);
            this.shapeTriangle.Name = "shapeTriangle";
            this.shapeTriangle.Size = new System.Drawing.Size(63, 17);
            this.shapeTriangle.TabIndex = 7;
            this.shapeTriangle.TabStop = true;
            this.shapeTriangle.Text = "Triangle";
            this.shapeTriangle.UseVisualStyleBackColor = true;
            // 
            // shapeSquare
            // 
            this.shapeSquare.AutoSize = true;
            this.shapeSquare.Location = new System.Drawing.Point(108, 30);
            this.shapeSquare.Name = "shapeSquare";
            this.shapeSquare.Size = new System.Drawing.Size(59, 17);
            this.shapeSquare.TabIndex = 8;
            this.shapeSquare.TabStop = true;
            this.shapeSquare.Text = "Square";
            this.shapeSquare.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.shapeTxt);
            this.groupBox3.Controls.Add(this.shapeRoundShapes);
            this.groupBox3.Controls.Add(this.shapeTriangle);
            this.groupBox3.Controls.Add(this.shapeSquare);
            this.groupBox3.Location = new System.Drawing.Point(212, 295);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(364, 128);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Shape";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Adet:  ";
            // 
            // shapeTxt
            // 
            this.shapeTxt.Location = new System.Drawing.Point(197, 84);
            this.shapeTxt.Name = "shapeTxt";
            this.shapeTxt.Size = new System.Drawing.Size(100, 20);
            this.shapeTxt.TabIndex = 10;
            // 
            // shapeRoundShapes
            // 
            this.shapeRoundShapes.AutoSize = true;
            this.shapeRoundShapes.Location = new System.Drawing.Point(219, 30);
            this.shapeRoundShapes.Name = "shapeRoundShapes";
            this.shapeRoundShapes.Size = new System.Drawing.Size(96, 17);
            this.shapeRoundShapes.TabIndex = 9;
            this.shapeRoundShapes.TabStop = true;
            this.shapeRoundShapes.Text = "Round Shapes";
            this.shapeRoundShapes.UseVisualStyleBackColor = true;
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "MainGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.MainGame_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ayarlar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton difRdBtn2;
        private System.Windows.Forms.TextBox txtRow;
        private System.Windows.Forms.RadioButton difRdBtn3;
        private System.Windows.Forms.Label txtEnterMatrix;
        private System.Windows.Forms.RadioButton difRdBtn4;
        private System.Windows.Forms.TextBox txtColm;
        private System.Windows.Forms.Label txtX;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton difRdBtn1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.RadioButton shapeTriangle;
        private System.Windows.Forms.RadioButton shapeSquare;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox shapeTxt;
        private System.Windows.Forms.RadioButton shapeRoundShapes;
    }
}