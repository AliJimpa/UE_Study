// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Nova : ModuleRules
{
	public Nova(ReadOnlyTargetRules Target) : base(Target)
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

        PrivateDependencyModuleNames.AddRange(new string[] {  });

        PublicIncludePaths.AddRange(new string[] {
            "Nova",
            //"Nova/TP_FirstPerson",
            //"Nova/TP_FirstPerson/Variant_Horror",
            //"Nova/TP_FirstPerson/Variant_Horror/UI",
            //"Nova/TP_FirstPerson/Variant_Shooter",
            //"Nova/TP_FirstPerson/Variant_Shooter/AI",
            //"Nova/TP_FirstPerson/Variant_Shooter/UI",
            //"Nova/TP_FirstPerson/Variant_Shooter/Weapons"
        });

        // Uncomment if you are using Slate UI
        // PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

        // Uncomment if you are using online features
        // PrivateDependencyModuleNames.Add("OnlineSubsystem");

        // To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
    }
}
