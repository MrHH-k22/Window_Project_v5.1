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
        private string imagePath = "";
        private byte[] avatarByteArray = null;
        Account account = new Account();
        public FInformation()
        {
            InitializeComponent();

        }

        public FInformation(Account acc)
        {
            InitializeComponent();
            account = acc;
            txtEmail.Text = account.Email;
            txtPassword.Text = "";
            txtName.Text = account.Name;
            txtAddress.Text = account.Address;
            txtPhone.Text = account.Phone;
            if (account.Birthday != DateTime.MinValue)
            {
                dtpBirthday.Value = account.Birthday.Date;
            }
            else
            {
                dtpBirthday.Value = DateTime.Today; 
            }
            convertByte(pbAvatar, account.Avatar);

            
        }

        private void convertByte(PictureBox pic, byte[] imageData)
        {

            if (imageData != null && imageData.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    // Attempt to create Image object
                    try
                    {
                        pic.Image = Image.FromStream(ms);
                    }
                    catch (ArgumentException ex)
                    {
                        // Handle ArgumentException
                        Console.WriteLine("Failed to create Image object: " + ex.Message);
                    }
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            account.Name = txtName.Text;
            account.Email = txtEmail.Text;
            if (txtPassword.Text.Length > 0)
            {
                account.Password = txtPassword.Text;
            }
            account.Phone = txtPhone.Text;
            account.Birthday = dtpBirthday.Value;
            account.Address = txtAddress.Text;
            account.Avatar = avatarByteArray;

            accountDAO.update(account);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif)|*.jpg; *.jpeg; *.png; *.gif";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = dialog.FileName.ToString();

                // Đọc hình ảnh từ tệp
                System.Drawing.Image originalImage = System.Drawing.Image.FromFile(imagePath);

                // Thay đổi kích thước của hình ảnh
                System.Drawing.Image resizedImage = ResizeImage(originalImage, pbAvatar.Width, pbAvatar.Height);

                // Hiển thị hình ảnh trong PictureBox
                pbAvatar.Image = resizedImage;

                // Đọc dữ liệu hình ảnh thành mảng byte
                using (FileStream fs = new FileStream(dialog.FileName, FileMode.Open, FileAccess.Read))
                {
                    BinaryReader br = new BinaryReader(fs);
                    avatarByteArray = br.ReadBytes((int)fs.Length);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            FBuy f = new FBuy(account);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }
    }
}
