---
title: POST Agents/Archive/GetActivityFilter
uid: v1ArchiveAgent_GetActivityFilter
generated: true
---

# POST Agents/Archive/GetActivityFilter

```http
POST /api/v1/Agents/Archive/GetActivityFilter
```

Get activity filter for the specified list.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Archive/GetActivityFilter?$select=name,department,category/id
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

### Response body: ActivityFilter

| Property Name | Type |  Description |
|----------------|------|--------------|
| FromDate | date-time | The filtering From date |
| ToDate | date-time | The filtering To date |
| AssociateList | array | The list of associates to filter on |
| GroupList | array | The list of groups to filter on |
| FutureDateList | array | The list of future date selections. This is a static MDO list with standard values. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Archive/GetActivityFilter
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "FromDate": "2000-02-12T10:30:23.0359181+01:00",
  "ToDate": "2009-03-06T10:30:23.0359181+01:00",
  "AssociateList": [
    {
      "Id": 555,
      "Name": "Hoeger, Bosco and Kerluke",
      "ToolTip": "Sit dolores unde quis accusantium quae.",
      "Deleted": false,
      "Rank": 922,
      "Type": "quia",
      "ColorBlock": 341,
      "IconHint": "temporibus",
      "Selected": true,
      "LastChanged": "2018-01-24T10:30:23.0359181+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "suscipit",
      "StyleHint": "veritatis",
      "Hidden": false,
      "FullName": "Mrs. Krystal Zulauf",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 869
        }
      }
    }
  ],
  "GroupList": [
    {
      "Id": 324,
      "Name": "Wiza LLC",
      "ToolTip": "Et et quod.",
      "Deleted": false,
      "Rank": 492,
      "Type": "eaque",
      "ColorBlock": 395,
      "IconHint": "maxime",
      "Selected": false,
      "LastChanged": "2015-05-05T10:30:23.0514184+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "enim",
      "StyleHint": "quo",
      "Hidden": false,
      "FullName": "Sven Kirlin",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 988
        }
      }
    }
  ],
  "FutureDateList": [
    {
      "Id": 799,
      "Name": "Bergnaum Inc and Sons",
      "ToolTip": "Nobis et voluptas rerum ab earum.",
      "Deleted": false,
      "Rank": 973,
      "Type": "eveniet",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "sunt",
      "ColorBlock": 994,
      "ExtraInfo": "voluptatem",
      "StyleHint": "facere",
      "FullName": "Greta Corkery",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 90
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 110
    }
  }
}
```