using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Pazuzu
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CharEditStatusHelper(object sender, EventArgs e)
        {
            EditorStatusLabel.Text = "Open the character editor.";
        }

        private void WeaponEditorStatusHelper(object sender, EventArgs e)
        {
            EditorStatusLabel.Text = "Open the weapon editor.";
        }

        private void ArmorEditorStatusHelper(object sender, EventArgs e)
        {
            EditorStatusLabel.Text = "Open the armor editor.";
        }

        private void MagicEditStatusHelper(object sender, EventArgs e)
        {
            EditorStatusLabel.Text = "Open the magic editor.";
        }

        private void MonsterEditStatusHelper(object sender, EventArgs e)
        {
            EditorStatusLabel.Text = "Open the monster editor.";
        }

        private void BattlefieldEditStatusHelper(object sender, EventArgs e)
        {
            EditorStatusLabel.Text = "Open the battlefield editor.";
        }

        private void MapEditStatusHandler(object sender, EventArgs e)
        {
            EditorStatusLabel.Text = "Open the map editor.";
        }

        private void FormationEditStatusHelper(object sender, EventArgs e)
        {
            EditorStatusLabel.Text = "Open the monster formation editor.";
        }
    }
}
