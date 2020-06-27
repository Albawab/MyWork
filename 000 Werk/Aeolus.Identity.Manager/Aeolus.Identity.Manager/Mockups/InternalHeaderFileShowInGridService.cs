// <copyright file="InternalHeaderFileShowInGridService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Identity.Manager.Mockups
{
    using System.Collections.Generic;
    using HenE.Aeolus.Blazor.Common.Header.Interface;
    using HenE.Aeolus.Blazor.Common.Header.Models;

    public class InternalHeaderFileShowInGridService : IHeader
    {
        public HeaderItemModel GetHeaderItems()
        {
            return this.GetItems();
        }

        private HeaderItemModel GetItems()
        {
            return new HeaderItemModel("Import");
        }
    }
}
