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
  "FromDate": "2017-11-18T13:14:05.507008+01:00",
  "ToDate": "2019-12-31T13:14:05.507008+01:00",
  "AssociateList": [
    {
      "Id": 142,
      "Name": "Gutkowski Group",
      "ToolTip": "Mollitia quod placeat consequatur.",
      "Deleted": false,
      "Rank": 201,
      "Type": "est",
      "ColorBlock": 827,
      "IconHint": "dolorem",
      "Selected": false,
      "LastChanged": "2024-09-28T13:14:05.507008+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ratione",
      "StyleHint": "porro",
      "Hidden": false,
      "FullName": "Muhammad Olson",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 656
        }
      }
    }
  ],
  "GroupList": [
    {
      "Id": 453,
      "Name": "Rutherford-Gutmann",
      "ToolTip": "Consequatur dolorem dolor accusamus vel.",
      "Deleted": true,
      "Rank": 767,
      "Type": "architecto",
      "ColorBlock": 392,
      "IconHint": "incidunt",
      "Selected": false,
      "LastChanged": "2000-11-15T13:14:05.507008+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ducimus",
      "StyleHint": "ipsum",
      "Hidden": true,
      "FullName": "Janiya Witting",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 184
        }
      }
    }
  ],
  "FutureDateList": [
    {
      "Id": 678,
      "Name": "Robel-Huel",
      "ToolTip": "Atque in occaecati saepe consequatur et reiciendis veritatis.",
      "Deleted": true,
      "Rank": 507,
      "Type": "nihil",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "inventore",
      "ColorBlock": 921,
      "ExtraInfo": "consequatur",
      "StyleHint": "aut",
      "FullName": "Dr. Maxie Arden Maggio",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 231
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 182
    }
  }
}
```