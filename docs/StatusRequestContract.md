# IO.Swagger.Model.StatusRequestContract
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PaymentType** | **string** | Indicates electronic data capture (EDC) type. | 
**ReferenceId** | **string** | Alphanumeric SPIn transaction identifier. Has to be unique within one batch. | 
**PrintReceipt** | **string** | Indicates if any of receipt copies should be printed after the transaction. | [optional] 
**GetReceipt** | **string** | Indicates if any of receipt copies should be returned in response. | [optional] 
**MerchantNumber** | **int?** | Merchant number for multi-merchant environment.   If not present in multi-merchant environment, transaction will be cancelled. | [optional] 
**CaptureSignature** | **bool?** | Indicates whether customer signature should be captured or not in course of transaction. | [optional] 
**Tpn** | **string** | Terminal profile number.  Can be used to identify the terminal in SPIn Proxy environment. | 
**Authkey** | **string** | Merchant&#x27;s authorization password. Required if no SPInToken. | [optional] 
**SPInProxyTimeout** | **int?** | Timeout for processing transaction with SPIn proxy. If null, the default timeout will be used. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

