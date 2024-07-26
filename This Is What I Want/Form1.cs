using static System.Windows.Forms.AxHost;
using System.Net.NetworkInformation;
using System.DirectoryServices;
using Microsoft.VisualBasic.ApplicationServices;
using This_Is_What_I_Want.Properties;
using System.Diagnostics;
using System.Windows.Forms.Design;

namespace This_Is_What_I_Want
{
    public partial class Form1 : Form
    {

        List<string> listFiles = new List<string>();

        string directory = "D:\\RING 3A\\Godot Storage\\STABLE 4";

        string backup_path;

        public Form1()
        {


            InitializeComponent();

            init_folder();
        }

        public void init_folder()
        {


            listFiles.Clear();
            listView.Clear();

            foreach (string item in Directory.GetFiles(directory))
            {
                txtPath.Text = directory;
                backup_path = directory;

                FileInfo fi = new FileInfo(item);
                listFiles.Add(fi.FullName);
                listView.Items.Add(fi.Name, imageList.Images.Count);

                if (Path.GetExtension(item) == ".exe")
                {
                    Icon exe = new Icon("C:\\Users\\SuperCdat\\source\\repos\\This Is What I Want\\This Is What I Want\\Resources\\.exe-type.ico");
                    imageList.Images.Add(exe);

                }
                if (Path.GetExtension(item) == ".dll")
                {
                    Icon exe = new Icon("C:\\Users\\SuperCdat\\source\\repos\\This Is What I Want\\This Is What I Want\\Resources\\.dll-type.ico");
                    imageList.Images.Add(exe);

                }
                else
                {
                    imageList.Images.Add(Icon.ExtractAssociatedIcon(item));
                }

            }
        }

        private void Tick_Click(object sender, EventArgs e)
        {


            try
            {
                if (txtPath.Text == "dl")
                {
                    directory = "C:\\Users\\SuperCdat\\Downloads";
                    if (CHECK_BOX.Checked)
                    {
                        Process.Start("explorer.exe", "C:\\Users\\SuperCdat\\Downloads");
                    }
                }
                else if (txtPath.Text == "dc")
                {
                    directory = "C:\\Users\\SuperCdat\\Documents";
                    if (CHECK_BOX.Checked)
                    {
                        Process.Start("explorer.exe", "C:\\Users\\SuperCdat\\Documents");
                    }
                }
                else if (txtPath.Text == "dk")
                {
                    directory = "C:\\Users\\SuperCdat\\Desktop";
                    if (CHECK_BOX.Checked)
                    {
                        Process.Start("explorer.exe", "C:\\Users\\SuperCdat\\Desktop");
                    }
                }
                else
                {
                    directory = txtPath.Text;
                    if (CHECK_BOX.Checked)
                    {
                        Process.Start("explorer.exe", txtPath.Text);
                    }
                }
                init_folder();
            }
            catch
            {
                MessageBox.Show("Please enter the correct path.", "Error");
                directory = backup_path;
                init_folder();
            }

        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPath_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Tick_Click(this.Tick, e);
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listView.FocusedItem != null)
            {
                System.Diagnostics.Process.Start(listFiles[listView.FocusedItem.Index]);
            }
        }
    }
}
