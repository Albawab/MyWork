using System;
using System.Collections.Generic;
using System.Text;

namespace HenE.Aeolus.Blazor.Common.Menubar.Models
{
     public class MenubarDialogModel : MenubarItemModel
    {

        public MenubarDialogModel(int id,string title) : base(id, title,MenubarType.Dialog)
        {

        }

        public List<MenubarItemModel> Kinderen { get; set; }
    }
}
