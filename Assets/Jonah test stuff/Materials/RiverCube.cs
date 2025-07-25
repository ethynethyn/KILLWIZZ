using UnityEngine;
using UnityEngine.SceneManagement;

public class RiverCube : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<CharacterController>())
        {
            Debug.Log("Touched lava");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }
}
