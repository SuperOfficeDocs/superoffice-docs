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
  "FromDate": "2007-11-15T13:13:59.4845676+01:00",
  "ToDate": "2008-10-12T13:13:59.4845676+02:00",
  "AssociateList": [
    {
      "Id": 58,
      "Name": "Torp Group",
      "ToolTip": "Quam deserunt.",
      "Deleted": true,
      "Rank": 362,
      "Type": "qui",
      "ColorBlock": 877,
      "IconHint": "exercitationem",
      "Selected": false,
      "LastChanged": "2016-08-26T13:13:59.4845676+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aliquam",
      "StyleHint": "voluptatem",
      "Hidden": true,
      "FullName": "Gwen Bergstrom",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 676
        }
      }
    }
  ],
  "GroupList": [
    {
      "Id": 713,
      "Name": "Orn Inc and Sons",
      "ToolTip": "Amet aut saepe.",
      "Deleted": false,
      "Rank": 690,
      "Type": "labore",
      "ColorBlock": 68,
      "IconHint": "est",
      "Selected": false,
      "LastChanged": "2005-05-30T13:13:59.4845676+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "consequuntur",
      "StyleHint": "numquam",
      "Hidden": false,
      "FullName": "Noah Connelly",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 222
        }
      }
    }
  ],
  "FutureDateList": [
    {
      "Id": 626,
      "Name": "Schulist LLC",
      "ToolTip": "Ut saepe eum et.",
      "Deleted": false,
      "Rank": 546,
      "Type": "qui",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "odit",
      "ColorBlock": 787,
      "ExtraInfo": "vel",
      "StyleHint": "repellat",
      "FullName": "Sibyl Berge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 969
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 63
    }
  }
}
```