---
title: POST Agents/Quote/GetAllPriceLists
uid: v1QuoteAgent_GetAllPriceLists
---

# POST Agents/Quote/GetAllPriceLists

```http
POST /api/v1/Agents/Quote/GetAllPriceLists
```

Gets the all PriceLists in all currencies, including those inactive.

Will return empty array if there is no PriceList available.

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Quote/GetAllPriceLists?$select=name,department,category/id
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

QuoteConnectionId, Currency

| Property Name | Type |  Description |
|----------------|------|--------------|
| QuoteConnectionId | int32 |  |
| Currency | string |  |

## Response: array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

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
POST /api/v1/Agents/Quote/GetAllPriceLists
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "QuoteConnectionId": 718,
  "Currency": "qui"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "PriceListId": 897,
    "ERPPriceListKey": "aperiam",
    "QuoteConnectionId": 64,
    "Name": "Lemke-Cruickshank",
    "Description": "Expanded uniform Graphic Interface",
    "Currency": "quo",
    "CurrencyName": "Collier Inc and Sons",
    "ValidFrom": "2014-07-08T11:10:27.7114917+02:00",
    "ValidTo": "2003-09-20T11:10:27.7114917+02:00",
    "IsActive": false,
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 142
      }
    }
  }
]
```
