---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: sign_system_user_token       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: How to sign system user token # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto               # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
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

* Your application is approved and authenticated
* You have [validated the claim][2] and extracted the system user token from the [SuperIdToken][3]
* You have your private key file ([converted from RSA to PEM][4]

<a href="../../../assets/downloads/superofficeonlinecertificates.zip" download>Click to download the SuperOffice public key</<a>>.

## To sign the token

1. Concatenate the first 3 items: `PLAINTEXT_TOKEN.TIMESTAMP`

2. Using the partner's private certificate key, sign the concatenated items

3. Base64 encode the signed result

### Signing with JavaScript

```javascript
const utcTimestamp = moment.utc().format('YYYYMMDDHHmm');
const data = `YOUR_SYSTEM_USER_TOKEN.${utcTimestamp}`;

let sign = crypto.createSign('SHA256');
sign.update(data);
sign.end();

sign = sign.sign(rsaPrivateKey, 'base64');
const signedToken = `${data}.${sign}`;
```

### Signing with PHP

```php
$systemUserTokenAndTime = Application Name-pzqc70604i.201511111342
$signature = signVariable($systemUserTokenAndTime)
$signedSystemToken = $systemUserTokenAndTime + "." + base64_encode($signature)
```

<!-- Referenced links -->
[1]: system-user-token.md
[2]: ../../tokens/validate-security-tokens.md
[3]: ../../tokens/superid-token.md
[4]: http://www.platanus.cz/blog/converting-rsa-xml-key-to-pem
