---
title: POST Agents/List/SetVisibleForUserGroups
id: v1ListAgent_SetVisibleForUserGroups
---

# POST Agents/List/SetVisibleForUserGroups

```http
POST /api/v1/Agents/List/SetVisibleForUserGroups
```

Update User groups that this list item is visible for







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/List/SetVisibleForUserGroups?$select=name,department,category/id
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

UdListDefinitionId, ListItemId, UserGroups 

| Property Name | Type |  Description |
|----------------|------|--------------|
| UdListDefinitionId | int32 |  |
| ListItemId | int32 |  |
| UserGroups | array |  |


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
POST /api/v1/Agents/List/SetVisibleForUserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "UdListDefinitionId": 913,
  "ListItemId": 146,
  "UserGroups": [
    {
      "Id": 597,
      "Name": "Renner-Price",
      "ToolTip": "Accusamus nemo eos qui nemo sit alias.",
      "Deleted": true,
      "Rank": 207,
      "Type": "aut",
      "ColorBlock": 240,
      "IconHint": "dicta",
      "Selected": true,
      "LastChanged": "2011-10-16T18:28:49.3081177+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolore",
      "StyleHint": "officiis",
      "Hidden": false,
      "FullName": "Adam Klein"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 132,
    "Name": "Bogan, Ortiz and Ferry",
    "ToolTip": "Sed quo quos illo nulla.",
    "Deleted": false,
    "Rank": 438,
    "Type": "hic",
    "ColorBlock": 979,
    "IconHint": "voluptas",
    "Selected": true,
    "LastChanged": "2010-11-13T18:28:49.3091178+01:00",
    "ChildItems": [
      {
        "Id": 61,
        "Name": "Champlin-Emmerich",
        "ToolTip": "Sed eos et.",
        "Deleted": true,
        "Rank": 637,
        "Type": "dolores",
        "ColorBlock": 574,
        "IconHint": "voluptatem",
        "Selected": false,
        "LastChanged": "2002-09-18T18:28:49.3101182+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quia",
        "StyleHint": "nulla",
        "Hidden": true,
        "FullName": "Ophelia Cremin",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": "envisioneer synergistic relationships"
            },
            "FieldType": "System.Int32",
            "FieldLength": 11
          }
        }
      }
    ],
    "ExtraInfo": "explicabo",
    "StyleHint": "id",
    "Hidden": false,
    "FullName": "Gage Cartwright",
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
        "FieldType": "System.Int32",
        "FieldLength": 348
      }
    }
  }
]
```