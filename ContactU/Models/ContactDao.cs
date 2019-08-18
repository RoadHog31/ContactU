using ContactU.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactU.Models
{
    //Long lasting "OBSERVABLE" with caching.
    //The Model allows getting/saving data from/to the data source, 
    //it stores cached data and raises events to notify its clients about...
    //changes in its data.
    //The Model is unaware of neither the View nor the Presenter.
    //Both View and Presenter reference the Model which acts as an observable. 
    //Indeed, one of the most  important principles of MVC/P is that the Model 
    //should supply a mechanism to allow multiple Views to observe its data.
    
    public class ContactDao : IContactDao
    {
        private List<Contact> c_AllContacts;

        //Datamapper and concrete model goes in this class...
        //private ContactDataMapper _contactDataMapper;
        //private List<Contact> c_AllContacts;

        public ContactDao()
        {
           
        }

        //On first initialising the app get all contacts...    
        public List<Contact> GetAllContacts()
        {              
            try
            {
                using (ContactMiidbEntities contactMiidbEntities = new ContactMiidbEntities())
                {
                  var c_AllContacts = contactMiidbEntities.Contacts.FirstOrDefault();
                }
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            return c_AllContacts;
        }

        public Contact GetByName(string p_firstname)
        {
            throw new NotImplementedException();
        }

        public void Save(Contact p_contact)
        {
            throw new NotImplementedException();
        }
    }

    
}
