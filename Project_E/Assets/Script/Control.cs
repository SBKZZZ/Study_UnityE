using UnityEngine;

public class Control : MonoBehaviour
{
    public int a;
    public int b;
    public string fruit;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (a > b)
        {
            Debug.Log("a 는 b 보다 큽니다.");
        }
        else if (a < b)
        {
            Debug.Log("a 는 b 보다 작습니다.");
        }
        else if (a == b)
        {
            Debug.Log("a 와 b 는 같습니다.");
        }
        else
        {
            Debug.Log("ERROR");
        }

        switch(this.fruit)
        {
            case "사과":
                Debug.Log("Apple");
                break;
            case "바나나":
                Debug.Log("Banana");
                break;
            case "포도":
                Debug.Log("Grape");
                break;
            default:
                Debug.Log("알 수 없는 과일입니다.");
                break;
        }

        for (int i = 0; i < 5; i++)
        {
            Debug.Log("for 문 실행 중 " + i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
