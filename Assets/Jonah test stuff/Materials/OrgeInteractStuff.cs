using DialogueEditor;
using StarterAssets;
using UnityEngine;

public class OrgeInteractStuff : MonoBehaviour
{
    public GameObject blindnessCanvas;
    public GameObject potion;
    public FirstPersonController fpc;
    public NPCConversation AteBreadNext;
    public NPCConversation Drankpotion;
    public void Slowness()
    {
        fpc.MoveSpeed = fpc.MoveSpeed / 2f;
    }
    
    public void AferAteBread()
    {
        ConversationManager.Instance.StartConversation(AteBreadNext);
    }

    public void SpawnPotion()
    {
        potion.SetActive(true);
    }
    public void AferDrinkPotion()
    {
        ConversationManager.Instance.StartConversation(Drankpotion);
    }
    public void blindnessActivate()
    {
        blindnessCanvas.SetActive(true);
        
    }
}
