using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MenuProofPanel : MonoBehaviour
{
    public TextMeshProUGUI proofTitle;
    public TextMeshProUGUI proofDescription;
    public TextMeshProUGUI hour;
    public Image image;

    public void ShowProof(ProofSO proof)
    {
        proofTitle.text = proof.proofName;
        proofDescription.text = proof.proofDescription;
        hour.text = proof.hour;
        image.sprite = proof.proofImage;

    }
}
