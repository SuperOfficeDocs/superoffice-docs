---
title: POST Agents/Quote/SavePriceList
uid: v1QuoteAgent_SavePriceList
---

# POST Agents/Quote/SavePriceList

```http
POST /api/v1/Agents/Quote/SavePriceList
```

Updates the existing PriceList or creates a new PriceList if the id parameter is empty








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

## Request Body: entity 

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

### Response body: PriceList

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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Quote/SavePriceList
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PriceListId": 343,
  "ERPPriceListKey": "consequatur",
  "QuoteConnectionId": 589,
  "Name": "Stehr, Lebsack and Kshlerin",
  "Description": "Advanced dedicated standardization",
  "Currency": "sed",
  "CurrencyName": "Orn-Halvorson",
  "ValidFrom": "2015-10-21T17:37:18.7082418+02:00",
  "ValidTo": "2012-01-25T17:37:18.7082418+01:00",
  "IsActive": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PriceListId": 488,
  "ERPPriceListKey": "at",
  "QuoteConnectionId": 603,
  "Name": "Schneider-Greenfelder",
  "Description": "Universal clear-thinking Graphical User Interface",
  "Currency": "eligendi",
  "CurrencyName": "Dooley-Weissnat",
  "ValidFrom": "2008-07-08T17:37:18.7082418+02:00",
  "ValidTo": "2022-10-10T17:37:18.7082418+02:00",
  "IsActive": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 803
    }
  }
}
```