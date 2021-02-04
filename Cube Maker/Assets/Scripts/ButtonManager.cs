using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ButtonManager : MonoBehaviour
{
    [SerializeField] CubeGen CubeGen;
    [SerializeField] InputField UserInput;
    [SerializeField] Button buttontmp;
    [SerializeField] GameObject ClosingGui;
    


    public void Ok()
    {
        CubeGen.HowMany = int.Parse(UserInput.text);
        ClosingGui.SetActive(false);
    }

    public void Redo()
    {
        SceneManager.LoadScene(0);
    }
}
