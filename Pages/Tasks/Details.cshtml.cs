using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Task = todo.Models.Task;

namespace todo.Pages.Tasks
{
    public class DetailsModel : PageModel
    {
        private readonly todo.Models.todoContext _context;

        public DetailsModel(todo.Models.todoContext context)
        {
            _context = context;
        }

        public Task Task { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Task = await _context.Task.FirstOrDefaultAsync(m => m.ID == id);

            if (Task == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
