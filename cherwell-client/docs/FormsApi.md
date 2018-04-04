# IO.Swagger.Api.FormsApi

All URIs are relative to *http://sapntest.cherwellondemand.com/CherwellAPI*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FormsGetMobileFormForBusObByIdAndPublicIdV1**](FormsApi.md#formsgetmobileformforbusobbyidandpublicidv1) | **GET** /api/V1/getmobileformforbusob/busobid/{busobid}/publicid/{publicid} | Get mobile form by BusObId and PublicID
[**FormsGetMobileFormForBusObByIdAndRecIdV1**](FormsApi.md#formsgetmobileformforbusobbyidandrecidv1) | **GET** /api/V1/getmobileformforbusob/busobid/{busobid}/busobrecid/{busobrecid} | Get mobile form by BusObId and BusObRecId
[**FormsGetMobileFormForBusObByNameAndPublicIdV1**](FormsApi.md#formsgetmobileformforbusobbynameandpublicidv1) | **GET** /api/V1/getmobileformforbusob/busobname/{busobname}/publicid/{publicid} | Get mobile form by BusObName and PublicId
[**FormsGetMobileFormForBusObByNameAndRecIdV1**](FormsApi.md#formsgetmobileformforbusobbynameandrecidv1) | **GET** /api/V1/getmobileformforbusob/busobname/{busobname}/busobrecid/{busobrecid} | Get mobile form by BusObName and record ID.


<a name="formsgetmobileformforbusobbyidandpublicidv1"></a>
# **FormsGetMobileFormForBusObByIdAndPublicIdV1**
> MobileFormResponse FormsGetMobileFormForBusObByIdAndPublicIdV1 (string busobid, string publicid, bool? foredit = null, string formid = null)

Get mobile form by BusObId and PublicID

Operation that gets a mobile form for a specific business object by Business Object ID and Public ID.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FormsGetMobileFormForBusObByIdAndPublicIdV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FormsApi();
            var busobid = busobid_example;  // string | Specify the Business Object ID.
            var publicid = publicid_example;  // string | Specify the Business Object public ID.
            var foredit = true;  // bool? | Flag to get the edit mode version of a form. (optional) 
            var formid = formid_example;  // string | Specify the form ID if the default is not desired. (optional) 

            try
            {
                // Get mobile form by BusObId and PublicID
                MobileFormResponse result = apiInstance.FormsGetMobileFormForBusObByIdAndPublicIdV1(busobid, publicid, foredit, formid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FormsApi.FormsGetMobileFormForBusObByIdAndPublicIdV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **busobid** | **string**| Specify the Business Object ID. | 
 **publicid** | **string**| Specify the Business Object public ID. | 
 **foredit** | **bool?**| Flag to get the edit mode version of a form. | [optional] 
 **formid** | **string**| Specify the form ID if the default is not desired. | [optional] 

### Return type

[**MobileFormResponse**](MobileFormResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="formsgetmobileformforbusobbyidandrecidv1"></a>
# **FormsGetMobileFormForBusObByIdAndRecIdV1**
> MobileFormResponse FormsGetMobileFormForBusObByIdAndRecIdV1 (string busobid, string busobrecid, bool? foredit = null, string formid = null)

Get mobile form by BusObId and BusObRecId

Operation that gets a mobile form for a specific business object by Business Object ID and record ID.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FormsGetMobileFormForBusObByIdAndRecIdV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FormsApi();
            var busobid = busobid_example;  // string | Specify the Business Object ID.
            var busobrecid = busobrecid_example;  // string | Specify the Business Object record ID.
            var foredit = true;  // bool? | Flag to get the edit mode version of a form. (optional) 
            var formid = formid_example;  // string | Specify the form ID if the default is not desired. (optional) 

            try
            {
                // Get mobile form by BusObId and BusObRecId
                MobileFormResponse result = apiInstance.FormsGetMobileFormForBusObByIdAndRecIdV1(busobid, busobrecid, foredit, formid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FormsApi.FormsGetMobileFormForBusObByIdAndRecIdV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **busobid** | **string**| Specify the Business Object ID. | 
 **busobrecid** | **string**| Specify the Business Object record ID. | 
 **foredit** | **bool?**| Flag to get the edit mode version of a form. | [optional] 
 **formid** | **string**| Specify the form ID if the default is not desired. | [optional] 

### Return type

[**MobileFormResponse**](MobileFormResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="formsgetmobileformforbusobbynameandpublicidv1"></a>
# **FormsGetMobileFormForBusObByNameAndPublicIdV1**
> MobileFormResponse FormsGetMobileFormForBusObByNameAndPublicIdV1 (string busobname, string publicid, bool? foredit = null, string formid = null)

Get mobile form by BusObName and PublicId

Operation that gets a mobile form for a specific business object by Business Object name and public ID.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FormsGetMobileFormForBusObByNameAndPublicIdV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FormsApi();
            var busobname = busobname_example;  // string | Specify the Business Object name.
            var publicid = publicid_example;  // string | Specify the Business Object public ID.
            var foredit = true;  // bool? | Flag to get the edit mode version of a form. (optional) 
            var formid = formid_example;  // string | Specify the form ID if the default is not desired. (optional) 

            try
            {
                // Get mobile form by BusObName and PublicId
                MobileFormResponse result = apiInstance.FormsGetMobileFormForBusObByNameAndPublicIdV1(busobname, publicid, foredit, formid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FormsApi.FormsGetMobileFormForBusObByNameAndPublicIdV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **busobname** | **string**| Specify the Business Object name. | 
 **publicid** | **string**| Specify the Business Object public ID. | 
 **foredit** | **bool?**| Flag to get the edit mode version of a form. | [optional] 
 **formid** | **string**| Specify the form ID if the default is not desired. | [optional] 

### Return type

[**MobileFormResponse**](MobileFormResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="formsgetmobileformforbusobbynameandrecidv1"></a>
# **FormsGetMobileFormForBusObByNameAndRecIdV1**
> MobileFormResponse FormsGetMobileFormForBusObByNameAndRecIdV1 (string busobname, string busobrecid, bool? foredit = null, string formid = null)

Get mobile form by BusObName and record ID.

Operation that gets a mobile form for a specific business object by Business Object name and record ID.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FormsGetMobileFormForBusObByNameAndRecIdV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FormsApi();
            var busobname = busobname_example;  // string | Specify the Business Object name.
            var busobrecid = busobrecid_example;  // string | Specify the Business Object record ID.
            var foredit = true;  // bool? | Flag to get the edit mode version of a form. (optional) 
            var formid = formid_example;  // string | Specify the form ID if the default is not desired. (optional) 

            try
            {
                // Get mobile form by BusObName and record ID.
                MobileFormResponse result = apiInstance.FormsGetMobileFormForBusObByNameAndRecIdV1(busobname, busobrecid, foredit, formid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FormsApi.FormsGetMobileFormForBusObByNameAndRecIdV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **busobname** | **string**| Specify the Business Object name. | 
 **busobrecid** | **string**| Specify the Business Object record ID. | 
 **foredit** | **bool?**| Flag to get the edit mode version of a form. | [optional] 
 **formid** | **string**| Specify the form ID if the default is not desired. | [optional] 

### Return type

[**MobileFormResponse**](MobileFormResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

