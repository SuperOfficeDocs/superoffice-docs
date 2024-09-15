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
  "FromDate": "2006-11-22T04:02:01.2056679+01:00",
  "ToDate": "2014-11-03T04:02:01.2056679+01:00",
  "AssociateList": [
    {
      "Id": 989,
      "Name": "Waters Group",
      "ToolTip": "Numquam aut.",
      "Deleted": false,
      "Rank": 229,
      "Type": "placeat",
      "ColorBlock": 942,
      "IconHint": "consequuntur",
      "Selected": false,
      "LastChanged": "2019-10-30T04:02:01.2057742+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "non",
      "StyleHint": "maxime",
      "Hidden": false,
      "FullName": "Dortha Moen",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 735
        }
      }
    }
  ],
  "GroupList": [
    {
      "Id": 78,
      "Name": "Wintheiser, Muller and Pfeffer",
      "ToolTip": "Laboriosam ut.",
      "Deleted": false,
      "Rank": 73,
      "Type": "reprehenderit",
      "ColorBlock": 148,
      "IconHint": "totam",
      "Selected": true,
      "LastChanged": "2021-02-25T04:02:01.2057742+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolores",
      "StyleHint": "quos",
      "Hidden": true,
      "FullName": "Katelin Turcotte",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 831
        }
      }
    }
  ],
  "FutureDateList": [
    {
      "Id": 695,
      "Name": "Harber Group",
      "ToolTip": "Et molestias autem ut.",
      "Deleted": false,
      "Rank": 833,
      "Type": "cupiditate",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "officia",
      "ColorBlock": 795,
      "ExtraInfo": "accusantium",
      "StyleHint": "vitae",
      "FullName": "Prof. Frederik Nadia Cole II",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 368
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 102
    }
  }
}
```