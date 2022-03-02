using AutoMapper;
using LibraryProject.Domain.Entities;
using LibraryProject.Domain.Enums;
using LibraryProject.Repositories.Interfaces;
using LibraryProject.Web.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject.Web.Pages
{
    public class ReservationDetailModel : PageModel
    {
        private readonly ILogger<CreateReservationModel> _logger;

        public readonly IBookRepository _bookRepository;

        public readonly IBookReservationRepository _bookReservationRepository;

        private readonly IMapper _mapper;

        public ReservationDetailModel(IMapper mapper, ILogger<CreateReservationModel> logger, IBookRepository bookRepository, IBookReservationRepository bookReservationRepository)
        {
            _logger = logger;
            _bookRepository = bookRepository;
            _bookReservationRepository = bookReservationRepository;
            _mapper = mapper;
        }

        [BindProperty]
        public BookReservationViewModel ReservationViewModel { get; set; }



        public async Task<IActionResult> OnGetAsync(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            ReservationViewModel = new BookReservationViewModel();

            var bookReservation = await _bookReservationRepository.GetByBookId(id);
            ReservationViewModel = _mapper.Map<BookReservationViewModel>(bookReservation);
            if (ReservationViewModel == null)
            {
                return NotFound();
            }
            return Page();
        }




    }
}
