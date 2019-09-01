using ContactU.Models;
using ContactU.Interfaces;
using ContactU.Presenters;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ContactU
{
    /// <summary>
    /// MVP - The View creates the Presenter and is "injected with the Model", 
    ///it delegates user inputs to the Presenter and observe the Model for changes
    ///in its data.
    ///The View creates the Presenter, it lives as long as it's visible to the front 
    ///end user.
    /// </summary>
    public partial class PeopleForm : Form, IPeopleForm
    {
        private readonly ContactDao m_contactDao;
        private AddContactPresenter p_addcontactpresenter;
        //private List<Contact> m_allContacts;

        //Initialisation property see Program file entry point.
        public AddContactPresenter Presenter
        {
            get { return p_addcontactpresenter; }
        }

        //Text typed into the seach field textbox on UI. 
        public string SearchName
        {
            set
            {
                txtBoxPeopleSearch.Text = value;
            }
        }

        //Generic Constructor to initialise the app main view...
        public PeopleForm()
        {
            InitializeComponent();
        }

        //Overloaded Constructor takes in a Model layer object.
        public PeopleForm(ContactDao contactDao)
        {
            InitializeComponent();

            AddContactPresenter addContactPresenter = new AddContactPresenter(this, contactDao);

            this.p_addcontactpresenter = addContactPresenter;
            this.m_contactDao = contactDao;

            //Event worked fine.
            //this.Click += new System.EventHandler(UpdateFormTitleWithDateTime);
        }

        //Search text box placeholder UI changes.
        private void BtnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Red;
        }

        //Search text box placeholder UI changes.
        private void BtnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Blue;
        }

        //Takes Initialisation data from Presenter InitView Method...
        // and passes it to the ListView control. 
        public void AddAllContactsToListView(Contact m_contact)
        {
            listView1.Items.Add(m_contact.FirstName);
            listView1.Items.Add(m_contact.LastName);          
            
        }

        private void PeopleForm_Load(object sender, EventArgs e)
        {
            // TODO: Loads search bar with a placeholder.
            txtBoxPeopleSearch.Text = "Enter some text here please...";
            txtBoxPeopleSearch.ForeColor = Color.DarkGray;
            //this.Click += new System.EventHandler(UpdateFormTitleWithDateTime);

            //addContact1.SendToBack();
            //addContact1.Hide();

            //Event Test...
            //Text = "Testing!!!!" + DateTime.Now;        
        }

        //"raising events" Test eventhandler - see PeopleForm_Load event.
        private void UpdateFormTitleWithDateTime(object sender, EventArgs e)
        {
            Text = "Testing!!!! -" + DateTime.Now;
        }

        // TODO: Removes placeholder from search bar.
        private void TextBoxSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxPeopleSearch.Text) || string.IsNullOrWhiteSpace(txtBoxPeopleSearch.Text))
            {
               txtBoxPeopleSearch.Text = "Enter some text here please...";
               txtBoxPeopleSearch.ForeColor = Color.DarkGray;
            }            
        }

        // TODO: Loads search bar with a placeholder.
        private void TextBoxSearch_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxPeopleSearch.Text) || !string.IsNullOrWhiteSpace(txtBoxPeopleSearch.Text))
            {
                txtBoxPeopleSearch.Text = "";
                txtBoxPeopleSearch.ForeColor = Color.Black;
            }
        }

        private void BtnAddContact_Click(object sender, EventArgs e)
        {
            btnEdit.Hide();
            btnEdit.SendToBack();
            //editContact1.Hide();
            //deleteContact1.Hide();
            this.Size = new System.Drawing.Size(695, 900);
            //addContact1.BringToFront();
            //addContact1.Visible = true; 
            
            
        }

        public void RefreshAllContactsToListView(Contact m_contact)
        {
            throw new NotImplementedException();
        }

        public void AddContactToListView(Contact contact)
        {
            throw new NotImplementedException();
        }


        private void BtnEditContact_Click(object sender, EventArgs e)
        {

        }
    }
}
