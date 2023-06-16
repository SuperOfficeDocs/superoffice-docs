---
title: POST Agents/MDO/SetSelected
uid: v1MDOAgent_SetSelected
generated: true
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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Name": "Kling Group",
  "AdditionalInfo": "officia",
  "SelectableMDOList": [
    {
      "Id": 143,
      "Name": "Stiedemann, Schulist and Upton",
      "ToolTip": "Et expedita voluptatibus ipsam qui exercitationem quidem natus.",
      "Deleted": true,
      "Rank": 117,
      "Type": "necessitatibus",
      "ColorBlock": 295,
      "IconHint": "amet",
      "Selected": false,
      "LastChanged": "1997-04-13T16:00:41.2736903+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "cumque",
      "StyleHint": "temporibus",
      "Hidden": false,
      "FullName": "Mr. Devonte Edward Mayert"
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
    "Id": 130,
    "Name": "Dibbert LLC",
    "ToolTip": "Omnis aut soluta.",
    "Deleted": false,
    "Rank": 796,
    "Type": "ut",
    "ColorBlock": 551,
    "IconHint": "nobis",
    "Selected": true,
    "LastChanged": "1996-09-26T16:00:41.2736903+02:00",
    "ChildItems": [
      {
        "Id": 612,
        "Name": "Steuber Group",
        "ToolTip": "Magnam soluta.",
        "Deleted": false,
        "Rank": 977,
        "Type": "ut",
        "ColorBlock": 13,
        "IconHint": "qui",
        "Selected": false,
        "LastChanged": "2018-01-29T16:00:41.2736903+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "nobis",
        "StyleHint": "non",
        "Hidden": true,
        "FullName": "Leonor Dach",
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
    "ExtraInfo": "recusandae",
    "StyleHint": "sunt",
    "Hidden": true,
    "FullName": "Mikel Wilderman",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 273
      }
    }
  }
]
```