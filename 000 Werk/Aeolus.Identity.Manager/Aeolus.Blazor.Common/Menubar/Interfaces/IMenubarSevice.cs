using HenE.Aeolus.Blazor.Common.ListAndItemsBody.Models;
using HenE.Aeolus.Blazor.Common.Menubar.Models;
using System.Collections.Generic;

namespace HenE.Aeolus.Blazor.Common.Menubar.Interfaces
{
    public interface IMenubarSevice
    {
        List<MenubarItemModel> GetMenubarItems();

        void Update(BodyModel item);
    }
}
