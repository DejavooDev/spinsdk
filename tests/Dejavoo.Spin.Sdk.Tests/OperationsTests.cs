using System;
using System.Threading.Tasks;
using Dejavoo.Spin.Sdk.Methods;
using Dejavoo.Spin.Sdk.Methods.Models;
using FluentAssertions;
using NUnit.Framework;

namespace Dejavoo.Spin.Sdk.UnitTests
{
    [Parallelizable(ParallelScope.None)]
    public sealed class OperationsTests
    {
        [TestCase(10.01, PaymentType.Debit)]
        [TestCase(10.02, PaymentType.Debit)]
        [TestCase(10.03, PaymentType.Debit)]
        [TestCase(10.04, PaymentType.Debit)]
        [TestCase(10.05, PaymentType.Debit)]
        [TestCase(10.06, PaymentType.Debit)]
        [TestCase(10.07, PaymentType.Debit)]
        [TestCase(10.08, PaymentType.Debit)]
        [TestCase(10.09, PaymentType.Debit)]
        [TestCase(10.10, PaymentType.Debit)]
        [TestCase(10.11, PaymentType.Debit)]
        [TestCase(10.12, PaymentType.Debit)]
        [TestCase(10.13, PaymentType.Debit)]
        [TestCase(10.14, PaymentType.Debit)]
        [TestCase(10.15, PaymentType.Debit)]
        [TestCase(10.16, PaymentType.Debit)]
        [TestCase(10.17, PaymentType.Debit)]
        [TestCase(10.19, PaymentType.Debit)]
        [TestCase(10.20, PaymentType.Debit)]
        [TestCase(10.21, PaymentType.Debit)]
        [TestCase(10.22, PaymentType.Debit)]
        [TestCase(10.23, PaymentType.Debit)]
        [TestCase(10.24, PaymentType.Debit)]
        [TestCase(20.01, PaymentType.Debit)]
        [TestCase(20.02, PaymentType.Debit)]
        [TestCase(20.03, PaymentType.Debit)]
        [TestCase(20.04, PaymentType.Debit)]
        [TestCase(20.05, PaymentType.Debit)]
        [TestCase(20.06, PaymentType.Debit)]
        [TestCase(20.07, PaymentType.Debit)]
        [TestCase(20.08, PaymentType.Debit)]
        [TestCase(20.09, PaymentType.Debit)]
        [TestCase(20.10, PaymentType.Debit)]
        public async Task PlainSale_ShouldFail(double value, PaymentType paymentType)
        {
            // Arrange
            IOperationExecutor executor = CreateTarget();

            IOperation<SaleResponse> operation = Operations.Sale(value, paymentType);

            // Act
            Func<Task> act = () => operation.ExecuteAsync(executor);
            
            // Assert
            await act.Should().ThrowExactlyAsync<ExecutorException>();
        }

        [TestCase(10.01, PaymentType.Debit)]
        [TestCase(10.02, PaymentType.Debit)]
        [TestCase(10.03, PaymentType.Debit)]
        [TestCase(10.04, PaymentType.Debit)]
        [TestCase(10.05, PaymentType.Debit)]
        [TestCase(10.06, PaymentType.Debit)]
        [TestCase(10.07, PaymentType.Debit)]
        [TestCase(10.08, PaymentType.Debit)]
        [TestCase(10.09, PaymentType.Debit)]
        [TestCase(10.10, PaymentType.Debit)]
        [TestCase(10.11, PaymentType.Debit)]
        [TestCase(10.12, PaymentType.Debit)]
        [TestCase(10.13, PaymentType.Debit)]
        [TestCase(10.14, PaymentType.Debit)]
        [TestCase(10.15, PaymentType.Debit)]
        [TestCase(10.16, PaymentType.Debit)]
        [TestCase(10.17, PaymentType.Debit)]
        [TestCase(10.19, PaymentType.Debit)]
        [TestCase(10.20, PaymentType.Debit)]
        [TestCase(10.21, PaymentType.Debit)]
        [TestCase(10.22, PaymentType.Debit)]
        [TestCase(10.23, PaymentType.Debit)]
        [TestCase(10.24, PaymentType.Debit)]
        [TestCase(20.01, PaymentType.Debit)]
        [TestCase(20.02, PaymentType.Debit)]
        [TestCase(20.03, PaymentType.Debit)]
        [TestCase(20.04, PaymentType.Debit)]
        [TestCase(20.05, PaymentType.Debit)]
        [TestCase(20.06, PaymentType.Debit)]
        [TestCase(20.07, PaymentType.Debit)]
        [TestCase(20.08, PaymentType.Debit)]
        [TestCase(20.09, PaymentType.Debit)]
        [TestCase(20.10, PaymentType.Debit)]
        public async Task PlainVoid_ShouldFail(double value, PaymentType paymentType)
        {
            IOperationExecutor executor = CreateTarget();

            IOperation<VoidResponse> operation = Operations.Void(value, paymentType);

            // Act
            Func<Task> act = () => operation.ExecuteAsync(executor);
            
            // Assert
            await act.Should().ThrowExactlyAsync<ExecutorException>();
        }
        
