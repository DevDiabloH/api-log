using System;
using System.IO;
using System.Text;
using UnityEngine;

public static class APILog
{
    private static string FILE_PATH = Application.streamingAssetsPath + "/Log/" + System.DateTime.Today.Year.ToString() + System.DateTime.Today.Month.ToString() + "/";

    public static void Write(string url, string request)
    {
        if (false == System.IO.Directory.Exists(FILE_PATH))
        {
            System.IO.Directory.CreateDirectory(FILE_PATH);
            Debug.Log("create folder :: " + FILE_PATH);
        }

        // default
        string _text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\t" + url + "\t" + request + Environment.NewLine;

        // base64
        //string _date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        //byte[] _base64byte = Encoding.Unicode.GetBytes(string.Format("{0}\t{1}\t{2}", _date, url, request));
        //string _base64 = System.Convert.ToBase64String(_base64byte);
        //string _text = _base64 + Environment.NewLine;

        File.AppendAllText(FILE_PATH + System.DateTime.Today.Day + "_log.txt", _text);
    }
}
