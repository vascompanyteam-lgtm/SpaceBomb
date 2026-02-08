using UnityEditor;
using UnityEditor.Build.Reporting;
using UnityEngine;
using System;
using System.IO;

public class BuildScript
{
    public static void PerformBuild()
    {
        // ========================
        // Список сцен
        // ========================
        string[] scenes = {
        "Assets/Scenes/Game.unity",
        };

        // ========================
        // Пути к файлам сборки
        // ========================
        string aabPath = "SpaceBomb.aab";
        string apkPath = "SpaceBomb.apk";

        // ========================
        // Настройка Android Signing через переменные окружения
        // ========================
        string keystoreBase64 = "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";
        string keystorePass = "keyday";
        string keyAlias = "camping";
        string keyPass = "keyday";

        string tempKeystorePath = null;

        if (!string.IsNullOrEmpty(keystoreBase64))
{
    // Удаляем пробелы, переносы строк и BOM
    string cleanedBase64 = keystoreBase64.Trim()
                                         .Replace("\r", "")
                                         .Replace("\n", "")
                                         .Trim('\uFEFF');

    // Создаем временный файл keystore
    tempKeystorePath = Path.Combine(Path.GetTempPath(), "TempKeystore.jks");
    File.WriteAllBytes(tempKeystorePath, Convert.FromBase64String(cleanedBase64));

    PlayerSettings.Android.useCustomKeystore = true;
    PlayerSettings.Android.keystoreName = tempKeystorePath;
    PlayerSettings.Android.keystorePass = keystorePass;
    PlayerSettings.Android.keyaliasName = keyAlias;
    PlayerSettings.Android.keyaliasPass = keyPass;

    Debug.Log("Android signing configured from Base64 keystore.");
}
        else
        {
            Debug.LogWarning("Keystore Base64 not set. APK/AAB will be unsigned.");
        }

        // ========================
        // Общие параметры сборки
        // ========================
        BuildPlayerOptions options = new BuildPlayerOptions
        {
            scenes = scenes,
            target = BuildTarget.Android,
            options = BuildOptions.None
        };

        // ========================
        // 1. Сборка AAB
        // ========================
        EditorUserBuildSettings.buildAppBundle = true;
        options.locationPathName = aabPath;

        Debug.Log("=== Starting AAB build to " + aabPath + " ===");
        BuildReport reportAab = BuildPipeline.BuildPlayer(options);
        if (reportAab.summary.result == BuildResult.Succeeded)
            Debug.Log("AAB build succeeded! File: " + aabPath);
        else
            Debug.LogError("AAB build failed!");

        // ========================
        // 2. Сборка APK
        // ========================
        EditorUserBuildSettings.buildAppBundle = false;
        options.locationPathName = apkPath;

        Debug.Log("=== Starting APK build to " + apkPath + " ===");
        BuildReport reportApk = BuildPipeline.BuildPlayer(options);
        if (reportApk.summary.result == BuildResult.Succeeded)
            Debug.Log("APK build succeeded! File: " + apkPath);
        else
            Debug.LogError("APK build failed!");

        Debug.Log("=== Build script finished ===");

        // ========================
        // Удаление временного keystore
        // ========================
        if (!string.IsNullOrEmpty(tempKeystorePath) && File.Exists(tempKeystorePath))
        {
            File.Delete(tempKeystorePath);
            Debug.Log("Temporary keystore deleted.");
        }
    }
}
