---
title: How to sign system user token
uid: sign_system_user_token
description: How to sign system user token
author: {github-id}
keywords: authentication, system user
so.topic: howto
so.envir: cloud
so.client: online
---

# How to sign system user token

Before requesting a new system user ticket, you have to sign your system user token with your RSA private key. The timestamp is also updated.

The **SignedSystemToken** element has the following format:

* plain text [system user token][1]
* a period (.)
* a UTC date time formatted as YYYYMMddhhmm using leading zeros
* a period (.)
* a Base64-encoded, signed version of the first 3 items

For example:

```javascript
System User Token.YYYYMMDDHHMM.mwhpYcNBfFqEaL0uLkCwXB99sM/Wo7DOnhjRwsmwNAd2EmBM1z+Co=
```

## Pre-requisites

* Your application is approved and authorized.
* You have [validated the claim][2] and extracted the system user token from the `id_token`.
* You have your private key file (obtained after application registration).

## To sign the token

1. Concatenate the first 3 items: `PLAINTEXT_TOKEN.TIMESTAMP`.

2. Using the partner's private certificate key, sign the concatenated items.

3. Base64 encode the signed result.

### [Signing with CSharp](#tab/sign-cs)

```csharp
/// <summary>
/// Sign the token according to the system user specification.                  
/// </summary>
/// <param name="systemUserToken">An applications unique system user key for a tenant.</param>
/// <param name="privateKey">XML Formatted RSA public key.</param>
/// <returns>Signed system user string.</returns>
public string Sign(string systemUserToken, string privateKey)
{
    var utcNow = DateTime.UtcNow.ToString("yyyyMMddHHmm");
    var signThis = systemUserToken + "." + utcNow;
    using (var rsaCryptoProvider = new RSACryptoServiceProvider())
    {
        rsaCryptoProvider.FromXmlString(privateKey);
        var signature = rsaCryptoProvider.SignData(Encoding.UTF8.GetBytes(signThis), "SHA256");
        return signThis + "." + Convert.ToBase64String(signature);
    }
}
```

### [Signing with JavaScript](#tab/sign-js)

```javascript
const utcTimestamp = moment.utc().format('YYYYMMDDHHmm');
const data = `YOUR_SYSTEM_USER_TOKEN.${utcTimestamp}`;

let sign = crypto.createSign('SHA256');
sign.update(data);
sign.end();

sign = sign.sign(rsaPrivateKey, 'base64');
const signedToken = `${data}.${sign}`;
```

### [Signing with PHP](#tab/sign-php)

```php
$systemUserTokenAndTime = Application Name-pzqc70604i.201511111342
$signature = signVariable($systemUserTokenAndTime)
$signedSystemToken = $systemUserTokenAndTime + "." + base64_encode($signature)
```

***

<!-- Referenced links -->
[1]: index.md#system-user-tokens
[2]: ../validate-security-tokens.md
[4]: http://www.platanus.cz/blog/converting-rsa-xml-key-to-pem
[5]: https://www.nuget.org/packages/SuperOffice.Crm.Online.Core
[6]: ../../../assets/downloads/superofficeonlinecertificates.zip
[7]: https://sod.superoffice.com/login/.well-known/openid-configuration
[8]: https://qaonline.superoffice.com/login/.well-known/openid-configuration
[9]: https://online.superoffice.com/login/.well-known/openid-configuration
