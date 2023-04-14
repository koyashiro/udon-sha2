# UdonSHA2

SHA2 implementation for UdonSharp.

## Supported hash functions

- [ ] SHA-224
- [x] SHA-256
- [ ] SHA-384
- [ ] SHA-512
- [ ] SHA-512/224
- [ ] SHA-512/256

## Installation

To use this package, you need to add [my package repository](https://github.com/koyashiro/vpm-repos).
Please read more details [here](https://github.com/koyashiro/vpm-repos#installation).

Please install this package with [Creator Companion](https://vcc.docs.vrchat.com/) or [VPM CLI](https://vcc.docs.vrchat.com/vpm/cli/).

### Creator Companion

1. Enable the `koyashiro` package repository.

   ![image](https://user-images.githubusercontent.com/6698252/230629434-048cde39-a0ec-4c53-bfe2-46bde2e6a57a.png)

2. Find `UdonSHA2` from the list of packages and install any version you want.

### VPM CLI

1. Execute the following command to install the package.

   ```sh
   vpm add package net.koyashiro.udonsha2
   ```

## Example

```cs
using UnityEngine;
using UdonSharp;
using Koyashiro.UdonSHA2;

public class UdonSHA2Sample : UdonSharpBehaviour
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
```
