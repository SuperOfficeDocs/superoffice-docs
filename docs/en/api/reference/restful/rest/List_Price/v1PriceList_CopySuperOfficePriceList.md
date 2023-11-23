---
title: POST Pricelist/{id}/CopyTo/{newName}
uid: v1PriceList_CopySuperOfficePriceList
generated: true
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
POST /api/v1/Pricelist/{originalPriceListId}/CopyTo/{newName}?validFrom=08/26/1999 13:38:18
POST /api/v1/Pricelist/{originalPriceListId}/CopyTo/{newName}?validTo=10/01/2006 13:38:18
POST /api/v1/Pricelist/{originalPriceListId}/CopyTo/{newName}?newCurrencyId=226
POST /api/v1/Pricelist/{originalPriceListId}/CopyTo/{newName}?convertCurrency=True
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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

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
  "PriceListId": 691,
  "ERPPriceListKey": "dolores",
  "QuoteConnectionId": 4,
  "Name": "Cassin-Koelpin",
  "Description": "De-engineered neutral support",
  "Currency": "aliquam",
  "CurrencyName": "Lowe Inc and Sons",
  "ValidFrom": "2008-02-04T13:38:18.1087815+01:00",
  "ValidTo": "2017-01-31T13:38:18.1087815+01:00",
  "IsActive": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 718
    }
  }
}
```