namespace CabinetMedical.Forms
{
    partial class RetetaForm
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
            this.MedicTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.PacientTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DiagnosticTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TratamentTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DataTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MedicTextBox
            // 
            this.MedicTextBox.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicTextBox.Location = new System.Drawing.Point(252, 137);
            this.MedicTextBox.Name = "MedicTextBox";
            this.MedicTextBox.Size = new System.Drawing.Size(261, 50);
            this.MedicTextBox.TabIndex = 2;
            this.MedicTextBox.TextChanged += new System.EventHandler(this.MedicTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Medic:";
            // 
            // SubmitButton
            // 
            this.SubmitButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SubmitButton.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(460, 653);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(236, 69);
            this.SubmitButton.TabIndex = 2;
            this.SubmitButton.Text = "Inregistrare";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // PacientTextBox
            // 
            this.PacientTextBox.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PacientTextBox.Location = new System.Drawing.Point(252, 206);
            this.PacientTextBox.Name = "PacientTextBox";
            this.PacientTextBox.Size = new System.Drawing.Size(261, 50);
            this.PacientTextBox.TabIndex = 4;
            this.PacientTextBox.TextChanged += new System.EventHandler(this.PacientTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pacient:";
            // 
            // DiagnosticTextBox
            // 
            this.DiagnosticTextBox.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiagnosticTextBox.Location = new System.Drawing.Point(103, 324);
            this.DiagnosticTextBox.Multiline = true;
            this.DiagnosticTextBox.Name = "DiagnosticTextBox";
            this.DiagnosticTextBox.Size = new System.Drawing.Size(998, 128);
            this.DiagnosticTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 42);
            this.label3.TabIndex = 5;
            this.label3.Text = "Diagnostic:";
            // 
            // TratamentTextBox
            // 
            this.TratamentTextBox.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TratamentTextBox.Location = new System.Drawing.Point(103, 506);
            this.TratamentTextBox.Multiline = true;
            this.TratamentTextBox.Name = "TratamentTextBox";
            this.TratamentTextBox.Size = new System.Drawing.Size(998, 128);
            this.TratamentTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 42);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tratament:";
            // 
            // DataTimePicker
            // 
            this.DataTimePicker.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataTimePicker.Location = new System.Drawing.Point(568, 206);
            this.DataTimePicker.Name = "DataTimePicker";
            this.DataTimePicker.Size = new System.Drawing.Size(542, 44);
            this.DataTimePicker.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(561, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 42);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data:";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTextBox.Location = new System.Drawing.Point(252, 63);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(261, 50);
            this.IdTextBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(96, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 42);
            this.label6.TabIndex = 11;
            this.label6.Text = "ID:";
            // 
            // RetetaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1198, 750);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DataTimePicker);
            this.Controls.Add(this.TratamentTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DiagnosticTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PacientTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MedicTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SubmitButton);
            this.Name = "RetetaForm";
            this.Text = "RetetaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox IdTextBox;
        public System.Windows.Forms.TextBox MedicTextBox;
        public System.Windows.Forms.TextBox PacientTextBox;
        public System.Windows.Forms.TextBox DiagnosticTextBox;
        public System.Windows.Forms.TextBox TratamentTextBox;
        public System.Windows.Forms.DateTimePicker DataTimePicker;
    }
}