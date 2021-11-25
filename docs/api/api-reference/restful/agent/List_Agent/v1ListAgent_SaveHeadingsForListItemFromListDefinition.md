---
title: POST Agents/List/SaveHeadingsForListItemFromListDefinition
id: v1ListAgent_SaveHeadingsForListItemFromListDefinition
---

# POST Agents/List/SaveHeadingsForListItemFromListDefinition

```http
POST /api/v1/Agents/List/SaveHeadingsForListItemFromListDefinition
```

Saves the active headings for the list item.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/List/SaveHeadingsForListItemFromListDefinition?$select=name,department,category/id
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

UdListDefinitionId, ListItemId, Headings 

| Property Name | Type |  Description |
|----------------|------|--------------|
| UdListDefinitionId | int32 |  |
| ListItemId | int32 |  |
| Headings | array |  |


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
POST /api/v1/Agents/List/SaveHeadingsForListItemFromListDefinition
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "UdListDefinitionId": 398,
  "ListItemId": 75,
  "Headings": [
    {
      "Id": 934,
      "Name": "Ziemann, Wyman and Johnson",
      "ToolTip": "Aut dolor officia.",
      "Deleted": false,
      "Rank": 49,
      "Type": "similique",
      "ColorBlock": 14,
      "IconHint": "voluptates",
      "Selected": true,
      "LastChanged": "2008-07-12T18:28:49.3211192+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "suscipit",
      "StyleHint": "dolorem",
      "Hidden": false,
      "FullName": "Hilario Corkery"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 243,
    "Name": "O'Keefe, Fisher and Dach",
    "ToolTip": "Labore quae aperiam id architecto.",
    "Deleted": false,
    "Rank": 378,
    "Type": "aut",
    "ColorBlock": 430,
    "IconHint": "voluptates",
    "Selected": false,
    "LastChanged": "2011-04-16T18:28:49.3231181+02:00",
    "ChildItems": [
      {
        "Id": 675,
        "Name": "Olson-Emard",
        "ToolTip": "Eveniet aliquid saepe et.",
        "Deleted": false,
        "Rank": 900,
        "Type": "rerum",
        "ColorBlock": 618,
        "IconHint": "pariatur",
        "Selected": false,
        "LastChanged": "2015-09-27T18:28:49.3231181+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "architecto",
        "StyleHint": "dignissimos",
        "Hidden": true,
        "FullName": "Elvera Eichmann",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": "architect extensible partnerships"
            },
            "FieldType": "System.String",
            "FieldLength": 183
          }
        }
      }
    ],
    "ExtraInfo": "necessitatibus",
    "StyleHint": "voluptatem",
    "Hidden": true,
    "FullName": "Donato D'Amore",
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
        "FieldLength": 348
      }
    }
  }
]
```