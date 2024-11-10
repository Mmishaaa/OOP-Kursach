using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using ScooterBooking.Application.ViewModels.BookingViewModel;
using ScooterBooking.Domain.Entities;
using ScooterBooking.Domain.Interfaces.Services;
using ScooterBooking.Domain.PaginationModels;
using ScooterBooking.Presentation.Constants;

namespace ScooterBooking.Presentation.Controllers
{
    [Controller]
    [Route($"{ControllerEndpoints.BookingEndpoint}")]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateBookingViewModel> _createBookingViewModelValidator;
        private readonly IValidator<UpdateBookingViewModel> _updateBookingViewModelValidator;
        public BookingController(
            IBookingService bookingService,
            IMapper mapper,
            IValidator<CreateBookingViewModel> createBookingViewModelValidator,
            IValidator<UpdateBookingViewModel> updateBookingViewModelValidator)
        {
            _bookingService = bookingService;
            _mapper = mapper;
            _createBookingViewModelValidator = createBookingViewModelValidator;
            _updateBookingViewModelValidator = updateBookingViewModelValidator;
        }

        [HttpGet]
        public async Task<PagedResult<ShortBookingViewModel>> GetAllAsync([FromQuery] int pageNumber, int pageSize, CancellationToken cancellationToken)
        {
            var pagedResult = await _bookingService.GetAllAsync(pageNumber, pageSize, cancellationToken);
            return _mapper.Map<PagedResult<ShortBookingViewModel>>(pagedResult);
        }

        [HttpGet("{id}")]
        public async Task<ShortBookingViewModel> GetByIdAsync([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            var assistance = await _bookingService.GetByIdAsync(id, cancellationToken);
            return _mapper.Map<ShortBookingViewModel>(assistance);
        }

        [HttpPost]
        public async Task<BookingViewModel> CreateAsync([FromBody] CreateBookingViewModel viewModel, CancellationToken cancellationToken)
        {
            await _createBookingViewModelValidator.ValidateAndThrowAsync(viewModel, cancellationToken);
            var assistance = _mapper.Map<BookingEntity>(viewModel);
            var result = await _bookingService.AddAsync(assistance, cancellationToken);
            return _mapper.Map<BookingViewModel>(result);
        }

        [HttpPut("{id}")]
        public async Task<BookingViewModel> Update([FromRoute] Guid id, [FromBody] UpdateBookingViewModel viewModel, CancellationToken cancellationToken)
        {
            await _updateBookingViewModelValidator.ValidateAndThrowAsync(viewModel, cancellationToken);
            var modelToUpdate = _mapper.Map<BookingEntity>(viewModel);
            var result = await _bookingService.UpdateAsync(id, modelToUpdate, cancellationToken);
            return _mapper.Map<BookingViewModel>(result);
        }

        [HttpDelete("{id}")]
        public Task DeleteAsync([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            return _bookingService.DeleteAsync(id, cancellationToken);
        }
    }
}
