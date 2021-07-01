using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Campagne : MonoBehaviour
{
    public MYthsAndSteel_Enum.Scenario _Scenario; //Sc�nario S�l�ctionn� et affich�
    [SerializeField] int ScenarioVal = 0;
    [SerializeField] int spaceBetweenScenario = 0;

    [SerializeField] int Unlocked;//Nombre actuelle de niveau d�bloqu�

    [Header("Assignations")]

    [SerializeField] private SaveData saveData;
    [SerializeField] private GameObject _buttonLeft = null;
    [SerializeField] private GameObject _buttonRight = null;
    [SerializeField] private float _mapSpeed = 0f;
    [SerializeField] private GameObject _mapTransform = null;
    [SerializeField] private GameObject Jauge0 = null;
    [SerializeField] private GameObject Jauge1 = null;
    [SerializeField] private GameObject Jauge2 = null;
    [SerializeField] private GameObject Jauge3 = null;
    [SerializeField] private GameObject Jauge4 = null;
    [SerializeField] private GameObject Jauge5 = null;
    [SerializeField] private GameObject Jauge6 = null;
    [SerializeField] private GameObject Jauge7 = null;
    [SerializeField] private TextMeshProUGUI RedPlayerVictories;
    [SerializeField] private TextMeshProUGUI BluePlayerVictories;
    [SerializeField] int redPlayerVictories;
    [SerializeField] int bluePlayerVictories;

    private void Start()
    {
        PlayerPrefs.SetInt("RethelDone", 0);
        PlayerPrefs.SetInt("ShanghaiDone", 0);
        PlayerPrefs.SetInt("StalingradDone", 0);
        PlayerPrefs.SetInt("HuskyDone", 0);
        PlayerPrefs.SetInt("GuadalcanalDone", 0);
        PlayerPrefs.SetInt("ElAlameinDone", 0);
        PlayerPrefs.SetInt("ElsenbornDone", 0);
    }
    private void Awake()
    {
        Time.timeScale = 1;
        Unlocked = PlayerPrefs.GetInt("UnlockCampaign");

        switch (Unlocked)
        {
            case 0:
                Jauge0.SetActive(true);
                Jauge1.SetActive(false);
                Jauge2.SetActive(false);
                Jauge3.SetActive(false);
                Jauge4.SetActive(false);
                Jauge5.SetActive(false);
                Jauge6.SetActive(false);
                Jauge7.SetActive(false);
                break;
            case 1:
                Jauge0.SetActive(false);
                Jauge1.SetActive(true);
                Jauge2.SetActive(false);
                Jauge3.SetActive(false);
                Jauge4.SetActive(false);
                Jauge5.SetActive(false);
                Jauge6.SetActive(false);
                Jauge7.SetActive(false);
                break;
            case 2:
                Jauge0.SetActive(false);
                Jauge1.SetActive(false);
                Jauge2.SetActive(true);
                Jauge3.SetActive(false);
                Jauge4.SetActive(false);
                Jauge5.SetActive(false);
                Jauge6.SetActive(false);
                Jauge7.SetActive(false);
                break;
            case 3:
                Jauge0.SetActive(false);
                Jauge1.SetActive(false);
                Jauge2.SetActive(false);
                Jauge3.SetActive(true);
                Jauge4.SetActive(false);
                Jauge5.SetActive(false);
                Jauge6.SetActive(false);
                Jauge7.SetActive(false);
                break;
            case 4:
                Jauge0.SetActive(false);
                Jauge1.SetActive(false);
                Jauge2.SetActive(false);
                Jauge3.SetActive(false);
                Jauge4.SetActive(true);
                Jauge5.SetActive(false);
                Jauge6.SetActive(false);
                Jauge7.SetActive(false);
                break;
            case 5:
                Jauge0.SetActive(false);
                Jauge1.SetActive(false);
                Jauge2.SetActive(false);
                Jauge3.SetActive(false);
                Jauge4.SetActive(false);
                Jauge5.SetActive(true);
                Jauge6.SetActive(false);
                Jauge7.SetActive(false);
                break;
            case 6:
                Jauge0.SetActive(false);
                Jauge1.SetActive(false);
                Jauge2.SetActive(false);
                Jauge3.SetActive(false);
                Jauge4.SetActive(false);
                Jauge5.SetActive(false);
                Jauge6.SetActive(true);
                Jauge7.SetActive(false);
                break;
            default:
                Jauge0.SetActive(false);
                Jauge1.SetActive(false);
                Jauge2.SetActive(false);
                Jauge3.SetActive(false);
                Jauge4.SetActive(false);
                Jauge5.SetActive(false);
                Jauge6.SetActive(false);
                Jauge7.SetActive(true);
                break;

        }

        if (Unlocked == 0)
        {
            _buttonRight.GetComponent<Button>().interactable = false;
            _buttonLeft.GetComponent<Button>().interactable = false;
        }
    }

    private void Update()
    {
        _mapTransform.GetComponent<RectTransform>().localPosition = Vector2.MoveTowards(_mapTransform.GetComponent<RectTransform>().localPosition, new Vector2(-spaceBetweenScenario * (Screen.width / 1920f) * ScenarioVal, _mapTransform.GetComponent<RectTransform>().localPosition.y), Time.deltaTime * _mapSpeed);
        redPlayerVictories = saveData.redPlayerVictories;
        bluePlayerVictories = saveData.bluePlayerVictories;
        RedPlayerVictories.text = redPlayerVictories.ToString();
        BluePlayerVictories.text = bluePlayerVictories.ToString();
       
        // CODE A D�-COMMENTER SI UN PLATEAU PAR SCENE (+ R�assigner le switch dans le bouton des batailles)
        /* 
        if (ScenarioVal == 0 && PlayerPrefs.GetInt("RethelDone") == 1)
        {
            _buttonRight.GetComponent<Button>().interactable = true;
        }
        else
        {
            _buttonRight.GetComponent<Button>().interactable = false;
        }
        if (ScenarioVal == 1 && PlayerPrefs.GetInt("ShanghaiDone") == 1)
        {
            _buttonRight.GetComponent<Button>().interactable = true;
        }
        else
        {
            _buttonRight.GetComponent<Button>().interactable = false;
        }
        if (ScenarioVal == 2 && PlayerPrefs.GetInt("StalingradDone") == 1)
        {
            _buttonRight.GetComponent<Button>().interactable = true;
        }
        else
        {
            _buttonRight.GetComponent<Button>().interactable = false;
        }
        if (ScenarioVal == 3 && PlayerPrefs.GetInt("HuskyDone") == 1)
        {
            _buttonRight.GetComponent<Button>().interactable = true;
        }
        else
        {
            _buttonRight.GetComponent<Button>().interactable = false;
        }
        if (ScenarioVal == 4 && PlayerPrefs.GetInt("GuadalcanalDone") == 1)
        {
            _buttonRight.GetComponent<Button>().interactable = true;
        }
        else
        {
            _buttonRight.GetComponent<Button>().interactable = false;
        }
        if (ScenarioVal == 5 && PlayerPrefs.GetInt("ElAlameinDone") == 1)
        {
            _buttonRight.GetComponent<Button>().interactable = true;
        }
        else
        {
            _buttonRight.GetComponent<Button>().interactable = false;
        }
        if (ScenarioVal == 6 && PlayerPrefs.GetInt("ElsenbornDone") == 1)
        {
            _buttonRight.GetComponent<Button>().interactable = true;
        }
        else
        {
            _buttonRight.GetComponent<Button>().interactable = false;
        }
        */
    }

    /// <summary>
    /// Permet d'aller � une sc�ne quand on clique sur un bouton
    /// </summary>
    public void ChangeScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
        switch (sceneID)
        {

            case 1:
                PlayerPrefs.SetInt("RethelDone", 1);
                PlayerPrefs.SetInt("Bataille", 1);
                break;
            case 2:
                PlayerPrefs.SetInt("ShanghaiDone", 1);
                PlayerPrefs.SetInt("Bataille", 2);
                break;
            case 3:
                PlayerPrefs.SetInt("StalingradDone", 1);
                PlayerPrefs.SetInt("Bataille", 3);
                break;
            case 4:
                PlayerPrefs.SetInt("HuskyDone", 1);
                PlayerPrefs.SetInt("Bataille", 4);
                break;
            case 5:
                PlayerPrefs.SetInt("GuadalcanalDone", 1);
                PlayerPrefs.SetInt("Bataille", 5);
                break;
            case 6:
                PlayerPrefs.SetInt("ElAlameinDone", 1);
                PlayerPrefs.SetInt("Bataille", 6);
                break;
            case 7:
                PlayerPrefs.SetInt("ElsenbornDone", 1);
                PlayerPrefs.SetInt("Bataille", 7);
                break;
            default:
                break;
        }

    }

    /// <summary>
    /// Fonction boutton pour montrer le sc�nario pr�c�dent
    /// </summary>
    public void Decrease()
    {
        int targetValue = ScenarioVal - 1;

        if (targetValue > 0 && targetValue < 7)
        {
            _buttonRight.GetComponent<Button>().interactable = true;
            _buttonLeft.GetComponent<Button>().interactable = true;
            _Scenario--;
            ScenarioVal--;
        }
        else if (targetValue == 0)
        {
            _buttonRight.GetComponent<Button>().interactable = true;
            _buttonLeft.GetComponent<Button>().interactable = false;
            _Scenario--;
            ScenarioVal--;
        }
        else if (targetValue < 0) { }
    }

    /// <summary>
    /// Fonction boutton pour montrer le sc�nario suivant
    /// </summary>
    public void Increase()
    {
        int targetValue = ScenarioVal + 1;

        if (targetValue > 0 && targetValue < 6)
        {
            _buttonLeft.GetComponent<Button>().interactable = true;
            _buttonRight.GetComponent<Button>().interactable = true; // Enlever la ligne quand d�commentez la ligne 148 aka CODE A D�-COMMENTER SI UN PLATEAU PAR SCENE (+ R�assigner le switch dans le bouton des batailles)
            _Scenario++;
            ScenarioVal++;
        }
        else if (targetValue == 6)
        {
            _buttonRight.GetComponent<Button>().interactable = false;
            _buttonLeft.GetComponent<Button>().interactable = true;
            _Scenario++;
            ScenarioVal++;
        }
        else if (targetValue > 6) { }

        if (targetValue == ScenarioVal)
        {
            if (ScenarioVal == Unlocked)
            {
                _buttonRight.GetComponent<Button>().interactable = false;
            }
        }
    }
}
