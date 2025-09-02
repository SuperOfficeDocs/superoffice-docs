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
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "FromDate": "2024-11-23T03:46:54.2851489+01:00",
  "ToDate": "2022-10-20T03:46:54.2851489+02:00",
  "AssociateList": [
    {
      "Id": 410,
      "Name": "Donnelly-O'Hara",
      "ToolTip": "Quia ut nesciunt quo voluptatem aut.",
      "Deleted": true,
      "Rank": 717,
      "Type": "ullam",
      "ColorBlock": 422,
      "IconHint": "cupiditate",
      "Selected": true,
      "LastChanged": "2015-04-18T03:46:54.2851489+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "error",
      "StyleHint": "animi",
      "Hidden": true,
      "FullName": "Emerald Aufderhar",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 683
        }
      }
    }
  ],
  "GroupList": [
    {
      "Id": 164,
      "Name": "Stehr Group",
      "ToolTip": "Explicabo vel laboriosam et dolores.",
      "Deleted": true,
      "Rank": 133,
      "Type": "et",
      "ColorBlock": 68,
      "IconHint": "odio",
      "Selected": true,
      "LastChanged": "2009-05-23T03:46:54.2851489+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "maxime",
      "StyleHint": "rem",
      "Hidden": false,
      "FullName": "Dr. Price Padberg I",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 708
        }
      }
    }
  ],
  "FutureDateList": [
    {
      "Id": 705,
      "Name": "Harber-Trantow",
      "ToolTip": "Sed dolorem laboriosam et repellat et.",
      "Deleted": false,
      "Rank": 562,
      "Type": "qui",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "rem",
      "ColorBlock": 284,
      "ExtraInfo": "qui",
      "StyleHint": "consequatur",
      "FullName": "Michelle Sawayn",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 855
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 111
    }
  }
}
```