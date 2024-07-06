using Content.Shared.Actions;
using Robust.Shared.GameStates;

namespace Content.Shared.Changeling;

[RegisterComponent, NetworkedComponent]
public sealed partial class ChangelingActionComponent : Component
{
    [DataField("chemicalCost")]
    public float ChemicalCost = 0;

    [DataField("useInLesserForm")]
    public bool UseWhileLesserForm = false;
}

#region Events - Basic

public sealed partial class OpenEvolutionMenuEvent : InstantActionEvent { }
public sealed partial class AbsorbDNAEvent : EntityTargetActionEvent { }
public sealed partial class StingExtractDNAEvent : EntityTargetActionEvent { }
public sealed partial class ChangelingTransformCycleEvent : InstantActionEvent { }
public sealed partial class ChangelingTransformEvent : InstantActionEvent { }
public sealed partial class EnterStasisEvent : InstantActionEvent { }
public sealed partial class ExitStasisEvent : InstantActionEvent { }

#endregion

#region Events - Combat

public sealed partial class ToggleArmbladeEvent : InstantActionEvent { }
public sealed partial class CreateBoneShardEvent : InstantActionEvent { }
public sealed partial class ToggleChitinousArmorEvent : InstantActionEvent { }
public sealed partial class ToggleOrganicShieldEvent : InstantActionEvent { }
public sealed partial class ShriekDissonantEvent : InstantActionEvent { }
public sealed partial class ShriekResonantEvent : InstantActionEvent { }
public sealed partial class ToggleStrainedMusclesEvent : InstantActionEvent { }

#endregion

#region Events - Sting

public sealed partial class StingBlindEvent : EntityTargetActionEvent { }
public sealed partial class StingCryoEvent : EntityTargetActionEvent { }
public sealed partial class StingLethargicEvent : EntityTargetActionEvent { }
public sealed partial class StingMuteEvent : EntityTargetActionEvent { }
public sealed partial class StingFakeArmbladeEvent : EntityTargetActionEvent { }
public sealed partial class StingTransformEvent : EntityTargetActionEvent { }

#endregion

#region Events - Utility



#endregion
