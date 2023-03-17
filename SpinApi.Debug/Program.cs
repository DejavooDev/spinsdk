using Dejavoo.Spin.Sdk.Client.Api;
using Dejavoo.Spin.Sdk.Client.Client;
using Dejavoo.Spin.Sdk.Client.Model;

var api = new RegisterApi(new Configuration { BasePath = "https://test.spinpos.net/spin" });

var saleRequestContract = new SaleRequestContract(
    10f,
    paymentType: SaleRequestContract.PaymentTypeEnum.Card,
    referenceId: Guid.NewGuid().ToString("N"),
    tpn: "z11invtest01",
    authkey: "zbhRAW9N6x");

var response = await api.RegisterSaleAsync(saleRequestContract);

Console.WriteLine(response);