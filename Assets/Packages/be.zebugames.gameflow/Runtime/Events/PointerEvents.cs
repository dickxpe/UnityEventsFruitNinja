using System;
using UltEvents;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class PointerEvents : MonoBehaviour, IPointerDownHandler, IPointerClickHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, IPointerMoveHandler
{



    public UltEvent onPointerClick;
    public UltEvent onPointerDown;
    public UltEvent onPointerUp;
    public UltEvent onPointerEnter;
    public UltEvent onPointerExit;
    public UltEvent onPointerMove;
    public void OnPointerClick(PointerEventData eventData)
    {
        onPointerClick.Invoke();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        onPointerDown.Invoke();
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        onPointerUp.Invoke();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        onPointerEnter.Invoke();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        onPointerExit.Invoke();
    }

    public void OnPointerMove(PointerEventData eventData)
    {
        onPointerMove.Invoke();
    }


}
