using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassManager
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            PassLoad();
            AddButton.Enabled = true;
            EditButton.Enabled = false;
            PassTextbox.UseSystemPasswordChar = true;
            FilterCombobox.SelectedIndex = 0;
            CategoryCombobox.SelectedIndex = 5;
            PassDatagrid.Columns[0].Visible = false;
            PassDatagrid.Columns[3].Visible = false;
            PassDatagrid.Columns[4].Visible = false;
            PassDatagrid.Columns[5].Visible = false;
            FilterCombobox.SelectedIndexChanged
            += new System.EventHandler(
                    searchOrFilter);
            foreach (DataGridViewColumn font in PassDatagrid.Columns)
            {
                font.DefaultCellStyle.Font = new Font("Roboto Light", 14F, GraphicsUnit.Pixel);
            }
        }
        private void PassLoad ()
        {
            string SQL = "Select `passwords`.`idPass`, `passwords`.`name`, `passwords`.`login`, `passwords`.`password`, " +
                "`passwords`.`url`, `passwords`.`comment`, `passwords`.`category` From passwords";
            DataTable passDataTable = DataBaseConnection.ExecuteDataQuery(SQL);
            PassDatagrid.DataSource = passDataTable;
            PassDatagrid.ClearSelection();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            int idPass = (int)PassDatagrid.SelectedRows[0].Cells[0].Value;
            string SQL = "Update `passwords` " +
                "Set " +
                $" `name` = '{NameTextbox.Text}', " +
                $" `login` = '{LoginTextbox.Text}', " +
                $" `password` = '{PassTextbox.Text}', " +
                $" `url` = '{SiteTextbox.Text}', " +
                $" `comment` = '{CommentTextbox.Text}', " +
                $" `category` = '{CategoryCombobox.Text}'" +
                "where `idPass` = " +
                $"{idPass}";
            DataBaseConnection.ExecuteNonQuery(SQL);
            PassDatagrid.ClearSelection();
            PassLoad();
            Clear();
        }

        private void PassDatagrid_SelectionChanged(object sender, EventArgs e)
        {
            AddButton.Enabled = false;
            EditButton.Enabled = true;
            PassTextbox.UseSystemPasswordChar = true;
            if (PassDatagrid.SelectedRows.Count == 1)
            {
                NameTextbox.Text = PassDatagrid.SelectedRows[0].Cells["name"].Value.ToString();
                LoginTextbox.Text = PassDatagrid.SelectedRows[0].Cells["login"].Value.ToString();
                PassTextbox.Text = PassDatagrid.SelectedRows[0].Cells["password"].Value.ToString();
                SiteTextbox.Text = PassDatagrid.SelectedRows[0].Cells["url"].Value.ToString();
                CommentTextbox.Text = PassDatagrid.SelectedRows[0].Cells["comment"].Value.ToString();
                CategoryCombobox.Text = PassDatagrid.SelectedRows[0].Cells["category"].Value.ToString();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string SQL = "Insert into passwords " +
                " (`name`, `login`, `password`, `url`, `comment`, `category`) " +
                "VALUES " +
                $" ('{NameTextbox.Text}', '{LoginTextbox.Text}', '{PassTextbox.Text}'," +
                $"'{SiteTextbox.Text}', '{CommentTextbox.Text}', '{CategoryCombobox.Text}') ";
            if (DataBaseConnection.ExecuteNonQuery(SQL) == 1)
            {
                PassLoad();
            }
            Clear();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string SQL = "Delete From `passwords` Where";
            for (int i = 0; i < PassDatagrid.SelectedRows.Count; i++)
            {
                if (i >= 1)
                    SQL += " OR ";
                SQL += $"`idPass` = " +
                    $"{ PassDatagrid.SelectedRows[i].Cells[0].Value} ";
            }
            DataBaseConnection.ExecuteNonQuery(SQL);
            PassDatagrid.ClearSelection();
            PassLoad();
            Clear();
        }

        private void Search(string categoryFilter, string findtext)
        {
            if (categoryFilter == "Все" && SearchTextbox.Text != null)
            {
                string SQL = "Select `passwords`.`idPass`, `passwords`.`name`, `passwords`.`login`, " +
                "`passwords`.`password`, `passwords`.`url`, `passwords`.`comment`, `passwords`.`category` " +
                "From passwords " +
                $"Where (`passwords`.`name` Like '%{findtext}')";
                PassDatagrid.DataSource = DataBaseConnection.ExecuteDataQuery(SQL);
            }
            else
            {
                string SQL = "Select `passwords`.`idPass`, `passwords`.`name`, `passwords`.`login`, " +
                "`passwords`.`password`, `passwords`.`url`, `passwords`.`comment`, `passwords`.`category` " +
                "From passwords " +
                $"Where (`passwords`.`name` Like '%{findtext}') ";
                SQL += $"AND `passwords`.`category`='{categoryFilter}' ";
                PassDatagrid.DataSource = DataBaseConnection.ExecuteDataQuery(SQL);
            }
            PassDatagrid.ClearSelection();
            Clear();
        }

        private void SearchTextbox_TextChanged(object sender, EventArgs e)
        {
            Search(FilterCombobox.Text, SearchTextbox.Text);
        }
        private void searchOrFilter(object sender, EventArgs e)
        {
            if (FilterCombobox.Text != "Все" && SearchTextbox.Text != "")
                Search(FilterCombobox.Text, SearchTextbox.Text);
            else
                PassLoad();
        }

        private void PassCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (PassCheckbox.Checked)
            {
                PassTextbox.UseSystemPasswordChar = false;
            }
            else
            {
                PassTextbox.UseSystemPasswordChar = true;
            }
        }

        private void CopyPassButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(PassTextbox.Text);
        }

        private void SiteButton_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo(SiteTextbox.Text);
            Process.Start(sInfo);
        }

        private void Clear()
        {
            NameTextbox.Clear();
            LoginTextbox.Clear();
            PassTextbox.Clear();
            SiteTextbox.Clear();
            CommentTextbox.Clear();
            CategoryCombobox.SelectedIndex = 5;
            PassDatagrid.ClearSelection();
            AddButton.Enabled = true;
            EditButton.Enabled = false;
            PassCheckbox.Checked = false;
            Clipboard.Clear();
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            Info Info = new Info();
            Info.Show();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Settings Settings = new Settings();
            Hide();
            Settings.ShowDialog();
        }
    }
}
