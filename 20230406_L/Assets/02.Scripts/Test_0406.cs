using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_0406 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        int output = 0;
        output += 52;
        output += 273;
        output += 103;

        Debug.Log(output);


        string output2 = "hello ";
        output2 += "world";
        output2 += "!!";
        Debug.Log(output2);

        int number = 10;
        number++;
        Debug.Log(number);
        number--;
        Debug.Log(number);

        number = 10;
        Debug.Log(number);
        Debug.Log(number++);
        Debug.Log(number--);
        Debug.Log(number);

        number = 10;
        Debug.Log(number);
        Debug.Log(++number);
        Debug.Log(--number);
        Debug.Log(number);

        int _int = 273;
        long _long = 522731033265;
        float _float = 52.273F;
        double _double = 52.273;
        char _char = '글';
        string _string = "문자열";

        //출력
        Debug.Log(_int.GetType());
        Debug.Log(_long.GetType());
        Debug.Log(_float.GetType());
        Debug.Log(_double.GetType());
        Debug.Log(_char.GetType());
        Debug.Log(_string.GetType());

        //출력
        Debug.Log((273).GetType());
        Debug.Log((522731033265).GetType());
        Debug.Log((52.273F).GetType());
        Debug.Log((52.273).GetType());
        Debug.Log(('글').GetType());
        Debug.Log(("문자열").GetType());

        var a = (int)10.0;
        var b = (float)10;
        var c = (double)10.0;

        Debug.Log(a.GetType());
        Debug.Log(b.GetType());
        Debug.Log(c.GetType());


        //강제 자료형 변환에 따른 데이터 손실 예
        long longNumber = 2147483647L + 2147483647L;
        int intNumber = (int)longNumber;
        Debug.Log(intNumber);

        //강제 자료형 변환에 따른 데이터 손시 발생하지 않는 예
         long longNumber2 = 52273;
        int intNumber2 = (int)longNumber2;
        Debug.Log(intNumber2);

        // long 자료형을 int 자료형으로 변환합니다.
        longNumber = 2147483647L + 2147483647L;
        int longToint = (int)longNumber;
        Debug.Log(longToint);

        // double 자료형을 int 자료형으로 변환합니다.
        double doubleNumber = 52.27310332;
        int doubleToint = (int)doubleNumber;
        Debug.Log(doubleToint);

        // int 자료형의 숫자를 생성합니다.
        intNumber = 2147483647;

        // int 자료형을 long 자료형으로 자동 변환 합니다.
        long intToLong = intNumber;
        Debug.Log(intToLong);

        // int 자료형을 double 자료형으로 자동 변환 합니다.
        double intToDouble = intNumber;
        Debug.Log(intToDouble);

        // string 자료형을 int 자료형으로 변환합니다.
        //string numberString = "52273";
        //int intNumber = (int)numberString;
        //Debug.Log(intNumber);


        Debug.Log(int.Parse("52"));
        Debug.Log(long.Parse("273"));
        Debug.Log(float.Parse("52.273"));
        Debug.Log(double.Parse("103.32"));

        Debug.Log(int.Parse("52").GetType());
        Debug.Log(long.Parse("273").GetType());
        Debug.Log(float.Parse("52.273").GetType());
        Debug.Log(double.Parse("103.32").GetType());

        //Debug.Log(int.Parse("52.273"));
        //Debug.Log(int.Parse("abc"));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
