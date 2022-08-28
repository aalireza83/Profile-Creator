using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Profile_Creator
{
    public partial class ProfileCreator : Form
    {
        public ProfileCreator()
        {
            InitializeComponent();
        }
        List<string> Address = new List<string>();
        private void btn_Source_Click(object sender, EventArgs e)
        {
            if (rb_File.Checked)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files (*.bmp;*.png;*.jpg)|*.bmp;*.png;*.jpg";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Address.Clear();
                    Address.Add(openFileDialog.FileName);
                    txt_Source.Text = openFileDialog.FileName;
                    progressBar.Maximum = 1;
                }
            }
            else if (rb_Folder.Checked)
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    Address.Clear();
                    foreach (var files in Directory.GetFiles(folderBrowserDialog.SelectedPath))
                    {
                        if (files.EndsWith(".bmp") || files.EndsWith(".png") || files.EndsWith(".jpg"))
                            Address.Add(files);
                    }
                    if (Address.Count != 0)
                    {
                        txt_Source.Text = folderBrowserDialog.SelectedPath;
                        progressBar.Maximum = Address.Count;
                    }
                }
            }
        }
        private void rb_Folder_CheckedChanged(object sender, EventArgs e)
        {
            Address.Clear();
            txt_Source.Text = "";
        }
        private void btn_Destination_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txt_Destination.Text = folderBrowserDialog.SelectedPath;
            }
        }
        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (isvalid())
            {
                foreach (string Addres in Address)
                {
                    Image image = Image.FromFile(Addres);
                    Bitmap baseImage = new Bitmap(image, new Size(148, 168));
                    Bitmap overlayImage = new Bitmap(Image.FromFile(txt_Temp.Text));

                    var finalImage = new Bitmap(overlayImage.Width, overlayImage.Height, PixelFormat.Format32bppArgb);
                    var graphics = Graphics.FromImage(finalImage);
                    graphics.CompositingMode = CompositingMode.SourceOver;

                    graphics.DrawImage(baseImage, 129, 130);
                    graphics.DrawImage(overlayImage, 0, 0);

                    Font font = new Font("Tahoma", 12, FontStyle.Bold);
                    string text1 = Path.GetFileNameWithoutExtension(Addres);
                    string text2 = txt_Class.Text;

                    var size1 = overlayImage.Width / 2 - graphics.MeasureString(text1, font).Width / 2;
                    graphics.DrawString(text1, font, SystemBrushes.WindowText, new Point((int)size1 + 5, 308));

                    var size2 = overlayImage.Width / 2 - graphics.MeasureString(text2, font).Width / 2;
                    graphics.DrawString(text2, font, SystemBrushes.WindowText, new Point((int)size2 + 5, 329));

                    finalImage.Save(txt_Destination.Text + "\\" + Path.GetFileName(Addres), ImageFormat.Png);
                    baseImage.Dispose();
                    progressBar.Value++;
                }
                MessageBox.Show("پروفایل ها ساخته شد", "عملیات با موفقیت انجام شد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Address.Clear();
                txt_Class.Text = "";
                txt_Destination.Text = "";
                txt_Source.Text = "";
                txt_Temp.Text = "";
                progressBar.Value = 0;
            }
        }
        private void btn_Temp_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.bmp;*.png;*.jpg)|*.bmp;*.png;*.jpg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txt_Temp.Text = openFileDialog.FileName;
            }
        }
        bool isvalid()
        {
            if (txt_Temp.Text == "")
            {
                MessageBox.Show("فیلد قالب را پر کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txt_Source.Text == "")
            {
                MessageBox.Show("فیلد مبدأ را پر کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txt_Destination.Text == "")
            {
                MessageBox.Show("فیلد مقصد را پر کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txt_Class.Text == "")
            {
                MessageBox.Show("فیلد کلاس را پر کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
