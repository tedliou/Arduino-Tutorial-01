using TMPro;
using UnityEngine;

public class Tutorial01 : MonoBehaviour
{
    public TMP_Text UIText;

    void OnConnectionEvent(bool success) {}

    void OnMessageArrived(string msg)
    {
        UIText.text = msg;
    }
}
