using HenE.Aeolus.Blazor.Common.Menubar.Models;
using System.Collections.Generic;

namespace HenE.Aeolus.Blazor.Common.ListAndItemsBody.Interfaces
{
    public interface IHandleMenubar
    {
        List<MenubarItemModel> GetMenubarItems();
    }
}
