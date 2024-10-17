---
uid: crmscript-message-load
title: Get message info
description: How to load and get info about a request message with CRMScript.
keywords: CRMScript, Service, ticket, request, message, load, getValue, attachment
author: Bergfrid Skaara Dias
date: 05.26.2023
version: 10
topic: howto
---

# Get message info

## Bool load(Integer id)

Brings up the message with the given ID. This is always the 1st step when you want to do anything with an existing message.

```crmscript
Message m;
m.load(1);
```

## String getValue(String colName)

Fetches the value from a named field. Look up names in the reference section down below.

```crmscript!
Message m;
m.load(2);
print(m.getValue("timeCharge").toString());
```

## Integer\[\] getAttachments()

Fetches the ID of all attachments connected to the message.

```crmscript!
Message m;
m.load(2);
Integer[] attachments = m.getAttachments();
while(attachments.length() > 0) {
  printLine(attachments.popFront());
}
```

<!-- Referenced links -->
