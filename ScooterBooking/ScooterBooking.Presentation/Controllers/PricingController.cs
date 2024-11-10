using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ScooterBooking.Application.ViewModels.PricingViewModel;
using ScooterBooking.Domain.Entities;
using ScooterBooking.Domain.Interfaces.Services;
using ScooterBooking.Domain.PaginationModels;
using ScooterBooking.Presentation.Constants;

namespace ScooterBooking.Presentation.Controllers
{
    [Controller]
    [Route($"{ControllerEndpoints.PricingEndpoint}")]
    public class PricingController : ControllerBase
    {
        private readonly IPricingService _pricingService;
        private readonly IMapper _mapper;
        public PricingController(IPricingService pricingService, IMapper mapper)
        {
            _pricingService = pricingService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<PagedResult<ShortPricingViewModel>> GetAllAsync([FromQuery] int pageNumber, int pageSize, CancellationToken cancellationToken)
        {
            var pagedResult = await _pricingService.GetAllAsync(pageNumber, pageSize, cancellationToken);
            return _mapper.Map<PagedResult<ShortPricingViewModel>>(pagedResult);
        }

        [HttpGet("{id}")]
        public async Task<ShortPricingViewModel> GetByIdAsync([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            var pricingEntity = await _pricingService.GetByIdAsync(id, cancellationToken);
            return _mapper.Map<ShortPricingViewModel>(pricingEntity);
        }

        [HttpPost]
        public async Task<PricingViewModel> CreateAsync([FromBody] CreatePricingViewModel viewModel, CancellationToken cancellationToken)
        {
            //await _createAssistanceViewModelValidator.ValidateAndThrowAsync(viewModel, cancellationToken);
            var pricingEntity = _mapper.Map<PricingEntity>(viewModel);
            var result = await _pricingService.AddAsync(pricingEntity, cancellationToken);
            return _mapper.Map<PricingViewModel>(result);
        }

        [HttpPut("{id}")]
        public async Task<PricingViewModel> Update([FromRoute] Guid id, [FromBody] UpdatePricingViewModel viewModel, CancellationToken cancellationToken)
        {
            //await _updateAssistanceViewModelValidator.ValidateAndThrowAsync(viewModel, cancellationToken);
            var modelToUpdate = _mapper.Map<PricingEntity>(viewModel);
            var result = await _pricingService.UpdateAsync(id, modelToUpdate, cancellationToken);
            return _mapper.Map<PricingViewModel>(result);
        }

        [HttpDelete("{id}")]
        public Task DeleteAsync([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            return _pricingService.DeleteAsync(id, cancellationToken);
        }
    }
}
