﻿namespace Loja_Online_POO
{
    partial class StoreFront
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addCat = new System.Windows.Forms.Button();
            this.AddProd = new System.Windows.Forms.Button();
            this.NavCat = new System.Windows.Forms.Button();
            this.editList = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(130)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1419, 100);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Loja_Online_POO.Properties.Resources.Hamburger_icon_svg;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(0, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 24);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(1216, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Log-out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.editList);
            this.panel2.Controls.Add(this.NavCat);
            this.panel2.Controls.Add(this.AddProd);
            this.panel2.Controls.Add(this.addCat);
            this.panel2.Location = new System.Drawing.Point(0, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 574);
            this.panel2.TabIndex = 1;
            this.panel2.Visible = false;
            // 
            // addCat
            // 
            this.addCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.addCat.Location = new System.Drawing.Point(56, 84);
            this.addCat.Name = "addCat";
            this.addCat.Size = new System.Drawing.Size(210, 30);
            this.addCat.TabIndex = 0;
            this.addCat.Text = "Adicionar Categoria";
            this.addCat.UseVisualStyleBackColor = true;
            this.addCat.Visible = false;
            this.addCat.Click += new System.EventHandler(this.addCat_Click);
            // 
            // AddProd
            // 
            this.AddProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProd.Location = new System.Drawing.Point(56, 158);
            this.AddProd.Name = "AddProd";
            this.AddProd.Size = new System.Drawing.Size(210, 30);
            this.AddProd.TabIndex = 1;
            this.AddProd.Text = "Adicionar Produto";
            this.AddProd.UseVisualStyleBackColor = true;
            this.AddProd.Visible = false;
            this.AddProd.Click += new System.EventHandler(this.AddProd_Click);
            // 
            // NavCat
            // 
            this.NavCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.NavCat.Location = new System.Drawing.Point(56, 228);
            this.NavCat.Name = "NavCat";
            this.NavCat.Size = new System.Drawing.Size(210, 30);
            this.NavCat.TabIndex = 2;
            this.NavCat.Text = "Navegar Categorias";
            this.NavCat.UseVisualStyleBackColor = true;
            this.NavCat.Visible = false;
            this.NavCat.Click += new System.EventHandler(this.NavCat_Click);
            // 
            // editList
            // 
            this.editList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editList.Location = new System.Drawing.Point(56, 297);
            this.editList.Name = "editList";
            this.editList.Size = new System.Drawing.Size(210, 30);
            this.editList.TabIndex = 3;
            this.editList.Text = "Editar Lista Clientes";
            this.editList.UseVisualStyleBackColor = true;
            this.editList.Visible = false;
            this.editList.Click += new System.EventHandler(this.button3_Click);
            // 
            // StoreFront
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1307, 671);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "StoreFront";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StoreFront";
            this.Load += new System.EventHandler(this.StoreFront_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addCat;
        private System.Windows.Forms.Button AddProd;
        private System.Windows.Forms.Button NavCat;
        private System.Windows.Forms.Button editList;
    }
}