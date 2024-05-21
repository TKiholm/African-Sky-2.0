using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DomeFade : MonoBehaviour
{

    [SerializeField] private Wait wait;
    private bool EmbersA;

    public GameObject dome;
    bool faded;



    public IEnumerator FadeOutObject(GameObject objToFade)
    {
        //yield return new WaitForSeconds(4);
        // Get the mesh renderer of the object
        MeshRenderer meshRenderer = objToFade.GetComponent<MeshRenderer>();

        // Get the color value of the main material
        Color color = meshRenderer.materials[0].color;

        // While the color's alpha value is above 0
        while (color.a > 0)
        {
            // Reduce the color's alpha value
            color.a -= 0.00008f;

            // Apply the modified color to the object's mesh renderer
            meshRenderer.materials[0].color = color;

            // Wait for the frame to update
            yield return new WaitForEndOfFrame();
        }

        // If the material's color's alpha value is less than or equal to 0, end the coroutine
        yield return new WaitUntil(() => meshRenderer.materials[0].color.a <= 0f);
        faded = true;
    }



    private void Start()
    {
        faded = false;
       // StartCoroutine(FadeOutObject(dome));
    }
    public void Update()
    {

        EmbersA = wait.Embers;

        if (EmbersA == true)
        {
            StartCoroutine(FadeOutObject(dome));
        }
    }

}
