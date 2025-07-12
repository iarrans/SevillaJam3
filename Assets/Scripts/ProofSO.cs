using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "proof", menuName = "ProofInfo")]
public class ProofSO : ScriptableObject
{
    public int proofID;
    public string proofName;
    public string proofDescription;
    public string hour;
    public Sprite proofImage;
}
