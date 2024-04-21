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
    private bool canMove = true; // ���������Ƿ�����ƶ�
    private Vector3 lastValidPosition; // ��¼���һ����Ч��λ��
    public float rotationSpeed = 100000f; // ��ת�ٶȣ������ڱ༭���е���

      void Start()
    {
        // ȷ����Ϸ��ʼʱ�ı������ص�
        textObject.SetActive(false);
    }

    void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mOffset = gameObject.transform.position - GetMouseWorldPos();
        lastValidPosition = transform.position; // ����갴��ʱ�����������Чλ��
        
        move = 1 - move; // �л� move ��״̬
    }

    void OnMouseDrag()
    {
        if (canMove)
        {
            Vector3 newPos = GetMouseWorldPos() + mOffset;
            transform.position = newPos;
            lastValidPosition = transform.position;

            if (Input.GetKey(KeyCode.Mouse0)) // ֻ��������������ʱ��������ת
            {
                float scroll = Input.GetAxis("Mouse ScrollWheel");
                if (scroll != 0)
                {
                    // ��תΧ��Z�ᣬ������XYƽ����ת
                    transform.Rotate(Vector3.forward, scroll * rotationSpeed * Time.deltaTime, Space.World);
                }
            }
        }
        else
        {
            transform.position = lastValidPosition; // ��������ƶ�����ָ��������Ч��λ��
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
        Debug.Log("��������ײ����ײ����" + other.name);
        
      
        if (other.gameObject == specificObject)
    {
       textObject.SetActive(true);
       button.SetActive(true);
    }
       
    }

    void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log(other.name + " ���뿪��������");
        canMove = true; // �����������뿪��������ʱ���ָ��ƶ�����
    }
}
