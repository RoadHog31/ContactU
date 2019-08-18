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
    }
}
