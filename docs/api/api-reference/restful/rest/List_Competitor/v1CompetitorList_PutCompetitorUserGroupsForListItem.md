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
    "Id": 56,
    "Name": "Reilly-Cartwright",
    "ToolTip": "Et explicabo tenetur neque harum fugiat est.",
    "Deleted": true,
    "Rank": 62,
    "Type": "officia",
    "ColorBlock": 487,
    "IconHint": "quasi",
    "Selected": true,
    "LastChanged": "2002-05-06T18:25:51.6522947+02:00",
    "ChildItems": [
      {
        "Id": 2,
        "Name": "Mueller, Crist and Klein",
        "ToolTip": "Quo fugit quae suscipit.",
        "Deleted": true,
        "Rank": 322,
        "Type": "ab",
        "ColorBlock": 402,
        "IconHint": "corrupti",
        "Selected": false,
        "LastChanged": "2021-03-07T18:25:51.6522947+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "ut",
        "StyleHint": "reprehenderit",
        "Hidden": false,
        "FullName": "Sydni Fay"
      }
    ],
    "ExtraInfo": "vero",
    "StyleHint": "non",
    "Hidden": false,
    "FullName": "Lenny Becker"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 367,
    "Name": "Maggio Group",
    "ToolTip": "At beatae incidunt et.",
    "Deleted": true,
    "Rank": 384,
    "Type": "quos",
    "ColorBlock": 603,
    "IconHint": "recusandae",
    "Selected": true,
    "LastChanged": "2020-07-22T18:25:51.6532948+02:00",
    "ChildItems": [
      {
        "Id": 770,
        "Name": "Parisian-Rice",
        "ToolTip": "Similique qui adipisci corrupti.",
        "Deleted": true,
        "Rank": 472,
        "Type": "aut",
        "ColorBlock": 201,
        "IconHint": "nam",
        "Selected": false,
        "LastChanged": "2016-03-20T18:25:51.6532948+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quis",
        "StyleHint": "dolor",
        "Hidden": false,
        "FullName": "Delmer Hoppe",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 356
          }
        }
      }
    ],
    "ExtraInfo": "officia",
    "StyleHint": "sint",
    "Hidden": true,
    "FullName": "Priscilla Murphy",
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
        "FieldLength": 968
      }
    }
  }
]
```