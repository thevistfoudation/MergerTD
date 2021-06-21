using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckMergeController : MonoBehaviour
{

    private void OnTriggerStay2D(Collider2D collision)
    {
         if (collision.gameObject.tag == "Slot")
        {
            this.gameObject.transform.position = collision.gameObject.transform.position;
            //MergerController.Instance.mouseButtonReleassed = false;
            Debug.Log("sat nhap");
            //collision.gameObject.GetComponent<BoxCollider2D>().enabled = false;
        }     
    }
    private void  OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("asdasf " + collision.gameObject.name);
        Debug.Log("da chay qua day ");
        // if (this.gameObject.GetComponent<GunController>().State == collision.gameObject.GetComponent<GunController>().State && 
        //    this.gameObject.GetComponent<MergerController>().Lv == collision.gameObject.GetComponent<MergerController>().Lv && 
        //    collision.gameObject.tag != "Slot")
        //{
        //    //Destroy(collision.gameObject);
        //    //Destroy(this.gameObject);
        //    collision.gameObject.SetActive(false);
        //    this.gameObject.SetActive(false);
        //    int i = this.gameObject.GetComponent<MergerController>().Lv;
        //    i++;
        //    Debug.Log(i);
        //    MergerController.Instance.mouseButtonReleassed = false;
        //    Debug.Log(this.gameObject.GetComponent<GunController>().State.ToString() + i.ToString());
        //    GameObject obj = (GameObject)Instantiate(Resources.Load(this.gameObject.GetComponent<GunController>().State.ToString() + i.ToString()), transform.position, Quaternion.identity);
        //    obj.GetComponent<MergerController>().Lv = i;
            
        //}
    }
}
