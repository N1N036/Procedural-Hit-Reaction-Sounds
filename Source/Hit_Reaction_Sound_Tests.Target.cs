// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class Hit_Reaction_Sound_TestsTarget : TargetRules
{
	public Hit_Reaction_Sound_TestsTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "Hit_Reaction_Sound_Tests" } );
	}
}
