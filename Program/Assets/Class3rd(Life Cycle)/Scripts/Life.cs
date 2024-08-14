using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    private void Awake()
    {
        // Awake()
        // ���� ������Ʈ�� �����Ǿ��� ��, �� �ѹ��� ȣ��Ǹ�, 
        // ��ũ��Ʈ�� ��Ȱ��ȭ�� ������ ���� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.

        Debug.Log("Awake");

    }

    private void OnEnable()
    {
        // OnEnable
        // ���� ������Ʈ�� Ȱ��ȭ�Ǿ��� ��, ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�. 
        Debug.Log("OnEnable");
    }
    void Start()
    {
        // Start()
        // ���� ������Ʈ�� �����Ǿ��� ��, �� �ѹ��� ȣ��Ǹ�, 
        // ��ũ��Ʈ�� ��Ȱ��ȭ�� ������ ��, ȣ����� ���� �̺�Ʈ �Լ��Դϴ�. 

        Debug.Log("Start");
    }

    private void FixedUpdate()
    {
        // FixedUpdate()
        // TimeStep�̶�� ���� ���� ������ �������� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�. 
        // �浹���� ���� ������ ������ ������ �䱸�ϱ� ������ ������ �ð��� ���� ����
        // Ű�Է� ���� �͵��� ���� �� �ֱ� ������ update�ʿ��� ó��
        Debug.Log("Fixed Update");
    }

    void Update()
    {
        // Update()
        // �����Ӹ��� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
        Debug.Log("Update");
    }

    private void LateUpdate()
    {
        // LateUpdate()
        // Update �Լ��� ���� �Ŀ� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
        Debug.Log("LateUpdate");
    }

    private void OnDisable()
    {
        // OnDisable()
        // ���� ������Ʈ�� ��Ȱ��ȭ�Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.

    }

}
