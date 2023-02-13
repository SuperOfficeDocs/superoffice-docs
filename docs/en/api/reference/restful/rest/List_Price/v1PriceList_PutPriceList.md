---
title: PUT Pricelist/{id}
uid: v1PriceList_PutPriceList
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

PriceList updated.

| Response | Description |
|----------------|-------------|
| 200 | PriceList updated. |
| 400 | Bad request. Entity to save is not in request body. |

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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/Pricelist/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "PriceListId": 840,
  "ERPPriceListKey": "voluptate",
  "QuoteConnectionId": 447,
  "Name": "Hoeger Inc and Sons",
  "Description": "Down-sized solution-oriented protocol",
  "Currency": "aut",
  "CurrencyName": "Terry Inc and Sons",
  "ValidFrom": "1995-12-15T11:22:46.0066565+01:00",
  "ValidTo": "1998-06-10T11:22:46.0066565+02:00",
  "IsActive": false
}
```

## Sample response

```http_
HTTP/1.1 200 PriceList updated.
Content-Type: application/json; charset=utf-8

{
  "PriceListId": 16,
  "ERPPriceListKey": "ut",
  "QuoteConnectionId": 581,
  "Name": "Prohaska, Gulgowski and Keebler",
  "Description": "Organized optimal service-desk",
  "Currency": "delectus",
  "CurrencyName": "Farrell-Nienow",
  "ValidFrom": "2004-07-17T11:22:46.0066565+02:00",
  "ValidTo": "1996-10-21T11:22:46.0066565+02:00",
  "IsActive": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 709
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```