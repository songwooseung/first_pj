using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu] // �θ�Ŭ������ScriptableObject�� �ΰ� Assat�����ͷ� ����� �����ϴ�
public class StageData : ScriptableObject // ���� �����͸� ������ �� �ִ� Ŭ���� 
{
    [SerializeField]
    private Vector2 limitMin;
    [SerializeField]
    private Vector2 limitMax;

    public Vector2 LimitMin => limitMin; //�빮�� LimitMin,Max�� �ܺ�Ŭ�������� ���� ����
    public Vector2 LimitMax => limitMax;
}
