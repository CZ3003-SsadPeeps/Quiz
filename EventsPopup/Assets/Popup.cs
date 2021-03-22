using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Popup : MonoBehaviour
{
    [SerializeField] Button _button;
    [SerializeField] Text _buttonText;
    [SerializeField] Text _popupText;


    public void Init(Transform canvas, string popupMessage, string btntxt)
    {
        _popupText.text = popupMessage;
        _buttonText.text = btntxt;

        transform.SetParent(canvas);
        transform.localScale = Vector3.one;
        transform.localPosition = Vector3.zero;

        _button.onClick.AddListener(() =>
        {
            GameObject.Destroy(this.gameObject);
        });
    }
}
