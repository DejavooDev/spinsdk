using System.Drawing;
using System.Globalization;
using Dejavoo.Spin.Sdk;
using Dejavoo.Spin.Sdk.Methods;
using Dejavoo.Spin.Sdk.Methods.Models;
using Newtonsoft.Json;
using Typin;
using Typin.Attributes;
using Typin.Console;
using Typin.Exceptions;
using Typin.Modes;
using Console = Colorful.Console;

public static class Program
{
    private static readonly JsonSerializerSettings Options = new()
    {
        NullValueHandling = NullValueHandling.Include,
        DefaultValueHandling = DefaultValueHandling.Include,
        Formatting = Formatting.Indented,
        DateFormatHandling = DateFormatHandling.IsoDateFormat,
        DateTimeZoneHandling = DateTimeZoneHandling.Local,
        FloatFormatHandling = FloatFormatHandling.String,
        StringEscapeHandling = StringEscapeHandling.EscapeNonAscii,
        Culture = CultureInfo.CurrentCulture,
    };

    public static async Task<int> Main(string[] args) => await new CliApplicationBuilder()
        .AddCommandsFromThisAssembly()
        .UseInteractiveMode()
        .Build()
        .RunAsync(args);

    [Command("sale")]
    public sealed class SaleCommand : ICommand
    {
        [CommandParameter(0, Name = "tpn", Description = "Tpn.")]
        public string Tpn { get; set; }

        [CommandParameter(1, Name = "key", Description = "The authentication key.")]
        public string AuthKey { get; set; }

        [CommandParameter(2, Name = "amount", Description = "Amount to be charged for the operation.")]
        public double Amount { get; set; }

        [CommandParameter(3, Name = "type", Description = "Payment type to use for the operation.")]
        public PaymentType PaymentType { get; set; }

        public async ValueTask ExecuteAsync(IConsole console)
        {
            IOperationExecutor executor = Spin.V2Test.CreateExecutor(Tpn, AuthKey);

            IOperation<SaleResponse> sale = Operations.Sale(Amount, PaymentType);

            try
            {
                SaleResponse response = await sale.ExecuteAsync(executor);

                Console.WriteLine("SUCCESS", Color.Green);
                Console.WriteLine(JsonConvert.SerializeObject(response, Options));
            }
            catch (Exception e)
            {
                throw new CommandException(e.Message);
            }
        }
    }

    [Command("void")]
    public sealed class VoidCommand : ICommand
    {
        [CommandParameter(0, Name = "tpn", Description = "Tpn.")]
        public string Tpn { get; set; }

        [CommandParameter(1, Name = "key", Description = "The authentication key.")]
        public string AuthKey { get; set; }

        [CommandParameter(2, Name = "amount", Description = "Amount to be voided for the operation.")]
        public double Amount { get; set; }

        [CommandParameter(3, Name = "type", Description = "Payment type to use for the operation.")]
        public PaymentType PaymentType { get; set; }

        public async ValueTask ExecuteAsync(IConsole console)
        {
            IOperationExecutor executor = Spin.V2Test.CreateExecutor(Tpn, AuthKey);

            IOperation<VoidResponse> @void = Operations.Void(Amount, PaymentType);

            try
            {
                VoidResponse response = await @void.ExecuteAsync(executor);

                Console.WriteLine("SUCCESS", Color.Green);
                Console.WriteLine(JsonConvert.SerializeObject(response, Options));
            }
            catch (Exception e)
            {
                throw new CommandException(e.Message);
            }
        }
    }

    [Command("return")]
    public sealed class ReturnCommand : ICommand
    {
        [CommandParameter(0, Name = "tpn", Description = "Tpn.")]
        public string Tpn { get; set; }

        [CommandParameter(1, Name = "key", Description = "The authentication key.")]
        public string AuthKey { get; set; }

        [CommandParameter(2, Name = "amount", Description = "Amount to be returned for the operation.")]
        public double Amount { get; set; }

        [CommandParameter(3, Name = "type", Description = "Payment type to use for the operation.")]
        public PaymentType PaymentType { get; set; }

