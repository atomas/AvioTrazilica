﻿namespace AvioTrazilica
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
            this.buttonPretrazi = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ColumnKratica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAerodrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBoxKratica = new System.Windows.Forms.TextBox();
            this.buttonPotragaKratice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxPolazniAerodrom
            // 
            this.txtBoxPolazniAerodrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPolazniAerodrom.Location = new System.Drawing.Point(14, 117);
            this.txtBoxPolazniAerodrom.Margin = new System.Windows.Forms.Padding(5);
            this.txtBoxPolazniAerodrom.Name = "txtBoxPolazniAerodrom";
            this.txtBoxPolazniAerodrom.Size = new System.Drawing.Size(150, 26);
            this.txtBoxPolazniAerodrom.TabIndex = 0;
            this.txtBoxPolazniAerodrom.Text = "Polazni aerodrom";
            // 
            // txtBoxBrojPutnika
            // 
            this.txtBoxBrojPutnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBrojPutnika.Location = new System.Drawing.Point(13, 14);
            this.txtBoxBrojPutnika.Margin = new System.Windows.Forms.Padding(5);
            this.txtBoxBrojPutnika.Name = "txtBoxBrojPutnika";
            this.txtBoxBrojPutnika.Size = new System.Drawing.Size(150, 26);
            this.txtBoxBrojPutnika.TabIndex = 2;
            this.txtBoxBrojPutnika.Text = "Broj putnika";
            // 
            // txtBoxValuta
            // 
            this.txtBoxValuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxValuta.Location = new System.Drawing.Point(13, 66);
            this.txtBoxValuta.Margin = new System.Windows.Forms.Padding(5);
            this.txtBoxValuta.Name = "txtBoxValuta";
            this.txtBoxValuta.Size = new System.Drawing.Size(150, 26);
            this.txtBoxValuta.TabIndex = 3;
            this.txtBoxValuta.Text = "Valuta";
            // 
            // datePolazak
            // 
            this.datePolazak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePolazak.Location = new System.Drawing.Point(192, 64);
            this.datePolazak.Margin = new System.Windows.Forms.Padding(5);
            this.datePolazak.Name = "datePolazak";
            this.datePolazak.Size = new System.Drawing.Size(200, 26);
            this.datePolazak.TabIndex = 4;
            // 
            // datePovratak
            // 
            this.datePovratak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePovratak.Location = new System.Drawing.Point(433, 64);
            this.datePovratak.Margin = new System.Windows.Forms.Padding(5);
            this.datePovratak.Name = "datePovratak";
            this.datePovratak.Size = new System.Drawing.Size(200, 26);
            this.datePovratak.TabIndex = 5;
            // 
            // buttonPretrazi
            // 
            this.buttonPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPretrazi.Location = new System.Drawing.Point(14, 165);
            this.buttonPretrazi.Margin = new System.Windows.Forms.Padding(5);
            this.buttonPretrazi.Name = "buttonPretrazi";
            this.buttonPretrazi.Size = new System.Drawing.Size(619, 40);
            this.buttonPretrazi.TabIndex = 6;
            this.buttonPretrazi.Text = "Pretraži letove";
            this.buttonPretrazi.UseVisualStyleBackColor = true;
            this.buttonPretrazi.Click += new System.EventHandler(this.buttonPretrazi_Click);
            // 
            // txtBoxOdredisniAerodrom
            // 
            this.txtBoxOdredisniAerodrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxOdredisniAerodrom.Location = new System.Drawing.Point(192, 117);
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
            this.labelDatumPolaska.Location = new System.Drawing.Point(188, 39);
            this.labelDatumPolaska.Name = "labelDatumPolaska";
            this.labelDatumPolaska.Size = new System.Drawing.Size(120, 20);
            this.labelDatumPolaska.TabIndex = 8;
            this.labelDatumPolaska.Text = "Datum polaska:";
            // 
            // labelDatumPovratka
            // 
            this.labelDatumPovratka.AutoSize = true;
            this.labelDatumPovratka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatumPovratka.Location = new System.Drawing.Point(429, 39);
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
            this.dataGridView1.Location = new System.Drawing.Point(13, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1238, 529);
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
            this.ColumnBrojPresjedanja.HeaderText = "Broj presjedanja polazak/povratak";
            this.ColumnBrojPresjedanja.Name = "ColumnBrojPresjedanja";
            // 
            // ColumnBrojPutnika
            // 
            this.ColumnBrojPutnika.HeaderText = "Broj putnika";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(726, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ovdje možete provjeriti kraticu za aerodrom koji vas zanima";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnKratica,
            this.ColumnAerodrom});
            this.dataGridView2.Location = new System.Drawing.Point(901, 50);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(350, 157);
            this.dataGridView2.TabIndex = 12;
            // 
            // ColumnKratica
            // 
            this.ColumnKratica.HeaderText = "Kratica";
            this.ColumnKratica.Name = "ColumnKratica";
            // 
            // ColumnAerodrom
            // 
            this.ColumnAerodrom.HeaderText = "Aerodrom";
            this.ColumnAerodrom.Name = "ColumnAerodrom";
            this.ColumnAerodrom.Width = 200;
            // 
            // txtBoxKratica
            // 
            this.txtBoxKratica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxKratica.Location = new System.Drawing.Point(729, 50);
            this.txtBoxKratica.Name = "txtBoxKratica";
            this.txtBoxKratica.Size = new System.Drawing.Size(166, 26);
            this.txtBoxKratica.TabIndex = 13;
            this.txtBoxKratica.Text = "Unesite grad";
            // 
            // buttonPotragaKratice
            // 
            this.buttonPotragaKratice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPotragaKratice.Location = new System.Drawing.Point(729, 86);
            this.buttonPotragaKratice.Name = "buttonPotragaKratice";
            this.buttonPotragaKratice.Size = new System.Drawing.Size(166, 40);
            this.buttonPotragaKratice.TabIndex = 14;
            this.buttonPotragaKratice.Text = "Potraži kraticu";
            this.buttonPotragaKratice.UseVisualStyleBackColor = true;
            this.buttonPotragaKratice.Click += new System.EventHandler(this.buttonPotragaKratice_Click);
            // 
            // FormAvioTrazilica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 754);
            this.Controls.Add(this.buttonPotragaKratice);
            this.Controls.Add(this.txtBoxKratica);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelDatumPovratka);
            this.Controls.Add(this.labelDatumPolaska);
            this.Controls.Add(this.txtBoxOdredisniAerodrom);
            this.Controls.Add(this.buttonPretrazi);
            this.Controls.Add(this.datePovratak);
            this.Controls.Add(this.datePolazak);
            this.Controls.Add(this.txtBoxValuta);
            this.Controls.Add(this.txtBoxBrojPutnika);
            this.Controls.Add(this.txtBoxPolazniAerodrom);
            this.Name = "FormAvioTrazilica";
            this.Text = "Avio Tražilica";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxPolazniAerodrom;
        private System.Windows.Forms.TextBox txtBoxBrojPutnika;
        private System.Windows.Forms.TextBox txtBoxValuta;
        private System.Windows.Forms.DateTimePicker datePolazak;
        private System.Windows.Forms.DateTimePicker datePovratak;
        private System.Windows.Forms.Button buttonPretrazi;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKratica;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAerodrom;
        private System.Windows.Forms.TextBox txtBoxKratica;
        private System.Windows.Forms.Button buttonPotragaKratice;
    }
}

