using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ScooterBooking.Application.ViewModels.UserViewModel;
using ScooterBooking.Domain.Entities;
using ScooterBooking.Domain.Interfaces.Services;
using ScooterBooking.Domain.PaginationModels;
using ScooterBooking.Presentation.Constants;

namespace UserBooking.Presentation.Controllers
{
    [Controller]
    [Route($"{ControllerEndpoints.UserEndpoint}")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<PagedResult<ShortUserViewModel>> GetAllAsync(int pageNumber, int pageSize, CancellationToken cancellationToken)
        {
            var pagedResult = await _userService.GetAllAsync(pageNumber, pageSize, cancellationToken);
            return _mapper.Map<PagedResult<ShortUserViewModel>>(pagedResult);
        }

        [HttpGet("{id}")]
        public async Task<ShortUserViewModel> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var UserEntity = await _userService.GetByIdAsync(id, cancellationToken);
            return _mapper.Map<ShortUserViewModel>(UserEntity);
        }

        [HttpPost]
        public async Task<UserViewModel> CreateAsync(CreateUserViewModel viewModel, CancellationToken cancellationToken)
        {
            //await _createAssistanceViewModelValidator.ValidateAndThrowAsync(viewModel, cancellationToken);
            var UserEntity = _mapper.Map<UserEntity>(viewModel);
            var result = await _userService.AddAsync(UserEntity, cancellationToken);
            return _mapper.Map<UserViewModel>(result);
        }

        [HttpPut("{id}")]
        public async Task<UserViewModel> Update(Guid id, UpdateUserViewModel viewModel, CancellationToken cancellationToken)
        {
            //await _updateAssistanceViewModelValidator.ValidateAndThrowAsync(viewModel, cancellationToken);
            var modelToUpdate = _mapper.Map<UserEntity>(viewModel);
            var result = await _userService.UpdateAsync(id, modelToUpdate, cancellationToken);
            return _mapper.Map<UserViewModel>(result);
        }

        [HttpDelete("{id}")]
        public void DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            _userService.DeleteAsync(id, cancellationToken);
        }
    }
}
