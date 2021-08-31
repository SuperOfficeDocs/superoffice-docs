---
title: SaveRefCountEntity
id: v1NumberAllocationAgent_SaveRefCountEntity
---

# SaveRefCountEntity

```http
POST /api/v1/Agents/NumberAllocation/SaveRefCountEntity
```

Updates the existing RefCountEntity or creates a new RefCountEntity if the id parameter is empty








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

The RefCountEntity to be saved. 

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
POST /api/v1/Agents/NumberAllocation/SaveRefCountEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "RefCountsId": 445,
  "Field": "consequuntur",
  "RecordId": 570,
  "SuggestedRecords": [
    {
      "Id": 389,
      "Name": "Lueilwitz-Barton",
      "ToolTip": "Voluptas dolorem inventore vitae.",
      "Deleted": false,
      "Rank": 543,
      "Type": "explicabo",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "enim",
      "ColorBlock": 395,
      "ExtraInfo": "velit",
      "StyleHint": "quam",
      "FullName": "Phyllis Gislason"
    }
  ],
  "CurrentValue": 76,
  "TravelPrefix": 338,
  "SatPrefix": 718,
  "Allocate": false,
  "Unique": false,
  "ReadOnly": false,
  "AllowBlank": false
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "RefCountsId": 919,
  "Field": "vel",
  "RecordId": 372,
  "SuggestedRecords": [
    {
      "Id": 918,
      "Name": "Daugherty, Koelpin and Durgan",
      "ToolTip": "Mollitia qui quia sunt reiciendis.",
      "Deleted": true,
      "Rank": 86,
      "Type": "unde",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "est",
      "ColorBlock": 316,
      "ExtraInfo": "dolorum",
      "StyleHint": "perspiciatis",
      "FullName": "Ms. Columbus Becker",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 878
        }
      }
    }
  ],
  "CurrentValue": 674,
  "TravelPrefix": 228,
  "SatPrefix": 103,
  "Allocate": true,
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
      "FieldType": "System.Int32",
      "FieldLength": 53
    }
  }
}
```