# IO.Swagger.Api.CoreApi

All URIs are relative to *http://sapntest.cherwellondemand.com/CherwellAPI*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CoreGetGalleryImageV1**](CoreApi.md#coregetgalleryimagev1) | **GET** /api/V1/getgalleryimage/name/{name} | Get built-in images


<a name="coregetgalleryimagev1"></a>
# **CoreGetGalleryImageV1**
> string CoreGetGalleryImageV1 (string name, int? width = null, int? height = null)

Get built-in images

Operation that gets built-in images. If you are requesting an icon (.ico), you can specify width and height.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CoreGetGalleryImageV1Example
    {
        public void main()
        {
            var apiInstance = new CoreApi();
            var name = name_example;  // string | Image name and folder location in the Image Manager. Parameter must begin with \"[PlugIn]Images;\" and then a period-separated list of folders. Example: \"[PlugIn]Images;Images.Common.Cherwell.ico\".
            var width = 56;  // int? | Specify the width (icons only). (optional) 
            var height = 56;  // int? | Specify the height (icons only). (optional) 

            try
            {
                // Get built-in images
                string result = apiInstance.CoreGetGalleryImageV1(name, width, height);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CoreApi.CoreGetGalleryImageV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Image name and folder location in the Image Manager. Parameter must begin with \&quot;[PlugIn]Images;\&quot; and then a period-separated list of folders. Example: \&quot;[PlugIn]Images;Images.Common.Cherwell.ico\&quot;. | 
 **width** | **int?**| Specify the width (icons only). | [optional] 
 **height** | **int?**| Specify the height (icons only). | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

