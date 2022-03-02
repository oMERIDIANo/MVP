using UnrealBuildTool;

public class ShipLayoutTarget : TargetRules
{
	public ShipLayoutTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("ShipLayout");
	}
}
