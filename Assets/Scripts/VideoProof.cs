using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VideoProof : MonoBehaviour
{
    public bool alreadyDiscovered;
    public ProofSO proofInfo;

    public void CheckProof()
    {
       // Show the proof information in the UI (ProofManager: proofPanel)
       // Check if the proof has already been discovered
       if (alreadyDiscovered)
        {
              // If already discovered, show the proof information
              ProofManager.Instance.ShowProof(proofInfo);
        }
       else
       {
              // If not discovered, mark it as discovered and show the proof information
              alreadyDiscovered = true;
              ProofManager.Instance.ShowProof(proofInfo);
              ProofManager.Instance.UnlockProof(proofInfo);
       }
    }
}
