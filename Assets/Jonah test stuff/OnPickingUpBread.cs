using JetBrains.Annotations;
using UnityEngine;

public class OnPickingUpBread : MonoBehaviour
{
    public OrgeInteractStuff OIS;
    private void Update()
    {
         
        if (transform.parent != null && transform.parent.name == "ObjectHoldPosition")
        {
            OIS.AferAteBread();
            Destroy(gameObject);
            // play next dialogue
        }

    }
}
