---
title: GET Pricelist/default
uid: v1PriceList_DefaultPriceList
generated: true
---

# GET Pricelist/default

```http
GET /api/v1/Pricelist/default
```

Set default values into a new PriceList.


NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Quote agent service CreateDefaultPriceList.







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
GET /api/v1/Pricelist/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PriceListId": 916,
  "ERPPriceListKey": "eligendi",
  "QuoteConnectionId": 881,
  "Name": "Auer-Schimmel",
  "Description": "Synergistic web-enabled adapter",
  "Currency": "iste",
  "CurrencyName": "Bergnaum Group",
  "ValidFrom": "2008-05-18T17:54:08.9605465+02:00",
  "ValidTo": "1999-06-23T17:54:08.9605465+02:00",
  "IsActive": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 578
    }
  }
}
```