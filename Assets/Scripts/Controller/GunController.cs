using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum state
{
    GUN,
    MISSLE,
    CANNON
}
public class GunController : MonoBehaviour
    {
        public Transform TranShoot;
        public GameObject[] bullet;
        //public Vector3 pos;
        public float delay;
        public float BulletLevel;
        //BulletLevel dựa vào level ng chơi hoặc điểm số
        Transform player;
        //private Rigidbody2D rb;
        // private Vector2 movement;
        public static GunController Instance;
        public Vector3 angle;
        public state State;
    private void Awake()
    {
        if (Instance == null) Instance = this;
    }
    ////public state state;
    // Start is called before the first frame update
    void Start()
        {
            //StartCoroutine(shoot());
            // player = GameObject.Find("Ship").transform;
            // rb = this.GetComponent<Rigidbody2D>();
            BulletLevel = 1;
        }
        IEnumerator shoot()
        {
            //ko sử dụng trong update vì gọi liên tục sẽ bị crash
            while (true)
            {
                // SoundsController.instance.playSound((int)AudioIndex.Shoot, 0.05f);
                if (BulletLevel == 1)
                { 
                    Instantiate(bullet[0], TranShoot.transform.position, Quaternion.Euler(angle.x, angle.y, -90));
                //Đạn Thẳng
                   }
                
                yield return new WaitForSeconds(delay);
                //delay đạn tránh trường hợp bắn liên tục
            }
        }
        IEnumerator c()
        {
            while (true)
            {
                yield return shoot();
            }
        }
        // Update is called once per frame
    }


