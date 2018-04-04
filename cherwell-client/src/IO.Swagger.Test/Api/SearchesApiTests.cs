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
    ///  Class for testing SearchesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SearchesApiTests
    {
        private SearchesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SearchesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SearchesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SearchesApi
            //Assert.IsInstanceOfType(typeof(SearchesApi), instance, "instance is a SearchesApi");
        }

        
        /// <summary>
        /// Test SearchesGetQuickSearchConfigurationForBusObsV1
        /// </summary>
        [Test]
        public void SearchesGetQuickSearchConfigurationForBusObsV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //QuickSearchConfigurationRequest request = null;
            //var response = instance.SearchesGetQuickSearchConfigurationForBusObsV1(request);
            //Assert.IsInstanceOf<QuickSearchConfigurationResponse> (response, "response is QuickSearchConfigurationResponse");
        }
        
        /// <summary>
        /// Test SearchesGetQuickSearchConfigurationForBusObsWithViewRightsV1
        /// </summary>
        [Test]
        public void SearchesGetQuickSearchConfigurationForBusObsWithViewRightsV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.SearchesGetQuickSearchConfigurationForBusObsWithViewRightsV1();
            //Assert.IsInstanceOf<QuickSearchConfigurationResponse> (response, "response is QuickSearchConfigurationResponse");
        }
        
        /// <summary>
        /// Test SearchesGetQuickSearchResultsV1
        /// </summary>
        [Test]
        public void SearchesGetQuickSearchResultsV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //QuickSearchRequest request = null;
            //bool? includeLinks = null;
            //var response = instance.SearchesGetQuickSearchResultsV1(request, includeLinks);
            //Assert.IsInstanceOf<SimpleResultsList> (response, "response is SimpleResultsList");
        }
        
        /// <summary>
        /// Test SearchesGetQuickSearchSpecificResultsV1
        /// </summary>
        [Test]
        public void SearchesGetQuickSearchSpecificResultsV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //QuickSearchSpecificRequest request = null;
            //bool? includeSchema = null;
            //bool? includeLocationFields = null;
            //bool? includeLinks = null;
            //var response = instance.SearchesGetQuickSearchSpecificResultsV1(request, includeSchema, includeLocationFields, includeLinks);
            //Assert.IsInstanceOf<SearchResultsTableResponse> (response, "response is SearchResultsTableResponse");
        }
        
        /// <summary>
        /// Test SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV1
        /// </summary>
        [Test]
        public void SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string association = null;
            //string scope = null;
            //string scopeowner = null;
            //string folder = null;
            //bool? links = null;
            //var response = instance.SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV1(association, scope, scopeowner, folder, links);
            //Assert.IsInstanceOf<SearchItemResponse> (response, "response is SearchItemResponse");
        }
        
        /// <summary>
        /// Test SearchesGetSearchItemsByAssociationScopeScopeOwnerV1
        /// </summary>
        [Test]
        public void SearchesGetSearchItemsByAssociationScopeScopeOwnerV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string association = null;
            //string scope = null;
            //string scopeowner = null;
            //bool? links = null;
            //var response = instance.SearchesGetSearchItemsByAssociationScopeScopeOwnerV1(association, scope, scopeowner, links);
            //Assert.IsInstanceOf<SearchItemResponse> (response, "response is SearchItemResponse");
        }
        
        /// <summary>
        /// Test SearchesGetSearchItemsByAssociationScopeV1
        /// </summary>
        [Test]
        public void SearchesGetSearchItemsByAssociationScopeV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string association = null;
            //string scope = null;
            //bool? links = null;
            //var response = instance.SearchesGetSearchItemsByAssociationScopeV1(association, scope, links);
            //Assert.IsInstanceOf<SearchItemResponse> (response, "response is SearchItemResponse");
        }
        
        /// <summary>
        /// Test SearchesGetSearchItemsByAssociationV1
        /// </summary>
        [Test]
        public void SearchesGetSearchItemsByAssociationV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string association = null;
            //bool? links = null;
            //var response = instance.SearchesGetSearchItemsByAssociationV1(association, links);
            //Assert.IsInstanceOf<SearchItemResponse> (response, "response is SearchItemResponse");
        }
        
        /// <summary>
        /// Test SearchesGetSearchItemsV1
        /// </summary>
        [Test]
        public void SearchesGetSearchItemsV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? links = null;
            //var response = instance.SearchesGetSearchItemsV1(links);
            //Assert.IsInstanceOf<SearchItemResponse> (response, "response is SearchItemResponse");
        }
        
        /// <summary>
        /// Test SearchesGetSearchResultsAdHocV1
        /// </summary>
        [Test]
        public void SearchesGetSearchResultsAdHocV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SearchResultsRequest request = null;
            //var response = instance.SearchesGetSearchResultsAdHocV1(request);
            //Assert.IsInstanceOf<SearchResultsResponse> (response, "response is SearchResultsResponse");
        }
        
        /// <summary>
        /// Test SearchesGetSearchResultsByIdV1
        /// </summary>
        [Test]
        public void SearchesGetSearchResultsByIdV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string association = null;
            //string scope = null;
            //string scopeowner = null;
            //string searchid = null;
            //string searchTerm = null;
            //int? pagenumber = null;
            //int? pagesize = null;
            //bool? includeschema = null;
            //var response = instance.SearchesGetSearchResultsByIdV1(association, scope, scopeowner, searchid, searchTerm, pagenumber, pagesize, includeschema);
            //Assert.IsInstanceOf<SearchResultsResponse> (response, "response is SearchResultsResponse");
        }
        
        /// <summary>
        /// Test SearchesGetSearchResultsByNameV1
        /// </summary>
        [Test]
        public void SearchesGetSearchResultsByNameV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string association = null;
            //string scope = null;
            //string scopeowner = null;
            //string searchname = null;
            //string searchTerm = null;
            //int? pagenumber = null;
            //int? pagesize = null;
            //bool? includeschema = null;
            //var response = instance.SearchesGetSearchResultsByNameV1(association, scope, scopeowner, searchname, searchTerm, pagenumber, pagesize, includeschema);
            //Assert.IsInstanceOf<SearchResultsResponse> (response, "response is SearchResultsResponse");
        }
        
        /// <summary>
        /// Test SearchesGetSearchResultsExportAdHocV1
        /// </summary>
        [Test]
        public void SearchesGetSearchResultsExportAdHocV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ExportSearchResultsRequest request = null;
            //var response = instance.SearchesGetSearchResultsExportAdHocV1(request);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test SearchesGetSearchResultsExportByIdV1
        /// </summary>
        [Test]
        public void SearchesGetSearchResultsExportByIdV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string association = null;
            //string scope = null;
            //string scopeowner = null;
            //string searchid = null;
            //string exportformat = null;
            //string searchTerm = null;
            //int? pagenumber = null;
            //int? pagesize = null;
            //var response = instance.SearchesGetSearchResultsExportByIdV1(association, scope, scopeowner, searchid, exportformat, searchTerm, pagenumber, pagesize);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test SearchesGetSearchResultsExportByNameV1
        /// </summary>
        [Test]
        public void SearchesGetSearchResultsExportByNameV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string association = null;
            //string scope = null;
            //string scopeowner = null;
            //string searchname = null;
            //string exportformat = null;
            //string searchTerm = null;
            //int? pagenumber = null;
            //int? pagesize = null;
            //var response = instance.SearchesGetSearchResultsExportByNameV1(association, scope, scopeowner, searchname, exportformat, searchTerm, pagenumber, pagesize);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
    }

}
