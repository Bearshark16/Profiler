using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Profiler
{
    public partial class CreatePokemonWindow : Form
    {
        public CreatePokemonWindow()
        {
            InitializeComponent();
        }

        public static string name;
        public static string hp;
        public static string attack;
        public static string defence;
        public static string speed;
        public static Image image;
        public static string filePath;
        public static Uri filePathUri;

        #region Bullshit
        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void Upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PNG files|*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                Profile.SizeMode = PictureBoxSizeMode.CenterImage;
                Profile.SizeMode = PictureBoxSizeMode.Zoom;
                Profile.Image = Image.FromFile(filePath);
                MessageBox.Show(filePath);
            }
        }

        private void Values_Click(object sender, EventArgs e)
        {
            name = NameTextBox.Text;
            hp = HpTextBox.Text;
            attack = AttackTextBox.Text;
            defence = DefenceTextBox.Text;
            speed = SpeedTextBox.Text;
            image = Image.FromFile(filePath);
            filePathUri = new Uri(filePath);
        }
    }
}
