using UnrealBuildTool;

public class Character_CreatorServerTarget : TargetRules
{
	public Character_CreatorServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Character_Creator");
	}
}
