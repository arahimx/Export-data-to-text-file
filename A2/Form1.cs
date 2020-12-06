using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace A2
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_selectpic_Click(object sender, EventArgs e)
        {
            string imagelocation = "";

            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Images File (*.JPG;)|*.JPG;";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imagelocation = dialog.FileName;
                    pb_profile.ImageLocation = imagelocation;
                    tb_url.Text = imagelocation;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured");

            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.RestoreDirectory = true;
            savefile.InitialDirectory = "e:\\faktur";
            savefile.FileName = String.Format("{0}.txt", tb_name.Text);
            savefile.DefaultExt = "*.txt*";
            savefile.Filter = "TEXT Files|*.txt";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
              using (System.IO.StreamWriter sw = new System.IO.StreamWriter(savefile.FileName))
                sw.WriteLine(tb_name.Text +"\r\n"+ tb_email.Text + "\r\n" + nud_age.Text + "\r\n" + tb_url.Text);

            }
        }
    }
}