        [TestCase(10.01, PaymentType.Debit)]
        [TestCase(10.02, PaymentType.Debit)]
        [TestCase(10.03, PaymentType.Debit)]
        [TestCase(10.04, PaymentType.Debit)]
        [TestCase(10.05, PaymentType.Debit)]
        [TestCase(10.06, PaymentType.Debit)]
        [TestCase(10.07, PaymentType.Debit)]
        [TestCase(10.08, PaymentType.Debit)]
        [TestCase(10.09, PaymentType.Debit)]
        [TestCase(10.10, PaymentType.Debit)]
        [TestCase(10.11, PaymentType.Debit)]
        [TestCase(10.12, PaymentType.Debit)]
        [TestCase(10.13, PaymentType.Debit)]
        [TestCase(10.14, PaymentType.Debit)]
        [TestCase(10.15, PaymentType.Debit)]
        [TestCase(10.16, PaymentType.Debit)]
        [TestCase(10.17, PaymentType.Debit)]
        [TestCase(10.19, PaymentType.Debit)]
        [TestCase(10.20, PaymentType.Debit)]
        [TestCase(10.21, PaymentType.Debit)]
        [TestCase(10.22, PaymentType.Debit)]
        [TestCase(10.23, PaymentType.Debit)]
        [TestCase(10.24, PaymentType.Debit)]
        [TestCase(20.01, PaymentType.Debit)]
        [TestCase(20.02, PaymentType.Debit)]
        [TestCase(20.03, PaymentType.Debit)]
        [TestCase(20.04, PaymentType.Debit)]
        [TestCase(20.05, PaymentType.Debit)]
        [TestCase(20.06, PaymentType.Debit)]
        [TestCase(20.07, PaymentType.Debit)]
        [TestCase(20.08, PaymentType.Debit)]
        [TestCase(20.09, PaymentType.Debit)]
        [TestCase(20.10, PaymentType.Debit)]
        public async Task PlainTipAdjust_ShouldFail(double value, PaymentType paymentType)
        {
            IOperationExecutor executor = CreateTarget();

            IOperation<TipAdjustResponse> operation = Operations.TipAdjust(value, "8236", paymentType);

            // Act
            Func<Task> act = () => operation.ExecuteAsync(executor);
            
            // Assert
            await act.Should().ThrowExactlyAsync<ExecutorException>();
        }
        
        [TestCase(10.01, PaymentType.Debit)]
        [TestCase(10.02, PaymentType.Debit)]
        [TestCase(10.03, PaymentType.Debit)]
        [TestCase(10.04, PaymentType.Debit)]
        [TestCase(10.05, PaymentType.Debit)]
        [TestCase(10.06, PaymentType.Debit)]
        [TestCase(10.07, PaymentType.Debit)]
        [TestCase(10.08, PaymentType.Debit)]
        [TestCase(10.09, PaymentType.Debit)]
        [TestCase(10.10, PaymentType.Debit)]
        [TestCase(10.11, PaymentType.Debit)]
        [TestCase(10.12, PaymentType.Debit)]
        [TestCase(10.13, PaymentType.Debit)]
        [TestCase(10.14, PaymentType.Debit)]
        [TestCase(10.15, PaymentType.Debit)]
        [TestCase(10.16, PaymentType.Debit)]
        [TestCase(10.17, PaymentType.Debit)]
        [TestCase(10.19, PaymentType.Debit)]
        [TestCase(10.20, PaymentType.Debit)]
        [TestCase(10.21, PaymentType.Debit)]
        [TestCase(10.22, PaymentType.Debit)]
        [TestCase(10.23, PaymentType.Debit)]
        [TestCase(10.24, PaymentType.Debit)]
        [TestCase(20.01, PaymentType.Debit)]
        [TestCase(20.02, PaymentType.Debit)]
        [TestCase(20.03, PaymentType.Debit)]
        [TestCase(20.04, PaymentType.Debit)]
        [TestCase(20.05, PaymentType.Debit)]
        [TestCase(20.06, PaymentType.Debit)]
        [TestCase(20.07, PaymentType.Debit)]
        [TestCase(20.08, PaymentType.Debit)]
        [TestCase(20.09, PaymentType.Debit)]
        [TestCase(20.10, PaymentType.Debit)]
        public async Task PlainReturn_ShouldFail(double value, PaymentType paymentType)
        {
            IOperationExecutor executor = CreateTarget();

            IOperation<ReturnResponse> operation = Operations.Return(value, paymentType);

            // Act
            Func<Task> act = () => operation.ExecuteAsync(executor);
            
            // Assert
            await act.Should().ThrowExactlyAsync<ExecutorException>();
        }

        private static IOperationExecutor CreateTarget() =>
            Spin.V2Test.CreateExecutor("0922161235", "fVScy1RJkF");
    }
}