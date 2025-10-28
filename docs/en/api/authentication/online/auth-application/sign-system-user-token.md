---
title: How to sign system user token
uid: sign_system_user_token
description: How to sign system user token
author: SuperOffice Product and Engineering
keywords: authentication, system user
date: 10.28.2025
content_type: howto
category: api
deployment: online
platform: web
redirect_from: /en/authentication/online/auth-application/sign-system-user-token
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

### [Signing with Python](#tab/sign-python)

Accepts both PEM and XML formatted RSA private keys.

```python
from SignSysUserToken import SystemUserTokenSigner

# Usage example
signer = SystemUserTokenSigner('YOUR_APP-2d2D5KmBji','private.xml')
print(signer.sign())

```

SystemUserTokenSigner implementation:

Given below is the complete implementation of the `SystemUserTokenSigner` class used in the above example.

```python
import datetime
import hashlib
from base64 import b64encode, b64decode
from cryptography.hazmat.primitives import hashes, serialization
from cryptography.hazmat.primitives.asymmetric import rsa, padding
from xml.dom import minidom
from datetime import datetime, timezone
from Crypto.Util import number
from Crypto.PublicKey import RSA


class SystemUserTokenSigner:
    
    def get_long_int(self, nodelist):
        """converts contents of element as long int"""
        rc = []
        for node in nodelist:
            if node.nodeType == node.TEXT_NODE:
                rc.append(node.data)
        string = ''.join(rc)
        return number.bytes_to_long(b64decode(string))
    
    #
    # gets the PEM cert from from Private RSA Key XML file.
    #

    def get_rsa_as_pem_content(self, file_name):
        '''returns a PEM from from Private RSA Key XML file.'''
        with open(file_name, 'rb') as pkFile:
            xmlPrivateKey = pkFile.read()
        rsaKeyValue = minidom.parseString(xmlPrivateKey)
        modulus = self.get_long_int(rsaKeyValue.getElementsByTagName(
            'Modulus')[0].childNodes)
        exponent = self.get_long_int(rsaKeyValue.getElementsByTagName(
            'Exponent')[0].childNodes)
        d = self.get_long_int(
            rsaKeyValue.getElementsByTagName('D')[0].childNodes)
        p = self.get_long_int(
            rsaKeyValue.getElementsByTagName('P')[0].childNodes)
        q = self.get_long_int(
            rsaKeyValue.getElementsByTagName('Q')[0].childNodes)
        qInv = self.get_long_int(rsaKeyValue.getElementsByTagName(
            'InverseQ')[0].childNodes)
        privateKey = RSA.construct((modulus, exponent, d, p, q, qInv), False)
        pemKey = privateKey.exportKey()
        return pemKey.decode('utf-8')

    def get_pem_content(self, file_name):
        '''returns contents from private RSA XML file.'''
        with open(file_name, 'rb') as pkFile:
            rsaFileContent = pkFile.read()
            return rsaFileContent.decode('utf-8')

    def get_private_key(self, file_name):
        if str(file_name).endswith('.xml'):
            return self.get_rsa_as_pem_content(file_name)
        elif str(file_name).endswith('.pem'):
            return self.get_pem_content(file_name)

    def __init__(self, app_token, private_key_file):
        self.application_token = app_token
        self.private_key = self.get_private_key(private_key_file)
        print(self.private_key)

    # Sign the system user token according to the specification.
    def sign(self):
        time_utc = datetime.now(timezone.utc)
        time_formatted = datetime.strftime(time_utc, "%Y%m%d%H%M")
        system_token = self.application_token + '.' + time_formatted

        key = serialization.load_pem_private_key(
            self.private_key.encode('utf-8'), 
            password=None
        )
        signature = key.sign(
            system_token.encode('utf-8'),
            padding.PKCS1v15(),
            hashes.SHA256()
        )
        signed_system_token = system_token + "." + \
            b64encode(signature).decode('UTF-8')
        
        return f"{signed_system_token}"
```

#### pyproject.toml dependencies

```txt
[project]
name = "devnet-python-system-user"
version = "0.1.0"
description = "Add your description here"
readme = "README.md"
requires-python = ">=3.13"
dependencies = [
    "cryptography>=46.0.2",
    "pycryptodome>=3.23.0",
    "python-jose[cryptography]>=3.5.0",
    "pyopenssl>=25.3.0",
    "requests>=2.32.5",
    "suds-py3>=1.4.5.0",
]

```

***

<!-- Referenced links -->
[1]: index.md
[2]: ../validate-security-tokens.md
