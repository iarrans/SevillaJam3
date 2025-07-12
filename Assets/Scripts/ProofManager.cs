using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProofManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static ProofManager Instance;

    public GameObject proofPanel;

    public List<ProofSO> unlockedProofs = new List<ProofSO>();
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    public void ShowProof(ProofSO proof)
    {
        proofPanel.GetComponent<VideoProofPanel>().ShowPanel(proof.name, proof.proofDescription, proof.proofImage, proof.hour);
    }

    public void UnlockProof(ProofSO proof)
    {
        // Check if the proof is already unlocked
        if (!unlockedProofs.Contains(proof))
        {
            // Add the proof to the list of unlocked proofs
            unlockedProofs.Add(proof);
            Debug.Log($"Proof '{proof.name}' has been unlocked.");
        }
    }
}
