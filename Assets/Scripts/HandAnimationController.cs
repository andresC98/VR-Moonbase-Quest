using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HandAnimationController : MonoBehaviour
{

    public InputDeviceCharacteristics controllerType;
    public InputDevice thisController;

    // Start is called before the first frame update
    void Start()
    {
        List<InputDevice> controllerDevices = new List<InputDevice>();

        InputDevices.GetDevicesWithCharacteristics(controllerType, controllerDevices);

        thisController = controllerDevices[0];

        //Debug.Log(thisController.name);

    }

    // Update is called once per frame
    void Update()
    {

        if (thisController.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue) && triggerValue > 0.1f)
        {
            Debug.Log("Trigger press!");
            // Access the animator component - control a value - trigger animation
        }

        if (thisController.TryGetFeatureValue(CommonUsages.grip, out float gripValue) && gripValue > 0.1f)
        {
            Debug.Log("Grip press with value " + gripValue);
            // Access the animator component - control a value - grip animation

        }
    }
}
