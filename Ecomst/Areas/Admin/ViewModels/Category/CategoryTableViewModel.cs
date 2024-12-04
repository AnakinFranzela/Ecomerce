﻿using Ecomst.DTO;
using Ecomst.Helpers;
using System.ComponentModel;

namespace Ecomst.Areas.Admin.ViewModels.Category
{
    public class CategoryTableViewModel : BaseTableViewModel
    {
        public List<Entities.Category> Data { get; set; }
        public void PopulateFromSearchResult(SearchResult<Entities.Category> searchResult)
        {
            TotalPages = searchResult.TotalPages;
            RecordsTotal = searchResult.RecordsTotal;
            RecordsFiltered = searchResult.RecordsFiltered;
            Start = searchResult.Start;
            Data = searchResult.Data;
        }

        //Search properties
        [DisplayName("Име")]
        public string? Name { get; set; }
        [DisplayName("Ред на показване")]
        public int? DisplayOrder { get; set; }
    }
}
