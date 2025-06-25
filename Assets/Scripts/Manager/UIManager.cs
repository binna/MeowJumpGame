using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

namespace Cat
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField]
        private TMP_InputField nicknameInputField;
        
        [SerializeField]
        private TextMeshProUGUI nicknameText;
        
        [SerializeField]
        private TextMeshProUGUI recordText;

        [SerializeField] 
        private GameObject gamePlayRoot;
        
        [SerializeField] 
        private GameObject introUI;

        [SerializeField] 
        private GameObject alertUI;
        
        [SerializeField]
        private GameObject outerUI;

        [SerializeField]
        private GameObject playUI;
        
        void Awake()
        {
            gamePlayRoot.SetActive(false);
            playUI.SetActive(false);
            introUI.SetActive(true);
            outerUI.SetActive(false);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }
        }

        public void OnAlertConfirmButton()
        {
            alertUI.SetActive(false);
        }

        public void OnStartButton()
        {
            if (nicknameInputField.text == "")
            {
                alertUI.SetActive(true);
                return;
            }

            gamePlayRoot.SetActive(true);
            playUI.SetActive(true);
            introUI.SetActive(false);
            outerUI.SetActive(false);
            
            GameHUDManager.ScoreReset();

            nicknameText.text = nicknameInputField.text;
        }

        public void OnMoveLobbyButton()
        {
            gamePlayRoot.SetActive(false);
            playUI.SetActive(false);
            introUI.SetActive(true);
            outerUI.SetActive(false);
        }

        public void OuterUI(string text)
        {
            recordText.text = text;
            gamePlayRoot.SetActive(false);
            playUI.SetActive(false);
            introUI.SetActive(false);
            outerUI.SetActive(true);
        }
    }
}