        public async ValueTask ExecuteAsync(IConsole console)
        {
            IOperationExecutor executor = Spin.V2Test.CreateExecutor(Tpn, AuthKey);

            IOperation<ReturnResponse> @return = Operations.Return(Amount, PaymentType);

            try
            {
                ReturnResponse response = await @return.ExecuteAsync(executor);

                Console.WriteLine("SUCCESS", Color.Green);
                Console.WriteLine(JsonConvert.SerializeObject(response, Options));
            }
            catch (Exception e)
            {
                throw new CommandException(e.Message);
            }
        }
    }

    [Command("tip-adjust")]
    public sealed class TipAdjustCommand : ICommand
    {
        [CommandParameter(0, Name = "tpn", Description = "Tpn.")]
        public string Tpn { get; set; }

        [CommandParameter(1, Name = "key", Description = "The authentication key.")]
        public string AuthKey { get; set; }

        [CommandParameter(2, Name = "amount", Description = "Total Amount for the operation.")]
        public double Amount { get; set; }

        [CommandParameter(3, Name = "last4", Description = "Last 4 digits on the card.")]
        public string Last4 { get; set; }

        [CommandParameter(4, Name = "type", Description = "Payment type to use for the operation.")]
        public PaymentType PaymentType { get; set; }

        public async ValueTask ExecuteAsync(IConsole console)
        {
            IOperationExecutor executor = Spin.V2Test.CreateExecutor(Tpn, AuthKey);

            IOperation<TipAdjustResponse> tipAdjust = Operations.TipAdjust(Amount, Last4, PaymentType);

            try
            {
                TipAdjustResponse response = await tipAdjust.ExecuteAsync(executor);

                Console.WriteLine("SUCCESS", Color.Green);
                Console.WriteLine(JsonConvert.SerializeObject(response, Options));
            }
            catch (Exception e)
            {
                throw new CommandException(e.Message);
            }
        }
    }

    [Command("settle")]
    public sealed class SettleCommand : ICommand
    {
        [CommandParameter(0, Name = "tpn", Description = "Tpn.")]
        public string Tpn { get; set; }

        [CommandParameter(1, Name = "key", Description = "The authentication key.")]
        public string AuthKey { get; set; }

        public async ValueTask ExecuteAsync(IConsole console)
        {
            IOperationExecutor executor = Spin.V2Test.CreateExecutor(Tpn, AuthKey);

            IOperation<SettleResponse> settle = Operations.Settle();

            try
            {
                SettleResponse response = await settle.ExecuteAsync(executor);

                Console.WriteLine("SUCCESS", Color.Green);
                Console.WriteLine(JsonConvert.SerializeObject(response, Options));
            }
            catch (Exception e)
            {
                throw new CommandException(e.Message);
            }
        }
    }

    [Command("status")]
    public sealed class StatusCommand : ICommand
    {
        [CommandParameter(0, Name = "tpn", Description = "Tpn.")]
        public string Tpn { get; set; }

        [CommandParameter(1, Name = "key", Description = "The authentication key.")]
        public string AuthKey { get; set; }

        [CommandParameter(2, Name = "ref", Description = "Transaction reference to acquire status from.")]
        public string ReferenceId { get; set; }

        [CommandParameter(3, Name = "type", Description = "Payment type of the transaction to acquire status from.")]
        public PaymentType PaymentType { get; set; }

        public async ValueTask ExecuteAsync(IConsole console)
        {
            IOperationExecutor executor = Spin.V2Test.CreateExecutor(Tpn, AuthKey);

            IOperation<StatusResponse> status = Operations.Status(ReferenceId, PaymentType);

            try
            {
                StatusResponse response = await status.ExecuteAsync(executor);

                Console.WriteLine("SUCCESS", Color.Green);
                Console.WriteLine(JsonConvert.SerializeObject(response, Options));
            }
            catch (Exception e)
            {
                throw new CommandException(e.Message);
            }
        }
    }
}
