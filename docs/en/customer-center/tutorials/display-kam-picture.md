---
title: Display the KAM's picture
uid: display_kam_picture
description: Get person image and display in the customer center
author: SuperOffice Product and Engineering
date: 06.24.2016
keywords: Customer Center
content_type: tutorial
index: true
---

# How to display the key account manager's picture

Encoding of binary data is normally behind the scenes. In CRMScript, it is represented as an array of Byte objects.

Binary data is base64 encoded when transmitted between the script and NetServer, but the encoding/decoding is handled behind the scenes.

The `NSStream` object is normally used for binary data, and in CRMScript this is represented as an array of Bytes.

## Example

We will now look at an example where we use the `NSStream` object to get a person’s image. We will also display this image in the Customer Centre.

```crmscript
#setLanguageLevel 3;

Integer id = getCgiVariable("assocId").toInteger();

NSUserAgent uAgent;
NSUser[] user = uAgent.GetUserFromEjUserId(id);

NSBLOBAgent bAgent;
NSImage image = bAgent.GetPersonImage(user[0].GetPerson().GetPersonId());

print("Content-Type: image/png\n\n");
printBinary(image.GetImage());
```
