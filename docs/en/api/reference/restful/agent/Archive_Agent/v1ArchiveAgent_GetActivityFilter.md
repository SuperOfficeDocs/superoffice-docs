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
  "FromDate": "2011-03-02T23:03:54.9586429+01:00",
  "ToDate": "2016-04-01T23:03:54.9586429+02:00",
  "AssociateList": [
    {
      "Id": 331,
      "Name": "Gibson-Ledner",
      "ToolTip": "Magnam sint mollitia velit ab.",
      "Deleted": false,
      "Rank": 863,
      "Type": "officia",
      "ColorBlock": 687,
      "IconHint": "sed",
      "Selected": false,
      "LastChanged": "2023-11-30T23:03:54.9586429+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "asperiores",
      "StyleHint": "corrupti",
      "Hidden": true,
      "FullName": "Mrs. Mariano Collins",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 618
        }
      }
    }
  ],
  "GroupList": [
    {
      "Id": 3,
      "Name": "Dicki LLC",
      "ToolTip": "Ut qui consectetur autem.",
      "Deleted": true,
      "Rank": 172,
      "Type": "ullam",
      "ColorBlock": 5,
      "IconHint": "tempore",
      "Selected": true,
      "LastChanged": "2003-04-12T23:03:54.9586429+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quia",
      "StyleHint": "eos",
      "Hidden": true,
      "FullName": "Miss Faye Schamberger",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 500
        }
      }
    }
  ],
  "FutureDateList": [
    {
      "Id": 955,
      "Name": "Roberts Group",
      "ToolTip": "Iusto voluptatum temporibus deleniti.",
      "Deleted": true,
      "Rank": 166,
      "Type": "nesciunt",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "ex",
      "ColorBlock": 521,
      "ExtraInfo": "quia",
      "StyleHint": "consequuntur",
      "FullName": "Dr. Bette Rolfson",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 793
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 51
    }
  }
}
```