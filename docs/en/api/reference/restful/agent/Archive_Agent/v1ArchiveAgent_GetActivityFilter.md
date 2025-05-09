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
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "FromDate": "2000-09-30T16:32:38.1334952+02:00",
  "ToDate": "2022-03-05T16:32:38.1334952+01:00",
  "AssociateList": [
    {
      "Id": 900,
      "Name": "Koss-Botsford",
      "ToolTip": "Occaecati repellendus nam autem at.",
      "Deleted": false,
      "Rank": 841,
      "Type": "assumenda",
      "ColorBlock": 558,
      "IconHint": "inventore",
      "Selected": false,
      "LastChanged": "2022-09-17T16:32:38.1334952+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "velit",
      "StyleHint": "perferendis",
      "Hidden": false,
      "FullName": "Miss Murl Grimes",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 736
        }
      }
    }
  ],
  "GroupList": [
    {
      "Id": 363,
      "Name": "Champlin Inc and Sons",
      "ToolTip": "Dicta officiis optio perferendis qui.",
      "Deleted": false,
      "Rank": 823,
      "Type": "iste",
      "ColorBlock": 350,
      "IconHint": "mollitia",
      "Selected": true,
      "LastChanged": "2016-08-24T16:32:38.1334952+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quia",
      "StyleHint": "totam",
      "Hidden": false,
      "FullName": "Jarod O'Kon DVM",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 429
        }
      }
    }
  ],
  "FutureDateList": [
    {
      "Id": 347,
      "Name": "Olson-Christiansen",
      "ToolTip": "Et ipsam aut minima ipsam cumque inventore.",
      "Deleted": false,
      "Rank": 473,
      "Type": "ab",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "quasi",
      "ColorBlock": 462,
      "ExtraInfo": "sequi",
      "StyleHint": "explicabo",
      "FullName": "Sallie Paucek",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 701
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 476
    }
  }
}
```