using ContactU.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace ContactU.Models
{
    /// <summary>
    ///Long lasting "OBSERVABLE" with caching.
    ///The Model allows getting/saving data from/to the data source,
    ///it stores cached data and raises events to notify its clients about...
    ///changes in its data.
    ///The Model is unaware of neither the View nor the Presenter.
    ///Both View and Presenter reference the Model which acts as an observable. 
    ///Indeed, one of the most  important principles of MVC/P is that the Model
    ///should supply a mechanism to allow multiple Views to observe its data.
    /// </summary>
    public class ContactDao : IContactDao
    {
        
        //private ContactDataMapper _contactDataMapper;
        //private List<Contact> c_AllContacts;

        /// <summary>
        /// Datamapper (if used) and concrete model goes in this class.
        /// </summary>
        public ContactDao()
        {
            
        }        

        //On first initialising the app gets all contacts from EF6 context...    
        public List<Contact> GetAllContacts()
        {              
            try
            {
                using (ContactMiidbEntities contactMiidbEntities = new ContactMiidbEntities())
                {
                    var c_AllContacts = contactMiidbEntities.Contacts.ToList();

                    var p_AllContacts = c_AllContacts;

                    return p_AllContacts;
                }
                
            }
            catch (SqlException sqlex)
            {
                throw sqlex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                
            }
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
