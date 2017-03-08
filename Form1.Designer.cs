namespace Pazuzu
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.EditorStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.DatawriteStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openROMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveRIMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormationEditButton = new System.Windows.Forms.Button();
            this.MapEditButton = new System.Windows.Forms.Button();
            this.BtlFldEditButton = new System.Windows.Forms.Button();
            this.MonEditButton = new System.Windows.Forms.Button();
            this.MagEditButton = new System.Windows.Forms.Button();
            this.ArmorEditButton = new System.Windows.Forms.Button();
            this.WeaponEditButton = new System.Windows.Forms.Button();
            this.CharEditButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(769, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditorStatusLabel,
            this.DatawriteStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 100);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(769, 24);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // EditorStatusLabel
            // 
            this.EditorStatusLabel.AutoSize = false;
            this.EditorStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.EditorStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.EditorStatusLabel.Name = "EditorStatusLabel";
            this.EditorStatusLabel.Size = new System.Drawing.Size(250, 19);
            this.EditorStatusLabel.Text = "toolStripStatusLabel1";
            this.EditorStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DatawriteStatusLabel
            // 
            this.DatawriteStatusLabel.AutoSize = false;
            this.DatawriteStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.DatawriteStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.DatawriteStatusLabel.Name = "DatawriteStatusLabel";
            this.DatawriteStatusLabel.Size = new System.Drawing.Size(504, 19);
            this.DatawriteStatusLabel.Spring = true;
            this.DatawriteStatusLabel.Text = "toolStripStatusLabel3";
            this.DatawriteStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openROMToolStripMenuItem,
            this.saveRIMToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openROMToolStripMenuItem
            // 
            this.openROMToolStripMenuItem.Name = "openROMToolStripMenuItem";
            this.openROMToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openROMToolStripMenuItem.Text = "Open ROM";
            // 
            // saveRIMToolStripMenuItem
            // 
            this.saveRIMToolStripMenuItem.Name = "saveRIMToolStripMenuItem";
            this.saveRIMToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveRIMToolStripMenuItem.Text = "Save ROM";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // FormationEditButton
            // 
            this.FormationEditButton.Location = new System.Drawing.Point(544, 27);
            this.FormationEditButton.Name = "FormationEditButton";
            this.FormationEditButton.Size = new System.Drawing.Size(70, 70);
            this.FormationEditButton.TabIndex = 9;
            this.FormationEditButton.Text = "button1";
            this.FormationEditButton.UseVisualStyleBackColor = true;
            this.FormationEditButton.MouseHover += new System.EventHandler(this.FormationEditStatusHelper);
            // 
            // MapEditButton
            // 
            this.MapEditButton.Image = global::Pazuzu.Properties.Resources.pyramid;
            this.MapEditButton.Location = new System.Drawing.Point(468, 27);
            this.MapEditButton.Name = "MapEditButton";
            this.MapEditButton.Size = new System.Drawing.Size(70, 70);
            this.MapEditButton.TabIndex = 8;
            this.MapEditButton.UseVisualStyleBackColor = true;
            this.MapEditButton.MouseHover += new System.EventHandler(this.MapEditStatusHandler);
            // 
            // BtlFldEditButton
            // 
            this.BtlFldEditButton.Image = global::Pazuzu.Properties.Resources.battlefield;
            this.BtlFldEditButton.Location = new System.Drawing.Point(392, 27);
            this.BtlFldEditButton.Name = "BtlFldEditButton";
            this.BtlFldEditButton.Size = new System.Drawing.Size(70, 70);
            this.BtlFldEditButton.TabIndex = 7;
            this.BtlFldEditButton.UseVisualStyleBackColor = true;
            this.BtlFldEditButton.MouseHover += new System.EventHandler(this.BattlefieldEditStatusHelper);
            // 
            // MonEditButton
            // 
            this.MonEditButton.Image = global::Pazuzu.Properties.Resources.medusa;
            this.MonEditButton.Location = new System.Drawing.Point(316, 27);
            this.MonEditButton.Name = "MonEditButton";
            this.MonEditButton.Size = new System.Drawing.Size(70, 70);
            this.MonEditButton.TabIndex = 6;
            this.MonEditButton.UseVisualStyleBackColor = true;
            this.MonEditButton.MouseHover += new System.EventHandler(this.MonsterEditStatusHelper);
            // 
            // MagEditButton
            // 
            this.MagEditButton.Image = global::Pazuzu.Properties.Resources.magic;
            this.MagEditButton.Location = new System.Drawing.Point(240, 27);
            this.MagEditButton.Name = "MagEditButton";
            this.MagEditButton.Size = new System.Drawing.Size(70, 70);
            this.MagEditButton.TabIndex = 5;
            this.MagEditButton.UseVisualStyleBackColor = true;
            this.MagEditButton.MouseHover += new System.EventHandler(this.MagicEditStatusHelper);
            // 
            // ArmorEditButton
            // 
            this.ArmorEditButton.Image = global::Pazuzu.Properties.Resources.armor;
            this.ArmorEditButton.Location = new System.Drawing.Point(164, 27);
            this.ArmorEditButton.Name = "ArmorEditButton";
            this.ArmorEditButton.Size = new System.Drawing.Size(70, 70);
            this.ArmorEditButton.TabIndex = 4;
            this.ArmorEditButton.UseVisualStyleBackColor = true;
            this.ArmorEditButton.MouseHover += new System.EventHandler(this.ArmorEditorStatusHelper);
            // 
            // WeaponEditButton
            // 
            this.WeaponEditButton.Image = global::Pazuzu.Properties.Resources.sword;
            this.WeaponEditButton.Location = new System.Drawing.Point(88, 27);
            this.WeaponEditButton.Name = "WeaponEditButton";
            this.WeaponEditButton.Size = new System.Drawing.Size(70, 70);
            this.WeaponEditButton.TabIndex = 3;
            this.WeaponEditButton.UseVisualStyleBackColor = true;
            this.WeaponEditButton.MouseHover += new System.EventHandler(this.WeaponEditorStatusHelper);
            // 
            // CharEditButton
            // 
            this.CharEditButton.Image = global::Pazuzu.Properties.Resources.kaeli;
            this.CharEditButton.Location = new System.Drawing.Point(12, 27);
            this.CharEditButton.Name = "CharEditButton";
            this.CharEditButton.Size = new System.Drawing.Size(70, 70);
            this.CharEditButton.TabIndex = 2;
            this.CharEditButton.UseVisualStyleBackColor = true;
            this.CharEditButton.MouseHover += new System.EventHandler(this.CharEditStatusHelper);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 124);
            this.Controls.Add(this.FormationEditButton);
            this.Controls.Add(this.MapEditButton);
            this.Controls.Add(this.BtlFldEditButton);
            this.Controls.Add(this.MonEditButton);
            this.Controls.Add(this.MagEditButton);
            this.Controls.Add(this.ArmorEditButton);
            this.Controls.Add(this.WeaponEditButton);
            this.Controls.Add(this.CharEditButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Pazuzu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel EditorStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel DatawriteStatusLabel;
        private System.Windows.Forms.Button CharEditButton;
        private System.Windows.Forms.Button WeaponEditButton;
        private System.Windows.Forms.Button ArmorEditButton;
        private System.Windows.Forms.Button MagEditButton;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openROMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveRIMToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button MonEditButton;
        private System.Windows.Forms.Button BtlFldEditButton;
        private System.Windows.Forms.Button MapEditButton;
        private System.Windows.Forms.Button FormationEditButton;
    }
}

