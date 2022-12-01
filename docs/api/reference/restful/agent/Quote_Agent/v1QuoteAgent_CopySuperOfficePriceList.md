---
title: POST Agents/Quote/CopySuperOfficePriceList
uid: v1QuoteAgent_CopySuperOfficePriceList
---

# POST Agents/Quote/CopySuperOfficePriceList

```http
POST /api/v1/Agents/Quote/CopySuperOfficePriceList
```

Create a copy of a PriceList in the SuperOffice database







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Quote/CopySuperOfficePriceList?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request  

OriginalPriceListId, NewName, ValidFrom, ValidTo, NewCurrencyId, ConvertCurrency 

| Property Name | Type |  Description |
|----------------|------|--------------|
| OriginalPriceListId | int32 |  |
| NewName | string |  |
| ValidFrom | date-time |  |
| ValidTo | date-time |  |
| NewCurrencyId | int32 |  |
| ConvertCurrency | bool |  |


## Response: 

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: 

| Property Name | Type |  Description |
|----------------|------|--------------|
| PriceListId | int32 | Primary key |
| ERPPriceListKey | string | The key that uniquely identifies this pricelist in the ERP system |
| QuoteConnectionId | int32 | (Reserved for future use) The connection to the ERP system used for this pricelist |
| Name | string | Name of this pricelist to use in the user interface. |
| Description | string | Description of this pricelist , will be used as tool-tip in the user interface. |
| Currency | string | The iso currency code, like 'USD' or 'NOK'. |
| CurrencyName | string | The name to use in the user interface, like perhaps 'US dollar' or '$' |
| ValidFrom | date-time | The date (inclusive) the pricelist start to be valid. This can be DateTime.MinValue to signal that it doesn't have a specific start date. |
| ValidTo | date-time | The date (inclusive) the pricelist ends to be valid. This can be DateTime.MaxValue to signal that it doesn't have a specific end date. |
| IsActive | bool | Is the list active (as opposed to being worked on, suddenly canceled, etc. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Quote/CopySuperOfficePriceList
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "OriginalPriceListId": 644,
  "NewName": "Von-Bergstrom",
  "ValidFrom": "2019-08-27T02:49:45.0153392+02:00",
  "ValidTo": "2013-09-16T02:49:45.0153392+02:00",
  "NewCurrencyId": 318,
  "ConvertCurrency": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PriceListId": 48,
  "ERPPriceListKey": "officia",
  "QuoteConnectionId": 893,
  "Name": "Ryan, Hammes and Howe",
  "Description": "Vision-oriented grid-enabled alliance",
  "Currency": "odio",
  "CurrencyName": "Weimann, Reinger and Weber",
  "ValidFrom": "2020-10-14T02:49:45.0153392+02:00",
  "ValidTo": "2009-11-09T02:49:45.0153392+01:00",
  "IsActive": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 650
    }
  }
}
```