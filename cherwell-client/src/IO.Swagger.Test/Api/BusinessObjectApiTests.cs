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
    ///  Class for testing BusinessObjectApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class BusinessObjectApiTests
    {
        private BusinessObjectApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new BusinessObjectApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BusinessObjectApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' BusinessObjectApi
            //Assert.IsInstanceOfType(typeof(BusinessObjectApi), instance, "instance is a BusinessObjectApi");
        }

        
        /// <summary>
        /// Test BusinessObjectDeleteBusinessObjectBatchV1
        /// </summary>
        [Test]
        public void BusinessObjectDeleteBusinessObjectBatchV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BatchDeleteRequest request = null;
            //var response = instance.BusinessObjectDeleteBusinessObjectBatchV1(request);
            //Assert.IsInstanceOf<BatchDeleteResponse> (response, "response is BatchDeleteResponse");
        }
        
        /// <summary>
        /// Test BusinessObjectDeleteBusinessObjectByPublicIdV1
        /// </summary>
        [Test]
        public void BusinessObjectDeleteBusinessObjectByPublicIdV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string busobid = null;
            //string publicid = null;
            //var response = instance.BusinessObjectDeleteBusinessObjectByPublicIdV1(busobid, publicid);
            //Assert.IsInstanceOf<DeleteResponse> (response, "response is DeleteResponse");
        }
        
        /// <summary>
        /// Test BusinessObjectDeleteBusinessObjectByRecIdV1
        /// </summary>
        [Test]
        public void BusinessObjectDeleteBusinessObjectByRecIdV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string busobid = null;
            //string busobrecid = null;
            //var response = instance.BusinessObjectDeleteBusinessObjectByRecIdV1(busobid, busobrecid);
            //Assert.IsInstanceOf<DeleteResponse> (response, "response is DeleteResponse");
        }
        
        /// <summary>
        /// Test BusinessObjectDeleteRelatedBusinessObjectByPublicIdV1
        /// </summary>
        [Test]
        public void BusinessObjectDeleteRelatedBusinessObjectByPublicIdV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentbusobid = null;
            //string parentbusobrecid = null;
            //string relationshipid = null;
            //string publicid = null;
            //var response = instance.BusinessObjectDeleteRelatedBusinessObjectByPublicIdV1(parentbusobid, parentbusobrecid, relationshipid, publicid);
            //Assert.IsInstanceOf<RelatedBusinessObjectResponse> (response, "response is RelatedBusinessObjectResponse");
        }
        
        /// <summary>
        /// Test BusinessObjectDeleteRelatedBusinessObjectByRecIdV1
        /// </summary>
        [Test]
        public void BusinessObjectDeleteRelatedBusinessObjectByRecIdV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentbusobid = null;
            //string parentbusobrecid = null;
            //string relationshipid = null;
            //string busobrecid = null;
            //var response = instance.BusinessObjectDeleteRelatedBusinessObjectByRecIdV1(parentbusobid, parentbusobrecid, relationshipid, busobrecid);
            //Assert.IsInstanceOf<RelatedBusinessObjectResponse> (response, "response is RelatedBusinessObjectResponse");
        }
        
        /// <summary>
        /// Test BusinessObjectFieldValuesLookupV1
        /// </summary>
        [Test]
        public void BusinessObjectFieldValuesLookupV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //FieldValuesLookupRequest request = null;
            //var response = instance.BusinessObjectFieldValuesLookupV1(request);
            //Assert.IsInstanceOf<FieldValuesLookupResponse> (response, "response is FieldValuesLookupResponse");
        }
        
        /// <summary>
        /// Test BusinessObjectGetBusinessObjectAttachmentByAttachmentIdV1
        /// </summary>
        [Test]
        public void BusinessObjectGetBusinessObjectAttachmentByAttachmentIdV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string attachmentid = null;
            //string busobid = null;
            //string busobrecid = null;
            //var response = instance.BusinessObjectGetBusinessObjectAttachmentByAttachmentIdV1(attachmentid, busobid, busobrecid);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test BusinessObjectGetBusinessObjectAttachmentsByIdAndPublicIdV1
        /// </summary>
        [Test]
        public void BusinessObjectGetBusinessObjectAttachmentsByIdAndPublicIdV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string busobid = null;
            //string publicid = null;
            //string type = null;
            //string attachmenttype = null;
            //bool? includelinks = null;
            //var response = instance.BusinessObjectGetBusinessObjectAttachmentsByIdAndPublicIdV1(busobid, publicid, type, attachmenttype, includelinks);
            //Assert.IsInstanceOf<AttachmentsResponse> (response, "response is AttachmentsResponse");
        }
        
        /// <summary>
        /// Test BusinessObjectGetBusinessObjectAttachmentsByIdAndRecIdV1
        /// </summary>
        [Test]
        public void BusinessObjectGetBusinessObjectAttachmentsByIdAndRecIdV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string busobid = null;
            //string busobrecid = null;
            //string type = null;
            //string attachmenttype = null;
            //bool? includelinks = null;
            //var response = instance.BusinessObjectGetBusinessObjectAttachmentsByIdAndRecIdV1(busobid, busobrecid, type, attachmenttype, includelinks);
            //Assert.IsInstanceOf<AttachmentsResponse> (response, "response is AttachmentsResponse");
        }
        
        /// <summary>
        /// Test BusinessObjectGetBusinessObjectAttachmentsByNameAndPublicIdV1
        /// </summary>
        [Test]
        public void BusinessObjectGetBusinessObjectAttachmentsByNameAndPublicIdV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string busobname = null;
            //string publicid = null;
            //string type = null;
            //string attachmenttype = null;
            //bool? includelinks = null;
            //var response = instance.BusinessObjectGetBusinessObjectAttachmentsByNameAndPublicIdV1(busobname, publicid, type, attachmenttype, includelinks);
            //Assert.IsInstanceOf<AttachmentsResponse> (response, "response is AttachmentsResponse");
        }
        
        /// <summary>
        /// Test BusinessObjectGetBusinessObjectAttachmentsByNameAndRecIdV1
        /// </summary>
        [Test]
        public void BusinessObjectGetBusinessObjectAttachmentsByNameAndRecIdV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string busobname = null;
            //string busobrecid = null;
            //string type = null;
            //string attachmenttype = null;
            //bool? includelinks = null;
            //var response = instance.BusinessObjectGetBusinessObjectAttachmentsByNameAndRecIdV1(busobname, busobrecid, type, attachmenttype, includelinks);
            //Assert.IsInstanceOf<AttachmentsResponse> (response, "response is AttachmentsResponse");
        }
        
        /// <summary>
        /// Test BusinessObjectGetBusinessObjectAttachmentsV1
        /// </summary>
        [Test]
        public void BusinessObjectGetBusinessObjectAttachmentsV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AttachmentsRequest attachmentsRequest = null;
            //var response = instance.BusinessObjectGetBusinessObjectAttachmentsV1(attachmentsRequest);
            //Assert.IsInstanceOf<AttachmentsResponse> (response, "response is AttachmentsResponse");
        }
        
        /// <summary>
        /// Test BusinessObjectGetBusinessObjectBatchV1
        /// </summary>
        [Test]
        public void BusinessObjectGetBusinessObjectBatchV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BatchReadRequest request = null;
            //var response = instance.BusinessObjectGetBusinessObjectBatchV1(request);
            //Assert.IsInstanceOf<BatchReadResponse> (response, "response is BatchReadResponse");
        }
        
        /// <summary>
        /// Test BusinessObjectGetBusinessObjectByPublicIdV1
        /// </summary>
        [Test]
        public void BusinessObjectGetBusinessObjectByPublicIdV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string busobid = null;
            //string publicid = null;
            //var response = instance.BusinessObjectGetBusinessObjectByPublicIdV1(busobid, publicid);
            //Assert.IsInstanceOf<ReadResponse> (response, "response is ReadResponse");
        }
        
        /// <summary>
        /// Test BusinessObjectGetBusinessObjectByRecIdV1
        /// </summary>
        [Test]
        public void BusinessObjectGetBusinessObjectByRecIdV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string busobid = null;
            //string busobrecid = null;
            //var response = instance.BusinessObjectGetBusinessObjectByRecIdV1(busobid, busobrecid);
            //Assert.IsInstanceOf<ReadResponse> (response, "response is ReadResponse");
        }
        
        /// <summary>
        /// Test BusinessObjectGetBusinessObjectByScanCodeBusObIdV1
        /// </summary>
        [Test]
        public void BusinessObjectGetBusinessObjectByScanCodeBusObIdV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string scanCode = null;
            //string busobid = null;
            //var response = instance.BusinessObjectGetBusinessObjectByScanCodeBusObIdV1(scanCode, busobid);
            //Assert.IsInstanceOf<BarcodeLookupResponse> (response, "response is BarcodeLookupResponse");
        }
        
        /// <summary>
        /// Test BusinessObjectGetBusinessObjectByScanCodeBusObNameV1
        /// </summary>
        [Test]
        public void BusinessObjectGetBusinessObjectByScanCodeBusObNameV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string scanCode = null;
            //string busobname = null;
            //var response = instance.BusinessObjectGetBusinessObjectByScanCodeBusObNameV1(scanCode, busobname);
            //Assert.IsInstanceOf<BarcodeLookupResponse> (response, "response is BarcodeLookupResponse");
        }
        
        /// <summary>
        /// Test BusinessObjectGetBusinessObjectSchemaV1
        /// </summary>
        [Test]
        public void BusinessObjectGetBusinessObjectSchemaV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string busobId = null;
            //bool? includerelationships = null;
            //var response = instance.BusinessObjectGetBusinessObjectSchemaV1(busobId, includerelationships);
            //Assert.IsInstanceOf<SchemaResponse> (response, "response is SchemaResponse");
        }
        
        /// <summary>
        /// Test BusinessObjectGetBusinessObjectSummariesV1
        /// </summary>
        [Test]
        public void BusinessObjectGetBusinessObjectSummariesV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string type = null;
            //var response = instance.BusinessObjectGetBusinessObjectSummariesV1(type);
            //Assert.IsInstanceOf<List<Summary>> (response, "response is List<Summary>");
        }
        
        /// <summary>
        /// Test BusinessObjectGetBusinessObjectSummaryByIdV1
        /// </summary>
        [Test]
        public void BusinessObjectGetBusinessObjectSummaryByIdV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string busobid = null;
            //var response = instance.BusinessObjectGetBusinessObjectSummaryByIdV1(busobid);
            //Assert.IsInstanceOf<List<Summary>> (response, "response is List<Summary>");
        }
        
        /// <summary>
        /// Test BusinessObjectGetBusinessObjectSummaryByNameV1
        /// </summary>
        [Test]
        public void BusinessObjectGetBusinessObjectSummaryByNameV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string busobname = null;
            //var response = instance.BusinessObjectGetBusinessObjectSummaryByNameV1(busobname);
            //Assert.IsInstanceOf<List<Summary>> (response, "response is List<Summary>");
        }
        
        /// <summary>
        /// Test BusinessObjectGetBusinessObjectTemplateV1
        /// </summary>
        [Test]
        public void BusinessObjectGetBusinessObjectTemplateV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TemplateRequest request = null;
            //var response = instance.BusinessObjectGetBusinessObjectTemplateV1(request);
            //Assert.IsInstanceOf<TemplateResponse> (response, "response is TemplateResponse");
        }
        
        /// <summary>
        /// Test BusinessObjectGetRelatedBusinessObjectByRequestV1
        /// </summary>
        [Test]
        public void BusinessObjectGetRelatedBusinessObjectByRequestV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RelatedBusinessObjectRequest relatedBusinessObjectRequest = null;
            //bool? includelinks = null;
            //var response = instance.BusinessObjectGetRelatedBusinessObjectByRequestV1(relatedBusinessObjectRequest, includelinks);
            //Assert.IsInstanceOf<RelatedBusinessObjectResponse> (response, "response is RelatedBusinessObjectResponse");
        }
        
        /// <summary>
        /// Test BusinessObjectGetRelatedBusinessObjectV1
        /// </summary>
        [Test]
        public void BusinessObjectGetRelatedBusinessObjectV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentbusobid = null;
            //string parentbusobrecid = null;
            //string relationshipid = null;
            //int? pageNumber = null;
            //int? pageSize = null;
            //bool? allfields = null;
            //bool? usedefaultgrid = null;
            //bool? includelinks = null;
            //var response = instance.BusinessObjectGetRelatedBusinessObjectV1(parentbusobid, parentbusobrecid, relationshipid, pageNumber, pageSize, allfields, usedefaultgrid, includelinks);
            //Assert.IsInstanceOf<RelatedBusinessObjectResponse> (response, "response is RelatedBusinessObjectResponse");
        }
        
        /// <summary>
        /// Test BusinessObjectGetRelatedBusinessObjectWithCustomGridV1
        /// </summary>
        [Test]
        public void BusinessObjectGetRelatedBusinessObjectWithCustomGridV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentbusobid = null;
            //string parentbusobrecid = null;
            //string relationshipid = null;
            //string gridid = null;
            //int? pageNumber = null;
            //int? pageSize = null;
            //bool? includelinks = null;
            //var response = instance.BusinessObjectGetRelatedBusinessObjectWithCustomGridV1(parentbusobid, parentbusobrecid, relationshipid, gridid, pageNumber, pageSize, includelinks);
            //Assert.IsInstanceOf<RelatedBusinessObjectResponse> (response, "response is RelatedBusinessObjectResponse");
        }
        
        /// <summary>
        /// Test BusinessObjectLinkRelatedBusinessObjectByRecIdV1
        /// </summary>
        [Test]
        public void BusinessObjectLinkRelatedBusinessObjectByRecIdV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentbusobid = null;
            //string parentbusobrecid = null;
            //string relationshipid = null;
            //string busobid = null;
            //string busobrecid = null;
            //var response = instance.BusinessObjectLinkRelatedBusinessObjectByRecIdV1(parentbusobid, parentbusobrecid, relationshipid, busobid, busobrecid);
            //Assert.IsInstanceOf<RelatedBusinessObjectResponse> (response, "response is RelatedBusinessObjectResponse");
        }
        
        /// <summary>
        /// Test BusinessObjectRemoveBusinessObjectAttachmentByIdAndPublicIdV1
        /// </summary>
        [Test]
        public void BusinessObjectRemoveBusinessObjectAttachmentByIdAndPublicIdV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string attachmentid = null;
            //string busobid = null;
            //string publicid = null;
            //instance.BusinessObjectRemoveBusinessObjectAttachmentByIdAndPublicIdV1(attachmentid, busobid, publicid);
            
        }
        
        /// <summary>
        /// Test BusinessObjectRemoveBusinessObjectAttachmentByIdAndRecIdV1
        /// </summary>
        [Test]
        public void BusinessObjectRemoveBusinessObjectAttachmentByIdAndRecIdV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string attachmentid = null;
            //string busobid = null;
            //string busobrecid = null;
            //instance.BusinessObjectRemoveBusinessObjectAttachmentByIdAndRecIdV1(attachmentid, busobid, busobrecid);
            
        }
        
        /// <summary>
        /// Test BusinessObjectRemoveBusinessObjectAttachmentByNameAndPublicIdV1
        /// </summary>
        [Test]
        public void BusinessObjectRemoveBusinessObjectAttachmentByNameAndPublicIdV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string attachmentid = null;
            //string busobname = null;
            //string publicid = null;
            //instance.BusinessObjectRemoveBusinessObjectAttachmentByNameAndPublicIdV1(attachmentid, busobname, publicid);
            
        }
        
        /// <summary>
        /// Test BusinessObjectRemoveBusinessObjectAttachmentByNameAndRecIdV1
        /// </summary>
        [Test]
        public void BusinessObjectRemoveBusinessObjectAttachmentByNameAndRecIdV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string attachmentid = null;
            //string busobname = null;
            //string busobrecid = null;
            //instance.BusinessObjectRemoveBusinessObjectAttachmentByNameAndRecIdV1(attachmentid, busobname, busobrecid);
            
        }
        
        /// <summary>
        /// Test BusinessObjectSaveBusinessObjectAttachmentBusObV1
        /// </summary>
        [Test]
        public void BusinessObjectSaveBusinessObjectAttachmentBusObV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SaveBusObAttachmentRequest request = null;
            //var response = instance.BusinessObjectSaveBusinessObjectAttachmentBusObV1(request);
            //Assert.IsInstanceOf<AttachmentsResponse> (response, "response is AttachmentsResponse");
        }
        
        /// <summary>
        /// Test BusinessObjectSaveBusinessObjectAttachmentLinkV1
        /// </summary>
        [Test]
        public void BusinessObjectSaveBusinessObjectAttachmentLinkV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SaveLinkAttachmentRequest request = null;
            //var response = instance.BusinessObjectSaveBusinessObjectAttachmentLinkV1(request);
            //Assert.IsInstanceOf<AttachmentsResponse> (response, "response is AttachmentsResponse");
        }
        
        /// <summary>
        /// Test BusinessObjectSaveBusinessObjectAttachmentUrlV1
        /// </summary>
        [Test]
        public void BusinessObjectSaveBusinessObjectAttachmentUrlV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SaveUrlAttachmentRequest request = null;
            //var response = instance.BusinessObjectSaveBusinessObjectAttachmentUrlV1(request);
            //Assert.IsInstanceOf<AttachmentsResponse> (response, "response is AttachmentsResponse");
        }
        
        /// <summary>
        /// Test BusinessObjectSaveBusinessObjectBatchV1
        /// </summary>
        [Test]
        public void BusinessObjectSaveBusinessObjectBatchV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BatchSaveRequest request = null;
            //var response = instance.BusinessObjectSaveBusinessObjectBatchV1(request);
            //Assert.IsInstanceOf<BatchSaveResponse> (response, "response is BatchSaveResponse");
        }
        
        /// <summary>
        /// Test BusinessObjectSaveBusinessObjectV1
        /// </summary>
        [Test]
        public void BusinessObjectSaveBusinessObjectV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SaveRequest request = null;
            //var response = instance.BusinessObjectSaveBusinessObjectV1(request);
            //Assert.IsInstanceOf<SaveResponse> (response, "response is SaveResponse");
        }
        
        /// <summary>
        /// Test BusinessObjectSaveRelatedBusinessObjectV1
        /// </summary>
        [Test]
        public void BusinessObjectSaveRelatedBusinessObjectV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RelatedSaveRequest request = null;
            //var response = instance.BusinessObjectSaveRelatedBusinessObjectV1(request);
            //Assert.IsInstanceOf<RelatedSaveResponse> (response, "response is RelatedSaveResponse");
        }
        
        /// <summary>
        /// Test BusinessObjectUnLinkRelatedBusinessObjectByRecIdV1
        /// </summary>
        [Test]
        public void BusinessObjectUnLinkRelatedBusinessObjectByRecIdV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentbusobid = null;
            //string parentbusobrecid = null;
            //string relationshipid = null;
            //string busobid = null;
            //string busobrecid = null;
            //var response = instance.BusinessObjectUnLinkRelatedBusinessObjectByRecIdV1(parentbusobid, parentbusobrecid, relationshipid, busobid, busobrecid);
            //Assert.IsInstanceOf<RelatedBusinessObjectResponse> (response, "response is RelatedBusinessObjectResponse");
        }
        
        /// <summary>
        /// Test BusinessObjectUploadBusinessObjectAttachmentByIdAndPublicIdV1
        /// </summary>
        [Test]
        public void BusinessObjectUploadBusinessObjectAttachmentByIdAndPublicIdV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //byte[] body = null;
            //string filename = null;
            //string busobid = null;
            //string publicid = null;
            //int? offset = null;
            //int? totalsize = null;
            //string attachmentid = null;
            //string displaytext = null;
            //var response = instance.BusinessObjectUploadBusinessObjectAttachmentByIdAndPublicIdV1(body, filename, busobid, publicid, offset, totalsize, attachmentid, displaytext);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test BusinessObjectUploadBusinessObjectAttachmentByIdAndRecIdV1
        /// </summary>
        [Test]
        public void BusinessObjectUploadBusinessObjectAttachmentByIdAndRecIdV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //byte[] body = null;
            //string filename = null;
            //string busobid = null;
            //string busobrecid = null;
            //int? offset = null;
            //int? totalsize = null;
            //string attachmentid = null;
            //string displaytext = null;
            //var response = instance.BusinessObjectUploadBusinessObjectAttachmentByIdAndRecIdV1(body, filename, busobid, busobrecid, offset, totalsize, attachmentid, displaytext);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test BusinessObjectUploadBusinessObjectAttachmentByNameAndPublicIdV1
        /// </summary>
        [Test]
        public void BusinessObjectUploadBusinessObjectAttachmentByNameAndPublicIdV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //byte[] body = null;
            //string filename = null;
            //string busobname = null;
            //string publicid = null;
            //int? offset = null;
            //int? totalsize = null;
            //string attachmentid = null;
            //string displaytext = null;
            //var response = instance.BusinessObjectUploadBusinessObjectAttachmentByNameAndPublicIdV1(body, filename, busobname, publicid, offset, totalsize, attachmentid, displaytext);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test BusinessObjectUploadBusinessObjectAttachmentByNameAndRecIdV1
        /// </summary>
        [Test]
        public void BusinessObjectUploadBusinessObjectAttachmentByNameAndRecIdV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //byte[] body = null;
            //string filename = null;
            //string busobname = null;
            //string busobrecid = null;
            //int? offset = null;
            //int? totalsize = null;
            //string attachmentid = null;
            //string displaytext = null;
            //var response = instance.BusinessObjectUploadBusinessObjectAttachmentByNameAndRecIdV1(body, filename, busobname, busobrecid, offset, totalsize, attachmentid, displaytext);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
    }

}