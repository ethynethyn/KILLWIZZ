using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InfoCardScript : MonoBehaviour
{

    public infoCard newInfoCard;
    public TextMeshProUGUI text;
    public Image image;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void createCard(infoCard newCard)
    {
        newInfoCard = newCard;
        text.text = newInfoCard.personName;
    }
}
