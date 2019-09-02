using ContactU.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactU.Interfaces
{
    public interface IContactDao
    {
        List<Contact> GetAllContacts();
        void Save(int id, string p_firstname, string p_lastname, string email, string mobile);
        Contact GetByName(string p_firstname);
    }
}
