using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class cross : MonoBehaviour
{
    [SerializeField] Image crosshair;
    [SerializeField] GraphicRaycaster m_Raycaster;
    [SerializeField] PointerEventData m_PointerEventData;
    [SerializeField] EventSystem m_EventSystem;
    [SerializeField] GameObject m_SelectedObj;
    private void Update() 
    {
        
        if(Input.GetKey(KeyCode.Mouse0))
        {
            m_PointerEventData = new PointerEventData(m_EventSystem);
            m_PointerEventData.position = Input.mousePosition;
            crosshair.rectTransform.position = m_PointerEventData.position;  
        }
        
   
                   

    }
}
