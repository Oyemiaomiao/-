using UnityEngine;

public class QuitGameButton : MonoBehaviour
{
    // ������������󶨵���ť�ĵ���¼�
    public void QuitGame()
    {
        // �ڱ༭���У��⽫�������κ�Ч��
        // �ڹ�������Ϸ�У������ر���Ϸ
        Application.Quit();

        // �������Unity�༭���е��ԣ��������д��뽫ȷ���ܹ��˳�����ģʽ
        // ע�⣺ֻ�ڿ���������ʹ��
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
