---
title: POST Agents/License/GetUserLicensesMDOList
uid: v1LicenseAgent_GetUserLicensesMDOList
---

# POST Agents/License/GetUserLicensesMDOList

```http
POST /api/v1/Agents/License/GetUserLicensesMDOList
```

Get all licenses in a MDOListItem structure.

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/License/GetUserLicensesMDOList?$select=name,department,category/id
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

## Response: array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| Id | int32 | The Id of the ListItem |
| Name | string | The name of the ListItem |
| ToolTip | string | The tooltip of the ListItem |
| Deleted | bool | The deleted status of the ListItem |
| Rank | int32 | The rank of the ListItem |
| Type | string | The type of the ListItem. Custom field. |
| ColorBlock | int32 | The color indicator of the ListItem color block |
| IconHint | string | The Icon hint of the ListItem. Custom field. |
| Selected | bool | True if the ListItem is selected |
| LastChanged | date-time | Time of last change. |
| ChildItems | array | The child items of the SelectableMDOListItem |
| ExtraInfo | string | Extra information added to the ListItem. Could be information such as sort order etc or other meta data. Custom field. |
| StyleHint | string | Style hint indicating, information such as background color etc. Custom field. |
| Hidden | bool | True if the ListItem is hidden |
| FullName | string | The name of the ListItem in its context |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/License/GetUserLicensesMDOList
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 863,
    "Name": "Becker Inc and Sons",
    "ToolTip": "Quis quia porro et ipsam.",
    "Deleted": false,
    "Rank": 219,
    "Type": "repudiandae",
    "ColorBlock": 421,
    "IconHint": "reiciendis",
    "Selected": false,
    "LastChanged": "2021-06-30T11:10:27.1114536+02:00",
    "ChildItems": [
      {
        "Id": 823,
        "Name": "Nikolaus Group",
        "ToolTip": "Dolor voluptatem sed magnam odit animi.",
        "Deleted": false,
        "Rank": 137,
        "Type": "quod",
        "ColorBlock": 838,
        "IconHint": "ullam",
        "Selected": false,
        "LastChanged": "1995-10-02T11:10:27.1114536+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "dolores",
        "StyleHint": "laudantium",
        "Hidden": false,
        "FullName": "Miss Treva Ritchie",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 521
          }
        }
      }
    ],
    "ExtraInfo": "blanditiis",
    "StyleHint": "iusto",
    "Hidden": true,
    "FullName": "Syble Prohaska",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 709
      }
    }
  }
]
```
