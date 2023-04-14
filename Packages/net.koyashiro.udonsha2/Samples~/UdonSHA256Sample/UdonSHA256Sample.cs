using UnityEngine;
using UdonSharp;
using Koyashiro.UdonSHA2;

public class UdonSHA256Sample : UdonSharpBehaviour
{
    public void Start()
    {
        var message = "Hello, world!";
        var bytes = new byte[message.Length];
        for (var i = 0; i < message.Length; i++)
        {
            bytes[i] = (byte)message[i];
        }
        var hash = SHA256.ComputeHash(bytes);

        var s = string.Empty;
        foreach (var b in hash)
        {
            s += $"{b:x2}";
        }
        Debug.Log($"0x{s}"); // 0x315f5bdb76d078c43b8ac0064e4a0164612b1fce77c869345bfc94c75894edd3
    }
}
