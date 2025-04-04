// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core.TestFramework;

namespace Azure.AI.Language.Text.Authoring.Tests
{
    public class AuthoringClientTestEnvironment : TestEnvironment
    {
        public Uri Endpoint => new(GetRecordedVariable("AZURE_TEXT_AUTHORING_ENDPOINT"));

        public string ApiKey => GetRecordedVariable("AZURE_TEXT_AUTHORING_KEY", options => options.IsSecret());

        public string CTProjectName => GetRecordedVariable("AZURE_TEXT_AUTHORING_CUSTOM_PROJECT");

        public string CTDeploymentName => GetRecordedVariable("AZURE_TEXT_AUTHORING_CUSTOM_DEPLOYMENT");

        public string CSCProjectName => GetRecordedVariable("AZURE_TEXT_AUTHORING_SINGLE_CLASSIFICATION_PROJECT");

        public string CSCDeploymentName => GetRecordedVariable("AZURE_TEXT_AUTHORING_SINGLE_CLASSIFICATION_DEPLOYMENT");

        public string CMCProjectName => GetRecordedVariable("AZURE_TEXT_AUTHORING_MULTI_CLASSIFICATION_PROJECT");

        public string CMCDeploymentName => GetRecordedVariable("AZURE_TEXT_AUTHORING_MULTI_CLASSIFICATION_DEPLOYMENT");

        public string ProjectDescription => GetRecordedVariable("AZURE_TEXT_AUTHORING_PROJECT_DESCRIPTION");

        public string ProjectLanguage => GetRecordedVariable("AZURE_TEXT_AUTHORING_PROJECT_LANGUAGE");
    }
}
