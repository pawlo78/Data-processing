using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace dataGridView_usersProcessing
{
    public partial class FormUsersView : Form
    {
        //object creation
        List<Users> usersList;
        //variable: store last id
        int lastId;       
        //Object Users creation
        Users user = new Users();
        //id from selected row
        int selectedId;

        public FormUsersView()
        {            
            InitializeComponent();           
            //creating data
            InitializeData();
            //preparation of settings 
            InitializeSettings();
        }

        //btn add user
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUser();
            SettingsDataGridView();
            DisplayButtonsDelMod();
        }

        //add user function
        private void AddUser()
        {
            //Data validation
            if (ValidationDataAddUser())
            {
                //set a new id
                lastId++;               
                //reading elements from fields
                string name = tbNameAdd.Text.ToString();
                string surname = tbSurnameAdd.Text.ToString();
                string level = cbLevelAdd.Text.ToString();
                //creating a new list item
                user.AddUser(lastId, name, surname, level);
                //refresh the list
                DataGVRefresh();
                //deleting data from fields
                tbNameAdd.Text = "";
                tbSurnameAdd.Text = "";
                cbLevelAdd.SelectedIndex = 0;
            }
        }

        //checking completed data Add
        private bool ValidationDataAddUser()
        {
            //checking completed fields
            if (tbNameAdd.Text.Trim().Length == 0 || tbSurnameAdd.Text.Trim().Length == 0 || cbLevelAdd.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please complete all data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3, MessageBoxOptions.DefaultDesktopOnly);
                return false;
            }
            return true;
        }

        //delete btn OK
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //delete selected row
            user.DeleteUser(dgvUsersView.CurrentCell.RowIndex);
            //refresh the list
            DataGVRefresh();
            //displaying del and mod buttons
            DisplayButtonsDelMod();
            SettingsDataGridView();
        }

        //modify btn
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //disabling items after clicking the modify button
            dgvUsersView.Enabled = false;
            gbAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            gbMod.Enabled = true;

            //complete the fields
            //setting the id of the selected row to be modified
            string id = dgvUsersView.SelectedRows[0].Cells[0].Value.ToString();
            selectedId = Int16.Parse(id);
            tbNameMod.Text = dgvUsersView.SelectedRows[0].Cells[1].Value.ToString();
            tbSurnameMod.Text = dgvUsersView.SelectedRows[0].Cells[2].Value.ToString();
            cbLevelMod.Text = dgvUsersView.SelectedRows[0].Cells[3].Value.ToString();
        }        

        //checking completed data Mod
        private bool ValidationDataModUser()
        {
            //checking completed fields
            if (tbNameMod.Text.Trim().Length == 0 || tbSurnameMod.Text.Trim().Length == 0 || cbLevelMod.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please complete all data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3, MessageBoxOptions.DefaultDesktopOnly);
                return false;
            }
            return true;
        }

        //Done btn
        private void btnDone_Click(object sender, EventArgs e)
        {
            if (ValidationDataModUser())
            {
                //data assignment
                user.EditUser(selectedId, tbNameMod.Text, tbSurnameMod.Text, cbLevelMod.Text);
                //enabling elements after modification
                tbNameMod.Text = "";
                tbSurnameMod.Text = "";
                cbLevelMod.Text = "";
                dgvUsersView.Enabled = true;
                gbAdd.Enabled = true;
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
                gbMod.Enabled = false;
            }
        }

        //close of aplication
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }       

        //refresh the list
        private void DataGVRefresh()
        {
            dgvUsersView.DataSource = null;
            dgvUsersView.DataSource = usersList;
        }

        //displaying del and mod buttons
        private void DisplayButtonsDelMod()
        {
            if (usersList.Count() > 0)
            {
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
            }
            else
            {
                //if the List is empty
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                lastId = 0;
            }
        }

        //preparation of data 
        private void InitializeData()
        {
            //creating data using a list
            usersList = user.InitializeDataUsers();
            //variable storing current id
            lastId = usersList.Count();
            //assigning data to the dataGridView
            dgvUsersView.DataSource = usersList;
        }

        //preparation of settings 
        private void InitializeSettings()
        {
            SettingsDataGridView();
            //font settings
            dgvUsersView.DefaultCellStyle.Font = new Font("Tahoma", 14);
            //select the entire line
            dgvUsersView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //prohibition of selecting several lines
            this.dgvUsersView.MultiSelect = false;

            //adding items to ComboBox Add
            cbLevelAdd.Items.Add("Beginner");
            cbLevelAdd.Items.Add("Average");
            cbLevelAdd.Items.Add("Expert");
            cbLevelAdd.SelectedIndex = 0;
            //adding items to ComboBox Mod
            cbLevelMod.Items.Add("Beginner");
            cbLevelMod.Items.Add("Average");
            cbLevelMod.Items.Add("Expert");

            //displaying Delete and Modify buttons
            DisplayButtonsDelMod();

            //dispaling the modification field
            gbMod.Enabled = false;
        }

        private void SettingsDataGridView()
        {
            //column and row settings
            dgvUsersView.Columns[0].Width = 40;
            dgvUsersView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvUsersView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvUsersView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvUsersView.RowTemplate.Height = 30;
            dgvUsersView.Columns[0].HeaderText = "ID";
            dgvUsersView.Columns[1].HeaderText = "NAME";
            dgvUsersView.Columns[2].HeaderText = "SURNAME";
            dgvUsersView.Columns[3].HeaderText = "LEVEL";
        }      
    }
}
