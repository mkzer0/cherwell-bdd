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
    ///  Class for testing FormsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class FormsApiTests
    {
        private FormsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FormsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FormsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' FormsApi
            //Assert.IsInstanceOfType(typeof(FormsApi), instance, "instance is a FormsApi");
        }

        
        /// <summary>
        /// Test FormsGetMobileFormForBusObByIdAndPublicIdV1
        /// </summary>
        [Test]
        public void FormsGetMobileFormForBusObByIdAndPublicIdV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string busobid = null;
            //string publicid = null;
            //bool? foredit = null;
            //string formid = null;
            //var response = instance.FormsGetMobileFormForBusObByIdAndPublicIdV1(busobid, publicid, foredit, formid);
            //Assert.IsInstanceOf<MobileFormResponse> (response, "response is MobileFormResponse");
        }
        
        /// <summary>
        /// Test FormsGetMobileFormForBusObByIdAndRecIdV1
        /// </summary>
        [Test]
        public void FormsGetMobileFormForBusObByIdAndRecIdV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string busobid = null;
            //string busobrecid = null;
            //bool? foredit = null;
            //string formid = null;
            //var response = instance.FormsGetMobileFormForBusObByIdAndRecIdV1(busobid, busobrecid, foredit, formid);
            //Assert.IsInstanceOf<MobileFormResponse> (response, "response is MobileFormResponse");
        }
        
        /// <summary>
        /// Test FormsGetMobileFormForBusObByNameAndPublicIdV1
        /// </summary>
        [Test]
        public void FormsGetMobileFormForBusObByNameAndPublicIdV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string busobname = null;
            //string publicid = null;
            //bool? foredit = null;
            //string formid = null;
            //var response = instance.FormsGetMobileFormForBusObByNameAndPublicIdV1(busobname, publicid, foredit, formid);
            //Assert.IsInstanceOf<MobileFormResponse> (response, "response is MobileFormResponse");
        }
        
        /// <summary>
        /// Test FormsGetMobileFormForBusObByNameAndRecIdV1
        /// </summary>
        [Test]
        public void FormsGetMobileFormForBusObByNameAndRecIdV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string busobname = null;
            //string busobrecid = null;
            //bool? foredit = null;
            //string formid = null;
            //var response = instance.FormsGetMobileFormForBusObByNameAndRecIdV1(busobname, busobrecid, foredit, formid);
            //Assert.IsInstanceOf<MobileFormResponse> (response, "response is MobileFormResponse");
        }
        
    }

}
