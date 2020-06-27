using System;
using System.Collections.Generic;
using System.Text;

namespace HenE.Aeolus.Blazor.Common.Header.Models
{
    public class HeaderItemModel
    {
        public HeaderItemModel(string titel)
        {
            Titel = titel;
        }

        /// <summary>
        /// Get en set de title van een header.
        /// </summary>
        public string Titel { get; set; }

        /// <summary>
        /// Gets or sets de kinderen van de header.
        /// </summary>
        public List<HeaderItemModel> Kinderen { get; set; }
    }
}
