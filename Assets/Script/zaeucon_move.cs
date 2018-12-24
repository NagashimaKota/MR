using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class zaeucon_move : MonoBehaviour {
    

    void Start ()
    {
		
	}

	void Update ()
    {
        transform.localPosition = InputTracking.GetLocalPosition(XRNode.LeftHand);
        transform.localRotation = InputTracking.GetLocalRotation(XRNode.LeftHand);
    }
}
