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
  "FromDate": "2017-08-29T13:28:21.7887743+02:00",
  "ToDate": "2020-05-28T13:28:21.7887743+02:00",
  "AssociateList": [
    {
      "Id": 447,
      "Name": "Paucek-West",
      "ToolTip": "Voluptas maxime cum dignissimos sed quia veritatis explicabo.",
      "Deleted": true,
      "Rank": 343,
      "Type": "tempora",
      "ColorBlock": 451,
      "IconHint": "repellat",
      "Selected": false,
      "LastChanged": "1997-06-13T13:28:21.7887743+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "odit",
      "StyleHint": "illum",
      "Hidden": false,
      "FullName": "Maude Murray",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 521
        }
      }
    }
  ],
  "GroupList": [
    {
      "Id": 855,
      "Name": "Rice-Nicolas",
      "ToolTip": "Quis molestias fuga perspiciatis.",
      "Deleted": false,
      "Rank": 832,
      "Type": "rem",
      "ColorBlock": 393,
      "IconHint": "facere",
      "Selected": false,
      "LastChanged": "2010-10-12T13:28:21.7887743+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aliquam",
      "StyleHint": "sequi",
      "Hidden": false,
      "FullName": "Telly Moen",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 3
        }
      }
    }
  ],
  "FutureDateList": [
    {
      "Id": 359,
      "Name": "Roberts-Hettinger",
      "ToolTip": "Quia aut quam doloribus earum sint laboriosam eveniet.",
      "Deleted": false,
      "Rank": 980,
      "Type": "tempore",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "eaque",
      "ColorBlock": 550,
      "ExtraInfo": "dolores",
      "StyleHint": "ex",
      "FullName": "Mr. Carmela Hagenes I",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 911
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 807
    }
  }
}
```