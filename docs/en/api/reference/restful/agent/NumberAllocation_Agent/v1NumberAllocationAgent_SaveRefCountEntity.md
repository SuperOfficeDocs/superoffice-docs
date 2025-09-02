---
title: POST Agents/NumberAllocation/SaveRefCountEntity
uid: v1NumberAllocationAgent_SaveRefCountEntity
generated: true
content_type: reference
---

# POST Agents/NumberAllocation/SaveRefCountEntity

```http
POST /api/v1/Agents/NumberAllocation/SaveRefCountEntity
```

Updates the existing RefCountEntity or creates a new RefCountEntity if the id parameter is 0.








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

## Request Body: refCountEntity 

The RefCountEntity that is saved 

| Property Name | Type |  Description |
|----------------|------|--------------|
| RefCountsId | Integer | Primary key |
| Field | String | Field identifier in string format table.field |
| RecordId | Integer | Record id in target table, used when there are separate counters for each target record |
| SuggestedRecords | Array | List of valid entities, the associated record is selected in the list, used records are filtered out |
| CurrentValue | Integer | Current value of counter |
| TravelPrefix | Integer | size of prefix for Travel use of ths counter |
| SatPrefix | Integer | size of prefix for Satellite use of this counter |
| Allocate | Boolean | Allocate numbers automatically |
| Unique | Boolean | Check that entered value is unique |
| ReadOnly | Boolean | Target field is read only in GUI |
| AllowBlank | Boolean | Allow blank  as a valid value |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: RefCountEntity

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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/NumberAllocation/SaveRefCountEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "RefCountsId": 623,
  "Field": "in",
  "RecordId": 920,
  "SuggestedRecords": [
    {
      "Id": 972,
      "Name": "Luettgen Group",
      "ToolTip": "Optio dolorem sed sed.",
      "Deleted": false,
      "Rank": 224,
      "Type": "necessitatibus",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "sequi",
      "ColorBlock": 199,
      "ExtraInfo": "ut",
      "StyleHint": "tempora",
      "FullName": "Madeline Adams"
    }
  ],
  "CurrentValue": 53,
  "TravelPrefix": 362,
  "SatPrefix": 669,
  "Allocate": false,
  "Unique": true,
  "ReadOnly": false,
  "AllowBlank": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "RefCountsId": 308,
  "Field": "sequi",
  "RecordId": 175,
  "SuggestedRecords": [
    {
      "Id": 677,
      "Name": "Zulauf, Murazik and Kohler",
      "ToolTip": "Ipsum aut asperiores repudiandae commodi odit voluptas.",
      "Deleted": false,
      "Rank": 197,
      "Type": "dignissimos",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "aut",
      "ColorBlock": 319,
      "ExtraInfo": "est",
      "StyleHint": "eligendi",
      "FullName": "Kaycee Effertz",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 108
        }
      }
    }
  ],
  "CurrentValue": 247,
  "TravelPrefix": 392,
  "SatPrefix": 345,
  "Allocate": false,
  "Unique": false,
  "ReadOnly": false,
  "AllowBlank": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 70
    }
  }
}
```