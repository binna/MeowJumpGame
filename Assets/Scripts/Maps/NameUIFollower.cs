using UnityEngine;

namespace Cat
{
    public class NameUIFollower : MonoBehaviour
    {
        [SerializeField]
        private Transform playerTransform;
        
        private readonly Vector3 _offset = new(0, 1, 0);

        void Update()
        {
            transform.position = playerTransform.transform.position + _offset;
        }
    }
}