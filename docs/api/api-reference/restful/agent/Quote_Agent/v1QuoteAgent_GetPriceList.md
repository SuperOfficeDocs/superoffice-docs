---
title: POST Agents/Quote/GetPriceList
id: v1QuoteAgent_GetPriceList
---

# POST Agents/Quote/GetPriceList

```http
POST /api/v1/Agents/Quote/GetPriceList
```

Gets a PriceList object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| priceListId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Quote/GetPriceList?priceListId=974
POST /api/v1/Agents/Quote/GetPriceList?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response: object

A pricelist is basically a collection of products. It can be valid in a time period, and outright deactivated. All prices in the product list is in a specific currency. We have decieded not to separate prices and products, which means that we get a simpler data model, but some redundancy.



Carrier object for PriceList.
Services for the PriceList Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IQuoteAgent">Quote Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

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

## Sample Request

```http!
POST /api/v1/Agents/Quote/GetPriceList
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PriceListId": 542,
  "ERPPriceListKey": "numquam",
  "QuoteConnectionId": 656,
  "Name": "Welch, Mertz and Grimes",
  "Description": "Grass-roots full-range time-frame",
  "Currency": "quia",
  "CurrencyName": "Kunde, Greenfelder and Cruickshank",
  "ValidFrom": "2007-06-15T16:48:30.4329399+02:00",
  "ValidTo": "1994-04-12T16:48:30.4329399+02:00",
  "IsActive": false,
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 150
    }
  }
}
```