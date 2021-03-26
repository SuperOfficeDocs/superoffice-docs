---
title: PUT List/SelectionCategory/Items/{id}/UserGroups
id: v1SelectionCategoryList_PutSelectionCategoryUserGroupsForListItem
---

# PUT List/SelectionCategory/Items/{id}/UserGroups

```http
PUT /api/v1/List/SelectionCategory/Items/{itemId}/UserGroups
```

Saves user groups visible for the SelectionCategory list's item.

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
PUT /api/v1/List/SelectionCategory/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 637,
    "Name": "Ankunding, O'Reilly and Kerluke",
    "ToolTip": "Nihil minus asperiores.",
    "Deleted": false,
    "Rank": 638,
    "Type": "pariatur",
    "ColorBlock": 39,
    "IconHint": "illo",
    "Selected": false,
    "LastChanged": "2004-01-13T09:41:00.7523876+01:00",
    "ChildItems": [
      {
        "Id": 13,
        "Name": "Jaskolski LLC",
        "ToolTip": "Ipsa sit sapiente distinctio.",
        "Deleted": false,
        "Rank": 594,
        "Type": "tempore",
        "ColorBlock": 702,
        "IconHint": "velit",
        "Selected": true,
        "LastChanged": "2017-12-31T09:41:00.7523876+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "impedit",
        "StyleHint": "sapiente",
        "Hidden": true,
        "FullName": "Cassidy McDermott DVM"
      }
    ],
    "ExtraInfo": "et",
    "StyleHint": "sed",
    "Hidden": false,
    "FullName": "Ezra Stroman"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 578,
    "Name": "Grant-Hilpert",
    "ToolTip": "Aut est in rem sint autem placeat.",
    "Deleted": true,
    "Rank": 650,
    "Type": "veritatis",
    "ColorBlock": 703,
    "IconHint": "perferendis",
    "Selected": true,
    "LastChanged": "2020-11-10T09:41:00.7533877+01:00",
    "ChildItems": [
      {
        "Id": 1001,
        "Name": "Spencer-Stark",
        "ToolTip": "Perferendis provident sed in corporis.",
        "Deleted": true,
        "Rank": 866,
        "Type": "dolorem",
        "ColorBlock": 618,
        "IconHint": "aliquam",
        "Selected": true,
        "LastChanged": "1995-05-23T09:41:00.7533877+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "similique",
        "StyleHint": "commodi",
        "Hidden": false,
        "FullName": "Judson D'Amore",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 11
          }
        }
      }
    ],
    "ExtraInfo": "sit",
    "StyleHint": "in",
    "Hidden": true,
    "FullName": "Josie Grimes",
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
        "FieldLength": 930
      }
    }
  }
]
```