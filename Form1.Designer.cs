namespace Pazuzu
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            toolTip1 = new ToolTip(components);
            WeaponEditorButton = new Button();
            statusStrip1 = new StatusStrip();
            toolStrip1 = new ToolStrip();
            OpenROMButton = new ToolStripButton();
            SaveROMButton = new ToolStripButton();
            GeneratePatchButton = new ToolStripButton();
            AboutButton = new ToolStripButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            CharacterEditorButton = new Button();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // WeaponEditorButton
            // 
            WeaponEditorButton.Image = Properties.Resources.sword;
            WeaponEditorButton.Location = new Point(79, 3);
            WeaponEditorButton.Name = "WeaponEditorButton";
            WeaponEditorButton.Size = new Size(70, 70);
            WeaponEditorButton.TabIndex = 1;
            toolTip1.SetToolTip(WeaponEditorButton, "Opens the weapon editor.");
            WeaponEditorButton.UseVisualStyleBackColor = true;
            WeaponEditorButton.Click += WeaponEditorButton_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 115);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { OpenROMButton, SaveROMButton, GeneratePatchButton, AboutButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 39);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // OpenROMButton
            // 
            OpenROMButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            OpenROMButton.Image = Properties.Resources.folder_open;
            OpenROMButton.ImageTransparentColor = Color.Magenta;
            OpenROMButton.Name = "OpenROMButton";
            OpenROMButton.Size = new Size(36, 36);
            OpenROMButton.Text = "toolStripButton1";
            OpenROMButton.ToolTipText = "Open a ROM to edit.";
            // 
            // SaveROMButton
            // 
            SaveROMButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            SaveROMButton.Image = Properties.Resources.media_floppy;
            SaveROMButton.ImageTransparentColor = Color.Magenta;
            SaveROMButton.Name = "SaveROMButton";
            SaveROMButton.Size = new Size(36, 36);
            SaveROMButton.Text = "toolStripButton2";
            SaveROMButton.ToolTipText = "Saves the edited ROM.";
            // 
            // GeneratePatchButton
            // 
            GeneratePatchButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            GeneratePatchButton.Image = Properties.Resources.emblem_favorite;
            GeneratePatchButton.ImageTransparentColor = Color.Magenta;
            GeneratePatchButton.Name = "GeneratePatchButton";
            GeneratePatchButton.Size = new Size(36, 36);
            GeneratePatchButton.Text = "toolStripButton3";
            GeneratePatchButton.ToolTipText = "Generate an IPS patch.";
            // 
            // AboutButton
            // 
            AboutButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            AboutButton.Image = Properties.Resources.help_browser;
            AboutButton.ImageTransparentColor = Color.Magenta;
            AboutButton.Name = "AboutButton";
            AboutButton.Size = new Size(36, 36);
            AboutButton.Text = "toolStripButton1";
            AboutButton.ToolTipText = "About this app.";
            AboutButton.Click += AboutButton_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(CharacterEditorButton);
            flowLayoutPanel1.Controls.Add(WeaponEditorButton);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 39);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 76);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // CharacterEditorButton
            // 
            CharacterEditorButton.Image = Properties.Resources.kaeli;
            CharacterEditorButton.Location = new Point(3, 3);
            CharacterEditorButton.Name = "CharacterEditorButton";
            CharacterEditorButton.Size = new Size(70, 70);
            CharacterEditorButton.TabIndex = 0;
            CharacterEditorButton.UseVisualStyleBackColor = true;
            CharacterEditorButton.Click += CharacterEditorButton_Click;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 137);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            Text = "Pazuzu";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolTip toolTip1;
        private StatusStrip statusStrip1;
        private ToolStrip toolStrip1;
        private FlowLayoutPanel flowLayoutPanel1;
        private ToolStripButton OpenROMButton;
        private ToolStripButton SaveROMButton;
        private ToolStripButton GeneratePatchButton;
        private Button CharacterEditorButton;
        private Button WeaponEditorButton;
        private ToolStripButton AboutButton;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}