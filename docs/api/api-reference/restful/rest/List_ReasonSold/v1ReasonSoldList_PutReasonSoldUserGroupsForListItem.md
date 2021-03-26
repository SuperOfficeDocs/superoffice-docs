---
title: PUT List/ReasonSold/Items/{id}/UserGroups
id: v1ReasonSoldList_PutReasonSoldUserGroupsForListItem
---

# PUT List/ReasonSold/Items/{id}/UserGroups

```http
PUT /api/v1/List/ReasonSold/Items/{itemId}/UserGroups
```

Saves user groups visible for the ReasonSold list's item.

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
PUT /api/v1/List/ReasonSold/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 280,
    "Name": "Huels-Brekke",
    "ToolTip": "Velit ut.",
    "Deleted": false,
    "Rank": 172,
    "Type": "magnam",
    "ColorBlock": 658,
    "IconHint": "unde",
    "Selected": false,
    "LastChanged": "2002-09-17T09:41:00.6993884+02:00",
    "ChildItems": [
      {
        "Id": 692,
        "Name": "Pfeffer-Fisher",
        "ToolTip": "Ea labore maiores eos.",
        "Deleted": false,
        "Rank": 879,
        "Type": "eligendi",
        "ColorBlock": 831,
        "IconHint": "eveniet",
        "Selected": false,
        "LastChanged": "2011-08-30T09:41:00.6993884+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "rerum",
        "StyleHint": "quia",
        "Hidden": true,
        "FullName": "Raina Tromp"
      }
    ],
    "ExtraInfo": "nemo",
    "StyleHint": "eligendi",
    "Hidden": true,
    "FullName": "Billie Kovacek"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 44,
    "Name": "Jakubowski LLC",
    "ToolTip": "Iusto quia nihil a minus aut.",
    "Deleted": true,
    "Rank": 524,
    "Type": "eos",
    "ColorBlock": 886,
    "IconHint": "consequuntur",
    "Selected": false,
    "LastChanged": "2007-07-25T09:41:00.7013889+02:00",
    "ChildItems": [
      {
        "Id": 540,
        "Name": "Tremblay, Kshlerin and Klocko",
        "ToolTip": "Totam molestias perspiciatis suscipit eligendi ad porro.",
        "Deleted": false,
        "Rank": 905,
        "Type": "qui",
        "ColorBlock": 417,
        "IconHint": "non",
        "Selected": false,
        "LastChanged": "1995-10-19T09:41:00.7013889+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "voluptate",
        "StyleHint": "est",
        "Hidden": true,
        "FullName": "Orpha Walsh",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": "engineer virtual relationships"
            },
            "FieldType": "System.Int32",
            "FieldLength": 390
          }
        }
      }
    ],
    "ExtraInfo": "quia",
    "StyleHint": "ut",
    "Hidden": false,
    "FullName": "Linnea Batz PhD",
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
        "FieldLength": 88
      }
    }
  }
]
```