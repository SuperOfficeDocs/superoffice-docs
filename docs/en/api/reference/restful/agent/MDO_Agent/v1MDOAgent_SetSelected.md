---
title: POST Agents/MDO/SetSelected
uid: v1MDOAgent_SetSelected
---

# POST Agents/MDO/SetSelected

```http
POST /api/v1/Agents/MDO/SetSelected
```

Saves the selected values as selected by their given list representation.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/MDO/SetSelected?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request 

Name, AdditionalInfo, SelectableMDOList 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Name | String |  |
| AdditionalInfo | String |  |
| SelectableMDOList | Array |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/MDO/SetSelected
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Name": "Deckow, McCullough and Hahn",
  "AdditionalInfo": "recusandae",
  "SelectableMDOList": [
    {
      "Id": 998,
      "Name": "Reinger, Wolff and Mohr",
      "ToolTip": "Iusto unde officiis velit corporis quidem.",
      "Deleted": false,
      "Rank": 139,
      "Type": "quidem",
      "ColorBlock": 19,
      "IconHint": "enim",
      "Selected": false,
      "LastChanged": "2021-11-13T15:29:22.1543035+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ipsa",
      "StyleHint": "ullam",
      "Hidden": false,
      "FullName": "Jerrell Graham"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 362,
    "Name": "Wintheiser, Hintz and Jewess",
    "ToolTip": "Sit culpa architecto.",
    "Deleted": false,
    "Rank": 17,
    "Type": "quia",
    "ColorBlock": 10,
    "IconHint": "amet",
    "Selected": true,
    "LastChanged": "1997-02-13T15:29:22.1553036+01:00",
    "ChildItems": [
      {
        "Id": 347,
        "Name": "Williamson, Moen and Cartwright",
        "ToolTip": "Alias sed consequuntur sequi.",
        "Deleted": true,
        "Rank": 271,
        "Type": "at",
        "ColorBlock": 953,
        "IconHint": "exercitationem",
        "Selected": true,
        "LastChanged": "2018-04-29T15:29:22.1553036+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "voluptatem",
        "StyleHint": "saepe",
        "Hidden": false,
        "FullName": "Isaac Jakubowski",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 510
          }
        }
      }
    ],
    "ExtraInfo": "et",
    "StyleHint": "dolore",
    "Hidden": false,
    "FullName": "Wallace Grimes",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 457
      }
    }
  }
]
```