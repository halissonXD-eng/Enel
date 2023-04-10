using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animaciones : MonoBehaviour
{
    [SerializeField] private GameObject logo;
    [SerializeField] private GameObject txtNombre;

    private void Start()
    {
        LeanTween.moveX(logo.GetComponent<RectTransform>(), 0, 1.5f).setDelay(1.5f).setEase(LeanTweenType.easeInOutBack);
        LeanTween.moveX(txtNombre.GetComponent<RectTransform>(), 0, 1.5f).setDelay(1.5f).setEase(LeanTweenType.easeInOutBack);
    }
}
