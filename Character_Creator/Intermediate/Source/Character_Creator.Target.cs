using UnrealBuildTool;

public class Character_CreatorTarget : TargetRules
{
	public Character_CreatorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Character_Creator");
	}
}
