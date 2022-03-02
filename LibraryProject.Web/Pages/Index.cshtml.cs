using AutoMapper;
using LibraryProject.Repositories.Interfaces;
using LibraryProject.Web.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryProject.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;


        public IndexModel(ILogger<IndexModel> logger,IBookRepository bookRepository, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
            _bookRepository = bookRepository;
        }

        public List<BookViewModel> BookViewModel{ get; set; }

        public async Task<IActionResult> Onget()
        {
            var getAllBooks = _bookRepository.GetAll();
             BookViewModel = _mapper.Map<List<BookViewModel>>(getAllBooks);


            if (BookViewModel == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
