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
    [TechTalk.SpecRun.FeatureAttribute("DateTesting", SourceFile="DateTesting.feature", SourceLine=0)]
    public partial class DateTestingFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "DateTesting.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "DateTesting", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [TechTalk.SpecRun.ScenarioAttribute("Test all Date and Time formats", new string[] {
                "Cleanup",
                "API",
                "Chrome"}, SourceLine=5)]
        public virtual void TestAllDateAndTimeFormats()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Test all Date and Time formats", null, new string[] {
                        "Cleanup",
                        "API",
                        "Chrome"});
#line 6
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table61 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table61.AddRow(new string[] {
                        "Name",
                        "Testing Dates"});
            table61.AddRow(new string[] {
                        "Date Only",
                        "1-1-2010"});
            table61.AddRow(new string[] {
                        "User Local Date Only",
                        "1-1-2010"});
            table61.AddRow(new string[] {
                        "User Local Date Time",
                        "1-1-2010 10:00"});
            table61.AddRow(new string[] {
                        "Time Zone Independent Date Only",
                        "1-1-2010"});
            table61.AddRow(new string[] {
                        "Time Zone Independent Date Time",
                        "1-1-2010 10:00"});
#line 7
testRunner.Given("a mv_datetester named TestDateTime with the following values", ((string)(null)), table61, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table62 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table62.AddRow(new string[] {
                        "Date Only",
                        "1-1-2010"});
            table62.AddRow(new string[] {
                        "User Local Date Only",
                        "1-1-2010"});
            table62.AddRow(new string[] {
                        "User Local Date Time",
                        "1-1-2010 10:00"});
            table62.AddRow(new string[] {
                        "Time Zone Independent Date Only",
                        "1-1-2010"});
            table62.AddRow(new string[] {
                        "Time Zone Independent Date Time",
                        "1-1-2010 10:00"});
#line 15
testRunner.Then("TestDateTime has the following values", ((string)(null)), table62, "Then ");
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
