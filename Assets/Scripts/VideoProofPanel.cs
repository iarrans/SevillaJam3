using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class VideoProofPanel : MonoBehaviour
{
    public TextMeshProUGUI proofName;
    public TextMeshProUGUI proofDescription;
    public TextMeshProUGUI hour;
    public Image proofImage;
    public Button closeButton;

    public void ShowPanel(string name, string description, Sprite image, string hou)
    {
        proofName.text = name;
        proofDescription.text = description;
        proofImage.sprite = image;
        hour.text = hou;
        gameObject.SetActive(true);
    }

    public void HidePanel()
    {
        gameObject.SetActive(false);
    }
}
