using ContactU.Models;

namespace ContactU.Interfaces
{
    public interface IAddContactView
    {       
        Contact ContactToAdd { get; }

        void AddContactToListView(Contact m_contact);       


    }
}
