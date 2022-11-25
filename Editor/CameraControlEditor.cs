using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CameraControl))]
public class CameraControlEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        CameraControl cameraControl = (CameraControl)target;
        if(GUILayout.Button("Change Camera"))
        {
            UnityEngine.Debug.Log("Pressed Change Camera Button");
            cameraControl.CameraChange();
        }
    }
}
