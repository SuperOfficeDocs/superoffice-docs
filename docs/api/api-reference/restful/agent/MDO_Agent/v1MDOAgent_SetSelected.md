---
title: SetSelected
id: v1MDOAgent_SetSelected
---

# SetSelected

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
| Name | string |  |
| AdditionalInfo | string |  |
| SelectableMDOList | array |  |


## Response: array



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

## Sample Request

```http!
POST /api/v1/Agents/MDO/SetSelected
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Name": "Pacocha Inc and Sons",
  "AdditionalInfo": "quia",
  "SelectableMDOList": [
    {
      "Id": 574,
      "Name": "Bashirian LLC",
      "ToolTip": "Cumque ratione sed ad alias tempora.",
      "Deleted": true,
      "Rank": 88,
      "Type": "sequi",
      "ColorBlock": 953,
      "IconHint": "quae",
      "Selected": true,
      "LastChanged": "2008-01-24T14:58:04.5694602+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "iste",
      "StyleHint": "reprehenderit",
      "Hidden": true,
      "FullName": "America Reichel II"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 781,
    "Name": "Mills LLC",
    "ToolTip": "Consequatur explicabo ratione nostrum.",
    "Deleted": false,
    "Rank": 488,
    "Type": "aut",
    "ColorBlock": 857,
    "IconHint": "nobis",
    "Selected": true,
    "LastChanged": "2003-11-29T14:58:04.5704599+01:00",
    "ChildItems": [
      {
        "Id": 616,
        "Name": "Reinger Inc and Sons",
        "ToolTip": "Accusantium et soluta.",
        "Deleted": false,
        "Rank": 116,
        "Type": "aliquam",
        "ColorBlock": 757,
        "IconHint": "ullam",
        "Selected": false,
        "LastChanged": "2001-04-01T14:58:04.5704599+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "laboriosam",
        "StyleHint": "minima",
        "Hidden": true,
        "FullName": "Thad Boyle",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 866
          }
        }
      }
    ],
    "ExtraInfo": "consequatur",
    "StyleHint": "voluptatem",
    "Hidden": false,
    "FullName": "Charles Leuschke",
    "TableRight": {
      "Mask": "Delete",
      "Reason": ""
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 866
      }
    }
  }
]
```