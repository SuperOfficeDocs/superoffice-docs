---
title: POST Agents/NumberAllocation/SaveRefCountEntity
id: v1NumberAllocationAgent_SaveRefCountEntity
---

# POST Agents/NumberAllocation/SaveRefCountEntity

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
  "RefCountsId": 429,
  "Field": "ea",
  "RecordId": 855,
  "SuggestedRecords": [
    {
      "Id": 800,
      "Name": "Durgan LLC",
      "ToolTip": "Ullam dolores deleniti iure velit.",
      "Deleted": true,
      "Rank": 725,
      "Type": "hic",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "minima",
      "ColorBlock": 724,
      "ExtraInfo": "rem",
      "StyleHint": "repudiandae",
      "FullName": "Abigayle Williamson"
    }
  ],
  "CurrentValue": 588,
  "TravelPrefix": 403,
  "SatPrefix": 216,
  "Allocate": false,
  "Unique": true,
  "ReadOnly": false,
  "AllowBlank": false
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "RefCountsId": 389,
  "Field": "qui",
  "RecordId": 367,
  "SuggestedRecords": [
    {
      "Id": 644,
      "Name": "Collins, Lindgren and McCullough",
      "ToolTip": "Non pariatur accusamus voluptas nam.",
      "Deleted": false,
      "Rank": 913,
      "Type": "deserunt",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "quae",
      "ColorBlock": 71,
      "ExtraInfo": "qui",
      "StyleHint": "possimus",
      "FullName": "Adela Bartell V",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 146
        }
      }
    }
  ],
  "CurrentValue": 127,
  "TravelPrefix": 182,
  "SatPrefix": 288,
  "Allocate": true,
  "Unique": false,
  "ReadOnly": true,
  "AllowBlank": false,
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
      "FieldLength": 646
    }
  }
}
```