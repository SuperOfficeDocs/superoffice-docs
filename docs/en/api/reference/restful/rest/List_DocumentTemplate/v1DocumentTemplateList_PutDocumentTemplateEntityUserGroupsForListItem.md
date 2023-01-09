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
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 69,
    "Name": "Rodriguez, Pagac and Kuphal",
    "ToolTip": "Veritatis earum.",
    "Deleted": false,
    "Rank": 240,
    "Type": "fuga",
    "ColorBlock": 397,
    "IconHint": "ut",
    "Selected": false,
    "LastChanged": "2008-07-18T17:37:40.0204701+02:00",
    "ChildItems": [
      {
        "Id": 816,
        "Name": "McLaughlin-Mraz",
        "ToolTip": "Ullam reprehenderit.",
        "Deleted": false,
        "Rank": 969,
        "Type": "deleniti",
        "ColorBlock": 772,
        "IconHint": "similique",
        "Selected": false,
        "LastChanged": "2008-07-25T17:37:40.0204701+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "voluptates",
        "StyleHint": "ratione",
        "Hidden": false,
        "FullName": "Mr. Ahmad Medhurst DDS"
      }
    ],
    "ExtraInfo": "excepturi",
    "StyleHint": "eligendi",
    "Hidden": true,
    "FullName": "Carolina Rice"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 996,
    "Name": "Weissnat-Predovic",
    "ToolTip": "Quia rerum placeat distinctio.",
    "Deleted": false,
    "Rank": 129,
    "Type": "dolorem",
    "ColorBlock": 956,
    "IconHint": "suscipit",
    "Selected": false,
    "LastChanged": "2002-10-15T17:37:40.0214701+02:00",
    "ChildItems": [
      {
        "Id": 939,
        "Name": "Daniel, Ortiz and Kovacek",
        "ToolTip": "Officia ipsum dolores.",
        "Deleted": true,
        "Rank": 825,
        "Type": "reprehenderit",
        "ColorBlock": 487,
        "IconHint": "consectetur",
        "Selected": true,
        "LastChanged": "2006-05-12T17:37:40.0214701+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "eum",
        "StyleHint": "consequatur",
        "Hidden": false,
        "FullName": "Avery Lang",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 682
          }
        }
      }
    ],
    "ExtraInfo": "sequi",
    "StyleHint": "mollitia",
    "Hidden": false,
    "FullName": "Mr. Deven Feest",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 931
      }
    }
  }
]
```