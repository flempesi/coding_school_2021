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
    public class EditModel : PageModel
    {

        [BindProperty]
        public Customer SelectedListItem { get; set; }

        private IItemStorage _storage { get; set; }

        public EditModel(IItemStorage storage)
        {
            _storage = storage;
        }

        public void OnGet(int id)
        {
            if (id == 0)
            {
                SelectedListItem = new Customer();
                return;
            }

            SelectedListItem = _storage.GetById(id);
        }

        public IActionResult OnPost()
        {
            _storage.AddItem(SelectedListItem);

            return RedirectToPage("List");
        }

        public IActionResult OnPostCancel()
        {
            return RedirectToPage("List");
        }

        public IActionResult OnPostDelete()
        {
            _storage.RemoveItem(SelectedListItem.Id);
            return RedirectToPage("List");
        }
    }
}
