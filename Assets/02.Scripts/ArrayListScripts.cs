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
            Debug.Log($"����Ʈ�ε���: {list.IndexOf(i)}�� ���� : {i} �Դϴ�");

        Debug.Log("1�̶�� ���� list�� ���� �ֳ���? " + list.Contains(1));
        Debug.Log("10�̶�� ���� list�� ���� �ֳ���?" + list.Contains(10));
        Debug.Log("4��� ���ڰ� list�� ��� �ֳ���? " + list.IndexOf(4));
        Debug.Log("10��� ���ڰ� list�� ��� �ֳ���?" + list.IndexOf(10));

    }

}
