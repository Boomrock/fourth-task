using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PremetivAnimation : MonoBehaviour
{
    [SerializeField] private GameObject Cube;
    [SerializeField] private float duration = 5;
    [SerializeField] private Vector3 endPoint; 
    
    // Start is called before the first frame update
    void Start()
    {
        Cube.transform.DOMove(endPoint, duration)
                      .SetEase(Ease.InCubic)
                      .OnKill(EndAnimation);
    }

    private void EndAnimation()
    {
        Debug.Log("End Animation");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
