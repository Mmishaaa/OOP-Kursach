﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ScooterBooking.Application.ViewModels.LocationViewModel;
using ScooterBooking.Domain.Entities;
using ScooterBooking.Domain.Interfaces.Services;
using ScooterBooking.Domain.PaginationModels;
using ScooterBooking.Presentation.Constants;

namespace ScooterBooking.Presentation.Controllers
{

    [Controller]
    [Route($"{ControllerEndpoints.LocationEndpoint}")]
    public class LocationController : ControllerBase
    {
        private readonly ILocationService _locationService;
        private readonly IMapper _mapper;
        public LocationController(ILocationService locationService, IMapper mapper)
        {
            _locationService = locationService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<PagedResult<ShortLocationViewModel>> GetAllAsync(int pageNumber, int pageSize, CancellationToken cancellationToken)
        {
            var pagedResult = await _locationService.GetAllAsync(pageNumber, pageSize, cancellationToken);
            return _mapper.Map<PagedResult<ShortLocationViewModel>>(pagedResult);
        }

        [HttpGet("{id}")]
        public async Task<ShortLocationViewModel> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var locationEntity = await _locationService.GetByIdAsync(id, cancellationToken);
            return _mapper.Map<ShortLocationViewModel>(locationEntity);
        }

        [HttpPost]
        public async Task<LocationViewModel> CreateAsync(CreateLocationViewModel viewModel, CancellationToken cancellationToken)
        {
            //await _createAssistanceViewModelValidator.ValidateAndThrowAsync(viewModel, cancellationToken);
            var locationEntity = _mapper.Map<LocationEntity>(viewModel);
            var result = await _locationService.AddAsync(locationEntity, cancellationToken);
            return _mapper.Map<LocationViewModel>(result);
        }

        [HttpPut("{id}")]
        public async Task<LocationViewModel> Update(Guid id, UpdateLocationViewModel viewModel, CancellationToken cancellationToken)
        {
            //await _updateAssistanceViewModelValidator.ValidateAndThrowAsync(viewModel, cancellationToken);
            var modelToUpdate = _mapper.Map<LocationEntity>(viewModel);
            var result = await _locationService.UpdateAsync(id, modelToUpdate, cancellationToken);
            return _mapper.Map<LocationViewModel>(result);
        }

        [HttpDelete("{id}")]
        public Task DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            return _locationService.DeleteAsync(id, cancellationToken);
        }
    }
}