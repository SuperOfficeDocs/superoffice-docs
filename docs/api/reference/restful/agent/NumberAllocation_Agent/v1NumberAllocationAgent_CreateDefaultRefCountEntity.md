---
title: POST Agents/NumberAllocation/CreateDefaultRefCountEntity
id: v1NumberAllocationAgent_CreateDefaultRefCountEntity
---

# POST Agents/NumberAllocation/CreateDefaultRefCountEntity

```http
POST /api/v1/Agents/NumberAllocation/CreateDefaultRefCountEntity
```

Set default values into a new RefCountEntity.

NetServer calculates default values on the entity, which is required when creating/storing a new instance

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

A refcount entity for a number allocation

Carrier object for RefCountEntity.
Services for the RefCountEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.INumberAllocationAgent">NumberAllocation Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| RefCountsId | int32 | Primary key |
| Field | string | Field identifier in string format table.field |
| RecordId | int32 | Record id in target table, used when there are separate counters for each target record |
| SuggestedRecords | array | List of valid entities, the associated record is selected in the list, used records are filtered out |
| CurrentValue | int32 | Current value of counter |
| TravelPrefix | int32 | size of prefix for Travel use of ths counter |
| SatPrefix | int32 | size of prefix for Satellite use of this counter |
| Allocate | bool | Allocate numbers automatically |
| Unique | bool | Check that entered value is unique |
| ReadOnly | bool | Target field is read only in GUI |
| AllowBlank | bool | Allow blank  as a valid value |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/NumberAllocation/CreateDefaultRefCountEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "RefCountsId": 575,
  "Field": "sapiente",
  "RecordId": 380,
  "SuggestedRecords": [
    {
      "Id": 655,
      "Name": "Eichmann Inc and Sons",
      "ToolTip": "Sunt voluptas ipsam asperiores veniam ea mollitia.",
      "Deleted": false,
      "Rank": 863,
      "Type": "fugit",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "et",
      "ColorBlock": 136,
      "ExtraInfo": "eius",
      "StyleHint": "optio",
      "FullName": "Agustin Fritsch IV",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 736
        }
      }
    }
  ],
  "CurrentValue": 593,
  "TravelPrefix": 811,
  "SatPrefix": 403,
  "Allocate": false,
  "Unique": false,
  "ReadOnly": false,
  "AllowBlank": true,
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
      "FieldLength": 996
    }
  }
}
```
