﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SimpleIdServer.IdServer.Host.Acceptance.Tests.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class UMAPermissionsFeature : object, Xunit.IClassFixture<UMAPermissionsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "UMAPermissions.feature"
#line hidden
        
        public UMAPermissionsFeature(UMAPermissionsFeature.FixtureData fixtureData, SimpleIdServer_IdServer_Host_Acceptance_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "UMAPermissions", "\tCheck /perm endpoitn", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public void TestInitialize()
        {
        }
        
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="get a permisson ticket")]
        [Xunit.TraitAttribute("FeatureTitle", "UMAPermissions")]
        [Xunit.TraitAttribute("Description", "get a permisson ticket")]
        public void GetAPermissonTicket()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("get a permisson ticket", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 4
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table528 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table528.AddRow(new string[] {
                            "client_id",
                            "fiftyThreeClient"});
                table528.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table528.AddRow(new string[] {
                            "scope",
                            "uma_protection"});
                table528.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 5
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table528, "When ");
#line hidden
#line 12
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 13
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table529 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table529.AddRow(new string[] {
                            "resource_scopes",
                            "[\"scope1\",\"scope2\"]"});
                table529.AddRow(new string[] {
                            "subject",
                            "user1"});
                table529.AddRow(new string[] {
                            "icon_uri",
                            "icon"});
                table529.AddRow(new string[] {
                            "name#fr",
                            "nom"});
                table529.AddRow(new string[] {
                            "name#en",
                            "name"});
                table529.AddRow(new string[] {
                            "description#fr",
                            "descriptionFR"});
                table529.AddRow(new string[] {
                            "description#en",
                            "descriptionEN"});
                table529.AddRow(new string[] {
                            "type",
                            "type"});
                table529.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 15
 testRunner.And("execute HTTP POST JSON request \'http://localhost/rreguri\'", ((string)(null)), table529, "And ");
#line hidden
#line 27
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
 testRunner.And("extract parameter \'_id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table530 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table530.AddRow(new string[] {
                            "resource_id",
                            "$_id$"});
                table530.AddRow(new string[] {
                            "resource_scopes",
                            "[\"scope1\",\"scope2\"]"});
                table530.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 30
 testRunner.And("execute HTTP POST JSON request \'http://localhost/perm\'", ((string)(null)), table530, "And ");
#line hidden
#line 36
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 38
 testRunner.Then("HTTP status code equals to \'201\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 39
 testRunner.And("JSON exists \'ticket\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                UMAPermissionsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                UMAPermissionsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
