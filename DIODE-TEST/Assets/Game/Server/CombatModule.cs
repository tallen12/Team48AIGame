using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CombatModule  {
    public CombatModule()
    {

    }
    public List<UnitServer> calculate(UnitServer one,UnitServer two)
    {
        List < UnitServer > output=new List<UnitServer>();
        if (one.combatStat > two.combatStat)
            output.Add(one);
        else if (one.combatStat < two.combatStat)
            output.Add(two);
        else
        {
            output.Add(one);
            output.Add(two);
        }
        return output;
    }
}
