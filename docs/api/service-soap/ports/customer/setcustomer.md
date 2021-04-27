---
title: cs_soap_ports_customer_setcustomer
description: Services SOAP interface port reference - customer setCustomer
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# setCustomer

## Description

This method will set/change one or more values on the logged-in customer. The values are sent as an array of **ValuePairStruct**, which contain one field and one value.

> [!NOTE]
> All fields have to be valid, else nothing will be stored.

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key |
| customerValues | An array of **ValuePairStruct** consisting of a field and a value. The field indicates which customer field you want to set and its value. It is important to only use legal fields, else the whole method will fail. To set an external extra field on a customer, use `x_<nr>` where nr = number of the extra fields. Use the `getExtraFields()` to find available extra fields. |

**Other legal fields are:**

* name
* display\_name
* firstname
* lastname
* phone
* cellphone
* note
* password
* email (will add the email address)
* language
* company (the ID of the company)

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |

## Example

```csharp
customer.customerService custService = new customer.customerService();
string errorCode = custService.login("johndoe","pw",out sessionKey);

if(errorCode.Equals("0"))
{
  customer.ValuePairStruct[] customerValues = new customer.ValuePairStruct[2];
  customerValues[0] = new customer.ValuePairStruct();
  customerValues[0].field = "name";
  customerValues[0].value = "Johnny X";
  customerValues[1] = new customer.ValuePairStruct();
  customerValues[1].field = "email";
  customerValues[1].value = "johnny@x.com";
  string ret = custService.setCustomer(sessionKey, customerValues);
}
```

<!-- Referenced links -->
[1]: ../../error-codes.md

<!-- Referenced links -->
[1]: ../../error-codes.md
