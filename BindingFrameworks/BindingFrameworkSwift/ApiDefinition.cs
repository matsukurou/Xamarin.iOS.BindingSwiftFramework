using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace BindingFrameworkSwift
{
	partial interface Constants
	{
		// extern double FrameworkObjCVersionNumber;
		[Field ("FrameworkObjCVersionNumber", "__Internal")]
		double FrameworkObjCVersionNumber { get; }

		// extern const unsigned char [] FrameworkObjCVersionString;
		[Field ("FrameworkObjCVersionString", "__Internal")]
		byte[] FrameworkObjCVersionString { get; }
	}

	// @interface FrameworkObjC : NSObject
	[BaseType (typeof(NSObject))]
	interface FrameworkObjC
	{
		// +(id)initMyClass;
		[Static]
		[Export ("initMyClass")]
		NSObject InitMyClass { get; }

		// +(void)start;
		[Static]
		[Export ("start")]
		void Start ();

		// -(void)startPrint;
		[Export ("startPrint")]
		void StartPrint ();
	}
}

