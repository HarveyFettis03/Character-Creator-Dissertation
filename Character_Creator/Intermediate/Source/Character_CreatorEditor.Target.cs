using UnrealBuildTool;

public class Character_CreatorEditorTarget : TargetRules
{
	public Character_CreatorEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Character_Creator");
	}
}
