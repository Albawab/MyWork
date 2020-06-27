using HenE.Aeolus.Blazor.Common.Header.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HenE.Aeolus.Blazor.Common.Header.Interface
{
    public interface IHeader
    {
       HeaderItemModel GetHeaderItems();
    }
}
