namespace Profiler
{
    partial class CreatePokemonWindow
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
            this.Profile = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.HpTextBox = new System.Windows.Forms.TextBox();
            this.AttackTextBox = new System.Windows.Forms.TextBox();
            this.DefenceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SpeedTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Upload = new System.Windows.Forms.Button();
            this.Values = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Profile)).BeginInit();
            this.SuspendLayout();
            // 
            // Profile
            // 
            this.Profile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Profile.Location = new System.Drawing.Point(12, 12);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(100, 93);
            this.Profile.TabIndex = 0;
            this.Profile.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(183, 12);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // HpTextBox
            // 
            this.HpTextBox.Location = new System.Drawing.Point(183, 51);
            this.HpTextBox.Name = "HpTextBox";
            this.HpTextBox.Size = new System.Drawing.Size(100, 20);
            this.HpTextBox.TabIndex = 2;
            this.HpTextBox.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // AttackTextBox
            // 
            this.AttackTextBox.Location = new System.Drawing.Point(183, 77);
            this.AttackTextBox.Name = "AttackTextBox";
            this.AttackTextBox.Size = new System.Drawing.Size(100, 20);
            this.AttackTextBox.TabIndex = 3;
            // 
            // DefenceTextBox
            // 
            this.DefenceTextBox.Location = new System.Drawing.Point(183, 103);
            this.DefenceTextBox.Name = "DefenceTextBox";
            this.DefenceTextBox.Size = new System.Drawing.Size(100, 20);
            this.DefenceTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hp:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // SpeedTextBox
            // 
            this.SpeedTextBox.Location = new System.Drawing.Point(183, 129);
            this.SpeedTextBox.Name = "SpeedTextBox";
            this.SpeedTextBox.Size = new System.Drawing.Size(100, 20);
            this.SpeedTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Attack:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Defence:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Speed:";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(156, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(39, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Upload
            // 
            this.Upload.Location = new System.Drawing.Point(12, 111);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(100, 23);
            this.Upload.TabIndex = 13;
            this.Upload.Text = "Upload Image";
            this.Upload.UseVisualStyleBackColor = true;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // Values
            // 
            this.Values.Location = new System.Drawing.Point(183, 156);
            this.Values.Name = "Values";
            this.Values.Size = new System.Drawing.Size(100, 23);
            this.Values.TabIndex = 14;
            this.Values.Text = "Set Values";
            this.Values.UseVisualStyleBackColor = true;
            this.Values.Click += new System.EventHandler(this.Values_Click);
            // 
            // CreatePokemonWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 237);
            this.Controls.Add(this.Values);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SpeedTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DefenceTextBox);
            this.Controls.Add(this.AttackTextBox);
            this.Controls.Add(this.HpTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.Profile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CreatePokemonWindow";
            this.Text = "Create Pokémon";
            ((System.ComponentModel.ISupportInitialize)(this.Profile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Profile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox HpTextBox;
        private System.Windows.Forms.TextBox AttackTextBox;
        private System.Windows.Forms.TextBox DefenceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SpeedTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Upload;
        private System.Windows.Forms.Button Values;
    }
}