using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LTAUnityBase.Base.DesignPattern;
public class DragDropController : MonoBehaviour
{
    public Vector2 mousePosition;
    public float offsetX, offsetY;
    public bool mouseButtonReleassed;
    public int Lv;
   
    public void OnMouseDown()
    {
        mouseButtonReleassed = false;
        offsetX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x;
        offsetY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y;
        Debug.Log("chuot xuong");
    }

    public void OnMouseDrag()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(mousePosition.x - offsetX, mousePosition.y - offsetY);
    }
    public void OnMouseUp()
    {
        mouseButtonReleassed = true;
        Debug.Log("chuot len");
        
    }
    //private void OnTriggerStay2D(Collider2D collision)
    //{
    //    if (collision.gameObject.tag == "Slot")
    //    {
    //        this.gameObject.transform.position = collision.gameObject.transform.position;
    //        mouseButtonReleassed = false;
    //        Debug.Log("sat nhap");
    //        collision.gameObject.GetComponent<BoxCollider2D>().enabled = false;
    //    }
    //}
}
public class Drag : SingletonMonoBehaviour<DragDropController>
{

}
