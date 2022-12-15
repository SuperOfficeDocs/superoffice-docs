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

Response body: 

| Property Name | Type |  Description |
|----------------|------|--------------|
| FromDate | date-time | The filtering From date |
| ToDate | date-time | The filtering To date |
| AssociateList | array | The list of associates to filter on |
| GroupList | array | The list of groups to filter on |
| FutureDateList | array | The list of future date selections. This is a static MDO list with standard values. |
| TableRight |  |  |
| FieldProperties | object |  |

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
  "FromDate": "2017-01-11T02:49:43.6535327+01:00",
  "ToDate": "1996-01-27T02:49:43.6535327+01:00",
  "AssociateList": [
    {
      "Id": 783,
      "Name": "Wuckert, Lockman and Howe",
      "ToolTip": "Vero aliquam mollitia doloribus error dignissimos voluptatem et.",
      "Deleted": false,
      "Rank": 228,
      "Type": "ipsam",
      "ColorBlock": 513,
      "IconHint": "vero",
      "Selected": true,
      "LastChanged": "2021-03-04T02:49:43.6535327+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "adipisci",
      "StyleHint": "sapiente",
      "Hidden": false,
      "FullName": "Austyn Bosco",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 681
        }
      }
    }
  ],
  "GroupList": [
    {
      "Id": 910,
      "Name": "Hansen-Wunsch",
      "ToolTip": "Dolorem et sed delectus eligendi.",
      "Deleted": true,
      "Rank": 197,
      "Type": "dolor",
      "ColorBlock": 652,
      "IconHint": "officiis",
      "Selected": true,
      "LastChanged": "2004-08-27T02:49:43.6535327+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolorum",
      "StyleHint": "laudantium",
      "Hidden": false,
      "FullName": "Jessyca Torp",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 858
        }
      }
    }
  ],
  "FutureDateList": [
    {
      "Id": 73,
      "Name": "Kilback, Thompson and Dickens",
      "ToolTip": "Autem beatae.",
      "Deleted": true,
      "Rank": 368,
      "Type": "repellat",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "alias",
      "ColorBlock": 706,
      "ExtraInfo": "et",
      "StyleHint": "consequatur",
      "FullName": "Mr. Erin Margot Krajcik DDS",
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
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 232
    }
  }
}
```