using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureEditor : MonoBehaviour
{
    [SerializeField] MeshRenderer meshRenderer;
    public List<Material> Material_List;

    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }
    public void ChangeTexture(int type)
    {
        meshRenderer.material = Material_List[type];
    }
    
}
