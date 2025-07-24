using UnityEngine;

public class OnPickingUpPotion : MonoBehaviour
{
    public OrgeInteractStuff OIS;
    private void Update()
    {

        if (transform.parent != null && transform.parent.name == "ObjectHoldPosition")
        {
            OIS.AferDrinkPotion();
            Destroy(gameObject);
            // play next dialogue
        }

    }
}
