using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace LibraryManagementSystem
{
    public class HelperClass
    {
        public static void  makeFieldsBlank(Control ctrl)
        {
            try
            {
                foreach (Control a in ctrl.Controls)
                {
                    if (a is TextBox)
                        a.Text = "";
                    if (a is ComboBox)
                        a.Text = null;
                    if (a is PictureBox)
                    {
                      
                        a.BackgroundImage = null;
                    }
                   
                }
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
        public static byte[] ImageConverter(PictureBox pbox)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                pbox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] ImageFile = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(ImageFile, 0, ImageFile.Length);
                return ImageFile;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static bool CheckExistence(DataGridView dgv, String dbname, Control ctrl)///Checking the existance of sring with same value
        {

            bool result = false;
            int repeat = 0;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                String txtname = dgv.Rows[i].Cells[dbname].Value.ToString();
                if (ctrl.Text == txtname)
                {
                    repeat = 1;
                }
                else
                {
                    repeat = 0;
                }

            }
            if (repeat == 1)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;

        }

    }
}
