using UnityEngine;

public class Tutorial02 : MonoBehaviour
{
    public GameObject ball;

    void OnConnectionEvent(bool success) { }

    void OnMessageArrived(string msg)
    {
        var size = System.Convert.ToSingle(msg) / 100;
        ball.transform.localScale = Vector3.one * size;
    }
}