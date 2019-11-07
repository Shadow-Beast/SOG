using UnityEngine;
using UnityEngine.UI;

public class MessagePanel : MonoBehaviour
{
    public Text titleText,bodyText;

    public void Show(string title,string body)
    {
        gameObject.SetActive(true);
        titleText.text = title;
        bodyText.text = body;
    }

    public void OkButton_Clicked()
    {
        gameObject.SetActive(false);
    }

    private void Start()
    {
        gameObject.SetActive(false);
    }
}
