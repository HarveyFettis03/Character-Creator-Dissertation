using UnrealBuildTool;

public class Character_CreatorClientTarget : TargetRules
{
	public Character_CreatorClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Character_Creator");
	}
}
