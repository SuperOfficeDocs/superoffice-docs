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
| TableRight | TableRight |  |
| FieldProperties | object |  |

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
  "FromDate": "2003-06-09T12:15:18.142764+02:00",
  "ToDate": "2016-01-02T12:15:18.142764+01:00",
  "AssociateList": [
    {
      "Id": 685,
      "Name": "Monahan-Gutkowski",
      "ToolTip": "Ab laudantium quam.",
      "Deleted": false,
      "Rank": 109,
      "Type": "est",
      "ColorBlock": 499,
      "IconHint": "totam",
      "Selected": false,
      "LastChanged": "2002-06-15T12:15:18.142764+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptas",
      "StyleHint": "rem",
      "Hidden": false,
      "FullName": "Mrs. Ken Walker II",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 860
        }
      }
    }
  ],
  "GroupList": [
    {
      "Id": 984,
      "Name": "Jacobs Inc and Sons",
      "ToolTip": "Qui inventore amet aut sit.",
      "Deleted": false,
      "Rank": 843,
      "Type": "voluptatem",
      "ColorBlock": 402,
      "IconHint": "consequuntur",
      "Selected": true,
      "LastChanged": "2015-08-26T12:15:18.1437638+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "totam",
      "StyleHint": "laborum",
      "Hidden": true,
      "FullName": "Lorenza Lockman",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 248
        }
      }
    }
  ],
  "FutureDateList": [
    {
      "Id": 129,
      "Name": "Schuppe-Ondricka",
      "ToolTip": "Repellendus explicabo et consequatur unde saepe.",
      "Deleted": false,
      "Rank": 347,
      "Type": "ut",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "maxime",
      "ColorBlock": 469,
      "ExtraInfo": "delectus",
      "StyleHint": "quia",
      "FullName": "Rhett Celestine Dickinson III",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 290
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 93
    }
  }
}
```