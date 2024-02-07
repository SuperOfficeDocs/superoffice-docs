---
title: PUT List/SelectionCategory/Items/{id}/UserGroups
uid: v1SelectionCategoryList_PutSelectionCategoryUserGroupsForListItem
generated: true
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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
PUT /api/v1/List/SelectionCategory/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 820,
    "Name": "Stroman Group",
    "ToolTip": "Ea consequatur.",
    "Deleted": true,
    "Rank": 235,
    "Type": "unde",
    "ColorBlock": 376,
    "IconHint": "et",
    "Selected": false,
    "LastChanged": "2022-08-11T16:55:31.0863652+02:00",
    "ChildItems": [
      {
        "Id": 114,
        "Name": "Ritchie-Ortiz",
        "ToolTip": "Error quae provident.",
        "Deleted": false,
        "Rank": 548,
        "Type": "architecto",
        "ColorBlock": 330,
        "IconHint": "repudiandae",
        "Selected": false,
        "LastChanged": "2023-12-12T16:55:31.0863652+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "facilis",
        "StyleHint": "omnis",
        "Hidden": false,
        "FullName": "Novella Judge Borer Jr."
      }
    ],
    "ExtraInfo": "et",
    "StyleHint": "quis",
    "Hidden": true,
    "FullName": "Norbert Durgan"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 896,
    "Name": "Wisozk, Dare and Lang",
    "ToolTip": "Quis provident est consectetur.",
    "Deleted": true,
    "Rank": 328,
    "Type": "rem",
    "ColorBlock": 449,
    "IconHint": "aliquam",
    "Selected": true,
    "LastChanged": "2021-08-03T16:55:31.0882782+02:00",
    "ChildItems": [
      {
        "Id": 884,
        "Name": "Moore-Wolf",
        "ToolTip": "Dolores perspiciatis facere recusandae quas et.",
        "Deleted": true,
        "Rank": 733,
        "Type": "exercitationem",
        "ColorBlock": 59,
        "IconHint": "vel",
        "Selected": true,
        "LastChanged": "1998-02-11T16:55:31.0882782+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "animi",
        "StyleHint": "velit",
        "Hidden": false,
        "FullName": "Mrs. Bridie Marquise Abernathy DDS",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 636
          }
        }
      }
    ],
    "ExtraInfo": "rerum",
    "StyleHint": "porro",
    "Hidden": true,
    "FullName": "Boris Kaitlyn McLaughlin IV",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 99
      }
    }
  }
]
```