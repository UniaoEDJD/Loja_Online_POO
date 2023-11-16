namespace Loja_Online_POO.Classes
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
            this.SuspendLayout();
            // 
            // prodID
            // 
            this.prodID.Location = new System.Drawing.Point(84, 63);
            this.prodID.Name = "prodID";
            this.prodID.Size = new System.Drawing.Size(100, 20);
            this.prodID.TabIndex = 0;
            // 
            // proName
            // 
            this.proName.Location = new System.Drawing.Point(84, 89);
            this.proName.Name = "proName";
            this.proName.Size = new System.Drawing.Size(100, 20);
            this.proName.TabIndex = 1;
            // 
            // ProdMarca
            // 
            this.ProdMarca.Location = new System.Drawing.Point(733, 63);
            this.ProdMarca.Name = "ProdMarca";
            this.ProdMarca.Size = new System.Drawing.Size(100, 20);
            this.ProdMarca.TabIndex = 2;
            // 
            // prodDesc
            // 
            this.prodDesc.Location = new System.Drawing.Point(84, 272);
            this.prodDesc.Multiline = true;
            this.prodDesc.Name = "prodDesc";
            this.prodDesc.Size = new System.Drawing.Size(333, 115);
            this.prodDesc.TabIndex = 3;
            this.prodDesc.TextChanged += new System.EventHandler(this.prodDesc_TextChanged);
            // 
            // Warranty
            // 
            this.Warranty.Location = new System.Drawing.Point(84, 415);
            this.Warranty.Name = "Warranty";
            this.Warranty.Size = new System.Drawing.Size(100, 20);
            this.Warranty.TabIndex = 4;
            // 
            // prodPrice
            // 
            this.prodPrice.Location = new System.Drawing.Point(733, 88);
            this.prodPrice.Name = "prodPrice";
            this.prodPrice.Size = new System.Drawing.Size(100, 20);
            this.prodPrice.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(84, 142);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(772, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 539);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.prodPrice);
            this.Controls.Add(this.Warranty);
            this.Controls.Add(this.prodDesc);
            this.Controls.Add(this.ProdMarca);
            this.Controls.Add(this.proName);
            this.Controls.Add(this.prodID);
            this.Name = "AddProd";
            this.Text = "AddProd";
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
    }
}