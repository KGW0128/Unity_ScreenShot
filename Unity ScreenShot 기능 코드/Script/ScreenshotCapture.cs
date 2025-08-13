using UnityEngine;
using System.IO;

public class ScreenshotCapture : MonoBehaviour
{
    public void CaptureScreen()
    {
        // 저장 폴더 경로 (플랫폼에 안전하게 저장)
        string folderPath = Path.Combine(Application.persistentDataPath, "Screenshots");

        // 폴더 없으면 생성
        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
            Debug.Log("폴더 생성: " + folderPath);
        }

        // 자동으로 인덱스를 증가시키며 파일 이름 설정
        int index = 1;
        string filePath;
        do
        {
            filePath = Path.Combine(folderPath, $"screenshot_{index}.png");
            index++;
        } while (File.Exists(filePath));

        // 스크린샷 저장
        ScreenCapture.CaptureScreenshot(filePath);
        Debug.Log("스크린샷 저장됨: " + filePath);
    }
}
