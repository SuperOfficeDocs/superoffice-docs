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
  "FromDate": "2017-04-15T03:44:52.0427664+02:00",
  "ToDate": "2018-06-26T03:44:52.0427664+02:00",
  "AssociateList": [
    {
      "Id": 976,
      "Name": "Lebsack, Roberts and Bernhard",
      "ToolTip": "Nobis qui quo ex.",
      "Deleted": true,
      "Rank": 871,
      "Type": "sint",
      "ColorBlock": 976,
      "IconHint": "nihil",
      "Selected": false,
      "LastChanged": "2014-03-26T03:44:52.0427664+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "consequatur",
      "StyleHint": "et",
      "Hidden": true,
      "FullName": "Horacio Ernest Padberg II",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 380
        }
      }
    }
  ],
  "GroupList": [
    {
      "Id": 679,
      "Name": "Zemlak Group",
      "ToolTip": "Sit quod.",
      "Deleted": false,
      "Rank": 400,
      "Type": "voluptatibus",
      "ColorBlock": 331,
      "IconHint": "sed",
      "Selected": false,
      "LastChanged": "2006-01-07T03:44:52.0427664+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptatum",
      "StyleHint": "molestiae",
      "Hidden": false,
      "FullName": "Deven Julia Schowalter IV",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 968
        }
      }
    }
  ],
  "FutureDateList": [
    {
      "Id": 638,
      "Name": "Berge Group",
      "ToolTip": "Ducimus laborum pariatur nobis.",
      "Deleted": true,
      "Rank": 970,
      "Type": "dolor",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "occaecati",
      "ColorBlock": 284,
      "ExtraInfo": "consequatur",
      "StyleHint": "sunt",
      "FullName": "Thea Nader",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 148
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 296
    }
  }
}
```