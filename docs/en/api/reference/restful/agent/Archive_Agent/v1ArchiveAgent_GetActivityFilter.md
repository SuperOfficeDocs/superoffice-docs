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
  "FromDate": "2004-10-25T12:19:44.4611915+02:00",
  "ToDate": "2001-02-15T12:19:44.4611915+01:00",
  "AssociateList": [
    {
      "Id": 189,
      "Name": "Hansen, Christiansen and Maggio",
      "ToolTip": "Dolores rem eos architecto.",
      "Deleted": true,
      "Rank": 751,
      "Type": "dolores",
      "ColorBlock": 887,
      "IconHint": "enim",
      "Selected": true,
      "LastChanged": "2000-04-20T12:19:44.4611915+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "similique",
      "StyleHint": "et",
      "Hidden": false,
      "FullName": "Dennis Zieme",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 83
        }
      }
    }
  ],
  "GroupList": [
    {
      "Id": 522,
      "Name": "Little-Howe",
      "ToolTip": "Dolore rerum voluptatem qui velit et dignissimos pariatur.",
      "Deleted": true,
      "Rank": 562,
      "Type": "ea",
      "ColorBlock": 959,
      "IconHint": "quam",
      "Selected": false,
      "LastChanged": "2022-02-02T12:19:44.4611915+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "soluta",
      "StyleHint": "omnis",
      "Hidden": true,
      "FullName": "Keenan Mraz IV",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 904
        }
      }
    }
  ],
  "FutureDateList": [
    {
      "Id": 738,
      "Name": "Hammes LLC",
      "ToolTip": "Autem qui aliquam reiciendis.",
      "Deleted": false,
      "Rank": 289,
      "Type": "optio",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "molestias",
      "ColorBlock": 288,
      "ExtraInfo": "expedita",
      "StyleHint": "ratione",
      "FullName": "Vena Runte",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 704
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 61
    }
  }
}
```