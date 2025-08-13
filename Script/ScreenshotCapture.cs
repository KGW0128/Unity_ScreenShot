using UnityEngine;
using System.IO;

public class ScreenshotCapture : MonoBehaviour
{
    public void CaptureScreen()
    {
        // ���� ���� ��� (�÷����� �����ϰ� ����)
        string folderPath = Path.Combine(Application.persistentDataPath, "Screenshots");

        // ���� ������ ����
        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
            Debug.Log("���� ����: " + folderPath);
        }

        // �ڵ����� �ε����� ������Ű�� ���� �̸� ����
        int index = 1;
        string filePath;
        do
        {
            filePath = Path.Combine(folderPath, $"screenshot_{index}.png");
            index++;
        } while (File.Exists(filePath));

        // ��ũ���� ����
        ScreenCapture.CaptureScreenshot(filePath);
        Debug.Log("��ũ���� �����: " + filePath);
    }
}
