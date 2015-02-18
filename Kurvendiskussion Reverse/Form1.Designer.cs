namespace Kurvendiskussion_Reverse
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Nullstelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resultat = new System.Windows.Forms.Label();
            this.Wendepunkt = new System.Windows.Forms.Button();
            this.Extrempunkt = new System.Windows.Forms.Button();
            this.TB_X = new System.Windows.Forms.MaskedTextBox();
            this.TB_Y = new System.Windows.Forms.MaskedTextBox();
            this.TB_Grad = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.punkt = new System.Windows.Forms.Button();
            this.minusX = new System.Windows.Forms.CheckBox();
            this.minusY = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nullstelle
            // 
            this.Nullstelle.Location = new System.Drawing.Point(150, 47);
            this.Nullstelle.Name = "Nullstelle";
            this.Nullstelle.Size = new System.Drawing.Size(146, 26);
            this.Nullstelle.TabIndex = 1;
            this.Nullstelle.Text = "Nullstelle hinzufügen";
            this.Nullstelle.UseVisualStyleBackColor = true;
            this.Nullstelle.Click += new System.EventHandler(this.nullstelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "y";
            // 
            // resultat
            // 
            this.resultat.AutoSize = true;
            this.resultat.Location = new System.Drawing.Point(12, 157);
            this.resultat.Name = "resultat";
            this.resultat.Size = new System.Drawing.Size(52, 13);
            this.resultat.TabIndex = 4;
            this.resultat.Text = "Resultat: ";
            // 
            // Wendepunkt
            // 
            this.Wendepunkt.Location = new System.Drawing.Point(150, 111);
            this.Wendepunkt.Name = "Wendepunkt";
            this.Wendepunkt.Size = new System.Drawing.Size(146, 26);
            this.Wendepunkt.TabIndex = 6;
            this.Wendepunkt.Text = "Wendepunkt hinzufügen";
            this.Wendepunkt.UseVisualStyleBackColor = true;
            this.Wendepunkt.Click += new System.EventHandler(this.wendepunkt_Click);
            // 
            // Extrempunkt
            // 
            this.Extrempunkt.Location = new System.Drawing.Point(150, 79);
            this.Extrempunkt.Name = "Extrempunkt";
            this.Extrempunkt.Size = new System.Drawing.Size(146, 26);
            this.Extrempunkt.TabIndex = 7;
            this.Extrempunkt.Text = "Extrempunkt hinzufügen";
            this.Extrempunkt.UseVisualStyleBackColor = true;
            this.Extrempunkt.Click += new System.EventHandler(this.extrempunkt_Click);
            // 
            // TB_X
            // 
            this.TB_X.Location = new System.Drawing.Point(68, 47);
            this.TB_X.Mask = "000000000";
            this.TB_X.Name = "TB_X";
            this.TB_X.Size = new System.Drawing.Size(63, 20);
            this.TB_X.TabIndex = 8;
            // 
            // TB_Y
            // 
            this.TB_Y.Location = new System.Drawing.Point(68, 83);
            this.TB_Y.Mask = "000000000";
            this.TB_Y.Name = "TB_Y";
            this.TB_Y.Size = new System.Drawing.Size(63, 20);
            this.TB_Y.TabIndex = 9;
            // 
            // TB_Grad
            // 
            this.TB_Grad.Location = new System.Drawing.Point(119, 21);
            this.TB_Grad.Mask = "0";
            this.TB_Grad.Name = "TB_Grad";
            this.TB_Grad.Size = new System.Drawing.Size(12, 20);
            this.TB_Grad.TabIndex = 10;
            this.TB_Grad.TextChanged += new System.EventHandler(this.TB_Grad_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Grad";
            // 
            // listView1
            // 
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(314, 13);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(273, 135);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // punkt
            // 
            this.punkt.Location = new System.Drawing.Point(150, 19);
            this.punkt.Name = "punkt";
            this.punkt.Size = new System.Drawing.Size(146, 23);
            this.punkt.TabIndex = 13;
            this.punkt.Text = "Punkt hinzufügen";
            this.punkt.UseVisualStyleBackColor = true;
            this.punkt.Click += new System.EventHandler(this.punkt_Click);
            // 
            // minusX
            // 
            this.minusX.AutoSize = true;
            this.minusX.Location = new System.Drawing.Point(31, 49);
            this.minusX.Name = "minusX";
            this.minusX.Size = new System.Drawing.Size(29, 17);
            this.minusX.TabIndex = 14;
            this.minusX.Text = "-";
            this.minusX.UseVisualStyleBackColor = true;
            // 
            // minusY
            // 
            this.minusY.AutoSize = true;
            this.minusY.Location = new System.Drawing.Point(31, 85);
            this.minusY.Name = "minusY";
            this.minusY.Size = new System.Drawing.Size(29, 17);
            this.minusY.TabIndex = 15;
            this.minusY.Text = "-";
            this.minusY.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 179);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.minusY);
            this.Controls.Add(this.minusX);
            this.Controls.Add(this.punkt);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_Grad);
            this.Controls.Add(this.TB_Y);
            this.Controls.Add(this.TB_X);
            this.Controls.Add(this.Extrempunkt);
            this.Controls.Add(this.Wendepunkt);
            this.Controls.Add(this.resultat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nullstelle);
            this.Name = "Form1";
            this.Text = "KDR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Nullstelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resultat;
        private System.Windows.Forms.Button Wendepunkt;
        private System.Windows.Forms.Button Extrempunkt;
        private System.Windows.Forms.MaskedTextBox TB_X;
        private System.Windows.Forms.MaskedTextBox TB_Y;
        private System.Windows.Forms.MaskedTextBox TB_Grad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button punkt;
        private System.Windows.Forms.CheckBox minusX;
        private System.Windows.Forms.CheckBox minusY;
        private System.Windows.Forms.Button button1;
    }
}

