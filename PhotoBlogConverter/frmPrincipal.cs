using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PhotoBlogConverter
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSourceFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            fd.SelectedPath = this.tbSourceFolder.Text;
            if (fd.ShowDialog() == DialogResult.OK)
                tbSourceFolder.Text = fd.SelectedPath;
        }

        private void btnSaveFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            fd.SelectedPath = this.txtSaveFolder.Text;
            if (fd.ShowDialog() == DialogResult.OK)
                txtSaveFolder.Text = fd.SelectedPath;
        }

        private void btProccess_Click(object sender, EventArgs e)
        {
            bool errors = false;
            //Check values have been set
            if (errors == false && tbSourceFolder.Text == "")
                errors = setError("Select A Source Directory");
            if (errors == false && txtSaveFolder.Text == "")
                errors = setError("Select A Save To Directory");

            if (errors == false)
            {
                lblStatus.Text = "Starting Process...";
                PhotoConverterOptions ops = new PhotoConverterOptions();
                ops.IncludeSubfolders = this.chBRecursion.Checked;
                ops.MaxHeight = Double.Parse(this.tbOutputHeight.Text);
                ops.MaxWidth = Double.Parse(this.tbOutputWidth.Text);
                ops.OriginPath = this.tbSourceFolder.Text;
                ops.OutputPath = this.txtSaveFolder.Text;
                ops.pbTemp = this.pbStatus;
                

                bool results = PhotoConverter.processDirectory(tbSourceFolder.Text, ops);
                lblStatus.Text = "Done";
            }
        }

        private bool setError(String message)
        {
            MessageBox.Show(message);
            return true;
        }


        
    }
}
