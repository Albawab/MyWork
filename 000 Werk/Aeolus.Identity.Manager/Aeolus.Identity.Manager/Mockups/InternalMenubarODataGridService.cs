// <copyright file="InternalMenubarODataGridService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Identity.Manager.Mockups
{
    using System;
    using System.Collections.Generic;
    using HenE.Aeolus.Blazor.Common.Menubar.Interfaces;
    using HenE.Aeolus.Blazor.Common.ListAndItemsBody.Models;
    using HenE.Aeolus.Blazor.Common.Menubar.Models;

    public class InternalMenubarODataGridService : IMenubarSevice
    {
        private List<MenubarItemModel> toolmenuItem = new List<MenubarItemModel>();
        private List<MenubarItemModel> updateToolmenuItem = new List<MenubarItemModel>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalMenubarODataGridService"/> class.
        /// </summary>
        public InternalMenubarODataGridService()
        {
            this.ToolMenuItem.AddRange(this.GetItems());
        }

        /// <summary>
        /// Gets or sets de element van de tool bar.
        /// </summary>
        public List<MenubarItemModel> ToolMenuItem { get => this.toolmenuItem; set => this.toolmenuItem = value; }

        /// <summary>
        /// Krijgt de tools bar.
        /// </summary>
        /// <returns>De tools bar.</returns>
        public List<MenubarItemModel> GetMenubarItems()
        {
            return this.ToolMenuItem;
        }

        /// <inheritdoc/>
        public void Update(BodyModel item)
        {
            throw new NotImplementedException();
        }

        private List<MenubarItemModel> GetItems()
        {
            List<MenubarItemModel> result = new List<MenubarItemModel>();
            result.Add(new MenubarLinkModel(1, "Excel Exporteren"));
            result.Add(new MenubarLinkModel(3, "Pdf Exporteren"));
            return result;
        }
    }
}
