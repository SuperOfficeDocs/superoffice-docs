---
title: POST Pricelist/{id}/CopyTo/{newName}
uid: v1PriceList_CopySuperOfficePriceList
---

# POST Pricelist/{id}/CopyTo/{newName}

```http
POST /api/v1/Pricelist/{originalPriceListId}/CopyTo/{newName}
```

Create a copy of a PriceList in the SuperOffice database






| Path Part | Type | Description |
|-----------|------|-------------|
| originalPriceListId | int32 | Id of the PriceList to be copied **Required** |
| newName | string | Name of the copied PriceList **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| validFrom | date-time | **Required** Start date for the new pricelist. |
| validTo | date-time | **Required** End date for the new pricelist. |
| newCurrencyId | int32 |  Currency id of the copied PriceList. If 0 or the same as the original the copied products will keep their prices and the currency will be the same as the original. |
| convertCurrency | bool |  If true, product prices will be recalculated to the new currency. If false, product prices will be set to zero. |

```http
POST /api/v1/Pricelist/{originalPriceListId}/CopyTo/{newName}?validFrom=03/28/2004 11:10:55
POST /api/v1/Pricelist/{originalPriceListId}/CopyTo/{newName}?validTo=05/24/2003 11:10:55
POST /api/v1/Pricelist/{originalPriceListId}/CopyTo/{newName}?newCurrencyId=580
POST /api/v1/Pricelist/{originalPriceListId}/CopyTo/{newName}?convertCurrency=False
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
POST /api/v1/Pricelist/{originalPriceListId}/CopyTo/{newName}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PriceListId": 887,
  "ERPPriceListKey": "vero",
  "QuoteConnectionId": 700,
  "Name": "Lakin-Hills",
  "Description": "Realigned contextually-based collaboration",
  "Currency": "aspernatur",
  "CurrencyName": "Von Inc and Sons",
  "ValidFrom": "2011-07-16T11:10:54.3909023+02:00",
  "ValidTo": "1999-03-24T11:10:54.3909023+01:00",
  "IsActive": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 98
    }
  }
}
```