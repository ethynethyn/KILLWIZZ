using UnityEngine;
using UnityEngine.UI;

public class CustomUIControls : MonoBehaviour
{
    public ScrollRect scrollRect;
    public float speed;
    public GameObject phone;

    // Update is called once per frame
    void Update()
    {
        scroll();
        showUI();
    }


    public void scroll()
    {
        //Scrolls down
        Vector2 velocity = Vector2.zero;
        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            velocity = Vector2.up * speed * 10;
        }

        //scrolls up
        else if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            velocity = -Vector2.up * speed * 10;
        }
        scrollRect.velocity = velocity;
    }

    public void showUI()
    {
        if(Input.GetKey(KeyCode.Tab))
        {
           phone.gameObject.SetActive(true);
        }

        else
        {
            phone.gameObject.SetActive(false);
        }
    }
}
