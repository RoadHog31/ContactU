using ContactU.Interfaces;
using ContactU.Models;
using ContactU.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactU
{
    /*The View creates the Presenter and is "injected with the Model", 
   * it delegates user inputs to the Presenter and observe the Model for changes 
   * in its data.
   * The View creates the Presenter, it lives as long as it's visible to the front 
   * end user.*/

    public partial class PeopleForm : Form, IPeopleFormView
    {
        private readonly ContactDao m_contactDao;
        private AddContactPresenter p_addcontactpresenter;
        //private List<Contact> m_allContacts;

        //Initialisation property see Program file entry point.
        public AddContactPresenter Presenter
        {
            get { return p_addcontactpresenter; }
        }

        public string SearchName { set => throw new NotImplementedException(); }

        public Contact ContactToAdd => throw new NotImplementedException();

        //Generic Constructor all form to initially start up...
        public PeopleForm()
        {
            InitializeComponent();
        }

        //Custom Constructor
        public PeopleForm(ContactDao contactDao)
        {
            InitializeComponent();

            AddContactPresenter addContactPresenter = new AddContactPresenter(this, contactDao);

            this.p_addcontactpresenter = addContactPresenter;
            this.m_contactDao = contactDao;
        }

        private void BtnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Red;
        }

        private void BtnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Blue;
        }

        public void AddContactToList(Contact m_contact)
        {
            listView1.Items.Add(m_contact.FirstName);
            listView1.Items.Add(m_contact.LastName);
            listView1.Items.Add(Convert.ToBase64String(m_contact.Image));

        }

        private void PeopleForm_Load(object sender, EventArgs e)
        {
            // TODO: Loads search bar with a placeholder.
            txtBoxPeopleSearch.Text = "Enter some text here please...";
            txtBoxPeopleSearch.ForeColor = Color.DarkGray;
        }

        // TODO: Removes placeholder from search bar.
        private void TextBoxSearch_Leave(object sender, EventArgs e)
        {
            if (txtBoxPeopleSearch.Text == "")
            {
                txtBoxPeopleSearch.Text = "Enter some text here please...";

            }
        }

        // TODO: Loads search bar with a placeholder.
        private void TextBoxSearch_Enter(object sender, EventArgs e)
        {
            if (txtBoxPeopleSearch.Text == "Enter some text here please...")
            {
                txtBoxPeopleSearch.Text = "";
                txtBoxPeopleSearch.ForeColor = Color.Black;
            }
        }
    }
}
