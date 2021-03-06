/* 
 * Cherwell Rest API
 *
 * <a href=\"../../index.html\">Cherwell Rest API Documentation</a><br>Select version options from the header drop-down list (to the left of the Client Key box). Then, click Explore to view different versions of operations.
 *
 * OpenAPI spec version: 9.1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing SecurityApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SecurityApiTests
    {
        private SecurityApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SecurityApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SecurityApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SecurityApi
            //Assert.IsInstanceOfType(typeof(SecurityApi), instance, "instance is a SecurityApi");
        }

        
        /// <summary>
        /// Test SecurityAddUserToTeamByBatchV1
        /// </summary>
        [Test]
        public void SecurityAddUserToTeamByBatchV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AddUserToTeamByBatchRequest request = null;
            //var response = instance.SecurityAddUserToTeamByBatchV1(request);
            //Assert.IsInstanceOf<AddUserToTeamByBatchResponse> (response, "response is AddUserToTeamByBatchResponse");
        }
        
        /// <summary>
        /// Test SecurityAddUserToTeamV1
        /// </summary>
        [Test]
        public void SecurityAddUserToTeamV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AddUserToTeamRequest dataRequest = null;
            //instance.SecurityAddUserToTeamV1(dataRequest);
            
        }
        
        /// <summary>
        /// Test SecurityAddUserToTeamV2
        /// </summary>
        [Test]
        public void SecurityAddUserToTeamV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AddUserToTeamRequest dataRequest = null;
            //var response = instance.SecurityAddUserToTeamV2(dataRequest);
            //Assert.IsInstanceOf<AddUserToTeamResponse> (response, "response is AddUserToTeamResponse");
        }
        
        /// <summary>
        /// Test SecurityDeleteUserBatchV1
        /// </summary>
        [Test]
        public void SecurityDeleteUserBatchV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserBatchDeleteRequest request = null;
            //var response = instance.SecurityDeleteUserBatchV1(request);
            //Assert.IsInstanceOf<UserBatchDeleteResponse> (response, "response is UserBatchDeleteResponse");
        }
        
        /// <summary>
        /// Test SecurityDeleteUserBatchV2
        /// </summary>
        [Test]
        public void SecurityDeleteUserBatchV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserBatchDeleteRequest request = null;
            //var response = instance.SecurityDeleteUserBatchV2(request);
            //Assert.IsInstanceOf<UserBatchDeleteV2Response> (response, "response is UserBatchDeleteV2Response");
        }
        
        /// <summary>
        /// Test SecurityDeleteUserV1
        /// </summary>
        [Test]
        public void SecurityDeleteUserV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userrecordid = null;
            //var response = instance.SecurityDeleteUserV1(userrecordid);
            //Assert.IsInstanceOf<UserDeleteResponse> (response, "response is UserDeleteResponse");
        }
        
        /// <summary>
        /// Test SecurityDeleteUserV2
        /// </summary>
        [Test]
        public void SecurityDeleteUserV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userrecordid = null;
            //var response = instance.SecurityDeleteUserV2(userrecordid);
            //Assert.IsInstanceOf<UserDeleteV2Response> (response, "response is UserDeleteV2Response");
        }
        
        /// <summary>
        /// Test SecurityGetRolesV1
        /// </summary>
        [Test]
        public void SecurityGetRolesV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.SecurityGetRolesV1();
            //Assert.IsInstanceOf<RoleReadResponse> (response, "response is RoleReadResponse");
        }
        
        /// <summary>
        /// Test SecurityGetRolesV2
        /// </summary>
        [Test]
        public void SecurityGetRolesV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.SecurityGetRolesV2();
            //Assert.IsInstanceOf<RoleReadV2Response> (response, "response is RoleReadV2Response");
        }
        
        /// <summary>
        /// Test SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV1
        /// </summary>
        [Test]
        public void SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string groupid = null;
            //string busObId = null;
            //var response = instance.SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV1(groupid, busObId);
            //Assert.IsInstanceOf<List<BusinessObjectPermission>> (response, "response is List<BusinessObjectPermission>");
        }
        
        /// <summary>
        /// Test SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV2
        /// </summary>
        [Test]
        public void SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string groupid = null;
            //string busObId = null;
            //var response = instance.SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV2(groupid, busObId);
            //Assert.IsInstanceOf<GetSecurityGroupBusinessObjectPermissionsResponse> (response, "response is GetSecurityGroupBusinessObjectPermissionsResponse");
        }
        
        /// <summary>
        /// Test SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV1
        /// </summary>
        [Test]
        public void SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string groupname = null;
            //string busobname = null;
            //var response = instance.SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV1(groupname, busobname);
            //Assert.IsInstanceOf<List<BusinessObjectPermission>> (response, "response is List<BusinessObjectPermission>");
        }
        
        /// <summary>
        /// Test SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV2
        /// </summary>
        [Test]
        public void SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string groupname = null;
            //string busobname = null;
            //var response = instance.SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV2(groupname, busobname);
            //Assert.IsInstanceOf<GetSecurityGroupBusinessObjectPermissionsResponse> (response, "response is GetSecurityGroupBusinessObjectPermissionsResponse");
        }
        
        /// <summary>
        /// Test SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV1
        /// </summary>
        [Test]
        public void SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string busObId = null;
            //var response = instance.SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV1(busObId);
            //Assert.IsInstanceOf<List<BusinessObjectPermission>> (response, "response is List<BusinessObjectPermission>");
        }
        
        /// <summary>
        /// Test SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV2
        /// </summary>
        [Test]
        public void SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string busObId = null;
            //var response = instance.SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV2(busObId);
            //Assert.IsInstanceOf<GetSecurityGroupBusinessObjectPermissionsResponse> (response, "response is GetSecurityGroupBusinessObjectPermissionsResponse");
        }
        
        /// <summary>
        /// Test SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV1
        /// </summary>
        [Test]
        public void SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string busobname = null;
            //var response = instance.SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV1(busobname);
            //Assert.IsInstanceOf<List<BusinessObjectPermission>> (response, "response is List<BusinessObjectPermission>");
        }
        
        /// <summary>
        /// Test SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV2
        /// </summary>
        [Test]
        public void SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string busobname = null;
            //var response = instance.SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV2(busobname);
            //Assert.IsInstanceOf<GetSecurityGroupBusinessObjectPermissionsResponse> (response, "response is GetSecurityGroupBusinessObjectPermissionsResponse");
        }
        
        /// <summary>
        /// Test SecurityGetSecurityGroupCategoriesV1
        /// </summary>
        [Test]
        public void SecurityGetSecurityGroupCategoriesV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.SecurityGetSecurityGroupCategoriesV1();
            //Assert.IsInstanceOf<List<RightCategory>> (response, "response is List<RightCategory>");
        }
        
        /// <summary>
        /// Test SecurityGetSecurityGroupCategoriesV2
        /// </summary>
        [Test]
        public void SecurityGetSecurityGroupCategoriesV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.SecurityGetSecurityGroupCategoriesV2();
            //Assert.IsInstanceOf<SecurityRightCategoriesResponse> (response, "response is SecurityRightCategoriesResponse");
        }
        
        /// <summary>
        /// Test SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV1
        /// </summary>
        [Test]
        public void SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string groupid = null;
            //string categoryid = null;
            //var response = instance.SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV1(groupid, categoryid);
            //Assert.IsInstanceOf<List<Right>> (response, "response is List<Right>");
        }
        
        /// <summary>
        /// Test SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV2
        /// </summary>
        [Test]
        public void SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string groupid = null;
            //string categoryid = null;
            //var response = instance.SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV2(groupid, categoryid);
            //Assert.IsInstanceOf<SecurityRightsResponse> (response, "response is SecurityRightsResponse");
        }
        
        /// <summary>
        /// Test SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV1
        /// </summary>
        [Test]
        public void SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string groupname = null;
            //string categoryname = null;
            //var response = instance.SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV1(groupname, categoryname);
            //Assert.IsInstanceOf<List<Right>> (response, "response is List<Right>");
        }
        
        /// <summary>
        /// Test SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV2
        /// </summary>
        [Test]
        public void SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string groupname = null;
            //string categoryname = null;
            //var response = instance.SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV2(groupname, categoryname);
            //Assert.IsInstanceOf<SecurityRightsResponse> (response, "response is SecurityRightsResponse");
        }
        
        /// <summary>
        /// Test SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV1
        /// </summary>
        [Test]
        public void SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string categoryid = null;
            //var response = instance.SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV1(categoryid);
            //Assert.IsInstanceOf<List<Right>> (response, "response is List<Right>");
        }
        
        /// <summary>
        /// Test SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV2
        /// </summary>
        [Test]
        public void SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string categoryid = null;
            //var response = instance.SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV2(categoryid);
            //Assert.IsInstanceOf<SecurityRightsResponse> (response, "response is SecurityRightsResponse");
        }
        
        /// <summary>
        /// Test SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV1
        /// </summary>
        [Test]
        public void SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string categoryname = null;
            //var response = instance.SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV1(categoryname);
            //Assert.IsInstanceOf<List<Right>> (response, "response is List<Right>");
        }
        
        /// <summary>
        /// Test SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV2
        /// </summary>
        [Test]
        public void SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string categoryname = null;
            //var response = instance.SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV2(categoryname);
            //Assert.IsInstanceOf<SecurityRightsResponse> (response, "response is SecurityRightsResponse");
        }
        
        /// <summary>
        /// Test SecurityGetSecurityGroupsV1
        /// </summary>
        [Test]
        public void SecurityGetSecurityGroupsV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.SecurityGetSecurityGroupsV1();
            //Assert.IsInstanceOf<SecurityGroupResponse> (response, "response is SecurityGroupResponse");
        }
        
        /// <summary>
        /// Test SecurityGetSecurityGroupsV2
        /// </summary>
        [Test]
        public void SecurityGetSecurityGroupsV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.SecurityGetSecurityGroupsV2();
            //Assert.IsInstanceOf<SecurityGroupV2Response> (response, "response is SecurityGroupV2Response");
        }
        
        /// <summary>
        /// Test SecurityGetTeamsV1
        /// </summary>
        [Test]
        public void SecurityGetTeamsV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.SecurityGetTeamsV1();
            //Assert.IsInstanceOf<TeamsResponse> (response, "response is TeamsResponse");
        }
        
        /// <summary>
        /// Test SecurityGetTeamsV2
        /// </summary>
        [Test]
        public void SecurityGetTeamsV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.SecurityGetTeamsV2();
            //Assert.IsInstanceOf<TeamsV2Response> (response, "response is TeamsV2Response");
        }
        
        /// <summary>
        /// Test SecurityGetUserBatchV1
        /// </summary>
        [Test]
        public void SecurityGetUserBatchV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserBatchReadRequest request = null;
            //var response = instance.SecurityGetUserBatchV1(request);
            //Assert.IsInstanceOf<UserBatchReadResponse> (response, "response is UserBatchReadResponse");
        }
        
        /// <summary>
        /// Test SecurityGetUserByLoginIdV1
        /// </summary>
        [Test]
        public void SecurityGetUserByLoginIdV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string loginid = null;
            //var response = instance.SecurityGetUserByLoginIdV1(loginid);
            //Assert.IsInstanceOf<User> (response, "response is User");
        }
        
        /// <summary>
        /// Test SecurityGetUserByLoginIdV2
        /// </summary>
        [Test]
        public void SecurityGetUserByLoginIdV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string loginid = null;
            //string loginidtype = null;
            //var response = instance.SecurityGetUserByLoginIdV2(loginid, loginidtype);
            //Assert.IsInstanceOf<User> (response, "response is User");
        }
        
        /// <summary>
        /// Test SecurityGetUserByLoginIdV3
        /// </summary>
        [Test]
        public void SecurityGetUserByLoginIdV3Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string loginid = null;
            //string loginidtype = null;
            //var response = instance.SecurityGetUserByLoginIdV3(loginid, loginidtype);
            //Assert.IsInstanceOf<UserV2> (response, "response is UserV2");
        }
        
        /// <summary>
        /// Test SecurityGetUserByPublicIdV1
        /// </summary>
        [Test]
        public void SecurityGetUserByPublicIdV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string publicid = null;
            //var response = instance.SecurityGetUserByPublicIdV1(publicid);
            //Assert.IsInstanceOf<UserReadResponse> (response, "response is UserReadResponse");
        }
        
        /// <summary>
        /// Test SecurityGetUserByPublicIdV2
        /// </summary>
        [Test]
        public void SecurityGetUserByPublicIdV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string publicid = null;
            //var response = instance.SecurityGetUserByPublicIdV2(publicid);
            //Assert.IsInstanceOf<UserReadV2Response> (response, "response is UserReadV2Response");
        }
        
        /// <summary>
        /// Test SecurityGetUsersInSecurityGroupV1
        /// </summary>
        [Test]
        public void SecurityGetUsersInSecurityGroupV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string groupid = null;
            //var response = instance.SecurityGetUsersInSecurityGroupV1(groupid);
            //Assert.IsInstanceOf<List<User>> (response, "response is List<User>");
        }
        
        /// <summary>
        /// Test SecurityGetUsersInSecurityGroupV2
        /// </summary>
        [Test]
        public void SecurityGetUsersInSecurityGroupV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string groupid = null;
            //var response = instance.SecurityGetUsersInSecurityGroupV2(groupid);
            //Assert.IsInstanceOf<UserReadV2Response> (response, "response is UserReadV2Response");
        }
        
        /// <summary>
        /// Test SecurityGetUsersTeamsV1
        /// </summary>
        [Test]
        public void SecurityGetUsersTeamsV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userRecordId = null;
            //var response = instance.SecurityGetUsersTeamsV1(userRecordId);
            //Assert.IsInstanceOf<TeamsResponse> (response, "response is TeamsResponse");
        }
        
        /// <summary>
        /// Test SecurityGetUsersTeamsV2
        /// </summary>
        [Test]
        public void SecurityGetUsersTeamsV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userRecordId = null;
            //var response = instance.SecurityGetUsersTeamsV2(userRecordId);
            //Assert.IsInstanceOf<TeamsV2Response> (response, "response is TeamsV2Response");
        }
        
        /// <summary>
        /// Test SecurityGetWorkgroupsV1
        /// </summary>
        [Test]
        public void SecurityGetWorkgroupsV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.SecurityGetWorkgroupsV1();
            //Assert.IsInstanceOf<TeamsResponse> (response, "response is TeamsResponse");
        }
        
        /// <summary>
        /// Test SecurityGetWorkgroupsV2
        /// </summary>
        [Test]
        public void SecurityGetWorkgroupsV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.SecurityGetWorkgroupsV2();
            //Assert.IsInstanceOf<TeamsV2Response> (response, "response is TeamsV2Response");
        }
        
        /// <summary>
        /// Test SecurityRemoveUserFromTeamV1
        /// </summary>
        [Test]
        public void SecurityRemoveUserFromTeamV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamId = null;
            //string userrecordid = null;
            //instance.SecurityRemoveUserFromTeamV1(teamId, userrecordid);
            
        }
        
        /// <summary>
        /// Test SecurityRemoveUserFromTeamV2
        /// </summary>
        [Test]
        public void SecurityRemoveUserFromTeamV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamId = null;
            //string userrecordid = null;
            //var response = instance.SecurityRemoveUserFromTeamV2(teamId, userrecordid);
            //Assert.IsInstanceOf<RemoveUserFromTeamResponse> (response, "response is RemoveUserFromTeamResponse");
        }
        
        /// <summary>
        /// Test SecuritySaveTeamV1
        /// </summary>
        [Test]
        public void SecuritySaveTeamV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TeamSaveRequest request = null;
            //var response = instance.SecuritySaveTeamV1(request);
            //Assert.IsInstanceOf<TeamSaveResponse> (response, "response is TeamSaveResponse");
        }
        
        /// <summary>
        /// Test SecuritySaveUserBatchV1
        /// </summary>
        [Test]
        public void SecuritySaveUserBatchV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserBatchSaveRequest request = null;
            //var response = instance.SecuritySaveUserBatchV1(request);
            //Assert.IsInstanceOf<UserBatchSaveResponse> (response, "response is UserBatchSaveResponse");
        }
        
        /// <summary>
        /// Test SecuritySaveUserBatchV2
        /// </summary>
        [Test]
        public void SecuritySaveUserBatchV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserBatchSaveV2Request request = null;
            //var response = instance.SecuritySaveUserBatchV2(request);
            //Assert.IsInstanceOf<UserBatchSaveV2Response> (response, "response is UserBatchSaveV2Response");
        }
        
        /// <summary>
        /// Test SecuritySaveUserV1
        /// </summary>
        [Test]
        public void SecuritySaveUserV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserSaveRequest request = null;
            //var response = instance.SecuritySaveUserV1(request);
            //Assert.IsInstanceOf<UserSaveResponse> (response, "response is UserSaveResponse");
        }
        
        /// <summary>
        /// Test SecuritySaveUserV2
        /// </summary>
        [Test]
        public void SecuritySaveUserV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserSaveV2Request request = null;
            //var response = instance.SecuritySaveUserV2(request);
            //Assert.IsInstanceOf<UserSaveV2Response> (response, "response is UserSaveV2Response");
        }
        
    }

}
