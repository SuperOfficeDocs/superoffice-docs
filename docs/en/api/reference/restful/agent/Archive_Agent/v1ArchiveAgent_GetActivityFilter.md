---
title: POST Agents/Archive/GetActivityFilter
uid: v1ArchiveAgent_GetActivityFilter
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
  "FromDate": "2016-01-08T15:29:20.7607904+01:00",
  "ToDate": "2021-02-19T15:29:20.7607904+01:00",
  "AssociateList": [
    {
      "Id": 237,
      "Name": "DuBuque, Spencer and Thiel",
      "ToolTip": "Dolorem voluptas ratione quia officia dolore.",
      "Deleted": true,
      "Rank": 627,
      "Type": "rerum",
      "ColorBlock": 194,
      "IconHint": "ea",
      "Selected": false,
      "LastChanged": "2005-10-15T15:29:20.7607904+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptas",
      "StyleHint": "nobis",
      "Hidden": false,
      "FullName": "Hudson Schmeler",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 482
        }
      }
    }
  ],
  "GroupList": [
    {
      "Id": 588,
      "Name": "Leuschke Inc and Sons",
      "ToolTip": "Provident consectetur quam praesentium dignissimos ut et vel.",
      "Deleted": false,
      "Rank": 397,
      "Type": "ex",
      "ColorBlock": 557,
      "IconHint": "ipsam",
      "Selected": false,
      "LastChanged": "2010-06-16T15:29:20.7612893+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolore",
      "StyleHint": "et",
      "Hidden": true,
      "FullName": "Adela Carroll",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 923
        }
      }
    }
  ],
  "FutureDateList": [
    {
      "Id": 745,
      "Name": "Hegmann-Weber",
      "ToolTip": "Alias at veniam ipsa ut nam nisi.",
      "Deleted": false,
      "Rank": 516,
      "Type": "suscipit",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "et",
      "ColorBlock": 281,
      "ExtraInfo": "voluptatem",
      "StyleHint": "consectetur",
      "FullName": "Elouise Ledner V",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 521
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 328
    }
  }
}
```