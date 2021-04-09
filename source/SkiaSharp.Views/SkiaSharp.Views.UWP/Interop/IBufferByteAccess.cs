﻿using System;
using System.Runtime.InteropServices;

#if WINDOWS
namespace SkiaSharp.Views.Windows
#else
namespace SkiaSharp.Views.UWP
#endif
{
	[ComImport]
	[Guid("905a0fef-bc53-11df-8c49-001e4fc686da")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	internal interface IBufferByteAccess
	{
		long Buffer([Out] out IntPtr value);
	}
}
