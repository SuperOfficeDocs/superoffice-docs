---
title: SaveHeadingsForListItemFromListDefinition
id: v1ListAgent_SaveHeadingsForListItemFromListDefinition
---

# SaveHeadingsForListItemFromListDefinition

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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "UdListDefinitionId": 296,
  "ListItemId": 44,
  "Headings": [
    {
      "Id": 642,
      "Name": "Osinski Group",
      "ToolTip": "Dolore nobis nihil repellat labore autem sunt.",
      "Deleted": true,
      "Rank": 330,
      "Type": "rerum",
      "ColorBlock": 429,
      "IconHint": "voluptate",
      "Selected": true,
      "LastChanged": "2020-11-04T14:58:04.4254659+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "esse",
      "StyleHint": "quam",
      "Hidden": false,
      "FullName": "Fritz Hahn"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 736,
    "Name": "Renner-Nicolas",
    "ToolTip": "Et incidunt fuga non.",
    "Deleted": true,
    "Rank": 73,
    "Type": "recusandae",
    "ColorBlock": 830,
    "IconHint": "qui",
    "Selected": true,
    "LastChanged": "2021-04-29T14:58:04.4264679+02:00",
    "ChildItems": [
      {
        "Id": 164,
        "Name": "Williamson-Robel",
        "ToolTip": "Sit voluptatibus reprehenderit omnis.",
        "Deleted": true,
        "Rank": 349,
        "Type": "voluptatem",
        "ColorBlock": 726,
        "IconHint": "deleniti",
        "Selected": true,
        "LastChanged": "2007-10-17T14:58:04.4264679+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "nostrum",
        "StyleHint": "enim",
        "Hidden": false,
        "FullName": "Ilene Bruen",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 136
          }
        }
      }
    ],
    "ExtraInfo": "modi",
    "StyleHint": "laboriosam",
    "Hidden": false,
    "FullName": "Mylene Ziemann",
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
        "FieldLength": 879
      }
    }
  }
]
```