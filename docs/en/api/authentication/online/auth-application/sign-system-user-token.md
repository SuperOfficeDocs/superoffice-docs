---
title: How to sign system user token
uid: sign_system_user_token
description: How to sign system user token
author: SuperOffice Product and Engineering
keywords: authentication, system user
content_type: howto
deployment: online
client: online
---

<!-- markdownlint-disable-file MD051 -->
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

// System User Token is a string obtained when an application 
// is authorized to access to access Tenant web services.

$systemUserToken = "Application Name-pzqc70604i";

// Private key is the RSA XML key, converted to PEM format
// Convert RSAXML to PEM using tool: https://devnet-tools.superoffice.com/rsa

$private_key_file = "privatekey.pem"

// read in the private key

$privateKey = openssl_pkey_get_private(file_get_contents($private_key_file), "PASSWORD");

// create the content that will be signed.

$signThis = $systemUserToken.".".date("YmdHi");

//sign the system token using private key of the application, returns $signature

openssl_sign($signThis, $signature, $privateKey, OPENSSL_ALGO_SHA256);

// concatenate the two parts of the signed token (SystemUserToken.UtcDate.Base64EncodedSignature)

$signedToken = $signThis.".".base64_encode($signature)

```

***

<!-- Referenced links -->
[1]: index.md
[2]: ../validate-security-tokens.md
