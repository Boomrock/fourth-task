using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class UIAnimation : MonoBehaviour
{
    [SerializeField] private Canvas canvas;
    [SerializeField] private RectTransform rectTransform;
    private float scale;
    private Vector3 hidePosition;
    private Vector3 showPosition;


    private void Start()
    {
        scale = canvas.transform.localScale.x;
        var offset = rectTransform.rect.size * scale;
        var position = rectTransform.transform.position;
        
        hidePosition = position + new Vector3(offset.x, 0);
        showPosition = position - new Vector3(offset.x, 0);
    }

    public void Show()
    {
        rectTransform.DOMove(showPosition, 1);

    }
    public void Hide()
    {
        rectTransform.DOMove(hidePosition, 1);
    }


}
