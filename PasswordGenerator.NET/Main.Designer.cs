﻿namespace PasswordGenerator.NET
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateMultiplePasswordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lengthInput = new System.Windows.Forms.NumericUpDown();
            this.EditSpecialCharactersButton = new System.Windows.Forms.Button();
            this.specialCheckbox = new System.Windows.Forms.CheckBox();
            this.GeneratePassword = new System.Windows.Forms.Button();
            this.numbersCheckbox = new System.Windows.Forms.CheckBox();
            this.letterRadio4 = new System.Windows.Forms.RadioButton();
            this.letterRadio3 = new System.Windows.Forms.RadioButton();
            this.letterRadio2 = new System.Windows.Forms.RadioButton();
            this.letterRadio1 = new System.Windows.Forms.RadioButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.logo1 = new System.Windows.Forms.Panel();
            this.loadingLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lengthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.generateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1491, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(59, 29);
            this.fileToolStripMenuItem.Text = " File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.newToolStripMenuItem.Text = "new window";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.exitToolStripMenuItem.Text = "exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // generateToolStripMenuItem
            // 
            this.generateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPasswordToolStripMenuItem,
            this.generateMultiplePasswordsToolStripMenuItem});
            this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
            this.generateToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.generateToolStripMenuItem.Text = "generate";
            // 
            // newPasswordToolStripMenuItem
            // 
            this.newPasswordToolStripMenuItem.Name = "newPasswordToolStripMenuItem";
            this.newPasswordToolStripMenuItem.Size = new System.Drawing.Size(342, 34);
            this.newPasswordToolStripMenuItem.Text = "generate password";
            this.newPasswordToolStripMenuItem.Click += new System.EventHandler(this.generatePasswordToolStripMenuItem_Click);
            // 
            // generateMultiplePasswordsToolStripMenuItem
            // 
            this.generateMultiplePasswordsToolStripMenuItem.Name = "generateMultiplePasswordsToolStripMenuItem";
            this.generateMultiplePasswordsToolStripMenuItem.Size = new System.Drawing.Size(342, 34);
            this.generateMultiplePasswordsToolStripMenuItem.Text = "generate multiple passwords";
            this.generateMultiplePasswordsToolStripMenuItem.Click += new System.EventHandler(this.generateMultiplePasswordsToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 33);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.loadingLabel);
            this.splitContainer1.Panel1.Controls.Add(this.progressBar1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.lengthInput);
            this.splitContainer1.Panel1.Controls.Add(this.EditSpecialCharactersButton);
            this.splitContainer1.Panel1.Controls.Add(this.specialCheckbox);
            this.splitContainer1.Panel1.Controls.Add(this.GeneratePassword);
            this.splitContainer1.Panel1.Controls.Add(this.numbersCheckbox);
            this.splitContainer1.Panel1.Controls.Add(this.letterRadio4);
            this.splitContainer1.Panel1.Controls.Add(this.letterRadio3);
            this.splitContainer1.Panel1.Controls.Add(this.letterRadio2);
            this.splitContainer1.Panel1.Controls.Add(this.letterRadio1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1491, 776);
            this.splitContainer1.SplitterDistance = 687;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 642);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(687, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 333);
            this.label1.MaximumSize = new System.Drawing.Size(0, 31);
            this.label1.MinimumSize = new System.Drawing.Size(0, 31);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.label1.Size = new System.Drawing.Size(687, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "length";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lengthInput
            // 
            this.lengthInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.lengthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lengthInput.Location = new System.Drawing.Point(0, 301);
            this.lengthInput.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.lengthInput.Name = "lengthInput";
            this.lengthInput.Size = new System.Drawing.Size(687, 32);
            this.lengthInput.TabIndex = 6;
            this.lengthInput.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // EditSpecialCharactersButton
            // 
            this.EditSpecialCharactersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.EditSpecialCharactersButton.Font = new System.Drawing.Font("Lucida Console", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditSpecialCharactersButton.Location = new System.Drawing.Point(0, 276);
            this.EditSpecialCharactersButton.MaximumSize = new System.Drawing.Size(0, 25);
            this.EditSpecialCharactersButton.MinimumSize = new System.Drawing.Size(0, 25);
            this.EditSpecialCharactersButton.Name = "EditSpecialCharactersButton";
            this.EditSpecialCharactersButton.Size = new System.Drawing.Size(687, 25);
            this.EditSpecialCharactersButton.TabIndex = 6;
            this.EditSpecialCharactersButton.Text = "Edit special characters";
            this.EditSpecialCharactersButton.UseVisualStyleBackColor = true;
            this.EditSpecialCharactersButton.Click += new System.EventHandler(this.EditSpecialCharactersButton_Click);
            // 
            // specialCheckbox
            // 
            this.specialCheckbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.specialCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.specialCheckbox.Location = new System.Drawing.Point(0, 230);
            this.specialCheckbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.specialCheckbox.MaximumSize = new System.Drawing.Size(0, 46);
            this.specialCheckbox.MinimumSize = new System.Drawing.Size(0, 46);
            this.specialCheckbox.Name = "specialCheckbox";
            this.specialCheckbox.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.specialCheckbox.Size = new System.Drawing.Size(687, 46);
            this.specialCheckbox.TabIndex = 5;
            this.specialCheckbox.Text = "special characters";
            this.specialCheckbox.UseVisualStyleBackColor = true;
            // 
            // GeneratePassword
            // 
            this.GeneratePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.GeneratePassword.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GeneratePassword.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.GeneratePassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GeneratePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.GeneratePassword.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GeneratePassword.ForeColor = System.Drawing.Color.White;
            this.GeneratePassword.Location = new System.Drawing.Point(0, 665);
            this.GeneratePassword.Name = "GeneratePassword";
            this.GeneratePassword.Size = new System.Drawing.Size(687, 111);
            this.GeneratePassword.TabIndex = 8;
            this.GeneratePassword.Text = "Generate password";
            this.GeneratePassword.UseVisualStyleBackColor = false;
            this.GeneratePassword.Click += new System.EventHandler(this.GeneratePassword_Click);
            // 
            // numbersCheckbox
            // 
            this.numbersCheckbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.numbersCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.numbersCheckbox.Location = new System.Drawing.Point(0, 184);
            this.numbersCheckbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numbersCheckbox.MaximumSize = new System.Drawing.Size(0, 46);
            this.numbersCheckbox.MinimumSize = new System.Drawing.Size(0, 46);
            this.numbersCheckbox.Name = "numbersCheckbox";
            this.numbersCheckbox.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.numbersCheckbox.Size = new System.Drawing.Size(687, 46);
            this.numbersCheckbox.TabIndex = 4;
            this.numbersCheckbox.Text = "numbers";
            this.numbersCheckbox.UseVisualStyleBackColor = true;
            // 
            // letterRadio4
            // 
            this.letterRadio4.BackColor = System.Drawing.SystemColors.Control;
            this.letterRadio4.Dock = System.Windows.Forms.DockStyle.Top;
            this.letterRadio4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.letterRadio4.Location = new System.Drawing.Point(0, 138);
            this.letterRadio4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.letterRadio4.MaximumSize = new System.Drawing.Size(0, 46);
            this.letterRadio4.MinimumSize = new System.Drawing.Size(0, 46);
            this.letterRadio4.Name = "letterRadio4";
            this.letterRadio4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.letterRadio4.Size = new System.Drawing.Size(687, 46);
            this.letterRadio4.TabIndex = 3;
            this.letterRadio4.Tag = "";
            this.letterRadio4.Text = "no letters";
            this.letterRadio4.UseVisualStyleBackColor = false;
            // 
            // letterRadio3
            // 
            this.letterRadio3.BackColor = System.Drawing.SystemColors.Control;
            this.letterRadio3.Dock = System.Windows.Forms.DockStyle.Top;
            this.letterRadio3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.letterRadio3.Location = new System.Drawing.Point(0, 92);
            this.letterRadio3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.letterRadio3.MaximumSize = new System.Drawing.Size(0, 46);
            this.letterRadio3.MinimumSize = new System.Drawing.Size(0, 46);
            this.letterRadio3.Name = "letterRadio3";
            this.letterRadio3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.letterRadio3.Size = new System.Drawing.Size(687, 46);
            this.letterRadio3.TabIndex = 2;
            this.letterRadio3.Text = "lowercase letters only";
            this.letterRadio3.UseVisualStyleBackColor = false;
            // 
            // letterRadio2
            // 
            this.letterRadio2.BackColor = System.Drawing.SystemColors.Control;
            this.letterRadio2.Dock = System.Windows.Forms.DockStyle.Top;
            this.letterRadio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.letterRadio2.Location = new System.Drawing.Point(0, 46);
            this.letterRadio2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.letterRadio2.MaximumSize = new System.Drawing.Size(0, 46);
            this.letterRadio2.MinimumSize = new System.Drawing.Size(0, 46);
            this.letterRadio2.Name = "letterRadio2";
            this.letterRadio2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.letterRadio2.Size = new System.Drawing.Size(687, 46);
            this.letterRadio2.TabIndex = 1;
            this.letterRadio2.Text = "uppercase letters only";
            this.letterRadio2.UseVisualStyleBackColor = false;
            // 
            // letterRadio1
            // 
            this.letterRadio1.BackColor = System.Drawing.SystemColors.Control;
            this.letterRadio1.Checked = true;
            this.letterRadio1.Dock = System.Windows.Forms.DockStyle.Top;
            this.letterRadio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.letterRadio1.Location = new System.Drawing.Point(0, 0);
            this.letterRadio1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.letterRadio1.MaximumSize = new System.Drawing.Size(0, 46);
            this.letterRadio1.MinimumSize = new System.Drawing.Size(0, 46);
            this.letterRadio1.Name = "letterRadio1";
            this.letterRadio1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.letterRadio1.Size = new System.Drawing.Size(687, 46);
            this.letterRadio1.TabIndex = 0;
            this.letterRadio1.TabStop = true;
            this.letterRadio1.Text = "uppercase and lowercase letters";
            this.letterRadio1.UseVisualStyleBackColor = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(798, 776);
            this.splitContainer2.SplitterDistance = 198;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.logo1);
            this.splitContainer3.Size = new System.Drawing.Size(596, 776);
            this.splitContainer3.SplitterDistance = 196;
            this.splitContainer3.TabIndex = 0;
            // 
            // logo1
            // 
            this.logo1.BackColor = System.Drawing.Color.White;
            this.logo1.BackgroundImage = global::PasswordGenerator.NET.Properties.Resources.password_Generator;
            this.logo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo1.Location = new System.Drawing.Point(0, 0);
            this.logo1.Name = "logo1";
            this.logo1.Size = new System.Drawing.Size(196, 286);
            this.logo1.TabIndex = 1;
            // 
            // loadingLabel
            // 
            this.loadingLabel.AutoSize = true;
            this.loadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loadingLabel.Location = new System.Drawing.Point(275, 496);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(0, 37);
            this.loadingLabel.TabIndex = 10;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 809);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(498, 591);
            this.Name = "Main";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lengthInput)).EndInit();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateMultiplePasswordsToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RadioButton letterRadio4;
        private System.Windows.Forms.RadioButton letterRadio3;
        private System.Windows.Forms.RadioButton letterRadio2;
        private System.Windows.Forms.RadioButton letterRadio1;
        private System.Windows.Forms.CheckBox numbersCheckbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown lengthInput;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Panel logo1;
        public System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.Button GeneratePassword;
        private System.Windows.Forms.Button EditSpecialCharactersButton;
        private System.Windows.Forms.CheckBox specialCheckbox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label loadingLabel;
    }
}