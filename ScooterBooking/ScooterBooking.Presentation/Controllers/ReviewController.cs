using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using ScooterBooking.Application.ViewModels.ReviewViewModel;
using ScooterBooking.Domain.Entities;
using ScooterBooking.Domain.Interfaces.Services;
using ScooterBooking.Domain.PaginationModels;
using ScooterBooking.Presentation.Constants;

namespace ScooterBooking.Presentation.Controllers
{
    [Controller]
    [Route($"{ControllerEndpoints.ReviewEndpoint}")]
    public class ReviewController : ControllerBase
    {
        private readonly IReviewService _reviewService;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateReviewViewModel> _createReviewViewModelValidator;
        private readonly IValidator<UpdateReviewViewModel> _updateReviewViewModelValidator;
        public ReviewController(
            IReviewService reviewService,
            IMapper mapper,
            IValidator<CreateReviewViewModel> createReviewViewModelValidator,
            IValidator<UpdateReviewViewModel> updateReviewViewModelValidator)
        {
            _reviewService = reviewService;
            _mapper = mapper;
            _createReviewViewModelValidator = createReviewViewModelValidator;
            _updateReviewViewModelValidator = updateReviewViewModelValidator;
        }

        [HttpGet]
        public async Task<PagedResult<ShortReviewViewModel>> GetAllAsync([FromQuery] int pageNumber, int pageSize, CancellationToken cancellationToken)
        {
            var pagedResult = await _reviewService.GetAllAsync(pageNumber, pageSize, cancellationToken);
            return _mapper.Map<PagedResult<ShortReviewViewModel>>(pagedResult);
        }

        [HttpGet("{id}")]
        public async Task<ShortReviewViewModel> GetByIdAsync([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            var ReviewEntity = await _reviewService.GetByIdAsync(id, cancellationToken);
            return _mapper.Map<ShortReviewViewModel>(ReviewEntity);
        }

        [HttpPost]
        public async Task<ReviewViewModel> CreateAsync([FromBody] CreateReviewViewModel viewModel, CancellationToken cancellationToken)
        {
            await _createReviewViewModelValidator.ValidateAndThrowAsync(viewModel, cancellationToken);
            var ReviewEntity = _mapper.Map<ReviewEntity>(viewModel);
            var result = await _reviewService.AddAsync(ReviewEntity, cancellationToken);
            return _mapper.Map<ReviewViewModel>(result);
        }

        [HttpPut("{id}")]
        public async Task<ReviewViewModel> UpdateAsync([FromRoute] Guid id, [FromBody] UpdateReviewViewModel viewModel, CancellationToken cancellationToken)
        {
            await _updateReviewViewModelValidator.ValidateAndThrowAsync(viewModel, cancellationToken);
            var modelToUpdate = _mapper.Map<ReviewEntity>(viewModel);
            var result = await _reviewService.UpdateAsync(id, modelToUpdate, cancellationToken);
            return _mapper.Map<ReviewViewModel>(result);
        }

        [HttpDelete("{id}")]
        public Task DeleteAsync([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            return _reviewService.DeleteAsync(id, cancellationToken);
        }
    }
}
