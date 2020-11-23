using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ludiq;
using Bolt;

[IncludeInSettings(true)]
public static class XFlowMachine
{ 
    public static void InstantiateMachine(GameObject target, FlowMacro macro)
    {
        target.AddComponent<FlowMachine>().nest.SwitchToMacro(macro);
    }

}
