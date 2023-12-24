// Copyright Alex Iancu

using UnrealBuildTool;
using System.Collections.Generic;

public class EpicGameToBeEditorTarget : TargetRules
{
	public EpicGameToBeEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V4;

		ExtraModuleNames.AddRange( new string[] { "EpicGameToBe" } );
	}
}
