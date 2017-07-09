﻿// <copyright file="PreviewShoppingCartPageProceedBehaviour.cs" company="Automate The Planet Ltd.">
// Copyright 2016 Automate The Planet Ltd.
// Licensed under the Apache License, Version 2.0 (the "License");
// You may not use this file except in compliance with the License.
// You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// <author>Anton Angelov</author>
// <site>http://automatetheplanet.com/</site>

using Microsoft.Practices.Unity;
using SpecflowBehavioursDesignPattern.Base;
using SpecflowBehavioursDesignPattern.Behaviours.Core;
using SpecflowBehavioursDesignPattern.Pages.PreviewShoppingCartPage;
using SpecflowBehavioursDesignPattern.Pages.SignInPage;
using TechTalk.SpecFlow;

namespace SpecflowBehavioursDesignPattern.Behaviours.BindBehaviours
{
    [Binding]
    public class PreviewShoppingCartPageProceedBehaviour : WaitableActionBehaviour
    {
        private readonly PreviewShoppingCartPage _previewShoppingCartPage;
        private readonly SignInPage _signInPage;

        public PreviewShoppingCartPageProceedBehaviour()
        {
            _previewShoppingCartPage = UnityContainerFactory.GetContainer().Resolve<PreviewShoppingCartPage>();
            _signInPage = UnityContainerFactory.GetContainer().Resolve<SignInPage>(); 
        }

        [When(@"then I click the 'proceed to checkout' button")]
        public override void Execute()
        {
            base.Execute();
        }

        protected override void PerformAct()
        {
            _previewShoppingCartPage.ClickProceedToCheckoutButton();
        }

        protected override void PerformPostActWait()
        {
            _signInPage.WaitForPageToLoad();
        }
    }
}