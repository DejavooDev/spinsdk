# IO.Swagger.Model.BasePaymentResponseContract
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PaymentType** | **string** | Indicates electronic data capture  [&#x27;Credit&#x27;, &#x27;Debit&#x27;, &#x27;EBT&#x27;, &#x27;Card&#x27;]. | [optional] 
**Amounts** | [**PaymentAmountsContract**](PaymentAmountsContract.md) |  | [optional] 
**AuthCode** | **string** | Authorization code provided by payment processor. | [optional] 
**ReferenceId** | **string** | Alphanumeric unique SPin transaction identifier. | [optional] 
**InvoiceNumber** | **string** | Unique invoice number. | [optional] 
**SerialNumber** | **string** | Device Serial Number. | [optional] 
**BatchNumber** | **string** | Current batch number. | [optional] 
**TransactionNumber** | **string** | Transaction number within batch. | [optional] 
**Voided** | **bool?** | Indicates whether transaction was voided or not. | [optional] 
**Signature** | **string** | Indicates customer signature if it was captured. | [optional] 
**CardData** | [**CardDataContract**](CardDataContract.md) |  | [optional] 
**Receipts** | [**ReceiptContract**](ReceiptContract.md) |  | [optional] 
**GeneralResponse** | [**GeneralResponseContract**](GeneralResponseContract.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

