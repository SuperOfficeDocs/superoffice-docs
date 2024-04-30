---
title: PUT List/ProjectType/Items/{id}/UserGroups
uid: v1ProjectTypeList_PutProjectTypeUserGroupsForListItem
generated: true
---

# PUT List/ProjectType/Items/{id}/UserGroups

```http
PUT /api/v1/List/ProjectType/Items/{itemId}/UserGroups
```

Saves user groups visible for the ProjectType list's item.


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
PUT /api/v1/List/ProjectType/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 434,
    "Name": "Corwin LLC",
    "ToolTip": "Iste magni odit et eligendi dolor accusantium.",
    "Deleted": true,
    "Rank": 519,
    "Type": "natus",
    "ColorBlock": 528,
    "IconHint": "nobis",
    "Selected": true,
    "LastChanged": "2014-04-25T11:16:14.668281+02:00",
    "ChildItems": [
      {
        "Id": 108,
        "Name": "Satterfield LLC",
        "ToolTip": "Ut tempora ut maxime quaerat impedit repudiandae suscipit.",
        "Deleted": true,
        "Rank": 811,
        "Type": "dolores",
        "ColorBlock": 458,
        "IconHint": "cum",
        "Selected": false,
        "LastChanged": "2024-04-10T11:16:14.668281+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "voluptas",
        "StyleHint": "libero",
        "Hidden": true,
        "FullName": "Coty Melvin Rogahn II"
      }
    ],
    "ExtraInfo": "iusto",
    "StyleHint": "maxime",
    "Hidden": false,
    "FullName": "Darrion Koss DVM"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 428,
    "Name": "Mraz, Kshlerin and Stracke",
    "ToolTip": "Dignissimos nam rerum repudiandae.",
    "Deleted": true,
    "Rank": 419,
    "Type": "velit",
    "ColorBlock": 312,
    "IconHint": "non",
    "Selected": false,
    "LastChanged": "2010-07-25T11:16:14.668281+02:00",
    "ChildItems": [
      {
        "Id": 6,
        "Name": "Turcotte Group",
        "ToolTip": "Est cum est nihil.",
        "Deleted": true,
        "Rank": 645,
        "Type": "officiis",
        "ColorBlock": 45,
        "IconHint": "atque",
        "Selected": false,
        "LastChanged": "2015-04-21T11:16:14.668281+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "officia",
        "StyleHint": "debitis",
        "Hidden": true,
        "FullName": "Mr. Antwan Hyman Kshlerin",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 478
          }
        }
      }
    ],
    "ExtraInfo": "in",
    "StyleHint": "ipsam",
    "Hidden": false,
    "FullName": "Maggie Gulgowski",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 983
      }
    }
  }
]
```