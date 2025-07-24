using UnityEngine;

public class OnPickingUpBread : MonoBehaviour
{

    private void Update()
    {
        if (transform.parent != null && transform.parent.name == "ObjectHoldPosition")
        {
            Destroy(gameObject);
            // play next dialogue
        }

    }
}
