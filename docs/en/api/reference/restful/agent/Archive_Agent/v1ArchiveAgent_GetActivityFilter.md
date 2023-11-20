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
  "FromDate": "2015-08-03T13:38:13.0615453+02:00",
  "ToDate": "2007-06-19T13:38:13.0615453+02:00",
  "AssociateList": [
    {
      "Id": 200,
      "Name": "Bogisich Group",
      "ToolTip": "Autem suscipit sequi ipsum exercitationem odio corrupti dolorem.",
      "Deleted": true,
      "Rank": 301,
      "Type": "quaerat",
      "ColorBlock": 997,
      "IconHint": "ea",
      "Selected": false,
      "LastChanged": "2003-05-15T13:38:13.0615453+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "qui",
      "StyleHint": "facere",
      "Hidden": false,
      "FullName": "Mr. Daphne Shields III",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 687
        }
      }
    }
  ],
  "GroupList": [
    {
      "Id": 757,
      "Name": "Ernser, Thiel and Gibson",
      "ToolTip": "Earum sed nobis praesentium ratione laudantium quas repellat.",
      "Deleted": false,
      "Rank": 262,
      "Type": "veniam",
      "ColorBlock": 713,
      "IconHint": "magnam",
      "Selected": false,
      "LastChanged": "2010-01-23T13:38:13.0615453+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "soluta",
      "StyleHint": "possimus",
      "Hidden": false,
      "FullName": "Miss Reuben White",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 242
        }
      }
    }
  ],
  "FutureDateList": [
    {
      "Id": 537,
      "Name": "Marquardt-Hansen",
      "ToolTip": "Optio aut.",
      "Deleted": false,
      "Rank": 482,
      "Type": "facilis",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "culpa",
      "ColorBlock": 396,
      "ExtraInfo": "odio",
      "StyleHint": "accusantium",
      "FullName": "Ms. Constantin Torp V",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 165
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 99
    }
  }
}
```