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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 282,
    "Name": "Bradtke-Heathcote",
    "ToolTip": "Necessitatibus ut eos deleniti itaque distinctio quo rerum.",
    "Deleted": true,
    "Rank": 671,
    "Type": "eligendi",
    "ColorBlock": 496,
    "IconHint": "dignissimos",
    "Selected": false,
    "LastChanged": "2016-02-03T11:44:42.898184+01:00",
    "ChildItems": [
      {
        "Id": 40,
        "Name": "Stanton LLC",
        "ToolTip": "Aut deserunt sit eveniet blanditiis ipsam magnam veritatis.",
        "Deleted": false,
        "Rank": 324,
        "Type": "commodi",
        "ColorBlock": 209,
        "IconHint": "minus",
        "Selected": false,
        "LastChanged": "2002-11-20T11:44:42.898184+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "maiores",
        "StyleHint": "reiciendis",
        "Hidden": false,
        "FullName": "Orie Lind"
      }
    ],
    "ExtraInfo": "accusamus",
    "StyleHint": "perspiciatis",
    "Hidden": false,
    "FullName": "Amaya Camden Kozey IV"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 124,
    "Name": "Von, Dooley and Von",
    "ToolTip": "Sit vitae temporibus beatae est tenetur.",
    "Deleted": true,
    "Rank": 372,
    "Type": "velit",
    "ColorBlock": 397,
    "IconHint": "impedit",
    "Selected": true,
    "LastChanged": "2007-06-25T11:44:42.898184+02:00",
    "ChildItems": [
      {
        "Id": 452,
        "Name": "Macejkovic-Runolfsson",
        "ToolTip": "Totam at nostrum animi veritatis consectetur perspiciatis.",
        "Deleted": false,
        "Rank": 497,
        "Type": "quam",
        "ColorBlock": 898,
        "IconHint": "saepe",
        "Selected": false,
        "LastChanged": "2002-12-16T11:44:42.898184+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "voluptates",
        "StyleHint": "occaecati",
        "Hidden": false,
        "FullName": "Susanna Koelpin",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 169
          }
        }
      }
    ],
    "ExtraInfo": "nostrum",
    "StyleHint": "ullam",
    "Hidden": false,
    "FullName": "Ms. Owen Carroll",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 169
      }
    }
  }
]
```