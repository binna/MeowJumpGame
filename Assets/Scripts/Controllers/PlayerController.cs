using UnityEngine;

namespace Cat
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] 
        private Transform hpRoot;
        
        private readonly Vector3 _initPosition = new(0, 5f, 0);
        
        private UIManager _uiManager;
        private SoundManager _soundManager;
        
        private Rigidbody2D _catRigidbody;
        private Animator _catAnimator;
        
        private GameObject[] _hps;

        private int _lifeCount;
        
        private void Awake()
        {
            _catRigidbody = GetComponent<Rigidbody2D>();
            _catAnimator = GetComponent<Animator>();
            
            _catRigidbody.constraints = RigidbodyConstraints2D.FreezePositionX;
            
            _hps = new GameObject[hpRoot.childCount];
            for (int i = 0; i < hpRoot.childCount; i++)
            {
                _hps[i] = hpRoot.GetChild(i).gameObject;
            }

            _uiManager = GameObject.Find("@UIManager")
                .GetComponent<UIManager>();
            
            _soundManager = GameObject.Find("@SoundManager")
                .GetComponent<SoundManager>();
        }
      
        private void OnEnable()
        {
            ResetGame();
        }

        private void Update()
        {
            if (transform.position.y < -3f)
            {
                transform.localPosition = _initPosition; 
                return;
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                _soundManager.OnJumpSound();
                
                _catAnimator.SetTrigger(Define.AnimationParameter.JUMP);
                _catRigidbody.AddForceY(Define.JUMP_POWER, ForceMode2D.Impulse);

                // 자연스러운 점프를 위한 속도 제한
                if (_catRigidbody.linearVelocityY > Define.LINEAR_VELOCITY_Y_LIMIT)
                    _catRigidbody.linearVelocityY = Define.LINEAR_VELOCITY_Y_LIMIT;
            }

            var catRotation = transform.eulerAngles;
            catRotation.z = _catRigidbody.linearVelocityY * 2.5f;
            transform.eulerAngles = catRotation;
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag(Define.TagType.CHURU))
            {
                other.gameObject.SetActive(false);
                other.transform.parent.GetComponent<ItemController>().PlayEffect();
                
                GameHUDManager.PlusScore();
                _soundManager.OnGainItemSound();
            }
        }
        
        private void OnCollisionEnter2D(Collision2D other)
        {
            switch (other.gameObject.tag)
            {
                case Define.TagType.PIPE:
                    transform.localPosition = _initPosition;
                    
                    _soundManager.OnCollisionSound();
                    
                    _hps[_lifeCount].SetActive(false);
                    _lifeCount++;
                    
                    if (_lifeCount >= 5)
                    {
                        _soundManager.SetOutroSound();
                        _uiManager.OuterUI(GameHUDManager.GetRecordText());
                    }
                    return;
                case Define.TagType.GROUND:
                    _catAnimator.SetTrigger(Define.AnimationParameter.GROUND);
                    return;
            }
        }

        private void ResetGame()
        {
            transform.localPosition = Vector3.zero; 
            _soundManager.SetBGMSound();
            
            _lifeCount = 0;
            
            for (int i = 0; i < hpRoot.childCount; i++)
            {
                _hps[i].gameObject.SetActive(true);
            }
        }
    }
}