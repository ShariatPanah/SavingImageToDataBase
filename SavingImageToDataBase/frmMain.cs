using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SavingImageToDataBase
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public static string strConnectionString = "Data Source=.;Initial Catalog=DBImage;Integrated Security=True";

        public byte[] retrievePictureByID(int _id)
        {
            SqlConnection Connection = new SqlConnection(strConnectionString);
            SqlCommand Command = new SqlCommand();

            byte[] arrPicture = null;
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandText = "Select * From tbl_Image Where ID=@id";

                Command.Parameters.AddWithValue("@id", _id);
                SqlDataReader Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    arrPicture = (byte[])Reader["Image"];
                }

                return arrPicture;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return arrPicture;
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public void updateComboBox()
        {
            try
            {
                cmbIndices.Items.Clear();
                foreach (int item in getIndices())
                {
                    cmbIndices.Items.Add(item);
                }
            }
            catch (Exception)
            {

            }
        }

        public int[] getIndices()
        {
            SqlConnection Connection = new SqlConnection(strConnectionString);
            SqlCommand Command = new SqlCommand();

            int[] indices = null;
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandText = "Select Count(*) From tbl_Image";

                indices = new int[(int)Command.ExecuteScalar()];
                Command.CommandText = "Select id From tbl_Image";

                SqlDataReader Reader = Command.ExecuteReader();

                for (int i = 0; Reader.Read(); i++)
                {
                    indices[i] = (int)Reader["id"];
                }

                return indices;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return indices;
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public byte[] getPicturesByte()
        {
            Bitmap oBitmap = (Bitmap)pcbPictures.Image;
            System.IO.MemoryStream oMemoryStream = new System.IO.MemoryStream();
            oBitmap.Save(oMemoryStream, oBitmap.RawFormat);

            byte[] arrPicture = oMemoryStream.GetBuffer();
            return arrPicture;
        }

        public void insertPicture(byte[] _picture)
        {
            SqlConnection Connection = new SqlConnection(strConnectionString);
            SqlCommand Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandText = "Insert into tbl_Image Select Image=@Img";

                Command.Parameters.AddWithValue("@Img", _picture);
                Command.ExecuteNonQuery();

                MessageBox.Show("Succeed!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog oOpenFileDialog = new OpenFileDialog();
            oOpenFileDialog.Filter = "All Graphic Types|*.jpg;*.jpeg;*.png;*.bmp;*.tiff;*.gif";

            if (oOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                pcbPictures.Image = Image.FromFile(oOpenFileDialog.FileName);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            pcbPictures.Image = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            insertPicture(getPicturesByte());
            updateComboBox();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            updateComboBox();
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            if (cmbIndices.Text != "Image indices")
            {
                System.IO.MemoryStream oMemoryStream = new System.IO.MemoryStream(retrievePictureByID(Convert.ToInt32(cmbIndices.SelectedItem)));
                pcbPictures.Image = Image.FromStream(oMemoryStream);
            }
            else
            {
                MessageBox.Show("Please Select an Image Number");
            }
        }

        private void btnSaveToPc_Click(object sender, EventArgs e)
        {
            Bitmap oBitmap = new Bitmap(pcbPictures.Image);

            oBitmap.Save(Application.StartupPath + "12.png", System.Drawing.Imaging.ImageFormat.Png);
            //pcbPictures.Image.Save(Application.StartupPath + "12.jpg", System.Drawing.Imaging.ImageFormat)
        }
    }
}
