using ContactU.Interfaces;
using ContactU.Models;
using System.Collections.Generic;

namespace ContactU.Presenters
{
    /// <summary>
    ///The Presenters "MEDIATE" between the View and the Model, 
    ///it accepts gestures from the View and commands the Model
    ///as appropriate.
    ///One of the most important design principle “Program to interfaces, not implementations.”
    /// </summary>
    public class AddContactPresenter
    {
        private IContactDao _contactDao;        
        private IAddPeopleFormView _peopleForm;

        public AddContactPresenter(IAddPeopleFormView peopleFormView, 
                                    IContactDao contactDao)
        {
            this._peopleForm = peopleFormView;
            this._contactDao = contactDao;
        }

        //This accesses method from ContactDao model and passes to the view for binding.
        public void InitialiseViewData()
        {
            IEnumerable<Contact> contacts = _contactDao.GetAllContacts();

            if (contacts != null)
            {
                foreach (Contact contact in contacts)
                {
                    _peopleForm.AddContactToList(contact);
                }
            }
            else
            {
                return;
            }            
        }
    }
}
