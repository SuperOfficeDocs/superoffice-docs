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
  "RefCountsId": 97,
  "Field": "inventore",
  "RecordId": 655,
  "SuggestedRecords": [
    {
      "Id": 659,
      "Name": "Weimann LLC",
      "ToolTip": "Dignissimos nesciunt saepe nihil repellat voluptatibus.",
      "Deleted": false,
      "Rank": 102,
      "Type": "optio",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "unde",
      "ColorBlock": 771,
      "ExtraInfo": "ea",
      "StyleHint": "ullam",
      "FullName": "Franco Larkin V"
    }
  ],
  "CurrentValue": 200,
  "TravelPrefix": 628,
  "SatPrefix": 181,
  "Allocate": false,
  "Unique": true,
  "ReadOnly": true,
  "AllowBlank": true
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "RefCountsId": 874,
  "Field": "tempora",
  "RecordId": 572,
  "SuggestedRecords": [
    {
      "Id": 731,
      "Name": "Gaylord Group",
      "ToolTip": "Quos fugit dolores ut.",
      "Deleted": false,
      "Rank": 238,
      "Type": "quia",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "ullam",
      "ColorBlock": 625,
      "ExtraInfo": "at",
      "StyleHint": "quia",
      "FullName": "Julia Lowe",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 589
        }
      }
    }
  ],
  "CurrentValue": 767,
  "TravelPrefix": 406,
  "SatPrefix": 701,
  "Allocate": false,
  "Unique": true,
  "ReadOnly": false,
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
      "FieldLength": 930
    }
  }
}
```