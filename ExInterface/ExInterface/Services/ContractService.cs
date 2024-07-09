using ExInterface.Entities;

namespace ExInterface.Services
{
    internal class ContractService
    {

        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            DateTime dataFatura;
            double valorParcelado = contract.TotalValue / months;
            double valorFatura;

            for (int i = 1; i <= months; i++)
            {
                dataFatura = contract.Date.AddMonths(i);
                valorFatura = valorParcelado + _onlinePaymentService.Interests(valorParcelado, i);
                valorFatura = valorFatura + _onlinePaymentService.PaymentFee(valorFatura);

                contract.AddInstallment(new Installment(dataFatura, valorFatura));
            }
        }
    }
}
