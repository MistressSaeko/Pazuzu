namespace Pazuzu
{
    partial class CharEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharEdit));
            this.CharLabel = new System.Windows.Forms.Label();
            this.CharChooser = new System.Windows.Forms.ComboBox();
            this.GearGroup = new System.Windows.Forms.GroupBox();
            this.WeaponLabel = new System.Windows.Forms.Label();
            this.AccLabel = new System.Windows.Forms.Label();
            this.ArmorLabel = new System.Windows.Forms.Label();
            this.WeaponChooser = new System.Windows.Forms.ComboBox();
            this.ArmorChooser = new System.Windows.Forms.ComboBox();
            this.ShieldChooser = new System.Windows.Forms.ComboBox();
            this.AcccessoryChooser = new System.Windows.Forms.ComboBox();
            this.ShieldLabel = new System.Windows.Forms.Label();
            this.StatusGroup = new System.Windows.Forms.GroupBox();
            this.StatusList = new System.Windows.Forms.CheckedListBox();
            this.ElementsGroup = new System.Windows.Forms.GroupBox();
            this.ElementalList = new System.Windows.Forms.CheckedListBox();
            this.StatsGroup = new System.Windows.Forms.GroupBox();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.GearGroup.SuspendLayout();
            this.StatusGroup.SuspendLayout();
            this.ElementsGroup.SuspendLayout();
            this.StatsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // CharLabel
            // 
            resources.ApplyResources(this.CharLabel, "CharLabel");
            this.CharLabel.Name = "CharLabel";
            // 
            // CharChooser
            // 
            this.CharChooser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CharChooser.FormattingEnabled = true;
            resources.ApplyResources(this.CharChooser, "CharChooser");
            this.CharChooser.Name = "CharChooser";
            // 
            // GearGroup
            // 
            this.GearGroup.Controls.Add(this.ShieldLabel);
            this.GearGroup.Controls.Add(this.AcccessoryChooser);
            this.GearGroup.Controls.Add(this.ShieldChooser);
            this.GearGroup.Controls.Add(this.ArmorChooser);
            this.GearGroup.Controls.Add(this.WeaponChooser);
            this.GearGroup.Controls.Add(this.ArmorLabel);
            this.GearGroup.Controls.Add(this.AccLabel);
            this.GearGroup.Controls.Add(this.WeaponLabel);
            resources.ApplyResources(this.GearGroup, "GearGroup");
            this.GearGroup.Name = "GearGroup";
            this.GearGroup.TabStop = false;
            // 
            // WeaponLabel
            // 
            resources.ApplyResources(this.WeaponLabel, "WeaponLabel");
            this.WeaponLabel.Name = "WeaponLabel";
            // 
            // AccLabel
            // 
            resources.ApplyResources(this.AccLabel, "AccLabel");
            this.AccLabel.Name = "AccLabel";
            // 
            // ArmorLabel
            // 
            resources.ApplyResources(this.ArmorLabel, "ArmorLabel");
            this.ArmorLabel.Name = "ArmorLabel";
            // 
            // WeaponChooser
            // 
            this.WeaponChooser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WeaponChooser.FormattingEnabled = true;
            resources.ApplyResources(this.WeaponChooser, "WeaponChooser");
            this.WeaponChooser.Name = "WeaponChooser";
            // 
            // ArmorChooser
            // 
            this.ArmorChooser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ArmorChooser.FormattingEnabled = true;
            resources.ApplyResources(this.ArmorChooser, "ArmorChooser");
            this.ArmorChooser.Name = "ArmorChooser";
            // 
            // ShieldChooser
            // 
            this.ShieldChooser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShieldChooser.FormattingEnabled = true;
            resources.ApplyResources(this.ShieldChooser, "ShieldChooser");
            this.ShieldChooser.Name = "ShieldChooser";
            // 
            // AcccessoryChooser
            // 
            this.AcccessoryChooser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AcccessoryChooser.FormattingEnabled = true;
            resources.ApplyResources(this.AcccessoryChooser, "AcccessoryChooser");
            this.AcccessoryChooser.Name = "AcccessoryChooser";
            // 
            // ShieldLabel
            // 
            resources.ApplyResources(this.ShieldLabel, "ShieldLabel");
            this.ShieldLabel.Name = "ShieldLabel";
            // 
            // StatusGroup
            // 
            this.StatusGroup.Controls.Add(this.StatusList);
            resources.ApplyResources(this.StatusGroup, "StatusGroup");
            this.StatusGroup.Name = "StatusGroup";
            this.StatusGroup.TabStop = false;
            // 
            // StatusList
            // 
            this.StatusList.FormattingEnabled = true;
            this.StatusList.Items.AddRange(new object[] {
            resources.GetString("StatusList.Items"),
            resources.GetString("StatusList.Items1"),
            resources.GetString("StatusList.Items2"),
            resources.GetString("StatusList.Items3"),
            resources.GetString("StatusList.Items4"),
            resources.GetString("StatusList.Items5"),
            resources.GetString("StatusList.Items6"),
            resources.GetString("StatusList.Items7"),
            resources.GetString("StatusList.Items8")});
            resources.ApplyResources(this.StatusList, "StatusList");
            this.StatusList.Name = "StatusList";
            // 
            // ElementsGroup
            // 
            this.ElementsGroup.Controls.Add(this.ElementalList);
            resources.ApplyResources(this.ElementsGroup, "ElementsGroup");
            this.ElementsGroup.Name = "ElementsGroup";
            this.ElementsGroup.TabStop = false;
            // 
            // ElementalList
            // 
            this.ElementalList.FormattingEnabled = true;
            this.ElementalList.Items.AddRange(new object[] {
            resources.GetString("ElementalList.Items"),
            resources.GetString("ElementalList.Items1"),
            resources.GetString("ElementalList.Items2"),
            resources.GetString("ElementalList.Items3"),
            resources.GetString("ElementalList.Items4"),
            resources.GetString("ElementalList.Items5"),
            resources.GetString("ElementalList.Items6"),
            resources.GetString("ElementalList.Items7"),
            resources.GetString("ElementalList.Items8")});
            resources.ApplyResources(this.ElementalList, "ElementalList");
            this.ElementalList.Name = "ElementalList";
            // 
            // StatsGroup
            // 
            this.StatsGroup.Controls.Add(this.comboBox1);
            this.StatsGroup.Controls.Add(this.LevelLabel);
            resources.ApplyResources(this.StatsGroup, "StatsGroup");
            this.StatsGroup.Name = "StatsGroup";
            this.StatsGroup.TabStop = false;
            // 
            // LevelLabel
            // 
            resources.ApplyResources(this.LevelLabel, "LevelLabel");
            this.LevelLabel.Name = "LevelLabel";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            // 
            // CharEdit
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StatsGroup);
            this.Controls.Add(this.ElementsGroup);
            this.Controls.Add(this.StatusGroup);
            this.Controls.Add(this.GearGroup);
            this.Controls.Add(this.CharChooser);
            this.Controls.Add(this.CharLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CharEdit";
            this.GearGroup.ResumeLayout(false);
            this.GearGroup.PerformLayout();
            this.StatusGroup.ResumeLayout(false);
            this.ElementsGroup.ResumeLayout(false);
            this.StatsGroup.ResumeLayout(false);
            this.StatsGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CharLabel;
        private System.Windows.Forms.ComboBox CharChooser;
        private System.Windows.Forms.GroupBox GearGroup;
        private System.Windows.Forms.Label ShieldLabel;
        private System.Windows.Forms.ComboBox AcccessoryChooser;
        private System.Windows.Forms.ComboBox ShieldChooser;
        private System.Windows.Forms.ComboBox ArmorChooser;
        private System.Windows.Forms.ComboBox WeaponChooser;
        private System.Windows.Forms.Label ArmorLabel;
        private System.Windows.Forms.Label AccLabel;
        private System.Windows.Forms.Label WeaponLabel;
        private System.Windows.Forms.GroupBox StatusGroup;
        private System.Windows.Forms.CheckedListBox StatusList;
        private System.Windows.Forms.GroupBox ElementsGroup;
        private System.Windows.Forms.CheckedListBox ElementalList;
        private System.Windows.Forms.GroupBox StatsGroup;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label LevelLabel;
    }
}