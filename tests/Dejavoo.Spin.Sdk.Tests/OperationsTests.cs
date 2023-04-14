using System;
using System.Threading.Tasks;
using Dejavoo.Spin.Sdk.Methods;
using Dejavoo.Spin.Sdk.Methods.Models;
using FluentAssertions;
using NUnit.Framework;

namespace Dejavoo.Spin.Sdk.UnitTests
{
    [Parallelizable(ParallelScope.All)]
    public sealed class OperationsTests
    {
        [TestCase(10.00f, PaymentType.Debit)]
        [TestCase(10.01f, PaymentType.Debit)]
        [TestCase(10.02f, PaymentType.Debit)]
        [TestCase(10.03f, PaymentType.Debit)]
        [TestCase(10.04f, PaymentType.Debit)]
        [TestCase(10.05f, PaymentType.Debit)]
        [TestCase(10.06f, PaymentType.Debit)]
        [TestCase(10.07f, PaymentType.Debit)]
        [TestCase(10.08f, PaymentType.Debit)]
        [TestCase(10.09f, PaymentType.Debit)]
        [TestCase(10.10f, PaymentType.Debit)]
        [TestCase(10.11f, PaymentType.Debit)]
        [TestCase(10.12f, PaymentType.Debit)]
        [TestCase(10.13f, PaymentType.Debit)]
        [TestCase(10.14f, PaymentType.Debit)]
        [TestCase(10.15f, PaymentType.Debit)]
        [TestCase(10.16f, PaymentType.Debit)]
        [TestCase(10.17f, PaymentType.Debit)]
        [TestCase(10.18f, PaymentType.Debit)]
        [TestCase(10.19f, PaymentType.Debit)]
        [TestCase(10.20f, PaymentType.Debit)]
        [TestCase(10.21f, PaymentType.Debit)]
        [TestCase(10.22f, PaymentType.Debit)]
        [TestCase(10.23f, PaymentType.Debit)]
        [TestCase(10.24f, PaymentType.Debit)]
        [TestCase(10.25f, PaymentType.Debit)]
        [TestCase(20.01f, PaymentType.Debit)]
        [TestCase(20.02f, PaymentType.Debit)]
        [TestCase(20.03f, PaymentType.Debit)]
        [TestCase(20.04f, PaymentType.Debit)]
        [TestCase(20.05f, PaymentType.Debit)]
        [TestCase(20.06f, PaymentType.Debit)]
        [TestCase(20.07f, PaymentType.Debit)]
        [TestCase(20.08f, PaymentType.Debit)]
        [TestCase(20.09f, PaymentType.Debit)]
        [TestCase(20.10f, PaymentType.Debit)]
        [TestCase(22.01f, PaymentType.Debit)]
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

        [TestCase(10.00f, PaymentType.Debit)]
        [TestCase(10.01f, PaymentType.Debit)]
        [TestCase(10.02f, PaymentType.Debit)]
        [TestCase(10.03f, PaymentType.Debit)]
        [TestCase(10.04f, PaymentType.Debit)]
        [TestCase(10.05f, PaymentType.Debit)]
        [TestCase(10.06f, PaymentType.Debit)]
        [TestCase(10.07f, PaymentType.Debit)]
        [TestCase(10.08f, PaymentType.Debit)]
        [TestCase(10.09f, PaymentType.Debit)]
        [TestCase(10.10f, PaymentType.Debit)]
        [TestCase(10.11f, PaymentType.Debit)]
        [TestCase(10.12f, PaymentType.Debit)]
        [TestCase(10.13f, PaymentType.Debit)]
        [TestCase(10.14f, PaymentType.Debit)]
        [TestCase(10.15f, PaymentType.Debit)]
        [TestCase(10.16f, PaymentType.Debit)]
        [TestCase(10.17f, PaymentType.Debit)]
        [TestCase(10.18f, PaymentType.Debit)]
        [TestCase(10.19f, PaymentType.Debit)]
        [TestCase(10.20f, PaymentType.Debit)]
        [TestCase(10.21f, PaymentType.Debit)]
        [TestCase(10.22f, PaymentType.Debit)]
        [TestCase(10.23f, PaymentType.Debit)]
        [TestCase(10.24f, PaymentType.Debit)]
        [TestCase(10.25f, PaymentType.Debit)]
        [TestCase(20.01f, PaymentType.Debit)]
        [TestCase(20.02f, PaymentType.Debit)]
        [TestCase(20.03f, PaymentType.Debit)]
        [TestCase(20.04f, PaymentType.Debit)]
        [TestCase(20.05f, PaymentType.Debit)]
        [TestCase(20.06f, PaymentType.Debit)]
        [TestCase(20.07f, PaymentType.Debit)]
        [TestCase(20.08f, PaymentType.Debit)]
        [TestCase(20.09f, PaymentType.Debit)]
        [TestCase(20.10f, PaymentType.Debit)]
        [TestCase(22.01f, PaymentType.Debit)]
        public async Task PlainVoid_ShouldFail(double value, PaymentType paymentType)
        {
            IOperationExecutor executor = CreateTarget();

            IOperation<VoidResponse> operation = Operations.Void(value, paymentType);

            // Act
            Func<Task> act = () => operation.ExecuteAsync(executor);
            
            // Assert
            await act.Should().ThrowExactlyAsync<ExecutorException>();
        }
        
