namespace Calculator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnmodule = new System.Windows.Forms.Button();
            this.btnpre = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btndivide = new System.Windows.Forms.Button();
            this.btnseven = new System.Windows.Forms.Button();
            this.btneight = new System.Windows.Forms.Button();
            this.btnnine = new System.Windows.Forms.Button();
            this.btnMultify = new System.Windows.Forms.Button();
            this.btnfour = new System.Windows.Forms.Button();
            this.btnfive = new System.Windows.Forms.Button();
            this.btnsix = new System.Windows.Forms.Button();
            this.btnsub = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btntwo = new System.Windows.Forms.Button();
            this.btnthree = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnzero = new System.Windows.Forms.Button();
            this.btndo = new System.Windows.Forms.Button();
            this.btnequal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btnequal);
            this.panel1.Controls.Add(this.btndo);
            this.panel1.Controls.Add(this.btnzero);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Controls.Add(this.btnthree);
            this.panel1.Controls.Add(this.btntwo);
            this.panel1.Controls.Add(this.btnOne);
            this.panel1.Controls.Add(this.btnsub);
            this.panel1.Controls.Add(this.btnsix);
            this.panel1.Controls.Add(this.btnfive);
            this.panel1.Controls.Add(this.btnfour);
            this.panel1.Controls.Add(this.btnMultify);
            this.panel1.Controls.Add(this.btnnine);
            this.panel1.Controls.Add(this.btneight);
            this.panel1.Controls.Add(this.btnseven);
            this.panel1.Controls.Add(this.btndivide);
            this.panel1.Controls.Add(this.btnC);
            this.panel1.Controls.Add(this.btnCE);
            this.panel1.Controls.Add(this.btnpre);
            this.panel1.Controls.Add(this.btnmodule);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(12, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 432);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 30);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 32);
            this.textBox1.TabIndex = 0;
            // 
            // btnmodule
            // 
            this.btnmodule.Location = new System.Drawing.Point(19, 357);
            this.btnmodule.Name = "btnmodule";
            this.btnmodule.Size = new System.Drawing.Size(60, 41);
            this.btnmodule.TabIndex = 1;
            this.btnmodule.Text = "%";
            this.btnmodule.UseVisualStyleBackColor = true;
            // 
            // btnpre
            // 
            this.btnpre.Location = new System.Drawing.Point(151, 100);
            this.btnpre.Name = "btnpre";
            this.btnpre.Size = new System.Drawing.Size(60, 41);
            this.btnpre.TabIndex = 3;
            this.btnpre.Text = "<<";
            this.btnpre.UseVisualStyleBackColor = true;
            this.btnpre.Click += new System.EventHandler(this.btnpre_Click);
            // 
            // btnCE
            // 
            this.btnCE.Location = new System.Drawing.Point(19, 100);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(60, 41);
            this.btnCE.TabIndex = 5;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(85, 100);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(60, 41);
            this.btnC.TabIndex = 6;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btndivide
            // 
            this.btndivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndivide.Location = new System.Drawing.Point(228, 100);
            this.btndivide.Name = "btndivide";
            this.btndivide.Size = new System.Drawing.Size(60, 41);
            this.btndivide.TabIndex = 8;
            this.btndivide.Text = "/";
            this.btndivide.UseVisualStyleBackColor = true;
            this.btndivide.Click += new System.EventHandler(this.btndivide_Click);
            // 
            // btnseven
            // 
            this.btnseven.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnseven.Location = new System.Drawing.Point(19, 165);
            this.btnseven.Name = "btnseven";
            this.btnseven.Size = new System.Drawing.Size(60, 41);
            this.btnseven.TabIndex = 9;
            this.btnseven.Text = "7";
            this.btnseven.UseVisualStyleBackColor = true;
            this.btnseven.Click += new System.EventHandler(this.btnseven_Click);
            // 
            // btneight
            // 
            this.btneight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneight.Location = new System.Drawing.Point(85, 165);
            this.btneight.Name = "btneight";
            this.btneight.Size = new System.Drawing.Size(60, 41);
            this.btneight.TabIndex = 10;
            this.btneight.Text = "8";
            this.btneight.UseVisualStyleBackColor = true;
            this.btneight.Click += new System.EventHandler(this.btneight_Click);
            // 
            // btnnine
            // 
            this.btnnine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnine.Location = new System.Drawing.Point(151, 165);
            this.btnnine.Name = "btnnine";
            this.btnnine.Size = new System.Drawing.Size(60, 41);
            this.btnnine.TabIndex = 11;
            this.btnnine.Text = "9";
            this.btnnine.UseVisualStyleBackColor = true;
            this.btnnine.Click += new System.EventHandler(this.btnnine_Click);
            // 
            // btnMultify
            // 
            this.btnMultify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultify.Location = new System.Drawing.Point(228, 164);
            this.btnMultify.Name = "btnMultify";
            this.btnMultify.Size = new System.Drawing.Size(60, 41);
            this.btnMultify.TabIndex = 12;
            this.btnMultify.Text = "*";
            this.btnMultify.UseVisualStyleBackColor = true;
            this.btnMultify.Click += new System.EventHandler(this.btnMultify_Click);
            // 
            // btnfour
            // 
            this.btnfour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfour.Location = new System.Drawing.Point(19, 228);
            this.btnfour.Name = "btnfour";
            this.btnfour.Size = new System.Drawing.Size(60, 41);
            this.btnfour.TabIndex = 13;
            this.btnfour.Text = "4";
            this.btnfour.UseVisualStyleBackColor = true;
            this.btnfour.Click += new System.EventHandler(this.btnfour_Click);
            // 
            // btnfive
            // 
            this.btnfive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfive.Location = new System.Drawing.Point(85, 228);
            this.btnfive.Name = "btnfive";
            this.btnfive.Size = new System.Drawing.Size(60, 41);
            this.btnfive.TabIndex = 14;
            this.btnfive.Text = "5";
            this.btnfive.UseVisualStyleBackColor = true;
            this.btnfive.Click += new System.EventHandler(this.btnfive_Click);
            // 
            // btnsix
            // 
            this.btnsix.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsix.Location = new System.Drawing.Point(151, 228);
            this.btnsix.Name = "btnsix";
            this.btnsix.Size = new System.Drawing.Size(60, 41);
            this.btnsix.TabIndex = 15;
            this.btnsix.Text = "6";
            this.btnsix.UseVisualStyleBackColor = true;
            this.btnsix.Click += new System.EventHandler(this.btnsix_Click);
            // 
            // btnsub
            // 
            this.btnsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsub.Location = new System.Drawing.Point(228, 228);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(60, 41);
            this.btnsub.TabIndex = 16;
            this.btnsub.Text = "-";
            this.btnsub.UseVisualStyleBackColor = true;
            this.btnsub.Click += new System.EventHandler(this.btnsub_Click);
            // 
            // btnOne
            // 
            this.btnOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOne.Location = new System.Drawing.Point(19, 291);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(60, 41);
            this.btnOne.TabIndex = 17;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btntwo
            // 
            this.btntwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntwo.Location = new System.Drawing.Point(85, 291);
            this.btntwo.Name = "btntwo";
            this.btntwo.Size = new System.Drawing.Size(60, 41);
            this.btntwo.TabIndex = 18;
            this.btntwo.Text = "2";
            this.btntwo.UseVisualStyleBackColor = true;
            this.btntwo.Click += new System.EventHandler(this.btntwo_Click);
            // 
            // btnthree
            // 
            this.btnthree.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthree.Location = new System.Drawing.Point(151, 291);
            this.btnthree.Name = "btnthree";
            this.btnthree.Size = new System.Drawing.Size(60, 41);
            this.btnthree.TabIndex = 19;
            this.btnthree.Text = "3";
            this.btnthree.UseVisualStyleBackColor = true;
            this.btnthree.Click += new System.EventHandler(this.btnthree_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(228, 291);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(60, 41);
            this.btnadd.TabIndex = 20;
            this.btnadd.Text = "+";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnzero
            // 
            this.btnzero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnzero.Location = new System.Drawing.Point(85, 357);
            this.btnzero.Name = "btnzero";
            this.btnzero.Size = new System.Drawing.Size(60, 41);
            this.btnzero.TabIndex = 22;
            this.btnzero.Text = "0";
            this.btnzero.UseVisualStyleBackColor = true;
            this.btnzero.Click += new System.EventHandler(this.btnzero_Click);
            // 
            // btndo
            // 
            this.btndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndo.Location = new System.Drawing.Point(151, 356);
            this.btndo.Name = "btndo";
            this.btndo.Size = new System.Drawing.Size(60, 41);
            this.btndo.TabIndex = 23;
            this.btndo.Text = ".";
            this.btndo.UseVisualStyleBackColor = true;
            this.btndo.Click += new System.EventHandler(this.btndo_Click);
            // 
            // btnequal
            // 
            this.btnequal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnequal.Location = new System.Drawing.Point(228, 356);
            this.btnequal.Name = "btnequal";
            this.btnequal.Size = new System.Drawing.Size(60, 40);
            this.btnequal.TabIndex = 24;
            this.btnequal.Text = "=";
            this.btnequal.UseVisualStyleBackColor = true;
            this.btnequal.Click += new System.EventHandler(this.btnequal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 473);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnequal;
        private System.Windows.Forms.Button btndo;
        private System.Windows.Forms.Button btnzero;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnthree;
        private System.Windows.Forms.Button btntwo;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.Button btnsix;
        private System.Windows.Forms.Button btnfive;
        private System.Windows.Forms.Button btnfour;
        private System.Windows.Forms.Button btnMultify;
        private System.Windows.Forms.Button btnnine;
        private System.Windows.Forms.Button btneight;
        private System.Windows.Forms.Button btnseven;
        private System.Windows.Forms.Button btndivide;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnpre;
        private System.Windows.Forms.Button btnmodule;
    }
}

