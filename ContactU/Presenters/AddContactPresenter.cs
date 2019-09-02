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
        private IPeopleForm _peopleForm;
        private IAddContactView addContactView;

        public AddContactPresenter(IPeopleForm peopleFormView, 
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
                    _peopleForm.AddAllContactsToListView(contact);
                }
            }
            else
            {
                return;
            }            
        }

        /// <summary>
        /// Called by the view; this grabs the updated contact from the view and commits it to the DB.
        /// </summary>
        public void AddContact(int id, string firstName, string LastName, string Mobile, string email) 
        {
            _contactDao.Save(id, firstName, LastName, Mobile, email);

        }

        // <summary>
        /// Checks if a contact already exists with the same contact ID.
        /// </summary>
        private bool IsContactinDatabase(Contact contact)
        {
            return false;
        }
    }
}
