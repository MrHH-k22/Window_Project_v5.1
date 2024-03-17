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

namespace Window_Project_v5._1.Forms
{
    public partial class FInformation : Form
    {
        private AccountDAO accountDAO = new AccountDAO();
        private string imagePath;
        private byte[] avatarByteArray = null;

        public FInformation()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Account account = new Account(txtEmail.Text,txtPassword.Text,txtName.Text,txtPhone.Text,dtpBirthday.Value,txtAddress.Text, avatarByteArray);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif)|*.jpg; *.jpeg; *.png; *.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog.FileName;

                // Đọc hình ảnh từ tệp
                System.Drawing.Image originalImage = System.Drawing.Image.FromFile(imagePath);

                // Thay đổi kích thước của hình ảnh
                System.Drawing.Image resizedImage = ResizeImage(originalImage, pbAvatar.Width, pbAvatar.Height);

                // Hiển thị hình ảnh trong PictureBox
                pbAvatar.Image = resizedImage;

                // Đọc dữ liệu hình ảnh thành mảng byte
                using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                {
                    BinaryReader br = new BinaryReader(fs);
                    avatarByteArray = br.ReadBytes((int)fs.Length);
                }
            }
        }

        private System.Drawing.Image ResizeImage(System.Drawing.Image image, int width, int height)
        {
            // Tạo một Bitmap mới với kích thước đã cho
            Bitmap result = new Bitmap(width, height);

            // Tạo Graphics để vẽ hình ảnh vào Bitmap mới
            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(image, 0, 0, width, height);
            }

            return result;
        }
    }
}
