using ContactU.Models;

namespace ContactU.Interfaces
{
    public interface IAddContactView
    {       
        Contact ContactToAdd { set; }

        void AddContactToListView(Contact m_contact); 

    }
}
