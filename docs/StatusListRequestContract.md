# Dejavoo.Spin.Sdk.Client.Model.StatusListRequestContract
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PaymentType** | **string** |  | 
**TransactionFromIndex** | **int?** |  | 
**TransactionToIndex** | **int?** |  | 
**Tpn** | **string** | Terminal profile number.  Can be used to identify the terminal in SPIn Proxy environment. | 
**Authkey** | **string** | Merchant&#x27;s authorization password. Required if no SPInToken. | [optional] 
**SPInProxyTimeout** | **int?** | Timeout for processing transaction with SPIn proxy. If null, the default timeout will be used. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

