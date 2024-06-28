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
namespace SimpleIdServer.IdServer.Host.Acceptance.Tests.Features.GrantTypes
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class RefreshTokenGrantTypeErrorsFeature : object, Xunit.IClassFixture<RefreshTokenGrantTypeErrorsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "RefreshTokenGrantTypeErrors.feature"
#line hidden
        
        public RefreshTokenGrantTypeErrorsFeature(RefreshTokenGrantTypeErrorsFeature.FixtureData fixtureData, SimpleIdServer_IdServer_Host_Acceptance_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/GrantTypes", "RefreshTokenGrantTypeErrors", "\tCheck errors returned when using \'refresh_token\' grant-type", ProgrammingLanguage.CSharp, featureTags);
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
        
        [Xunit.SkippableFactAttribute(DisplayName="Send \'grant_type=refresh_token\' with no refresh_token parameter")]
        [Xunit.TraitAttribute("FeatureTitle", "RefreshTokenGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "Send \'grant_type=refresh_token\' with no refresh_token parameter")]
        public void SendGrant_TypeRefresh_TokenWithNoRefresh_TokenParameter()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Send \'grant_type=refresh_token\' with no refresh_token parameter", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
                TechTalk.SpecFlow.Table table326 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table326.AddRow(new string[] {
                            "grant_type",
                            "refresh_token"});
#line 5
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table326, "When ");
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
 testRunner.And("JSON \'$.error_description\'=\'missing parameter refresh_token\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Send \'grant_type=refresh_token,refresh_token=rt\' with no client_id")]
        [Xunit.TraitAttribute("FeatureTitle", "RefreshTokenGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "Send \'grant_type=refresh_token,refresh_token=rt\' with no client_id")]
        public void SendGrant_TypeRefresh_TokenRefresh_TokenRtWithNoClient_Id()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Send \'grant_type=refresh_token,refresh_token=rt\' with no client_id", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
                TechTalk.SpecFlow.Table table327 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table327.AddRow(new string[] {
                            "grant_type",
                            "refresh_token"});
                table327.AddRow(new string[] {
                            "refresh_token",
                            "rt"});
#line 15
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table327, "When ");
#line hidden
#line 20
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 21
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 22
 testRunner.And("JSON \'$.error\'=\'invalid_client\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 23
 testRunner.And("JSON \'$.error_description\'=\'missing client_id\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Send \'grant_type=refresh_token,refresh_token=rt\' with invalid client_id")]
        [Xunit.TraitAttribute("FeatureTitle", "RefreshTokenGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "Send \'grant_type=refresh_token,refresh_token=rt\' with invalid client_id")]
        public void SendGrant_TypeRefresh_TokenRefresh_TokenRtWithInvalidClient_Id()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Send \'grant_type=refresh_token,refresh_token=rt\' with invalid client_id", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
                TechTalk.SpecFlow.Table table328 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table328.AddRow(new string[] {
                            "grant_type",
                            "refresh_token"});
                table328.AddRow(new string[] {
                            "refresh_token",
                            "rt"});
                table328.AddRow(new string[] {
                            "client_id",
                            "c"});
#line 26
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table328, "When ");
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
 testRunner.And("JSON \'$.error_description\'=\'unknown client c\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Send \'grant_type=refresh_token,refresh_token=rt,client_id=firstClient\' with no cl" +
            "ient_secret")]
        [Xunit.TraitAttribute("FeatureTitle", "RefreshTokenGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "Send \'grant_type=refresh_token,refresh_token=rt,client_id=firstClient\' with no cl" +
            "ient_secret")]
        public void SendGrant_TypeRefresh_TokenRefresh_TokenRtClient_IdFirstClientWithNoClient_Secret()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Send \'grant_type=refresh_token,refresh_token=rt,client_id=firstClient\' with no cl" +
                    "ient_secret", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
                TechTalk.SpecFlow.Table table329 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table329.AddRow(new string[] {
                            "grant_type",
                            "refresh_token"});
                table329.AddRow(new string[] {
                            "refresh_token",
                            "rt"});
                table329.AddRow(new string[] {
                            "client_id",
                            "firstClient"});
#line 38
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table329, "When ");
#line hidden
#line 44
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 45
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 46
 testRunner.And("JSON \'$.error\'=\'invalid_client\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 47
 testRunner.And("JSON \'$.error_description\'=\'bad client credential\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Send \'grant_type=refresh_token,refresh_token=rt,client_id=firstClient,client_secr" +
            "et=bad\' with bad client_secret")]
        [Xunit.TraitAttribute("FeatureTitle", "RefreshTokenGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "Send \'grant_type=refresh_token,refresh_token=rt,client_id=firstClient,client_secr" +
            "et=bad\' with bad client_secret")]
        public void SendGrant_TypeRefresh_TokenRefresh_TokenRtClient_IdFirstClientClient_SecretBadWithBadClient_Secret()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Send \'grant_type=refresh_token,refresh_token=rt,client_id=firstClient,client_secr" +
                    "et=bad\' with bad client_secret", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 49
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table330 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table330.AddRow(new string[] {
                            "grant_type",
                            "refresh_token"});
                table330.AddRow(new string[] {
                            "refresh_token",
                            "rt"});
                table330.AddRow(new string[] {
                            "client_id",
                            "firstClient"});
                table330.AddRow(new string[] {
                            "client_secret",
                            "bad"});
#line 50
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table330, "When ");
#line hidden
#line 57
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 58
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 59
 testRunner.And("JSON \'$.error\'=\'invalid_client\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 60
 testRunner.And("JSON \'$.error_description\'=\'bad client credential\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Send \'grant_type=refresh_token,refresh_token=rt,client_id=firstClient,client_secr" +
            "et=password\' with unauthorized grant_type")]
        [Xunit.TraitAttribute("FeatureTitle", "RefreshTokenGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "Send \'grant_type=refresh_token,refresh_token=rt,client_id=firstClient,client_secr" +
            "et=password\' with unauthorized grant_type")]
        public void SendGrant_TypeRefresh_TokenRefresh_TokenRtClient_IdFirstClientClient_SecretPasswordWithUnauthorizedGrant_Type()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Send \'grant_type=refresh_token,refresh_token=rt,client_id=firstClient,client_secr" +
                    "et=password\' with unauthorized grant_type", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 62
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table331 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table331.AddRow(new string[] {
                            "grant_type",
                            "refresh_token"});
                table331.AddRow(new string[] {
                            "refresh_token",
                            "rt"});
                table331.AddRow(new string[] {
                            "client_id",
                            "firstClient"});
                table331.AddRow(new string[] {
                            "client_secret",
                            "password"});
