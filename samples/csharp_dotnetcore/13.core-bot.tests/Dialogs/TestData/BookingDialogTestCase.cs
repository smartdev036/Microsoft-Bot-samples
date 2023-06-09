﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Microsoft.BotBuilderSamples;

namespace CoreBot.Tests.Dialogs.TestData
{
    /// <summary>
    /// A class to store test case data for <see cref="BookingDialogTests"/>.
    /// </summary>
    public class BookingDialogTestCase
    {
        public string Name { get; set; }

        public BookingDetails InitialBookingDetails { get; set; }
#pragma warning disable CA1819 // Properties should not return arrays
        public string[,] UtterancesAndReplies { get; set; }
#pragma warning restore CA1819 // Properties should not return arrays
        public BookingDetails ExpectedBookingDetails { get; set; }
    }
}
