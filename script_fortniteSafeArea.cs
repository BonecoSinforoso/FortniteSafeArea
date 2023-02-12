//made in unity - by Boneco Sinforoso
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class script_admGameTudo : MonoBehaviour
{

    [SerializeField] GameObject[] obj_safe; //3 in example

    void Start()
    {
        SafeSet();
    }

    void SafeSet()
    {
        for (int i = 0; i < obj_safe.Length - 1; i++)
        {
            obj_safe[i + 1].transform.position = obj_safe[i].transform.position;
            obj_safe[i + 1].transform.position += Random.insideUnitSphere * (obj_safe[i].GetComponent<RectTransform>().rect.width / 2 - obj_safe[i + 1].GetComponent<RectTransform>().rect.width / 2);
        }
    }
}