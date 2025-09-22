---
title: PUT List/ReasonStalled/Items/{id}/UserGroups
uid: v1ReasonStalledList_PutReasonStalledUserGroupsForListItem
generated: true
content_type: reference
---

# PUT List/ReasonStalled/Items/{id}/UserGroups

```http
PUT /api/v1/List/ReasonStalled/Items/{itemId}/UserGroups
```

Saves user groups visible for the ReasonStalled list's item.


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
PUT /api/v1/List/ReasonStalled/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 14,
    "Name": "Littel-Weimann",
    "ToolTip": "Adipisci et.",
    "Deleted": true,
    "Rank": 553,
    "Type": "sed",
    "ColorBlock": 998,
    "IconHint": "quaerat",
    "Selected": true,
    "LastChanged": "2022-11-14T11:24:54.1249113+01:00",
    "ChildItems": [
      {
        "Id": 999,
        "Name": "O'Reilly LLC",
        "ToolTip": "Et aut est similique est ratione.",
        "Deleted": true,
        "Rank": 702,
        "Type": "et",
        "ColorBlock": 404,
        "IconHint": "in",
        "Selected": true,
        "LastChanged": "2018-04-13T11:24:54.1249113+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "dolores",
        "StyleHint": "tempora",
        "Hidden": false,
        "FullName": "Prof. Donnie Louie Hayes"
      }
    ],
    "ExtraInfo": "atque",
    "StyleHint": "velit",
    "Hidden": false,
    "FullName": "Rex Homenick"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 345,
    "Name": "Nienow-Friesen",
    "ToolTip": "Quaerat maxime facilis ipsam et maiores fuga.",
    "Deleted": false,
    "Rank": 792,
    "Type": "doloribus",
    "ColorBlock": 975,
    "IconHint": "ratione",
    "Selected": true,
    "LastChanged": "2003-03-20T11:24:54.1249113+01:00",
    "ChildItems": [
      {
        "Id": 259,
        "Name": "Rosenbaum, Emmerich and Gusikowski",
        "ToolTip": "Minima eum fuga maxime ipsum ex voluptate nihil.",
        "Deleted": false,
        "Rank": 581,
        "Type": "velit",
        "ColorBlock": 458,
        "IconHint": "tempora",
        "Selected": true,
        "LastChanged": "2010-09-11T11:24:54.1249113+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "minima",
        "StyleHint": "consequatur",
        "Hidden": false,
        "FullName": "Billy Jude Hahn MD",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 882
          }
        }
      }
    ],
    "ExtraInfo": "doloremque",
    "StyleHint": "totam",
    "Hidden": false,
    "FullName": "Jeffry Runolfsson",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 907
      }
    }
  }
]
```