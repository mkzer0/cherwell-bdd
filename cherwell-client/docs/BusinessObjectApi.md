# IO.Swagger.Api.BusinessObjectApi

All URIs are relative to *http://sapntest.cherwellondemand.com/CherwellAPI*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BusinessObjectDeleteBusinessObjectBatchV1**](BusinessObjectApi.md#businessobjectdeletebusinessobjectbatchv1) | **POST** /api/V1/deletebusinessobjectbatch | Delete Business Objects in a batch
[**BusinessObjectDeleteBusinessObjectByPublicIdV1**](BusinessObjectApi.md#businessobjectdeletebusinessobjectbypublicidv1) | **DELETE** /api/V1/deletebusinessobject/busobid/{busobid}/publicid/{publicid} | Delete a Business Object by public ID
[**BusinessObjectDeleteBusinessObjectByRecIdV1**](BusinessObjectApi.md#businessobjectdeletebusinessobjectbyrecidv1) | **DELETE** /api/V1/deletebusinessobject/busobid/{busobid}/busobrecid/{busobrecid} | Delete a Business Object by record ID
[**BusinessObjectDeleteRelatedBusinessObjectByPublicIdV1**](BusinessObjectApi.md#businessobjectdeleterelatedbusinessobjectbypublicidv1) | **DELETE** /api/V1/deleterelatedbusinessobject/parentbusobid/{parentbusobid}/parentbusobrecid/{parentbusobrecid}/relationshipid/{relationshipid}/publicid/{publicid} | Delete a related Business Object by public ID
[**BusinessObjectDeleteRelatedBusinessObjectByRecIdV1**](BusinessObjectApi.md#businessobjectdeleterelatedbusinessobjectbyrecidv1) | **DELETE** /api/V1/deleterelatedbusinessobject/parentbusobid/{parentbusobid}/parentbusobrecid/{parentbusobrecid}/relationshipid/{relationshipid}/busobrecid/{busobrecid} | Delete a related Business Object by record ID
[**BusinessObjectFieldValuesLookupV1**](BusinessObjectApi.md#businessobjectfieldvalueslookupv1) | **POST** /api/V1/fieldvalueslookup | Get lookup values for fields
[**BusinessObjectGetBusinessObjectAttachmentByAttachmentIdV1**](BusinessObjectApi.md#businessobjectgetbusinessobjectattachmentbyattachmentidv1) | **GET** /api/V1/getbusinessobjectattachment/attachmentid/{attachmentid}/busobid/{busobid}/busobrecid/{busobrecid} | Get an imported Business Object attachment
[**BusinessObjectGetBusinessObjectAttachmentsByIdAndPublicIdV1**](BusinessObjectApi.md#businessobjectgetbusinessobjectattachmentsbyidandpublicidv1) | **GET** /api/V1/getbusinessobjectattachments/busobid/{busobid}/publicid/{publicid}/type/{type}/attachmenttype/{attachmenttype} | Get attachments by Business Object public ID
[**BusinessObjectGetBusinessObjectAttachmentsByIdAndRecIdV1**](BusinessObjectApi.md#businessobjectgetbusinessobjectattachmentsbyidandrecidv1) | **GET** /api/V1/getbusinessobjectattachments/busobid/{busobid}/busobrecid/{busobrecid}/type/{type}/attachmenttype/{attachmenttype} | Get attachments by Business Object record ID
[**BusinessObjectGetBusinessObjectAttachmentsByNameAndPublicIdV1**](BusinessObjectApi.md#businessobjectgetbusinessobjectattachmentsbynameandpublicidv1) | **GET** /api/V1/getbusinessobjectattachments/busobname/{busobname}/publicid/{publicid}/type/{type}/attachmenttype/{attachmenttype} | Get attachments by Business Object name and public ID
[**BusinessObjectGetBusinessObjectAttachmentsByNameAndRecIdV1**](BusinessObjectApi.md#businessobjectgetbusinessobjectattachmentsbynameandrecidv1) | **GET** /api/V1/getbusinessobjectattachments/busobname/{busobname}/busobrecid/{busobrecid}/type/{type}/attachmenttype/{attachmenttype} | Get attachments by Business Object name and record ID
[**BusinessObjectGetBusinessObjectAttachmentsV1**](BusinessObjectApi.md#businessobjectgetbusinessobjectattachmentsv1) | **POST** /api/V1/getbusinessobjectattachments | Get Business Object attachments by request object
[**BusinessObjectGetBusinessObjectBatchV1**](BusinessObjectApi.md#businessobjectgetbusinessobjectbatchv1) | **POST** /api/V1/getbusinessobjectbatch | Get a batch of Business Object records
[**BusinessObjectGetBusinessObjectByPublicIdV1**](BusinessObjectApi.md#businessobjectgetbusinessobjectbypublicidv1) | **GET** /api/V1/getbusinessobject/busobid/{busobid}/publicid/{publicid} | Get a Business Object record
[**BusinessObjectGetBusinessObjectByRecIdV1**](BusinessObjectApi.md#businessobjectgetbusinessobjectbyrecidv1) | **GET** /api/V1/getbusinessobject/busobid/{busobid}/busobrecid/{busobrecid} | Get a Business Object record
[**BusinessObjectGetBusinessObjectByScanCodeBusObIdV1**](BusinessObjectApi.md#businessobjectgetbusinessobjectbyscancodebusobidv1) | **GET** /api/V1/getbusinessobject/scancode/{scanCode}/busobid/{busobid} | Get a Business Object by its scan code and Business Object ID.
[**BusinessObjectGetBusinessObjectByScanCodeBusObNameV1**](BusinessObjectApi.md#businessobjectgetbusinessobjectbyscancodebusobnamev1) | **GET** /api/V1/getbusinessobject/scancode/{scanCode}/busobname/{busobname} | Get a Business Object by its scan code and Business Object name.
[**BusinessObjectGetBusinessObjectSchemaV1**](BusinessObjectApi.md#businessobjectgetbusinessobjectschemav1) | **GET** /api/V1/getbusinessobjectschema/busobid/{busobId} | Get a Business Object schema
[**BusinessObjectGetBusinessObjectSummariesV1**](BusinessObjectApi.md#businessobjectgetbusinessobjectsummariesv1) | **GET** /api/V1/getbusinessobjectsummaries/type/{type} | Get Business Object summaries by type
[**BusinessObjectGetBusinessObjectSummaryByIdV1**](BusinessObjectApi.md#businessobjectgetbusinessobjectsummarybyidv1) | **GET** /api/V1/getbusinessobjectsummary/busobid/{busobid} | Get a Business Object summary by ID
[**BusinessObjectGetBusinessObjectSummaryByNameV1**](BusinessObjectApi.md#businessobjectgetbusinessobjectsummarybynamev1) | **GET** /api/V1/getbusinessobjectsummary/busobname/{busobname} | Get a Business Object summary by name
[**BusinessObjectGetBusinessObjectTemplateV1**](BusinessObjectApi.md#businessobjectgetbusinessobjecttemplatev1) | **POST** /api/V1/getbusinessobjecttemplate | Get Business Object templates for create
[**BusinessObjectGetRelatedBusinessObjectByRequestV1**](BusinessObjectApi.md#businessobjectgetrelatedbusinessobjectbyrequestv1) | **POST** /api/V1/getrelatedbusinessobject | Get related Business Objects using a request object
[**BusinessObjectGetRelatedBusinessObjectV1**](BusinessObjectApi.md#businessobjectgetrelatedbusinessobjectv1) | **GET** /api/V1/getrelatedbusinessobject/parentbusobid/{parentbusobid}/parentbusobrecid/{parentbusobrecid}/relationshipid/{relationshipid} | Get related Business Objects by ID
[**BusinessObjectGetRelatedBusinessObjectWithCustomGridV1**](BusinessObjectApi.md#businessobjectgetrelatedbusinessobjectwithcustomgridv1) | **GET** /api/V1/getrelatedbusinessobject/parentbusobid/{parentbusobid}/parentbusobrecid/{parentbusobrecid}/relationshipid/{relationshipid}/gridid/{gridid} | Get related Business Objects custom grid
[**BusinessObjectLinkRelatedBusinessObjectByRecIdV1**](BusinessObjectApi.md#businessobjectlinkrelatedbusinessobjectbyrecidv1) | **GET** /api/V1/linkrelatedbusinessobject/parentbusobid/{parentbusobid}/parentbusobrecid/{parentbusobrecid}/relationshipid/{relationshipid}/busobid/{busobid}/busobrecid/{busobrecid} | Link related Business Objects
[**BusinessObjectRemoveBusinessObjectAttachmentByIdAndPublicIdV1**](BusinessObjectApi.md#businessobjectremovebusinessobjectattachmentbyidandpublicidv1) | **DELETE** /api/V1/removebusinessobjectattachment/attachmentid/{attachmentid}/busobid/{busobid}/publicid/{publicid} | Remove an attachment by Business Object ID and public ID
[**BusinessObjectRemoveBusinessObjectAttachmentByIdAndRecIdV1**](BusinessObjectApi.md#businessobjectremovebusinessobjectattachmentbyidandrecidv1) | **DELETE** /api/V1/removebusinessobjectattachment/attachmentid/{attachmentid}/busobid/{busobid}/busobrecid/{busobrecid} | Remove an attachment by Business Object ID and record ID
[**BusinessObjectRemoveBusinessObjectAttachmentByNameAndPublicIdV1**](BusinessObjectApi.md#businessobjectremovebusinessobjectattachmentbynameandpublicidv1) | **DELETE** /api/V1/removebusinessobjectattachment/attachmentid/{attachmentid}/busobname/{busobname}/publicid/{publicid} | Remove an attachment by Business Object name and public ID
[**BusinessObjectRemoveBusinessObjectAttachmentByNameAndRecIdV1**](BusinessObjectApi.md#businessobjectremovebusinessobjectattachmentbynameandrecidv1) | **DELETE** /api/V1/removebusinessobjectattachment/attachmentid/{attachmentid}/busobname/{busobname}/busobrecid/{busobrecid} | Remove an attachment by Business Object name and record ID
[**BusinessObjectSaveBusinessObjectAttachmentBusObV1**](BusinessObjectApi.md#businessobjectsavebusinessobjectattachmentbusobv1) | **PUT** /api/V1/savebusinessobjectattachmentbusob | Attach a Business Object to a Business Object
[**BusinessObjectSaveBusinessObjectAttachmentLinkV1**](BusinessObjectApi.md#businessobjectsavebusinessobjectattachmentlinkv1) | **PUT** /api/V1/savebusinessobjectattachmentlink | Attach a file via UNC
[**BusinessObjectSaveBusinessObjectAttachmentUrlV1**](BusinessObjectApi.md#businessobjectsavebusinessobjectattachmenturlv1) | **PUT** /api/V1/savebusinessobjectattachmenturl | Attach a URL path
[**BusinessObjectSaveBusinessObjectBatchV1**](BusinessObjectApi.md#businessobjectsavebusinessobjectbatchv1) | **POST** /api/V1/savebusinessobjectbatch | Create or update a batch of Business Objects
[**BusinessObjectSaveBusinessObjectV1**](BusinessObjectApi.md#businessobjectsavebusinessobjectv1) | **POST** /api/V1/savebusinessobject | Create or Update a Business Object
[**BusinessObjectSaveRelatedBusinessObjectV1**](BusinessObjectApi.md#businessobjectsaverelatedbusinessobjectv1) | **POST** /api/V1/saverelatedbusinessobject | Create or update a related Business Object
[**BusinessObjectUnLinkRelatedBusinessObjectByRecIdV1**](BusinessObjectApi.md#businessobjectunlinkrelatedbusinessobjectbyrecidv1) | **DELETE** /api/V1/unlinkrelatedbusinessobject/parentbusobid/{parentbusobid}/parentbusobrecid/{parentbusobrecid}/relationshipid/{relationshipid}/busobid/{busobid}/busobrecid/{busobrecid} | UnLink related Business Objects
[**BusinessObjectUploadBusinessObjectAttachmentByIdAndPublicIdV1**](BusinessObjectApi.md#businessobjectuploadbusinessobjectattachmentbyidandpublicidv1) | **POST** /api/V1/uploadbusinessobjectattachment/filename/{filename}/busobid/{busobid}/publicid/{publicid}/offset/{offset}/totalsize/{totalsize} | Upload an attachment by Business Object ID and public ID
[**BusinessObjectUploadBusinessObjectAttachmentByIdAndRecIdV1**](BusinessObjectApi.md#businessobjectuploadbusinessobjectattachmentbyidandrecidv1) | **POST** /api/V1/uploadbusinessobjectattachment/filename/{filename}/busobid/{busobid}/busobrecid/{busobrecid}/offset/{offset}/totalsize/{totalsize} | Upload an attachment by Business Object ID and record ID
[**BusinessObjectUploadBusinessObjectAttachmentByNameAndPublicIdV1**](BusinessObjectApi.md#businessobjectuploadbusinessobjectattachmentbynameandpublicidv1) | **POST** /api/V1/uploadbusinessobjectattachment/filename/{filename}/busobname/{busobname}/publicid/{publicid}/offset/{offset}/totalsize/{totalsize} | Upload an attachment by Business Object name and public ID
[**BusinessObjectUploadBusinessObjectAttachmentByNameAndRecIdV1**](BusinessObjectApi.md#businessobjectuploadbusinessobjectattachmentbynameandrecidv1) | **POST** /api/V1/uploadbusinessobjectattachment/filename/{filename}/busobname/{busobname}/busobrecid/{busobrecid}/offset/{offset}/totalsize/{totalsize} | Upload an attachment by Business Object name and record ID


<a name="businessobjectdeletebusinessobjectbatchv1"></a>
# **BusinessObjectDeleteBusinessObjectBatchV1**
> BatchDeleteResponse BusinessObjectDeleteBusinessObjectBatchV1 (BatchDeleteRequest request)

Delete Business Objects in a batch

Operation to delete a batch of Business Objects.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BusinessObjectDeleteBusinessObjectBatchV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessObjectApi();
            var request = new BatchDeleteRequest(); // BatchDeleteRequest | Specify an array of Business Object IDs and record IDs or public IDs. Use a flag to stop on error or continue on error.

            try
            {
                // Delete Business Objects in a batch
                BatchDeleteResponse result = apiInstance.BusinessObjectDeleteBusinessObjectBatchV1(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessObjectApi.BusinessObjectDeleteBusinessObjectBatchV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**BatchDeleteRequest**](BatchDeleteRequest.md)| Specify an array of Business Object IDs and record IDs or public IDs. Use a flag to stop on error or continue on error. | 

### Return type

[**BatchDeleteResponse**](BatchDeleteResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="businessobjectdeletebusinessobjectbypublicidv1"></a>
# **BusinessObjectDeleteBusinessObjectByPublicIdV1**
> DeleteResponse BusinessObjectDeleteBusinessObjectByPublicIdV1 (string busobid, string publicid)

Delete a Business Object by public ID

Operation to delete a Business Object by Business Object ID.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BusinessObjectDeleteBusinessObjectByPublicIdV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessObjectApi();
            var busobid = busobid_example;  // string | Specify the Business Object ID.
            var publicid = publicid_example;  // string | Specify the Business Object public ID.

            try
            {
                // Delete a Business Object by public ID
                DeleteResponse result = apiInstance.BusinessObjectDeleteBusinessObjectByPublicIdV1(busobid, publicid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessObjectApi.BusinessObjectDeleteBusinessObjectByPublicIdV1: " + e.Message );
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

### Return type

[**DeleteResponse**](DeleteResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="businessobjectdeletebusinessobjectbyrecidv1"></a>
# **BusinessObjectDeleteBusinessObjectByRecIdV1**
> DeleteResponse BusinessObjectDeleteBusinessObjectByRecIdV1 (string busobid, string busobrecid)

Delete a Business Object by record ID

Operation to delete a single Business Object.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BusinessObjectDeleteBusinessObjectByRecIdV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessObjectApi();
            var busobid = busobid_example;  // string | Specify the Business Object ID.
            var busobrecid = busobrecid_example;  // string |  Specify the Business Object record ID.

            try
            {
                // Delete a Business Object by record ID
                DeleteResponse result = apiInstance.BusinessObjectDeleteBusinessObjectByRecIdV1(busobid, busobrecid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessObjectApi.BusinessObjectDeleteBusinessObjectByRecIdV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **busobid** | **string**| Specify the Business Object ID. | 
 **busobrecid** | **string**|  Specify the Business Object record ID. | 

### Return type

[**DeleteResponse**](DeleteResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="businessobjectdeleterelatedbusinessobjectbypublicidv1"></a>
# **BusinessObjectDeleteRelatedBusinessObjectByPublicIdV1**
> RelatedBusinessObjectResponse BusinessObjectDeleteRelatedBusinessObjectByPublicIdV1 (string parentbusobid, string parentbusobrecid, string relationshipid, string publicid)

Delete a related Business Object by public ID

Operation to delete a related Business Object. (Use \"Unlink Related Business Object\" to unlink two Business Objects rather that deleting the related Business Object.)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BusinessObjectDeleteRelatedBusinessObjectByPublicIdV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessObjectApi();
            var parentbusobid = parentbusobid_example;  // string | Specify the Business Object ID for the parent Business Object.
            var parentbusobrecid = parentbusobrecid_example;  // string | Specify the record ID for the parent Business Object
            var relationshipid = relationshipid_example;  // string | Specify the Relationship ID for the related Business Object you want to delete.
            var publicid = publicid_example;  // string | Specify the public ID for the related Business Object you want to delete. Use only for Business Objects with unique public IDs. Use \"Delete a related Business Object by record ID\" when public IDs are not unique.

            try
            {
                // Delete a related Business Object by public ID
                RelatedBusinessObjectResponse result = apiInstance.BusinessObjectDeleteRelatedBusinessObjectByPublicIdV1(parentbusobid, parentbusobrecid, relationshipid, publicid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessObjectApi.BusinessObjectDeleteRelatedBusinessObjectByPublicIdV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parentbusobid** | **string**| Specify the Business Object ID for the parent Business Object. | 
 **parentbusobrecid** | **string**| Specify the record ID for the parent Business Object | 
 **relationshipid** | **string**| Specify the Relationship ID for the related Business Object you want to delete. | 
 **publicid** | **string**| Specify the public ID for the related Business Object you want to delete. Use only for Business Objects with unique public IDs. Use \&quot;Delete a related Business Object by record ID\&quot; when public IDs are not unique. | 

### Return type

[**RelatedBusinessObjectResponse**](RelatedBusinessObjectResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="businessobjectdeleterelatedbusinessobjectbyrecidv1"></a>
# **BusinessObjectDeleteRelatedBusinessObjectByRecIdV1**
> RelatedBusinessObjectResponse BusinessObjectDeleteRelatedBusinessObjectByRecIdV1 (string parentbusobid, string parentbusobrecid, string relationshipid, string busobrecid)

Delete a related Business Object by record ID

Operation to delete a related Business Object. (Use \"Unlink Related Business Object\" to unlink two Business Objects rather that deleting the related Business Object.)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BusinessObjectDeleteRelatedBusinessObjectByRecIdV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessObjectApi();
            var parentbusobid = parentbusobid_example;  // string | Specify the Business Object ID for the parent Business Object.
            var parentbusobrecid = parentbusobrecid_example;  // string | Specify the record ID for the parent Business Object
            var relationshipid = relationshipid_example;  // string | Specify the Relationship ID for the related Business Object you want to delete.
            var busobrecid = busobrecid_example;  // string | Specify the record ID for the related Business Object you want to delete.

            try
            {
                // Delete a related Business Object by record ID
                RelatedBusinessObjectResponse result = apiInstance.BusinessObjectDeleteRelatedBusinessObjectByRecIdV1(parentbusobid, parentbusobrecid, relationshipid, busobrecid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessObjectApi.BusinessObjectDeleteRelatedBusinessObjectByRecIdV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parentbusobid** | **string**| Specify the Business Object ID for the parent Business Object. | 
 **parentbusobrecid** | **string**| Specify the record ID for the parent Business Object | 
 **relationshipid** | **string**| Specify the Relationship ID for the related Business Object you want to delete. | 
 **busobrecid** | **string**| Specify the record ID for the related Business Object you want to delete. | 

### Return type

[**RelatedBusinessObjectResponse**](RelatedBusinessObjectResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="businessobjectfieldvalueslookupv1"></a>
# **BusinessObjectFieldValuesLookupV1**
> FieldValuesLookupResponse BusinessObjectFieldValuesLookupV1 (FieldValuesLookupRequest request)

Get lookup values for fields

Operation to get potentially valid values for Business Object fields.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BusinessObjectFieldValuesLookupV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessObjectApi();
            var request = new FieldValuesLookupRequest(); // FieldValuesLookupRequest | Request object that specifies the Business Object and fields for which values are to be returned.

            try
            {
                // Get lookup values for fields
                FieldValuesLookupResponse result = apiInstance.BusinessObjectFieldValuesLookupV1(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessObjectApi.BusinessObjectFieldValuesLookupV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**FieldValuesLookupRequest**](FieldValuesLookupRequest.md)| Request object that specifies the Business Object and fields for which values are to be returned. | 

### Return type

[**FieldValuesLookupResponse**](FieldValuesLookupResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="businessobjectgetbusinessobjectattachmentbyattachmentidv1"></a>
# **BusinessObjectGetBusinessObjectAttachmentByAttachmentIdV1**
> byte[] BusinessObjectGetBusinessObjectAttachmentByAttachmentIdV1 (string attachmentid, string busobid, string busobrecid)

Get an imported Business Object attachment

Operation to get a Business Object attachment that has been imported into the system.  HTTP Range Header can be used but is optional.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BusinessObjectGetBusinessObjectAttachmentByAttachmentIdV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessObjectApi();
            var attachmentid = attachmentid_example;  // string | Specify the internal ID of the attachment record that contains information about the imported file.
            var busobid = busobid_example;  // string | Specify the Business Object ID.
            var busobrecid = busobrecid_example;  // string | Specify the Business Object record ID.

            try
            {
                // Get an imported Business Object attachment
                byte[] result = apiInstance.BusinessObjectGetBusinessObjectAttachmentByAttachmentIdV1(attachmentid, busobid, busobrecid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessObjectApi.BusinessObjectGetBusinessObjectAttachmentByAttachmentIdV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attachmentid** | **string**| Specify the internal ID of the attachment record that contains information about the imported file. | 
 **busobid** | **string**| Specify the Business Object ID. | 
 **busobrecid** | **string**| Specify the Business Object record ID. | 

### Return type

**byte[]**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="businessobjectgetbusinessobjectattachmentsbyidandpublicidv1"></a>
# **BusinessObjectGetBusinessObjectAttachmentsByIdAndPublicIdV1**
> AttachmentsResponse BusinessObjectGetBusinessObjectAttachmentsByIdAndPublicIdV1 (string busobid, string publicid, string type, string attachmenttype, bool? includelinks = null)

Get attachments by Business Object public ID

Operation to get attachments for a Business Object by Business Object ID and public ID.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BusinessObjectGetBusinessObjectAttachmentsByIdAndPublicIdV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessObjectApi();
            var busobid = busobid_example;  // string | Specify the Business Object ID.
            var publicid = publicid_example;  // string | Specify the Business Object public ID for the record that contains the attachments.
            var type = type_example;  // string | Record attachment type: </br>None - Not applicable to the REST API. </br>File - Linked files. </br>FileManagerFile - Imported files.</br>BusOb - Attached Business Objects. </br>History - Information about the attachment, if any is available. For example, an e-mail message may store the name of an attachment sent.</br>Other - Not applicable to the REST API. </br>
            var attachmenttype = attachmenttype_example;  // string | For file types, select the type of attachment: </br>Imported - Attachment was imported into database. </br>Linked - Attachment is linked to an external file. </br>URL - Attachment is a URL.
            var includelinks = true;  // bool? | Flag to include hyperlinks in results. Default is false.  (optional) 

            try
            {
                // Get attachments by Business Object public ID
                AttachmentsResponse result = apiInstance.BusinessObjectGetBusinessObjectAttachmentsByIdAndPublicIdV1(busobid, publicid, type, attachmenttype, includelinks);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessObjectApi.BusinessObjectGetBusinessObjectAttachmentsByIdAndPublicIdV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **busobid** | **string**| Specify the Business Object ID. | 
 **publicid** | **string**| Specify the Business Object public ID for the record that contains the attachments. | 
 **type** | **string**| Record attachment type: &lt;/br&gt;None - Not applicable to the REST API. &lt;/br&gt;File - Linked files. &lt;/br&gt;FileManagerFile - Imported files.&lt;/br&gt;BusOb - Attached Business Objects. &lt;/br&gt;History - Information about the attachment, if any is available. For example, an e-mail message may store the name of an attachment sent.&lt;/br&gt;Other - Not applicable to the REST API. &lt;/br&gt; | 
 **attachmenttype** | **string**| For file types, select the type of attachment: &lt;/br&gt;Imported - Attachment was imported into database. &lt;/br&gt;Linked - Attachment is linked to an external file. &lt;/br&gt;URL - Attachment is a URL. | 
 **includelinks** | **bool?**| Flag to include hyperlinks in results. Default is false.  | [optional] 

### Return type

[**AttachmentsResponse**](AttachmentsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="businessobjectgetbusinessobjectattachmentsbyidandrecidv1"></a>
# **BusinessObjectGetBusinessObjectAttachmentsByIdAndRecIdV1**
> AttachmentsResponse BusinessObjectGetBusinessObjectAttachmentsByIdAndRecIdV1 (string busobid, string busobrecid, string type, string attachmenttype, bool? includelinks = null)

Get attachments by Business Object record ID

Operation to get attachments for a Business Object by Business Object ID and record ID.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BusinessObjectGetBusinessObjectAttachmentsByIdAndRecIdV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessObjectApi();
            var busobid = busobid_example;  // string | Specify the Business Object ID.
            var busobrecid = busobrecid_example;  // string | Specify the Business Object record ID.
            var type = type_example;  // string | Record attachment type: </br>None - Not applicable to the REST API. </br>File - Linked files. </br>FileManagerFile - Imported files.</br>BusOb - Attached Business Objects. </br>History - Information about the attachment, if any is available. For example, an e-mail message may store the name of an attachment sent.</br>Other - Not applicable to the REST API. </br>
            var attachmenttype = attachmenttype_example;  // string | For file types, select the type of attachment: </br>Imported - Attachment was imported into database. </br>Linked - Attachment is linked to an external file. </br>URL - Attachment is a URL.
            var includelinks = true;  // bool? | Flag to include hyperlinks in results. Default is false.  (optional) 

            try
            {
                // Get attachments by Business Object record ID
                AttachmentsResponse result = apiInstance.BusinessObjectGetBusinessObjectAttachmentsByIdAndRecIdV1(busobid, busobrecid, type, attachmenttype, includelinks);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessObjectApi.BusinessObjectGetBusinessObjectAttachmentsByIdAndRecIdV1: " + e.Message );
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
 **type** | **string**| Record attachment type: &lt;/br&gt;None - Not applicable to the REST API. &lt;/br&gt;File - Linked files. &lt;/br&gt;FileManagerFile - Imported files.&lt;/br&gt;BusOb - Attached Business Objects. &lt;/br&gt;History - Information about the attachment, if any is available. For example, an e-mail message may store the name of an attachment sent.&lt;/br&gt;Other - Not applicable to the REST API. &lt;/br&gt; | 
 **attachmenttype** | **string**| For file types, select the type of attachment: &lt;/br&gt;Imported - Attachment was imported into database. &lt;/br&gt;Linked - Attachment is linked to an external file. &lt;/br&gt;URL - Attachment is a URL. | 
 **includelinks** | **bool?**| Flag to include hyperlinks in results. Default is false.  | [optional] 

### Return type

[**AttachmentsResponse**](AttachmentsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="businessobjectgetbusinessobjectattachmentsbynameandpublicidv1"></a>
# **BusinessObjectGetBusinessObjectAttachmentsByNameAndPublicIdV1**
> AttachmentsResponse BusinessObjectGetBusinessObjectAttachmentsByNameAndPublicIdV1 (string busobname, string publicid, string type, string attachmenttype, bool? includelinks = null)

Get attachments by Business Object name and public ID

Operation to get attachments for a Business Object by Business Object Name and public ID.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BusinessObjectGetBusinessObjectAttachmentsByNameAndPublicIdV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessObjectApi();
            var busobname = busobname_example;  // string | Specify the Business Object name.
            var publicid = publicid_example;  // string | Specify the Business Object public ID for the record that contains the attachments.
            var type = type_example;  // string | Record attachment type: </br>None - Not applicable to the REST API. </br>File - Linked files. </br>FileManagerFile - Imported files.</br>BusOb - Attached Business Objects. </br>History - Information about the attachment, if any is available. For example, an e-mail message may store the name of an attachment sent.</br>Other - Not applicable to the REST API. </br>
            var attachmenttype = attachmenttype_example;  // string | For file types, select the type of attachment: </br>Imported - Attachment was imported into database. </br>Linked - Attachment is linked to an external file. </br>URL - Attachment is a URL.
            var includelinks = true;  // bool? | Flag to include hyperlinks in results. Default is false.  (optional) 

            try
            {
                // Get attachments by Business Object name and public ID
                AttachmentsResponse result = apiInstance.BusinessObjectGetBusinessObjectAttachmentsByNameAndPublicIdV1(busobname, publicid, type, attachmenttype, includelinks);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessObjectApi.BusinessObjectGetBusinessObjectAttachmentsByNameAndPublicIdV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **busobname** | **string**| Specify the Business Object name. | 
 **publicid** | **string**| Specify the Business Object public ID for the record that contains the attachments. | 
 **type** | **string**| Record attachment type: &lt;/br&gt;None - Not applicable to the REST API. &lt;/br&gt;File - Linked files. &lt;/br&gt;FileManagerFile - Imported files.&lt;/br&gt;BusOb - Attached Business Objects. &lt;/br&gt;History - Information about the attachment, if any is available. For example, an e-mail message may store the name of an attachment sent.&lt;/br&gt;Other - Not applicable to the REST API. &lt;/br&gt; | 
 **attachmenttype** | **string**| For file types, select the type of attachment: &lt;/br&gt;Imported - Attachment was imported into database. &lt;/br&gt;Linked - Attachment is linked to an external file. &lt;/br&gt;URL - Attachment is a URL. | 
 **includelinks** | **bool?**| Flag to include hyperlinks in results. Default is false.  | [optional] 

### Return type

[**AttachmentsResponse**](AttachmentsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="businessobjectgetbusinessobjectattachmentsbynameandrecidv1"></a>
# **BusinessObjectGetBusinessObjectAttachmentsByNameAndRecIdV1**
> AttachmentsResponse BusinessObjectGetBusinessObjectAttachmentsByNameAndRecIdV1 (string busobname, string busobrecid, string type, string attachmenttype, bool? includelinks = null)

Get attachments by Business Object name and record ID

Operation to get attachments for a Business Object by name and record ID.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BusinessObjectGetBusinessObjectAttachmentsByNameAndRecIdV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessObjectApi();
            var busobname = busobname_example;  // string | Specify the Business Object name.
            var busobrecid = busobrecid_example;  // string | Specify the Business Object record ID.
            var type = type_example;  // string | Record attachment type: </br>None - Not applicable to the REST API. </br>File - Linked files. </br>FileManagerFile - Imported files.</br>BusOb - Attached Business Objects. </br>History - Information about the attachment, if any is available. For example, an e-mail message may store the name of an attachment sent.</br>Other - Not applicable to the REST API. </br>
            var attachmenttype = attachmenttype_example;  // string | For file types, select the type of attachment: </br>Imported - Attachment was imported into database. </br>Linked - Attachment is linked to an external file. </br>URL - Attachment is a URL.
            var includelinks = true;  // bool? | Flag to include hyperlinks in results. Default is false.  (optional) 

            try
            {
                // Get attachments by Business Object name and record ID
                AttachmentsResponse result = apiInstance.BusinessObjectGetBusinessObjectAttachmentsByNameAndRecIdV1(busobname, busobrecid, type, attachmenttype, includelinks);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessObjectApi.BusinessObjectGetBusinessObjectAttachmentsByNameAndRecIdV1: " + e.Message );
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
 **type** | **string**| Record attachment type: &lt;/br&gt;None - Not applicable to the REST API. &lt;/br&gt;File - Linked files. &lt;/br&gt;FileManagerFile - Imported files.&lt;/br&gt;BusOb - Attached Business Objects. &lt;/br&gt;History - Information about the attachment, if any is available. For example, an e-mail message may store the name of an attachment sent.&lt;/br&gt;Other - Not applicable to the REST API. &lt;/br&gt; | 
 **attachmenttype** | **string**| For file types, select the type of attachment: &lt;/br&gt;Imported - Attachment was imported into database. &lt;/br&gt;Linked - Attachment is linked to an external file. &lt;/br&gt;URL - Attachment is a URL. | 
 **includelinks** | **bool?**| Flag to include hyperlinks in results. Default is false.  | [optional] 

### Return type

[**AttachmentsResponse**](AttachmentsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="businessobjectgetbusinessobjectattachmentsv1"></a>
# **BusinessObjectGetBusinessObjectAttachmentsV1**
> AttachmentsResponse BusinessObjectGetBusinessObjectAttachmentsV1 (AttachmentsRequest attachmentsRequest)

Get Business Object attachments by request object

Operation to get attachments for a Business Object by attachments request object.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BusinessObjectGetBusinessObjectAttachmentsV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessObjectApi();
            var attachmentsRequest = new AttachmentsRequest(); // AttachmentsRequest | Object with all the parameters to request an attachments list. You can also request a list of types to get more than just one type at a time.

            try
            {
                // Get Business Object attachments by request object
                AttachmentsResponse result = apiInstance.BusinessObjectGetBusinessObjectAttachmentsV1(attachmentsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessObjectApi.BusinessObjectGetBusinessObjectAttachmentsV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attachmentsRequest** | [**AttachmentsRequest**](AttachmentsRequest.md)| Object with all the parameters to request an attachments list. You can also request a list of types to get more than just one type at a time. | 

### Return type

[**AttachmentsResponse**](AttachmentsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="businessobjectgetbusinessobjectbatchv1"></a>
# **BusinessObjectGetBusinessObjectBatchV1**
> BatchReadResponse BusinessObjectGetBusinessObjectBatchV1 (BatchReadRequest request)

Get a batch of Business Object records

Operation that returns a batch of Business Object records that includes a list of field record IDs, display names, and values for each record.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BusinessObjectGetBusinessObjectBatchV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessObjectApi();
            var request = new BatchReadRequest(); // BatchReadRequest | Specify an array of Business Object IDs, record IDs, or public IDs. Use a flag to stop on error or continue on error.

            try
            {
                // Get a batch of Business Object records
                BatchReadResponse result = apiInstance.BusinessObjectGetBusinessObjectBatchV1(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessObjectApi.BusinessObjectGetBusinessObjectBatchV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**BatchReadRequest**](BatchReadRequest.md)| Specify an array of Business Object IDs, record IDs, or public IDs. Use a flag to stop on error or continue on error. | 

### Return type

[**BatchReadResponse**](BatchReadResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="businessobjectgetbusinessobjectbypublicidv1"></a>
# **BusinessObjectGetBusinessObjectByPublicIdV1**
> ReadResponse BusinessObjectGetBusinessObjectByPublicIdV1 (string busobid, string publicid)

Get a Business Object record

Operation that returns a Business Object record that includes a list of fields and their record IDs, names, and set values.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BusinessObjectGetBusinessObjectByPublicIdV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessObjectApi();
            var busobid = busobid_example;  // string | Specify the Business Object ID.
            var publicid = publicid_example;  // string | Specify the Business Object public ID.

            try
            {
                // Get a Business Object record
                ReadResponse result = apiInstance.BusinessObjectGetBusinessObjectByPublicIdV1(busobid, publicid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessObjectApi.BusinessObjectGetBusinessObjectByPublicIdV1: " + e.Message );
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

### Return type

[**ReadResponse**](ReadResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="businessobjectgetbusinessobjectbyrecidv1"></a>
# **BusinessObjectGetBusinessObjectByRecIdV1**
> ReadResponse BusinessObjectGetBusinessObjectByRecIdV1 (string busobid, string busobrecid)

Get a Business Object record

Operation that returns a Business Object record that includes a list of fields and their record IDs, names, and set values.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BusinessObjectGetBusinessObjectByRecIdV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessObjectApi();
            var busobid = busobid_example;  // string | Specify the Business Object ID.
            var busobrecid = busobrecid_example;  // string | Specify the Business Object record ID.

            try
            {
                // Get a Business Object record
                ReadResponse result = apiInstance.BusinessObjectGetBusinessObjectByRecIdV1(busobid, busobrecid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessObjectApi.BusinessObjectGetBusinessObjectByRecIdV1: " + e.Message );
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

### Return type

[**ReadResponse**](ReadResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="businessobjectgetbusinessobjectbyscancodebusobidv1"></a>
# **BusinessObjectGetBusinessObjectByScanCodeBusObIdV1**
> BarcodeLookupResponse BusinessObjectGetBusinessObjectByScanCodeBusObIdV1 (string scanCode, string busobid)

Get a Business Object by its scan code and Business Object ID.

Operation to get a Business Object based on its associated scan code and Business Object ID.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BusinessObjectGetBusinessObjectByScanCodeBusObIdV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessObjectApi();
            var scanCode = scanCode_example;  // string | The scan code for a Business Object record.
            var busobid = busobid_example;  // string | The Business Object ID.

            try
            {
                // Get a Business Object by its scan code and Business Object ID.
                BarcodeLookupResponse result = apiInstance.BusinessObjectGetBusinessObjectByScanCodeBusObIdV1(scanCode, busobid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessObjectApi.BusinessObjectGetBusinessObjectByScanCodeBusObIdV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scanCode** | **string**| The scan code for a Business Object record. | 
 **busobid** | **string**| The Business Object ID. | 

### Return type

[**BarcodeLookupResponse**](BarcodeLookupResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="businessobjectgetbusinessobjectbyscancodebusobnamev1"></a>
# **BusinessObjectGetBusinessObjectByScanCodeBusObNameV1**
> BarcodeLookupResponse BusinessObjectGetBusinessObjectByScanCodeBusObNameV1 (string scanCode, string busobname)

Get a Business Object by its scan code and Business Object name.

Operation to get a Business Object based on its associated scan code and Business Object name.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BusinessObjectGetBusinessObjectByScanCodeBusObNameV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessObjectApi();
            var scanCode = scanCode_example;  // string | The scan code for a Business Object record.
            var busobname = busobname_example;  // string | The Business Bbject name.

            try
            {
                // Get a Business Object by its scan code and Business Object name.
                BarcodeLookupResponse result = apiInstance.BusinessObjectGetBusinessObjectByScanCodeBusObNameV1(scanCode, busobname);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessObjectApi.BusinessObjectGetBusinessObjectByScanCodeBusObNameV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scanCode** | **string**| The scan code for a Business Object record. | 
 **busobname** | **string**| The Business Bbject name. | 

### Return type

[**BarcodeLookupResponse**](BarcodeLookupResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="businessobjectgetbusinessobjectschemav1"></a>
# **BusinessObjectGetBusinessObjectSchemaV1**
> SchemaResponse BusinessObjectGetBusinessObjectSchemaV1 (string busobId, bool? includerelationships = null)

Get a Business Object schema

Operation that returns the schema for a Business Object and, optionally, its related Business Objects.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BusinessObjectGetBusinessObjectSchemaV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessObjectApi();
            var busobId = busobId_example;  // string | Specify the Business Object ID.
            var includerelationships = true;  // bool? | Flag to include schemas for related Business Object. Default is false. (optional) 

            try
            {
                // Get a Business Object schema
                SchemaResponse result = apiInstance.BusinessObjectGetBusinessObjectSchemaV1(busobId, includerelationships);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessObjectApi.BusinessObjectGetBusinessObjectSchemaV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **busobId** | **string**| Specify the Business Object ID. | 
 **includerelationships** | **bool?**| Flag to include schemas for related Business Object. Default is false. | [optional] 

### Return type

[**SchemaResponse**](SchemaResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="businessobjectgetbusinessobjectsummariesv1"></a>
# **BusinessObjectGetBusinessObjectSummariesV1**
> List<Summary> BusinessObjectGetBusinessObjectSummariesV1 (string type)

Get Business Object summaries by type

Operation that returns a list of Business Object summaries by type (Major, Supporting, Lookup, Groups, and All). 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BusinessObjectGetBusinessObjectSummariesV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessObjectApi();
            var type = type_example;  // string | Use to show:<br />All - All objects<br />Major - Major objects only<br />Supporting - Supporting objects only<br />Lookup - Lookup objects only<br />Groups - Groups only

            try
            {
                // Get Business Object summaries by type
                List&lt;Summary&gt; result = apiInstance.BusinessObjectGetBusinessObjectSummariesV1(type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessObjectApi.BusinessObjectGetBusinessObjectSummariesV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| Use to show:&lt;br /&gt;All - All objects&lt;br /&gt;Major - Major objects only&lt;br /&gt;Supporting - Supporting objects only&lt;br /&gt;Lookup - Lookup objects only&lt;br /&gt;Groups - Groups only | 

### Return type

[**List<Summary>**](Summary.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="businessobjectgetbusinessobjectsummarybyidv1"></a>
# **BusinessObjectGetBusinessObjectSummaryByIdV1**
> List<Summary> BusinessObjectGetBusinessObjectSummaryByIdV1 (string busobid)

Get a Business Object summary by ID

Operation that returns a single Business Object summary by ID.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BusinessObjectGetBusinessObjectSummaryByIdV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessObjectApi();
            var busobid = busobid_example;  // string | Specify a Business Object ID to get its summary.

            try
            {
                // Get a Business Object summary by ID
                List&lt;Summary&gt; result = apiInstance.BusinessObjectGetBusinessObjectSummaryByIdV1(busobid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessObjectApi.BusinessObjectGetBusinessObjectSummaryByIdV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **busobid** | **string**| Specify a Business Object ID to get its summary. | 

### Return type

[**List<Summary>**](Summary.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="businessobjectgetbusinessobjectsummarybynamev1"></a>
# **BusinessObjectGetBusinessObjectSummaryByNameV1**
> List<Summary> BusinessObjectGetBusinessObjectSummaryByNameV1 (string busobname)

Get a Business Object summary by name

Operation that returns a single Business Object summary by name.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BusinessObjectGetBusinessObjectSummaryByNameV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessObjectApi();
            var busobname = busobname_example;  // string | Specify a Business Object name to get its summary.

            try
            {
                // Get a Business Object summary by name
                List&lt;Summary&gt; result = apiInstance.BusinessObjectGetBusinessObjectSummaryByNameV1(busobname);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessObjectApi.BusinessObjectGetBusinessObjectSummaryByNameV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **busobname** | **string**| Specify a Business Object name to get its summary. | 

### Return type

[**List<Summary>**](Summary.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="businessobjectgetbusinessobjecttemplatev1"></a>
# **BusinessObjectGetBusinessObjectTemplateV1**
> TemplateResponse BusinessObjectGetBusinessObjectTemplateV1 (TemplateRequest request)

Get Business Object templates for create

Operation that returns a template to create Business Objects.  The template includes placeholders for field values. You can then send the template with these values to the Business Object Save operation.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BusinessObjectGetBusinessObjectTemplateV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessObjectApi();
            var request = new TemplateRequest(); // TemplateRequest | Specify the Business Object ID. Use true to include all required fields or all fields. Specify an optional fields list by adding field names in a comma-delimited list [\"field1\", \"field2\"]. 

            try
            {
                // Get Business Object templates for create
                TemplateResponse result = apiInstance.BusinessObjectGetBusinessObjectTemplateV1(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessObjectApi.BusinessObjectGetBusinessObjectTemplateV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**TemplateRequest**](TemplateRequest.md)| Specify the Business Object ID. Use true to include all required fields or all fields. Specify an optional fields list by adding field names in a comma-delimited list [\&quot;field1\&quot;, \&quot;field2\&quot;].  | 

### Return type

[**TemplateResponse**](TemplateResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="businessobjectgetrelatedbusinessobjectbyrequestv1"></a>
# **BusinessObjectGetRelatedBusinessObjectByRequestV1**
> RelatedBusinessObjectResponse BusinessObjectGetRelatedBusinessObjectByRequestV1 (RelatedBusinessObjectRequest relatedBusinessObjectRequest, bool? includelinks = null)

Get related Business Objects using a request object

Operation to get related Business Objects for a specific relationship. Specify a list of fields to include in the response. The order of parameter usage and overrides is: all fields set to true overrides default overrides;  custom grid overrides field list settings.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BusinessObjectGetRelatedBusinessObjectByRequestV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessObjectApi();
            var relatedBusinessObjectRequest = new RelatedBusinessObjectRequest(); // RelatedBusinessObjectRequest | Request object containing all the possible parameters to get related Business Objects.
            var includelinks = true;  // bool? | Flag to include hyperlinks in results. Default is false.  (optional) 

            try
            {
                // Get related Business Objects using a request object
                RelatedBusinessObjectResponse result = apiInstance.BusinessObjectGetRelatedBusinessObjectByRequestV1(relatedBusinessObjectRequest, includelinks);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessObjectApi.BusinessObjectGetRelatedBusinessObjectByRequestV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **relatedBusinessObjectRequest** | [**RelatedBusinessObjectRequest**](RelatedBusinessObjectRequest.md)| Request object containing all the possible parameters to get related Business Objects. | 
 **includelinks** | **bool?**| Flag to include hyperlinks in results. Default is false.  | [optional] 

### Return type

[**RelatedBusinessObjectResponse**](RelatedBusinessObjectResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="businessobjectgetrelatedbusinessobjectv1"></a>
# **BusinessObjectGetRelatedBusinessObjectV1**
> RelatedBusinessObjectResponse BusinessObjectGetRelatedBusinessObjectV1 (string parentbusobid, string parentbusobrecid, string relationshipid, int? pageNumber = null, int? pageSize = null, bool? allfields = null, bool? usedefaultgrid = null, bool? includelinks = null)

Get related Business Objects by ID

Operation to get the related objects for a Business Object relationship specifying all fields or default grid as the field to return.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BusinessObjectGetRelatedBusinessObjectV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessObjectApi();
            var parentbusobid = parentbusobid_example;  // string | Specify the Business Object ID for the parent Business Object.
            var parentbusobrecid = parentbusobrecid_example;  // string | Specify the record ID for the parent Business Object.
            var relationshipid = relationshipid_example;  // string | Specify the Relationship ID for the related Business Object you want to return.
            var pageNumber = 56;  // int? | Specify the page number of the result set to return. (optional) 
            var pageSize = 56;  // int? | Specify the number of rows to return per page. (optional) 
            var allfields = true;  // bool? | Flag to include all related Business Object fields.  Default is true if not supplied.  If true, then UseDefaultGrid is not used. (optional) 
            var usedefaultgrid = true;  // bool? | Flag to trigger the use of the related Business Objects default grid for the list of fields to return. (optional) 
            var includelinks = true;  // bool? | Flag to include hyperlinks in results. Default is false.  (optional) 

            try
            {
                // Get related Business Objects by ID
                RelatedBusinessObjectResponse result = apiInstance.BusinessObjectGetRelatedBusinessObjectV1(parentbusobid, parentbusobrecid, relationshipid, pageNumber, pageSize, allfields, usedefaultgrid, includelinks);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessObjectApi.BusinessObjectGetRelatedBusinessObjectV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parentbusobid** | **string**| Specify the Business Object ID for the parent Business Object. | 
 **parentbusobrecid** | **string**| Specify the record ID for the parent Business Object. | 
 **relationshipid** | **string**| Specify the Relationship ID for the related Business Object you want to return. | 
 **pageNumber** | **int?**| Specify the page number of the result set to return. | [optional] 
 **pageSize** | **int?**| Specify the number of rows to return per page. | [optional] 
 **allfields** | **bool?**| Flag to include all related Business Object fields.  Default is true if not supplied.  If true, then UseDefaultGrid is not used. | [optional] 
 **usedefaultgrid** | **bool?**| Flag to trigger the use of the related Business Objects default grid for the list of fields to return. | [optional] 
 **includelinks** | **bool?**| Flag to include hyperlinks in results. Default is false.  | [optional] 

### Return type

[**RelatedBusinessObjectResponse**](RelatedBusinessObjectResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="businessobjectgetrelatedbusinessobjectwithcustomgridv1"></a>
# **BusinessObjectGetRelatedBusinessObjectWithCustomGridV1**
> RelatedBusinessObjectResponse BusinessObjectGetRelatedBusinessObjectWithCustomGridV1 (string parentbusobid, string parentbusobrecid, string relationshipid, string gridid, int? pageNumber = null, int? pageSize = null, bool? includelinks = null)

Get related Business Objects custom grid

Operation to get related Business Objects for a specific relationship. Specify a custom grid ID as the fields to return.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BusinessObjectGetRelatedBusinessObjectWithCustomGridV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessObjectApi();
            var parentbusobid = parentbusobid_example;  // string | Specify the Business Object ID for the parent Business Object.
            var parentbusobrecid = parentbusobrecid_example;  // string | Specify the record ID for the parent Business Object.
            var relationshipid = relationshipid_example;  // string | Specify the Relationship ID for the related Business Object you want to return.
            var gridid = gridid_example;  // string | Specify the ID for the custom grid that contains the field list.
            var pageNumber = 56;  // int? | Specify the page number of the result set to return. (optional) 
            var pageSize = 56;  // int? | Specify the number of rows to return per page. (optional) 
            var includelinks = true;  // bool? | Flag to include hyperlinks in results. Default is false.  (optional) 

            try
            {
                // Get related Business Objects custom grid
                RelatedBusinessObjectResponse result = apiInstance.BusinessObjectGetRelatedBusinessObjectWithCustomGridV1(parentbusobid, parentbusobrecid, relationshipid, gridid, pageNumber, pageSize, includelinks);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessObjectApi.BusinessObjectGetRelatedBusinessObjectWithCustomGridV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parentbusobid** | **string**| Specify the Business Object ID for the parent Business Object. | 
 **parentbusobrecid** | **string**| Specify the record ID for the parent Business Object. | 
 **relationshipid** | **string**| Specify the Relationship ID for the related Business Object you want to return. | 
 **gridid** | **string**| Specify the ID for the custom grid that contains the field list. | 
 **pageNumber** | **int?**| Specify the page number of the result set to return. | [optional] 
 **pageSize** | **int?**| Specify the number of rows to return per page. | [optional] 
 **includelinks** | **bool?**| Flag to include hyperlinks in results. Default is false.  | [optional] 

### Return type

[**RelatedBusinessObjectResponse**](RelatedBusinessObjectResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="businessobjectlinkrelatedbusinessobjectbyrecidv1"></a>
# **BusinessObjectLinkRelatedBusinessObjectByRecIdV1**
> RelatedBusinessObjectResponse BusinessObjectLinkRelatedBusinessObjectByRecIdV1 (string parentbusobid, string parentbusobrecid, string relationshipid, string busobid, string busobrecid)

Link related Business Objects

Operation to link related Business Objects. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BusinessObjectLinkRelatedBusinessObjectByRecIdV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessObjectApi();
            var parentbusobid = parentbusobid_example;  // string | Specify the Business Object ID for the parent Business Object.
            var parentbusobrecid = parentbusobrecid_example;  // string | Specify the record ID for the parent Business Object.
            var relationshipid = relationshipid_example;  // string | Specify the Relationship ID for the related Business Object you want to link.
            var busobid = busobid_example;  // string | Specify the Business Object ID of the Business Object to be linked.
            var busobrecid = busobrecid_example;  // string | Specify the Business Object record ID of the Business Object to be linked.

            try
            {
                // Link related Business Objects
                RelatedBusinessObjectResponse result = apiInstance.BusinessObjectLinkRelatedBusinessObjectByRecIdV1(parentbusobid, parentbusobrecid, relationshipid, busobid, busobrecid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessObjectApi.BusinessObjectLinkRelatedBusinessObjectByRecIdV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parentbusobid** | **string**| Specify the Business Object ID for the parent Business Object. | 
 **parentbusobrecid** | **string**| Specify the record ID for the parent Business Object. | 
 **relationshipid** | **string**| Specify the Relationship ID for the related Business Object you want to link. | 
 **busobid** | **string**| Specify the Business Object ID of the Business Object to be linked. | 
 **busobrecid** | **string**| Specify the Business Object record ID of the Business Object to be linked. | 

### Return type

[**RelatedBusinessObjectResponse**](RelatedBusinessObjectResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="businessobjectremovebusinessobjectattachmentbyidandpublicidv1"></a>
# **BusinessObjectRemoveBusinessObjectAttachmentByIdAndPublicIdV1**
> void BusinessObjectRemoveBusinessObjectAttachmentByIdAndPublicIdV1 (string attachmentid, string busobid, string publicid)

Remove an attachment by Business Object ID and public ID

Operation to remove an attachment from a Business Object using the attachment record ID, Business Object ID, and Business Object public ID.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BusinessObjectRemoveBusinessObjectAttachmentByIdAndPublicIdV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessObjectApi();
            var attachmentid = attachmentid_example;  // string | Specify the internal ID of the attachment record.
            var busobid = busobid_example;  // string | Specify the Business Object ID.
            var publicid = publicid_example;  // string | Specify the Business Object public ID.

            try
            {
                // Remove an attachment by Business Object ID and public ID
                apiInstance.BusinessObjectRemoveBusinessObjectAttachmentByIdAndPublicIdV1(attachmentid, busobid, publicid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessObjectApi.BusinessObjectRemoveBusinessObjectAttachmentByIdAndPublicIdV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attachmentid** | **string**| Specify the internal ID of the attachment record. | 
 **busobid** | **string**| Specify the Business Object ID. | 
 **publicid** | **string**| Specify the Business Object public ID. | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="businessobjectremovebusinessobjectattachmentbyidandrecidv1"></a>
# **BusinessObjectRemoveBusinessObjectAttachmentByIdAndRecIdV1**
> void BusinessObjectRemoveBusinessObjectAttachmentByIdAndRecIdV1 (string attachmentid, string busobid, string busobrecid)

Remove an attachment by Business Object ID and record ID

Operation to remove an attachment from a Business Object using the attachment record ID, Business Object ID, and Business Object record ID.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BusinessObjectRemoveBusinessObjectAttachmentByIdAndRecIdV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessObjectApi();
            var attachmentid = attachmentid_example;  // string | Specify the internal ID of the attachment record.
            var busobid = busobid_example;  // string | Specify the Business Object ID.
            var busobrecid = busobrecid_example;  // string | Specify the Business Object record ID.

            try
            {
                // Remove an attachment by Business Object ID and record ID
                apiInstance.BusinessObjectRemoveBusinessObjectAttachmentByIdAndRecIdV1(attachmentid, busobid, busobrecid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessObjectApi.BusinessObjectRemoveBusinessObjectAttachmentByIdAndRecIdV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attachmentid** | **string**| Specify the internal ID of the attachment record. | 
 **busobid** | **string**| Specify the Business Object ID. | 
 **busobrecid** | **string**| Specify the Business Object record ID. | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="businessobjectremovebusinessobjectattachmentbynameandpublicidv1"></a>
# **BusinessObjectRemoveBusinessObjectAttachmentByNameAndPublicIdV1**
> void BusinessObjectRemoveBusinessObjectAttachmentByNameAndPublicIdV1 (string attachmentid, string busobname, string publicid)

Remove an attachment by Business Object name and public ID

Operation to remove an attachment from a Business Object using the attachment record ID, Business Object name, and Business Object record ID.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BusinessObjectRemoveBusinessObjectAttachmentByNameAndPublicIdV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessObjectApi();
            var attachmentid = attachmentid_example;  // string | Specify the internal ID of the attachment record.
            var busobname = busobname_example;  // string | Specify the Business Object name.
            var publicid = publicid_example;  // string | Specify the Business Object public ID.

            try
            {
                // Remove an attachment by Business Object name and public ID
                apiInstance.BusinessObjectRemoveBusinessObjectAttachmentByNameAndPublicIdV1(attachmentid, busobname, publicid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessObjectApi.BusinessObjectRemoveBusinessObjectAttachmentByNameAndPublicIdV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attachmentid** | **string**| Specify the internal ID of the attachment record. | 
 **busobname** | **string**| Specify the Business Object name. | 
 **publicid** | **string**| Specify the Business Object public ID. | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="businessobjectremovebusinessobjectattachmentbynameandrecidv1"></a>
# **BusinessObjectRemoveBusinessObjectAttachmentByNameAndRecIdV1**
> void BusinessObjectRemoveBusinessObjectAttachmentByNameAndRecIdV1 (string attachmentid, string busobname, string busobrecid)

Remove an attachment by Business Object name and record ID

Operation to remove an attachment from a Business Object using the attachment record ID, Business Object name, and Business Object public ID.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BusinessObjectRemoveBusinessObjectAttachmentByNameAndRecIdV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessObjectApi();
            var attachmentid = attachmentid_example;  // string | Specify the internal ID of the attachment record.
            var busobname = busobname_example;  // string | Specify the Business Object name.
            var busobrecid = busobrecid_example;  // string | Specify the Business Object record ID.

            try
            {
                // Remove an attachment by Business Object name and record ID
                apiInstance.BusinessObjectRemoveBusinessObjectAttachmentByNameAndRecIdV1(attachmentid, busobname, busobrecid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessObjectApi.BusinessObjectRemoveBusinessObjectAttachmentByNameAndRecIdV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attachmentid** | **string**| Specify the internal ID of the attachment record. | 
 **busobname** | **string**| Specify the Business Object name. | 
 **busobrecid** | **string**| Specify the Business Object record ID. | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="businessobjectsavebusinessobjectattachmentbusobv1"></a>
# **BusinessObjectSaveBusinessObjectAttachmentBusObV1**
> AttachmentsResponse BusinessObjectSaveBusinessObjectAttachmentBusObV1 (SaveBusObAttachmentRequest request)

Attach a Business Object to a Business Object

Operation to attach a Business Object to a Business Object. This links the Business Object but does not create a relationship between the two. (Use \"Link Related Business Objects\" to create a relationship.)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BusinessObjectSaveBusinessObjectAttachmentBusObV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessObjectApi();
            var request = new SaveBusObAttachmentRequest(); // SaveBusObAttachmentRequest | Request object used to specify the Business Objects to attach. You can use Business Object name or ID and Business Object record ID or public ID.

            try
            {
                // Attach a Business Object to a Business Object
                AttachmentsResponse result = apiInstance.BusinessObjectSaveBusinessObjectAttachmentBusObV1(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessObjectApi.BusinessObjectSaveBusinessObjectAttachmentBusObV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**SaveBusObAttachmentRequest**](SaveBusObAttachmentRequest.md)| Request object used to specify the Business Objects to attach. You can use Business Object name or ID and Business Object record ID or public ID. | 

### Return type

[**AttachmentsResponse**](AttachmentsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="businessobjectsavebusinessobjectattachmentlinkv1"></a>
# **BusinessObjectSaveBusinessObjectAttachmentLinkV1**
> AttachmentsResponse BusinessObjectSaveBusinessObjectAttachmentLinkV1 (SaveLinkAttachmentRequest request)

Attach a file via UNC

Operation to attach a file to a Business Object via a path (UNC recommended).

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BusinessObjectSaveBusinessObjectAttachmentLinkV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessObjectApi();
            var request = new SaveLinkAttachmentRequest(); // SaveLinkAttachmentRequest | Request object used to specify the file path (UNC recommended) and the Business Object. You can use Business Object name or ID and Business Object record ID or public ID.

            try
            {
                // Attach a file via UNC
                AttachmentsResponse result = apiInstance.BusinessObjectSaveBusinessObjectAttachmentLinkV1(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessObjectApi.BusinessObjectSaveBusinessObjectAttachmentLinkV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**SaveLinkAttachmentRequest**](SaveLinkAttachmentRequest.md)| Request object used to specify the file path (UNC recommended) and the Business Object. You can use Business Object name or ID and Business Object record ID or public ID. | 

### Return type

[**AttachmentsResponse**](AttachmentsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="businessobjectsavebusinessobjectattachmenturlv1"></a>
# **BusinessObjectSaveBusinessObjectAttachmentUrlV1**
> AttachmentsResponse BusinessObjectSaveBusinessObjectAttachmentUrlV1 (SaveUrlAttachmentRequest request)

Attach a URL path

Operation to attach a URL path to a Business Object.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BusinessObjectSaveBusinessObjectAttachmentUrlV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessObjectApi();
            var request = new SaveUrlAttachmentRequest(); // SaveUrlAttachmentRequest | Request object used to specify the URL path and Business Object. You can use Business Object name or ID and Business Object record ID or public ID.

            try
            {
                // Attach a URL path
                AttachmentsResponse result = apiInstance.BusinessObjectSaveBusinessObjectAttachmentUrlV1(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessObjectApi.BusinessObjectSaveBusinessObjectAttachmentUrlV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**SaveUrlAttachmentRequest**](SaveUrlAttachmentRequest.md)| Request object used to specify the URL path and Business Object. You can use Business Object name or ID and Business Object record ID or public ID. | 

### Return type

[**AttachmentsResponse**](AttachmentsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="businessobjectsavebusinessobjectbatchv1"></a>
# **BusinessObjectSaveBusinessObjectBatchV1**
> BatchSaveResponse BusinessObjectSaveBusinessObjectBatchV1 (BatchSaveRequest request)

Create or update a batch of Business Objects

Operation that creates or updates an array of Business Objects in a batch. To update, specify record ID or public ID. To create, leave record ID and public ID empty.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BusinessObjectSaveBusinessObjectBatchV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessObjectApi();
            var request = new BatchSaveRequest(); // BatchSaveRequest | Specify the array of Business Object templates. 

            try
            {
                // Create or update a batch of Business Objects
                BatchSaveResponse result = apiInstance.BusinessObjectSaveBusinessObjectBatchV1(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessObjectApi.BusinessObjectSaveBusinessObjectBatchV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**BatchSaveRequest**](BatchSaveRequest.md)| Specify the array of Business Object templates.  | 

### Return type

[**BatchSaveResponse**](BatchSaveResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="businessobjectsavebusinessobjectv1"></a>
# **BusinessObjectSaveBusinessObjectV1**
> SaveResponse BusinessObjectSaveBusinessObjectV1 (SaveRequest request)

Create or Update a Business Object

Operation that creates a new Business Object or updates an existing Business Object. To update, specify record ID or public ID. To create, leave record ID and public ID empty.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BusinessObjectSaveBusinessObjectV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessObjectApi();
            var request = new SaveRequest(); // SaveRequest | Specify a list of fields from a Business Object template. 

            try
            {
                // Create or Update a Business Object
                SaveResponse result = apiInstance.BusinessObjectSaveBusinessObjectV1(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessObjectApi.BusinessObjectSaveBusinessObjectV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**SaveRequest**](SaveRequest.md)| Specify a list of fields from a Business Object template.  | 

### Return type

[**SaveResponse**](SaveResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="businessobjectsaverelatedbusinessobjectv1"></a>
# **BusinessObjectSaveRelatedBusinessObjectV1**
> RelatedSaveResponse BusinessObjectSaveRelatedBusinessObjectV1 (RelatedSaveRequest request)

Create or update a related Business Object

Operation that creates or updates a related Business Object. To update, specify record ID or public ID. To create, leave record ID and public ID empty.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BusinessObjectSaveRelatedBusinessObjectV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessObjectApi();
            var request = new RelatedSaveRequest(); // RelatedSaveRequest | Request object specifying the parent the Business Object, the Relationship, and field values for the Business Object to create or update. 

            try
            {
                // Create or update a related Business Object
                RelatedSaveResponse result = apiInstance.BusinessObjectSaveRelatedBusinessObjectV1(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessObjectApi.BusinessObjectSaveRelatedBusinessObjectV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**RelatedSaveRequest**](RelatedSaveRequest.md)| Request object specifying the parent the Business Object, the Relationship, and field values for the Business Object to create or update.  | 

### Return type

[**RelatedSaveResponse**](RelatedSaveResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="businessobjectunlinkrelatedbusinessobjectbyrecidv1"></a>
# **BusinessObjectUnLinkRelatedBusinessObjectByRecIdV1**
> RelatedBusinessObjectResponse BusinessObjectUnLinkRelatedBusinessObjectByRecIdV1 (string parentbusobid, string parentbusobrecid, string relationshipid, string busobid, string busobrecid)

UnLink related Business Objects

Operation to unlink related Business Objects.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BusinessObjectUnLinkRelatedBusinessObjectByRecIdV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessObjectApi();
            var parentbusobid = parentbusobid_example;  // string | Specify the Business Object ID for the parent Business Object.
            var parentbusobrecid = parentbusobrecid_example;  // string | Specify the record ID for the parent Business Object.
            var relationshipid = relationshipid_example;  // string | Specify the Relationship ID for the related Business Object you want to unlink.
            var busobid = busobid_example;  // string | Specify the Business Object ID of the Business Object to be unlinked.
            var busobrecid = busobrecid_example;  // string | Specify the Business Object record ID of the Business Object to be unlinked.

            try
            {
                // UnLink related Business Objects
                RelatedBusinessObjectResponse result = apiInstance.BusinessObjectUnLinkRelatedBusinessObjectByRecIdV1(parentbusobid, parentbusobrecid, relationshipid, busobid, busobrecid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessObjectApi.BusinessObjectUnLinkRelatedBusinessObjectByRecIdV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parentbusobid** | **string**| Specify the Business Object ID for the parent Business Object. | 
 **parentbusobrecid** | **string**| Specify the record ID for the parent Business Object. | 
 **relationshipid** | **string**| Specify the Relationship ID for the related Business Object you want to unlink. | 
 **busobid** | **string**| Specify the Business Object ID of the Business Object to be unlinked. | 
 **busobrecid** | **string**| Specify the Business Object record ID of the Business Object to be unlinked. | 

### Return type

[**RelatedBusinessObjectResponse**](RelatedBusinessObjectResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="businessobjectuploadbusinessobjectattachmentbyidandpublicidv1"></a>
# **BusinessObjectUploadBusinessObjectAttachmentByIdAndPublicIdV1**
> string BusinessObjectUploadBusinessObjectAttachmentByIdAndPublicIdV1 (byte[] body, string filename, string busobid, string publicid, int? offset, int? totalsize, string attachmentid = null, string displaytext = null)

Upload an attachment by Business Object ID and public ID

Operation to upload an attachment to a Business Object record using a Business Object ID and public ID. The body of the request is the byte array of the file part being uploaded.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BusinessObjectUploadBusinessObjectAttachmentByIdAndPublicIdV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessObjectApi();
            var body = BINARY_DATA_HERE;  // byte[] | 
            var filename = filename_example;  // string | Specify the name of the file being uploaded. If no attachment name is provided, the file name is used.
            var busobid = busobid_example;  // string | Specify the Business Object ID.
            var publicid = publicid_example;  // string | Specify the Business Object public ID  to attach the file to.
            var offset = 56;  // int? | The offset is the starting index of the file part being uploaded.  If this is the first part then the offset will be zero.
            var totalsize = 56;  // int? | The entire file size in bytes.
            var attachmentid = attachmentid_example;  // string | Specify the attachment ID of an uploaded file to upload subsequent parts and ensure each part gets appended to the parts that have already been uploaded. (optional) 
            var displaytext = displaytext_example;  // string | Specify the attachment name, which is the display text for the attachment record. (optional) 

            try
            {
                // Upload an attachment by Business Object ID and public ID
                string result = apiInstance.BusinessObjectUploadBusinessObjectAttachmentByIdAndPublicIdV1(body, filename, busobid, publicid, offset, totalsize, attachmentid, displaytext);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessObjectApi.BusinessObjectUploadBusinessObjectAttachmentByIdAndPublicIdV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **byte[]**|  | 
 **filename** | **string**| Specify the name of the file being uploaded. If no attachment name is provided, the file name is used. | 
 **busobid** | **string**| Specify the Business Object ID. | 
 **publicid** | **string**| Specify the Business Object public ID  to attach the file to. | 
 **offset** | **int?**| The offset is the starting index of the file part being uploaded.  If this is the first part then the offset will be zero. | 
 **totalsize** | **int?**| The entire file size in bytes. | 
 **attachmentid** | **string**| Specify the attachment ID of an uploaded file to upload subsequent parts and ensure each part gets appended to the parts that have already been uploaded. | [optional] 
 **displaytext** | **string**| Specify the attachment name, which is the display text for the attachment record. | [optional] 

### Return type

**string**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/octet-stream
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="businessobjectuploadbusinessobjectattachmentbyidandrecidv1"></a>
# **BusinessObjectUploadBusinessObjectAttachmentByIdAndRecIdV1**
> string BusinessObjectUploadBusinessObjectAttachmentByIdAndRecIdV1 (byte[] body, string filename, string busobid, string busobrecid, int? offset, int? totalsize, string attachmentid = null, string displaytext = null)

Upload an attachment by Business Object ID and record ID

Operation to upload an attachment to a Business Object record using a Business Object ID and record ID. The body of the request is the byte array of the file part being uploaded.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BusinessObjectUploadBusinessObjectAttachmentByIdAndRecIdV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessObjectApi();
            var body = BINARY_DATA_HERE;  // byte[] | 
            var filename = filename_example;  // string | Specify the name of the file being uploaded. If no attachment name is provided, the file name is used.
            var busobid = busobid_example;  // string | Specify the Business Object ID.
            var busobrecid = busobrecid_example;  // string | Specify the Business Object record ID to attach the file to.
            var offset = 56;  // int? | The offset is the starting index of the file part being uploaded.  If this is the first part then the offset will be zero.
            var totalsize = 56;  // int? | The entire file size in bytes.
            var attachmentid = attachmentid_example;  // string | Specify the attachment ID of an uploaded file to upload subsequent parts and ensure each part gets appended to the parts that have already been uploaded. (optional) 
            var displaytext = displaytext_example;  // string | Specify the attachment name, which is the display text for the attachment record. (optional) 

            try
            {
                // Upload an attachment by Business Object ID and record ID
                string result = apiInstance.BusinessObjectUploadBusinessObjectAttachmentByIdAndRecIdV1(body, filename, busobid, busobrecid, offset, totalsize, attachmentid, displaytext);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessObjectApi.BusinessObjectUploadBusinessObjectAttachmentByIdAndRecIdV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **byte[]**|  | 
 **filename** | **string**| Specify the name of the file being uploaded. If no attachment name is provided, the file name is used. | 
 **busobid** | **string**| Specify the Business Object ID. | 
 **busobrecid** | **string**| Specify the Business Object record ID to attach the file to. | 
 **offset** | **int?**| The offset is the starting index of the file part being uploaded.  If this is the first part then the offset will be zero. | 
 **totalsize** | **int?**| The entire file size in bytes. | 
 **attachmentid** | **string**| Specify the attachment ID of an uploaded file to upload subsequent parts and ensure each part gets appended to the parts that have already been uploaded. | [optional] 
 **displaytext** | **string**| Specify the attachment name, which is the display text for the attachment record. | [optional] 

### Return type

**string**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/octet-stream
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="businessobjectuploadbusinessobjectattachmentbynameandpublicidv1"></a>
# **BusinessObjectUploadBusinessObjectAttachmentByNameAndPublicIdV1**
> string BusinessObjectUploadBusinessObjectAttachmentByNameAndPublicIdV1 (byte[] body, string filename, string busobname, string publicid, int? offset, int? totalsize, string attachmentid = null, string displaytext = null)

Upload an attachment by Business Object name and public ID

Operation to upload an attachment to a Business Object record using a Business Object name and public ID. The body of the request is the byte array of the file part being uploaded.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BusinessObjectUploadBusinessObjectAttachmentByNameAndPublicIdV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessObjectApi();
            var body = BINARY_DATA_HERE;  // byte[] | 
            var filename = filename_example;  // string | Specify the name of the file being uploaded. If no attachment name is provided, the file name is used.
            var busobname = busobname_example;  // string | Specify the Business Object name.
            var publicid = publicid_example;  // string | Specify the Business Object public ID  to attach the file to.
            var offset = 56;  // int? | The offset is the starting index of the file part being uploaded.  If this is the first part then the offset will be zero.
            var totalsize = 56;  // int? | The entire file size in bytes.
            var attachmentid = attachmentid_example;  // string | Specify the attachment ID of an uploaded file to upload subsequent parts and ensure each part gets appended to the parts that have already been uploaded. (optional) 
            var displaytext = displaytext_example;  // string | Specify the attachment name, which is the display text for the attachment record. (optional) 

            try
            {
                // Upload an attachment by Business Object name and public ID
                string result = apiInstance.BusinessObjectUploadBusinessObjectAttachmentByNameAndPublicIdV1(body, filename, busobname, publicid, offset, totalsize, attachmentid, displaytext);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessObjectApi.BusinessObjectUploadBusinessObjectAttachmentByNameAndPublicIdV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **byte[]**|  | 
 **filename** | **string**| Specify the name of the file being uploaded. If no attachment name is provided, the file name is used. | 
 **busobname** | **string**| Specify the Business Object name. | 
 **publicid** | **string**| Specify the Business Object public ID  to attach the file to. | 
 **offset** | **int?**| The offset is the starting index of the file part being uploaded.  If this is the first part then the offset will be zero. | 
 **totalsize** | **int?**| The entire file size in bytes. | 
 **attachmentid** | **string**| Specify the attachment ID of an uploaded file to upload subsequent parts and ensure each part gets appended to the parts that have already been uploaded. | [optional] 
 **displaytext** | **string**| Specify the attachment name, which is the display text for the attachment record. | [optional] 

### Return type

**string**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/octet-stream
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="businessobjectuploadbusinessobjectattachmentbynameandrecidv1"></a>
# **BusinessObjectUploadBusinessObjectAttachmentByNameAndRecIdV1**
> string BusinessObjectUploadBusinessObjectAttachmentByNameAndRecIdV1 (byte[] body, string filename, string busobname, string busobrecid, int? offset, int? totalsize, string attachmentid = null, string displaytext = null)

Upload an attachment by Business Object name and record ID

Operation to upload an attachment to a Business Object record using a Business Object name and record ID. The body of the request is the byte array of the file part being uploaded.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BusinessObjectUploadBusinessObjectAttachmentByNameAndRecIdV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessObjectApi();
            var body = BINARY_DATA_HERE;  // byte[] | 
            var filename = filename_example;  // string | Specify the name of the file being uploaded. If no attachment name is provided, the file name is used.
            var busobname = busobname_example;  // string | Specify the Business Object name.
            var busobrecid = busobrecid_example;  // string | Specify the Business Object record ID to attach the file to.
            var offset = 56;  // int? | The offset is the starting index of the file part being uploaded.  If this is the first part then the offset will be zero.
            var totalsize = 56;  // int? | The entire file size in bytes.
            var attachmentid = attachmentid_example;  // string | Specify the attachment ID of an uploaded file to upload subsequent parts and ensure each part gets appended to the parts that have already been uploaded. (optional) 
            var displaytext = displaytext_example;  // string | Specify the attachment name, which is the display text for the attachment record. (optional) 

            try
            {
                // Upload an attachment by Business Object name and record ID
                string result = apiInstance.BusinessObjectUploadBusinessObjectAttachmentByNameAndRecIdV1(body, filename, busobname, busobrecid, offset, totalsize, attachmentid, displaytext);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessObjectApi.BusinessObjectUploadBusinessObjectAttachmentByNameAndRecIdV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **byte[]**|  | 
 **filename** | **string**| Specify the name of the file being uploaded. If no attachment name is provided, the file name is used. | 
 **busobname** | **string**| Specify the Business Object name. | 
 **busobrecid** | **string**| Specify the Business Object record ID to attach the file to. | 
 **offset** | **int?**| The offset is the starting index of the file part being uploaded.  If this is the first part then the offset will be zero. | 
 **totalsize** | **int?**| The entire file size in bytes. | 
 **attachmentid** | **string**| Specify the attachment ID of an uploaded file to upload subsequent parts and ensure each part gets appended to the parts that have already been uploaded. | [optional] 
 **displaytext** | **string**| Specify the attachment name, which is the display text for the attachment record. | [optional] 

### Return type

**string**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/octet-stream
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

