# IO.Swagger.Api.SearchesApi

All URIs are relative to *http://sapntest.cherwellondemand.com/CherwellAPI*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SearchesGetQuickSearchConfigurationForBusObsV1**](SearchesApi.md#searchesgetquicksearchconfigurationforbusobsv1) | **POST** /api/V1/getquicksearchconfigurationforbusobs | Get a Quick Search from a list of Business Object IDs
[**SearchesGetQuickSearchConfigurationForBusObsWithViewRightsV1**](SearchesApi.md#searchesgetquicksearchconfigurationforbusobswithviewrightsv1) | **GET** /api/V1/getquicksearchconfigurationforbusobswithviewrights | Get a Quick Search by Business Objects with view rights
[**SearchesGetQuickSearchResultsV1**](SearchesApi.md#searchesgetquicksearchresultsv1) | **POST** /api/V1/getquicksearchresults | Execute a Quick Search from a list of Business Object IDs and search text
[**SearchesGetQuickSearchSpecificResultsV1**](SearchesApi.md#searchesgetquicksearchspecificresultsv1) | **POST** /api/V1/getquicksearchspecificresults | Execute a Quick Search on a specific Business Object
[**SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV1**](SearchesApi.md#searchesgetsearchitemsbyassociationscopescopeownerfolderv1) | **GET** /api/V1/getsearchitems/association/{association}/scope/{scope}/scopeowner/{scopeowner}/folder/{folder} | Get all saved searches by Folder ID
[**SearchesGetSearchItemsByAssociationScopeScopeOwnerV1**](SearchesApi.md#searchesgetsearchitemsbyassociationscopescopeownerv1) | **GET** /api/V1/getsearchitems/association/{association}/scope/{scope}/scopeowner/{scopeowner} | Get all saved searches by scope owner (sub scope)
[**SearchesGetSearchItemsByAssociationScopeV1**](SearchesApi.md#searchesgetsearchitemsbyassociationscopev1) | **GET** /api/V1/getsearchitems/association/{association}/scope/{scope} | Get all saved searches by scope
[**SearchesGetSearchItemsByAssociationV1**](SearchesApi.md#searchesgetsearchitemsbyassociationv1) | **GET** /api/V1/getsearchitems/association/{association} | Get all saved searches by Business Object association
[**SearchesGetSearchItemsV1**](SearchesApi.md#searchesgetsearchitemsv1) | **GET** /api/V1/getsearchitems | Get all saved searches by default Business Object association
[**SearchesGetSearchResultsAdHocV1**](SearchesApi.md#searchesgetsearchresultsadhocv1) | **POST** /api/V1/getsearchresults | Run an ad-hoc search
[**SearchesGetSearchResultsByIdV1**](SearchesApi.md#searchesgetsearchresultsbyidv1) | **GET** /api/V1/getsearchresults/association/{association}/scope/{scope}/scopeowner/{scopeowner}/searchid/{searchid} | Run a saved search by internal ID
[**SearchesGetSearchResultsByNameV1**](SearchesApi.md#searchesgetsearchresultsbynamev1) | **GET** /api/V1/getsearchresults/association/{association}/scope/{scope}/scopeowner/{scopeowner}/searchname/{searchname} | Run a saved search by name
[**SearchesGetSearchResultsExportAdHocV1**](SearchesApi.md#searchesgetsearchresultsexportadhocv1) | **POST** /api/V1/getsearchresultsexport | Export an ad-hoc search
[**SearchesGetSearchResultsExportByIdV1**](SearchesApi.md#searchesgetsearchresultsexportbyidv1) | **GET** /api/V1/getsearchresultsexport/association/{association}/scope/{scope}/scopeowner/{scopeowner}/searchid/{searchid}/exportformat/{exportformat} | Export a saved search by ID
[**SearchesGetSearchResultsExportByNameV1**](SearchesApi.md#searchesgetsearchresultsexportbynamev1) | **GET** /api/V1/getsearchresultsexport/association/{association}/scope/{scope}/scopeowner/{scopeowner}/searchname/{searchname}/exportformat/{exportformat} | Export a saved search by name


<a name="searchesgetquicksearchconfigurationforbusobsv1"></a>
# **SearchesGetQuickSearchConfigurationForBusObsV1**
> QuickSearchConfigurationResponse SearchesGetQuickSearchConfigurationForBusObsV1 (QuickSearchConfigurationRequest request)

Get a Quick Search from a list of Business Object IDs

Operation to build a Quick Search configuration that you can use to execute a Quick Search for multiple Business Objects. The configuration  includes supplied Business Object IDs and specific search items with the following options. Use the Option Key to determine if you can change the options. </br></br>ChangedOption</br>NonFinalStateOption</br>SearchAnyWordsOption</br>SearchAttachmentsOption</br>SearchRelatedOption</br>SortByOption</br></br>Option Key:</br>0 = None (Not selected and cannot select.)</br>1 = Use (Selected and cannot clear.)</br>2 = Display (Not selected and can select.)</br>3 = UseAndDisplay (Selected and can clear.)</br></br>SearchTargetType:</br>0 = BusOb (Business Object)</br>1 = DocRepository (Document Repository)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SearchesGetQuickSearchConfigurationForBusObsV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchesApi();
            var request = new QuickSearchConfigurationRequest(); // QuickSearchConfigurationRequest | Request containing the Business Object IDs list.

            try
            {
                // Get a Quick Search from a list of Business Object IDs
                QuickSearchConfigurationResponse result = apiInstance.SearchesGetQuickSearchConfigurationForBusObsV1(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesApi.SearchesGetQuickSearchConfigurationForBusObsV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**QuickSearchConfigurationRequest**](QuickSearchConfigurationRequest.md)| Request containing the Business Object IDs list. | 

### Return type

[**QuickSearchConfigurationResponse**](QuickSearchConfigurationResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchesgetquicksearchconfigurationforbusobswithviewrightsv1"></a>
# **SearchesGetQuickSearchConfigurationForBusObsWithViewRightsV1**
> QuickSearchConfigurationResponse SearchesGetQuickSearchConfigurationForBusObsWithViewRightsV1 ()

Get a Quick Search by Business Objects with view rights

Operation to get a Quick Search configuration that you can use to execute a Quick Search based the current user's Business Object view rights. The configuration  includes supplied Business Object IDs and specific search items with the following options. Use the Option Key to determine if you can change the options.</br></br>ChangedOption</br>NonFinalStateOption</br>SearchAnyWordsOption</br>SearchAttachmentsOption</br>SearchRelatedOption</br>SortByOption</br></br>Option Key:</br>0 = None (Not selected and cannot select.)</br>1 = Use (Selected and cannot clear.)</br>2 = Display (Not selected and can select.)</br>3 = UseAndDisplay (Selected and can clear.)</br></br>SearchTargetType:</br>0 = BusOb (Business Object)</br>1 = DocRepository (Document Repository)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SearchesGetQuickSearchConfigurationForBusObsWithViewRightsV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchesApi();

            try
            {
                // Get a Quick Search by Business Objects with view rights
                QuickSearchConfigurationResponse result = apiInstance.SearchesGetQuickSearchConfigurationForBusObsWithViewRightsV1();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesApi.SearchesGetQuickSearchConfigurationForBusObsWithViewRightsV1: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**QuickSearchConfigurationResponse**](QuickSearchConfigurationResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchesgetquicksearchresultsv1"></a>
# **SearchesGetQuickSearchResultsV1**
> SimpleResultsList SearchesGetQuickSearchResultsV1 (QuickSearchRequest request, bool? includeLinks = null)

Execute a Quick Search from a list of Business Object IDs and search text

Operation to execute a Quick Search using a list of Business Object IDs and search text.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SearchesGetQuickSearchResultsV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchesApi();
            var request = new QuickSearchRequest(); // QuickSearchRequest | Request object listing Business Object IDs and search text. Leave out the entire busObIds parameter and all configured quick search Business Objects will be searched.
            var includeLinks = true;  // bool? | Flag to include hyperlinks in results. Default is false.  (optional) 

            try
            {
                // Execute a Quick Search from a list of Business Object IDs and search text
                SimpleResultsList result = apiInstance.SearchesGetQuickSearchResultsV1(request, includeLinks);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesApi.SearchesGetQuickSearchResultsV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**QuickSearchRequest**](QuickSearchRequest.md)| Request object listing Business Object IDs and search text. Leave out the entire busObIds parameter and all configured quick search Business Objects will be searched. | 
 **includeLinks** | **bool?**| Flag to include hyperlinks in results. Default is false.  | [optional] 

### Return type

[**SimpleResultsList**](SimpleResultsList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchesgetquicksearchspecificresultsv1"></a>
# **SearchesGetQuickSearchSpecificResultsV1**
> SearchResultsTableResponse SearchesGetQuickSearchSpecificResultsV1 (QuickSearchSpecificRequest request, bool? includeSchema = null, bool? includeLocationFields = null, bool? includeLinks = null)

Execute a Quick Search on a specific Business Object

Operation to execute a Quick Search for a specific Business Object ID. Use \"Get a Quick Search from a list of Business Object IDs\" to find values for specific search item options, such as NonFinalStateOption.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SearchesGetQuickSearchSpecificResultsV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchesApi();
            var request = new QuickSearchSpecificRequest(); // QuickSearchSpecificRequest | Request object containing the parameters for specific Business Object Quick Search execution.
            var includeSchema = true;  // bool? | Flag to include the schema for the results. (optional) 
            var includeLocationFields = true;  // bool? | Flag to include location fields in the results. (optional) 
            var includeLinks = true;  // bool? | Flag to include hyperlinks in results. Default is false.  (optional) 

            try
            {
                // Execute a Quick Search on a specific Business Object
                SearchResultsTableResponse result = apiInstance.SearchesGetQuickSearchSpecificResultsV1(request, includeSchema, includeLocationFields, includeLinks);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesApi.SearchesGetQuickSearchSpecificResultsV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**QuickSearchSpecificRequest**](QuickSearchSpecificRequest.md)| Request object containing the parameters for specific Business Object Quick Search execution. | 
 **includeSchema** | **bool?**| Flag to include the schema for the results. | [optional] 
 **includeLocationFields** | **bool?**| Flag to include location fields in the results. | [optional] 
 **includeLinks** | **bool?**| Flag to include hyperlinks in results. Default is false.  | [optional] 

### Return type

[**SearchResultsTableResponse**](SearchResultsTableResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchesgetsearchitemsbyassociationscopescopeownerfolderv1"></a>
# **SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV1**
> SearchItemResponse SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV1 (string association, string scope, string scopeowner, string folder, bool? links = null)

Get all saved searches by Folder ID

Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchesApi();
            var association = association_example;  // string | Use to filter results by Business Object association ID.
            var scope = scope_example;  // string | Use to filter results by scope name or ID.
            var scopeowner = scopeowner_example;  // string | Use to filter results by scope owner ID.
            var folder = folder_example;  // string | Use to filter results by Search Group folder ID.
            var links = true;  // bool? | Flag to include hyperlinks in results. Default is false.  (optional) 

            try
            {
                // Get all saved searches by Folder ID
                SearchItemResponse result = apiInstance.SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV1(association, scope, scopeowner, folder, links);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesApi.SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **association** | **string**| Use to filter results by Business Object association ID. | 
 **scope** | **string**| Use to filter results by scope name or ID. | 
 **scopeowner** | **string**| Use to filter results by scope owner ID. | 
 **folder** | **string**| Use to filter results by Search Group folder ID. | 
 **links** | **bool?**| Flag to include hyperlinks in results. Default is false.  | [optional] 

### Return type

[**SearchItemResponse**](SearchItemResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchesgetsearchitemsbyassociationscopescopeownerv1"></a>
# **SearchesGetSearchItemsByAssociationScopeScopeOwnerV1**
> SearchItemResponse SearchesGetSearchItemsByAssociationScopeScopeOwnerV1 (string association, string scope, string scopeowner, bool? links = null)

Get all saved searches by scope owner (sub scope)

Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SearchesGetSearchItemsByAssociationScopeScopeOwnerV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchesApi();
            var association = association_example;  // string | Use to filter results by Business Object association ID.
            var scope = scope_example;  // string | Use to filter results by scope name or ID.
            var scopeowner = scopeowner_example;  // string | Use to filter results by scope owner ID.
            var links = true;  // bool? | Flag to include hyperlinks in results. Default is false.  (optional) 

            try
            {
                // Get all saved searches by scope owner (sub scope)
                SearchItemResponse result = apiInstance.SearchesGetSearchItemsByAssociationScopeScopeOwnerV1(association, scope, scopeowner, links);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesApi.SearchesGetSearchItemsByAssociationScopeScopeOwnerV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **association** | **string**| Use to filter results by Business Object association ID. | 
 **scope** | **string**| Use to filter results by scope name or ID. | 
 **scopeowner** | **string**| Use to filter results by scope owner ID. | 
 **links** | **bool?**| Flag to include hyperlinks in results. Default is false.  | [optional] 

### Return type

[**SearchItemResponse**](SearchItemResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchesgetsearchitemsbyassociationscopev1"></a>
# **SearchesGetSearchItemsByAssociationScopeV1**
> SearchItemResponse SearchesGetSearchItemsByAssociationScopeV1 (string association, string scope, bool? links = null)

Get all saved searches by scope

Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SearchesGetSearchItemsByAssociationScopeV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchesApi();
            var association = association_example;  // string | Use to filter results by Business Object association ID.
            var scope = scope_example;  // string | Use to filter results by scope name or ID.
            var links = true;  // bool? | Flag to include hyperlinks in results. Default is false.  (optional) 

            try
            {
                // Get all saved searches by scope
                SearchItemResponse result = apiInstance.SearchesGetSearchItemsByAssociationScopeV1(association, scope, links);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesApi.SearchesGetSearchItemsByAssociationScopeV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **association** | **string**| Use to filter results by Business Object association ID. | 
 **scope** | **string**| Use to filter results by scope name or ID. | 
 **links** | **bool?**| Flag to include hyperlinks in results. Default is false.  | [optional] 

### Return type

[**SearchItemResponse**](SearchItemResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchesgetsearchitemsbyassociationv1"></a>
# **SearchesGetSearchItemsByAssociationV1**
> SearchItemResponse SearchesGetSearchItemsByAssociationV1 (string association, bool? links = null)

Get all saved searches by Business Object association

Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SearchesGetSearchItemsByAssociationV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchesApi();
            var association = association_example;  // string | Use to filter results by Business Object association ID.
            var links = true;  // bool? | Flag to include hyperlinks in results. Default is false.  (optional) 

            try
            {
                // Get all saved searches by Business Object association
                SearchItemResponse result = apiInstance.SearchesGetSearchItemsByAssociationV1(association, links);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesApi.SearchesGetSearchItemsByAssociationV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **association** | **string**| Use to filter results by Business Object association ID. | 
 **links** | **bool?**| Flag to include hyperlinks in results. Default is false.  | [optional] 

### Return type

[**SearchItemResponse**](SearchItemResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchesgetsearchitemsv1"></a>
# **SearchesGetSearchItemsV1**
> SearchItemResponse SearchesGetSearchItemsV1 (bool? links = null)

Get all saved searches by default Business Object association

Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SearchesGetSearchItemsV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchesApi();
            var links = true;  // bool? | Flag to include hyperlinks in results. Default is false.  (optional) 

            try
            {
                // Get all saved searches by default Business Object association
                SearchItemResponse result = apiInstance.SearchesGetSearchItemsV1(links);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesApi.SearchesGetSearchItemsV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **links** | **bool?**| Flag to include hyperlinks in results. Default is false.  | [optional] 

### Return type

[**SearchItemResponse**](SearchItemResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchesgetsearchresultsadhocv1"></a>
# **SearchesGetSearchResultsAdHocV1**
> SearchResultsResponse SearchesGetSearchResultsAdHocV1 (SearchResultsRequest request)

Run an ad-hoc search

Operation that runs an ad-hoc Business Object search. To execute a search with Prompts, the PromptId and Value are required in the Prompt request object.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SearchesGetSearchResultsAdHocV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchesApi();
            var request = new SearchResultsRequest(); // SearchResultsRequest | Request object to specify search parameters.

            try
            {
                // Run an ad-hoc search
                SearchResultsResponse result = apiInstance.SearchesGetSearchResultsAdHocV1(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesApi.SearchesGetSearchResultsAdHocV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**SearchResultsRequest**](SearchResultsRequest.md)| Request object to specify search parameters. | 

### Return type

[**SearchResultsResponse**](SearchResultsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchesgetsearchresultsbyidv1"></a>
# **SearchesGetSearchResultsByIdV1**
> SearchResultsResponse SearchesGetSearchResultsByIdV1 (string association, string scope, string scopeowner, string searchid, string searchTerm = null, int? pagenumber = null, int? pagesize = null, bool? includeschema = null)

Run a saved search by internal ID

Operation that returns the paged results of a saved search. When the search contains Prompts, the response contains the Prompt. Send the Prompt and the original operation parameters to  SearchResultsRequest to the getsearchresults ad-hoc http post operation.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SearchesGetSearchResultsByIdV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchesApi();
            var association = association_example;  // string | Specify the Business Object association ID for the saved search.
            var scope = scope_example;  // string | Specify the scope name or ID for the saved search.
            var scopeowner = scopeowner_example;  // string | Specify the scope owner ID for the saved search. Use (None) when no scope owner exists.
            var searchid = searchid_example;  // string | Specify the internal ID for the saved search. Use \"Run a saved search by name\" if you do not have the internal ID.
            var searchTerm = searchTerm_example;  // string | Specify search text filter the results. Example: Use \"Service Request\" to filter Incident results to include only service requests. (optional) 
            var pagenumber = 56;  // int? | Specify the page number of the result set to return. (optional) 
            var pagesize = 56;  // int? | Specify the number of rows to return per page. (optional) 
            var includeschema = true;  // bool? | Use to include the table schema of the saved search. If false, results contain the fieldid and field value without field information. Default is false. (optional) 

            try
            {
                // Run a saved search by internal ID
                SearchResultsResponse result = apiInstance.SearchesGetSearchResultsByIdV1(association, scope, scopeowner, searchid, searchTerm, pagenumber, pagesize, includeschema);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesApi.SearchesGetSearchResultsByIdV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **association** | **string**| Specify the Business Object association ID for the saved search. | 
 **scope** | **string**| Specify the scope name or ID for the saved search. | 
 **scopeowner** | **string**| Specify the scope owner ID for the saved search. Use (None) when no scope owner exists. | 
 **searchid** | **string**| Specify the internal ID for the saved search. Use \&quot;Run a saved search by name\&quot; if you do not have the internal ID. | 
 **searchTerm** | **string**| Specify search text filter the results. Example: Use \&quot;Service Request\&quot; to filter Incident results to include only service requests. | [optional] 
 **pagenumber** | **int?**| Specify the page number of the result set to return. | [optional] 
 **pagesize** | **int?**| Specify the number of rows to return per page. | [optional] 
 **includeschema** | **bool?**| Use to include the table schema of the saved search. If false, results contain the fieldid and field value without field information. Default is false. | [optional] 

### Return type

[**SearchResultsResponse**](SearchResultsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchesgetsearchresultsbynamev1"></a>
# **SearchesGetSearchResultsByNameV1**
> SearchResultsResponse SearchesGetSearchResultsByNameV1 (string association, string scope, string scopeowner, string searchname, string searchTerm = null, int? pagenumber = null, int? pagesize = null, bool? includeschema = null)

Run a saved search by name

Operation that returns the paged results of a saved search. When the search contains Prompts, the response contains the Prompt. Send the Prompt and the original operation parameters to  SearchResultsRequest to the getsearchresults ad-hoc http post operation.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SearchesGetSearchResultsByNameV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchesApi();
            var association = association_example;  // string | Specify the Business Object association ID for the saved search.
            var scope = scope_example;  // string | Specify the scope name or ID for the saved search.
            var scopeowner = scopeowner_example;  // string | Specify the scope owner ID for the saved search. Use (None) when no scope owner exists.
            var searchname = searchname_example;  // string | Specify the name of the saved search.
            var searchTerm = searchTerm_example;  // string | Specify search text filter the results. Example: Use \"Service Request\" to filter Incident results to include only service requests. (optional) 
            var pagenumber = 56;  // int? | Specify the page number of the result set to return. (optional) 
            var pagesize = 56;  // int? | Specify the number of rows to return per page. (optional) 
            var includeschema = true;  // bool? | Use to include the table schema of the saved search. If false, results contain the fieldid and field value without field information. Default is false. (optional) 

            try
            {
                // Run a saved search by name
                SearchResultsResponse result = apiInstance.SearchesGetSearchResultsByNameV1(association, scope, scopeowner, searchname, searchTerm, pagenumber, pagesize, includeschema);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesApi.SearchesGetSearchResultsByNameV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **association** | **string**| Specify the Business Object association ID for the saved search. | 
 **scope** | **string**| Specify the scope name or ID for the saved search. | 
 **scopeowner** | **string**| Specify the scope owner ID for the saved search. Use (None) when no scope owner exists. | 
 **searchname** | **string**| Specify the name of the saved search. | 
 **searchTerm** | **string**| Specify search text filter the results. Example: Use \&quot;Service Request\&quot; to filter Incident results to include only service requests. | [optional] 
 **pagenumber** | **int?**| Specify the page number of the result set to return. | [optional] 
 **pagesize** | **int?**| Specify the number of rows to return per page. | [optional] 
 **includeschema** | **bool?**| Use to include the table schema of the saved search. If false, results contain the fieldid and field value without field information. Default is false. | [optional] 

### Return type

[**SearchResultsResponse**](SearchResultsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchesgetsearchresultsexportadhocv1"></a>
# **SearchesGetSearchResultsExportAdHocV1**
> string SearchesGetSearchResultsExportAdHocV1 (ExportSearchResultsRequest request)

Export an ad-hoc search

Operation that returns an ad-hoc search in a specified export format: 0=CSV, 1=Excel, 2=Tab, 3=Word, 4=Custom Separator, 5=Simple JSON. To execute a search with Prompts, the PromptId and Value are required in the Prompt request object.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SearchesGetSearchResultsExportAdHocV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchesApi();
            var request = new ExportSearchResultsRequest(); // ExportSearchResultsRequest | Request object to specify search parameters and export format.

            try
            {
                // Export an ad-hoc search
                string result = apiInstance.SearchesGetSearchResultsExportAdHocV1(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesApi.SearchesGetSearchResultsExportAdHocV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**ExportSearchResultsRequest**](ExportSearchResultsRequest.md)| Request object to specify search parameters and export format. | 

### Return type

**string**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchesgetsearchresultsexportbyidv1"></a>
# **SearchesGetSearchResultsExportByIdV1**
> string SearchesGetSearchResultsExportByIdV1 (string association, string scope, string scopeowner, string searchid, string exportformat, string searchTerm = null, int? pagenumber = null, int? pagesize = null)

Export a saved search by ID

Operation that returns the paged results of a saved search in a specified format. When the search contains Prompts, the response contains the Prompt. Send the Prompt and the original operation parameters to  SearchResultsRequest to the getsearchresultsexport ad-hoc http post operation.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SearchesGetSearchResultsExportByIdV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchesApi();
            var association = association_example;  // string | Specify the Business Object association ID for the saved search.
            var scope = scope_example;  // string | Specify the scope name or ID for the saved search.
            var scopeowner = scopeowner_example;  // string | Specify the scope owner ID for the saved search. Use (None) when no scope owner exists.
            var searchid = searchid_example;  // string | Specify the internal ID for the saved search. Use \"Run a saved search by name\" if you do not have the internal ID.
            var exportformat = exportformat_example;  // string | Specify the format of the export
            var searchTerm = searchTerm_example;  // string | Specify search text filter the results. Example: Use \"Service Request\" to filter Incident results to include only service requests. (optional) 
            var pagenumber = 56;  // int? | Specify the page number of the result set to return. (optional) 
            var pagesize = 56;  // int? | Specify the number of rows to return per page. (optional) 

            try
            {
                // Export a saved search by ID
                string result = apiInstance.SearchesGetSearchResultsExportByIdV1(association, scope, scopeowner, searchid, exportformat, searchTerm, pagenumber, pagesize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesApi.SearchesGetSearchResultsExportByIdV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **association** | **string**| Specify the Business Object association ID for the saved search. | 
 **scope** | **string**| Specify the scope name or ID for the saved search. | 
 **scopeowner** | **string**| Specify the scope owner ID for the saved search. Use (None) when no scope owner exists. | 
 **searchid** | **string**| Specify the internal ID for the saved search. Use \&quot;Run a saved search by name\&quot; if you do not have the internal ID. | 
 **exportformat** | **string**| Specify the format of the export | 
 **searchTerm** | **string**| Specify search text filter the results. Example: Use \&quot;Service Request\&quot; to filter Incident results to include only service requests. | [optional] 
 **pagenumber** | **int?**| Specify the page number of the result set to return. | [optional] 
 **pagesize** | **int?**| Specify the number of rows to return per page. | [optional] 

### Return type

**string**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchesgetsearchresultsexportbynamev1"></a>
# **SearchesGetSearchResultsExportByNameV1**
> string SearchesGetSearchResultsExportByNameV1 (string association, string scope, string scopeowner, string searchname, string exportformat, string searchTerm = null, int? pagenumber = null, int? pagesize = null)

Export a saved search by name

Operation that returns the paged results of a saved search in a specified format. When the search contains Prompts, the response contains the Prompt. Send the Prompt and the original operation parameters to  SearchResultsRequest to the getsearchresultsexport ad-hoc http post operation.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SearchesGetSearchResultsExportByNameV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchesApi();
            var association = association_example;  // string | Specify the Business Object association ID for the saved search.
            var scope = scope_example;  // string | Specify the scope name or ID for the saved search.
            var scopeowner = scopeowner_example;  // string | Specify the scope owner ID for the saved search. Use (None) when no scope owner exists.
            var searchname = searchname_example;  // string | Specify the name of the saved search.
            var exportformat = exportformat_example;  // string | Specify the format of the export
            var searchTerm = searchTerm_example;  // string | Specify search text filter the results. Example: Use \"Service Request\" to filter Incident results to include only service requests. (optional) 
            var pagenumber = 56;  // int? | Specify the page number of the result set to return. (optional) 
            var pagesize = 56;  // int? | Specify the number of rows to return per page. (optional) 

            try
            {
                // Export a saved search by name
                string result = apiInstance.SearchesGetSearchResultsExportByNameV1(association, scope, scopeowner, searchname, exportformat, searchTerm, pagenumber, pagesize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesApi.SearchesGetSearchResultsExportByNameV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **association** | **string**| Specify the Business Object association ID for the saved search. | 
 **scope** | **string**| Specify the scope name or ID for the saved search. | 
 **scopeowner** | **string**| Specify the scope owner ID for the saved search. Use (None) when no scope owner exists. | 
 **searchname** | **string**| Specify the name of the saved search. | 
 **exportformat** | **string**| Specify the format of the export | 
 **searchTerm** | **string**| Specify search text filter the results. Example: Use \&quot;Service Request\&quot; to filter Incident results to include only service requests. | [optional] 
 **pagenumber** | **int?**| Specify the page number of the result set to return. | [optional] 
 **pagesize** | **int?**| Specify the number of rows to return per page. | [optional] 

### Return type

**string**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

