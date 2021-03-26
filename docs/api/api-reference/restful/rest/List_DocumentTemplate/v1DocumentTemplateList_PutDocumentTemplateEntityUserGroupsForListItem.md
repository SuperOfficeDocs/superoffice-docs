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
    "Id": 566,
    "Name": "Howe LLC",
    "ToolTip": "Eius totam deleniti aliquid nostrum.",
    "Deleted": true,
    "Rank": 641,
    "Type": "magni",
    "ColorBlock": 514,
    "IconHint": "exercitationem",
    "Selected": true,
    "LastChanged": "2003-01-27T09:41:00.4283814+01:00",
    "ChildItems": [
      {
        "Id": 965,
        "Name": "Gibson, Hermiston and Kihn",
        "ToolTip": "Voluptatem eligendi commodi.",
        "Deleted": false,
        "Rank": 539,
        "Type": "animi",
        "ColorBlock": 284,
        "IconHint": "et",
        "Selected": false,
        "LastChanged": "2004-11-28T09:41:00.4283814+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "beatae",
        "StyleHint": "quod",
        "Hidden": true,
        "FullName": "Jairo Nicolas"
      }
    ],
    "ExtraInfo": "temporibus",
    "StyleHint": "est",
    "Hidden": false,
    "FullName": "Icie Leffler"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 449,
    "Name": "O'Keefe, Hegmann and Gulgowski",
    "ToolTip": "Rerum autem quos quisquam ullam fuga sed.",
    "Deleted": true,
    "Rank": 399,
    "Type": "culpa",
    "ColorBlock": 943,
    "IconHint": "suscipit",
    "Selected": true,
    "LastChanged": "2007-03-22T09:41:00.4293837+01:00",
    "ChildItems": [
      {
        "Id": 966,
        "Name": "Schumm Inc and Sons",
        "ToolTip": "Est commodi nam quia eveniet.",
        "Deleted": true,
        "Rank": 527,
        "Type": "rerum",
        "ColorBlock": 666,
        "IconHint": "dignissimos",
        "Selected": true,
        "LastChanged": "2004-04-28T09:41:00.4293837+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "soluta",
        "StyleHint": "laudantium",
        "Hidden": true,
        "FullName": "Abbigail Stroman",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 447
          }
        }
      }
    ],
    "ExtraInfo": "sunt",
    "StyleHint": "et",
    "Hidden": false,
    "FullName": "Abdiel Heidenreich",
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
        "FieldLength": 476
      }
    }
  }
]
```