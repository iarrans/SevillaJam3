using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Suspect", menuName = "Suspect")]
public class SuspectSO : ScriptableObject
{
    public string SuspectName;
    public string importantPoints;
    public string testimony;
    public Sprite portrait;
}
