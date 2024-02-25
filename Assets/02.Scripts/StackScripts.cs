using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackScripts : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        Stack<object> stack = new Stack<object>();
        stack.Push(1);
        stack.Push("AAA");
        stack.Push(10.3f);

       while(stack.Count > 0)
        {
            var imsi = stack.Pop();
            Debug.Log($"{stack.Count+1}��° �����ʹ� : {imsi} �Դϴ�");
        }
        stack.Push('A');
        stack.Push(65);
        Debug.Log($"������ ���� �����ʹ� {stack.Peek()} �Դϴ�");
        Debug.Log("���ÿ� �׿��ִ� ������ ���� : "+stack.Count+"�Դϴ�");
        stack.Clear();
        Debug.Log("���ÿ� �׿��ִ� ������ ���� : " + stack.Count + "�Դϴ�");
    }

}
