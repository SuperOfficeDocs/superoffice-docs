---
title: POST Agents/MDO/GetList
uid: v1MDOAgent_GetList
---

# POST Agents/MDO/GetList

```http
POST /api/v1/Agents/MDO/GetList
```

Method to get a MDO list.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/MDO/GetList?$select=name,department,category/id
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

Name, ForceFlatList, AdditionalInfo, OnlyHistory 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Name | string |  |
| ForceFlatList | bool |  |
| AdditionalInfo | string |  |
| OnlyHistory | bool |  |


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
| ChildItems | array | The child items of the MDOListItem |
| IconHint | string | The Icon hint of the ListItem. Custom field. |
| ColorBlock | int32 | The color indicator of the ListItem color block |
| ExtraInfo | string | Extra information added to the ListItem. Could be information such as sort order etc or other meta data. Custom field. |
| StyleHint | string | Style hint indicating, information such as background color etc. Custom field. |
| FullName | string | The name of the ListItem in its context |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/MDO/GetList
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "Name": "Cartwright Group",
  "ForceFlatList": false,
  "AdditionalInfo": "non",
  "OnlyHistory": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 472,
    "Name": "Turner Inc and Sons",
    "ToolTip": "Et voluptatem nihil nulla impedit porro.",
    "Deleted": false,
    "Rank": 14,
    "Type": "nihil",
    "ChildItems": [
      {
        "Id": 537,
        "Name": "Beier-Ondricka",
        "ToolTip": "Perferendis sit sit.",
        "Deleted": false,
        "Rank": 642,
        "Type": "nesciunt",
        "ChildItems": [
          {},
          {}
        ],
        "IconHint": "quaerat",
        "ColorBlock": 342,
        "ExtraInfo": "voluptatum",
        "StyleHint": "rerum",
        "FullName": "Karlie Sanford",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 678
          }
        }
      }
    ],
    "IconHint": "quia",
    "ColorBlock": 349,
    "ExtraInfo": "ex",
    "StyleHint": "reiciendis",
    "FullName": "Joana Robel V",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 867
      }
    }
  }
]
```