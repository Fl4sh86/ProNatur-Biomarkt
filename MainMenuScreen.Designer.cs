
namespace ProNatur_Biomarkt_GmbH
{
    partial class MainMenuScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuScreen));
            this.btmProducts = new System.Windows.Forms.Button();
            this.btmBill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btmProducts
            // 
            this.btmProducts.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btmProducts.BackgroundImage")));
            this.btmProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmProducts.ForeColor = System.Drawing.Color.White;
            this.btmProducts.Location = new System.Drawing.Point(41, 55);
            this.btmProducts.Name = "btmProducts";
            this.btmProducts.Size = new System.Drawing.Size(321, 125);
            this.btmProducts.TabIndex = 0;
            this.btmProducts.Text = "Produkte verwalten";
            this.btmProducts.UseVisualStyleBackColor = true;
            this.btmProducts.Click += new System.EventHandler(this.btmProducts_Click);
            // 
            // btmBill
            // 
            this.btmBill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btmBill.BackgroundImage")));
            this.btmBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmBill.ForeColor = System.Drawing.Color.White;
            this.btmBill.Location = new System.Drawing.Point(391, 55);
            this.btmBill.Name = "btmBill";
            this.btmBill.Size = new System.Drawing.Size(321, 125);
            this.btmBill.TabIndex = 1;
            this.btmBill.Text = "Rechnung erstellen";
            this.btmBill.UseVisualStyleBackColor = true;
            // 
            // MainMenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(749, 233);
            this.Controls.Add(this.btmBill);
            this.Controls.Add(this.btmProducts);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainMenuScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hauptmenü";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btmProducts;
        private System.Windows.Forms.Button btmBill;
    }
}