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

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing CoreApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CoreApiTests
    {
        private CoreApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CoreApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CoreApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CoreApi
            //Assert.IsInstanceOfType(typeof(CoreApi), instance, "instance is a CoreApi");
        }

        
        /// <summary>
        /// Test CoreGetGalleryImageV1
        /// </summary>
        [Test]
        public void CoreGetGalleryImageV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //int? width = null;
            //int? height = null;
            //var response = instance.CoreGetGalleryImageV1(name, width, height);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
    }

}
