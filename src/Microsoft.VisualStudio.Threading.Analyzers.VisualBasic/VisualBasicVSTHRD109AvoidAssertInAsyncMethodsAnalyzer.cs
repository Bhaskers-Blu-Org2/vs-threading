﻿// Copyright (c) Microsoft Corporation. All rights reserved.

namespace Microsoft.VisualStudio.Threading.Analyzers
{
    using Microsoft.CodeAnalysis;
    using Microsoft.CodeAnalysis.Diagnostics;

    [DiagnosticAnalyzer(LanguageNames.VisualBasic)]
    public sealed class VisualBasicVSTHRD109AvoidAssertInAsyncMethodsAnalyzer : AbstractVSTHRD109AvoidAssertInAsyncMethodsAnalyzer
    {
        private protected override LanguageUtils LanguageUtils => VisualBasicUtils.Instance;
    }
}
