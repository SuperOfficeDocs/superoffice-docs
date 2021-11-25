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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 257,
    "Name": "Abbott, Ebert and Romaguera",
    "ToolTip": "Sed nulla.",
    "Deleted": true,
    "Rank": 444,
    "Type": "molestiae",
    "ColorBlock": 183,
    "IconHint": "natus",
    "Selected": true,
    "LastChanged": "2008-04-18T18:25:51.8358999+02:00",
    "ChildItems": [
      {
        "Id": 290,
        "Name": "Bechtelar Inc and Sons",
        "ToolTip": "Eos rerum hic maxime.",
        "Deleted": false,
        "Rank": 759,
        "Type": "aspernatur",
        "ColorBlock": 89,
        "IconHint": "odio",
        "Selected": true,
        "LastChanged": "2013-08-11T18:25:51.8358999+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "suscipit",
        "StyleHint": "voluptas",
        "Hidden": true,
        "FullName": "Tom Toy"
      }
    ],
    "ExtraInfo": "sequi",
    "StyleHint": "nostrum",
    "Hidden": true,
    "FullName": "Wellington Dach"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 662,
    "Name": "Yost Inc and Sons",
    "ToolTip": "Maiores est ut rem excepturi.",
    "Deleted": false,
    "Rank": 647,
    "Type": "necessitatibus",
    "ColorBlock": 891,
    "IconHint": "necessitatibus",
    "Selected": false,
    "LastChanged": "1996-06-25T18:25:51.8385263+02:00",
    "ChildItems": [
      {
        "Id": 284,
        "Name": "Anderson, Dicki and Schuster",
        "ToolTip": "Aspernatur enim inventore.",
        "Deleted": true,
        "Rank": 929,
        "Type": "aut",
        "ColorBlock": 761,
        "IconHint": "adipisci",
        "Selected": true,
        "LastChanged": "1994-11-02T18:25:51.8385263+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "ut",
        "StyleHint": "dignissimos",
        "Hidden": false,
        "FullName": "Margarette Fahey",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 450
          }
        }
      }
    ],
    "ExtraInfo": "voluptates",
    "StyleHint": "eos",
    "Hidden": true,
    "FullName": "Miss Toby Cummerata",
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
        "FieldLength": 547
      }
    }
  }
]
```