#line 63
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table331, "When ");
#line hidden
#line 70
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 71
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 72
 testRunner.And("JSON \'$.error\'=\'invalid_client\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 73
 testRunner.And("JSON \'$.error_description\'=\'grant type refresh_token is not supported by the clie" +
                        "nt\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Send \'grant_type=refresh_token,refresh_token=rt,client_id=fifthClient,client_secr" +
            "et=password\' with missing refresh_token")]
        [Xunit.TraitAttribute("FeatureTitle", "RefreshTokenGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "Send \'grant_type=refresh_token,refresh_token=rt,client_id=fifthClient,client_secr" +
            "et=password\' with missing refresh_token")]
        public void SendGrant_TypeRefresh_TokenRefresh_TokenRtClient_IdFifthClientClient_SecretPasswordWithMissingRefresh_Token()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Send \'grant_type=refresh_token,refresh_token=rt,client_id=fifthClient,client_secr" +
                    "et=password\' with missing refresh_token", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 75
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table332 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table332.AddRow(new string[] {
                            "grant_type",
                            "refresh_token"});
                table332.AddRow(new string[] {
                            "refresh_token",
                            "rt"});
                table332.AddRow(new string[] {
                            "client_id",
                            "fifthClient"});
                table332.AddRow(new string[] {
                            "client_secret",
                            "password"});
