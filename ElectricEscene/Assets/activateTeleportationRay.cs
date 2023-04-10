using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class activateTeleportationRay : MonoBehaviour
{
    public GameObject leftTeleportation;

    public InputActionProperty leftActivate;

    public InputActionProperty LeftCancel;

    // Update is called once per frame
    void Update()
    {
        leftTeleportation.SetActive(LeftCancel.action.ReadValue<float>() == 0 && leftActivate.action.ReadValue<float>() > 0.1f);
    }
}
