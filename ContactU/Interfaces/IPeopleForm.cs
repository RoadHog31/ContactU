using ContactU.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactU.Interfaces
{
    public interface IPeopleForm
    {
        void AddAllContactsToListView(Contact m_contact);
        void RefreshAllContactsToListView(Contact m_contact);
        void AddContactToListView(Contact contact);
    }
       
}
