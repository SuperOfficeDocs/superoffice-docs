---
title: PUT List/DocumentTemplate/Items/{id}/UserGroups
id: v1DocumentTemplateList_PutDocumentTemplateEntityUserGroupsForListItem
---

# PUT List/DocumentTemplate/Items/{id}/UserGroups

```http
PUT /api/v1/List/DocumentTemplate/Items/{itemId}/UserGroups
```

Saves user groups visible for the DocumentTemplateEntity list's item.

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
PUT /api/v1/List/DocumentTemplate/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 694,
    "Name": "Purdy-Stehr",
    "ToolTip": "Fuga accusamus est.",
    "Deleted": false,
    "Rank": 27,
    "Type": "quia",
    "ColorBlock": 466,
    "IconHint": "vero",
    "Selected": true,
    "LastChanged": "2010-01-16T15:05:43.4615463+01:00",
    "ChildItems": [
      {
        "Id": 962,
        "Name": "Rogahn-Hahn",
        "ToolTip": "Sint similique quisquam atque beatae illo quo.",
        "Deleted": false,
        "Rank": 461,
        "Type": "accusantium",
        "ColorBlock": 964,
        "IconHint": "vel",
        "Selected": true,
        "LastChanged": "1997-08-23T15:05:43.4615463+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quisquam",
        "StyleHint": "repellendus",
        "Hidden": false,
        "FullName": "Jayne Ernser"
      }
    ],
    "ExtraInfo": "ipsum",
    "StyleHint": "beatae",
    "Hidden": false,
    "FullName": "Mrs. Jackeline Kuhic"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 30,
    "Name": "Borer, Kautzer and Schneider",
    "ToolTip": "Harum aliquam sint voluptas ut aliquam blanditiis.",
    "Deleted": true,
    "Rank": 852,
    "Type": "ut",
    "ColorBlock": 132,
    "IconHint": "sed",
    "Selected": true,
    "LastChanged": "2007-07-11T15:05:43.47655+02:00",
    "ChildItems": [
      {
        "Id": 672,
        "Name": "Daugherty Inc and Sons",
        "ToolTip": "Ut et.",
        "Deleted": true,
        "Rank": 669,
        "Type": "aut",
        "ColorBlock": 434,
        "IconHint": "aspernatur",
        "Selected": false,
        "LastChanged": "1994-10-04T15:05:43.4775116+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "dolorem",
        "StyleHint": "odit",
        "Hidden": true,
        "FullName": "Kacie Schmitt I",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 662
          }
        }
      }
    ],
    "ExtraInfo": "ut",
    "StyleHint": "in",
    "Hidden": false,
    "FullName": "Sydnee Fritsch",
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
        "FieldLength": 661
      }
    }
  }
]
```