---
title: PUT List/DocumentTemplate/Items/{id}/UserGroups
uid: v1DocumentTemplateList_PutDocumentTemplateEntityUserGroupsForListItem
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
| Id | Integer | The Id of the ListItem |
| Name | String | The name of the ListItem |
| ToolTip | String | The tooltip of the ListItem |
| Deleted | Boolean | The deleted status of the ListItem |
| Rank | Integer | The rank of the ListItem |
| Type | String | The type of the ListItem. Custom field. |
| ColorBlock | Integer | The color indicator of the ListItem color block |
| IconHint | String | The Icon hint of the ListItem. Custom field. |
| Selected | Boolean | True if the ListItem is selected |
| LastChanged | String | Time of last change. |
| ChildItems | Array | The child items of the SelectableMDOListItem |
| ExtraInfo | String | Extra information added to the ListItem. Could be information such as sort order etc or other meta data. Custom field. |
| StyleHint | String | Style hint indicating, information such as background color etc. Custom field. |
| Hidden | Boolean | True if the ListItem is hidden |
| FullName | String | The name of the ListItem in its context |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |

## Sample request

```http!
PUT /api/v1/List/DocumentTemplate/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 616,
    "Name": "Stark Inc and Sons",
    "ToolTip": "Possimus qui laborum et pariatur enim ipsa aliquam.",
    "Deleted": false,
    "Rank": 701,
    "Type": "suscipit",
    "ColorBlock": 240,
    "IconHint": "provident",
    "Selected": false,
    "LastChanged": "2018-12-19T14:19:11.2574687+01:00",
    "ChildItems": [
      {
        "Id": 702,
        "Name": "Ankunding Group",
        "ToolTip": "Nihil soluta numquam eveniet.",
        "Deleted": false,
        "Rank": 604,
        "Type": "perspiciatis",
        "ColorBlock": 783,
        "IconHint": "quod",
        "Selected": false,
        "LastChanged": "2017-05-18T14:19:11.2574687+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "vel",
        "StyleHint": "impedit",
        "Hidden": false,
        "FullName": "Markus Bechtelar"
      }
    ],
    "ExtraInfo": "voluptatem",
    "StyleHint": "sequi",
    "Hidden": false,
    "FullName": "Ms. Emile Kali Towne"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 986,
    "Name": "Klocko-Purdy",
    "ToolTip": "Occaecati ipsam quia est magnam eos nemo nesciunt.",
    "Deleted": false,
    "Rank": 391,
    "Type": "sapiente",
    "ColorBlock": 238,
    "IconHint": "ex",
    "Selected": false,
    "LastChanged": "1998-09-21T14:19:11.2574687+02:00",
    "ChildItems": [
      {
        "Id": 694,
        "Name": "King Inc and Sons",
        "ToolTip": "Magnam sed quisquam.",
        "Deleted": false,
        "Rank": 257,
        "Type": "excepturi",
        "ColorBlock": 175,
        "IconHint": "mollitia",
        "Selected": true,
        "LastChanged": "1998-08-29T14:19:11.2574687+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "corporis",
        "StyleHint": "consequatur",
        "Hidden": true,
        "FullName": "Dr. Aditya Runolfsdottir Jr.",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 983
          }
        }
      }
    ],
    "ExtraInfo": "provident",
    "StyleHint": "qui",
    "Hidden": false,
    "FullName": "Jermain Hamill",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 752
      }
    }
  }
]
```