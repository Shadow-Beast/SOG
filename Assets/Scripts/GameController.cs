using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject loginPanel, messagePanel, characterChooseModePanel;
    public Camera characterChooseCamera;
    public GameObject[] characterList;
    public Character userCharacter;
    public string nameOfUser;

    // Start is called before the first frame update
    void Start()
    {
        InitializeGameObject();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnterButton_Clicked()
    {
        string nameInputFieldText = loginPanel.GetComponentInChildren<InputField>().text;
        if (nameInputFieldText == string.Empty)
        {
            messagePanel.GetComponent<MessagePanel>().Show(Constants.titleForNameEmpty,Constants.bodyForNameEmpty);
        }
        else
        {
            userCharacter.UserName = nameInputFieldText;
            loginPanel.SetActive(false);
            characterChooseModePanel.SetActive(true);
        }
    }

    void InitializeGameObject()
    {
        loginPanel.SetActive(true);
        characterChooseModePanel.SetActive(false);
        userCharacter = new Character();
        characterChooseCamera.enabled = true;
        LoadGameModels();
    }

    void LoadGameModels()
    {
        characterList = Resources.LoadAll<GameObject>(Constants.modelsFolder);
        for(int i = 0; i < characterList.Length; i++)
        {
            characterList[i] = Instantiate(characterList[i], new Vector3(0, 0, 0), Quaternion.identity);
            characterList[i].SetActive(false);
        }
    }
}
