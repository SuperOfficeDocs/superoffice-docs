---
title: PUT List/ProjectType/Items/{id}/UserGroups
id: v1ProjectTypeList_PutProjectTypeUserGroupsForListItem
---

# PUT List/ProjectType/Items/{id}/UserGroups

```http
PUT /api/v1/List/ProjectType/Items/{itemId}/UserGroups
```

Saves user groups visible for the ProjectType list's item.

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
PUT /api/v1/List/ProjectType/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 979,
    "Name": "Labadie-Bernier",
    "ToolTip": "In velit possimus perferendis tempora.",
    "Deleted": false,
    "Rank": 766,
    "Type": "qui",
    "ColorBlock": 299,
    "IconHint": "omnis",
    "Selected": false,
    "LastChanged": "2012-11-25T09:41:00.6533821+01:00",
    "ChildItems": [
      {
        "Id": 683,
        "Name": "Pfannerstill-Johns",
        "ToolTip": "Ab occaecati eum ea perspiciatis.",
        "Deleted": false,
        "Rank": 131,
        "Type": "occaecati",
        "ColorBlock": 917,
        "IconHint": "id",
        "Selected": false,
        "LastChanged": "2013-07-13T09:41:00.6533821+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "molestias",
        "StyleHint": "quo",
        "Hidden": true,
        "FullName": "Queen Jast"
      }
    ],
    "ExtraInfo": "pariatur",
    "StyleHint": "perspiciatis",
    "Hidden": true,
    "FullName": "Leora Bashirian"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 273,
    "Name": "Runolfsdottir-Dickinson",
    "ToolTip": "Et architecto eius est.",
    "Deleted": true,
    "Rank": 288,
    "Type": "corrupti",
    "ColorBlock": 164,
    "IconHint": "voluptatum",
    "Selected": false,
    "LastChanged": "1995-01-10T09:41:00.6543817+01:00",
    "ChildItems": [
      {
        "Id": 634,
        "Name": "Schaefer-Gorczany",
        "ToolTip": "Et doloremque odit reprehenderit quisquam debitis fuga.",
        "Deleted": false,
        "Rank": 361,
        "Type": "qui",
        "ColorBlock": 309,
        "IconHint": "in",
        "Selected": true,
        "LastChanged": "2015-12-23T09:41:00.6543817+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "provident",
        "StyleHint": "earum",
        "Hidden": true,
        "FullName": "Dorothy Greenfelder",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 588
          }
        }
      }
    ],
    "ExtraInfo": "sed",
    "StyleHint": "dolor",
    "Hidden": false,
    "FullName": "Ronny Crooks",
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
        "FieldLength": 817
      }
    }
  }
]
```