#line 76
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table332, "When ");
#line hidden
#line 83
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 84
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 85
 testRunner.And("JSON \'$.error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 86
 testRunner.And("JSON \'$.error_description\'=\'bad refresh token\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Send \'grant_type=refresh_token,refresh_token=$refreshtoken$,client_id=fifthClient" +
            ",client_secret=password\' with expired refresh_token")]
        [Xunit.TraitAttribute("FeatureTitle", "RefreshTokenGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "Send \'grant_type=refresh_token,refresh_token=$refreshtoken$,client_id=fifthClient" +
            ",client_secret=password\' with expired refresh_token")]
        public void SendGrant_TypeRefresh_TokenRefresh_TokenRefreshtokenClient_IdFifthClientClient_SecretPasswordWithExpiredRefresh_Token()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Send \'grant_type=refresh_token,refresh_token=$refreshtoken$,client_id=fifthClient" +
                    ",client_secret=password\' with expired refresh_token", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 88
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table333 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table333.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
                table333.AddRow(new string[] {
                            "scope",
                            "secondScope"});
                table333.AddRow(new string[] {
                            "client_id",
                            "fifthClient"});
                table333.AddRow(new string[] {
                            "client_secret",
                            "password"});
#line 89
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table333, "When ");
#line hidden
#line 96
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 97
 testRunner.And("extract parameter \'$.refresh_token\' from JSON body into \'refreshToken\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table334 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table334.AddRow(new string[] {
                            "grant_type",
                            "refresh_token"});
                table334.AddRow(new string[] {
                            "refresh_token",
                            "$refreshToken$"});
                table334.AddRow(new string[] {
                            "client_id",
                            "fifthClient"});
                table334.AddRow(new string[] {
                            "client_secret",
                            "password"});
#line 99
 testRunner.And("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table334, "And ");
#line hidden
#line 106
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 107
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 108
 testRunner.And("JSON \'$.error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 109
 testRunner.And("JSON \'$.error_description\'=\'refresh token is expired\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="DPoP must be bound to the access token")]
        [Xunit.TraitAttribute("FeatureTitle", "RefreshTokenGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "DPoP must be bound to the access token")]
        public void DPoPMustBeBoundToTheAccessToken()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DPoP must be bound to the access token", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 111
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table335 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table335.AddRow(new string[] {
                            "htm",
                            "POST"});
                table335.AddRow(new string[] {
                            "htu",
                            "https://localhost:8080/token"});
#line 112
 testRunner.When("build DPoP proof", ((string)(null)), table335, "When ");
#line hidden
                TechTalk.SpecFlow.Table table336 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table336.AddRow(new string[] {
                            "htm",
                            "POST"});
                table336.AddRow(new string[] {
                            "htu",
                            "https://localhost:8080/token"});
#line 117
 testRunner.And("build DPoP proof and store into \'DPOP2\'", ((string)(null)), table336, "And ");
#line hidden
                TechTalk.SpecFlow.Table table337 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table337.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
                table337.AddRow(new string[] {
                            "scope",
                            "firstScope"});
                table337.AddRow(new string[] {
                            "client_id",
                            "sixtyThreeClient"});
                table337.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table337.AddRow(new string[] {
                            "DPoP",
                            "$DPOP$"});
#line 122
 testRunner.And("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table337, "And ");
#line hidden
#line 130
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 131
 testRunner.And("extract parameter \'$.refresh_token\' from JSON body into \'refreshToken\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table338 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table338.AddRow(new string[] {
                            "grant_type",
                            "refresh_token"});
                table338.AddRow(new string[] {
                            "refresh_token",
                            "$refreshToken$"});
                table338.AddRow(new string[] {
                            "client_id",
                            "sixtyThreeClient"});
                table338.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table338.AddRow(new string[] {
                            "DPoP",
                            "$DPOP2$"});
#line 133
 testRunner.And("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table338, "And ");
#line hidden
#line 141
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 143
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 144
 testRunner.And("JSON \'$.error\'=\'invalid_dpop_proof\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 145
 testRunner.And("JSON \'$.error_description\'=\'DPoP must be bound to the access token\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
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
                RefreshTokenGrantTypeErrorsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                RefreshTokenGrantTypeErrorsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
