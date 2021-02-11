﻿using System;
using System.Collections.Generic;
using System.Text;
using BSUIR.DAL.Interfaces.Models;

namespace BSUIR.DAL.Interfaces.Context
{
    public interface IAddressesContext : IEntityStorage
    {
        IEntitySet<Address> Addresses{ get; }

    }
}
