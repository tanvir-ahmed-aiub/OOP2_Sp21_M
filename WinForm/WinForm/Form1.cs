using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
        
        private void RegisterClick(object sender, EventArgs e)
        {
            string uname = "";
            string password = "";
            string profession = "";
            string gender = "";

            string errMsg =null;
            if (txtUsername.Text.Equals(""))
            {
                errMsg += "\nUsername Required";
            }
            else if (txtUsername.Text.Length <= 2) {
                errMsg += "\nUsername Must be at least 3 characters";
            }
            else
            {
                uname = txtUsername.Text;
            }
            if (txtPassword.Text.Equals(""))
            {
                errMsg += "\nPassword Required";
            }
            else {
                password = txtPassword.Text;
            }
            if (cbProfession.SelectedItem == null)
            {
                errMsg += "\nProfession Required";
            }
            else {
                profession = cbProfession.SelectedItem.ToString();
            }
            if (gbGender.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked) == null)
            {
                errMsg += "\nGender Required";
            }
            else {
                gender = gbGender.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked).Text;
            }

            /*var controls = gbGender.Controls;
            var types = controls.OfType<RadioButton>();
            var selected = types.FirstOrDefault(n => n.Checked);
            var gender = selected.Text;*/
           
            

            List<string> hb = new List<string>();

            if (cbGames.Checked) hb.Add(cbGames.Text);
            if (cbMovies.Checked) hb.Add(cbMovies.Text);
            if (cbSports.Checked) hb.Add(cbSports.Text);
            if (cbMusic.Checked) hb.Add(cbMusic.Text);

            if (errMsg==null)
            {
                rtOutput.Text = string.Format("Name: {0}\nPassword:{1}\nProfession:{2}\nGender:{3}\nHobbies:", uname, password, profession, gender);

                foreach (var st in hb)
                {
                    rtOutput.Text += st + " ";
                }
            }
            else {
                MessageBox.Show(errMsg);
            }

          
            
        }
        private void dummy(object sender, EventArgs e)
        {
            MessageBox.Show("register clicked from dummy");
        }

        private void subscribe(object sender, EventArgs e)
        {
            MessageBox.Show("subscribe clicked ");
        }
    }
}
