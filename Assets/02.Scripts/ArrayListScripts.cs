using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ArrayListScripts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<int> list = new List<int>();

        for (int i = 1; i <= 5; i++)
            list.Add(i);

        list.Insert(1,4);
        list.RemoveAt(1);
        list.AddRange(new List<int> { 6, 7, 8 });

        list.RemoveAll(x => x % 2 == 0);
        list.Reverse();

        foreach (var i in list)
            Debug.Log($"리스트인덱스: {list.IndexOf(i)}의 값은 : {i} 입니다");

        Debug.Log("1이라는 값을 list가 갖고 있나요? " + list.Contains(1));
        Debug.Log("10이라는 값을 list가 갖고 있나요?" + list.Contains(10));
        Debug.Log("4라는 숫자가 list에 어디에 있나요? " + list.IndexOf(4));
        Debug.Log("10라는 숫자가 list에 어디에 있나요?" + list.IndexOf(10));

    }

}
