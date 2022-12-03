using UnityEngine;

public class Tutorial03 : MonoBehaviour
{
    public Light light;

    void OnConnectionEvent(bool success) { }

    void OnMessageArrived(string msg)
    {
        var data = msg.Split(",");
        switch (data[0])
        {
            case "0":
                var rotate = System.Convert.ToSingle(data[1]);
                var tmpRot = light.transform.localEulerAngles;
                tmpRot.y = rotate;
                light.transform.localEulerAngles = tmpRot;
                break;
            case "1":
                var intensity = System.Convert.ToSingle(data[1]) / 100;
                RenderSettings.skybox.SetFloat("_Exposure", intensity);
                light.intensity = intensity;
                break;
        }
    }
}