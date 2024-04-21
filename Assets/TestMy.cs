using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMy : MonoBehaviour
{ public GameObject textObject; 

public GameObject specificObject;
public GameObject button; 
    private float move = 0;
    private Vector3 mOffset;
    private float mZCoord;
    private bool canMove = true; // 控制物体是否可以移动
    private Vector3 lastValidPosition; // 记录最后一个有效的位置
    public float rotationSpeed = 100000f; // 旋转速度，可以在编辑器中调整

      void Start()
    {
        // 确保游戏开始时文本是隐藏的
        textObject.SetActive(false);
    }

    void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mOffset = gameObject.transform.position - GetMouseWorldPos();
        lastValidPosition = transform.position; // 当鼠标按下时，更新最后有效位置
        
        move = 1 - move; // 切换 move 的状态
    }

    void OnMouseDrag()
    {
        if (canMove)
        {
            Vector3 newPos = GetMouseWorldPos() + mOffset;
            transform.position = newPos;
            lastValidPosition = transform.position;

            if (Input.GetKey(KeyCode.Mouse0)) // 只有在鼠标左键按下时才允许旋转
            {
                float scroll = Input.GetAxis("Mouse ScrollWheel");
                if (scroll != 0)
                {
                    // 旋转围绕Z轴，适用于XY平面旋转
                    transform.Rotate(Vector3.forward, scroll * rotationSpeed * Time.deltaTime, Space.World);
                }
            }
        }
        else
        {
            transform.position = lastValidPosition; // 如果不能移动，则恢复到最后有效的位置
        }
    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = mZCoord;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("发生了碰撞，碰撞对象：" + other.name);
        
      
        if (other.gameObject == specificObject)
    {
       textObject.SetActive(true);
       button.SetActive(true);
    }
       
    }

    void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log(other.name + " 已离开触发区域");
        canMove = true; // 当其他对象离开触发区域时，恢复移动能力
    }
}
