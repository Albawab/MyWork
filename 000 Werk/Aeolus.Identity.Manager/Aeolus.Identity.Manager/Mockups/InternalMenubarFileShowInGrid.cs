// <copyright file="InternalMenubarFileShowInGrid.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Identity.Manager.Mockups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using HenE.Aeolus.Blazor.Common.Menubar.Interfaces;
    using HenE.Aeolus.Blazor.Common.ListAndItemsBody.Models;
    using HenE.Aeolus.Blazor.Common.Menubar.Models;
    using Syncfusion.Blazor.Navigations;

    /// <summary>
    /// Klas om de items van de menubar maken.
    /// </summary>
    public class InternalMenubarFileShowInGrid : IMenubarSevice
    {
        private List<MenubarItemModel> menuItems = new List<MenubarItemModel>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalMenubarFileShowInGrid"/> class.
        /// </summary>
        public InternalMenubarFileShowInGrid()
        {
            this.menuItems.AddRange(this.GetItems());
        }

        /// <summary>
        /// Gets de menubar items.
        /// </summary>
        public List<MenubarItemModel> MenubarItems { get => this.menuItems; }

        public void Update(BodyModel item)
        {
            throw new NotImplementedException();
        }

        private List<MenubarItemModel> GetItems()
        {
            return new List<MenubarItemModel>()
            {
                new MenubarDialogModel(0, "Inlezen") { Kinderen = new List<MenubarItemModel>() { new MenubarUploadFileModel(0, "Upload file"), new MenubarButtonModel(1, "OK") } },
                new MenubarLinkModel(1, "Verwerken"),
            };
        }

        public List<MenubarItemModel> GetMenubarItems()
        {
            return this.menuItems;
        }
    }
}
