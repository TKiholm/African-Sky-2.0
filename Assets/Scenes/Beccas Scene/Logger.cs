using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Logger : MonoBehaviour
{
    public float logInterval = 5.0f; // Interval in seconds to log the framerate
    private float elapsedTime = 0.0f;
    private int frameCount = 0;

    private List<string> frameRateLog = new List<string>();
    private string filePath;
    private static int logNumber = 1;

    void Start()
    {
        // Set the file path to save the CSV file
        filePath = GetUniqueFilePath();

        // Print the file path to the console
        Debug.Log("Frame rate log file saved to: " + filePath);

        // Add headers to the CSV file
        frameRateLog.Add("Time,Framerate");

        // Start the logging coroutine
        StartCoroutine(LogFrameRate());
    }

    void Update()
    {
        // Increment the frame count and elapsed time
        frameCount++;
        elapsedTime += Time.deltaTime;
    }

    private IEnumerator LogFrameRate()
    {
        while (true)
        {
            yield return new WaitForSeconds(logInterval);

            // Calculate the average framerate
            float averageFrameRate = frameCount / elapsedTime;

            // Log the framerate with the timestamp
            string logEntry = string.Format("{0},{1}", Mathf.RoundToInt(Time.time), Mathf.RoundToInt(averageFrameRate));
            frameRateLog.Add(logEntry);

            // Reset the counters
            frameCount = 0;
            elapsedTime = 0.0f;

            // Write the log to the CSV file
            File.WriteAllLines(filePath, frameRateLog.ToArray());
        }
    }

    private string GetUniqueFilePath()
    {
        string path;
        do
        {
            path = Path.Combine(Application.dataPath, $"FrameRateLog_{logNumber}.csv");
            logNumber++;
        } while (File.Exists(path));
        return path;
    }
}


