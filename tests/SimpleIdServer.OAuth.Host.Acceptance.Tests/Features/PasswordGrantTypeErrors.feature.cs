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
namespace SimpleIdServer.OAuth.Host.Acceptance.Tests.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class PasswordGrantTypeErrorsFeature : object, Xunit.IClassFixture<PasswordGrantTypeErrorsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "PasswordGrantTypeErrors.feature"
#line hidden
        
        public PasswordGrantTypeErrorsFeature(PasswordGrantTypeErrorsFeature.FixtureData fixtureData, SimpleIdServer_OAuth_Host_Acceptance_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "PasswordGrantTypeErrors", "\tCheck errors returned when using \'password\' grant-type", ProgrammingLanguage.CSharp, featureTags);
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
        
        [Xunit.SkippableFactAttribute(DisplayName="Send \'grant_type=password\' with no username parameter")]
        [Xunit.TraitAttribute("FeatureTitle", "PasswordGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "Send \'grant_type=password\' with no username parameter")]
        public void SendGrant_TypePasswordWithNoUsernameParameter()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Send \'grant_type=password\' with no username parameter", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
                TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table22.AddRow(new string[] {
                            "grant_type",
                            "password"});
#line 5
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table22, "When ");
#line hidden
#line 9
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 10
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 11
 testRunner.And("JSON \'$.error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
 testRunner.And("JSON \'$.error_description\'=\'missing parameter username\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Send \'grant_type=password,username=user\' with no password parameter")]
        [Xunit.TraitAttribute("FeatureTitle", "PasswordGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "Send \'grant_type=password,username=user\' with no password parameter")]
        public void SendGrant_TypePasswordUsernameUserWithNoPasswordParameter()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Send \'grant_type=password,username=user\' with no password parameter", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 14
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table23.AddRow(new string[] {
                            "grant_type",
                            "password"});
                table23.AddRow(new string[] {
                            "username",
                            "user"});
#line 15
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table23, "When ");
#line hidden
#line 20
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 21
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 22
 testRunner.And("JSON \'$.error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 23
 testRunner.And("JSON \'$.error_description\'=\'missing parameter password\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Send \'grant_type=password,username=user,password=pwd\' with no client_id")]
        [Xunit.TraitAttribute("FeatureTitle", "PasswordGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "Send \'grant_type=password,username=user,password=pwd\' with no client_id")]
        public void SendGrant_TypePasswordUsernameUserPasswordPwdWithNoClient_Id()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Send \'grant_type=password,username=user,password=pwd\' with no client_id", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 25
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table24.AddRow(new string[] {
                            "grant_type",
                            "password"});
                table24.AddRow(new string[] {
                            "username",
                            "user"});
                table24.AddRow(new string[] {
                            "password",
                            "pwd"});
#line 26
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table24, "When ");
#line hidden
#line 32
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 33
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 34
 testRunner.And("JSON \'$.error\'=\'invalid_client\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 35
 testRunner.And("JSON \'$.error_description\'=\'missing client_id\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Send \'grant_type=password,username=user,password=pwd\' with invalid client_id")]
        [Xunit.TraitAttribute("FeatureTitle", "PasswordGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "Send \'grant_type=password,username=user,password=pwd\' with invalid client_id")]
        public void SendGrant_TypePasswordUsernameUserPasswordPwdWithInvalidClient_Id()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Send \'grant_type=password,username=user,password=pwd\' with invalid client_id", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 37
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table25.AddRow(new string[] {
                            "grant_type",
                            "password"});
                table25.AddRow(new string[] {
                            "username",
                            "user"});
                table25.AddRow(new string[] {
                            "password",
                            "pwd"});
                table25.AddRow(new string[] {
                            "client_id",
                            "c"});
#line 38
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table25, "When ");
#line hidden
#line 45
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 46
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 47
 testRunner.And("JSON \'$.error\'=\'invalid_client\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 48
 testRunner.And("JSON \'$.error_description\'=\'unknown client c\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Send \'grant_type=password,username=user,password=pwd,client_id=firstClient\' with " +
            "no client_secret")]
        [Xunit.TraitAttribute("FeatureTitle", "PasswordGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "Send \'grant_type=password,username=user,password=pwd,client_id=firstClient\' with " +
            "no client_secret")]
        public void SendGrant_TypePasswordUsernameUserPasswordPwdClient_IdFirstClientWithNoClient_Secret()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Send \'grant_type=password,username=user,password=pwd,client_id=firstClient\' with " +
                    "no client_secret", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 50
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table26 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table26.AddRow(new string[] {
                            "grant_type",
                            "password"});
                table26.AddRow(new string[] {
                            "username",
                            "user"});
                table26.AddRow(new string[] {
                            "password",
                            "pwd"});
                table26.AddRow(new string[] {
                            "client_id",
                            "firstClient"});
#line 51
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table26, "When ");
#line hidden
#line 58
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 59
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 60
 testRunner.And("JSON \'$.error\'=\'invalid_client\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 61
 testRunner.And("JSON \'$.error_description\'=\'bad client credential\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Send \'grant_type=password,username=user,password=pwd,client_id=firstClient,client" +
            "_secret=bad\' with bad client_secret")]
        [Xunit.TraitAttribute("FeatureTitle", "PasswordGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "Send \'grant_type=password,username=user,password=pwd,client_id=firstClient,client" +
            "_secret=bad\' with bad client_secret")]
        public void SendGrant_TypePasswordUsernameUserPasswordPwdClient_IdFirstClientClient_SecretBadWithBadClient_Secret()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Send \'grant_type=password,username=user,password=pwd,client_id=firstClient,client" +
                    "_secret=bad\' with bad client_secret", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 63
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table27 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table27.AddRow(new string[] {
                            "grant_type",
                            "password"});
                table27.AddRow(new string[] {
                            "username",
                            "user"});
                table27.AddRow(new string[] {
                            "password",
                            "pwd"});
                table27.AddRow(new string[] {
                            "client_id",
                            "firstClient"});
                table27.AddRow(new string[] {
                            "client_secret",
                            "bad"});
#line 64
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table27, "When ");
#line hidden
#line 72
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 73
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 74
 testRunner.And("JSON \'$.error\'=\'invalid_client\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 75
 testRunner.And("JSON \'$.error_description\'=\'bad client credential\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Send \'grant_type=password,username=user,password=pwd,client_id=firstClient,client" +
            "_secret=password\' with unauthorized grant_type")]
        [Xunit.TraitAttribute("FeatureTitle", "PasswordGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "Send \'grant_type=password,username=user,password=pwd,client_id=firstClient,client" +
            "_secret=password\' with unauthorized grant_type")]
        public void SendGrant_TypePasswordUsernameUserPasswordPwdClient_IdFirstClientClient_SecretPasswordWithUnauthorizedGrant_Type()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Send \'grant_type=password,username=user,password=pwd,client_id=firstClient,client" +
                    "_secret=password\' with unauthorized grant_type", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 77
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table28 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table28.AddRow(new string[] {
                            "grant_type",
                            "password"});
                table28.AddRow(new string[] {
                            "username",
                            "user"});
                table28.AddRow(new string[] {
                            "password",
                            "pwd"});
                table28.AddRow(new string[] {
                            "client_id",
                            "firstClient"});
                table28.AddRow(new string[] {
                            "client_secret",
                            "password"});
#line 78
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table28, "When ");
#line hidden
#line 86
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 87
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 88
 testRunner.And("JSON \'$.error\'=\'invalid_client\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 89
 testRunner.And("JSON \'$.error_description\'=\'grant type password is not supported by the client\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Send \'grant_type=password,username=user,password=pwd,client_id=secondClient,clien" +
            "t_secret=password\' with duplicate scopes")]
        [Xunit.TraitAttribute("FeatureTitle", "PasswordGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "Send \'grant_type=password,username=user,password=pwd,client_id=secondClient,clien" +
            "t_secret=password\' with duplicate scopes")]
        public void SendGrant_TypePasswordUsernameUserPasswordPwdClient_IdSecondClientClient_SecretPasswordWithDuplicateScopes()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Send \'grant_type=password,username=user,password=pwd,client_id=secondClient,clien" +
                    "t_secret=password\' with duplicate scopes", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 91
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table29 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table29.AddRow(new string[] {
                            "grant_type",
                            "password"});
                table29.AddRow(new string[] {
                            "username",
                            "user"});
                table29.AddRow(new string[] {
                            "password",
                            "pwd"});
                table29.AddRow(new string[] {
                            "client_id",
                            "secondClient"});
                table29.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table29.AddRow(new string[] {
                            "scope",
                            "scope scope"});
#line 92
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table29, "When ");
#line hidden
#line 101
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 102
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 103
 testRunner.And("JSON \'$.error\'=\'invalid_scope\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 104
 testRunner.And("JSON \'$.error_description\'=\'duplicate scopes : scope\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Send \'grant_type=password,username=user,password=pwd,client_id=secondClient,clien" +
            "t_secret=password\' with invalid scope")]
        [Xunit.TraitAttribute("FeatureTitle", "PasswordGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "Send \'grant_type=password,username=user,password=pwd,client_id=secondClient,clien" +
            "t_secret=password\' with invalid scope")]
        public void SendGrant_TypePasswordUsernameUserPasswordPwdClient_IdSecondClientClient_SecretPasswordWithInvalidScope()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Send \'grant_type=password,username=user,password=pwd,client_id=secondClient,clien" +
                    "t_secret=password\' with invalid scope", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 106
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table30 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table30.AddRow(new string[] {
                            "grant_type",
                            "password"});
                table30.AddRow(new string[] {
                            "username",
                            "user"});
                table30.AddRow(new string[] {
                            "password",
                            "pwd"});
                table30.AddRow(new string[] {
                            "client_id",
                            "secondClient"});
                table30.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table30.AddRow(new string[] {
                            "scope",
                            "scope"});
