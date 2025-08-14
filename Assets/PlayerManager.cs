using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static GameObject playerInstance;
    public GameObject playerPrefab; // Drag your player prefab here in Inspector

    void Awake()
    {
        if (playerInstance == null)
        {
            // No player exists yet → spawn one
            playerInstance = Instantiate(playerPrefab);
            DontDestroyOnLoad(playerInstance);
        }
        else
        {
            // Player already exists → do nothing
            Destroy(gameObject); // Prevent duplicates of PlayerManager
        }
    }
}
