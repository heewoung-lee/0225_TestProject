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
            Debug.Log($"{stack.Count+1}번째 데이터는 : {imsi} 입니다");
        }
        stack.Push('A');
        stack.Push(65);
        Debug.Log($"맨위에 쌓인 데이터는 {stack.Peek()} 입니다");
        Debug.Log("스택에 쌓여있는 데이터 수는 : "+stack.Count+"입니다");
        stack.Clear();
        Debug.Log("스택에 쌓여있는 데이터 수는 : " + stack.Count + "입니다");
    }

}
