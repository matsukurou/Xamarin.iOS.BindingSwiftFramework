using ObjCRuntime;

[assembly: LinkWith ("FrameworkObjC.a",
	LinkTarget.Arm64 | LinkTarget.ArmV7 | LinkTarget.Simulator | LinkTarget.Simulator64,
	Frameworks="UIKit Foundation",
	SmartLink = true,
	ForceLoad = true,
	LinkerFlags = "-lz -ObjC",
	IsCxx = true)]
