using System;
using System.Windows.Forms;
using ContactU.Interfaces;
using ContactU.Models;
using ContactU.Presenters;

namespace ContactU.UserControls
{
    public partial class AddContact : UserControl, IAddContactView, IClear
    {
        private readonly ContactDao m_contactDao;
        private AddContactPresenter p_addcontactpresenter;

        Contact contactModel = new Contact();                 
       
        //Generic Constructor
        public AddContact()
        {
            InitializeComponent();
        }

        //Override Constructor
        public AddContact(Contact contact)
        {
            InitializeComponent();
            // this.contactModel = contact;
        }

        //Override Constructor
        public AddContact(ContactDao contactDao, AddContactPresenter addContactPresenter)
        {
            InitializeComponent();

            this.m_contactDao = contactDao;
            this.p_addcontactpresenter = addContactPresenter;            
        }

        //Presenter object created.
        public AddContactPresenter Presenter
        {
            get { return p_addcontactpresenter; }
        }

        public Contact ContactToAdd => throw new NotImplementedException();

        //Takes Initialisation data from Presenter InitView Method...
        // and passes it to the ListView control. 
        public void AddContactToListView()
        {
            //Presenter object used. 
            //p_addcontactpresenter.AddContact();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxFirstName.Text) || !string.IsNullOrWhiteSpace(txtBoxFirstName.Text))
            {
                contactModel.FirstName = txtBoxFirstName.Text.Trim();
            }
            if (!string.IsNullOrEmpty(txtBoxLastName.Text) || !string.IsNullOrWhiteSpace(txtBoxLastName.Text))
            {
                contactModel.LastName = txtBoxLastName.Text.Trim();
            }
            if (!string.IsNullOrEmpty(txtBoxEmail.Text) || !string.IsNullOrWhiteSpace(txtBoxEmail.Text))
            {
                contactModel.Email = txtBoxEmail.Text.Trim();
            }
            if (!string.IsNullOrEmpty(txtBoxMobile.Text) || !string.IsNullOrWhiteSpace(txtBoxMobile.Text))
            {
                contactModel.Mobile = txtBoxMobile.Text.Trim();
            }
            if (contactModel != null)
            {
                p_addcontactpresenter.AddContact(contactModel);
            }
            else
            {
                return;
            }               
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test Cancel");
        }

        public void Clear()
        {                   
            txtBoxFirstName.Text = "";
            txtBoxLastName.Text = "";
            txtBoxMobile.Text = "";
            txtBoxEmail.Text = "";
            //Id initially set to 0 so we do ot need to add this. 
            contactModel.ContactId = 0;
        }

        private void AddContact_Load(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
