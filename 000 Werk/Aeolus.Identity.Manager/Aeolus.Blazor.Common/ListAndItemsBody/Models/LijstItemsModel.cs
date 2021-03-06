﻿using System.Collections.Generic;

namespace HenE.Aeolus.Blazor.Common.ListAndItemsBody.Models
{
    public class LijstItemsModel
    {
        public LijstItemsModel(string title)
        {
            Title = title;
        }
        public int Id { get; set; }

        public string Title { get; set; }

        public List<LijstItemsModel> Kinderen { get; set; }
    }
}
