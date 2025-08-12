using UnityEngine;

public class createNewCard : MonoBehaviour
{

    public infoCard infoCardObject;
    public InfoCardScript cardPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        initializeCard(infoCardObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void initializeCard(infoCard newInfoCard)
    {
        Debug.Log("new card created");
        InfoCardScript newCard = Instantiate(cardPrefab);
        newCard.createCard(newInfoCard);
        newCard.transform.SetParent(this.transform, false);

    }
}
