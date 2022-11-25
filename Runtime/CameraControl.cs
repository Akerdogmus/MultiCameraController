using UnityEngine;
using UnityEngine.UI;

public class CameraControl : MonoBehaviour
{
    [SerializeField] private Camera MainCamera;
    [SerializeField] private Camera[] activeCameraList; 
    [SerializeField] private Text cameraInfoText;
    int camCounter = 0;
    void Start()
    {
        MainCamera = Camera.main;
        cameraInfoText.text = MainCamera.name;
    }
    public void CameraChange()
    {
        MainCamera.enabled = false;
        for(int i=0;i<activeCameraList.Length;i++)
        {
            if(i!=camCounter){activeCameraList[i].enabled = false;}
            else{activeCameraList[i].enabled = true;}
            if(camCounter == activeCameraList.Length)
            {
                MainCamera.enabled = true;
                activeCameraList[camCounter-1].enabled = false;
                camCounter = 0;
            }
        }
        if(!MainCamera.isActiveAndEnabled){cameraInfoText.text = activeCameraList[camCounter].name;}
        else{cameraInfoText.text = MainCamera.name;}
        camCounter++;
    }
}
