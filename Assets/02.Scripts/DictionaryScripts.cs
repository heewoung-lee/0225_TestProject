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
        peopleinfo["Anna"] = "010-3333-3333";//이런식으로도 데이터를 생성할 수 있다.


        foreach(string value in peopleinfo.Values)
        {
            Debug.Log("적혀져 있는 모든 value 값 "+value); //모든 value 값을 뽑을 수 있다.
        }
        foreach (string key in peopleinfo.Keys)
        {
            Debug.Log("적혀져 있는 모든 key 값 " + key); //모든 key 값을 뽑을 수 있다.
        }


        var copyInfo = new Dictionary<string, string>(peopleinfo); // 값을 복사할땐 생성자에 파라미터에 원본 객체를 넣어주면 된다.

        foreach (KeyValuePair<string,string> item in copyInfo)
        {
            Debug.Log($"{item.Key}:{item.Value}"); // 복사값 확인
        }


        Debug.Log("Jone 이라는 사람이 있습니까? " + peopleinfo.ContainsKey("Jone"));//Key값을 통해 Value를 찾는다
        Debug.Log("Jamie 이라는 사람이 있습니까? " + peopleinfo.ContainsKey("Jamie"));


        var newPeoleInfo = peopleinfo.OrderBy(item => item.Value); //Value값을 오름차순으로 정렬 한 값을 newPeopleInfo로 전달

        foreach(var item in newPeoleInfo)
        {
            Debug.Log($"KEY: {item.Key}\tVALUE: {item.Value}");
        }
    }
}
