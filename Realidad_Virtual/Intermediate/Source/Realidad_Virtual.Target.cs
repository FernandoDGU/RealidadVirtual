using UnrealBuildTool;

public class Realidad_VirtualTarget : TargetRules
{
	public Realidad_VirtualTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Realidad_Virtual");
	}
}
