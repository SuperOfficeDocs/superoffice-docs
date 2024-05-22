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
  "FromDate": "2007-01-02T12:57:33.2116147+01:00",
  "ToDate": "2011-11-15T12:57:33.2116147+01:00",
  "AssociateList": [
    {
      "Id": 755,
      "Name": "Skiles, Ward and Hermiston",
      "ToolTip": "Temporibus qui nobis eligendi voluptatibus ducimus.",
      "Deleted": true,
      "Rank": 963,
      "Type": "porro",
      "ColorBlock": 663,
      "IconHint": "unde",
      "Selected": true,
      "LastChanged": "1998-06-12T12:57:33.2116147+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "laudantium",
      "StyleHint": "perferendis",
      "Hidden": false,
      "FullName": "Lorenzo Elisa Veum III",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 778
        }
      }
    }
  ],
  "GroupList": [
    {
      "Id": 102,
      "Name": "Robel, Donnelly and Ratke",
      "ToolTip": "Ut minima consequatur.",
      "Deleted": true,
      "Rank": 501,
      "Type": "earum",
      "ColorBlock": 294,
      "IconHint": "ipsam",
      "Selected": false,
      "LastChanged": "2020-03-14T12:57:33.2116147+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eos",
      "StyleHint": "exercitationem",
      "Hidden": true,
      "FullName": "Alex Ron Donnelly PhD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 360
        }
      }
    }
  ],
  "FutureDateList": [
    {
      "Id": 99,
      "Name": "Ziemann-Muller",
      "ToolTip": "Cumque ut.",
      "Deleted": false,
      "Rank": 632,
      "Type": "consectetur",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "atque",
      "ColorBlock": 600,
      "ExtraInfo": "dolorem",
      "StyleHint": "ab",
      "FullName": "Ms. Kenya Desmond Lind",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 550
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 349
    }
  }
}
```