/* 
 * DotAAS Part 2 | HTTP/REST | Asset Administration Shell Repository
 *
 * An exemplary interface combination for the use case of an Asset Administration Shell Repository
 *
 * OpenAPI spec version: Final-Draft
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
    ///  Class for testing AssetAdministrationShellRepositoryApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AssetAdministrationShellRepositoryApiTests
    {
        private AssetAdministrationShellRepositoryApi instance;
        private RestClient.Test.APIWebApplicationFactory _factory;

        [OneTimeSetUp]
        public void GivenARequestToTheController()
        {
            _factory = new RestClient.Test.APIWebApplicationFactory();
            var client = _factory.CreateClient();
            instance = new AssetAdministrationShellRepositoryApi(new Configuration { HttpClient = client });
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            _factory.Dispose();
        }

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AssetAdministrationShellRepositoryApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AssetAdministrationShellRepositoryApi
            //Assert.IsInstanceOfType(typeof(AssetAdministrationShellRepositoryApi), instance, "instance is a AssetAdministrationShellRepositoryApi");
        }

        /// <summary>
        /// Test DeleteAssetAdministrationShellById
        /// </summary>
        [Test]
        public void DeleteAssetAdministrationShellByIdTest()
        {
            
        }
        /// <summary>
        /// Test DeleteConceptDescriptionById
        /// </summary>
        [Test]
        public void DeleteConceptDescriptionByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string cdIdentifier = null;
            //instance.DeleteConceptDescriptionById(cdIdentifier);
            
        }
        /// <summary>
        /// Test DeleteSubmodelElementByPath
        /// </summary>
        [Test]
        public void DeleteSubmodelElementByPathTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string aasIdentifier = null;
            //string submodelIdentifier = null;
            //string idShortPath = null;
            //instance.DeleteSubmodelElementByPath(aasIdentifier, submodelIdentifier, idShortPath);
            
        }
        /// <summary>
        /// Test DeleteSubmodelElementByPathSubmodelRepo
        /// </summary>
        [Test]
        public void DeleteSubmodelElementByPathSubmodelRepoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string submodelIdentifier = null;
            //string idShortPath = null;
            //instance.DeleteSubmodelElementByPathSubmodelRepo(submodelIdentifier, idShortPath);
            
        }
        /// <summary>
        /// Test DeleteSubmodelReferenceById
        /// </summary>
        [Test]
        public void DeleteSubmodelReferenceByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string aasIdentifier = null;
            //string submodelIdentifier = null;
            //instance.DeleteSubmodelReferenceById(aasIdentifier, submodelIdentifier);
            
        }
        /// <summary>
        /// Test GenerateSerializationByIds
        /// </summary>
        [Test]
        public void GenerateSerializationByIdsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> aasIds = null;
            //List<string> submodelIds = null;
            //bool? includeConceptDescriptions = null;
            //var response = instance.GenerateSerializationByIds(aasIds, submodelIds, includeConceptDescriptions);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        /// <summary>
        /// Test GetAllAssetAdministrationShells
        /// </summary>
        [Test]
        public void GetAllAssetAdministrationShellsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<IdentifierKeyValuePair> assetIds = null;
            //string idShort = null;
            //var response = instance.GetAllAssetAdministrationShells(assetIds, idShort);
            //Assert.IsInstanceOf<List<AssetAdministrationShell>> (response, "response is List<AssetAdministrationShell>");
        }
        /// <summary>
        /// Test GetAllConceptDescriptions
        /// </summary>
        [Test]
        public void GetAllConceptDescriptionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string idShort = null;
            //string isCaseOf = null;
            //string dataSpecificationRef = null;
            //var response = instance.GetAllConceptDescriptions(idShort, isCaseOf, dataSpecificationRef);
            //Assert.IsInstanceOf<List<ConceptDescription>> (response, "response is List<ConceptDescription>");
        }
        /// <summary>
        /// Test GetAllSubmodelElements
        /// </summary>
        [Test]
        public void GetAllSubmodelElementsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string aasIdentifier = null;
            //string submodelIdentifier = null;
            //string level = null;
            //string content = null;
            //string extent = null;
            //var response = instance.GetAllSubmodelElements(aasIdentifier, submodelIdentifier, level, content, extent);
            //Assert.IsInstanceOf<List<SubmodelElement>> (response, "response is List<SubmodelElement>");
        }
        /// <summary>
        /// Test GetAllSubmodelElementsSubmodelRepo
        /// </summary>
        [Test]
        public void GetAllSubmodelElementsSubmodelRepoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string submodelIdentifier = null;
            //string level = null;
            //string content = null;
            //string extent = null;
            //var response = instance.GetAllSubmodelElementsSubmodelRepo(submodelIdentifier, level, content, extent);
            //Assert.IsInstanceOf<List<SubmodelElement>> (response, "response is List<SubmodelElement>");
        }
        /// <summary>
        /// Test GetAllSubmodelReferences
        /// </summary>
        [Test]
        public void GetAllSubmodelReferencesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string aasIdentifier = null;
            //var response = instance.GetAllSubmodelReferences(aasIdentifier);
            //Assert.IsInstanceOf<List<Reference>> (response, "response is List<Reference>");
        }
        /// <summary>
        /// Test GetAllSubmodels
        /// </summary>
        [Test]
        public void GetAllSubmodelsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string semanticId = null;
            //string idShort = null;
            //var response = instance.GetAllSubmodels(semanticId, idShort);
            //Assert.IsInstanceOf<List<Submodel>> (response, "response is List<Submodel>");
        }
        /// <summary>
        /// Test GetAssetAdministrationShell
        /// </summary>
        [Test]
        public void GetAssetAdministrationShellTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string aasIdentifier = null;
            //string content = null;
            //var response = instance.GetAssetAdministrationShell(aasIdentifier, content);
            //Assert.IsInstanceOf<AssetAdministrationShell> (response, "response is AssetAdministrationShell");
        }
        /// <summary>
        /// Test GetAssetAdministrationShellById
        /// </summary>
        [Test]
        public void GetAssetAdministrationShellByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string aasIdentifier = null;
            var response = instance.GetAssetAdministrationShellById("Test");
            Assert.IsInstanceOf<AssetAdministrationShell> (response, "response is AssetAdministrationShell");
        }
        /// <summary>
        /// Test GetAssetInformation
        /// </summary>
        [Test]
        public void GetAssetInformationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string aasIdentifier = null;
            //var response = instance.GetAssetInformation(aasIdentifier);
            //Assert.IsInstanceOf<AssetInformation> (response, "response is AssetInformation");
        }
        /// <summary>
        /// Test GetConceptDescriptionById
        /// </summary>
        [Test]
        public void GetConceptDescriptionByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string cdIdentifier = null;
            //var response = instance.GetConceptDescriptionById(cdIdentifier);
            //Assert.IsInstanceOf<ConceptDescription> (response, "response is ConceptDescription");
        }
        /// <summary>
        /// Test GetOperationAsyncResult
        /// </summary>
        [Test]
        public void GetOperationAsyncResultTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string aasIdentifier = null;
            //string submodelIdentifier = null;
            //string idShortPath = null;
            //string handleId = null;
            //string content = null;
            //var response = instance.GetOperationAsyncResult(aasIdentifier, submodelIdentifier, idShortPath, handleId, content);
            //Assert.IsInstanceOf<OperationResult> (response, "response is OperationResult");
        }
        /// <summary>
        /// Test GetOperationAsyncResultSubmodelRepo
        /// </summary>
        [Test]
        public void GetOperationAsyncResultSubmodelRepoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string submodelIdentifier = null;
            //string idShortPath = null;
            //string handleId = null;
            //string content = null;
            //var response = instance.GetOperationAsyncResultSubmodelRepo(submodelIdentifier, idShortPath, handleId, content);
            //Assert.IsInstanceOf<OperationResult> (response, "response is OperationResult");
        }
        /// <summary>
        /// Test GetSubmodel
        /// </summary>
        [Test]
        public void GetSubmodelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string aasIdentifier = null;
            //string submodelIdentifier = null;
            //string level = null;
            //string content = null;
            //string extent = null;
            //var response = instance.GetSubmodel(aasIdentifier, submodelIdentifier, level, content, extent);
            //Assert.IsInstanceOf<Submodel> (response, "response is Submodel");
        }
        /// <summary>
        /// Test GetSubmodelElementByPath
        /// </summary>
        [Test]
        public void GetSubmodelElementByPathTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string aasIdentifier = null;
            //string submodelIdentifier = null;
            //string idShortPath = null;
            //string level = null;
            //string content = null;
            //string extent = null;
            //var response = instance.GetSubmodelElementByPath(aasIdentifier, submodelIdentifier, idShortPath, level, content, extent);
            //Assert.IsInstanceOf<SubmodelElement> (response, "response is SubmodelElement");
        }
        /// <summary>
        /// Test GetSubmodelElementByPathSubmodelRepo
        /// </summary>
        [Test]
        public void GetSubmodelElementByPathSubmodelRepoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string submodelIdentifier = null;
            //string idShortPath = null;
            //string level = null;
            //string content = null;
            //string extent = null;
            //var response = instance.GetSubmodelElementByPathSubmodelRepo(submodelIdentifier, idShortPath, level, content, extent);
            //Assert.IsInstanceOf<SubmodelElement> (response, "response is SubmodelElement");
        }
        /// <summary>
        /// Test GetSubmodelSubmodelRepo
        /// </summary>
        [Test]
        public void GetSubmodelSubmodelRepoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string submodelIdentifier = null;
            //string level = null;
            //string content = null;
            //string extent = null;
            //var response = instance.GetSubmodelSubmodelRepo(submodelIdentifier, level, content, extent);
            //Assert.IsInstanceOf<Submodel> (response, "response is Submodel");
        }
        /// <summary>
        /// Test InvokeOperation
        /// </summary>
        [Test]
        public void InvokeOperationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //OperationRequest body = null;
            //string aasIdentifier = null;
            //string submodelIdentifier = null;
            //string idShortPath = null;
            //bool? async = null;
            //string content = null;
            //var response = instance.InvokeOperation(body, aasIdentifier, submodelIdentifier, idShortPath, async, content);
            //Assert.IsInstanceOf<OperationResult> (response, "response is OperationResult");
        }
        /// <summary>
        /// Test InvokeOperationSubmodelRepo
        /// </summary>
        [Test]
        public void InvokeOperationSubmodelRepoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //OperationRequest body = null;
            //string submodelIdentifier = null;
            //string idShortPath = null;
            //bool? async = null;
            //string content = null;
            //var response = instance.InvokeOperationSubmodelRepo(body, submodelIdentifier, idShortPath, async, content);
            //Assert.IsInstanceOf<OperationResult> (response, "response is OperationResult");
        }
        /// <summary>
        /// Test PostAssetAdministrationShell
        /// </summary>
        [Test]
        public void PostAssetAdministrationShellTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AssetAdministrationShell body = null;
            //var response = instance.PostAssetAdministrationShell(body);
            //Assert.IsInstanceOf<AssetAdministrationShell> (response, "response is AssetAdministrationShell");
        }
        /// <summary>
        /// Test PostConceptDescription
        /// </summary>
        [Test]
        public void PostConceptDescriptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ConceptDescription body = null;
            //var response = instance.PostConceptDescription(body);
            //Assert.IsInstanceOf<ConceptDescription> (response, "response is ConceptDescription");
        }
        /// <summary>
        /// Test PostSubmodel
        /// </summary>
        [Test]
        public void PostSubmodelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Submodel body = null;
            //var response = instance.PostSubmodel(body);
            //Assert.IsInstanceOf<Submodel> (response, "response is Submodel");
        }
        /// <summary>
        /// Test PostSubmodelElement
        /// </summary>
        [Test]
        public void PostSubmodelElementTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SubmodelElement body = null;
            //string aasIdentifier = null;
            //string submodelIdentifier = null;
            //string level = null;
            //string content = null;
            //string extent = null;
            //var response = instance.PostSubmodelElement(body, aasIdentifier, submodelIdentifier, level, content, extent);
            //Assert.IsInstanceOf<SubmodelElement> (response, "response is SubmodelElement");
        }
        /// <summary>
        /// Test PostSubmodelElementByPath
        /// </summary>
        [Test]
        public void PostSubmodelElementByPathTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SubmodelElement body = null;
            //string aasIdentifier = null;
            //string submodelIdentifier = null;
            //string idShortPath = null;
            //string level = null;
            //string content = null;
            //string extent = null;
            //var response = instance.PostSubmodelElementByPath(body, aasIdentifier, submodelIdentifier, idShortPath, level, content, extent);
            //Assert.IsInstanceOf<SubmodelElement> (response, "response is SubmodelElement");
        }
        /// <summary>
        /// Test PostSubmodelElementByPathSubmodelRepo
        /// </summary>
        [Test]
        public void PostSubmodelElementByPathSubmodelRepoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SubmodelElement body = null;
            //string submodelIdentifier = null;
            //string idShortPath = null;
            //string level = null;
            //string content = null;
            //string extent = null;
            //var response = instance.PostSubmodelElementByPathSubmodelRepo(body, submodelIdentifier, idShortPath, level, content, extent);
            //Assert.IsInstanceOf<SubmodelElement> (response, "response is SubmodelElement");
        }
        /// <summary>
        /// Test PostSubmodelElementSubmodelRepo
        /// </summary>
        [Test]
        public void PostSubmodelElementSubmodelRepoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SubmodelElement body = null;
            //string submodelIdentifier = null;
            //string level = null;
            //string content = null;
            //string extent = null;
            //var response = instance.PostSubmodelElementSubmodelRepo(body, submodelIdentifier, level, content, extent);
            //Assert.IsInstanceOf<SubmodelElement> (response, "response is SubmodelElement");
        }
        /// <summary>
        /// Test PostSubmodelReference
        /// </summary>
        [Test]
        public void PostSubmodelReferenceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Reference body = null;
            //string aasIdentifier = null;
            //var response = instance.PostSubmodelReference(body, aasIdentifier);
            //Assert.IsInstanceOf<Reference> (response, "response is Reference");
        }
        /// <summary>
        /// Test PutAssetAdministrationShell
        /// </summary>
        [Test]
        public void PutAssetAdministrationShellTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AssetAdministrationShell body = null;
            //string aasIdentifier = null;
            //string content = null;
            //instance.PutAssetAdministrationShell(body, aasIdentifier, content);
            
        }
        /// <summary>
        /// Test PutAssetAdministrationShellById
        /// </summary>
        [Test]
        public void PutAssetAdministrationShellByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AssetAdministrationShell body = null;
            //string aasIdentifier = null;
            //instance.PutAssetAdministrationShellById(body, aasIdentifier);
            
        }
        /// <summary>
        /// Test PutAssetInformation
        /// </summary>
        [Test]
        public void PutAssetInformationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AssetInformation body = null;
            //string aasIdentifier = null;
            //instance.PutAssetInformation(body, aasIdentifier);
            
        }
        /// <summary>
        /// Test PutConceptDescriptionById
        /// </summary>
        [Test]
        public void PutConceptDescriptionByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ConceptDescription body = null;
            //string cdIdentifier = null;
            //instance.PutConceptDescriptionById(body, cdIdentifier);
            
        }
        /// <summary>
        /// Test PutSubmodel
        /// </summary>
        [Test]
        public void PutSubmodelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Submodel body = null;
            //string aasIdentifier = null;
            //string submodelIdentifier = null;
            //string level = null;
            //string content = null;
            //string extent = null;
            //instance.PutSubmodel(body, aasIdentifier, submodelIdentifier, level, content, extent);
            
        }
        /// <summary>
        /// Test PutSubmodelElementByPath
        /// </summary>
        [Test]
        public void PutSubmodelElementByPathTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SubmodelElement body = null;
            //string aasIdentifier = null;
            //string submodelIdentifier = null;
            //string idShortPath = null;
            //string level = null;
            //string content = null;
            //string extent = null;
            //instance.PutSubmodelElementByPath(body, aasIdentifier, submodelIdentifier, idShortPath, level, content, extent);
            
        }
        /// <summary>
        /// Test PutSubmodelElementByPathSubmodelRepo
        /// </summary>
        [Test]
        public void PutSubmodelElementByPathSubmodelRepoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SubmodelElement body = null;
            //string submodelIdentifier = null;
            //string idShortPath = null;
            //string level = null;
            //string content = null;
            //string extent = null;
            //instance.PutSubmodelElementByPathSubmodelRepo(body, submodelIdentifier, idShortPath, level, content, extent);
            
        }
        /// <summary>
        /// Test PutSubmodelSubmodelRepo
        /// </summary>
        [Test]
        public void PutSubmodelSubmodelRepoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Submodel body = null;
            //string submodelIdentifier = null;
            //string level = null;
            //string content = null;
            //string extent = null;
            //instance.PutSubmodelSubmodelRepo(body, submodelIdentifier, level, content, extent);
            
        }
    }

}
