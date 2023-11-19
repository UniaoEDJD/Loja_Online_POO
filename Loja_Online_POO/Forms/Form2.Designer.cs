namespace Loja_Online_POO
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
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.menu_Exit = new System.Windows.Forms.Button();
            this.editList = new System.Windows.Forms.Button();
            this.verEnc = new System.Windows.Forms.Button();
            this.AddProd = new System.Windows.Forms.Button();
            this.addCat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(130)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1419, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(130)))), ((int)(((byte)(245)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gestor da loja";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = global::Loja_Online_POO.Properties.Resources.Hamburger_icon_svg;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.ForeColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(0, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 24);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(1197, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Log-out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.menu_Exit);
            this.panel2.Controls.Add(this.editList);
            this.panel2.Controls.Add(this.verEnc);
            this.panel2.Controls.Add(this.AddProd);
            this.panel2.Controls.Add(this.addCat);
            this.panel2.Location = new System.Drawing.Point(0, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 574);
            this.panel2.TabIndex = 1;
            this.panel2.Visible = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(56, 404);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(210, 30);
            this.button3.TabIndex = 5;
            this.button3.Text = "Criar Fatura";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // menu_Exit
            // 
            this.menu_Exit.Location = new System.Drawing.Point(56, 519);
            this.menu_Exit.Name = "menu_Exit";
            this.menu_Exit.Size = new System.Drawing.Size(210, 41);
            this.menu_Exit.TabIndex = 4;
            this.menu_Exit.Text = "Exit";
            this.menu_Exit.UseVisualStyleBackColor = true;
            this.menu_Exit.Click += new System.EventHandler(this.menu_Exit_Click);
            // 
            // editList
            // 
            this.editList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editList.Location = new System.Drawing.Point(56, 321);
            this.editList.Name = "editList";
            this.editList.Size = new System.Drawing.Size(210, 30);
            this.editList.TabIndex = 3;
            this.editList.Text = "Lista de Clientes";
            this.editList.UseVisualStyleBackColor = true;
            this.editList.Visible = false;
            this.editList.Click += new System.EventHandler(this.button3_Click);
            // 
            // verEnc
            // 
            this.verEnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.verEnc.Location = new System.Drawing.Point(56, 243);
            this.verEnc.Name = "verEnc";
            this.verEnc.Size = new System.Drawing.Size(210, 30);
            this.verEnc.TabIndex = 2;
            this.verEnc.Text = "Ver Produtos";
            this.verEnc.UseVisualStyleBackColor = true;
            this.verEnc.Visible = false;
            this.verEnc.Click += new System.EventHandler(this.NavCat_Click);
            // 
            // AddProd
            // 
            this.AddProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProd.Location = new System.Drawing.Point(56, 162);
            this.AddProd.Name = "AddProd";
            this.AddProd.Size = new System.Drawing.Size(210, 30);
            this.AddProd.TabIndex = 1;
            this.AddProd.Text = "Produtos";
            this.AddProd.UseVisualStyleBackColor = true;
            this.AddProd.Visible = false;
            this.AddProd.Click += new System.EventHandler(this.AddProd_Click);
            // 
            // addCat
            // 
            this.addCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.addCat.Location = new System.Drawing.Point(56, 77);
            this.addCat.Name = "addCat";
            this.addCat.Size = new System.Drawing.Size(210, 30);
            this.addCat.TabIndex = 0;
            this.addCat.Text = "Categorias";
            this.addCat.UseVisualStyleBackColor = true;
            this.addCat.Visible = false;
            this.addCat.Click += new System.EventHandler(this.addCat_Click);
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
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button verEnc;
        private System.Windows.Forms.Button editList;
        private System.Windows.Forms.Button menu_Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
    }
}