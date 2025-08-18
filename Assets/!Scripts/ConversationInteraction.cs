using UnityEngine;
using DialogueEditor;

public class ConversationInteraction : MonoBehaviour
{

    public NPCConversation conversation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startConversation()
    {
        ConversationManager.Instance.StartConversation(conversation);
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            if (Input.GetKeyDown("e"))
            {
                startConversation();
            }
        }
    }
}
