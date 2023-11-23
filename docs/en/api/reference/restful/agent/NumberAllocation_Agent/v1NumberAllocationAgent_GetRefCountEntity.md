---
title: POST Agents/NumberAllocation/GetRefCountEntity
uid: v1NumberAllocationAgent_GetRefCountEntity
generated: true
---

# POST Agents/NumberAllocation/GetRefCountEntity

```http
POST /api/v1/Agents/NumberAllocation/GetRefCountEntity
```

Gets a RefCountEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| refCountEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/NumberAllocation/GetRefCountEntity?refCountEntityId=99
POST /api/v1/Agents/NumberAllocation/GetRefCountEntity?$select=name,department,category/id
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
POST /api/v1/Agents/NumberAllocation/GetRefCountEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "RefCountsId": 873,
  "Field": "est",
  "RecordId": 406,
  "SuggestedRecords": [
    {
      "Id": 449,
      "Name": "Wunsch, Hyatt and Lubowitz",
      "ToolTip": "Recusandae voluptatem maxime officiis.",
      "Deleted": false,
      "Rank": 392,
      "Type": "eaque",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "rerum",
      "ColorBlock": 990,
      "ExtraInfo": "sint",
      "StyleHint": "sint",
      "FullName": "Kristina Pollich",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 772
        }
      }
    }
  ],
  "CurrentValue": 768,
  "TravelPrefix": 574,
  "SatPrefix": 9,
  "Allocate": false,
  "Unique": false,
  "ReadOnly": false,
  "AllowBlank": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 743
    }
  }
}
```