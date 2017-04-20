namespace AvioTrazilica
{
    partial class FormAvioTrazilica
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
            this.txtBoxPolazniAerodrom = new System.Windows.Forms.TextBox();
            this.txtBoxBrojPutnika = new System.Windows.Forms.TextBox();
            this.txtBoxValuta = new System.Windows.Forms.TextBox();
            this.datePolazak = new System.Windows.Forms.DateTimePicker();
            this.datePovratak = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBoxOdredisniAerodrom = new System.Windows.Forms.TextBox();
            this.labelDatumPolaska = new System.Windows.Forms.Label();
            this.labelDatumPovratka = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnPolazniAerodrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOdlazniAerodrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumndDatumiPolaskaPovratka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBrojPresjedanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBrojPutnika = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValuta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUkupnaCijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxPolazniAerodrom
            // 
            this.txtBoxPolazniAerodrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPolazniAerodrom.Location = new System.Drawing.Point(14, 14);
            this.txtBoxPolazniAerodrom.Margin = new System.Windows.Forms.Padding(5);
            this.txtBoxPolazniAerodrom.Name = "txtBoxPolazniAerodrom";
            this.txtBoxPolazniAerodrom.Size = new System.Drawing.Size(150, 26);
            this.txtBoxPolazniAerodrom.TabIndex = 0;
            this.txtBoxPolazniAerodrom.Text = "Polazni aerodrom";
            // 
            // txtBoxBrojPutnika
            // 
            this.txtBoxBrojPutnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBrojPutnika.Location = new System.Drawing.Point(14, 50);
            this.txtBoxBrojPutnika.Margin = new System.Windows.Forms.Padding(5);
            this.txtBoxBrojPutnika.Name = "txtBoxBrojPutnika";
            this.txtBoxBrojPutnika.Size = new System.Drawing.Size(150, 26);
            this.txtBoxBrojPutnika.TabIndex = 2;
            this.txtBoxBrojPutnika.Text = "Broj putnika";
            // 
            // txtBoxValuta
            // 
            this.txtBoxValuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxValuta.Location = new System.Drawing.Point(14, 86);
            this.txtBoxValuta.Margin = new System.Windows.Forms.Padding(5);
            this.txtBoxValuta.Name = "txtBoxValuta";
            this.txtBoxValuta.Size = new System.Drawing.Size(150, 26);
            this.txtBoxValuta.TabIndex = 3;
            this.txtBoxValuta.Text = "Valuta";
            // 
            // datePolazak
            // 
            this.datePolazak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePolazak.Location = new System.Drawing.Point(354, 50);
            this.datePolazak.Margin = new System.Windows.Forms.Padding(5);
            this.datePolazak.Name = "datePolazak";
            this.datePolazak.Size = new System.Drawing.Size(200, 26);
            this.datePolazak.TabIndex = 4;
            // 
            // datePovratak
            // 
            this.datePovratak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePovratak.Location = new System.Drawing.Point(564, 50);
            this.datePovratak.Margin = new System.Windows.Forms.Padding(5);
            this.datePovratak.Name = "datePovratak";
            this.datePovratak.Size = new System.Drawing.Size(200, 26);
            this.datePovratak.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(896, 43);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Pretraži letove";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtBoxOdredisniAerodrom
            // 
            this.txtBoxOdredisniAerodrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxOdredisniAerodrom.Location = new System.Drawing.Point(174, 14);
            this.txtBoxOdredisniAerodrom.Margin = new System.Windows.Forms.Padding(5);
            this.txtBoxOdredisniAerodrom.Name = "txtBoxOdredisniAerodrom";
            this.txtBoxOdredisniAerodrom.Size = new System.Drawing.Size(150, 26);
            this.txtBoxOdredisniAerodrom.TabIndex = 7;
            this.txtBoxOdredisniAerodrom.Text = "Odredišni aerodrom";
            // 
            // labelDatumPolaska
            // 
            this.labelDatumPolaska.AutoSize = true;
            this.labelDatumPolaska.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatumPolaska.Location = new System.Drawing.Point(350, 17);
            this.labelDatumPolaska.Name = "labelDatumPolaska";
            this.labelDatumPolaska.Size = new System.Drawing.Size(120, 20);
            this.labelDatumPolaska.TabIndex = 8;
            this.labelDatumPolaska.Text = "Datum polaska:";
            // 
            // labelDatumPovratka
            // 
            this.labelDatumPovratka.AutoSize = true;
            this.labelDatumPovratka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatumPovratka.Location = new System.Drawing.Point(560, 17);
            this.labelDatumPovratka.Name = "labelDatumPovratka";
            this.labelDatumPovratka.Size = new System.Drawing.Size(126, 20);
            this.labelDatumPovratka.TabIndex = 9;
            this.labelDatumPovratka.Text = "Datum povratka:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPolazniAerodrom,
            this.ColumnOdlazniAerodrom,
            this.ColumndDatumiPolaskaPovratka,
            this.ColumnBrojPresjedanja,
            this.ColumnBrojPutnika,
            this.ColumnValuta,
            this.ColumnUkupnaCijena});
            this.dataGridView1.Location = new System.Drawing.Point(13, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1145, 621);
            this.dataGridView1.TabIndex = 10;
            // 
            // ColumnPolazniAerodrom
            // 
            this.ColumnPolazniAerodrom.HeaderText = "Polazni aerodrom";
            this.ColumnPolazniAerodrom.Name = "ColumnPolazniAerodrom";
            this.ColumnPolazniAerodrom.Width = 200;
            // 
            // ColumnOdlazniAerodrom
            // 
            this.ColumnOdlazniAerodrom.HeaderText = "Odredišni aerodrom";
            this.ColumnOdlazniAerodrom.Name = "ColumnOdlazniAerodrom";
            this.ColumnOdlazniAerodrom.Width = 200;
            // 
            // ColumndDatumiPolaskaPovratka
            // 
            this.ColumndDatumiPolaskaPovratka.HeaderText = "Datum polaska/povratka";
            this.ColumndDatumiPolaskaPovratka.Name = "ColumndDatumiPolaskaPovratka";
            this.ColumndDatumiPolaskaPovratka.Width = 200;
            // 
            // ColumnBrojPresjedanja
            // 
            this.ColumnBrojPresjedanja.HeaderText = "Broj presjedanja";
            this.ColumnBrojPresjedanja.Name = "ColumnBrojPresjedanja";
            // 
            // ColumnBrojPutnika
            // 
            this.ColumnBrojPutnika.HeaderText = "BrojPutnika";
            this.ColumnBrojPutnika.Name = "ColumnBrojPutnika";
            // 
            // ColumnValuta
            // 
            this.ColumnValuta.HeaderText = "Valuta";
            this.ColumnValuta.Name = "ColumnValuta";
            // 
            // ColumnUkupnaCijena
            // 
            this.ColumnUkupnaCijena.HeaderText = "Ukupna cijena";
            this.ColumnUkupnaCijena.Name = "ColumnUkupnaCijena";
            this.ColumnUkupnaCijena.Width = 200;
            // 
            // FormAvioTrazilica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 754);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelDatumPovratka);
            this.Controls.Add(this.labelDatumPolaska);
            this.Controls.Add(this.txtBoxOdredisniAerodrom);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.datePovratak);
            this.Controls.Add(this.datePolazak);
            this.Controls.Add(this.txtBoxValuta);
            this.Controls.Add(this.txtBoxBrojPutnika);
            this.Controls.Add(this.txtBoxPolazniAerodrom);
            this.Name = "FormAvioTrazilica";
            this.Text = "Avio Tražilica";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxPolazniAerodrom;
        private System.Windows.Forms.TextBox txtBoxBrojPutnika;
        private System.Windows.Forms.TextBox txtBoxValuta;
        private System.Windows.Forms.DateTimePicker datePolazak;
        private System.Windows.Forms.DateTimePicker datePovratak;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBoxOdredisniAerodrom;
        private System.Windows.Forms.Label labelDatumPolaska;
        private System.Windows.Forms.Label labelDatumPovratka;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPolazniAerodrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOdlazniAerodrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumndDatumiPolaskaPovratka;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBrojPresjedanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBrojPutnika;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValuta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUkupnaCijena;
    }
}

