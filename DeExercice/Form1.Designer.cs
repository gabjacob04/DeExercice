namespace DeExercice
{
    partial class Form1
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
            this.btnBrasser = new System.Windows.Forms.Button();
            this.lblNombreObtenue = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTypeDe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBrasser
            // 
            this.btnBrasser.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBrasser.Location = new System.Drawing.Point(150, 220);
            this.btnBrasser.Name = "btnBrasser";
            this.btnBrasser.Size = new System.Drawing.Size(428, 209);
            this.btnBrasser.TabIndex = 0;
            this.btnBrasser.Text = "Brasser!";
            this.btnBrasser.UseVisualStyleBackColor = true;
            this.btnBrasser.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNombreObtenue
            // 
            this.lblNombreObtenue.AutoSize = true;
            this.lblNombreObtenue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombreObtenue.Location = new System.Drawing.Point(12, 68);
            this.lblNombreObtenue.Name = "lblNombreObtenue";
            this.lblNombreObtenue.Size = new System.Drawing.Size(304, 46);
            this.lblNombreObtenue.TabIndex = 1;
            this.lblNombreObtenue.Text = "Nombre obtenue : ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(12, 131);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(200, 46);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Point total : ";
            // 
            // lblTypeDe
            // 
            this.lblTypeDe.AutoSize = true;
            this.lblTypeDe.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTypeDe.Location = new System.Drawing.Point(12, 9);
            this.lblTypeDe.Name = "lblTypeDe";
            this.lblTypeDe.Size = new System.Drawing.Size(200, 46);
            this.lblTypeDe.TabIndex = 3;
            this.lblTypeDe.Text = "Type de dé :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTypeDe);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblNombreObtenue);
            this.Controls.Add(this.btnBrasser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBrasser;
        private Label lblNombreObtenue;
        private Label lblTotal;
        private Label lblTypeDe;
    }
}