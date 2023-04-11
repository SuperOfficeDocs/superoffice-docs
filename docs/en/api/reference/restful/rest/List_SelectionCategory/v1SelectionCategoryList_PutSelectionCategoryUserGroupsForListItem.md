---
title: PUT List/SelectionCategory/Items/{id}/UserGroups
uid: v1SelectionCategoryList_PutSelectionCategoryUserGroupsForListItem
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
    "Id": 160,
    "Name": "Cummings-Beier",
    "ToolTip": "Iusto et ut eligendi qui illo ea.",
    "Deleted": false,
    "Rank": 506,
    "Type": "in",
    "ColorBlock": 630,
    "IconHint": "alias",
    "Selected": false,
    "LastChanged": "2000-05-07T15:29:31.6089735+02:00",
    "ChildItems": [
      {
        "Id": 796,
        "Name": "Wuckert-White",
        "ToolTip": "Necessitatibus deleniti est et rem a quia dolor.",
        "Deleted": false,
        "Rank": 462,
        "Type": "voluptatum",
        "ColorBlock": 302,
        "IconHint": "quae",
        "Selected": false,
        "LastChanged": "2010-05-22T15:29:31.6094739+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "nulla",
        "StyleHint": "eum",
        "Hidden": false,
        "FullName": "Mr. Dana Schimmel"
      }
    ],
    "ExtraInfo": "beatae",
    "StyleHint": "ea",
    "Hidden": true,
    "FullName": "Ari Becker IV"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 351,
    "Name": "Parisian, Ondricka and Schultz",
    "ToolTip": "Consequuntur quaerat quia.",
    "Deleted": false,
    "Rank": 29,
    "Type": "praesentium",
    "ColorBlock": 737,
    "IconHint": "aut",
    "Selected": false,
    "LastChanged": "2014-11-07T15:29:31.6109732+01:00",
    "ChildItems": [
      {
        "Id": 779,
        "Name": "Gerlach-Jewess",
        "ToolTip": "Qui temporibus in.",
        "Deleted": true,
        "Rank": 983,
        "Type": "blanditiis",
        "ColorBlock": 487,
        "IconHint": "ea",
        "Selected": false,
        "LastChanged": "2012-09-16T15:29:31.6114734+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quo",
        "StyleHint": "facilis",
        "Hidden": false,
        "FullName": "Cruz Grady",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 571
          }
        }
      }
    ],
    "ExtraInfo": "impedit",
    "StyleHint": "at",
    "Hidden": true,
    "FullName": "Miss Zaria Hayley Feeney PhD",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 643
      }
    }
  }
]
```