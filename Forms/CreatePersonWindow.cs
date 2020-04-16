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
    public partial class CreatePersonWindow : Form
    {
        public CreatePersonWindow()
        {
            InitializeComponent();
        }

        public static string name;
        public static string age;
        public static string klass;
        public static string email;
        public static string description;
        public static Image image;
        public static string filePath;
        public static Uri filePathUri;

        #region Bullshit
        private void Label4_Click(object sender, EventArgs e)
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
                Profile2.SizeMode = PictureBoxSizeMode.CenterImage;
                Profile2.SizeMode = PictureBoxSizeMode.Zoom;
                Profile2.Image = Image.FromFile(filePath);
                MessageBox.Show(filePath);
            }
        }

        private void Values_Click(object sender, EventArgs e)
        {
            name = NameTextBox2.Text;
            age = AgeTextBox.Text;
            klass = ClassTextBox.Text;
            email = EmailTextBox.Text;
            description = DescriptionTextBox.Text;
            image = Image.FromFile(filePath);
            filePathUri = new Uri(filePath);
        }
    }
}
