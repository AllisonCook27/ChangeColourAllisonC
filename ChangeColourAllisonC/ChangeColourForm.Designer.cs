namespace ChangeColourAllisonC
{
    partial class frmChangeColour
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
            this.lblChangeColour = new System.Windows.Forms.Label();
            this.btnChangeColour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChangeColour
            // 
            this.lblChangeColour.AutoSize = true;
            this.lblChangeColour.BackColor = System.Drawing.Color.AliceBlue;
            this.lblChangeColour.Font = new System.Drawing.Font("Kozuka Mincho Pr6N H", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblChangeColour.Location = new System.Drawing.Point(72, 152);
            this.lblChangeColour.Name = "lblChangeColour";
            this.lblChangeColour.Size = new System.Drawing.Size(125, 28);
            this.lblChangeColour.TabIndex = 0;
            this.lblChangeColour.Text = "Change Colour";
            this.lblChangeColour.Click += new System.EventHandler(this.lblChangeColour_Click);
            // 
            // btnChangeColour
            // 
            this.btnChangeColour.Font = new System.Drawing.Font("Kozuka Mincho Pr6N H", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeColour.Location = new System.Drawing.Point(65, 59);
            this.btnChangeColour.Name = "btnChangeColour";
            this.btnChangeColour.Size = new System.Drawing.Size(143, 38);
            this.btnChangeColour.TabIndex = 1;
            this.btnChangeColour.Text = "Change Colour";
            this.btnChangeColour.UseVisualStyleBackColor = true;
            this.btnChangeColour.Click += new System.EventHandler(this.btnChangeColour_Click);
            // 
            // frmChangeColour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnChangeColour);
            this.Controls.Add(this.lblChangeColour);
            this.Name = "frmChangeColour";
            this.Text = "Chnage Colour by Allison C";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChangeColour;
        private System.Windows.Forms.Button btnChangeColour;
    }
}

