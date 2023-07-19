using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class ComplexAnimation : MonoBehaviour
{
    [SerializeField] private Transform Cube;
    [SerializeField] private float duration = 5;
    [SerializeField] private Vector3 endPoint; 
    // Start is called before the first frame update
    void Start()
    {
        DOTween.Sequence().Append(Cube.DOMove(endPoint, duration).SetEase(Ease.InCubic))
            .AppendInterval(0.1f)
            .Append(Cube.DOScale(new Vector3(2, 2), 2))
            .Append(Cube.DOMove(new Vector3(-1, 1), 0.1f))
            .AppendInterval(1)
            .Append(Cube.DOMove(new Vector3(10, 1), 0.1f))
            .AppendInterval(1)
            .Append(Cube.DOMove(new Vector3(0,0), 0.1f))
            .Append(Cube.DOScale(new Vector3( 1, 1), 1));

    }

    private void EndAnimation()
    {
        Debug.Log("End complex Animation");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
