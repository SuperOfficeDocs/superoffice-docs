---
uid: cs-soap-ports-customer-getextrafields
title: getExtraFields
description: Services SOAP interface port reference - customer getExtraFields
keywords: customer port, getExtraFields method
author: SuperOffice Product and Engineering
date: 01.25.2021
content_type: reference
category: Service
topic: legacy SOAP interface
language: en
redirect_from: /en/service/soap/ports/customer/getextrafields
---

# getExtraFields

## Description

Finds the extra fields that are connected to customer, company, or ticket. The structure returned contains information about the extra field, such as data type, name. and ID. The method will only return extra fields marked as external.

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key |
| domain | The domain to list. Can be "customer", "company" or "ticket". Only the extra fields connected to the domain specified will be returned. |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
| extraFields | The available extra fields. |

| extraFields field | Description |
|---|---|
| fieldName | Internal name of the field. For example, "customer.x_1" |
| displayField | The external name of the extra field. |
| fieldId | The internal ID. Same as the number in `fieldName` |
| fieldType | Data type of the field. See appendix for legal types. |

## Example

```csharp
string sessionKey;
customer.customerService custService = new customer.customerService();

if(custService.login("test","test",out sessionKey)=="0")
{
  customer.ExtraFieldsStruct[] extraFields;
  custService.getExtraFields(sessionKey, "customer", out extraFields);
}
```

<!-- Referenced links -->
[1]: ../../error-codes.md

<!-- Referenced links -->
