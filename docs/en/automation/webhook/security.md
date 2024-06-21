---
title: Webhook secrets
uid: webhook_security
description: "How to verify that the webhook has not been tampered with."
author: Tony Yates
date: 04.06.2018
keywords:
topic: howto
# envir:
# client:
---

# Webhook secrets

How do you know that the notification was sent from SuperOffice, and not from some random hacker? A webhook secret is used as an additional layer of security to verify that the webhook sent to the receiver has not been tampered with.

Only when a webhook definition contains a secret value will SuperOffice append an X-SuperOffice-Signature header to each event notification. It is then up to the receiver to verify the signature of the payload before processing the message.

So how does a receiver validate the X-SuperOffice-Signature header value? Let’s first review how the signature is generated.

SuperOffice uses the shared secret as a key in the HMAC SHA256 algorithm, which in turn is used to hash the body of the webhook JSON value. The result of the hash is then base64 encoded and used to populate the X-SuperOffice-Signature header value.

The responsibility of the receiver is to use the shared secret in the same manner and essentially do exactly the same thing. The receiver takes the body of the request. Essentially the webhook payload, hash, and base64 encode it and then compare the results with the value from the **X-SuperOffice-Signature** HTTP header.

If the values match then you can be confident the webhook is a valid message that has not been tampered with. If not, the webhook has likely been tampered with mid-stream and should be ignored.

## Validation example using C\#

```csharp
/// <summary>
/// Validates the X-SuperOffice-Signature webhook header value.
/// </summary>
/// <param name="storedSecret">The shared secret stored on the application side.</param>
/// <param name="headerValue">The value from X-SuperOffice-Signature header</param>
/// <param name="body">JSON representation of the webhook</param>
/// <returns></returns>
private bool IsValidWebHook(string storedSecret,string headerValue,System.IO.Stream body)
{
  var validationResult = false;

  // ensure it is the correct encoding
  var secret = System.Text.Encoding.UTF8.GetBytes(storedSecret);

  // hash and base64 encode the stored shared secret
  using (var hasher = new System.Security.Cryptography.HMACSHA256(secret))
  {
    var sha256 = hasher.ComputeHash(body);
    var base64 = Convert.ToBase64String(sha256);

    // verify the values match!
    if (base64 == headerValue)
    {
      validationResult = true;
    }
  }
  return validationResult;
}
```

## Validation routine using Node/JavaScript

You need to be careful to compute the hash based on the request string, and not a parsed and converted representation, since whitespace and line delimiters are significant. See [this article][1]  for an in-depth example using Express and Node.

```javascript
/**
@signature is X-SuperOffice-Signature header value
@secret is the stored shared secret
@ req is the HTTP request
@ buf is the body of the HTTP request
**/
function isValidWebHook(signature, secret, req, buf)
{
  // generate the signature locally
  const computedSignature = crypto
    .createHmac("sha256", secret)
    .update(buf.toString())
    .digest("base64");

  // compare generated vs. header value
  if (computedSignature === signature)
  {
    return true;
  } 
  else
  {
    return false;
  }
}
```

## Validation example using PHP

```php
/**
 * Validates SuperOffice webhook signature
 *
 * @param string $content The contents of the webhook
 * @param string $secret Your webhook secret
 * @param string $signature The signature from X-SuperOffice-Signature header
 *
 * @return bool
 */
function validateSignature(string $content, string $secret, string $signature): bool
{
    $sha256 = hash_hmac('sha256', $content, $secret, true);
    $base64 = base64_encode($sha256);

    return hash_equals($base64, $signature);
}
```

* [hash_hmac](https://www.php.net/manual/en/function.hash-hmac.php);
* [base64_encode](https://www.php.net/manual/en/function.base64-encode);
* [hash_equals](https://www.php.net/manual/en/function.hash-equals);

## Validation routine using Python

Community contribution from Fredrik Wik.

```python

#request.data is the webhook payload.
import hmac
import hashlib
import base64

xSignature = request.headers['x-superoffice-signature']
stored_secred = b"your_client_secret_here"
signature = str(base64.b64encode(hmac.new(stored_secred, request.data, digestmod=hashlib.sha256).digest()))
converted_signature = signature.split("'")[1]


if converted_signature == xSignature:
    print("They are the same")
else:
    print("They are different")

print(xSignature) #w+C9EOwS5kG2304s94RfJj8yzuXr2rzqfkRF3Kr5upg=
print(signature) #b'w+C9EOwS5kG2304s94RfJj8yzuXr2rzqfkRF3Kr5upg='
print(converted_signature) #w+C9EOwS5kG2304s94RfJj8yzuXr2rzqfkRF3Kr5upg=
```

<!-- Referenced links -->
[1]: https://sensecommerce.io/blog/validating-shopify-webhooks-node-js/
