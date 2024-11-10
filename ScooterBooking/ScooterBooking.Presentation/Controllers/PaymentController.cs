using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ScooterBooking.Application.ViewModels.PaymentViewModel;
using ScooterBooking.Domain.Entities;
using ScooterBooking.Domain.Interfaces.Services;
using ScooterBooking.Domain.PaginationModels;
using ScooterBooking.Presentation.Constants;

namespace ScooterBooking.Presentation.Controllers
{
    [Controller]
    [Route($"{ControllerEndpoints.PaymentEndpoint}")]
    public class PaymentController
    {
        private readonly IPaymentService _paymentService;
        private readonly IMapper _mapper;
        public PaymentController(IPaymentService paymentService, IMapper mapper)
        {
            _paymentService = paymentService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<PagedResult<ShortPaymentViewModel>> GetAllAsync([FromQuery] int pageNumber, int pageSize, CancellationToken cancellationToken)
        {
            var pagedResult = await _paymentService.GetAllAsync(pageNumber, pageSize, cancellationToken);
            return _mapper.Map<PagedResult<ShortPaymentViewModel>>(pagedResult);
        }

        [HttpGet("{id}")]
        public async Task<ShortPaymentViewModel> GetByIdAsync([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            var paymentEntity = await _paymentService.GetByIdAsync(id, cancellationToken);
            return _mapper.Map<ShortPaymentViewModel>(paymentEntity);
        }

        [HttpPost]
        public async Task<PaymentViewModel> CreateAsync([FromBody] CreatePaymentViewModel viewModel, CancellationToken cancellationToken)
        {
            //await _createAssistanceViewModelValidator.ValidateAndThrowAsync(viewModel, cancellationToken);
            var paymentEntity = _mapper.Map<PaymentEntity>(viewModel);
            var result = await _paymentService.AddAsync(paymentEntity, cancellationToken);
            return _mapper.Map<PaymentViewModel>(result);
        }

        [HttpPut("{id}")]
        public async Task<PaymentViewModel> Update([FromRoute] Guid id, [FromBody] UpdatePaymentViewModel viewModel, CancellationToken cancellationToken)
        {
            //await _updateAssistanceViewModelValidator.ValidateAndThrowAsync(viewModel, cancellationToken);
            var modelToUpdate = _mapper.Map<PaymentEntity>(viewModel);
            var result = await _paymentService.UpdateAsync(id, modelToUpdate, cancellationToken);
            return _mapper.Map<PaymentViewModel>(result);
        }

        [HttpDelete("{id}")]
        public Task DeleteAsync([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            return _paymentService.DeleteAsync(id, cancellationToken);
        }
    }
}
