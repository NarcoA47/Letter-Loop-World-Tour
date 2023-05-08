using UnityEngine;
using UnityEngine.EventSystems;

public class UIDragLogic : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

    private Vector3 center;
    private Quaternion initialRotation;

    public void Start() {
        center = transform.position;
        initialRotation = transform.rotation;
    }

    public void OnBeginDrag(PointerEventData eventData) {
        initialRotation = transform.rotation;
    }

    public void OnDrag(PointerEventData eventData) {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = Camera.main.transform.position.z;
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);
        float angle = Mathf.Atan2(worldPos.y - center.y, worldPos.x - center.x) * Mathf.Rad2Deg;
        Quaternion newRotation = Quaternion.Euler(0, 0, angle - initialRotation.eulerAngles.z);
        transform.rotation = newRotation;
    }

    public void OnEndDrag(PointerEventData eventData) {
        // do nothing
    }
}
