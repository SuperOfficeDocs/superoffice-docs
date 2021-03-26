---
title: POST List/Currency/Items
id: v1CurrencyList_PostCurrencyEntity
---

# POST List/Currency/Items

```http
POST /api/v1/List/Currency/Items
```

Create a new CurrencyEntity list item

Calls the List agent service SaveCurrencyEntity.






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

The CurrencyEntity to be created. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| CurrencyId | int32 | Primary key |
| Name | string | The list item |
| Tooltip | string | Tooltip or other description |
| Rank | int32 | Rank order |
| Rate | double | Exchange rate |
| Units | double | Exchange unit scale (0.01, 0.1, 1, 10, 100 etc) |
| Deleted | bool | 0 -&gt; record is active 1 -&gt; record is 'deleted' and should not be shown in lists |


## Response: object

Carrier object for CurrencyEntity.
Services for the CurrencyEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IListAgent">List Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| CurrencyId | int32 | Primary key |
| Name | string | The list item |
| Tooltip | string | Tooltip or other description |
| Rank | int32 | Rank order |
| Rate | double | Exchange rate |
| Units | double | Exchange unit scale (0.01, 0.1, 1, 10, 100 etc) |
| Deleted | bool | 0 -&gt; record is active 1 -&gt; record is 'deleted' and should not be shown in lists |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/List/Currency/Items
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "CurrencyId": 261,
  "Name": "Reichert-Reynolds",
  "Tooltip": "deleniti",
  "Rank": 985,
  "Rate": 11598.934,
  "Units": 16165.171999999999,
  "Deleted": false
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "CurrencyId": 394,
  "Name": "Casper, Becker and Wiegand",
  "Tooltip": "qui",
  "Rank": 906,
  "Rate": 19703.458,
  "Units": 7556.074,
  "Deleted": true,
  "TableRight": {
    "Mask": "Delete",
    "Reason": "reintermediate strategic applications"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 115
    }
  }
}
```