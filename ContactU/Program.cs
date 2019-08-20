using ContactU.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactU
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ContactDao contactDao = new ContactDao();
            PeopleForm peopleForm = new PeopleForm(contactDao);
            //peopleForm.Width = 355;
            
            peopleForm.Presenter.InitialiseViewData();
            Application.Run(peopleForm);           
            
        }
    }
}
