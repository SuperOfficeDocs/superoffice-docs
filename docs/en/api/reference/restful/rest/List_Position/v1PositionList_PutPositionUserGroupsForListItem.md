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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 945,
    "Name": "Raynor Inc and Sons",
    "ToolTip": "Consequatur provident quo consequuntur ea ratione doloribus.",
    "Deleted": false,
    "Rank": 886,
    "Type": "assumenda",
    "ColorBlock": 713,
    "IconHint": "eaque",
    "Selected": false,
    "LastChanged": "2011-07-21T14:19:11.3367817+02:00",
    "ChildItems": [
      {
        "Id": 129,
        "Name": "Denesik-Larkin",
        "ToolTip": "Quod aut quae amet consequuntur sint.",
        "Deleted": false,
        "Rank": 68,
        "Type": "voluptatem",
        "ColorBlock": 187,
        "IconHint": "repudiandae",
        "Selected": false,
        "LastChanged": "2014-09-23T14:19:11.3367817+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "consequatur",
        "StyleHint": "exercitationem",
        "Hidden": true,
        "FullName": "Ulices Nikolaus"
      }
    ],
    "ExtraInfo": "ducimus",
    "StyleHint": "molestias",
    "Hidden": false,
    "FullName": "Susanna Schoen"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 900,
    "Name": "McCullough, Heller and Sauer",
    "ToolTip": "Quibusdam est sed tempora sit.",
    "Deleted": false,
    "Rank": 656,
    "Type": "occaecati",
    "ColorBlock": 922,
    "IconHint": "assumenda",
    "Selected": false,
    "LastChanged": "2005-04-04T14:19:11.3367817+02:00",
    "ChildItems": [
      {
        "Id": 16,
        "Name": "Jones Inc and Sons",
        "ToolTip": "Blanditiis dolorum.",
        "Deleted": false,
        "Rank": 746,
        "Type": "et",
        "ColorBlock": 773,
        "IconHint": "aspernatur",
        "Selected": true,
        "LastChanged": "2003-05-03T14:19:11.3367817+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "sed",
        "StyleHint": "similique",
        "Hidden": false,
        "FullName": "Micaela Hayes",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 862
          }
        }
      }
    ],
    "ExtraInfo": "dolor",
    "StyleHint": "ut",
    "Hidden": false,
    "FullName": "Laura Rogahn",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 799
      }
    }
  }
]
```