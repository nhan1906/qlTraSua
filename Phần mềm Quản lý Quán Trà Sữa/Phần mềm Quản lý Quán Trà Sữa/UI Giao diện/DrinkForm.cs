using Quản_Lý_Quán_Trà_Sữa.DAO;
using Quản_Lý_Quán_Trà_Sữa.DTO;
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

namespace Phần_mềm_Quản_lý_Quán_Trà_Sữa.UI_Giao_diện
{
    public partial class DrinkForm : Form
    {

        BindingSource bdCategory = new BindingSource();
        BindingSource bdDrink = new BindingSource();
        public DrinkForm()
        {
            InitializeComponent();
            InitView();
            InitDtgv();
            dtgvDrink.Tag = 0;
        }
        private void InitView()
        {
            pnCategory.Visible = false;
            dtCategory.Visible = false;
            tabDrink_Click(new object(), new EventArgs());
            txtCategoryName.Enabled = false;
            txtNameDrink.Enabled = false;
            txtPrice.Enabled = false;
            btnAccept.Enabled = false;
            btnAcceptDrink.Enabled = false;
            btnCancel.Enabled = false;
            btnCancelDrink.Enabled = false;
        }
        private void DrinkForm_Load(object sender, EventArgs e)
        {
            LoadView();
            LoadDrinkCategory();
            LoadDrinkList();
        }
        private void tabDrink_Click(object sender, EventArgs e)
        {
            tabCategory.IsClick = false;
            pnCategory.Visible = false;
            pnDrink.Visible = true;
            dtgvDrink.Visible = true;
            dtCategory.Visible = false;
        }


        private void tabCategory_Click(object sender, EventArgs e)
        {
            tabDrink.IsClick = false;
            pnCategory.Visible = true;
            pnDrink.Visible = false;
            dtCategory.Visible = true;
            dtgvDrink.Visible = false;
        }
        private void LoadDrinkList()
        {
            dtgvDrink.DataSource = bdDrink;
            LoaddtgvDrink();

            dtgvDrink.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvDrink.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDrink.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvDrink.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            AddBindingDrink();
        }
        private void LoadDrinkCategory()
        {
            dtCategory.DataSource = bdCategory;
            Loaddtgv();
            dtCategory.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtCategory.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AddBindingCategory();
        }
        private void LoaddtgvDrink()
        {
            bdDrink.DataSource = DataProvider.Instance.ExecuteQuery("USP_GetListDrinkByToDtgv");
        }

        private void AddBindingDrink()
        {
            this.dtgvDrink.Columns[0].HeaderText = "Tên thức uống";
            this.dtgvDrink.Columns[1].HeaderText = "Loại thức uống";
            this.dtgvDrink.Columns[2].HeaderText = "Kích cỡ";
            this.dtgvDrink.Columns[3].HeaderText = "Giá tiền";
            txtNameDrink.DataBindings.Add(new Binding("Text", dtgvDrink.DataSource, "nameDrink", true, DataSourceUpdateMode.Never));
            txtPrice.DataBindings.Add(new Binding("Text", dtgvDrink.DataSource, "price", true, DataSourceUpdateMode.Never));
            //Binding text
        }
        private void Loaddtgv()
        {

            bdCategory.DataSource = CategoriesDDAO.Instance.GetListCategories();
        }
        private void AddBindingCategory()
        {
            this.dtCategory.Columns[0].HeaderText = "STT";
            this.dtCategory.Columns[1].HeaderText = "Loại thức uống";

            txtCategoryName.DataBindings.Add(new Binding("Text", dtCategory.DataSource, "nameCategories", true, DataSourceUpdateMode.Never));
        }

        private void InitDtgv()
        {

            //Color Background
            dtCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtCategory.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtCategory.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 11.25f, FontStyle.Bold);
            dtCategory.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dtCategory.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            dtCategory.RowHeadersVisible = false;

            //
            //Text font
            //
            dtCategory.DefaultCellStyle.Font = new Font("Cambria", 10.25f);
            dtCategory.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtCategory.DefaultCellStyle.ForeColor = Color.FromArgb(67, 72, 78);

            //Custom border
            dtCategory.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dtCategory.BorderStyle = BorderStyle.None;
            //Color row
            dtCategory.RowsDefaultCellStyle.BackColor = Color.FromArgb(220, 238, 249);
            dtCategory.RowsDefaultCellStyle.ForeColor = Color.FromArgb(67, 72, 78);
            dtCategory.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(186, 223, 241);
            dtCategory.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(67, 72, 78);
            dtCategory.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(131, 193, 233);
            dtCategory.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(67, 72, 78);

