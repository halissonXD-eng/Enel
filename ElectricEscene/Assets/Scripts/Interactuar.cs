using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Interactuar : MonoBehaviour
{
    private new Transform camera;
    public float rayDistance = 2;
    //public Texture2D puntero;
    //public GameObject TextDetect;
    GameObject ultimoReconocido = null;

    void Start()
    {
        camera = transform.Find("Main Camera");
        //TextDetect.SetActive(false);
    }

    void Update()
    {
        RaycastHit hit;
        
        if (Physics.Raycast(camera.position, camera.forward, out hit, rayDistance, LayerMask.GetMask("Interactable")))
        {
            Deselect();
            SeletedObject(hit.transform);
            if (Input.GetButtonDown("Interactable"))
            {

                if (Physics.Raycast(camera.position, camera.forward, out hit, rayDistance, LayerMask.GetMask("Interactable")))
                {
                    hit.transform.GetComponent<Interactable>().Interact();
                }
            }
        }
        else
        {
            Deselect();
        }

    }

    void SeletedObject(Transform transform)
    {
        transform.GetComponent<MeshRenderer>().material.color = Color.green;
        ultimoReconocido = transform.gameObject;
    }

    void Deselect()
    {
        if (ultimoReconocido)
        {
            ultimoReconocido.GetComponent<Renderer>().material.color = Color.white;
            ultimoReconocido = null;
        }
    }

    //private void OnGUI()
    //{
    //    Rect rect = new Rect(Screen.width / 2, Screen.height / 2, puntero.width, puntero.height);
    //    GUI.DrawTexture(rect, puntero);
    //}
}
