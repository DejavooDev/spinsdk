# IO.Swagger.Api.RegisterApi

All URIs are relative to *https://test.spinpos.net/spin*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RegisterPrinter**](RegisterApi.md#registerprinter) | **POST** /v2/Common/Printer | 
[**RegisterReturn**](RegisterApi.md#registerreturn) | **POST** /v2/Payment/Return | 
[**RegisterSale**](RegisterApi.md#registersale) | **POST** /v2/Payment/Sale | 
[**RegisterSettle**](RegisterApi.md#registersettle) | **POST** /v2/Payment/Settle | 
[**RegisterStatus**](RegisterApi.md#registerstatus) | **POST** /v2/Payment/Status | 
[**RegisterStatusList**](RegisterApi.md#registerstatuslist) | **POST** /v2/Payment/StatusList | 
[**RegisterTipAdjust**](RegisterApi.md#registertipadjust) | **POST** /v2/Payment/TipAdjust | 
[**RegisterUserChoice**](RegisterApi.md#registeruserchoice) | **POST** /v2/Common/UserChoice | 
[**RegisterUserInput**](RegisterApi.md#registeruserinput) | **POST** /v2/Common/UserInput | 
[**RegisterVoid**](RegisterApi.md#registervoid) | **POST** /v2/Payment/Void | 

<a name="registerprinter"></a>
# **RegisterPrinter**
> PrinterResponseContract RegisterPrinter (PrinterRequestContract body)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RegisterPrinterExample
    {
        public void main()
        {
            var apiInstance = new RegisterApi();
            var body = new PrinterRequestContract(); // PrinterRequestContract | 

            try
            {
                PrinterResponseContract result = apiInstance.RegisterPrinter(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RegisterApi.RegisterPrinter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PrinterRequestContract**](PrinterRequestContract.md)|  | 

### Return type

[**PrinterResponseContract**](PrinterResponseContract.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="registerreturn"></a>
# **RegisterReturn**
> BasePaymentResponseContract RegisterReturn (ReturnRequestContract body)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RegisterReturnExample
    {
        public void main()
        {
            var apiInstance = new RegisterApi();
            var body = new ReturnRequestContract(); // ReturnRequestContract | 

            try
            {
                BasePaymentResponseContract result = apiInstance.RegisterReturn(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RegisterApi.RegisterReturn: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReturnRequestContract**](ReturnRequestContract.md)|  | 

### Return type

[**BasePaymentResponseContract**](BasePaymentResponseContract.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="registersale"></a>
# **RegisterSale**
> BasePaymentResponseContract RegisterSale (SaleRequestContract body)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RegisterSaleExample
    {
        public void main()
        {
            var apiInstance = new RegisterApi();
            var body = new SaleRequestContract(); // SaleRequestContract | 

            try
            {
                BasePaymentResponseContract result = apiInstance.RegisterSale(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RegisterApi.RegisterSale: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SaleRequestContract**](SaleRequestContract.md)|  | 

### Return type

[**BasePaymentResponseContract**](BasePaymentResponseContract.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="registersettle"></a>
# **RegisterSettle**
> SettleResponseContract RegisterSettle (SettleRequestContract body)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RegisterSettleExample
    {
        public void main()
        {
            var apiInstance = new RegisterApi();
            var body = new SettleRequestContract(); // SettleRequestContract | 

            try
            {
                SettleResponseContract result = apiInstance.RegisterSettle(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RegisterApi.RegisterSettle: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SettleRequestContract**](SettleRequestContract.md)|  | 

### Return type

[**SettleResponseContract**](SettleResponseContract.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="registerstatus"></a>
# **RegisterStatus**
> BasePaymentResponseContract RegisterStatus (StatusRequestContract body)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RegisterStatusExample
    {
        public void main()
        {
            var apiInstance = new RegisterApi();
            var body = new StatusRequestContract(); // StatusRequestContract | 

            try
            {
                BasePaymentResponseContract result = apiInstance.RegisterStatus(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RegisterApi.RegisterStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**StatusRequestContract**](StatusRequestContract.md)|  | 

### Return type

[**BasePaymentResponseContract**](BasePaymentResponseContract.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="registerstatuslist"></a>
# **RegisterStatusList**
> StatusListResponseContract RegisterStatusList (StatusListRequestContract body)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RegisterStatusListExample
    {
        public void main()
        {
            var apiInstance = new RegisterApi();
            var body = new StatusListRequestContract(); // StatusListRequestContract | 

            try
            {
                StatusListResponseContract result = apiInstance.RegisterStatusList(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RegisterApi.RegisterStatusList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**StatusListRequestContract**](StatusListRequestContract.md)|  | 

### Return type

[**StatusListResponseContract**](StatusListResponseContract.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="registertipadjust"></a>
# **RegisterTipAdjust**
> BasePaymentResponseContract RegisterTipAdjust (TipAdjustRequestContract body)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RegisterTipAdjustExample
    {
        public void main()
        {
            var apiInstance = new RegisterApi();
            var body = new TipAdjustRequestContract(); // TipAdjustRequestContract | 

            try
            {
                BasePaymentResponseContract result = apiInstance.RegisterTipAdjust(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RegisterApi.RegisterTipAdjust: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TipAdjustRequestContract**](TipAdjustRequestContract.md)|  | 

### Return type

[**BasePaymentResponseContract**](BasePaymentResponseContract.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="registeruserchoice"></a>
# **RegisterUserChoice**
> UserChoiceResponseContract RegisterUserChoice (UserChoiceRequestContract body)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RegisterUserChoiceExample
    {
        public void main()
        {
            var apiInstance = new RegisterApi();
            var body = new UserChoiceRequestContract(); // UserChoiceRequestContract | 

            try
            {
                UserChoiceResponseContract result = apiInstance.RegisterUserChoice(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RegisterApi.RegisterUserChoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserChoiceRequestContract**](UserChoiceRequestContract.md)|  | 

### Return type

[**UserChoiceResponseContract**](UserChoiceResponseContract.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="registeruserinput"></a>
# **RegisterUserInput**
> UserInputResponseContract RegisterUserInput (UserInputRequestContract body)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RegisterUserInputExample
    {
        public void main()
        {
            var apiInstance = new RegisterApi();
            var body = new UserInputRequestContract(); // UserInputRequestContract | 

            try
            {
                UserInputResponseContract result = apiInstance.RegisterUserInput(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RegisterApi.RegisterUserInput: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserInputRequestContract**](UserInputRequestContract.md)|  | 

### Return type

[**UserInputResponseContract**](UserInputResponseContract.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="registervoid"></a>
# **RegisterVoid**
> BasePaymentResponseContract RegisterVoid (VoidRequestContract body)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RegisterVoidExample
    {
        public void main()
        {
            var apiInstance = new RegisterApi();
            var body = new VoidRequestContract(); // VoidRequestContract | 

            try
            {
                BasePaymentResponseContract result = apiInstance.RegisterVoid(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RegisterApi.RegisterVoid: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**VoidRequestContract**](VoidRequestContract.md)|  | 

### Return type

[**BasePaymentResponseContract**](BasePaymentResponseContract.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