#line 107
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table30, "When ");
#line hidden
#line 116
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 117
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 118
 testRunner.And("JSON \'$.error\'=\'invalid_scope\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 119
 testRunner.And("JSON \'$.error_description\'=\'unauthorized to scopes : scope\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Send \'grant_type=password,username=user,password=pwd,client_id=secondClient,clien" +
            "t_secret=password,scope=firstScope\' with bad user login")]
        [Xunit.TraitAttribute("FeatureTitle", "PasswordGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "Send \'grant_type=password,username=user,password=pwd,client_id=secondClient,clien" +
            "t_secret=password,scope=firstScope\' with bad user login")]
        public void SendGrant_TypePasswordUsernameUserPasswordPwdClient_IdSecondClientClient_SecretPasswordScopeFirstScopeWithBadUserLogin()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Send \'grant_type=password,username=user,password=pwd,client_id=secondClient,clien" +
                    "t_secret=password,scope=firstScope\' with bad user login", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 121
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table31 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table31.AddRow(new string[] {
                            "grant_type",
                            "password"});
                table31.AddRow(new string[] {
                            "username",
                            "badUser"});
                table31.AddRow(new string[] {
                            "password",
                            "badPwd"});
                table31.AddRow(new string[] {
                            "client_id",
                            "secondClient"});
                table31.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table31.AddRow(new string[] {
                            "scope",
                            "firstScope"});
