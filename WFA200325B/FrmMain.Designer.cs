namespace WFA200325B
{
    partial class FrmMain
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
            this.lbTetelek = new System.Windows.Forms.ListBox();
            this.tbTetelNev = new System.Windows.Forms.TextBox();
            this.btnTetelRogzitese = new System.Windows.Forms.Button();
            this.lblSum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTetelOsszeg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rbKiadas = new System.Windows.Forms.RadioButton();
            this.rbBevetel = new System.Windows.Forms.RadioButton();
            this.btnSum = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTetelek
            // 
            this.lbTetelek.BackColor = System.Drawing.Color.LightYellow;
            this.lbTetelek.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbTetelek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbTetelek.FormattingEnabled = true;
            this.lbTetelek.ItemHeight = 20;
            this.lbTetelek.Location = new System.Drawing.Point(557, 43);
            this.lbTetelek.Name = "lbTetelek";
            this.lbTetelek.ScrollAlwaysVisible = true;
            this.lbTetelek.Size = new System.Drawing.Size(190, 304);
            this.lbTetelek.TabIndex = 0;
            this.lbTetelek.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbTetelek_DrawItem);
            // 
            // tbTetelNev
            // 
            this.tbTetelNev.BackColor = System.Drawing.Color.LightYellow;
            this.tbTetelNev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbTetelNev.Location = new System.Drawing.Point(25, 43);
            this.tbTetelNev.Name = "tbTetelNev";
            this.tbTetelNev.Size = new System.Drawing.Size(261, 30);
            this.tbTetelNev.TabIndex = 1;
            // 
            // btnTetelRogzitese
            // 
            this.btnTetelRogzitese.BackColor = System.Drawing.Color.LightYellow;
            this.btnTetelRogzitese.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTetelRogzitese.Location = new System.Drawing.Point(25, 220);
            this.btnTetelRogzitese.Name = "btnTetelRogzitese";
            this.btnTetelRogzitese.Size = new System.Drawing.Size(478, 51);
            this.btnTetelRogzitese.TabIndex = 2;
            this.btnTetelRogzitese.Text = "Tétel rögzítése";
            this.btnTetelRogzitese.UseVisualStyleBackColor = false;
            this.btnTetelRogzitese.Click += new System.EventHandler(this.btnTetelRogzitese_Click);
            // 
            // lblSum
            // 
            this.lblSum.BackColor = System.Drawing.Color.LightYellow;
            this.lblSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSum.Location = new System.Drawing.Point(267, 307);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(230, 40);
            this.lblSum.TabIndex = 3;
            this.lblSum.Text = "###placeholder###";
            this.lblSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(22, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "tétel megnevezése";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(318, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "összeg";
            // 
            // tbTetelOsszeg
            // 
            this.tbTetelOsszeg.BackColor = System.Drawing.Color.LightYellow;
            this.tbTetelOsszeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbTetelOsszeg.Location = new System.Drawing.Point(321, 43);
            this.tbTetelOsszeg.Name = "tbTetelOsszeg";
            this.tbTetelOsszeg.Size = new System.Drawing.Size(182, 30);
            this.tbTetelOsszeg.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(554, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "eddigi tételek";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(25, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 85);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.rbKiadas, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.rbBevetel, 0, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(466, 58);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // rbKiadas
            // 
            this.rbKiadas.BackColor = System.Drawing.Color.LightYellow;
            this.rbKiadas.Checked = true;
            this.rbKiadas.Location = new System.Drawing.Point(236, 3);
            this.rbKiadas.Name = "rbKiadas";
            this.rbKiadas.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.rbKiadas.Size = new System.Drawing.Size(227, 52);
            this.rbKiadas.TabIndex = 0;
            this.rbKiadas.TabStop = true;
            this.rbKiadas.Text = "KIADÁS";
            this.rbKiadas.UseVisualStyleBackColor = false;
            // 
            // rbBevetel
            // 
            this.rbBevetel.BackColor = System.Drawing.Color.LightYellow;
            this.rbBevetel.Location = new System.Drawing.Point(3, 3);
            this.rbBevetel.Name = "rbBevetel";
            this.rbBevetel.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.rbBevetel.Size = new System.Drawing.Size(227, 52);
            this.rbBevetel.TabIndex = 1;
            this.rbBevetel.Text = "BEVÉTEL";
            this.rbBevetel.UseVisualStyleBackColor = false;
            // 
            // btnSum
            // 
            this.btnSum.BackColor = System.Drawing.Color.LightYellow;
            this.btnSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSum.Location = new System.Drawing.Point(25, 307);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(236, 40);
            this.btnSum.TabIndex = 2;
            this.btnSum.Text = "Összegzés";
            this.btnSum.UseVisualStyleBackColor = false;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(759, 377);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnTetelRogzitese);
            this.Controls.Add(this.tbTetelOsszeg);
            this.Controls.Add(this.tbTetelNev);
            this.Controls.Add(this.lbTetelek);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbTetelek;
        private System.Windows.Forms.TextBox tbTetelNev;
        private System.Windows.Forms.Button btnTetelRogzitese;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTetelOsszeg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton rbKiadas;
        private System.Windows.Forms.RadioButton rbBevetel;
        private System.Windows.Forms.Button btnSum;
    }
}