            //////////////////////////////////
            //Color Background
            dtgvDrink.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvDrink.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgvDrink.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 11.25f, FontStyle.Bold);
            dtgvDrink.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dtgvDrink.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            dtgvDrink.RowHeadersVisible = false;

            //
            //Text font
            //
            dtgvDrink.DefaultCellStyle.Font = new Font("Cambria", 10.25f);
            dtgvDrink.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgvDrink.DefaultCellStyle.ForeColor = Color.FromArgb(67, 72, 78);

            //Custom border
            dtgvDrink.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dtgvDrink.BorderStyle = BorderStyle.None;
            //Color row
            dtgvDrink.RowsDefaultCellStyle.BackColor = Color.FromArgb(220, 238, 249);
            dtgvDrink.RowsDefaultCellStyle.ForeColor = Color.FromArgb(67, 72, 78);
            dtgvDrink.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(186, 223, 241);
            dtgvDrink.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(67, 72, 78);
            dtgvDrink.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(131, 193, 233);
            dtgvDrink.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(67, 72, 78);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tabCategory.IsClick == true)
            {
                txtCategoryName.Enabled = true;
                btnAccept.Enabled = true;
                btnCancel.Enabled = true;
                txtCategoryName.Text = "";
                dtCategory.Tag = 1;
                return;
            }
            //
            txtNameDrink.Text = "";
            txtPrice.Text = "";
            dtgvDrink.Tag = -1;
            txtNameDrink.Enabled = true;
            txtPrice.Enabled = true;
            btnAcceptDrink.Enabled = true;
            btnCancelDrink.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(tabCategory.IsClick == true)
            {
                txtCategoryName.Enabled = true;
                btnAccept.Enabled = true;
                btnCancel.Enabled = true;
                dtCategory.Tag = 2;
                return;
            }
            dtgvDrink.Tag = (DrinkDAO.Instance.GetDrinkByName(txtNameDrink.Text , cmbSize.SelectedIndex + 1)).IdDrink;
            txtNameDrink.Enabled = true;
            txtPrice.Enabled = true;
            btnAcceptDrink.Enabled = true;
            btnCancelDrink.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(tabCategory.IsClick == true)
            {
                string name = dtCategory.SelectedCells[0].OwningRow.Cells["nameCategories"].Value.ToString();
                if (CategoriesDDAO.Instance.DeleteCategoriy(name) == 1)
                {
                    MessageBox.Show("Thành công");
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }

                Loaddtgv();
                return;
            }
            //delete drink
            string nameDrink = dtgvDrink.SelectedCells[0].OwningRow.Cells["nameDrink"].Value.ToString();
            string nameSizeDrink = dtgvDrink.SelectedCells[0].OwningRow.Cells["nameSizeDrink"].Value.ToString();
            int idSizeDrink = cmbSize.FindStringExact(nameSizeDrink);
            if (DrinkDAO.Instance.DeleteDrink(nameDrink, idSizeDrink + 1) == 1)
            {
                MessageBox.Show("Thành công");
            }
            else
            {
                MessageBox.Show("Thất bại");
            }

            LoaddtgvDrink();
            return;
        }
        
        private void LoadView()
        {
            cmbSize.DataSource = SizeDrinkDAO.Instance.GetListSizeDrink();
            cmbSize.DisplayMember = "NameSizeDrink";
            cmbType.DataSource = CategoriesDDAO.Instance.GetListCategories();
            cmbType.DisplayMember = "nameCategories";
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            int i = (int)dtCategory.Tag;
            if (i == 1)
            {
                if (txtCategoryName.Text == "")
                {
                      MessageBox.Show("Chưa nhập tên");
                      return;
                }
                  int result = CategoriesDDAO.Instance.AddNewCategories(txtCategoryName.Text);
                    if (result == 1)
                    {
                        MessageBox.Show("Thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thất bại");
                    }
                }

                if (i == 2)
                {
                    string name = dtCategory.SelectedCells[0].OwningRow.Cells["nameCategories"].Value.ToString();
                    if (txtCategoryName.Text == "" || txtCategoryName.Text == name)
                    {
                        MessageBox.Show("Nhập tên khác");
                        return;
                    }
                    int result = CategoriesDDAO.Instance.EditCategories(name, txtCategoryName.Text);
                    if (result == 1)
                    {
                        MessageBox.Show("Thành công");
                    }
                   else
                   {
                       MessageBox.Show("Thất bại");
               }
            }
            InitView();
            tabCategory_Click(new object(), new EventArgs());
            Loaddtgv();
            
        }

        private void txtNameDrink_TextChanged(object sender, EventArgs e)
        {
            string name = dtgvDrink.SelectedCells[0].OwningRow.Cells["nameSizeDrink"].Value.ToString();
            cmbSize.SelectedIndex = cmbSize.FindStringExact(name);
            name = dtgvDrink.SelectedCells[0].OwningRow.Cells["nameCategories"].Value.ToString();
            cmbType.SelectedIndex = cmbType.FindStringExact(name);
            //Lấy hình lên
            Drink drink = DrinkDAO.Instance.GetDrinkByName(txtNameDrink.Text, cmbSize.SelectedIndex + 1);
            if(drink != null)
            {
                byte[] byteImage = drink.Picture;
                if (byteImage != null)
                {
                    using (var ms = new MemoryStream(byteImage))
                    {
                        ptImage.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    ptImage.Image = null;
                }
            }
            
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            string name = dtgvDrink.SelectedCells[0].OwningRow.Cells["nameSizeDrink"].Value.ToString();
            cmbSize.SelectedIndex = cmbSize.FindStringExact(name);
            name = dtgvDrink.SelectedCells[0].OwningRow.Cells["nameCategories"].Value.ToString();
            cmbType.SelectedIndex = cmbType.FindStringExact(name);

            Drink drink = DrinkDAO.Instance.GetDrinkByName(txtNameDrink.Text, cmbSize.SelectedIndex + 1);
            if (drink != null)
            {
                byte[] byteImage = drink.Picture;
                if (byteImage != null)
                {
                    using (var ms = new MemoryStream(byteImage))
                    {
                        ptImage.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    ptImage.Image = null;
                }
            }
        }

        private void btnAcceptDrink_Click(object sender, EventArgs e)
        {
            int i = (int)dtgvDrink.Tag;
            if (i == -1)
            {
                if (txtNameDrink.Text == "" || txtPrice.Text == "")
                {
                    MessageBox.Show("Nhập đầy đủ thông tin.");
                    return;
                }
                if (ptImage.Image != null)
                {
                    Image image = ptImage.Image;
                    MemoryStream ms = new MemoryStream();
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                    byte[] byteImage = ms.ToArray();
                    int result = DrinkDAO.Instance.AddDrinkWithImage(txtNameDrink.Text, (float)Convert.ToDouble(txtPrice.Text), cmbType.SelectedIndex + 1, cmbSize.SelectedIndex + 1 , byteImage);
                    if (result == 1)
                    {
                        MessageBox.Show("Thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thất bại");
                    }
                }
                else
                {
                    int result = DrinkDAO.Instance.AddDrinkNoImage(txtNameDrink.Text, (float)Convert.ToDouble(txtPrice.Text), cmbType.SelectedIndex + 1, cmbSize.SelectedIndex + 1);
                    if (result == 1)
                    {
                        MessageBox.Show("Thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thất bại");
                    }
                }
                InitView();
                pnCategory.Visible = true;
                dtCategory.Visible = true;
                pnDrink.Visible = false;
                dtgvDrink.Visible = false;
                tabDrink_Click(new object(), new EventArgs());
                LoaddtgvDrink();
                return;
            }

            //Sửa
            if (txtNameDrink.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("Nhập đầy đủ thông tin.");
                return;
            }
            if (ptImage.Image != null)
            {
                Image image = ptImage.Image;
                MemoryStream ms = new MemoryStream();
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                byte[] byteImage = ms.ToArray();
                int result = DrinkDAO.Instance.EditDrinkWithImage(txtNameDrink.Text, float.Parse(txtPrice.Text), (cmbType.SelectedIndex + 1), (cmbSize.SelectedIndex + 1), byteImage , i);
                if (result == 1)
                {
                    MessageBox.Show("Thành công");
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
            }
            else
            {
                int result = DrinkDAO.Instance.EditDrinkNoImage(txtNameDrink.Text, float.Parse(txtPrice.Text), (cmbType.SelectedIndex + 1), (cmbSize.SelectedIndex + 1), i);
                if (result == 1)
                {
                    MessageBox.Show("Thành công");
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
            }
            InitView();
            pnCategory.Visible = true;
            dtCategory.Visible = true;
            pnDrink.Visible = false;
            dtgvDrink.Visible = false;
            tabCategory_Click(new object(), new EventArgs());
            LoaddtgvDrink();

        }

        private void ptImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open Image";
            ofd.InitialDirectory = @"C:\Desktop";
            ofd.Filter = "Image|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                ptImage.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnCategory.Visible = true;
            dtCategory.Visible = true;
            pnDrink.Visible = false;
            dtgvDrink.Visible = false;
            tabCategory_Click(new object(), new EventArgs());
        }

        private void btnCancelDrink_Click(object sender, EventArgs e)
        {
            InitView();
        }
        
    }
}
