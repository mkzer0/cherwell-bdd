# IO.Swagger.Api.ServiceApi

All URIs are relative to *http://sapntest.cherwellondemand.com/CherwellAPI*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ServiceGetServiceInfoV1**](ServiceApi.md#servicegetserviceinfov1) | **GET** /api/V1/serviceinfo | Get information about the REST Api and CSM
[**ServiceLogoutUserV1**](ServiceApi.md#servicelogoutuserv1) | **DELETE** /api/V1/logout | Log out user by token
[**ServiceToken**](ServiceApi.md#servicetoken) | **POST** /token | Get an access token


<a name="servicegetserviceinfov1"></a>
# **ServiceGetServiceInfoV1**
> ServiceInfoResponse ServiceGetServiceInfoV1 ()

Get information about the REST Api and CSM

Operation to get information about the REST API and CSM.  The response is latest REST API operation version, CSM version, and CSM system date and time.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceGetServiceInfoV1Example
    {
        public void main()
        {
            var apiInstance = new ServiceApi();

            try
            {
                // Get information about the REST Api and CSM
                ServiceInfoResponse result = apiInstance.ServiceGetServiceInfoV1();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceApi.ServiceGetServiceInfoV1: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ServiceInfoResponse**](ServiceInfoResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="servicelogoutuserv1"></a>
# **ServiceLogoutUserV1**
> void ServiceLogoutUserV1 ()

Log out user by token

Operation that logs out the user referenced in the authentication token.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceLogoutUserV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ServiceApi();

            try
            {
                // Log out user by token
                apiInstance.ServiceLogoutUserV1();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceApi.ServiceLogoutUserV1: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="servicetoken"></a>
# **ServiceToken**
> TokenResponse ServiceToken (string grantType, string clientId, string clientSecret = null, string username = null, string password = null, string refreshToken = null, string authMode = null)

Get an access token

Operation to request an access token for one of the following authentication modes. Or, you can request an access token using a refresh token. An API client key is required in both cases, and the authentication mode you use must be the mode used by the CSM Browser Client. </br>  Internal - Use a CSM username and password. If no other mode is specified, Internal mode is used.</br>  Windows - Uses the server variable LOGON_USER to attempt to find a CSM user.  You can also use domain\\username and password.</br>  LDAP - Uses the LDAP settings configured for CSM and the server variable LOGON_USER to attempt to find a CSM user. You can also use domain\\username and password.</br>  SAML - Uses the SAML settings configured for CSM to validate credentials and find the CSM user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceTokenExample
    {
        public void main()
        {
            var apiInstance = new ServiceApi();
            var grantType = grantType_example;  // string | The type of grant being requested: password or refresh_token.
            var clientId = clientId_example;  // string | The API client key for the client making the token request.
            var clientSecret = clientSecret_example;  // string | The API client secret for the native client making the token request.  This is only required for native clients. (optional) 
            var username = username_example;  // string | Specify the login ID for the CSM user who will be granted the access token.  (optional) 
            var password = password_example;  // string | Specify the password assigned to the login ID. (optional) 
            var refreshToken = refreshToken_example;  // string | Specify the refresh token used to grant another access token. (optional) 
            var authMode = authMode_example;  // string | Specify the Authentication Mode to use for requesting an access token. (optional) 

            try
            {
                // Get an access token
                TokenResponse result = apiInstance.ServiceToken(grantType, clientId, clientSecret, username, password, refreshToken, authMode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceApi.ServiceToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **grantType** | **string**| The type of grant being requested: password or refresh_token. | 
 **clientId** | **string**| The API client key for the client making the token request. | 
 **clientSecret** | **string**| The API client secret for the native client making the token request.  This is only required for native clients. | [optional] 
 **username** | **string**| Specify the login ID for the CSM user who will be granted the access token.  | [optional] 
 **password** | **string**| Specify the password assigned to the login ID. | [optional] 
 **refreshToken** | **string**| Specify the refresh token used to grant another access token. | [optional] 
 **authMode** | **string**| Specify the Authentication Mode to use for requesting an access token. | [optional] 

### Return type

[**TokenResponse**](TokenResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

