﻿namespace Loja_Online_POO.Classes
{
    partial class AddProd
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
            this.prodID = new System.Windows.Forms.TextBox();
            this.proName = new System.Windows.Forms.TextBox();
            this.ProdMarca = new System.Windows.Forms.TextBox();
            this.prodDesc = new System.Windows.Forms.TextBox();
            this.Warranty = new System.Windows.Forms.TextBox();
            this.prodPrice = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.stockBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.retornar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // prodID
            // 
            this.prodID.Location = new System.Drawing.Point(84, 163);
            this.prodID.Name = "prodID";
            this.prodID.Size = new System.Drawing.Size(100, 20);
            this.prodID.TabIndex = 0;
            // 
            // proName
            // 
            this.proName.Location = new System.Drawing.Point(84, 137);
            this.proName.Name = "proName";
            this.proName.Size = new System.Drawing.Size(100, 20);
            this.proName.TabIndex = 1;
            // 
            // ProdMarca
            // 
            this.ProdMarca.Location = new System.Drawing.Point(84, 189);
            this.ProdMarca.Name = "ProdMarca";
            this.ProdMarca.Size = new System.Drawing.Size(100, 20);
            this.ProdMarca.TabIndex = 2;
            // 
            // prodDesc
            // 
            this.prodDesc.Location = new System.Drawing.Point(84, 284);
            this.prodDesc.Multiline = true;
            this.prodDesc.Name = "prodDesc";
            this.prodDesc.Size = new System.Drawing.Size(333, 115);
            this.prodDesc.TabIndex = 3;
            this.prodDesc.TextChanged += new System.EventHandler(this.prodDesc_TextChanged);
            // 
            // Warranty
            // 
            this.Warranty.Location = new System.Drawing.Point(317, 405);
            this.Warranty.Name = "Warranty";
            this.Warranty.Size = new System.Drawing.Size(100, 20);
            this.Warranty.TabIndex = 4;
            // 
            // prodPrice
            // 
            this.prodPrice.Location = new System.Drawing.Point(828, 379);
            this.prodPrice.Name = "prodPrice";
            this.prodPrice.Size = new System.Drawing.Size(100, 20);
            this.prodPrice.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(84, 257);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(828, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Adicionar Produto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // stockBox
            // 
            this.stockBox.Location = new System.Drawing.Point(84, 215);
            this.stockBox.Name = "stockBox";
            this.stockBox.Size = new System.Drawing.Size(100, 20);
            this.stockBox.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(130)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.retornar);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 81);
            this.panel1.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Snow;
            this.label9.Location = new System.Drawing.Point(68, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(246, 31);
            this.label9.TabIndex = 1;
            this.label9.Text = "Adicionar Produto";
            // 
            // retornar
            // 
            this.retornar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retornar.Location = new System.Drawing.Point(856, 12);
            this.retornar.Name = "retornar";
            this.retornar.Size = new System.Drawing.Size(84, 26);
            this.retornar.TabIndex = 0;
            this.retornar.Text = "Return";
            this.retornar.UseVisualStyleBackColor = true;
            this.retornar.Click += new System.EventHandler(this.retornar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Categoria:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Marca:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Stock:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Descrição:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Garantia:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(858, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Preço";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox2.Location = new System.Drawing.Point(528, 123);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(379, 212);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // AddProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 468);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.stockBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.prodPrice);
            this.Controls.Add(this.Warranty);
            this.Controls.Add(this.prodDesc);
            this.Controls.Add(this.ProdMarca);
            this.Controls.Add(this.proName);
            this.Controls.Add(this.prodID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProd";
            this.Load += new System.EventHandler(this.AddProd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox prodID;
        private System.Windows.Forms.TextBox proName;
        private System.Windows.Forms.TextBox ProdMarca;
        private System.Windows.Forms.TextBox prodDesc;
        private System.Windows.Forms.TextBox Warranty;
        private System.Windows.Forms.TextBox prodPrice;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox stockBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button retornar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}