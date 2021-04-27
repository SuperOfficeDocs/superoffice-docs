---
title: cs_soap_ports_customer_geterrormessage
description: Services SOAP interface port reference - customer getErrorMessage
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# getErrorMessage

## Description

Finds the descriptive text for an error. These messages are linked to the session, so only the last error message for one session is returned. For errors before you receive a valid session key see the appendix.

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key. |

## Out parameters

| Parameter | Description |
|---|---|
| errorMessage | A text explaining the last error. |

## Example

```csharp
string sessionKey;

customer.customerService custService = new customer.customerService();
custService.login("test","test",out sessionKey);
string[] customerFields = new string[1];
customerFields[0]="kuztumer.name";

customer.ResultStruct[] customerResult;
string[] customerEmail;
string res = custService.getCustomer(sessionKey, customerFields, out customerResult, out customerEmail);

if(res =="0")
  textBox1.Text = "OK";
else
  textBox1.Text = custService.getErrorMessage(sessionKey);
```

<!-- Referenced links -->
[1]: ../../error-codes.md
