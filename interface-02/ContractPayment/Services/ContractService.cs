using ContractPayment.Entities;
using System;
using System.Linq;

namespace ContractPayment.Services
{
    internal class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService paymentService)
        {
            _onlinePaymentService = paymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;

            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                //Valor com juros
                double quotaWithInterest = basicQuota + _onlinePaymentService.Interest(basicQuota, i);
                //Valor com taxa de pagamento
                double fullQuota = quotaWithInterest + _onlinePaymentService.PaymentFee(quotaWithInterest);
                //Adiciona parcela ao contrato
                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }
    }
}
