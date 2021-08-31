---
title: PUT List/Competitor/Items/{id}/UserGroups
id: v1CompetitorList_PutCompetitorUserGroupsForListItem
---

# PUT List/Competitor/Items/{id}/UserGroups

```http
PUT /api/v1/List/Competitor/Items/{itemId}/UserGroups
```

Saves user groups visible for the Competitor list's item.

Calls the List agent service SaveHeadingsForListItemFromListDefinition.




| Path Part | Type | Description |
|-----------|------|-------------|
| itemId | int32 | The ID of the item to save. **Required** |



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

## Request Body: entities  

The headings to be saved. 

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
PUT /api/v1/List/Competitor/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 789,
    "Name": "Beier-Padberg",
    "ToolTip": "Iure voluptatem dolore tempora ea ab.",
    "Deleted": true,
    "Rank": 515,
    "Type": "dolorum",
    "ColorBlock": 571,
    "IconHint": "voluptatem",
    "Selected": true,
    "LastChanged": "2004-04-10T15:05:43.3205459+02:00",
    "ChildItems": [
      {
        "Id": 451,
        "Name": "Mayert-Rodriguez",
        "ToolTip": "Sunt qui omnis qui voluptatem quis sequi.",
        "Deleted": false,
        "Rank": 945,
        "Type": "corrupti",
        "ColorBlock": 264,
        "IconHint": "omnis",
        "Selected": false,
        "LastChanged": "2014-03-18T15:05:43.3215135+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "aut",
        "StyleHint": "voluptates",
        "Hidden": false,
        "FullName": "Mrs. Jesse Okuneva"
      }
    ],
    "ExtraInfo": "vitae",
    "StyleHint": "est",
    "Hidden": true,
    "FullName": "Armando Haley"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 726,
    "Name": "Keebler-Harvey",
    "ToolTip": "Iste iste omnis quo qui dolor iste.",
    "Deleted": false,
    "Rank": 690,
    "Type": "numquam",
    "ColorBlock": 587,
    "IconHint": "et",
    "Selected": false,
    "LastChanged": "1994-06-28T15:05:43.3225398+02:00",
    "ChildItems": [
      {
        "Id": 481,
        "Name": "Gleichner-Heaney",
        "ToolTip": "Qui ea et.",
        "Deleted": false,
        "Rank": 197,
        "Type": "quo",
        "ColorBlock": 464,
        "IconHint": "asperiores",
        "Selected": true,
        "LastChanged": "2011-07-21T15:05:43.3225398+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "at",
        "StyleHint": "consequatur",
        "Hidden": true,
        "FullName": "Eloy Conroy",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 776
          }
        }
      }
    ],
    "ExtraInfo": "magni",
    "StyleHint": "distinctio",
    "Hidden": false,
    "FullName": "Sincere Cruickshank DVM",
    "TableRight": {
      "Mask": "Delete",
      "Reason": "orchestrate turn-key web services"
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 491
      }
    }
  }
]
```