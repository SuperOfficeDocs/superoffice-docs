---
title: POST Pricelist
uid: v1PriceList_PostPriceList
---

# POST Pricelist

```http
POST /api/v1/Pricelist
```

Creates a new PriceList


Calls the Quote agent service SavePriceList.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/Pricelist?$select=name,department,category/id
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

## Request Body: newEntity 

The PriceList to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| PriceListId | Integer | Primary key |
| ERPPriceListKey | String | The key that uniquely identifies this pricelist in the ERP system |
| QuoteConnectionId | Integer | (Reserved for future use) The connection to the ERP system used for this pricelist |
| Name | String | Name of this pricelist to use in the user interface. |
| Description | String | Description of this pricelist , will be used as tool-tip in the user interface. |
| Currency | String | The iso currency code, like 'USD' or 'NOK'. |
| CurrencyName | String | The name to use in the user interface, like perhaps 'US dollar' or '$' |
| ValidFrom | String | The date (inclusive) the pricelist start to be valid. This can be DateTime.MinValue to signal that it doesn't have a specific start date. |
| ValidTo | String | The date (inclusive) the pricelist ends to be valid. This can be DateTime.MaxValue to signal that it doesn't have a specific end date. |
| IsActive | Boolean | Is the list active (as opposed to being worked on, suddenly canceled, etc. |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: PriceListWithLinks

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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
POST /api/v1/Pricelist
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "PriceListId": 523,
  "ERPPriceListKey": "aut",
  "QuoteConnectionId": 563,
  "Name": "Haley, Carroll and Gislason",
  "Description": "Monitored neutral alliance",
  "Currency": "minus",
  "CurrencyName": "Cremin, Boyer and Hermann",
  "ValidFrom": "2001-01-09T03:51:34.7708309+01:00",
  "ValidTo": "1997-09-30T03:51:34.7708309+02:00",
  "IsActive": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PriceListId": 714,
  "ERPPriceListKey": "officia",
  "QuoteConnectionId": 530,
  "Name": "Skiles-Macejkovic",
  "Description": "Proactive encompassing productivity",
  "Currency": "esse",
  "CurrencyName": "Crooks, Keebler and Bashirian",
  "ValidFrom": "2022-02-07T03:51:34.7708309+01:00",
  "ValidTo": "2018-12-28T03:51:34.7708309+01:00",
  "IsActive": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 110
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```