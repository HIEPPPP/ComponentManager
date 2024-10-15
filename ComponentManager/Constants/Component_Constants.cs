using ComponentManager.Models;
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComponentManager.Constrant
{
    public static class Component_Constants
    {
        public static string userId = string.Empty;
        public static string username = string.Empty;
        public static string password = string.Empty;
        public static List<UserRole> userRoles = null;


        public static void ExportExcel(GridControl gridControl)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel (2003)(.xls)|*.xls|Excel (2010) (.xlsx)|*.xlsx";
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string exportFilePath = saveDialog.FileName;
                    string fileExtenstion = new FileInfo(exportFilePath).Extension;

                    switch (fileExtenstion)
                    {
                        case ".xls":
                            gridControl.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            gridControl.ExportToXlsx(exportFilePath);
                            break;
                        default:
                            break;
                    }
                    if (File.Exists(exportFilePath))
                    {
                        try
                        {
                            System.Diagnostics.Process.Start(exportFilePath);
                            MessageBox.Show("EXPORT EXCEL SUCCESSFULL ... !", "btnExport", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            String msg = "The file could not be opened." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                            MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        String msg = "The file could not be saved." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                        MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        public static void Print(GridControl gridControl)
        {
            if (gridControl == null)
            {
                throw new ArgumentNullException(nameof(gridControl), "GridControl không được để trống.");
            }

            PrintableComponentLink printLink = new PrintableComponentLink(new PrintingSystem());

            printLink.Component = gridControl;

            //printLink.CreateMarginalHeaderArea += (s, args) =>
            //{
            //    string header = "Danh sách dữ liệu";
            //    args.Graphics.DrawString(header, new Font("Tahoma", 12, FontStyle.Bold), 
            //        Brushes.Black, args.PageBounds.Left + 10, args.PageBounds.Top + 10);
            //};

            // Hiển thị preview trước khi in
            printLink.ShowPreviewDialog();
        }



        public static byte[] encryptData(string data)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider md5Hasher = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] hashedBytes;
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            hashedBytes = md5Hasher.ComputeHash(encoder.GetBytes(data));
            return hashedBytes;
        }

        public static string _md5(string data)
        {
            return BitConverter.ToString(encryptData(data)).Replace("-", "").ToLower();
        }

        public static string _createMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }


        //Path and FileName
        //Open file and return path
        public static string OpenFileAndGetPath()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.CheckFileExists = true;
                openFileDialog.AddExtension = true;
                openFileDialog.Filter = "All files (*.*)|*.*";

                DialogResult result = openFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    return openFileDialog.FileName;
                }
                return string.Empty;
            }
        }

        //Get file name 
        public static string GetFileName(string filePath)
        {
            if (!string.IsNullOrEmpty(filePath))
            {
                return filePath.Substring(filePath.LastIndexOf("\\") + 1); // Cộng 1 để loại bỏ \\
            }
            return string.Empty;
        }

        /// <summary>
        /// Lưu file ảnh vào thư mục với tên file dựa trên timestamp.
        /// </summary>
        /// <param name="originalFilePath">Đường dẫn gốc của file</param>
        /// <param name="destinationFolder">Thư mục đích lưu file</param>
        /// <returns>Trả về tên file mới sau khi lưu</returns>
        public static string SaveImageWithTimestamp(string originalFilePath, string destinationFolder)
        {
            // Tạo thư mục nếu chưa tồn tại
            if (!Directory.Exists(destinationFolder))
            {
                Directory.CreateDirectory(destinationFolder);
            }

            // Tạo tên file mới dựa trên timestamp
            string timeStamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            string newFileName = timeStamp + Path.GetExtension(originalFilePath);
            string saveImagePath = Path.Combine(destinationFolder, newFileName);

            // Copy file vào thư mục đích
            File.Copy(originalFilePath, saveImagePath, true);

            return newFileName; // Trả về tên file mới (không bao gồm đường dẫn đầy đủ)
        }

    }
}
