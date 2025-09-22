---
title: POST Agents/Archive/GetActivityFilter
uid: v1ArchiveAgent_GetActivityFilter
generated: true
content_type: reference
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
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "FromDate": "2005-07-12T11:24:47.5939281+02:00",
  "ToDate": "2002-04-26T11:24:47.5939281+02:00",
  "AssociateList": [
    {
      "Id": 145,
      "Name": "Wisoky, Ankunding and Schinner",
      "ToolTip": "Nulla asperiores maxime.",
      "Deleted": true,
      "Rank": 665,
      "Type": "odit",
      "ColorBlock": 238,
      "IconHint": "quia",
      "Selected": true,
      "LastChanged": "2020-11-25T11:24:47.5939281+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quisquam",
      "StyleHint": "aut",
      "Hidden": false,
      "FullName": "Geovanni Litzy Kertzmann III",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 276
        }
      }
    }
  ],
  "GroupList": [
    {
      "Id": 67,
      "Name": "Leannon Inc and Sons",
      "ToolTip": "Optio officia aut laboriosam.",
      "Deleted": false,
      "Rank": 72,
      "Type": "accusantium",
      "ColorBlock": 144,
      "IconHint": "iure",
      "Selected": false,
      "LastChanged": "2002-03-23T11:24:47.5939281+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "est",
      "StyleHint": "quo",
      "Hidden": true,
      "FullName": "Estevan Walter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 927
        }
      }
    }
  ],
  "FutureDateList": [
    {
      "Id": 922,
      "Name": "Block-Bogisich",
      "ToolTip": "Sed eum velit sint aut id dolore.",
      "Deleted": false,
      "Rank": 626,
      "Type": "rem",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "sed",
      "ColorBlock": 262,
      "ExtraInfo": "corrupti",
      "StyleHint": "nostrum",
      "FullName": "Jacklyn Hauck",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 470
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 396
    }
  }
}
```