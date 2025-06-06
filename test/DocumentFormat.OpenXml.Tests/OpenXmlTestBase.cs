﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using LogUtil;
using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    public class OpenXmlTestBase
    {
        protected OpenXmlTestBase(ITestOutputHelper output)
        {
            Log = new VerifiableLog(output);
        }

        private protected VerifiableLog Log { get; }
    }
}
