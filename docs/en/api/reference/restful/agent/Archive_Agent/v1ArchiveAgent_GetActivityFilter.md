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
  "FromDate": "2013-05-13T02:38:20.8545926+02:00",
  "ToDate": "2003-10-01T02:38:20.8545926+02:00",
  "AssociateList": [
    {
      "Id": 339,
      "Name": "Krajcik Inc and Sons",
      "ToolTip": "Libero placeat et et cupiditate molestiae enim a.",
      "Deleted": false,
      "Rank": 841,
      "Type": "delectus",
      "ColorBlock": 904,
      "IconHint": "corporis",
      "Selected": true,
      "LastChanged": "2005-07-06T02:38:20.8545926+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptatem",
      "StyleHint": "blanditiis",
      "Hidden": false,
      "FullName": "Wava Diego Effertz IV",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 499
        }
      }
    }
  ],
  "GroupList": [
    {
      "Id": 900,
      "Name": "Bergstrom Group",
      "ToolTip": "Et id ullam quis qui ipsum aut.",
      "Deleted": true,
      "Rank": 76,
      "Type": "vitae",
      "ColorBlock": 128,
      "IconHint": "voluptates",
      "Selected": true,
      "LastChanged": "2009-08-06T02:38:20.8545926+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "debitis",
      "StyleHint": "ducimus",
      "Hidden": true,
      "FullName": "Mrs. Beryl Morissette",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 193
        }
      }
    }
  ],
  "FutureDateList": [
    {
      "Id": 720,
      "Name": "Dare, Towne and Lubowitz",
      "ToolTip": "Tempore sed numquam neque et.",
      "Deleted": false,
      "Rank": 222,
      "Type": "officiis",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "perferendis",
      "ColorBlock": 615,
      "ExtraInfo": "voluptatem",
      "StyleHint": "ipsam",
      "FullName": "Wilhelm Kertzmann",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 103
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 343
    }
  }
}
```