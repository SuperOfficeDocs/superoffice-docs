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
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "FromDate": "2012-09-14T14:19:02.7125533+02:00",
  "ToDate": "2005-09-10T14:19:02.7125533+02:00",
  "AssociateList": [
    {
      "Id": 872,
      "Name": "Walker LLC",
      "ToolTip": "Id fugit sed deleniti omnis.",
      "Deleted": true,
      "Rank": 585,
      "Type": "occaecati",
      "ColorBlock": 849,
      "IconHint": "quia",
      "Selected": false,
      "LastChanged": "2006-07-27T14:19:02.7125533+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "praesentium",
      "StyleHint": "quam",
      "Hidden": false,
      "FullName": "Ms. Emmalee Erica Graham IV",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 270
        }
      }
    }
  ],
  "GroupList": [
    {
      "Id": 256,
      "Name": "Gibson, Schuppe and Reichert",
      "ToolTip": "Dolorem inventore nesciunt nobis laboriosam rerum.",
      "Deleted": false,
      "Rank": 610,
      "Type": "illo",
      "ColorBlock": 922,
      "IconHint": "ullam",
      "Selected": true,
      "LastChanged": "2002-12-06T14:19:02.7125533+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nemo",
      "StyleHint": "porro",
      "Hidden": true,
      "FullName": "Branson Wintheiser",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 441
        }
      }
    }
  ],
  "FutureDateList": [
    {
      "Id": 464,
      "Name": "Larson, O'Hara and Bernier",
      "ToolTip": "Odit ipsum.",
      "Deleted": false,
      "Rank": 97,
      "Type": "molestiae",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "dolores",
      "ColorBlock": 589,
      "ExtraInfo": "tenetur",
      "StyleHint": "quidem",
      "FullName": "River Collier",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 391
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 481
    }
  }
}
```