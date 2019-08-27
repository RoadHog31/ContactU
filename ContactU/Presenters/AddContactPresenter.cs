using ContactU.Interfaces;
using ContactU.Models;
using System.Collections.Generic;

namespace ContactU.Presenters
{
    /// <summary>
    ///MVP - The Presenters "MEDIATE" between the View and the Model, 
    ///it accepts gestures from the View and commands the Model
    ///as appropriate.
    ///One of the most important design principle “Program to interfaces, not implementations.”
    /// </summary>
    public class AddContactPresenter
    {
        private IContactDao _contactDao;        
        private IAddContactView _peopleForm;        

        public AddContactPresenter(IAddContactView peopleFormView, 
                                    IContactDao contactDao)
        {
            _peopleForm = peopleFormView;
            _contactDao = contactDao;
        }        

        //This accesses method from ContactDao model and passes to the view for binding.
        public void InitialiseViewData()
        {
            IEnumerable<Contact> contacts = _contactDao.GetAllContacts();

            if (contacts != null)
            {
                foreach (Contact contact in contacts)
                {
                    _peopleForm.AddContactToListView(contact);
                }
            }
            else
            {
                return;
            }            
        }
    }
}
