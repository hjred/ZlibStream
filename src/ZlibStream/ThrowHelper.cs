// Copyright (c) Six Labors.
// Licensed under the Apache License, Version 2.0.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace SixLabors.ZlibStream
{
    [DebuggerStepThrough]
    internal static class ThrowHelper
    {
        [MethodImpl(InliningOptions.ColdPath)]
        public static void ThrowNullException(string paramName)
            => throw new ArgumentNullException(paramName);

        [MethodImpl(InliningOptions.ColdPath)]
        public static void ThrowCompressionException(bool compressing, string message)
            => throw new ZlibStreamException((compressing ? "de" : "in") + "flating: " + message);
    }
}
