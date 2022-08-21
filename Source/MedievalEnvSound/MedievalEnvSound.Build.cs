// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class MedievalEnvSound : ModuleRules
{
	public MedievalEnvSound(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay", "AkAudio" });
	}
}
