---
title: POST Agents/Archive/GetActivityFilter
uid: v1ArchiveAgent_GetActivityFilter
generated: true
content_type: reference
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
  "FromDate": "2006-04-18T03:41:53.0588794+02:00",
  "ToDate": "2017-01-10T03:41:53.0588794+01:00",
  "AssociateList": [
    {
      "Id": 100,
      "Name": "Bradtke Inc and Sons",
      "ToolTip": "Atque sed.",
      "Deleted": true,
      "Rank": 644,
      "Type": "et",
      "ColorBlock": 964,
      "IconHint": "omnis",
      "Selected": true,
      "LastChanged": "1998-08-25T03:41:53.0588794+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "omnis",
      "StyleHint": "quos",
      "Hidden": false,
      "FullName": "Ms. Odell Braulio Mohr",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 954
        }
      }
    }
  ],
  "GroupList": [
    {
      "Id": 633,
      "Name": "Kassulke, Jaskolski and Sanford",
      "ToolTip": "Velit repellat nostrum tempora recusandae aperiam et.",
      "Deleted": false,
      "Rank": 507,
      "Type": "alias",
      "ColorBlock": 166,
      "IconHint": "placeat",
      "Selected": true,
      "LastChanged": "2004-02-21T03:41:53.0588794+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sint",
      "StyleHint": "et",
      "Hidden": true,
      "FullName": "Kraig Kautzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 337
        }
      }
    }
  ],
  "FutureDateList": [
    {
      "Id": 573,
      "Name": "Marquardt, Lakin and Mills",
      "ToolTip": "Illo dolores itaque aut voluptas assumenda veritatis perspiciatis.",
      "Deleted": true,
      "Rank": 408,
      "Type": "eos",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "consequatur",
      "ColorBlock": 717,
      "ExtraInfo": "magni",
      "StyleHint": "soluta",
      "FullName": "Mustafa Towne I",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 837
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 894
    }
  }
}
```