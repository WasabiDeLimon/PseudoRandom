﻿
namespace ProyectoEquipo
{
    partial class PruebaVolados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tablaresultados = new System.Windows.Forms.DataGridView();
            this.ColnoCorridas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNumPseudo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFeria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColApuesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coldinero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colequis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtjuegos = new System.Windows.Forms.TextBox();
            this.txtapuesta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnjugar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txttope = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmontoinicial = new System.Windows.Forms.TextBox();
            this.lblVictoriaMagistral = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaresultados)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaresultados
            // 
            this.tablaresultados.AllowUserToAddRows = false;
            this.tablaresultados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(174)))));
            this.tablaresultados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaresultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaresultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColnoCorridas,
            this.ColNumPseudo,
            this.ColFeria,
            this.Colres,
            this.ColApuesta,
            this.Coldinero,
            this.Colequis});
            this.tablaresultados.Enabled = false;
            this.tablaresultados.GridColor = System.Drawing.Color.White;
            this.tablaresultados.Location = new System.Drawing.Point(12, 12);
            this.tablaresultados.MultiSelect = false;
            this.tablaresultados.Name = "tablaresultados";
            this.tablaresultados.ReadOnly = true;
            this.tablaresultados.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.tablaresultados.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaresultados.Size = new System.Drawing.Size(668, 291);
            this.tablaresultados.TabIndex = 13;
            this.tablaresultados.TabStop = false;
            // 
            // ColnoCorridas
            // 
            this.ColnoCorridas.HeaderText = "n";
            this.ColnoCorridas.Name = "ColnoCorridas";
            this.ColnoCorridas.ReadOnly = true;
            this.ColnoCorridas.Width = 60;
            // 
            // ColNumPseudo
            // 
            this.ColNumPseudo.HeaderText = "Rn";
            this.ColNumPseudo.Name = "ColNumPseudo";
            this.ColNumPseudo.ReadOnly = true;
            // 
            // ColFeria
            // 
            this.ColFeria.HeaderText = "Dinero antes/Volado";
            this.ColFeria.Name = "ColFeria";
            this.ColFeria.ReadOnly = true;
            // 
            // Colres
            // 
            this.Colres.HeaderText = "¿Se ganó el juego?";
            this.Colres.Name = "Colres";
            this.Colres.ReadOnly = true;
            // 
            // ColApuesta
            // 
            this.ColApuesta.HeaderText = "Apuesta";
            this.ColApuesta.Name = "ColApuesta";
            this.ColApuesta.ReadOnly = true;
            // 
            // Coldinero
            // 
            this.Coldinero.HeaderText = "Dinero despues/Volado";
            this.Coldinero.Name = "Coldinero";
            this.Coldinero.ReadOnly = true;
            // 
            // Colequis
            // 
            this.Colequis.HeaderText = "¿Se llegó a la meta?";
            this.Colequis.Name = "Colequis";
            this.Colequis.ReadOnly = true;
            // 
            // txtjuegos
            // 
            this.txtjuegos.Location = new System.Drawing.Point(53, 349);
            this.txtjuegos.Name = "txtjuegos";
            this.txtjuegos.Size = new System.Drawing.Size(100, 20);
            this.txtjuegos.TabIndex = 14;
            // 
            // txtapuesta
            // 
            this.txtapuesta.Location = new System.Drawing.Point(52, 406);
            this.txtapuesta.Name = "txtapuesta";
            this.txtapuesta.Size = new System.Drawing.Size(100, 20);
            this.txtapuesta.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Numero de juegos a realizar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Apuesta:";
            // 
            // btnjugar
            // 
            this.btnjugar.Location = new System.Drawing.Point(232, 391);
            this.btnjugar.Name = "btnjugar";
            this.btnjugar.Size = new System.Drawing.Size(77, 71);
            this.btnjugar.TabIndex = 18;
            this.btnjugar.Text = "Jugar";
            this.btnjugar.UseVisualStyleBackColor = true;
            this.btnjugar.Click += new System.EventHandler(this.btnjugar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 449);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Cantidad a llegar:";
            // 
            // txttope
            // 
            this.txttope.Location = new System.Drawing.Point(53, 465);
            this.txttope.Name = "txttope";
            this.txttope.Size = new System.Drawing.Size(100, 20);
            this.txttope.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Monto inicial:";
            // 
            // txtmontoinicial
            // 
            this.txtmontoinicial.Location = new System.Drawing.Point(223, 349);
            this.txtmontoinicial.Name = "txtmontoinicial";
            this.txtmontoinicial.Size = new System.Drawing.Size(100, 20);
            this.txtmontoinicial.TabIndex = 22;
            // 
            // lblVictoriaMagistral
            // 
            this.lblVictoriaMagistral.AutoSize = true;
            this.lblVictoriaMagistral.Location = new System.Drawing.Point(348, 391);
            this.lblVictoriaMagistral.Name = "lblVictoriaMagistral";
            this.lblVictoriaMagistral.Size = new System.Drawing.Size(10, 13);
            this.lblVictoriaMagistral.TabIndex = 23;
            this.lblVictoriaMagistral.Text = " ";
            this.lblVictoriaMagistral.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PruebaVolados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(693, 522);
            this.Controls.Add(this.lblVictoriaMagistral);
            this.Controls.Add(this.txtmontoinicial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttope);
            this.Controls.Add(this.btnjugar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtapuesta);
            this.Controls.Add(this.txtjuegos);
            this.Controls.Add(this.tablaresultados);
            this.Name = "PruebaVolados";
            this.Text = "PruebaVolados";
            this.Load += new System.EventHandler(this.PruebaVolados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaresultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaresultados;
        private System.Windows.Forms.TextBox txtjuegos;
        private System.Windows.Forms.TextBox txtapuesta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnjugar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttope;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColnoCorridas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNumPseudo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFeria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colres;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColApuesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coldinero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colequis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmontoinicial;
        private System.Windows.Forms.Label lblVictoriaMagistral;
    }
}