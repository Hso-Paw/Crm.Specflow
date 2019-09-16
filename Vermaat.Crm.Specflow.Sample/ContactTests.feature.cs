// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Vermaat.Crm.Specflow.Sample
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("ContactTests", Description="Some tests specific to the contact entity. \r\nUsed to show tests that use unusual " +
        "fields like the address and composite fields", SourceFile="ContactTests.feature", SourceLine=0)]
    public partial class ContactTestsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ContactTests.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ContactTests", "Some tests specific to the contact entity. \r\nUsed to show tests that use unusual " +
                    "fields like the address and composite fields", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Basic contact test", new string[] {
                "API",
                "Chrome",
                "Cleanup"}, SourceLine=5)]
        public virtual void BasicContactTest()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Basic contact test", null, new string[] {
                        "API",
                        "Chrome",
                        "Cleanup"});
#line 6
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table44 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table44.AddRow(new string[] {
                        "First Name",
                        "John"});
            table44.AddRow(new string[] {
                        "Last Name",
                        "Smith"});
            table44.AddRow(new string[] {
                        "Job Title",
                        "CLO"});
#line 7
testRunner.Given("a contact named TestContact with the following values", ((string)(null)), table44, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table45 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table45.AddRow(new string[] {
                        "First Name",
                        "Jerry"});
            table45.AddRow(new string[] {
                        "Job Title",
                        "Chief Lazyness Officer"});
#line 12
testRunner.When("TestContact is updated with the following values", ((string)(null)), table45, "When ");
#line hidden
            TechTalk.SpecFlow.Table table46 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table46.AddRow(new string[] {
                        "First Name",
                        "Jerry"});
            table46.AddRow(new string[] {
                        "Last Name",
                        "Smith"});
            table46.AddRow(new string[] {
                        "Job Title",
                        "Chief Lazyness Officer"});
#line 16
testRunner.Then("TestContact has the following values", ((string)(null)), table46, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Lookup with multiple results tests", new string[] {
                "Chrome",
                "Cleanup"}, SourceLine=22)]
        public virtual void LookupWithMultipleResultsTests()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Lookup with multiple results tests", null, new string[] {
                        "Chrome",
                        "Cleanup"});
#line 23
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table47 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table47.AddRow(new string[] {
                        "Account Name",
                        "DynamicHands"});
            table47.AddRow(new string[] {
                        "Main Phone",
                        "0612345678"});
            table47.AddRow(new string[] {
                        "Website",
                        "https://dynamichands.nl"});
            table47.AddRow(new string[] {
                        "Industry",
                        "Consulting"});
#line 24
testRunner.Given("an account named FirstAccount with the following values", ((string)(null)), table47, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table48 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table48.AddRow(new string[] {
                        "Account Name",
                        "DynamicHands"});
            table48.AddRow(new string[] {
                        "Main Phone",
                        "0612345678"});
            table48.AddRow(new string[] {
                        "Website",
                        "https://dynamichands.nl"});
            table48.AddRow(new string[] {
                        "Industry",
                        "Consulting"});
#line 30
testRunner.And("an account named SecondAccount with the following values", ((string)(null)), table48, "And ");
#line hidden
            TechTalk.SpecFlow.Table table49 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table49.AddRow(new string[] {
                        "First Name",
                        "Jerry"});
            table49.AddRow(new string[] {
                        "Last Name",
                        "Smith"});
            table49.AddRow(new string[] {
                        "Company Name",
                        "SecondAccount"});
            table49.AddRow(new string[] {
                        "Email",
                        "someone@test.com"});
#line 36
testRunner.When("a contact named TestLookup is created with the following values", ((string)(null)), table49, "When ");
#line hidden
            TechTalk.SpecFlow.Table table50 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table50.AddRow(new string[] {
                        "First Name",
                        "Jerry"});
            table50.AddRow(new string[] {
                        "Last Name",
                        "Smith"});
            table50.AddRow(new string[] {
                        "Company Name",
                        "SecondAccount"});
            table50.AddRow(new string[] {
                        "Email",
                        "someone@test.com"});
#line 42
testRunner.Then("TestLookup has the following values", ((string)(null)), table50, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Check required of form items", new string[] {
                "Chrome",
                "Cleanup"}, SourceLine=49)]
        public virtual void CheckRequiredOfFormItems()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check required of form items", null, new string[] {
                        "Chrome",
                        "Cleanup"});
#line 50
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table51 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table51.AddRow(new string[] {
                        "First Name",
                        "John"});
            table51.AddRow(new string[] {
                        "Last Name",
                        "Smith"});
            table51.AddRow(new string[] {
                        "Job Title",
                        "CLO"});
#line 51
testRunner.Given("a contact named TestContact with the following values", ((string)(null)), table51, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table52 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "State"});
            table52.AddRow(new string[] {
                        "First Name",
                        "Recommended"});
            table52.AddRow(new string[] {
                        "Last Name",
                        "Required"});
            table52.AddRow(new string[] {
                        "Job Title",
                        "Optional"});
#line 56
testRunner.Then("TestContact\'s form has the following form state", ((string)(null)), table52, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Check locked state of form items", new string[] {
                "Chrome",
                "Cleanup"}, SourceLine=62)]
        public virtual void CheckLockedStateOfFormItems()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check locked state of form items", null, new string[] {
                        "Chrome",
                        "Cleanup"});
#line 63
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table53 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table53.AddRow(new string[] {
                        "First Name",
                        "John"});
            table53.AddRow(new string[] {
                        "Last Name",
                        "Smith"});
            table53.AddRow(new string[] {
                        "Job Title",
                        "CLO"});
