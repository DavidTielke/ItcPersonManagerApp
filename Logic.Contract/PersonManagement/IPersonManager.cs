﻿using CrossCutting.Contract.DataClasses;

namespace DavidTielke.PMA.Logic.PersonManagement;

public interface IPersonManager
{
    IQueryable<Person> GetAllAdults();
    IQueryable<Person> GetAllChildren();
}