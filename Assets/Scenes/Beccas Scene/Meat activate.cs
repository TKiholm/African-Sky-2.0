using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Meatactivate : MonoBehaviour
{
    
    [SerializeField] private Wait wait;
    public GameObject targetObject;
    private XRGrabInteractable grabbableScript;
    private bool MeatR;
    
    // Start is called before the first frame update
    void Start()
    {
        if (targetObject != null)
        {
            // Get the GrabbableObject component
            grabbableScript = targetObject.GetComponent<XRGrabInteractable>();

            // Ensure the script is initially disabled
            if (grabbableScript != null)
            {
                grabbableScript.enabled = false;
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        MeatR = wait.MeatReady;
        
        {
            if (MeatR == true)
            {
                grabbableScript.enabled = true;
            }
        }
    }
        
    }
