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
    public class IndexModel : PageModel
    {
        private readonly todo.Models.todoContext _context;

        public IndexModel(todo.Models.todoContext context)
        {
            _context = context;
        }

        public IList<Task> Task { get;set; }

        public async void OnGetAsync()
        {
            Task = await _context.Task.ToListAsync();
        }
    }
}
