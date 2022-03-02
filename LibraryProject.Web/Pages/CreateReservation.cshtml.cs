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
    public class CreateReservationModel : PageModel
    {
        private readonly ILogger<CreateReservationModel> _logger;

        public readonly IBookRepository _bookRepository;

        public readonly IBookReservationRepository _bookReservationRepository;

        public readonly IBookReservationHistoryRepository _bookReservationHistoryRepository;

        private readonly IMapper _mapper;

        public CreateReservationModel(IBookReservationHistoryRepository bookReservationHistoryRepository, IMapper mapper, ILogger<CreateReservationModel> logger, IBookRepository bookRepository, IBookReservationRepository bookReservationRepository)
        {
            _logger = logger;
            _bookRepository = bookRepository;
            _bookReservationRepository = bookReservationRepository;
            _mapper = mapper;
            _bookReservationHistoryRepository = bookReservationHistoryRepository;
        }

        [BindProperty]
        public BookReservationViewModel ReservationViewModel { get; set; }



        public async Task<IActionResult> OnGetAsync(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ReservationViewModel = new BookReservationViewModel();

            ReservationViewModel.BookId = id;

            var book = await _bookRepository.GetById(id);
            ReservationViewModel.BookName = book.BookName;

            if (ReservationViewModel == null)
            {
                return NotFound();
            }
            return Page();
        }


        public async Task<IActionResult> OnPostAsync(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
           

            var bookReservationEntity = _mapper.Map<BookReservationEntity>(ReservationViewModel);
            bookReservationEntity.BookId = id;
            bookReservationEntity.ReserveStartDate = DateTime.Now;
            bookReservationEntity.ReserveEndDate = DateTime.Now.AddDays(15);
            //Create reservation
            await _bookReservationRepository.Create(bookReservationEntity);
            var bookReservationHistoryEntity = _mapper.Map<BookReservationHistoryEntity>(bookReservationEntity);
            bookReservationHistoryEntity.ReservationStatus = (int)BookStatusEnum.CheckOut;
            //Create reservation history
            //await _bookReservationHistoryRepository.Create(bookReservationHistoryEntity);

            var bookEntity = await _bookRepository.GetById(id);
            bookEntity.Status = (int)BookStatusEnum.CheckIn;
            await _bookRepository.Update(bookEntity.Id, bookEntity);
            return RedirectToPage("./Index");
        }

    }
}
