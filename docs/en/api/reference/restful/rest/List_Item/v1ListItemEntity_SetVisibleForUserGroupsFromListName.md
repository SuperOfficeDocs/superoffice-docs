---
title: PUT List/{udListDefinitionName}/Items/{id}/UserGroups
uid: v1ListItemEntity_SetVisibleForUserGroupsFromListName
generated: true
---

# PUT List/{udListDefinitionName}/Items/{id}/UserGroups

```http
PUT /api/v1/List/{udListDefinitionName}/Items/{listItemId}/UserGroups
```

Update User groups that this list item is visible for






| Path Part | Type | Description |
|-----------|------|-------------|
| udListDefinitionName | string | The name of the list definition, indicating which list to update the items from. **Required** |
| listItemId | int32 | The id of the list item **Required** |



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

## Request Body: userGroups 

The selectable user groups. 

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
PUT /api/v1/List/{udListDefinitionName}/Items/{listItemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 648,
    "Name": "Hauck, Fisher and Zulauf",
    "ToolTip": "Atque quos id.",
    "Deleted": true,
    "Rank": 495,
    "Type": "odit",
    "ColorBlock": 112,
    "IconHint": "iusto",
    "Selected": false,
    "LastChanged": "2013-07-26T16:55:30.5026971+02:00",
    "ChildItems": [
      {
        "Id": 466,
        "Name": "Zemlak, Cormier and Nikolaus",
        "ToolTip": "Tempora autem dolore adipisci quae a animi.",
        "Deleted": true,
        "Rank": 69,
        "Type": "dolores",
        "ColorBlock": 845,
        "IconHint": "numquam",
        "Selected": false,
        "LastChanged": "1999-04-30T16:55:30.5026971+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "ut",
        "StyleHint": "vel",
        "Hidden": false,
        "FullName": "Hassan Champlin"
      }
    ],
    "ExtraInfo": "qui",
    "StyleHint": "est",
    "Hidden": false,
    "FullName": "Elisa Green"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 281,
    "Name": "Mohr-Senger",
    "ToolTip": "Repellat ullam asperiores.",
    "Deleted": false,
    "Rank": 615,
    "Type": "excepturi",
    "ColorBlock": 250,
    "IconHint": "ad",
    "Selected": false,
    "LastChanged": "2015-08-01T16:55:30.5036972+02:00",
    "ChildItems": [
      {
        "Id": 499,
        "Name": "Reynolds, Deckow and Eichmann",
        "ToolTip": "Et sint ratione non quaerat accusantium laudantium.",
        "Deleted": false,
        "Rank": 699,
        "Type": "dolorum",
        "ColorBlock": 218,
        "IconHint": "consequuntur",
        "Selected": false,
        "LastChanged": "2011-11-26T16:55:30.5046978+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "asperiores",
        "StyleHint": "aliquid",
        "Hidden": true,
        "FullName": "Mr. Ila Blanda DVM",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 883
          }
        }
      }
    ],
    "ExtraInfo": "deleniti",
    "StyleHint": "ipsam",
    "Hidden": false,
    "FullName": "Joelle Torphy",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 762
      }
    }
  }
]
```