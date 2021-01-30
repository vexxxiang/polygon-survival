using UnityEngine;
using UnityEngine.EventSystems;
public class OnGUIHandler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool overGUI;

    public void OnPointerEnter(PointerEventData pointer)
    {
        overGUI = true;
    }

    public void OnPointerExit(PointerEventData pointer)
    {
        overGUI = false;
    }


}
