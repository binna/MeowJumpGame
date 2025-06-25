using UnityEngine;
using Random = UnityEngine.Random;

namespace Cat
{
    public class ItemController : MonoBehaviour
    {
        [SerializeField] 
        private GameObject pipe;

        [SerializeField] 
        private GameObject churu;

        [SerializeField] 
        private GameObject particle;

        private readonly int _colliderTypeCount = System.Enum
            .GetValues(typeof(Define.ColliderType))
            .Length;
        
        private Define.ColliderType _colliderType = Define.ColliderType.Pipe;
        
        private float _moveSpeedMax;
        private float _speedUpTimer;
        private float _randomPosY;
        private float _moveSpeed;
        
        private Vector3 _initPosition;

        private void Awake()
        {
            _initPosition = transform.localPosition;
        }

        private void OnEnable()
        {
            _moveSpeedMax = Define.MOVE_SPEED_MIN;
            SetRandomSetting(_initPosition.x);
        }

        void Update()
        {
            transform.position += Vector3.left * _moveSpeed * Time.deltaTime;
            _speedUpTimer += Time.deltaTime;

            if (transform.position.x < Define.BACKGROUND_END_X)
            {
                SetRandomSetting(Define.START_POSITION_X);
            }
        }
        
        
        public void PlayEffect()
        {
            particle.SetActive(true);
        }

        private void SetRandomSetting(float positionX)
        {
            _randomPosY = Random.Range(Define.RETURN_Y_MAX, Define.RETURN_Y_MIN);
            transform.position = new Vector3(positionX, _randomPosY, 0);

            pipe.SetActive(false);
            churu.SetActive(false);
            particle.SetActive(false);

            _colliderType = (Define.ColliderType)Random.Range(0, _colliderTypeCount);
            _moveSpeed = Random.Range(Define.MOVE_SPEED_MIN, _moveSpeedMax);
            
            if (_speedUpTimer > Define.SPEED_UP_INTERVAL)
            {
                _speedUpTimer = 0;
                _moveSpeedMax += 1;
            }
            
            switch (_colliderType)
            {
                case Define.ColliderType.Pipe:
                    pipe.SetActive(true);
                    break;
                case Define.ColliderType.Apple:
                    churu.SetActive(true);
                    break;
                case Define.ColliderType.Both:
                    pipe.SetActive(true);
                    churu.SetActive(true);
                    break;
            }
        }
    }
}