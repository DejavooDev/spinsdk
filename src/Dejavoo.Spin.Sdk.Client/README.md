# Dejavoo.Spin.Sdk.Client - the C# library for the SPIn API

- API version: v2
- Client version: 1.0.0

<a name="frameworks-supported"></a>
## Frameworks supported
- netstandard2.1 and later

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 108.0.3 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.2 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

<a name="installation"></a>
## Installation
Run the following command to generate the DLL

```
dotnet add package Dejavoo.Spin.Sdk.Client
```

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Dejavoo.Spin.Sdk.Client.Api;
using Dejavoo.Spin.Sdk.Client.Client;
using Dejavoo.Spin.Sdk.Client.Model;
```

<a name="getting-started"></a>
## Getting Started

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://spinpos.net/spin*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*RegisterApi* | [**RegisterPrinter**](docs/RegisterApi.md#registerprinter) | **POST** /v2/Common/Printer |
*RegisterApi* | [**RegisterReturn**](docs/RegisterApi.md#registerreturn) | **POST** /v2/Payment/Return |
*RegisterApi* | [**RegisterSale**](docs/RegisterApi.md#registersale) | **POST** /v2/Payment/Sale |
*RegisterApi* | [**RegisterSettle**](docs/RegisterApi.md#registersettle) | **POST** /v2/Payment/Settle |
*RegisterApi* | [**RegisterStatus**](docs/RegisterApi.md#registerstatus) | **POST** /v2/Payment/Status |
*RegisterApi* | [**RegisterStatusList**](docs/RegisterApi.md#registerstatuslist) | **POST** /v2/Payment/StatusList |
*RegisterApi* | [**RegisterTipAdjust**](docs/RegisterApi.md#registertipadjust) | **POST** /v2/Payment/TipAdjust |
*RegisterApi* | [**RegisterUserChoice**](docs/RegisterApi.md#registeruserchoice) | **POST** /v2/Common/UserChoice |
*RegisterApi* | [**RegisterUserInput**](docs/RegisterApi.md#registeruserinput) | **POST** /v2/Common/UserInput |
*RegisterApi* | [**RegisterVoid**](docs/RegisterApi.md#registervoid) | **POST** /v2/Payment/Void |

<a name="documentation-for-models"></a>
## Documentation for Models

- [Model.BasePaymentResponseContract](../../docs/BasePaymentResponseContract.md)
- [Model.CardDataContract](../../docs/CardDataContract.md)
- [Model.GeneralResponseContract](../../docs/GeneralResponseContract.md)
- [Model.PaymentAmountsContract](../../docs/PaymentAmountsContract.md)
- [Model.PrinterRequestContract](../../docs/PrinterRequestContract.md)
- [Model.PrinterResponseContract](../../docs/PrinterResponseContract.md)
- [Model.ReceiptContract](../../docs/ReceiptContract.md)
- [Model.ReturnRequestContract](../../docs/ReturnRequestContract.md)
- [Model.SaleRequestContract](../../docs/SaleRequestContract.md)
- [Model.SettleDetailsContract](../../docs/SettleDetailsContract.md)
- [Model.SettleRequestContract](../../docs/SettleRequestContract.md)
- [Model.SettleResponseContract](../../docs/SettleResponseContract.md)
- [Model.SettleTransactionReportContract](../../docs/SettleTransactionReportContract.md)
- [Model.StatusListRequestContract](../../docs/StatusListRequestContract.md)
- [Model.StatusListResponseContract](../../docs/StatusListResponseContract.md)
- [Model.StatusRequestContract](../../docs/StatusRequestContract.md)
- [Model.TipAdjustRequestContract](../../docs/TipAdjustRequestContract.md)
- [Model.UserChoiceRequestContract](../../docs/UserChoiceRequestContract.md)
- [Model.UserChoiceResponseContract](../../docs/UserChoiceResponseContract.md)
- [Model.UserInputRequestContract](../../docs/UserInputRequestContract.md)
- [Model.UserInputResponseContract](../../docs/UserInputResponseContract.md)
- [Model.VoidRequestContract](../../docs/VoidRequestContract.md)
