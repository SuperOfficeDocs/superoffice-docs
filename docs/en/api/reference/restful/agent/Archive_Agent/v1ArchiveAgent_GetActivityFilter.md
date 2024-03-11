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
  "FromDate": "2020-10-26T14:23:45.8293368+01:00",
  "ToDate": "2023-05-09T14:23:45.8293368+02:00",
  "AssociateList": [
    {
      "Id": 530,
      "Name": "Turcotte-Ledner",
      "ToolTip": "Assumenda et fuga occaecati.",
      "Deleted": false,
      "Rank": 555,
      "Type": "ut",
      "ColorBlock": 609,
      "IconHint": "explicabo",
      "Selected": false,
      "LastChanged": "2010-07-14T14:23:45.8293368+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "porro",
      "StyleHint": "corporis",
      "Hidden": true,
      "FullName": "Tina Weissnat",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 269
        }
      }
    }
  ],
  "GroupList": [
    {
      "Id": 780,
      "Name": "Heidenreich-Pfannerstill",
      "ToolTip": "Odit deleniti rerum cum cumque.",
      "Deleted": false,
      "Rank": 987,
      "Type": "odit",
      "ColorBlock": 183,
      "IconHint": "alias",
      "Selected": true,
      "LastChanged": "2021-10-25T14:23:45.8293368+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "omnis",
      "StyleHint": "et",
      "Hidden": true,
      "FullName": "Rosario Willms",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 150
        }
      }
    }
  ],
  "FutureDateList": [
    {
      "Id": 56,
      "Name": "Beer-Parisian",
      "ToolTip": "Suscipit modi in nesciunt molestiae.",
      "Deleted": false,
      "Rank": 619,
      "Type": "delectus",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "et",
      "ColorBlock": 97,
      "ExtraInfo": "omnis",
      "StyleHint": "repellendus",
      "FullName": "Miss Diego Chase Larkin",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 553
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 335
    }
  }
}
```