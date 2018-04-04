# IO.Swagger.Api.SecurityApi

All URIs are relative to *http://sapntest.cherwellondemand.com/CherwellAPI*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SecurityAddUserToTeamByBatchV1**](SecurityApi.md#securityaddusertoteambybatchv1) | **POST** /api/V1/addusertoteambybatch | Add users to a team by batch
[**SecurityAddUserToTeamV1**](SecurityApi.md#securityaddusertoteamv1) | **POST** /api/V1/addusertoteam | Add a user to a team
[**SecurityAddUserToTeamV2**](SecurityApi.md#securityaddusertoteamv2) | **POST** /api/V2/addusertoteam | Add a user to a team
[**SecurityDeleteUserBatchV1**](SecurityApi.md#securitydeleteuserbatchv1) | **POST** /api/V1/deleteuserbatch | Delete a batch of users
[**SecurityDeleteUserBatchV2**](SecurityApi.md#securitydeleteuserbatchv2) | **POST** /api/V2/deleteuserbatch | Delete a batch of users
[**SecurityDeleteUserV1**](SecurityApi.md#securitydeleteuserv1) | **DELETE** /api/V1/deleteuser/userrecordid/{userrecordid} | Delete a user by record ID
[**SecurityDeleteUserV2**](SecurityApi.md#securitydeleteuserv2) | **DELETE** /api/V2/deleteuser/userrecordid/{userrecordid} | Delete a user by record ID
[**SecurityGetRolesV1**](SecurityApi.md#securitygetrolesv1) | **GET** /api/V1/getroles | Get all available Roles
[**SecurityGetRolesV2**](SecurityApi.md#securitygetrolesv2) | **GET** /api/V2/getroles | Get all available Roles
[**SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV1**](SecurityApi.md#securitygetsecuritygroupbusinessobjectpermissionsbybusobidv1) | **GET** /api/V1/getsecuritygroupbusinessobjectpermissions/groupid/{groupid}/busobid/{busObId} | Get Business Object permissions by Security Group
[**SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV2**](SecurityApi.md#securitygetsecuritygroupbusinessobjectpermissionsbybusobidv2) | **GET** /api/V2/getsecuritygroupbusinessobjectpermissions/groupid/{groupid}/busobid/{busObId} | Get Business Object permissions by Security Group
[**SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV1**](SecurityApi.md#securitygetsecuritygroupbusinessobjectpermissionsbybusobnamev1) | **GET** /api/V1/getsecuritygroupbusinessobjectpermissions/groupname/{groupname}/busobname/{busobname} | Get Business Object permissions by Security Group
[**SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV2**](SecurityApi.md#securitygetsecuritygroupbusinessobjectpermissionsbybusobnamev2) | **GET** /api/V2/getsecuritygroupbusinessobjectpermissions/groupname/{groupname}/busobname/{busobname} | Get Business Object permissions by Security Group
[**SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV1**](SecurityApi.md#securitygetsecuritygroupbusinessobjectpermissionsforcurrentuserbybusobidv1) | **GET** /api/V1/getsecuritygroupbusinessobjectpermissionsforcurrentuserbybusobid/busobid/{busObId} | Get Business Object permission for current user
[**SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV2**](SecurityApi.md#securitygetsecuritygroupbusinessobjectpermissionsforcurrentuserbybusobidv2) | **GET** /api/V2/getsecuritygroupbusinessobjectpermissionsforcurrentuserbybusobid/busobid/{busObId} | Get Business Object permission for current user
[**SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV1**](SecurityApi.md#securitygetsecuritygroupbusinessobjectpermissionsforcurrentuserbybusobnamev1) | **GET** /api/V1/getsecuritygroupbusinessobjectpermissionsforcurrentuserbybusobname/busobname/{busobname} | Get Business Object permissions for current user
[**SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV2**](SecurityApi.md#securitygetsecuritygroupbusinessobjectpermissionsforcurrentuserbybusobnamev2) | **GET** /api/V2/getsecuritygroupbusinessobjectpermissionsforcurrentuserbybusobname/busobname/{busobname} | Get Business Object permissions for current user
[**SecurityGetSecurityGroupCategoriesV1**](SecurityApi.md#securitygetsecuritygroupcategoriesv1) | **GET** /api/V1/getsecuritygroupcategories | Get all Security Group categories
[**SecurityGetSecurityGroupCategoriesV2**](SecurityApi.md#securitygetsecuritygroupcategoriesv2) | **GET** /api/V2/getsecuritygroupcategories | Get all Security Group categories
[**SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV1**](SecurityApi.md#securitygetsecuritygrouprightsbygroupidandcategoryidv1) | **GET** /api/V1/getsecuritygrouprights/groupid/{groupid}/categoryid/{categoryid} | Get permissions for a Security Group by category
[**SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV2**](SecurityApi.md#securitygetsecuritygrouprightsbygroupidandcategoryidv2) | **GET** /api/V2/getsecuritygrouprights/groupid/{groupid}/categoryid/{categoryid} | Get permissions for a Security Group by category
[**SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV1**](SecurityApi.md#securitygetsecuritygrouprightsbygroupnameandcategorynamev1) | **GET** /api/V1/getsecuritygrouprights/groupname/{groupname}/categoryname/{categoryname} | Get permissions for a Security Group by category
[**SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV2**](SecurityApi.md#securitygetsecuritygrouprightsbygroupnameandcategorynamev2) | **GET** /api/V2/getsecuritygrouprights/groupname/{groupname}/categoryname/{categoryname} | Get permissions for a Security Group by category
[**SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV1**](SecurityApi.md#securitygetsecuritygrouprightsforcurrentuserbycategoryidv1) | **GET** /api/V1/getsecuritygrouprightsforcurrentuserbycategoryid/categoryid/{categoryid} | Get current user&#39;s permissions by Security Group category by ID
[**SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV2**](SecurityApi.md#securitygetsecuritygrouprightsforcurrentuserbycategoryidv2) | **GET** /api/V2/getsecuritygrouprightsforcurrentuserbycategoryid/categoryid/{categoryid} | Get current user&#39;s permissions by Security Group category by ID
[**SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV1**](SecurityApi.md#securitygetsecuritygrouprightsforcurrentuserbycategorynamev1) | **GET** /api/V1/getsecuritygrouprightsforcurrentuserbycategoryname/categoryname/{categoryname} | Get current user&#39;s permissions by Security Group category by name
[**SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV2**](SecurityApi.md#securitygetsecuritygrouprightsforcurrentuserbycategorynamev2) | **GET** /api/V2/getsecuritygrouprightsforcurrentuserbycategoryname/categoryname/{categoryname} | Get current user&#39;s permissions by Security Group category by name
[**SecurityGetSecurityGroupsV1**](SecurityApi.md#securitygetsecuritygroupsv1) | **GET** /api/V1/getsecuritygroups | Get all available Security Groups
[**SecurityGetSecurityGroupsV2**](SecurityApi.md#securitygetsecuritygroupsv2) | **GET** /api/V2/getsecuritygroups | Get all available Security Groups
[**SecurityGetTeamsV1**](SecurityApi.md#securitygetteamsv1) | **GET** /api/V1/getteams | Get all available Teams
[**SecurityGetTeamsV2**](SecurityApi.md#securitygetteamsv2) | **GET** /api/V2/getteams | Get all available Teams
[**SecurityGetUserBatchV1**](SecurityApi.md#securitygetuserbatchv1) | **POST** /api/V1/getuserbatch | Get user information in a batch
[**SecurityGetUserByLoginIdV1**](SecurityApi.md#securitygetuserbyloginidv1) | **GET** /api/V1/getuserbyloginid/loginid/{loginid} | Get a user by login ID
[**SecurityGetUserByLoginIdV2**](SecurityApi.md#securitygetuserbyloginidv2) | **GET** /api/V2/getuserbyloginid | Get a user by login ID and login ID type
[**SecurityGetUserByLoginIdV3**](SecurityApi.md#securitygetuserbyloginidv3) | **GET** /api/V3/getuserbyloginid | Get a user by login ID and login ID type
[**SecurityGetUserByPublicIdV1**](SecurityApi.md#securitygetuserbypublicidv1) | **GET** /api/V1/getuserbypublicid/publicid/{publicid} | Get a user by public ID
[**SecurityGetUserByPublicIdV2**](SecurityApi.md#securitygetuserbypublicidv2) | **GET** /api/V2/getuserbypublicid/publicid/{publicid} | Get a user by public ID
[**SecurityGetUsersInSecurityGroupV1**](SecurityApi.md#securitygetusersinsecuritygroupv1) | **GET** /api/V1/getusersinsecuritygroup/groupid/{groupid} | Get users in a Security Group
[**SecurityGetUsersInSecurityGroupV2**](SecurityApi.md#securitygetusersinsecuritygroupv2) | **GET** /api/V2/getusersinsecuritygroup/groupid/{groupid} | Get users in a Security Group
[**SecurityGetUsersTeamsV1**](SecurityApi.md#securitygetusersteamsv1) | **GET** /api/V1/getusersteams/userrecordid/{userRecordId} | Get Team assignments for a user
[**SecurityGetUsersTeamsV2**](SecurityApi.md#securitygetusersteamsv2) | **GET** /api/V2/getusersteams/userrecordid/{userRecordId} | Get Team assignments for a user
[**SecurityGetWorkgroupsV1**](SecurityApi.md#securitygetworkgroupsv1) | **GET** /api/V1/getworkgroups | Get all available Workgroups
[**SecurityGetWorkgroupsV2**](SecurityApi.md#securitygetworkgroupsv2) | **GET** /api/V2/getworkgroups | Get all available Workgroups
[**SecurityRemoveUserFromTeamV1**](SecurityApi.md#securityremoveuserfromteamv1) | **DELETE** /api/V1/removeuserfromteam/teamid/{teamId}/userrecordid/{userrecordid} | Remove a user from a team
[**SecurityRemoveUserFromTeamV2**](SecurityApi.md#securityremoveuserfromteamv2) | **DELETE** /api/V2/removeuserfromteam/teamid/{teamId}/userrecordid/{userrecordid} | Remove a user from a team
[**SecuritySaveTeamV1**](SecurityApi.md#securitysaveteamv1) | **POST** /api/V1/saveteam | Create or update a team
[**SecuritySaveUserBatchV1**](SecurityApi.md#securitysaveuserbatchv1) | **POST** /api/V1/saveuserbatch | Create or update users in a batch
[**SecuritySaveUserBatchV2**](SecurityApi.md#securitysaveuserbatchv2) | **POST** /api/V2/saveuserbatch | Create or update users in a batch
[**SecuritySaveUserV1**](SecurityApi.md#securitysaveuserv1) | **POST** /api/V1/saveuser | Create or update a user
[**SecuritySaveUserV2**](SecurityApi.md#securitysaveuserv2) | **POST** /api/V2/saveuser | Create or update a user


<a name="securityaddusertoteambybatchv1"></a>
# **SecurityAddUserToTeamByBatchV1**
> AddUserToTeamByBatchResponse SecurityAddUserToTeamByBatchV1 (AddUserToTeamByBatchRequest request)

Add users to a team by batch

Operation to add users to a Team by batch. To get internal IDs for users, use “Get User Information in a Batch.” To get a Team's internal ID, use \"Get all available Teams.\"

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SecurityAddUserToTeamByBatchV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();
            var request = new AddUserToTeamByBatchRequest(); // AddUserToTeamByBatchRequest | Request object to specify a list of add user to team request objects.

            try
            {
                // Add users to a team by batch
                AddUserToTeamByBatchResponse result = apiInstance.SecurityAddUserToTeamByBatchV1(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityAddUserToTeamByBatchV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**AddUserToTeamByBatchRequest**](AddUserToTeamByBatchRequest.md)| Request object to specify a list of add user to team request objects. | 

### Return type

[**AddUserToTeamByBatchResponse**](AddUserToTeamByBatchResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securityaddusertoteamv1"></a>
# **SecurityAddUserToTeamV1**
> void SecurityAddUserToTeamV1 (AddUserToTeamRequest dataRequest)

Add a user to a team

Operation to add a user to a Team. To get the user's internal ID, use \"Get a user by login ID\" or \"Get a user by public ID.\" To get a Team's internal ID, use \"Get all available Teams.\"

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SecurityAddUserToTeamV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();
            var dataRequest = new AddUserToTeamRequest(); // AddUserToTeamRequest | Request object to specify user and team values.

            try
            {
                // Add a user to a team
                apiInstance.SecurityAddUserToTeamV1(dataRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityAddUserToTeamV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dataRequest** | [**AddUserToTeamRequest**](AddUserToTeamRequest.md)| Request object to specify user and team values. | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securityaddusertoteamv2"></a>
# **SecurityAddUserToTeamV2**
> AddUserToTeamResponse SecurityAddUserToTeamV2 (AddUserToTeamRequest dataRequest)

Add a user to a team

Operation to add a user to a Team. To get the user's internal ID, use \"Get a user by login ID\" or \"Get a user by public ID.\" To get a Team's internal ID, use \"Get all available Teams.\"

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SecurityAddUserToTeamV2Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();
            var dataRequest = new AddUserToTeamRequest(); // AddUserToTeamRequest | Request object to specify user and team values.

            try
            {
                // Add a user to a team
                AddUserToTeamResponse result = apiInstance.SecurityAddUserToTeamV2(dataRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityAddUserToTeamV2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dataRequest** | [**AddUserToTeamRequest**](AddUserToTeamRequest.md)| Request object to specify user and team values. | 

### Return type

[**AddUserToTeamResponse**](AddUserToTeamResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securitydeleteuserbatchv1"></a>
# **SecurityDeleteUserBatchV1**
> UserBatchDeleteResponse SecurityDeleteUserBatchV1 (UserBatchDeleteRequest request)

Delete a batch of users

Operation to delete a batch of users. To get record IDs, use \"Get a user by login ID\" or \"Get a user by public id.\"

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SecurityDeleteUserBatchV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();
            var request = new UserBatchDeleteRequest(); // UserBatchDeleteRequest | Request object listing record IDs for users to be deleted and an error flag.

            try
            {
                // Delete a batch of users
                UserBatchDeleteResponse result = apiInstance.SecurityDeleteUserBatchV1(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityDeleteUserBatchV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**UserBatchDeleteRequest**](UserBatchDeleteRequest.md)| Request object listing record IDs for users to be deleted and an error flag. | 

### Return type

[**UserBatchDeleteResponse**](UserBatchDeleteResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securitydeleteuserbatchv2"></a>
# **SecurityDeleteUserBatchV2**
> UserBatchDeleteV2Response SecurityDeleteUserBatchV2 (UserBatchDeleteRequest request)

Delete a batch of users

Operation to delete a batch of users. To get record IDs, use \"Get a user by login ID\" or \"Get a user by public id.\"

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SecurityDeleteUserBatchV2Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();
            var request = new UserBatchDeleteRequest(); // UserBatchDeleteRequest | Request object listing record IDs for users to be deleted and an error flag.

            try
            {
                // Delete a batch of users
                UserBatchDeleteV2Response result = apiInstance.SecurityDeleteUserBatchV2(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityDeleteUserBatchV2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**UserBatchDeleteRequest**](UserBatchDeleteRequest.md)| Request object listing record IDs for users to be deleted and an error flag. | 

### Return type

[**UserBatchDeleteV2Response**](UserBatchDeleteV2Response.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securitydeleteuserv1"></a>
# **SecurityDeleteUserV1**
> UserDeleteResponse SecurityDeleteUserV1 (string userrecordid)

Delete a user by record ID

Operation to delete a user by record ID. To get record IDs, use \"Get a user by login ID\" or \"Get a user by public id.\"

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SecurityDeleteUserV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();
            var userrecordid = userrecordid_example;  // string | Specify the record ID of the user you want to delete

            try
            {
                // Delete a user by record ID
                UserDeleteResponse result = apiInstance.SecurityDeleteUserV1(userrecordid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityDeleteUserV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userrecordid** | **string**| Specify the record ID of the user you want to delete | 

### Return type

[**UserDeleteResponse**](UserDeleteResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securitydeleteuserv2"></a>
# **SecurityDeleteUserV2**
> UserDeleteV2Response SecurityDeleteUserV2 (string userrecordid)

Delete a user by record ID

Operation to delete a user by record ID. To get record IDs, use \"Get a user by login ID\" or \"Get a user by public id.\"

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SecurityDeleteUserV2Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();
            var userrecordid = userrecordid_example;  // string | Specify the record ID of the user you want to delete

            try
            {
                // Delete a user by record ID
                UserDeleteV2Response result = apiInstance.SecurityDeleteUserV2(userrecordid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityDeleteUserV2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userrecordid** | **string**| Specify the record ID of the user you want to delete | 

### Return type

[**UserDeleteV2Response**](UserDeleteV2Response.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securitygetrolesv1"></a>
# **SecurityGetRolesV1**
> RoleReadResponse SecurityGetRolesV1 ()

Get all available Roles

Operation to get all available Roles.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SecurityGetRolesV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();

            try
            {
                // Get all available Roles
                RoleReadResponse result = apiInstance.SecurityGetRolesV1();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityGetRolesV1: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**RoleReadResponse**](RoleReadResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securitygetrolesv2"></a>
# **SecurityGetRolesV2**
> RoleReadV2Response SecurityGetRolesV2 ()

Get all available Roles

Operation to get all available Roles.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SecurityGetRolesV2Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();

            try
            {
                // Get all available Roles
                RoleReadV2Response result = apiInstance.SecurityGetRolesV2();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityGetRolesV2: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**RoleReadV2Response**](RoleReadV2Response.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securitygetsecuritygroupbusinessobjectpermissionsbybusobidv1"></a>
# **SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV1**
> List<BusinessObjectPermission> SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV1 (string groupid, string busObId)

Get Business Object permissions by Security Group

Operation to get specific Business Object permissions for a Security Group. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();
            var groupid = groupid_example;  // string | Specify the Security Group ID. 
            var busObId = busObId_example;  // string | Specify the Business Object ID.

            try
            {
                // Get Business Object permissions by Security Group
                List&lt;BusinessObjectPermission&gt; result = apiInstance.SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV1(groupid, busObId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupid** | **string**| Specify the Security Group ID.  | 
 **busObId** | **string**| Specify the Business Object ID. | 

### Return type

[**List<BusinessObjectPermission>**](BusinessObjectPermission.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securitygetsecuritygroupbusinessobjectpermissionsbybusobidv2"></a>
# **SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV2**
> GetSecurityGroupBusinessObjectPermissionsResponse SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV2 (string groupid, string busObId)

Get Business Object permissions by Security Group

Operation to get specific Business Object permissions for a Security Group. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV2Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();
            var groupid = groupid_example;  // string | Specify the Security Group ID. 
            var busObId = busObId_example;  // string | Specify the Business Object ID.

            try
            {
                // Get Business Object permissions by Security Group
                GetSecurityGroupBusinessObjectPermissionsResponse result = apiInstance.SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV2(groupid, busObId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupid** | **string**| Specify the Security Group ID.  | 
 **busObId** | **string**| Specify the Business Object ID. | 

### Return type

[**GetSecurityGroupBusinessObjectPermissionsResponse**](GetSecurityGroupBusinessObjectPermissionsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securitygetsecuritygroupbusinessobjectpermissionsbybusobnamev1"></a>
# **SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV1**
> List<BusinessObjectPermission> SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV1 (string groupname, string busobname)

Get Business Object permissions by Security Group

Operation to get specific Business Object permissions for a Security Group. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();
            var groupname = groupname_example;  // string | Specify the Security Group name. 
            var busobname = busobname_example;  // string | Specify the Business Object name.

            try
            {
                // Get Business Object permissions by Security Group
                List&lt;BusinessObjectPermission&gt; result = apiInstance.SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV1(groupname, busobname);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupname** | **string**| Specify the Security Group name.  | 
 **busobname** | **string**| Specify the Business Object name. | 

### Return type

[**List<BusinessObjectPermission>**](BusinessObjectPermission.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securitygetsecuritygroupbusinessobjectpermissionsbybusobnamev2"></a>
# **SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV2**
> GetSecurityGroupBusinessObjectPermissionsResponse SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV2 (string groupname, string busobname)

Get Business Object permissions by Security Group

Operation to get specific Business Object permissions for a Security Group. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV2Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();
            var groupname = groupname_example;  // string | Specify the Security Group name. 
            var busobname = busobname_example;  // string | Specify the Business Object name.

            try
            {
                // Get Business Object permissions by Security Group
                GetSecurityGroupBusinessObjectPermissionsResponse result = apiInstance.SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV2(groupname, busobname);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupname** | **string**| Specify the Security Group name.  | 
 **busobname** | **string**| Specify the Business Object name. | 

### Return type

[**GetSecurityGroupBusinessObjectPermissionsResponse**](GetSecurityGroupBusinessObjectPermissionsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securitygetsecuritygroupbusinessobjectpermissionsforcurrentuserbybusobidv1"></a>
# **SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV1**
> List<BusinessObjectPermission> SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV1 (string busObId)

Get Business Object permission for current user

Operation to get Business Object permissions for the currently logged-in user's Security Group.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();
            var busObId = busObId_example;  // string | Specify the Business Object ID.

            try
            {
                // Get Business Object permission for current user
                List&lt;BusinessObjectPermission&gt; result = apiInstance.SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV1(busObId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **busObId** | **string**| Specify the Business Object ID. | 

### Return type

[**List<BusinessObjectPermission>**](BusinessObjectPermission.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securitygetsecuritygroupbusinessobjectpermissionsforcurrentuserbybusobidv2"></a>
# **SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV2**
> GetSecurityGroupBusinessObjectPermissionsResponse SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV2 (string busObId)

Get Business Object permission for current user

Operation to get Business Object permissions for the currently logged-in user's Security Group.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV2Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();
            var busObId = busObId_example;  // string | Specify the Business Object ID.

            try
            {
                // Get Business Object permission for current user
                GetSecurityGroupBusinessObjectPermissionsResponse result = apiInstance.SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV2(busObId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **busObId** | **string**| Specify the Business Object ID. | 

### Return type

[**GetSecurityGroupBusinessObjectPermissionsResponse**](GetSecurityGroupBusinessObjectPermissionsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securitygetsecuritygroupbusinessobjectpermissionsforcurrentuserbybusobnamev1"></a>
# **SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV1**
> List<BusinessObjectPermission> SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV1 (string busobname)

Get Business Object permissions for current user

Operation to get Business Object permissions for currently logged in user's Security Group.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();
            var busobname = busobname_example;  // string | Specify the Business Object name.

            try
            {
                // Get Business Object permissions for current user
                List&lt;BusinessObjectPermission&gt; result = apiInstance.SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV1(busobname);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **busobname** | **string**| Specify the Business Object name. | 

### Return type

[**List<BusinessObjectPermission>**](BusinessObjectPermission.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securitygetsecuritygroupbusinessobjectpermissionsforcurrentuserbybusobnamev2"></a>
# **SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV2**
> GetSecurityGroupBusinessObjectPermissionsResponse SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV2 (string busobname)

Get Business Object permissions for current user

Operation to get Business Object permissions for currently logged in user's Security Group.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV2Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();
            var busobname = busobname_example;  // string | Specify the Business Object name.

            try
            {
                // Get Business Object permissions for current user
                GetSecurityGroupBusinessObjectPermissionsResponse result = apiInstance.SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV2(busobname);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **busobname** | **string**| Specify the Business Object name. | 

### Return type

[**GetSecurityGroupBusinessObjectPermissionsResponse**](GetSecurityGroupBusinessObjectPermissionsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securitygetsecuritygroupcategoriesv1"></a>
# **SecurityGetSecurityGroupCategoriesV1**
> List<RightCategory> SecurityGetSecurityGroupCategoriesV1 ()

Get all Security Group categories

Operation to get IDs and names for all available Security Group categories. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SecurityGetSecurityGroupCategoriesV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();

            try
            {
                // Get all Security Group categories
                List&lt;RightCategory&gt; result = apiInstance.SecurityGetSecurityGroupCategoriesV1();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityGetSecurityGroupCategoriesV1: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<RightCategory>**](RightCategory.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securitygetsecuritygroupcategoriesv2"></a>
# **SecurityGetSecurityGroupCategoriesV2**
> SecurityRightCategoriesResponse SecurityGetSecurityGroupCategoriesV2 ()

Get all Security Group categories

Operation to get IDs and names for all available Security Group categories. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SecurityGetSecurityGroupCategoriesV2Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();

            try
            {
                // Get all Security Group categories
                SecurityRightCategoriesResponse result = apiInstance.SecurityGetSecurityGroupCategoriesV2();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityGetSecurityGroupCategoriesV2: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**SecurityRightCategoriesResponse**](SecurityRightCategoriesResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securitygetsecuritygrouprightsbygroupidandcategoryidv1"></a>
# **SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV1**
> List<Right> SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV1 (string groupid, string categoryid)

Get permissions for a Security Group by category

Operation to get permissions for a Security Group by category. To get Security Group IDs, use \"Get all available Security Groups.\" To get Security Group category IDs, use \"Get all Security Group categories.\"

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();
            var groupid = groupid_example;  // string | Specify the Security Group ID
            var categoryid = categoryid_example;  // string | Specify the Security Group category ID

            try
            {
                // Get permissions for a Security Group by category
                List&lt;Right&gt; result = apiInstance.SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV1(groupid, categoryid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupid** | **string**| Specify the Security Group ID | 
 **categoryid** | **string**| Specify the Security Group category ID | 

### Return type

[**List<Right>**](Right.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securitygetsecuritygrouprightsbygroupidandcategoryidv2"></a>
# **SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV2**
> SecurityRightsResponse SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV2 (string groupid, string categoryid)

Get permissions for a Security Group by category

Operation to get permissions for a Security Group by category. To get Security Group IDs, use \"Get all available Security Groups.\" To get Security Group category IDs, use \"Get all Security Group categories.\"

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV2Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();
            var groupid = groupid_example;  // string | Specify the Security Group ID
            var categoryid = categoryid_example;  // string | Specify the Security Group category ID

            try
            {
                // Get permissions for a Security Group by category
                SecurityRightsResponse result = apiInstance.SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV2(groupid, categoryid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupid** | **string**| Specify the Security Group ID | 
 **categoryid** | **string**| Specify the Security Group category ID | 

### Return type

[**SecurityRightsResponse**](SecurityRightsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securitygetsecuritygrouprightsbygroupnameandcategorynamev1"></a>
# **SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV1**
> List<Right> SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV1 (string groupname, string categoryname)

Get permissions for a Security Group by category

Operation to get permissions for a Security Group by category.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();
            var groupname = groupname_example;  // string | Specify the Security Group name.
            var categoryname = categoryname_example;  // string | Specify the Security Group category name.

            try
            {
                // Get permissions for a Security Group by category
                List&lt;Right&gt; result = apiInstance.SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV1(groupname, categoryname);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupname** | **string**| Specify the Security Group name. | 
 **categoryname** | **string**| Specify the Security Group category name. | 

### Return type

[**List<Right>**](Right.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securitygetsecuritygrouprightsbygroupnameandcategorynamev2"></a>
# **SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV2**
> SecurityRightsResponse SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV2 (string groupname, string categoryname)

Get permissions for a Security Group by category

Operation to get permissions for a Security Group by category.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV2Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();
            var groupname = groupname_example;  // string | Specify the Security Group name.
            var categoryname = categoryname_example;  // string | Specify the Security Group category name.

            try
            {
                // Get permissions for a Security Group by category
                SecurityRightsResponse result = apiInstance.SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV2(groupname, categoryname);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupname** | **string**| Specify the Security Group name. | 
 **categoryname** | **string**| Specify the Security Group category name. | 

### Return type

[**SecurityRightsResponse**](SecurityRightsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securitygetsecuritygrouprightsforcurrentuserbycategoryidv1"></a>
# **SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV1**
> List<Right> SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV1 (string categoryid)

Get current user's permissions by Security Group category by ID

Operation to get permissions for the current user's Security Group by category. To get Security Group category IDs, use \"Get all Security Group categories.\"

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();
            var categoryid = categoryid_example;  // string | Specify the Security Group category ID.

            try
            {
                // Get current user's permissions by Security Group category by ID
                List&lt;Right&gt; result = apiInstance.SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV1(categoryid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **categoryid** | **string**| Specify the Security Group category ID. | 

### Return type

[**List<Right>**](Right.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securitygetsecuritygrouprightsforcurrentuserbycategoryidv2"></a>
# **SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV2**
> SecurityRightsResponse SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV2 (string categoryid)

Get current user's permissions by Security Group category by ID

Operation to get permissions for the current user's Security Group by category. To get Security Group category IDs, use \"Get all Security Group categories.\"

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV2Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();
            var categoryid = categoryid_example;  // string | Specify the Security Group category ID.

            try
            {
                // Get current user's permissions by Security Group category by ID
                SecurityRightsResponse result = apiInstance.SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV2(categoryid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **categoryid** | **string**| Specify the Security Group category ID. | 

### Return type

[**SecurityRightsResponse**](SecurityRightsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securitygetsecuritygrouprightsforcurrentuserbycategorynamev1"></a>
# **SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV1**
> List<Right> SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV1 (string categoryname)

Get current user's permissions by Security Group category by name

Operation to get permissions for the current user's Security Group by category.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();
            var categoryname = categoryname_example;  // string | Specify the Security Group category name.

            try
            {
                // Get current user's permissions by Security Group category by name
                List&lt;Right&gt; result = apiInstance.SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV1(categoryname);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **categoryname** | **string**| Specify the Security Group category name. | 

### Return type

[**List<Right>**](Right.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securitygetsecuritygrouprightsforcurrentuserbycategorynamev2"></a>
# **SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV2**
> SecurityRightsResponse SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV2 (string categoryname)

Get current user's permissions by Security Group category by name

Operation to get permissions for the current user's Security Group by category.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV2Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();
            var categoryname = categoryname_example;  // string | Specify the Security Group category name.

            try
            {
                // Get current user's permissions by Security Group category by name
                SecurityRightsResponse result = apiInstance.SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV2(categoryname);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **categoryname** | **string**| Specify the Security Group category name. | 

### Return type

[**SecurityRightsResponse**](SecurityRightsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securitygetsecuritygroupsv1"></a>
# **SecurityGetSecurityGroupsV1**
> SecurityGroupResponse SecurityGetSecurityGroupsV1 ()

Get all available Security Groups

Operation to get IDs, names, and descriptions for all available Security Groups.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SecurityGetSecurityGroupsV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();

            try
            {
                // Get all available Security Groups
                SecurityGroupResponse result = apiInstance.SecurityGetSecurityGroupsV1();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityGetSecurityGroupsV1: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**SecurityGroupResponse**](SecurityGroupResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securitygetsecuritygroupsv2"></a>
# **SecurityGetSecurityGroupsV2**
> SecurityGroupV2Response SecurityGetSecurityGroupsV2 ()

Get all available Security Groups

Operation to get IDs, names, and descriptions for all available Security Groups.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SecurityGetSecurityGroupsV2Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();

            try
            {
                // Get all available Security Groups
                SecurityGroupV2Response result = apiInstance.SecurityGetSecurityGroupsV2();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityGetSecurityGroupsV2: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**SecurityGroupV2Response**](SecurityGroupV2Response.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securitygetteamsv1"></a>
# **SecurityGetTeamsV1**
> TeamsResponse SecurityGetTeamsV1 ()

Get all available Teams

Operation to get IDs and names for all available Teams.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SecurityGetTeamsV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();

            try
            {
                // Get all available Teams
                TeamsResponse result = apiInstance.SecurityGetTeamsV1();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityGetTeamsV1: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**TeamsResponse**](TeamsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securitygetteamsv2"></a>
# **SecurityGetTeamsV2**
> TeamsV2Response SecurityGetTeamsV2 ()

Get all available Teams

Operation to get IDs and names for all available Teams.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SecurityGetTeamsV2Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();

            try
            {
                // Get all available Teams
                TeamsV2Response result = apiInstance.SecurityGetTeamsV2();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityGetTeamsV2: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**TeamsV2Response**](TeamsV2Response.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securitygetuserbatchv1"></a>
# **SecurityGetUserBatchV1**
> UserBatchReadResponse SecurityGetUserBatchV1 (UserBatchReadRequest request)

Get user information in a batch

Operation to get user information in a batch. To get record IDs, use \"Get a user by login ID\" or \"Get a user by public id.\"

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SecurityGetUserBatchV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();
            var request = new UserBatchReadRequest(); // UserBatchReadRequest | Request object that lists user record IDs or public IDs of users and an error flag.

            try
            {
                // Get user information in a batch
                UserBatchReadResponse result = apiInstance.SecurityGetUserBatchV1(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityGetUserBatchV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**UserBatchReadRequest**](UserBatchReadRequest.md)| Request object that lists user record IDs or public IDs of users and an error flag. | 

### Return type

[**UserBatchReadResponse**](UserBatchReadResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securitygetuserbyloginidv1"></a>
# **SecurityGetUserByLoginIdV1**
> User SecurityGetUserByLoginIdV1 (string loginid)

Get a user by login ID

Operation to get detailed user information by login ID. Use to get user record IDs and account settings, for example. This operation has been deprecated by a V2 operation of the same name, but with query string parameters.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SecurityGetUserByLoginIdV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();
            var loginid = loginid_example;  // string | Specify the user's login ID.

            try
            {
                // Get a user by login ID
                User result = apiInstance.SecurityGetUserByLoginIdV1(loginid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityGetUserByLoginIdV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loginid** | **string**| Specify the user&#39;s login ID. | 

### Return type

[**User**](User.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securitygetuserbyloginidv2"></a>
# **SecurityGetUserByLoginIdV2**
> User SecurityGetUserByLoginIdV2 (string loginid, string loginidtype)

Get a user by login ID and login ID type

Operation to get detailed user information by login ID. Use to get user record IDs and account settings, for example.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SecurityGetUserByLoginIdV2Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();
            var loginid = loginid_example;  // string | Specify the user's login ID.
            var loginidtype = loginidtype_example;  // string | Specify the login ID type.

            try
            {
                // Get a user by login ID and login ID type
                User result = apiInstance.SecurityGetUserByLoginIdV2(loginid, loginidtype);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityGetUserByLoginIdV2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loginid** | **string**| Specify the user&#39;s login ID. | 
 **loginidtype** | **string**| Specify the login ID type. | 

### Return type

[**User**](User.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securitygetuserbyloginidv3"></a>
# **SecurityGetUserByLoginIdV3**
> UserV2 SecurityGetUserByLoginIdV3 (string loginid, string loginidtype)

Get a user by login ID and login ID type

Operation to get detailed user information by login ID. Use to get user record IDs and account settings, for example.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SecurityGetUserByLoginIdV3Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();
            var loginid = loginid_example;  // string | Specify the user's login ID.
            var loginidtype = loginidtype_example;  // string | Specify the login ID type.

            try
            {
                // Get a user by login ID and login ID type
                UserV2 result = apiInstance.SecurityGetUserByLoginIdV3(loginid, loginidtype);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityGetUserByLoginIdV3: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loginid** | **string**| Specify the user&#39;s login ID. | 
 **loginidtype** | **string**| Specify the login ID type. | 

### Return type

[**UserV2**](UserV2.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securitygetuserbypublicidv1"></a>
# **SecurityGetUserByPublicIdV1**
> UserReadResponse SecurityGetUserByPublicIdV1 (string publicid)

Get a user by public ID

Operation to get a user by public ID. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SecurityGetUserByPublicIdV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();
            var publicid = publicid_example;  // string | Specify the user's public ID.

            try
            {
                // Get a user by public ID
                UserReadResponse result = apiInstance.SecurityGetUserByPublicIdV1(publicid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityGetUserByPublicIdV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **publicid** | **string**| Specify the user&#39;s public ID. | 

### Return type

[**UserReadResponse**](UserReadResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securitygetuserbypublicidv2"></a>
# **SecurityGetUserByPublicIdV2**
> UserReadV2Response SecurityGetUserByPublicIdV2 (string publicid)

Get a user by public ID

Operation to get a user by public ID. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SecurityGetUserByPublicIdV2Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();
            var publicid = publicid_example;  // string | Specify the user's public ID.

            try
            {
                // Get a user by public ID
                UserReadV2Response result = apiInstance.SecurityGetUserByPublicIdV2(publicid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityGetUserByPublicIdV2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **publicid** | **string**| Specify the user&#39;s public ID. | 

### Return type

[**UserReadV2Response**](UserReadV2Response.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securitygetusersinsecuritygroupv1"></a>
# **SecurityGetUsersInSecurityGroupV1**
> List<User> SecurityGetUsersInSecurityGroupV1 (string groupid)

Get users in a Security Group

Operation to get the users in a specified Security Group. Use \"Get all available Security Groups\" to get Security Group record IDs. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SecurityGetUsersInSecurityGroupV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();
            var groupid = groupid_example;  // string | Specify the Security Group ID.

            try
            {
                // Get users in a Security Group
                List&lt;User&gt; result = apiInstance.SecurityGetUsersInSecurityGroupV1(groupid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityGetUsersInSecurityGroupV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupid** | **string**| Specify the Security Group ID. | 

### Return type

[**List<User>**](User.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securitygetusersinsecuritygroupv2"></a>
# **SecurityGetUsersInSecurityGroupV2**
> UserReadV2Response SecurityGetUsersInSecurityGroupV2 (string groupid)

Get users in a Security Group

Operation to get the users in a specified Security Group. Use \"Get all available Security Groups\" to get Security Group record IDs. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SecurityGetUsersInSecurityGroupV2Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();
            var groupid = groupid_example;  // string | Specify the Security Group ID.

            try
            {
                // Get users in a Security Group
                UserReadV2Response result = apiInstance.SecurityGetUsersInSecurityGroupV2(groupid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityGetUsersInSecurityGroupV2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupid** | **string**| Specify the Security Group ID. | 

### Return type

[**UserReadV2Response**](UserReadV2Response.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securitygetusersteamsv1"></a>
# **SecurityGetUsersTeamsV1**
> TeamsResponse SecurityGetUsersTeamsV1 (string userRecordId)

Get Team assignments for a user

Operation to get Team assignments for a user. To get record IDs, use \"Get a user by login ID\" or \"Get a user by public id.\"

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SecurityGetUsersTeamsV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();
            var userRecordId = userRecordId_example;  // string | Specify the user record ID.

            try
            {
                // Get Team assignments for a user
                TeamsResponse result = apiInstance.SecurityGetUsersTeamsV1(userRecordId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityGetUsersTeamsV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userRecordId** | **string**| Specify the user record ID. | 

### Return type

[**TeamsResponse**](TeamsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securitygetusersteamsv2"></a>
# **SecurityGetUsersTeamsV2**
> TeamsV2Response SecurityGetUsersTeamsV2 (string userRecordId)

Get Team assignments for a user

Operation to get Team assignments for a user. To get record IDs, use \"Get a user by login ID\" or \"Get a user by public id.\"

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SecurityGetUsersTeamsV2Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();
            var userRecordId = userRecordId_example;  // string | Specify the user record ID.

            try
            {
                // Get Team assignments for a user
                TeamsV2Response result = apiInstance.SecurityGetUsersTeamsV2(userRecordId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityGetUsersTeamsV2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userRecordId** | **string**| Specify the user record ID. | 

### Return type

[**TeamsV2Response**](TeamsV2Response.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securitygetworkgroupsv1"></a>
# **SecurityGetWorkgroupsV1**
> TeamsResponse SecurityGetWorkgroupsV1 ()

Get all available Workgroups

Operation to get IDs and names for all available Workgroups.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SecurityGetWorkgroupsV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();

            try
            {
                // Get all available Workgroups
                TeamsResponse result = apiInstance.SecurityGetWorkgroupsV1();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityGetWorkgroupsV1: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**TeamsResponse**](TeamsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securitygetworkgroupsv2"></a>
# **SecurityGetWorkgroupsV2**
> TeamsV2Response SecurityGetWorkgroupsV2 ()

Get all available Workgroups

Operation to get IDs and names for all available Workgroups.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SecurityGetWorkgroupsV2Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();

            try
            {
                // Get all available Workgroups
                TeamsV2Response result = apiInstance.SecurityGetWorkgroupsV2();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityGetWorkgroupsV2: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**TeamsV2Response**](TeamsV2Response.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securityremoveuserfromteamv1"></a>
# **SecurityRemoveUserFromTeamV1**
> void SecurityRemoveUserFromTeamV1 (string teamId, string userrecordid)

Remove a user from a team

Operation to remove a user from a Team. To get the user's record ID, use \"Get a user by login ID\" or \"Get a user by public ID.\" To get a Team's internal ID, use \"Get all available Teams.\"

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SecurityRemoveUserFromTeamV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();
            var teamId = teamId_example;  // string | Specify the internal ID of the Team you want to remove the user from
            var userrecordid = userrecordid_example;  // string | Specify the record ID of the user you want to remove from the Team.

            try
            {
                // Remove a user from a team
                apiInstance.SecurityRemoveUserFromTeamV1(teamId, userrecordid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityRemoveUserFromTeamV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **string**| Specify the internal ID of the Team you want to remove the user from | 
 **userrecordid** | **string**| Specify the record ID of the user you want to remove from the Team. | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securityremoveuserfromteamv2"></a>
# **SecurityRemoveUserFromTeamV2**
> RemoveUserFromTeamResponse SecurityRemoveUserFromTeamV2 (string teamId, string userrecordid)

Remove a user from a team

Operation to remove a user from a Team. To get the user's record ID, use \"Get a user by login ID\" or \"Get a user by public ID.\" To get a Team's internal ID, use \"Get all available Teams.\"

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SecurityRemoveUserFromTeamV2Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();
            var teamId = teamId_example;  // string | Specify the internal ID of the Team you want to remove the user from
            var userrecordid = userrecordid_example;  // string | Specify the record ID of the user you want to remove from the Team.

            try
            {
                // Remove a user from a team
                RemoveUserFromTeamResponse result = apiInstance.SecurityRemoveUserFromTeamV2(teamId, userrecordid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityRemoveUserFromTeamV2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **string**| Specify the internal ID of the Team you want to remove the user from | 
 **userrecordid** | **string**| Specify the record ID of the user you want to remove from the Team. | 

### Return type

[**RemoveUserFromTeamResponse**](RemoveUserFromTeamResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securitysaveteamv1"></a>
# **SecuritySaveTeamV1**
> TeamSaveResponse SecuritySaveTeamV1 (TeamSaveRequest request)

Create or update a team

Operation to create or update a Team or Workgroup. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SecuritySaveTeamV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();
            var request = new TeamSaveRequest(); // TeamSaveRequest | Request object to create Teams or Workgroups. To create a Team, use teamType and teamName. To update a team, use teamID. Team type values must be User or CustomerWorkgroup. The teamType cannot be changed for existing Teams or Workgroups.

            try
            {
                // Create or update a team
                TeamSaveResponse result = apiInstance.SecuritySaveTeamV1(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecuritySaveTeamV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**TeamSaveRequest**](TeamSaveRequest.md)| Request object to create Teams or Workgroups. To create a Team, use teamType and teamName. To update a team, use teamID. Team type values must be User or CustomerWorkgroup. The teamType cannot be changed for existing Teams or Workgroups. | 

### Return type

[**TeamSaveResponse**](TeamSaveResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securitysaveuserbatchv1"></a>
# **SecuritySaveUserBatchV1**
> UserBatchSaveResponse SecuritySaveUserBatchV1 (UserBatchSaveRequest request)

Create or update users in a batch

Operation to create or update users in a batch. To update, specify record ID. To create, leave record ID empty.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SecuritySaveUserBatchV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();
            var request = new UserBatchSaveRequest(); // UserBatchSaveRequest | Request object listing user record IDs and an error flag.

            try
            {
                // Create or update users in a batch
                UserBatchSaveResponse result = apiInstance.SecuritySaveUserBatchV1(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecuritySaveUserBatchV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**UserBatchSaveRequest**](UserBatchSaveRequest.md)| Request object listing user record IDs and an error flag. | 

### Return type

[**UserBatchSaveResponse**](UserBatchSaveResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securitysaveuserbatchv2"></a>
# **SecuritySaveUserBatchV2**
> UserBatchSaveV2Response SecuritySaveUserBatchV2 (UserBatchSaveV2Request request)

Create or update users in a batch

Operation to create or update users in a batch. To update, specify record ID. To create, leave record ID empty.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SecuritySaveUserBatchV2Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();
            var request = new UserBatchSaveV2Request(); // UserBatchSaveV2Request | Request object listing user record IDs and an error flag.

            try
            {
                // Create or update users in a batch
                UserBatchSaveV2Response result = apiInstance.SecuritySaveUserBatchV2(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecuritySaveUserBatchV2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**UserBatchSaveV2Request**](UserBatchSaveV2Request.md)| Request object listing user record IDs and an error flag. | 

### Return type

[**UserBatchSaveV2Response**](UserBatchSaveV2Response.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securitysaveuserv1"></a>
# **SecuritySaveUserV1**
> UserSaveResponse SecuritySaveUserV1 (UserSaveRequest request)

Create or update a user

Operation to create or update a user.  The response is a collection because if you use a public ID, more than one user could be updated since public IDs may not be unique. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SecuritySaveUserV1Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();
            var request = new UserSaveRequest(); // UserSaveRequest | Request object to specify user parameters and fields with values to be created or updated. The loginId and either the busObRecId or busObPublicId are required.

            try
            {
                // Create or update a user
                UserSaveResponse result = apiInstance.SecuritySaveUserV1(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecuritySaveUserV1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**UserSaveRequest**](UserSaveRequest.md)| Request object to specify user parameters and fields with values to be created or updated. The loginId and either the busObRecId or busObPublicId are required. | 

### Return type

[**UserSaveResponse**](UserSaveResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securitysaveuserv2"></a>
# **SecuritySaveUserV2**
> UserSaveV2Response SecuritySaveUserV2 (UserSaveV2Request request)

Create or update a user

Operation to create or update a user.  The response is a collection because if you use a public ID, more than one user could be updated since public IDs may not be unique. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SecuritySaveUserV2Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();
            var request = new UserSaveV2Request(); // UserSaveV2Request | Request object to specify user parameters and fields with values to be created or updated. The loginId and either the busObRecId or busObPublicId are required.

            try
            {
                // Create or update a user
                UserSaveV2Response result = apiInstance.SecuritySaveUserV2(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecuritySaveUserV2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**UserSaveV2Request**](UserSaveV2Request.md)| Request object to specify user parameters and fields with values to be created or updated. The loginId and either the busObRecId or busObPublicId are required. | 

### Return type

[**UserSaveV2Response**](UserSaveV2Response.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

