using UnityEngine;

public class CollisionActivator : MonoBehaviour
{
    public GameObject button; // 拖拽你的按钮到这个公共变量中

    void Start()
    {
        // 确保游戏开始时按钮是非激活状态
        button.SetActive(false);
    }

void OnCollisionEnter2D(Collision2D collision)
{
    Debug.Log("Collision Detected with: " + collision.collider.name);
    button.SetActive(true);
}


}
