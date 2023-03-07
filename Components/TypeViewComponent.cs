using Microsoft.AspNetCore.Mvc;
using Mission9_cpearce3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9_cpearce3.Components
{
    public class TypeViewComponent : ViewComponent
    {
        private IBookstoreRepository repo { get; set; }

        public TypeViewComponent (IBookstoreRepository temp)
        {
            repo = temp;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedType = RouteData?.Values["category"];

            var types = repo.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x);

            return View(types );
        }
    }
}
