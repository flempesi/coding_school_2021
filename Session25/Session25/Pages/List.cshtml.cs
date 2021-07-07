using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Session25.Model;
using Session25.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Session25.Pages
{
    public class ListModel : PageModel
    {
        public List<Customer> Items = new List<Customer>();

        private IItemStorage _storage { get; set; }

        public ListModel(IItemStorage storage)
        {
            _storage = storage;
        }

        public void OnGet()
        {
            Items = _storage.GetAllItems();
        }
    }
}
