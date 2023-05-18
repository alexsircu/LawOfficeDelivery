﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawOfficeDelivery.Interface
{
    internal interface IDeliveryFactory
    {
        void GetDelivery(IProviderFactory orderProviderFactory);
    }
}
