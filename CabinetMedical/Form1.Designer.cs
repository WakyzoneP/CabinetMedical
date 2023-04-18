namespace CabinetMedical
{
    partial class Form1
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
            this.MedicButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PacientButton = new System.Windows.Forms.Button();
            this.RetetaButton = new System.Windows.Forms.Button();
            this.panelForm = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // MedicButton
            // 
            this.MedicButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(186)))), ((int)(((byte)(140)))));
            this.MedicButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicButton.Location = new System.Drawing.Point(12, 78);
            this.MedicButton.Name = "MedicButton";
            this.MedicButton.Size = new System.Drawing.Size(420, 261);
            this.MedicButton.TabIndex = 1;
            this.MedicButton.Text = "&Medici";
            this.MedicButton.UseVisualStyleBackColor = false;
            this.MedicButton.Click += new System.EventHandler(this.MedicButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Arial", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(157)))), ((int)(((byte)(187)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1650, 66);
            this.label1.TabIndex = 2;
            this.label1.Text = "CABINET MEDICAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PacientButton
            // 
            this.PacientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(186)))), ((int)(((byte)(140)))));
            this.PacientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PacientButton.Location = new System.Drawing.Point(12, 345);
            this.PacientButton.Name = "PacientButton";
            this.PacientButton.Size = new System.Drawing.Size(420, 272);
            this.PacientButton.TabIndex = 3;
            this.PacientButton.Text = "&Pacienti";
            this.PacientButton.UseVisualStyleBackColor = false;
            this.PacientButton.Click += new System.EventHandler(this.PacientButton_Click);
            // 
            // RetetaButton
            // 
            this.RetetaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(186)))), ((int)(((byte)(140)))));
            this.RetetaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetetaButton.Location = new System.Drawing.Point(12, 623);
            this.RetetaButton.Name = "RetetaButton";
            this.RetetaButton.Size = new System.Drawing.Size(420, 276);
            this.RetetaButton.TabIndex = 4;
            this.RetetaButton.Text = "&Retete";
            this.RetetaButton.UseVisualStyleBackColor = false;
            this.RetetaButton.Click += new System.EventHandler(this.RetetaButton_Click);
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.PeachPuff;
            this.panelForm.Location = new System.Drawing.Point(438, 78);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(1224, 821);
            this.panelForm.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(157)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(1674, 911);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.RetetaButton);
            this.Controls.Add(this.PacientButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MedicButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button MedicButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PacientButton;
        private System.Windows.Forms.Button RetetaButton;
        private System.Windows.Forms.Panel panelForm;
    }
}

