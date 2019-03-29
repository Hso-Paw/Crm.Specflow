﻿using Microsoft.Dynamics365.UIAutomation.Api.UCI;
using Microsoft.Dynamics365.UIAutomation.Browser;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using TechTalk.SpecFlow;

namespace Vermaat.Crm.Specflow.EasyRepro.UCI
{
    class UCIBrowserEntity : BaseBrowserEntity
    {
        private readonly WebClient _client;
        private readonly XrmApp _app;
        private readonly ButtonTexts _buttonTexts;

        public UCIBrowserEntity(UCIBrowser browser, WebClient client, XrmApp app, ButtonTexts buttonTexts) :
            base(browser)
        {
            _client = client;
            _app = app;
            _buttonTexts = buttonTexts;
        }

        public override void DeleteRecord()
        {
            _app.CommandBar.ClickCommand(_buttonTexts.Delete);
            _app.Dialogs.ConfirmationDialog(true);
        }

        public override Guid GetId()
        {
            return _app.Entity.GetObjectId();
        }

        public override bool IsFieldVisible(string fieldLogicalName)
        {
            return _client.Execute($"Is Field visible: {fieldLogicalName}", driver =>
            {
                return driver.WaitUntilVisible(By.Id(fieldLogicalName), TimeSpan.FromSeconds(5));
            });
        }

        public override void SaveRecord(bool saveIfDuplicate)
        {
            _app.CommandBar.ClickCommand(_buttonTexts.Save);
            // ThinkTime before call to DuplicateDetection, frame must be visible before the method call in order to succeed
            _app.ThinkTime(2000);
            _app.Dialogs.ConfirmationDialog(saveIfDuplicate);
            _app.ThinkTime(2000);
        }

        protected override IFormFiller CreateBrowserFiller()
        {
            return new UCIFormFiller(_app.Entity);
        }

        protected override IWebDriver GetWebDriver()
        {
            return _client.Browser.Driver;
        }

        protected override void SelectTab(string tabName)
        {
            _app.Entity.SelectTab(tabName);
        }
    }
}