        [TestCase(10.00f, PaymentType.Debit)]
        [TestCase(10.01f, PaymentType.Debit)]
        [TestCase(10.02f, PaymentType.Debit)]
        [TestCase(10.03f, PaymentType.Debit)]
        [TestCase(10.04f, PaymentType.Debit)]
        [TestCase(10.05f, PaymentType.Debit)]
        [TestCase(10.06f, PaymentType.Debit)]
        [TestCase(10.07f, PaymentType.Debit)]
        [TestCase(10.08f, PaymentType.Debit)]
        [TestCase(10.09f, PaymentType.Debit)]
        [TestCase(10.10f, PaymentType.Debit)]
        [TestCase(10.11f, PaymentType.Debit)]
        [TestCase(10.12f, PaymentType.Debit)]
        [TestCase(10.13f, PaymentType.Debit)]
        [TestCase(10.14f, PaymentType.Debit)]
        [TestCase(10.15f, PaymentType.Debit)]
        [TestCase(10.16f, PaymentType.Debit)]
        [TestCase(10.17f, PaymentType.Debit)]
        [TestCase(10.18f, PaymentType.Debit)]
        [TestCase(10.19f, PaymentType.Debit)]
        [TestCase(10.20f, PaymentType.Debit)]
        [TestCase(10.21f, PaymentType.Debit)]
        [TestCase(10.22f, PaymentType.Debit)]
        [TestCase(10.23f, PaymentType.Debit)]
        [TestCase(10.24f, PaymentType.Debit)]
        [TestCase(10.25f, PaymentType.Debit)]
        [TestCase(20.01f, PaymentType.Debit)]
        [TestCase(20.02f, PaymentType.Debit)]
        [TestCase(20.03f, PaymentType.Debit)]
        [TestCase(20.04f, PaymentType.Debit)]
        [TestCase(20.05f, PaymentType.Debit)]
        [TestCase(20.06f, PaymentType.Debit)]
        [TestCase(20.07f, PaymentType.Debit)]
        [TestCase(20.08f, PaymentType.Debit)]
        [TestCase(20.09f, PaymentType.Debit)]
        [TestCase(20.10f, PaymentType.Debit)]
        [TestCase(22.01f, PaymentType.Debit)]
        public async Task PlainTipAdjust_ShouldFail(double value, PaymentType paymentType)
        {
            IOperationExecutor executor = CreateTarget();

            IOperation<TipAdjustResponse> operation = Operations.TipAdjust(value, "8236", paymentType);

            // Act
            Func<Task> act = () => operation.ExecuteAsync(executor);
            
            // Assert
            await act.Should().ThrowExactlyAsync<ExecutorException>();
        }
        
        [TestCase(10.00f, PaymentType.Debit)]
        [TestCase(10.01f, PaymentType.Debit)]
        [TestCase(10.02f, PaymentType.Debit)]
        [TestCase(10.03f, PaymentType.Debit)]
        [TestCase(10.04f, PaymentType.Debit)]
        [TestCase(10.05f, PaymentType.Debit)]
        [TestCase(10.06f, PaymentType.Debit)]
        [TestCase(10.07f, PaymentType.Debit)]
        [TestCase(10.08f, PaymentType.Debit)]
        [TestCase(10.09f, PaymentType.Debit)]
        [TestCase(10.10f, PaymentType.Debit)]
        [TestCase(10.11f, PaymentType.Debit)]
        [TestCase(10.12f, PaymentType.Debit)]
        [TestCase(10.13f, PaymentType.Debit)]
        [TestCase(10.14f, PaymentType.Debit)]
        [TestCase(10.15f, PaymentType.Debit)]
        [TestCase(10.16f, PaymentType.Debit)]
        [TestCase(10.17f, PaymentType.Debit)]
        [TestCase(10.18f, PaymentType.Debit)]
        [TestCase(10.19f, PaymentType.Debit)]
        [TestCase(10.20f, PaymentType.Debit)]
        [TestCase(10.21f, PaymentType.Debit)]
        [TestCase(10.22f, PaymentType.Debit)]
        [TestCase(10.23f, PaymentType.Debit)]
        [TestCase(10.24f, PaymentType.Debit)]
        [TestCase(10.25f, PaymentType.Debit)]
        [TestCase(20.01f, PaymentType.Debit)]
        [TestCase(20.02f, PaymentType.Debit)]
        [TestCase(20.03f, PaymentType.Debit)]
        [TestCase(20.04f, PaymentType.Debit)]
        [TestCase(20.05f, PaymentType.Debit)]
        [TestCase(20.06f, PaymentType.Debit)]
        [TestCase(20.07f, PaymentType.Debit)]
        [TestCase(20.08f, PaymentType.Debit)]
        [TestCase(20.09f, PaymentType.Debit)]
        [TestCase(20.10f, PaymentType.Debit)]
        [TestCase(22.01f, PaymentType.Debit)]
        public async Task PlainReturn_ShouldFail(double value, PaymentType paymentType)
        {
            IOperationExecutor executor = CreateTarget();

            IOperation<ReturnResponse> operation = Operations.Return(value, paymentType);

            // Act
            Func<Task> act = () => operation.ExecuteAsync(executor);
            
            // Assert
            await act.Should().ThrowExactlyAsync<ExecutorException>();
        }

        private IOperationExecutor CreateTarget() => Spin.V2Test.CreateExecutor("0922161235", "fVScy1RJkF");
    }
}