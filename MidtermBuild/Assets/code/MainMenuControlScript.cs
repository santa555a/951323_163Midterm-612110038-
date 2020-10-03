using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuControlScript : MonoBehaviour
{
    //Declarationssection
    [SerializeField] Button _startButton;
    [SerializeField] Button _optionsButton;
    [SerializeField] Button _credit;
    [SerializeField] Button _exitButton;
    [SerializeField] Button _stage1;
    [SerializeField] Button _stage2;
    [SerializeField] Button _back;

    // Start is called before the first frame update
    void Start()
    {
        _startButton.onClick.AddListener(delegate { StartButtonClick(_startButton); });
        _optionsButton.onClick.AddListener(delegate { OptionsButtonClick(_optionsButton); });
        _credit.onClick.AddListener(delegate { credit(_credit); });
        _exitButton.onClick.AddListener(delegate { ExitButtonClick(_exitButton); });
        _stage1.onClick.AddListener(delegate { stage1(_stage1); });
        _stage2.onClick.AddListener(delegate { stage2(_stage2); });
        _back.onClick.AddListener(delegate { back(_back); });
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void StartButtonClick(Button button)
    {
        SceneManager.LoadScene("select");
    }

    public void OptionsButtonClick(Button button)
    {
        SceneManager.LoadScene("SceneOptions");
    }
    public void credit(Button button)
    {
        SceneManager.LoadScene("creditscene");
    }
    public void ExitButtonClick(Button button)
    {
        Application.Quit();
    }

    public void stage1(Button button)
    {
        SceneManager.LoadScene("scene1");
    }
    public void stage2(Button button)
    {
        SceneManager.LoadScene("scene2");
    }
    public void back(Button button)
    {
        SceneManager.LoadScene("SceneMainMenu");
    }
}
