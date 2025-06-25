using UnityEngine;

namespace Cat
{
    public class MaterialScroller : MonoBehaviour
    {
        private MeshRenderer _meshRenderer;
        
        void Start()
        {
            _meshRenderer = GetComponent<MeshRenderer>();

        }

        void Update()
        {
            Vector2 offset = Vector2.right * Define.OFFSET_SPEED * Time.deltaTime;

            _meshRenderer.material.SetTextureOffset(
                "_MainTex",
                _meshRenderer.material.mainTextureOffset + offset);
        }
    }
}