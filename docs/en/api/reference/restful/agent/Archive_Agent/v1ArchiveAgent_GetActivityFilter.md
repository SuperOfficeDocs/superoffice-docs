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
  "FromDate": "1999-11-13T11:16:08.7097813+01:00",
  "ToDate": "2000-10-11T11:16:08.7097813+02:00",
  "AssociateList": [
    {
      "Id": 796,
      "Name": "Heller-Kub",
      "ToolTip": "Ex voluptates aut quas velit amet cupiditate rerum.",
      "Deleted": true,
      "Rank": 355,
      "Type": "est",
      "ColorBlock": 696,
      "IconHint": "occaecati",
      "Selected": true,
      "LastChanged": "2015-03-03T11:16:08.7097813+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ipsum",
      "StyleHint": "consequatur",
      "Hidden": false,
      "FullName": "Mary Anderson",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 786
        }
      }
    }
  ],
  "GroupList": [
    {
      "Id": 256,
      "Name": "Ledner-Williamson",
      "ToolTip": "Quam quia quia in.",
      "Deleted": false,
      "Rank": 615,
      "Type": "ea",
      "ColorBlock": 870,
      "IconHint": "sed",
      "Selected": false,
      "LastChanged": "2013-03-24T11:16:08.7097813+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "provident",
      "StyleHint": "sit",
      "Hidden": false,
      "FullName": "Ms. Vincenzo Ewald Stamm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 676
        }
      }
    }
  ],
  "FutureDateList": [
    {
      "Id": 171,
      "Name": "Krajcik Group",
      "ToolTip": "Et at numquam mollitia ea rerum dolore magnam.",
      "Deleted": true,
      "Rank": 93,
      "Type": "non",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "adipisci",
      "ColorBlock": 768,
      "ExtraInfo": "quia",
      "StyleHint": "perspiciatis",
      "FullName": "Abel D'Amore",
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
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 882
    }
  }
}
```