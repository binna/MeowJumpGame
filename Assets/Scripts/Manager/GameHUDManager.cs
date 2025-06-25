using TMPro;
using UnityEngine;

namespace Cat
{
    public class GameHUDManager : MonoBehaviour
    {
        [SerializeField] 
        private TextMeshProUGUI playTimeText;

        [SerializeField] 
        private TextMeshProUGUI scoreText;

        private static float _timer;
        private static int _score;

        void Update()
        {
            _timer += Time.deltaTime;

            playTimeText.text = $"Play Time : {_timer:F1}";
            scoreText.text = $"X {_score}";
        }

        public static void PlusScore()
        {
            _score++;
        }

        public static void ScoreReset()
        {
            _score = 0;
            _timer = 0f;
        }

        public static string GetRecordText()
        {
            return $"Play Time : {_timer:F1} Sec\nChuru Given : {_score}";
        }
    }
}