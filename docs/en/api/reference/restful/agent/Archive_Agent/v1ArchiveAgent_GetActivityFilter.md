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
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "FromDate": "2007-01-28T10:17:55.0977583+01:00",
  "ToDate": "2005-02-14T10:17:55.0977583+01:00",
  "AssociateList": [
    {
      "Id": 710,
      "Name": "Smitham-Volkman",
      "ToolTip": "Laboriosam ullam asperiores labore unde quasi.",
      "Deleted": false,
      "Rank": 639,
      "Type": "et",
      "ColorBlock": 997,
      "IconHint": "est",
      "Selected": false,
      "LastChanged": "2021-05-07T10:17:55.0977583+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "modi",
      "StyleHint": "et",
      "Hidden": true,
      "FullName": "Laverne Boehm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 245
        }
      }
    }
  ],
  "GroupList": [
    {
      "Id": 236,
      "Name": "D'Amore-Kautzer",
      "ToolTip": "Non eos quo nesciunt dolores harum.",
      "Deleted": false,
      "Rank": 38,
      "Type": "doloribus",
      "ColorBlock": 413,
      "IconHint": "necessitatibus",
      "Selected": true,
      "LastChanged": "2014-08-26T10:17:55.0977583+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quo",
      "StyleHint": "vel",
      "Hidden": true,
      "FullName": "Sincere Rosalyn Pollich Jr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 343
        }
      }
    }
  ],
  "FutureDateList": [
    {
      "Id": 231,
      "Name": "Hessel LLC",
      "ToolTip": "Ea voluptatem.",
      "Deleted": false,
      "Rank": 547,
      "Type": "enim",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "non",
      "ColorBlock": 174,
      "ExtraInfo": "eos",
      "StyleHint": "ea",
      "FullName": "Karlie Reilly",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 50
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 802
    }
  }
}
```