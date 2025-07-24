using UnityEngine;

public class DisableDialoguebox : MonoBehaviour
{
    public GameObject GameObject;
       public void DisableGameObject()    {
        GameObject.SetActive(false);
    }
}
