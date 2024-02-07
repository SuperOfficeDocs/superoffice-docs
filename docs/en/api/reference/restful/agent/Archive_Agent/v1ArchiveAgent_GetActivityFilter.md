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
  "FromDate": "2001-06-07T16:54:54.5547041+02:00",
  "ToDate": "2016-01-16T16:54:54.5547041+01:00",
  "AssociateList": [
    {
      "Id": 142,
      "Name": "O'Kon-Gaylord",
      "ToolTip": "At aut veritatis optio magnam qui.",
      "Deleted": false,
      "Rank": 147,
      "Type": "voluptatem",
      "ColorBlock": 800,
      "IconHint": "quibusdam",
      "Selected": true,
      "LastChanged": "2000-08-03T16:54:54.5547041+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "similique",
      "Hidden": true,
      "FullName": "Dillon Spencer MD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 853
        }
      }
    }
  ],
  "GroupList": [
    {
      "Id": 723,
      "Name": "Collins-Toy",
      "ToolTip": "Earum molestiae.",
      "Deleted": false,
      "Rank": 967,
      "Type": "fugiat",
      "ColorBlock": 413,
      "IconHint": "facilis",
      "Selected": true,
      "LastChanged": "2022-04-16T16:54:54.5547041+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "at",
      "StyleHint": "doloribus",
      "Hidden": false,
      "FullName": "Trycia Kerluke",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 664
        }
      }
    }
  ],
  "FutureDateList": [
    {
      "Id": 302,
      "Name": "Effertz-Denesik",
      "ToolTip": "Itaque omnis quam vel.",
      "Deleted": false,
      "Rank": 945,
      "Type": "consequatur",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "voluptatibus",
      "ColorBlock": 12,
      "ExtraInfo": "eos",
      "StyleHint": "facilis",
      "FullName": "Prof. Bonnie Reichert MD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 616
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 828
    }
  }
}
```