using AutoMapper;
using LibraryProject.Domain.Entities;
using LibraryProject.Web.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject.Web
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            // Maps
            CreateMap<BooksEntity, BookViewModel>();
            CreateMap<BookReservationViewModel, BookReservationEntity>();
            CreateMap<BookReservationEntity, BookReservationViewModel>();
            CreateMap<BookReservationHistoryEntity, BookReservationEntity>();

        }
    }
}
