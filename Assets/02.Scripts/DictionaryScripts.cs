using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class DictionaryScripts : MonoBehaviour
{
    private void Start()
    {

        Dictionary<string, string> peopleinfo = new Dictionary<string, string>();

        peopleinfo.Add("Maria", "010-1111-1111");
        peopleinfo.Add("Mohammed", "010-2222-2222");
        peopleinfo.Add("Jone", "010-0000-0000");
        peopleinfo["Michael"] = "010-4444-4444";
        peopleinfo["Anna"] = "010-3333-3333";//�̷������ε� �����͸� ������ �� �ִ�.


        foreach(string value in peopleinfo.Values)
        {
            Debug.Log("������ �ִ� ��� value �� "+value); //��� value ���� ���� �� �ִ�.
        }
        foreach (string key in peopleinfo.Keys)
        {
            Debug.Log("������ �ִ� ��� key �� " + key); //��� key ���� ���� �� �ִ�.
        }


        var copyInfo = new Dictionary<string, string>(peopleinfo); // ���� �����Ҷ� �����ڿ� �Ķ���Ϳ� ���� ��ü�� �־��ָ� �ȴ�.

        foreach (KeyValuePair<string,string> item in copyInfo)
        {
            Debug.Log($"{item.Key}:{item.Value}"); // ���簪 Ȯ��
        }


        Debug.Log("Jone �̶�� ����� �ֽ��ϱ�? " + peopleinfo.ContainsKey("Jone"));//Key���� ���� Value�� ã�´�
        Debug.Log("Jamie �̶�� ����� �ֽ��ϱ�? " + peopleinfo.ContainsKey("Jamie"));


        var newPeoleInfo = peopleinfo.OrderBy(item => item.Value); //Value���� ������������ ���� �� ���� newPeopleInfo�� ����

        foreach(var item in newPeoleInfo)
        {
            Debug.Log($"KEY: {item.Key}\tVALUE: {item.Value}");
        }
    }
}
