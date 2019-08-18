﻿using ContactU.Interfaces;
using ContactU.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactU.Presenters
{

    /*The Presenters "MEDIATE" between the View and the Model, 
     * it accepts gestures from the View and commands the Model 
     * as appropriate.*/

    public class AddContactPresenter
    {
        private IContactDao _contactDao;        
        private IPeopleFormView _peopleForm;

        public AddContactPresenter(IPeopleFormView peopleFormView, 
                                    IContactDao contactDao)
        {
            this._peopleForm = peopleFormView;
            this._contactDao = contactDao;
        }

        
    }
}