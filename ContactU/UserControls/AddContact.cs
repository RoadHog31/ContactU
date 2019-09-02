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

        //private List<Contact> m_allContacts;
        //private Contact contactModel;

        //First Name property used for binding. 
        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (string.IsNullOrEmpty(txtBoxFirstName.Text) || string.IsNullOrWhiteSpace(txtBoxFirstName.Text))
                {
                    _firstName = txtBoxFirstName.Text;
                }
            }
        }

        //Last Name property used for binding. 
        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (string.IsNullOrEmpty(txtBoxLastName.Text) || string.IsNullOrWhiteSpace(txtBoxLastName.Text))
                {
                    _lastName = txtBoxFirstName.Text;
                }
            }
        }

        //Last Name property used for binding. 
        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                if (string.IsNullOrEmpty(txtBoxEmail.Text) || string.IsNullOrWhiteSpace(txtBoxEmail.Text))
                {
                    _email = txtBoxEmail.Text;
                }
            }
        }

        //Last Name property used for binding. 
        private string _mobile;
        public string Mobile
        {
            get { return _mobile; }
            set
            {
                if (string.IsNullOrEmpty(txtBoxMobile.Text) || string.IsNullOrWhiteSpace(txtBoxMobile.Text))
                {
                    _mobile = txtBoxEmail.Text;
                }
            }
        }

        //ID property used for binding. 
        private int _ID;
        public int ContactID
        {
            get { return _ID; }
            set {
                if (value > -1)
                {
                    _ID = value;
                }
                             
                }
        }

        public AddContact()
        {
            InitializeComponent();
        }

        public AddContact(Contact contact)
        {
           // this.contactModel = contact;
        }

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
            p_addcontactpresenter.AddContact(_ID, _firstName, _lastName, _mobile, _email);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test Save");
            
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

        }

        private void AddContact_Load(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
