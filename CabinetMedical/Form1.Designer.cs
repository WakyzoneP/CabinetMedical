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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reteteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView = new System.Windows.Forms.ListView();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.medicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MedicButton
            // 
            this.MedicButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(186)))), ((int)(((byte)(140)))));
            this.MedicButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicButton.Location = new System.Drawing.Point(12, 109);
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
            this.label1.Location = new System.Drawing.Point(12, 40);
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
            this.PacientButton.Location = new System.Drawing.Point(12, 376);
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
            this.RetetaButton.Location = new System.Drawing.Point(12, 654);
            this.RetetaButton.Name = "RetetaButton";
            this.RetetaButton.Size = new System.Drawing.Size(420, 245);
            this.RetetaButton.TabIndex = 4;
            this.RetetaButton.Text = "&Retete";
            this.RetetaButton.UseVisualStyleBackColor = false;
            this.RetetaButton.Click += new System.EventHandler(this.RetetaButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.insertToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1674, 42);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(71, 44);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mediciToolStripMenuItem,
            this.pacientiToolStripMenuItem,
            this.reteteToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(197, 44);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // mediciToolStripMenuItem
            // 
            this.mediciToolStripMenuItem.Name = "mediciToolStripMenuItem";
            this.mediciToolStripMenuItem.Size = new System.Drawing.Size(229, 44);
            this.mediciToolStripMenuItem.Text = "Medici";
            this.mediciToolStripMenuItem.Click += new System.EventHandler(this.mediciToolStripMenuItem_Click);
            // 
            // pacientiToolStripMenuItem
            // 
            this.pacientiToolStripMenuItem.Name = "pacientiToolStripMenuItem";
            this.pacientiToolStripMenuItem.Size = new System.Drawing.Size(229, 44);
            this.pacientiToolStripMenuItem.Text = "Pacienti";
            // 
            // reteteToolStripMenuItem
            // 
            this.reteteToolStripMenuItem.Name = "reteteToolStripMenuItem";
            this.reteteToolStripMenuItem.Size = new System.Drawing.Size(229, 44);
            this.reteteToolStripMenuItem.Text = "Retete";
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(439, 109);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(1223, 790);
            this.listView.TabIndex = 7;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertToolStripMenuItem1});
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(121, 38);
            this.insertToolStripMenuItem.Text = "Manage";
            // 
            // insertToolStripMenuItem1
            // 
            this.insertToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicToolStripMenuItem,
            this.pacientToolStripMenuItem,
            this.retetaToolStripMenuItem});
            this.insertToolStripMenuItem1.Name = "insertToolStripMenuItem1";
            this.insertToolStripMenuItem1.Size = new System.Drawing.Size(359, 44);
            this.insertToolStripMenuItem1.Text = "Insert";
            // 
            // medicToolStripMenuItem
            // 
            this.medicToolStripMenuItem.Name = "medicToolStripMenuItem";
            this.medicToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.medicToolStripMenuItem.Text = "Medic";
            this.medicToolStripMenuItem.Click += new System.EventHandler(this.medicToolStripMenuItem_Click);
            // 
            // pacientToolStripMenuItem
            // 
            this.pacientToolStripMenuItem.Name = "pacientToolStripMenuItem";
            this.pacientToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.pacientToolStripMenuItem.Text = "Pacient";
            this.pacientToolStripMenuItem.Click += new System.EventHandler(this.pacientToolStripMenuItem_Click);
            // 
            // retetaToolStripMenuItem
            // 
            this.retetaToolStripMenuItem.Name = "retetaToolStripMenuItem";
            this.retetaToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.retetaToolStripMenuItem.Text = "Reteta";
            this.retetaToolStripMenuItem.Click += new System.EventHandler(this.retetaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(157)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(1674, 911);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.RetetaButton);
            this.Controls.Add(this.PacientButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MedicButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button MedicButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PacientButton;
        private System.Windows.Forms.Button RetetaButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reteteToolStripMenuItem;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem medicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retetaToolStripMenuItem;
    }
}

