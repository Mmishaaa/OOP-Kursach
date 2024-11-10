using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using ScooterBooking.Application.ViewModels.ScooterViewModel;
using ScooterBooking.Domain.Entities;
using ScooterBooking.Domain.Interfaces.Services;
using ScooterBooking.Domain.PaginationModels;
using ScooterBooking.Presentation.Constants;

namespace ScooterBooking.Presentation.Controllers
{
    [Controller]
    [Route($"{ControllerEndpoints.ScooterEndpoint}")]
    public class ScooterController : ControllerBase
    {
        private readonly IScooterService _scooterService;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateScooterViewModel> _createScooterViewModelValidator;
        private readonly IValidator<UpdateScooterViewModel> _updateScooterViewModelValidator;
        public ScooterController(
            IScooterService scooterService,
            IMapper mapper,
            IValidator<CreateScooterViewModel> createScooterViewModelValidator,
            IValidator<UpdateScooterViewModel> updateScooterViewModelValidator)
        {
            _scooterService = scooterService;
            _mapper = mapper;
            _createScooterViewModelValidator = createScooterViewModelValidator;
            _updateScooterViewModelValidator = updateScooterViewModelValidator;
        }

        [HttpGet]
        public async Task<PagedResult<ShortScooterViewModel>> GetAllAsync([FromQuery] int pageNumber, int pageSize, CancellationToken cancellationToken)
        {
            var pagedResult = await _scooterService.GetAllAsync(pageNumber, pageSize, cancellationToken);
            return _mapper.Map<PagedResult<ShortScooterViewModel>>(pagedResult);
        }

        [HttpGet("{id}")]
        public async Task<ShortScooterViewModel> GetByIdAsync([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            var scooterEntity = await _scooterService.GetByIdAsync(id, cancellationToken);
            return _mapper.Map<ShortScooterViewModel>(scooterEntity);
        }

        [HttpPost]
        public async Task<ScooterViewModel> CreateAsync([FromBody] CreateScooterViewModel viewModel, CancellationToken cancellationToken)
        {
            await _createScooterViewModelValidator.ValidateAndThrowAsync(viewModel, cancellationToken);
            var scooterEntity = _mapper.Map<ScooterEntity>(viewModel);
            var result = await _scooterService.AddAsync(scooterEntity, cancellationToken);
            return _mapper.Map<ScooterViewModel>(result);
        }

        [HttpPut("{id}")]
        public async Task<ScooterViewModel> UpdateAsync([FromRoute] Guid id, [FromBody] UpdateScooterViewModel viewModel, CancellationToken cancellationToken)
        {
            await _updateScooterViewModelValidator.ValidateAndThrowAsync(viewModel, cancellationToken);
            var modelToUpdate = _mapper.Map<ScooterEntity>(viewModel);
            var result = await _scooterService.UpdateAsync(id, modelToUpdate, cancellationToken);
            return _mapper.Map<ScooterViewModel>(result);
        }

        [HttpDelete("{id}")]
        public Task DeleteAsync([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            return _scooterService.DeleteAsync(id, cancellationToken);
        }
    }
}
