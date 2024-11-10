using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using ScooterBooking.Application.ViewModels.InsuranceViewModel;
using ScooterBooking.Domain.Entities;
using ScooterBooking.Domain.Interfaces.Services;
using ScooterBooking.Domain.PaginationModels;
using ScooterBooking.Presentation.Constants;

namespace ScooterBooking.Presentation.Controllers
{
    [Controller]
    [Route($"{ControllerEndpoints.InsuranceEndpoint}")]
    public class InsuranceController
    {
        private readonly IInsuranceService _insuranceService;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateInsuranceViewModel> _createInsuranceViewModelValidator;
        private readonly IValidator<UpdateInsuranceViewModel> _updateInsuranceViewModelValidator;
        public InsuranceController(
            IInsuranceService insuranceService,
            IMapper mapper,
            IValidator<CreateInsuranceViewModel> createInsuranceViewModelValidator,
            IValidator<UpdateInsuranceViewModel> updateInsuranceViewModelValidator)
        {
            _insuranceService = insuranceService;
            _mapper = mapper;
            _createInsuranceViewModelValidator = createInsuranceViewModelValidator;
            _updateInsuranceViewModelValidator = updateInsuranceViewModelValidator;
        }

        [HttpGet]
        public async Task<PagedResult<ShortInsuranceViewModel>> GetAllAsync([FromQuery] int pageNumber, int pageSize, CancellationToken cancellationToken)
        {
            var pagedResult = await _insuranceService.GetAllAsync(pageNumber, pageSize, cancellationToken);
            return _mapper.Map<PagedResult<ShortInsuranceViewModel>>(pagedResult);
        }

        [HttpGet("{id}")]
        public async Task<ShortInsuranceViewModel> GetByIdAsync([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            var insuranceEntity = await _insuranceService.GetByIdAsync(id, cancellationToken);
            return _mapper.Map<ShortInsuranceViewModel>(insuranceEntity);
        }

        [HttpPost]
        public async Task<InsuranceViewModel> CreateAsync([FromBody] CreateInsuranceViewModel viewModel, CancellationToken cancellationToken)
        {
            await _createInsuranceViewModelValidator.ValidateAndThrowAsync(viewModel, cancellationToken);
            var insuranceEntity = _mapper.Map<InsuranceEntity>(viewModel);
            var result = await _insuranceService.AddAsync(insuranceEntity, cancellationToken);
            return _mapper.Map<InsuranceViewModel>(result);
        }

        [HttpPut("{id}")]
        public async Task<InsuranceViewModel> UpdateAsync([FromRoute] Guid id, [FromBody] UpdateInsuranceViewModel viewModel, CancellationToken cancellationToken)
        {
            await _updateInsuranceViewModelValidator.ValidateAndThrowAsync(viewModel, cancellationToken);
            var modelToUpdate = _mapper.Map<InsuranceEntity>(viewModel);
            var result = await _insuranceService.UpdateAsync(id, modelToUpdate, cancellationToken);
            return _mapper.Map<InsuranceViewModel>(result);
        }

        [HttpDelete("{id}")]
        public Task DeleteAsync([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            return _insuranceService.DeleteAsync(id, cancellationToken);
        }
    }
}
