using UnityEngine;
using UnityEngine.SceneManagement; // �̰� ��� SceneManager�� ����� ������
public class ButtonEvent : MonoBehaviour
{
   public void SceneLoader(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