#line 122
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table31, "When ");
#line hidden
#line 131
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 132
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 133
 testRunner.And("JSON \'$.error\'=\'invalid_grant\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 134
 testRunner.And("JSON \'$.error_description\'=\'bad user credential\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Send \'grant_type=password,username=user,password=pwd,client_id=secondClient,clien" +
            "t_secret=password,scope=firstScope\' with bad user password")]
        [Xunit.TraitAttribute("FeatureTitle", "PasswordGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "Send \'grant_type=password,username=user,password=pwd,client_id=secondClient,clien" +
            "t_secret=password,scope=firstScope\' with bad user password")]
        public void SendGrant_TypePasswordUsernameUserPasswordPwdClient_IdSecondClientClient_SecretPasswordScopeFirstScopeWithBadUserPassword()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Send \'grant_type=password,username=user,password=pwd,client_id=secondClient,clien" +
                    "t_secret=password,scope=firstScope\' with bad user password", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 136
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table32 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table32.AddRow(new string[] {
                            "grant_type",
                            "password"});
                table32.AddRow(new string[] {
                            "username",
                            "user"});
                table32.AddRow(new string[] {
                            "password",
                            "badPwd"});
                table32.AddRow(new string[] {
                            "client_id",
                            "secondClient"});
                table32.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table32.AddRow(new string[] {
                            "scope",
                            "firstScope"});
#line 137
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table32, "When ");
#line hidden
#line 146
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 147
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 148
 testRunner.And("JSON \'$.error\'=\'invalid_grant\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 149
 testRunner.And("JSON \'$.error_description\'=\'bad user credential\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
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
                PasswordGrantTypeErrorsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                PasswordGrantTypeErrorsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
