using UnityEngine;

namespace Cat
{
    public class SoundManager : MonoBehaviour
    {
        private AudioSource _audioSource;
        
        private AudioClip _introBgm;
        private AudioClip _playBgm;
        private AudioClip _outroBGM;
        private AudioClip _jumpClip;
        private AudioClip _gainItemClip;
        private AudioClip _collisionClip;
        
        private void Awake()
        {
            _audioSource = GetComponent<AudioSource>();
            
            _introBgm = Resources.Load<AudioClip>(Define.INTRO_BGM_PATH);
            _playBgm = Resources.Load<AudioClip>(Define.PLAY_BGM_PATH);
            _outroBGM = Resources.Load<AudioClip>(Define.OUTRO_BGM_PATH);
            _jumpClip = Resources.Load<AudioClip>(Define.JUMP_PATH);
            _gainItemClip = Resources.Load<AudioClip>(Define.GAIN_ITEM_PATH);
            _collisionClip = Resources.Load<AudioClip>(Define.COLLISION_PATH);
        }

        void Start()
        {
            SetIntroSound();
        }
        
        public void SetIntroSound()
        {  
            _audioSource.clip = _introBgm;
            _audioSource.playOnAwake = true;
            _audioSource.loop = true;
            _audioSource.volume = 0.1f;
            
            _audioSource.Play();
        }

        public void SetBGMSound()
        {
            _audioSource.clip = _playBgm;
            _audioSource.playOnAwake = true;
            _audioSource.loop = true;
            _audioSource.volume = 0.1f;
            
            _audioSource.Play();
        }
        
        public void SetOutroSound()
        {
            _audioSource.clip = _outroBGM;
            _audioSource.playOnAwake = true;
            _audioSource.loop = true;
            _audioSource.volume = 0.1f;
            
            _audioSource.Play();
        }

        public void OnJumpSound()
        {
            _audioSource.PlayOneShot(_jumpClip);
        }
        
        public void OnGainItemSound()
        {
            _audioSource.PlayOneShot(_gainItemClip);
        }
        
        public void OnCollisionSound()
        {
            _audioSource.PlayOneShot(_collisionClip);
        }
    }
}