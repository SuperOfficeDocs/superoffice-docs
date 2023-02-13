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
  "FromDate": "2000-05-05T11:22:37.3836264+02:00",
  "ToDate": "2001-07-17T11:22:37.3836264+02:00",
  "AssociateList": [
    {
      "Id": 511,
      "Name": "Littel Group",
      "ToolTip": "Odio minus sit architecto esse qui mollitia ad.",
      "Deleted": false,
      "Rank": 346,
      "Type": "repudiandae",
      "ColorBlock": 33,
      "IconHint": "quasi",
      "Selected": false,
      "LastChanged": "1999-10-13T11:22:37.3836264+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dicta",
      "StyleHint": "reiciendis",
      "Hidden": true,
      "FullName": "Prof. Sonny Oliver Cartwright DDS",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 320
        }
      }
    }
  ],
  "GroupList": [
    {
      "Id": 519,
      "Name": "Cassin, Bosco and Kling",
      "ToolTip": "Suscipit ipsam eos ut temporibus consequatur.",
      "Deleted": false,
      "Rank": 985,
      "Type": "magnam",
      "ColorBlock": 853,
      "IconHint": "libero",
      "Selected": false,
      "LastChanged": "1997-06-08T11:22:37.3836264+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolores",
      "StyleHint": "harum",
      "Hidden": false,
      "FullName": "Pascale VonRueden",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 305
        }
      }
    }
  ],
  "FutureDateList": [
    {
      "Id": 366,
      "Name": "Wiza-Greenfelder",
      "ToolTip": "Suscipit consequuntur.",
      "Deleted": true,
      "Rank": 705,
      "Type": "illo",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "dolorem",
      "ColorBlock": 217,
      "ExtraInfo": "ullam",
      "StyleHint": "mollitia",
      "FullName": "Miss Bethany Loyal Durgan",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 693
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 37
    }
  }
}
```