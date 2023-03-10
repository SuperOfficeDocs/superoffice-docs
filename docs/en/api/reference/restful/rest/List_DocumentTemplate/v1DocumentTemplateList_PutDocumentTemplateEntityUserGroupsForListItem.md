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
    "Id": 177,
    "Name": "Bradtke, Tillman and Marvin",
    "ToolTip": "Optio officiis omnis quasi expedita quis non.",
    "Deleted": false,
    "Rank": 516,
    "Type": "sunt",
    "ColorBlock": 117,
    "IconHint": "consequuntur",
    "Selected": false,
    "LastChanged": "1996-06-24T12:15:28.1516187+02:00",
    "ChildItems": [
      {
        "Id": 865,
        "Name": "O'Keefe, Mills and Little",
        "ToolTip": "Porro sed esse et earum delectus dolor consequatur.",
        "Deleted": true,
        "Rank": 744,
        "Type": "esse",
        "ColorBlock": 592,
        "IconHint": "repudiandae",
        "Selected": false,
        "LastChanged": "2018-10-21T12:15:28.1526193+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "porro",
        "StyleHint": "blanditiis",
        "Hidden": true,
        "FullName": "Billie Aileen Smith I"
      }
    ],
    "ExtraInfo": "omnis",
    "StyleHint": "quidem",
    "Hidden": false,
    "FullName": "Sadye Dare"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 206,
    "Name": "Barton, Mosciski and O'Hara",
    "ToolTip": "Tempore illum aut.",
    "Deleted": true,
    "Rank": 994,
    "Type": "voluptatum",
    "ColorBlock": 303,
    "IconHint": "recusandae",
    "Selected": false,
    "LastChanged": "2003-07-24T12:15:28.1546184+02:00",
    "ChildItems": [
      {
        "Id": 95,
        "Name": "Hoeger Inc and Sons",
        "ToolTip": "Quaerat nesciunt iusto sapiente optio tempora qui sit.",
        "Deleted": false,
        "Rank": 130,
        "Type": "recusandae",
        "ColorBlock": 806,
        "IconHint": "iste",
        "Selected": false,
        "LastChanged": "2015-07-11T12:15:28.1546184+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "enim",
        "StyleHint": "reprehenderit",
        "Hidden": false,
        "FullName": "Arielle Ward",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 606
          }
        }
      }
    ],
    "ExtraInfo": "quia",
    "StyleHint": "qui",
    "Hidden": false,
    "FullName": "Xavier Gaylord",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 844
      }
    }
  }
]
```