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
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "FromDate": "2016-12-06T16:00:40.0550846+01:00",
  "ToDate": "2015-02-18T16:00:40.0550846+01:00",
  "AssociateList": [
    {
      "Id": 104,
      "Name": "Keebler Inc and Sons",
      "ToolTip": "Adipisci culpa omnis in sunt.",
      "Deleted": false,
      "Rank": 89,
      "Type": "iste",
      "ColorBlock": 776,
      "IconHint": "rerum",
      "Selected": false,
      "LastChanged": "1998-07-11T16:00:40.0550846+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "numquam",
      "StyleHint": "porro",
      "Hidden": false,
      "FullName": "Mrs. Nelson Amie Stoltenberg MD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 162
        }
      }
    }
  ],
  "GroupList": [
    {
      "Id": 247,
      "Name": "Bernhard, Mosciski and Carroll",
      "ToolTip": "Placeat commodi consequatur minus veniam.",
      "Deleted": false,
      "Rank": 815,
      "Type": "tenetur",
      "ColorBlock": 368,
      "IconHint": "ullam",
      "Selected": true,
      "LastChanged": "2014-08-08T16:00:40.0550846+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aperiam",
      "StyleHint": "et",
      "Hidden": true,
      "FullName": "Lori Sipes",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 630
        }
      }
    }
  ],
  "FutureDateList": [
    {
      "Id": 454,
      "Name": "Windler-Batz",
      "ToolTip": "Voluptates atque autem optio.",
      "Deleted": true,
      "Rank": 829,
      "Type": "temporibus",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "magni",
      "ColorBlock": 986,
      "ExtraInfo": "quam",
      "StyleHint": "sit",
      "FullName": "Marguerite Abbott",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 301
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 643
    }
  }
}
```