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
        char _char = '��';
        string _string = "���ڿ�";

        //���
        Debug.Log(_int.GetType());
        Debug.Log(_long.GetType());
        Debug.Log(_float.GetType());
        Debug.Log(_double.GetType());
        Debug.Log(_char.GetType());
        Debug.Log(_string.GetType());

        //���
        Debug.Log((273).GetType());
        Debug.Log((522731033265).GetType());
        Debug.Log((52.273F).GetType());
        Debug.Log((52.273).GetType());
        Debug.Log(('��').GetType());
        Debug.Log(("���ڿ�").GetType());

        var a = (int)10.0;
        var b = (float)10;
        var c = (double)10.0;

        Debug.Log(a.GetType());
        Debug.Log(b.GetType());
        Debug.Log(c.GetType());


        //���� �ڷ��� ��ȯ�� ���� ������ �ս� ��
        long longNumber = 2147483647L + 2147483647L;
        int intNumber = (int)longNumber;
        Debug.Log(intNumber);

        //���� �ڷ��� ��ȯ�� ���� ������ �ս� �߻����� �ʴ� ��
         long longNumber2 = 52273;
        int intNumber2 = (int)longNumber2;
        Debug.Log(intNumber2);

        // long �ڷ����� int �ڷ������� ��ȯ�մϴ�.
        longNumber = 2147483647L + 2147483647L;
        int longToint = (int)longNumber;
        Debug.Log(longToint);

        // double �ڷ����� int �ڷ������� ��ȯ�մϴ�.
        double doubleNumber = 52.27310332;
        int doubleToint = (int)doubleNumber;
        Debug.Log(doubleToint);

        // int �ڷ����� ���ڸ� �����մϴ�.
        intNumber = 2147483647;

        // int �ڷ����� long �ڷ������� �ڵ� ��ȯ �մϴ�.
        long intToLong = intNumber;
        Debug.Log(intToLong);

        // int �ڷ����� double �ڷ������� �ڵ� ��ȯ �մϴ�.
        double intToDouble = intNumber;
        Debug.Log(intToDouble);

        // string �ڷ����� int �ڷ������� ��ȯ�մϴ�.
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
