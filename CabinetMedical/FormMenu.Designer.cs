namespace CabinetMedical
{
    partial class FormMenu
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
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediciToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reteteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.medicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView = new System.Windows.Forms.ListView();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertIntoDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getDataFromDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.insertToolStripMenuItem,
            this.chartToolStripMenuItem,
            this.databaseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1674, 48);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(71, 38);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mediciToolStripMenuItem,
            this.pacientiToolStripMenuItem,
            this.reteteToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(206, 44);
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
            this.pacientiToolStripMenuItem.Click += new System.EventHandler(this.pacientiToolStripMenuItem_Click);
            // 
            // reteteToolStripMenuItem
            // 
            this.reteteToolStripMenuItem.Name = "reteteToolStripMenuItem";
            this.reteteToolStripMenuItem.Size = new System.Drawing.Size(229, 44);
            this.reteteToolStripMenuItem.Text = "Retete";
            this.reteteToolStripMenuItem.Click += new System.EventHandler(this.reteteToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mediciToolStripMenuItem1,
            this.pacientiToolStripMenuItem1,
            this.reteteToolStripMenuItem1});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(206, 44);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // mediciToolStripMenuItem1
            // 
            this.mediciToolStripMenuItem1.Name = "mediciToolStripMenuItem1";
            this.mediciToolStripMenuItem1.Size = new System.Drawing.Size(229, 44);
            this.mediciToolStripMenuItem1.Text = "Medici";
            this.mediciToolStripMenuItem1.Click += new System.EventHandler(this.mediciToolStripMenuItem1_Click);
            // 
            // pacientiToolStripMenuItem1
            // 
            this.pacientiToolStripMenuItem1.Name = "pacientiToolStripMenuItem1";
            this.pacientiToolStripMenuItem1.Size = new System.Drawing.Size(229, 44);
            this.pacientiToolStripMenuItem1.Text = "Pacienti";
            this.pacientiToolStripMenuItem1.Click += new System.EventHandler(this.pacientiToolStripMenuItem1_Click);
            // 
            // reteteToolStripMenuItem1
            // 
            this.reteteToolStripMenuItem1.Name = "reteteToolStripMenuItem1";
            this.reteteToolStripMenuItem1.Size = new System.Drawing.Size(229, 44);
            this.reteteToolStripMenuItem1.Text = "Retete";
            this.reteteToolStripMenuItem1.Click += new System.EventHandler(this.reteteToolStripMenuItem1_Click);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertToolStripMenuItem1,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
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
            this.insertToolStripMenuItem1.Size = new System.Drawing.Size(224, 44);
            this.insertToolStripMenuItem1.Text = "Insert";
            // 
            // medicToolStripMenuItem
            // 
            this.medicToolStripMenuItem.Name = "medicToolStripMenuItem";
            this.medicToolStripMenuItem.Size = new System.Drawing.Size(223, 44);
            this.medicToolStripMenuItem.Text = "Medic";
            this.medicToolStripMenuItem.Click += new System.EventHandler(this.medicToolStripMenuItem_Click);
            // 
            // pacientToolStripMenuItem
            // 
            this.pacientToolStripMenuItem.Name = "pacientToolStripMenuItem";
            this.pacientToolStripMenuItem.Size = new System.Drawing.Size(223, 44);
            this.pacientToolStripMenuItem.Text = "Pacient";
            this.pacientToolStripMenuItem.Click += new System.EventHandler(this.pacientToolStripMenuItem_Click);
            // 
            // retetaToolStripMenuItem
            // 
            this.retetaToolStripMenuItem.Name = "retetaToolStripMenuItem";
            this.retetaToolStripMenuItem.Size = new System.Drawing.Size(223, 44);
            this.retetaToolStripMenuItem.Text = "Reteta";
            this.retetaToolStripMenuItem.Click += new System.EventHandler(this.retetaToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(224, 44);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(224, 44);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // chartToolStripMenuItem
            // 
            this.chartToolStripMenuItem.Name = "chartToolStripMenuItem";
            this.chartToolStripMenuItem.Size = new System.Drawing.Size(91, 38);
            this.chartToolStripMenuItem.Text = "Chart";
            this.chartToolStripMenuItem.Click += new System.EventHandler(this.chartToolStripMenuItem_Click);
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
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertIntoDatabaseToolStripMenuItem,
            this.getDataFromDatabaseToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(132, 38);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // insertIntoDatabaseToolStripMenuItem
            // 
            this.insertIntoDatabaseToolStripMenuItem.Name = "insertIntoDatabaseToolStripMenuItem";
            this.insertIntoDatabaseToolStripMenuItem.Size = new System.Drawing.Size(397, 44);
            this.insertIntoDatabaseToolStripMenuItem.Text = "Add to database";
            this.insertIntoDatabaseToolStripMenuItem.Click += new System.EventHandler(this.insertIntoDatabaseToolStripMenuItem_Click);
            // 
            // getDataFromDatabaseToolStripMenuItem
            // 
            this.getDataFromDatabaseToolStripMenuItem.Name = "getDataFromDatabaseToolStripMenuItem";
            this.getDataFromDatabaseToolStripMenuItem.Size = new System.Drawing.Size(397, 44);
            this.getDataFromDatabaseToolStripMenuItem.Text = "Get data from database";
            this.getDataFromDatabaseToolStripMenuItem.Click += new System.EventHandler(this.getDataFromDatabaseToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(157)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(1674, 911);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.RetetaButton);
            this.Controls.Add(this.PacientButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MedicButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
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
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediciToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pacientiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reteteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertIntoDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getDataFromDatabaseToolStripMenuItem;
    }
}

