using UnityEngine;
using UnityEngine.UI; // ȷ������UnityEngine.UI�����ռ�

public class ToggleTexts : MonoBehaviour
{
    public GameObject[] textObjects; // �洢�����ı��������
    private int currentIndex = 0;    // ��ǰӦ��ʾ���ı�������

    void Start()
    {
        // ��ʼʱ��ȷ�������ı��򶼱�����
        foreach (GameObject text in textObjects)
        {
            text.SetActive(false);
        }
    }

    public void ShowNextText()
    {
        // ���ص�ǰ��ʾ���ı���
        if (textObjects[currentIndex].activeSelf)
        {
            textObjects[currentIndex].SetActive(false);
        }

        // ������������һ���ı���
        currentIndex = (currentIndex + 1) % textObjects.Length;

        // ��ʾ��һ���ı���
        textObjects[currentIndex].SetActive(true);
    }
}
