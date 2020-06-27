using System;
using System.Collections.Generic;
using System.Text;

namespace HenE.Aeolus.Blazor.Common.Menubar.Models
{
    public class MenubarUploadFileModel : MenubarItemModel
    {
        public MenubarUploadFileModel(int id, string title):base(id, title, MenubarType.UploadFile)
        {
                
        }
    }
}
