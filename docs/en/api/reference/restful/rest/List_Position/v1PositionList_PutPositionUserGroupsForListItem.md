---
title: PUT List/Position/Items/{id}/UserGroups
uid: v1PositionList_PutPositionUserGroupsForListItem
---

# PUT List/Position/Items/{id}/UserGroups

```http
PUT /api/v1/List/Position/Items/{itemId}/UserGroups
```

Saves user groups visible for the Position list's item.


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
PUT /api/v1/List/Position/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 522,
    "Name": "Welch-Littel",
    "ToolTip": "Inventore quia exercitationem dolores aut.",
    "Deleted": true,
    "Rank": 35,
    "Type": "fuga",
    "ColorBlock": 931,
    "IconHint": "tempore",
    "Selected": true,
    "LastChanged": "2006-08-09T17:37:40.1075019+02:00",
    "ChildItems": [
      {
        "Id": 186,
        "Name": "Fisher, Jones and Koch",
        "ToolTip": "Est dicta ut occaecati aut a quia.",
        "Deleted": false,
        "Rank": 696,
        "Type": "laudantium",
        "ColorBlock": 680,
        "IconHint": "voluptatem",
        "Selected": false,
        "LastChanged": "2020-06-12T17:37:40.1075019+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "doloribus",
        "StyleHint": "id",
        "Hidden": false,
        "FullName": "Syble Grimes"
      }
    ],
    "ExtraInfo": "porro",
    "StyleHint": "autem",
    "Hidden": false,
    "FullName": "Anderson Schuppe Jr."
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 80,
    "Name": "Crooks-Brown",
    "ToolTip": "A eos.",
    "Deleted": true,
    "Rank": 487,
    "Type": "eum",
    "ColorBlock": 226,
    "IconHint": "ex",
    "Selected": true,
    "LastChanged": "1998-11-14T17:37:40.1095032+01:00",
    "ChildItems": [
      {
        "Id": 551,
        "Name": "Schaden-Kris",
        "ToolTip": "Fugit architecto est nulla nesciunt est quaerat aliquid.",
        "Deleted": true,
        "Rank": 180,
        "Type": "beatae",
        "ColorBlock": 894,
        "IconHint": "libero",
        "Selected": false,
        "LastChanged": "2009-06-26T17:37:40.1095032+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "pariatur",
        "StyleHint": "similique",
        "Hidden": false,
        "FullName": "Olaf Jewess",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 865
          }
        }
      }
    ],
    "ExtraInfo": "et",
    "StyleHint": "illo",
    "Hidden": false,
    "FullName": "Miss Bobbie Gertrude Steuber V",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 466
      }
    }
  }
]
```