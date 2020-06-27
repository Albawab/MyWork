﻿// <copyright file="ToolType.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Blazor.Common.Menubar.Models
{
    /// <summary>
    /// Een enumeratie waar de types van de tool items staat in.
    /// </summary>
    public enum MenubarType
    {
        /// <summary>
        /// De item is een knop.
        /// </summary>
        Button,

        /// <summary>
        /// De item is een group.
        /// </summary>
        Group,

        /// <summary>
        /// De item is een link.
        /// </summary>
        Link,

        /// <summary>
        /// De item is een search box.
        /// </summary>
        Search,

        UploadFile,

        Dialog,
    }
}