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
  "FromDate": "2015-09-12T14:13:39.3286178+02:00",
  "ToDate": "2016-08-27T14:13:39.3286178+02:00",
  "AssociateList": [
    {
      "Id": 672,
      "Name": "Trantow LLC",
      "ToolTip": "Quos sed quia voluptates.",
      "Deleted": false,
      "Rank": 516,
      "Type": "ea",
      "ColorBlock": 195,
      "IconHint": "dolorum",
      "Selected": false,
      "LastChanged": "2013-08-30T14:13:39.3286178+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "modi",
      "StyleHint": "tempore",
      "Hidden": true,
      "FullName": "Ola Robel I",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 400
        }
      }
    }
  ],
  "GroupList": [
    {
      "Id": 114,
      "Name": "Kunde, Predovic and Waelchi",
      "ToolTip": "Nihil accusamus et ad nisi ipsum.",
      "Deleted": false,
      "Rank": 920,
      "Type": "dolore",
      "ColorBlock": 804,
      "IconHint": "qui",
      "Selected": true,
      "LastChanged": "2013-02-21T14:13:39.3286178+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nobis",
      "StyleHint": "eum",
      "Hidden": false,
      "FullName": "Prof. Jarrod Volkman",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 329
        }
      }
    }
  ],
  "FutureDateList": [
    {
      "Id": 61,
      "Name": "Heidenreich, Mills and Wunsch",
      "ToolTip": "Amet eius repellat quo praesentium eos neque.",
      "Deleted": false,
      "Rank": 734,
      "Type": "voluptatem",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "ea",
      "ColorBlock": 404,
      "ExtraInfo": "dolores",
      "StyleHint": "laudantium",
      "FullName": "Diana Friesen",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
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
      "FieldLength": 666
    }
  }
}
```