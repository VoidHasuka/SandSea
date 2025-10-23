// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class SandSea : ModuleRules
{
	public SandSea(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"SandSea",
			"SandSea/Variant_Platforming",
			"SandSea/Variant_Platforming/Animation",
			"SandSea/Variant_Combat",
			"SandSea/Variant_Combat/AI",
			"SandSea/Variant_Combat/Animation",
			"SandSea/Variant_Combat/Gameplay",
			"SandSea/Variant_Combat/Interfaces",
			"SandSea/Variant_Combat/UI",
			"SandSea/Variant_SideScrolling",
			"SandSea/Variant_SideScrolling/AI",
			"SandSea/Variant_SideScrolling/Gameplay",
			"SandSea/Variant_SideScrolling/Interfaces",
			"SandSea/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
