using System;
using System.Windows.Forms;
using ContactU.Interfaces;
using ContactU.Models;
using ContactU.Presenters;

namespace ContactU.UserControls
{
    public partial class AddContact : UserControl, IAddContactView
    {
        private readonly ContactDao m_contactDao;
        private AddContactPresenter p_addcontactpresenter;
        //private List<Contact> m_allContacts;

        public AddContact()
        {
            InitializeComponent();
        }

        public AddContact(ContactDao contactDao, AddContactPresenter addContactPresenter)
        {
            InitializeComponent();

            this.m_contactDao = contactDao;
            this.p_addcontactpresenter = addContactPresenter;
        }

        //Contact property used for binding. 
        public Contact ContactToAdd 
        { 
            set 
            {
              
                    
            } 
        }

        //Presenter object created.
        public AddContactPresenter Presenter
        {
            get { return p_addcontactpresenter; }
        }       

        //Takes Initialisation data from Presenter InitView Method...
        // and passes it to the ListView control. 
        public void AddContactToListView(Contact m_contact)
        {
            //Presenter object used. 
            p_addcontactpresenter.AddContact();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test Save");
            
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test Cancel");
        }
    }
}
