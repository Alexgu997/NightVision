using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[RequireComponent(typeof(PostProcessLayer))]
public class NightVision : MonoBehaviour
{
    [SerializeField] 
    private bool isNightVision;

    private PostProcessLayer layer;
    private void Awake()
    {
        layer = GetComponent<PostProcessLayer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        isNightVision = false;
    }

    // Update is called once per frame
    void Update()
    {
       layer.enabled = isNightVision;
    }
}
