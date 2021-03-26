---
title: PUT List/MrMrs/Items/{id}/UserGroups
id: v1MrMrsList_PutMrMrsUserGroupsForListItem
---

# PUT List/MrMrs/Items/{id}/UserGroups

```http
PUT /api/v1/List/MrMrs/Items/{itemId}/UserGroups
```

Saves user groups visible for the MrMrs list's item.

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
PUT /api/v1/List/MrMrs/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 752,
    "Name": "Medhurst LLC",
    "ToolTip": "Voluptatem voluptatem maxime ea.",
    "Deleted": true,
    "Rank": 725,
    "Type": "eum",
    "ColorBlock": 869,
    "IconHint": "quia",
    "Selected": false,
    "LastChanged": "2019-02-19T09:41:00.4623786+01:00",
    "ChildItems": [
      {
        "Id": 790,
        "Name": "Kihn-Berge",
        "ToolTip": "Asperiores saepe aliquam eum aspernatur impedit atque.",
        "Deleted": true,
        "Rank": 612,
        "Type": "incidunt",
        "ColorBlock": 959,
        "IconHint": "sit",
        "Selected": false,
        "LastChanged": "2020-02-08T09:41:00.4623786+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "consequatur",
        "StyleHint": "similique",
        "Hidden": true,
        "FullName": "Cleve Volkman"
      }
    ],
    "ExtraInfo": "fugiat",
    "StyleHint": "aut",
    "Hidden": true,
    "FullName": "Grant Jenkins"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 889,
    "Name": "Boyer-Kihn",
    "ToolTip": "Est quibusdam incidunt sit qui.",
    "Deleted": false,
    "Rank": 278,
    "Type": "sed",
    "ColorBlock": 407,
    "IconHint": "accusamus",
    "Selected": false,
    "LastChanged": "2007-08-09T09:41:00.464377+02:00",
    "ChildItems": [
      {
        "Id": 74,
        "Name": "Von, Koelpin and Daugherty",
        "ToolTip": "Provident ut sit eveniet voluptas.",
        "Deleted": false,
        "Rank": 432,
        "Type": "in",
        "ColorBlock": 257,
        "IconHint": "enim",
        "Selected": true,
        "LastChanged": "1999-12-27T09:41:00.464377+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "in",
        "StyleHint": "ipsum",
        "Hidden": true,
        "FullName": "Otilia Stiedemann MD",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 761
          }
        }
      }
    ],
    "ExtraInfo": "similique",
    "StyleHint": "ut",
    "Hidden": true,
    "FullName": "Queen Casper",
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
        "FieldLength": 147
      }
    }
  }
]
```