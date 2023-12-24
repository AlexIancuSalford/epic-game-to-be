// Copyright Alex Iancu

using UnrealBuildTool;
using System.Collections.Generic;

public class EpicGameToBeTarget : TargetRules
{
	public EpicGameToBeTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V4;

		ExtraModuleNames.AddRange( new string[] { "EpicGameToBe" } );
	}
}
