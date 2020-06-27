using System;
using System.Collections.Generic;
using System.Text;
using HenE.Aeolus.Blazor.Common.ShowFileInGrid.Model;

namespace HenE.Aeolus.Blazor.Common.ShowFileInGrid.Interfaces
{
    public interface IShowFileInGrid
    {
        /// <summary>
        /// Gets de data van een Excel bestand.
        /// </summary>
        /// <param name="fileName">De naam van het bestand.</param>
        /// <returns>Een lijst met data die wordt van een Excel bestand opgehaald.</returns>
        List<ExcelCelModel> GetExcelItems(string fileName);
    }
}
