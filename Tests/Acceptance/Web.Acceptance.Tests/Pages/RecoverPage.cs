﻿using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SecurityEssentials.Acceptance.Tests.Web.Pages
{
	public class RecoverPage : BasePage
	{

		private IWebElement UserName
		{
			get { return this.GetVisibleWebElement(By.Id("UserName")); }
		}

		private IWebElement RecoverButton
		{
			get { return this.GetVisibleWebElement(By.Id("recoverButton")); }
		}

		public RecoverPage(IWebDriver webDriver, Uri baseUri)
			: base(webDriver, baseUri, PageTitles.RECOVER)
		{
		}


		public void EnterDetails(Table table)
		{

			foreach (var row in table.Rows)
			{
				switch (row[0].ToLower())
				{
					case "username":
						UserName.SendKeys(row[1]);
						break;
					default:
						throw new Exception(string.Format("Field {0} not defined", row[0]));
				}
			}
		}

		public void ClickSubmit()
		{
			RecoverButton.Click();
		}

	}

}
