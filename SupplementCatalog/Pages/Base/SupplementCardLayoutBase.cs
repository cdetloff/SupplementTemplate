using Microsoft.AspNetCore.Components;
using SupplementCatalog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplementCatalog.web.Pages.Base
{
    public class SupplementCardLayoutBase : ComponentBase
    {
        public IEnumerable<SupplementModel> Supplements { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await Task.Run(LoadSupplements);
        }

        private void LoadSupplements()
        {
            System.Threading.Thread.Sleep(1000);
            Supplements = new List<SupplementModel>()
            {
                new SupplementModel()
                {
                    Name = "Test 1",
                    ImagePath = "css/images/generic-supplement-image.jpg",
                    ShortDescription = "Test Description",
                    LongDescription = "Test Long Description."
                },
                new SupplementModel()
                {
                    Name = "Test 2",
                    ImagePath = "css/images/generic-supplement-image.jpg",
                    ShortDescription = "Test Description",
                    LongDescription = "Test Long Description."
                },
                new SupplementModel()
                {
                    Name = "Test 3",
                    ImagePath = "css/images/generic-supplement-image.jpg",
                    ShortDescription = "Test Description",
                    LongDescription = "Test Long Description."
                },
                new SupplementModel()
                {
                    Name = "Test 4",
                    ImagePath = "css/images/generic-supplement-image.jpg",
                    ShortDescription = "Test Description",
                    LongDescription = "Test Long Description."
                },
                new SupplementModel()
                {
                    Name = "Test 5",
                    ImagePath = "css/images/generic-supplement-image.jpg",
                    ShortDescription = "Test Description",
                    LongDescription = "Test Long Description."
                },
                new SupplementModel()
                {
                    Name = "Test 6",
                    ImagePath = "css/images/generic-supplement-image.jpg",
                    ShortDescription = "Test Description",
                    LongDescription = "Test Long Description."
                }
            };

        }
    }
}
