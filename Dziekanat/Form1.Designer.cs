namespace Dziekanat_
{
    partial class OknoGlowneForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StudencidataGridView = new System.Windows.Forms.DataGridView();
            this.ImieCol1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazwiskoCol1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NrIndeksuCol1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Usun = new System.Windows.Forms.Button();
            this.dodajButton1 = new System.Windows.Forms.Button();
            this.nazwiskoTextBox2 = new System.Windows.Forms.TextBox();
            this.imieTextBox1 = new System.Windows.Forms.TextBox();
            this.nazwiskoLabel = new System.Windows.Forms.Label();
            this.ImieLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StudencidataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudencidataGridView
            // 
            this.StudencidataGridView.AllowUserToAddRows = false;
            this.StudencidataGridView.AllowUserToOrderColumns = true;
            this.StudencidataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudencidataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImieCol1,
            this.NazwiskoCol1,
            this.NrIndeksuCol1});
            this.StudencidataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudencidataGridView.Location = new System.Drawing.Point(0, 0);
            this.StudencidataGridView.Name = "StudencidataGridView";
            this.StudencidataGridView.ReadOnly = true;
            this.StudencidataGridView.RowTemplate.Height = 25;
            this.StudencidataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudencidataGridView.Size = new System.Drawing.Size(1031, 416);
            this.StudencidataGridView.TabIndex = 0;
            this.StudencidataGridView.SelectionChanged += new System.EventHandler(this.StudencidataGridView_SelectionChanged);
            // 
            // ImieCol1
            // 
            this.ImieCol1.DataPropertyName = "Imie";
            this.ImieCol1.HeaderText = "Imie";
            this.ImieCol1.Name = "ImieCol1";
            this.ImieCol1.ReadOnly = true;
            // 
            // NazwiskoCol1
            // 
            this.NazwiskoCol1.DataPropertyName = "Nazwisko";
            this.NazwiskoCol1.HeaderText = "Nazwisko";
            this.NazwiskoCol1.Name = "NazwiskoCol1";
            this.NazwiskoCol1.ReadOnly = true;
            // 
            // NrIndeksuCol1
            // 
            this.NrIndeksuCol1.DataPropertyName = "IndexNumber";
            this.NrIndeksuCol1.HeaderText = "Numer Indeksu";
            this.NrIndeksuCol1.Name = "NrIndeksuCol1";
            this.NrIndeksuCol1.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Usun);
            this.panel1.Controls.Add(this.dodajButton1);
            this.panel1.Controls.Add(this.nazwiskoTextBox2);
            this.panel1.Controls.Add(this.imieTextBox1);
            this.panel1.Controls.Add(this.nazwiskoLabel);
            this.panel1.Controls.Add(this.ImieLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 316);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 100);
            this.panel1.TabIndex = 1;
            // 
            // Usun
            // 
            this.Usun.Location = new System.Drawing.Point(780, 16);
            this.Usun.Name = "Usun";
            this.Usun.Size = new System.Drawing.Size(94, 26);
            this.Usun.TabIndex = 5;
            this.Usun.Text = "Usun";
            this.Usun.UseVisualStyleBackColor = true;
            this.Usun.Click += new System.EventHandler(this.Usun_Click);
            // 
            // dodajButton1
            // 
            this.dodajButton1.Location = new System.Drawing.Point(901, 16);
            this.dodajButton1.Name = "dodajButton1";
            this.dodajButton1.Size = new System.Drawing.Size(95, 29);
            this.dodajButton1.TabIndex = 4;
            this.dodajButton1.Text = "Dodaj";
            this.dodajButton1.UseVisualStyleBackColor = true;
            this.dodajButton1.Click += new System.EventHandler(this.dodajButton1_Click_1);
            // 
            // nazwiskoTextBox2
            // 
            this.nazwiskoTextBox2.Enabled = false;
            this.nazwiskoTextBox2.Location = new System.Drawing.Point(142, 49);
            this.nazwiskoTextBox2.Name = "nazwiskoTextBox2";
            this.nazwiskoTextBox2.Size = new System.Drawing.Size(226, 23);
            this.nazwiskoTextBox2.TabIndex = 3;
            // 
            // imieTextBox1
            // 
            this.imieTextBox1.Enabled = false;
            this.imieTextBox1.Location = new System.Drawing.Point(142, 16);
            this.imieTextBox1.Name = "imieTextBox1";
            this.imieTextBox1.Size = new System.Drawing.Size(226, 23);
            this.imieTextBox1.TabIndex = 2;
            // 
            // nazwiskoLabel
            // 
            this.nazwiskoLabel.AutoSize = true;
            this.nazwiskoLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nazwiskoLabel.Location = new System.Drawing.Point(12, 47);
            this.nazwiskoLabel.Name = "nazwiskoLabel";
            this.nazwiskoLabel.Size = new System.Drawing.Size(99, 25);
            this.nazwiskoLabel.TabIndex = 1;
            this.nazwiskoLabel.Text = "Nazwisko:";
            // 
            // ImieLabel
            // 
            this.ImieLabel.AutoSize = true;
            this.ImieLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ImieLabel.Location = new System.Drawing.Point(56, 11);
            this.ImieLabel.Name = "ImieLabel";
            this.ImieLabel.Size = new System.Drawing.Size(55, 25);
            this.ImieLabel.TabIndex = 0;
            this.ImieLabel.Text = "Imie:";
            // 
            // OknoGlowneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 416);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StudencidataGridView);
            this.Name = "OknoGlowneForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Okno Glowne";
            ((System.ComponentModel.ISupportInitialize)(this.StudencidataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView StudencidataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImieCol1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazwiskoCol1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrIndeksuCol1;
        private System.Windows.Forms.TextBox nazwiskoTextBox2;
        private System.Windows.Forms.TextBox imieTextBox1;
        private System.Windows.Forms.Label nazwiskoLabel;
        private System.Windows.Forms.Label ImieLabel;
        private System.Windows.Forms.Button dodajButton1;
        private System.Windows.Forms.Button Usun;
    }
}
