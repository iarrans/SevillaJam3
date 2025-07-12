using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProofMenuButton : MonoBehaviour
{
    public ProofSO proofSO;

    public void OnButtonClick()
    {
        ProofManager.Instance.ShowProofInMenu(proofSO);
    }

}
