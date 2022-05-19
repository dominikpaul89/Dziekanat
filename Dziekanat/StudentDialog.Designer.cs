namespace Dziekanat_
{
    partial class StudentDialog
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
            this.Imielabel1 = new System.Windows.Forms.Label();
            this.nazwiskoLabel1 = new System.Windows.Forms.Label();
            this.NrIndeksuLabel2 = new System.Windows.Forms.Label();
            this.imieTextBox1 = new System.Windows.Forms.TextBox();
            this.NazwiskoTextBox2 = new System.Windows.Forms.TextBox();
            this.NrIndeksuTextBox3 = new System.Windows.Forms.TextBox();
            this.anulujButton1 = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Imielabel1
            // 
            this.Imielabel1.AutoSize = true;
            this.Imielabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Imielabel1.Location = new System.Drawing.Point(46, 54);
            this.Imielabel1.Name = "Imielabel1";
            this.Imielabel1.Size = new System.Drawing.Size(55, 25);
            this.Imielabel1.TabIndex = 0;
            this.Imielabel1.Text = "Imie:";
            // 
            // nazwiskoLabel1
            // 
            this.nazwiskoLabel1.AutoSize = true;
            this.nazwiskoLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nazwiskoLabel1.Location = new System.Drawing.Point(46, 99);
            this.nazwiskoLabel1.Name = "nazwiskoLabel1";
            this.nazwiskoLabel1.Size = new System.Drawing.Size(99, 25);
            this.nazwiskoLabel1.TabIndex = 1;
            this.nazwiskoLabel1.Text = "Nazwisko:";
            // 
            // NrIndeksuLabel2
            // 
            this.NrIndeksuLabel2.AutoSize = true;
            this.NrIndeksuLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NrIndeksuLabel2.Location = new System.Drawing.Point(46, 144);
            this.NrIndeksuLabel2.Name = "NrIndeksuLabel2";
            this.NrIndeksuLabel2.Size = new System.Drawing.Size(116, 25);
            this.NrIndeksuLabel2.TabIndex = 2;
            this.NrIndeksuLabel2.Text = "Nr Indeksu: ";
            // 
            // imieTextBox1
            // 
            this.imieTextBox1.Location = new System.Drawing.Point(197, 54);
            this.imieTextBox1.Name = "imieTextBox1";
            this.imieTextBox1.Size = new System.Drawing.Size(136, 23);
            this.imieTextBox1.TabIndex = 3;
            // 
            // NazwiskoTextBox2
            // 
            this.NazwiskoTextBox2.Location = new System.Drawing.Point(197, 104);
            this.NazwiskoTextBox2.Name = "NazwiskoTextBox2";
            this.NazwiskoTextBox2.Size = new System.Drawing.Size(136, 23);
            this.NazwiskoTextBox2.TabIndex = 4;
            // 
            // NrIndeksuTextBox3
            // 
            this.NrIndeksuTextBox3.Location = new System.Drawing.Point(197, 146);
            this.NrIndeksuTextBox3.Name = "NrIndeksuTextBox3";
            this.NrIndeksuTextBox3.Size = new System.Drawing.Size(136, 23);
            this.NrIndeksuTextBox3.TabIndex = 5;
            this.NrIndeksuTextBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NrIndeksuTextBox3_KeyPress);
            // 
            // anulujButton1
            // 
            this.anulujButton1.Location = new System.Drawing.Point(288, 198);
            this.anulujButton1.Name = "anulujButton1";
            this.anulujButton1.Size = new System.Drawing.Size(75, 23);
            this.anulujButton1.TabIndex = 6;
            this.anulujButton1.Text = "Anuluj";
            this.anulujButton1.UseVisualStyleBackColor = true;
            this.anulujButton1.Click += new System.EventHandler(this.anulujButton1_Click);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(197, 198);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 7;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // StudentDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 233);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.anulujButton1);
            this.Controls.Add(this.NrIndeksuTextBox3);
            this.Controls.Add(this.NazwiskoTextBox2);
            this.Controls.Add(this.imieTextBox1);
            this.Controls.Add(this.NrIndeksuLabel2);
            this.Controls.Add(this.nazwiskoLabel1);
            this.Controls.Add(this.Imielabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doda jStudenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Imielabel1;
        private System.Windows.Forms.Label nazwiskoLabel1;
        private System.Windows.Forms.Label NrIndeksuLabel2;
        private System.Windows.Forms.TextBox imieTextBox1;
        private System.Windows.Forms.TextBox NazwiskoTextBox2;
        private System.Windows.Forms.TextBox NrIndeksuTextBox3;
        private System.Windows.Forms.Button anulujButton1;
        private System.Windows.Forms.Button OkButton;
    }
}