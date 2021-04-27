---
title: cs_soap_ports_customer_addattachment
description: Services SOAP interface port reference - customer addAttachment
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# addAttachment

## Description

Adds an attachment to the system. When creating a new message that contains an attachment you first have to add the attachment to the system, and then attach the attachment id returned from this method to the message. The attachment has to be base64 encoded.

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid or empty session key |
| attachmentName | The file name or other suitable name of the attachment |
| contentType | The mime like content-type of the file |
| data | Base64 encoded data |

[!include[ALT](../includes/attachment-content-types.md)]

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
| attachmentId | The ID that is assigned to the attachment by SuperOffice |

## Example

```csharp
System.IO.FileStream inFile;

string fileName = "c:\\myfile.bin";

byte[] binaryData;
inFile = new System.IO.FileStream(fileName, System.IO.FileMode.Open, System.IO.FileAccess.Read);

binaryData = new Byte[inFile.Length];
long bytesRead = inFile.Read(binaryData, 0, (int)inFile.Length);
inFile.Close();

string base64String;
base64String = System.Convert.ToBase64String(binaryData, 0, binaryData.Length);

customer.customerService custService = new customer.customerService();

string sessionKey;
string ret = custService.login("testuser","testpassword", out sessionKey);

if(ret == "0")
{
  string attachmentID;
  ret = custService.addAttachment(sessionKey, fileName, "application/octet-stream", base64String, out attachmentID);
  //[insert the attachment ID in the new message here]
  custService.logout(sessionKey);
}

ret = custService.logout(sessionKey);
```

<!-- Referenced links -->
[1]: ../../error-codes.md
