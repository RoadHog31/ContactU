using ContactU.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactU.Interfaces
{
    public interface IAddPeopleFormView
    {
        string SearchName { set; }

        Contact ContactToAdd { get; }

        void AddContactToListView(Contact m_contact);
    }
}
