---
title: PUT Pricelist/{id}
id: v1PriceList_PutPriceList
---

# PUT Pricelist/{id}

```http
PUT /api/v1/Pricelist/{id}
```

Updates the existing PriceList






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The PriceList id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/Pricelist/{id}?$select=name,department,category/id
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

## Request Body: entity  

The PriceList to be saved. 

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


## Response: object

A pricelist is basically a collection of products. It can be valid in a time period, and outright deactivated. All prices in the product list is in a specific currency. We have decieded not to separate prices and products, which means that we get a simpler data model, but some redundancy.



PriceList entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | PriceList updated. |
| 400 | Bad request. Entity to save is not in request body. |

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
| _Links | object |  |

## Sample Request

```http!
PUT /api/v1/Pricelist/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PriceListId": 521,
  "ERPPriceListKey": "est",
  "QuoteConnectionId": 893,
  "Name": "Collier Inc and Sons",
  "Description": "Synergistic 5th generation migration",
  "Currency": "et",
  "CurrencyName": "Lindgren-Fritsch",
  "ValidFrom": "2011-01-29T09:41:00.5193814+01:00",
  "ValidTo": "2018-06-24T09:41:00.5193814+02:00",
  "IsActive": true
}
```

```http_
HTTP/1.1 200 PriceList updated.
Content-Type: application/json; charset=utf-8

{
  "PriceListId": 320,
  "ERPPriceListKey": "pariatur",
  "QuoteConnectionId": 678,
  "Name": "Kutch LLC",
  "Description": "Multi-layered motivating function",
  "Currency": "aperiam",
  "CurrencyName": "Hahn-Waelchi",
  "ValidFrom": "1998-01-04T09:41:00.5193814+01:00",
  "ValidTo": "2010-03-15T09:41:00.5193814+01:00",
  "IsActive": true,
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
      "FieldType": "System.Int32",
      "FieldLength": 82
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```