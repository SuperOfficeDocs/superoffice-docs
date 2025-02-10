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
  "FromDate": "2023-08-18T12:01:27.3221238+02:00",
  "ToDate": "2002-06-30T12:01:27.3221238+02:00",
  "AssociateList": [
    {
      "Id": 894,
      "Name": "Stanton, Hudson and Dietrich",
      "ToolTip": "Modi voluptates inventore neque eius consequatur quia.",
      "Deleted": false,
      "Rank": 380,
      "Type": "veniam",
      "ColorBlock": 525,
      "IconHint": "omnis",
      "Selected": true,
      "LastChanged": "2013-04-15T12:01:27.3221238+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ut",
      "StyleHint": "officia",
      "Hidden": true,
      "FullName": "Mrs. Jailyn Jacques Ziemann I",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 932
        }
      }
    }
  ],
  "GroupList": [
    {
      "Id": 68,
      "Name": "Rogahn-Borer",
      "ToolTip": "Amet est temporibus eligendi sed illo.",
      "Deleted": false,
      "Rank": 96,
      "Type": "quaerat",
      "ColorBlock": 189,
      "IconHint": "aut",
      "Selected": false,
      "LastChanged": "2005-11-07T12:01:27.3221238+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aspernatur",
      "StyleHint": "ipsum",
      "Hidden": false,
      "FullName": "Osborne Blanda",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 810
        }
      }
    }
  ],
  "FutureDateList": [
    {
      "Id": 726,
      "Name": "Lynch-Marvin",
      "ToolTip": "Sed omnis.",
      "Deleted": false,
      "Rank": 556,
      "Type": "officiis",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "voluptatum",
      "ColorBlock": 662,
      "ExtraInfo": "placeat",
      "StyleHint": "ullam",
      "FullName": "Christina Faye Torphy Sr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 805
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 24
    }
  }
}
```