#line 64
testRunner.Given("a contact named TestContact with the following values", ((string)(null)), table53, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table54 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "State"});
            table54.AddRow(new string[] {
                        "First Name",
                        "Unlocked"});
            table54.AddRow(new string[] {
                        "Last Date Included in Campaign",
                        "Locked"});
#line 69
testRunner.Then("TestContact\'s form has the following form state", ((string)(null)), table54, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Check combined state of form items", new string[] {
                "Chrome",
                "Cleanup"}, SourceLine=74)]
        public virtual void CheckCombinedStateOfFormItems()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check combined state of form items", null, new string[] {
                        "Chrome",
                        "Cleanup"});
#line 75
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table55 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table55.AddRow(new string[] {
                        "First Name",
                        "John"});
            table55.AddRow(new string[] {
                        "Last Name",
                        "Smith"});
            table55.AddRow(new string[] {
                        "Job Title",
                        "CLO"});
#line 76
testRunner.Given("a contact named TestContact with the following values", ((string)(null)), table55, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table56 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "State"});
            table56.AddRow(new string[] {
                        "First Name",
                        "Recommended, Unlocked, Visible"});
            table56.AddRow(new string[] {
                        "Last Name",
                        "Required, Unlocked, Visible"});
            table56.AddRow(new string[] {
                        "Job Title",
                        "Optional, Unlocked, Visible"});
            table56.AddRow(new string[] {
                        "Last Date Included in Campaign",
                        "Locked, Optional, Visible"});
#line 81
testRunner.Then("TestContact\'s form has the following form state", ((string)(null)), table56, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Filling Date Only fields", new string[] {
                "Cleanup",
                "Chrome",
                "API"}, SourceLine=88)]
        public virtual void FillingDateOnlyFields()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Filling Date Only fields", null, new string[] {
                        "Cleanup",
                        "Chrome",
                        "API"});
#line 89
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table57 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table57.AddRow(new string[] {
                        "First Name",
                        "John"});
            table57.AddRow(new string[] {
                        "Last Name",
                        "Smith"});
            table57.AddRow(new string[] {
                        "Job Title",
                        "CLO"});
            table57.AddRow(new string[] {
                        "Birthday",
                        "20-05-1985"});
            table57.AddRow(new string[] {
                        "Anniversary",
                        "10-10-2010"});
#line 90
testRunner.Given("a contact named TestContact with the following values", ((string)(null)), table57, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table58 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table58.AddRow(new string[] {
                        "First Name",
                        "John"});
            table58.AddRow(new string[] {
                        "Last Name",
                        "Smith"});
            table58.AddRow(new string[] {
                        "Job Title",
                        "CLO"});
            table58.AddRow(new string[] {
                        "Birthday",
                        "20-05-1985"});
            table58.AddRow(new string[] {
                        "Anniversary",
                        "10-10-2010"});
#line 97
testRunner.Then("TestContact has the following values", ((string)(null)), table58, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Wait for Async processes to finish", new string[] {
                "Cleanup",
                "API"}, SourceLine=105)]
        public virtual void WaitForAsyncProcessesToFinish()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Wait for Async processes to finish", null, new string[] {
                        "Cleanup",
                        "API"});
#line 106
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table59 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table59.AddRow(new string[] {
                        "Account Name",
                        "AsyncTest"});
#line 107
testRunner.Given("an account named TestAccount with the following values", ((string)(null)), table59, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table60 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table60.AddRow(new string[] {
                        "First Name",
                        "John"});
            table60.AddRow(new string[] {
                        "Last Name",
                        "Smith"});
            table60.AddRow(new string[] {
                        "Company Name",
                        "TestAccount"});
#line 110
testRunner.And("a contact named TestContact with the following values", ((string)(null)), table60, "And ");
#line 115
testRunner.When("all asynchronous processes for TestContact are finished", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table61 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table61.AddRow(new string[] {
                        "Contact Present",
                        "Yes"});
#line 116
testRunner.Then("TestAccount has the following values", ((string)(null)), table61, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Basic Lookup test - Special Characters", new string[] {
                "Chrome",
                "Cleanup"}, SourceLine=120)]
        public virtual void BasicLookupTest_SpecialCharacters()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Basic Lookup test - Special Characters", null, new string[] {
                        "Chrome",
                        "Cleanup"});
#line 121
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table62 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table62.AddRow(new string[] {
                        "Account Name",
                        "Thïs \\s a \' Special \" Chácactèr Test/"});
            table62.AddRow(new string[] {
                        "Main Phone",
                        "0612345678"});
            table62.AddRow(new string[] {
                        "Website",
                        "https://dynamichands.nl"});
            table62.AddRow(new string[] {
                        "Industry",
                        "Consulting"});
#line 122
testRunner.Given("an account named FirstAccount with the following values", ((string)(null)), table62, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table63 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table63.AddRow(new string[] {
                        "First Name",
                        "Jerry"});
            table63.AddRow(new string[] {
                        "Last Name",
                        "Smith"});
            table63.AddRow(new string[] {
                        "Company Name",
                        "FirstAccount"});
            table63.AddRow(new string[] {
                        "Email",
                        "someone@test.com"});
#line 128
testRunner.When("a contact named TestLookup is created with the following values", ((string)(null)), table63, "When ");
#line hidden
            TechTalk.SpecFlow.Table table64 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table64.AddRow(new string[] {
                        "First Name",
                        "Jerry"});
            table64.AddRow(new string[] {
                        "Last Name",
                        "Smith"});
            table64.AddRow(new string[] {
                        "Company Name",
                        "FirstAccount"});
            table64.AddRow(new string[] {
                        "Email",
                        "someone@test.com"});
#line 134
testRunner.Then("TestLookup has the following values", ((string)(null)), table64, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
