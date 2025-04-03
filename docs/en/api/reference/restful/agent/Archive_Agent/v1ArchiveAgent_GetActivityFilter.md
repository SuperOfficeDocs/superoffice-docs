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
  "FromDate": "2000-09-16T14:28:21.4616659+02:00",
  "ToDate": "2022-07-04T14:28:21.4616659+02:00",
  "AssociateList": [
    {
      "Id": 104,
      "Name": "McClure-Kassulke",
      "ToolTip": "Quas amet molestias ducimus repellat molestias repellat magni.",
      "Deleted": false,
      "Rank": 833,
      "Type": "debitis",
      "ColorBlock": 884,
      "IconHint": "et",
      "Selected": false,
      "LastChanged": "2021-06-07T14:28:21.4616659+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quas",
      "StyleHint": "qui",
      "Hidden": false,
      "FullName": "General Hahn",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 588
        }
      }
    }
  ],
  "GroupList": [
    {
      "Id": 889,
      "Name": "Rath Inc and Sons",
      "ToolTip": "Rem ut quisquam non aliquid repellat architecto fuga.",
      "Deleted": true,
      "Rank": 477,
      "Type": "et",
      "ColorBlock": 197,
      "IconHint": "consequuntur",
      "Selected": true,
      "LastChanged": "2016-06-01T14:28:21.4616659+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "est",
      "StyleHint": "et",
      "Hidden": false,
      "FullName": "Lucinda Wintheiser",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 10
        }
      }
    }
  ],
  "FutureDateList": [
    {
      "Id": 676,
      "Name": "Hartmann, Waelchi and Maggio",
      "ToolTip": "Voluptas voluptas repudiandae sint odit et.",
      "Deleted": false,
      "Rank": 454,
      "Type": "et",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "modi",
      "ColorBlock": 280,
      "ExtraInfo": "iure",
      "StyleHint": "eius",
      "FullName": "Eleanore Dessie Boehm DDS",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 617
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 846
    }
  }
}
```