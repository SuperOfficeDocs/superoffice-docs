---
title: PUT List/{id}/Items/{id}/UserGroups
uid: v1ListItemEntity_SetVisibleForUserGroups
generated: true
---

# PUT List/{id}/Items/{id}/UserGroups

```http
PUT /api/v1/List/{udListDefinitionId}/Items/{listItemId}/UserGroups
```

Update User groups that this list item is visible for






| Path Part | Type | Description |
|-----------|------|-------------|
| udListDefinitionId | int32 | The id of the list. Negative numbers indicate TableNumber value instead of UDListDefId. e.g. -64 = category. **Required** |
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
PUT /api/v1/List/{udListDefinitionId}/Items/{listItemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 76,
    "Name": "Braun, Stamm and Hegmann",
    "ToolTip": "Dolores voluptatem nemo et voluptatibus.",
    "Deleted": false,
    "Rank": 682,
    "Type": "temporibus",
    "ColorBlock": 659,
    "IconHint": "soluta",
    "Selected": false,
    "LastChanged": "2006-12-03T16:00:48.8364781+01:00",
    "ChildItems": [
      {
        "Id": 802,
        "Name": "Dickens-Watsica",
        "ToolTip": "Doloremque officiis quasi doloremque.",
        "Deleted": false,
        "Rank": 272,
        "Type": "velit",
        "ColorBlock": 447,
        "IconHint": "eligendi",
        "Selected": true,
        "LastChanged": "2018-07-12T16:00:48.8364781+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "nesciunt",
        "StyleHint": "nisi",
        "Hidden": false,
        "FullName": "Houston Dooley"
      }
    ],
    "ExtraInfo": "et",
    "StyleHint": "qui",
    "Hidden": false,
    "FullName": "Ms. Kenny Neha Schultz"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 962,
    "Name": "Hayes-Orn",
    "ToolTip": "Aperiam repellendus ipsum omnis excepturi aut vitae in.",
    "Deleted": true,
    "Rank": 494,
    "Type": "et",
    "ColorBlock": 207,
    "IconHint": "ipsum",
    "Selected": true,
    "LastChanged": "2015-01-25T16:00:48.8364781+01:00",
    "ChildItems": [
      {
        "Id": 314,
        "Name": "O'Connell LLC",
        "ToolTip": "Velit et et et velit rerum enim illum.",
        "Deleted": true,
        "Rank": 4,
        "Type": "veritatis",
        "ColorBlock": 82,
        "IconHint": "eum",
        "Selected": false,
        "LastChanged": "2016-08-27T16:00:48.8364781+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "ab",
        "StyleHint": "et",
        "Hidden": false,
        "FullName": "Sylvester Herman",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 450
          }
        }
      }
    ],
    "ExtraInfo": "dolore",
    "StyleHint": "hic",
    "Hidden": false,
    "FullName": "Amalia Zulauf",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 443
      }
    }
  }
]
```