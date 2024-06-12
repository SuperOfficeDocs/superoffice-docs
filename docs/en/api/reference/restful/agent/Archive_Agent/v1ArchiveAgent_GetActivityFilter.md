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
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "FromDate": "2005-01-20T04:22:25.94972+01:00",
  "ToDate": "2004-02-23T04:22:25.94972+01:00",
  "AssociateList": [
    {
      "Id": 69,
      "Name": "Hoppe-Rippin",
      "ToolTip": "Incidunt enim non perspiciatis molestiae sequi.",
      "Deleted": false,
      "Rank": 290,
      "Type": "dicta",
      "ColorBlock": 713,
      "IconHint": "sequi",
      "Selected": true,
      "LastChanged": "2005-05-29T04:22:25.94972+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "perferendis",
      "StyleHint": "tempore",
      "Hidden": false,
      "FullName": "Mark Keaton Dickens DDS",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 778
        }
      }
    }
  ],
  "GroupList": [
    {
      "Id": 943,
      "Name": "Prohaska-Cormier",
      "ToolTip": "Vitae nobis aperiam maxime ducimus quia aut omnis.",
      "Deleted": true,
      "Rank": 221,
      "Type": "culpa",
      "ColorBlock": 497,
      "IconHint": "atque",
      "Selected": true,
      "LastChanged": "2014-08-29T04:22:25.94972+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "vel",
      "StyleHint": "eligendi",
      "Hidden": false,
      "FullName": "Hilton Stroman",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 812
        }
      }
    }
  ],
  "FutureDateList": [
    {
      "Id": 529,
      "Name": "Kilback Inc and Sons",
      "ToolTip": "Sed ut.",
      "Deleted": false,
      "Rank": 705,
      "Type": "est",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "labore",
      "ColorBlock": 401,
      "ExtraInfo": "a",
      "StyleHint": "illo",
      "FullName": "Consuelo Chaim Botsford V",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 526
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 535
    }
  }
}
```