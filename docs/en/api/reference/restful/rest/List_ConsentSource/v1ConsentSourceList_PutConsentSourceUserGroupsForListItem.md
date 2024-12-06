---
title: PUT List/ConsentSource/Items/{id}/UserGroups
uid: v1ConsentSourceList_PutConsentSourceUserGroupsForListItem
generated: true
---

# PUT List/ConsentSource/Items/{id}/UserGroups

```http
PUT /api/v1/List/ConsentSource/Items/{itemId}/UserGroups
```

Saves user groups visible for the ConsentSource list's item.


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
PUT /api/v1/List/ConsentSource/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 876,
    "Name": "Gulgowski-Block",
    "ToolTip": "Sapiente vitae nihil.",
    "Deleted": false,
    "Rank": 390,
    "Type": "mollitia",
    "ColorBlock": 787,
    "IconHint": "ut",
    "Selected": false,
    "LastChanged": "2013-08-26T10:18:00.9731148+02:00",
    "ChildItems": [
      {
        "Id": 247,
        "Name": "Schaden LLC",
        "ToolTip": "Sit excepturi accusamus.",
        "Deleted": false,
        "Rank": 766,
        "Type": "est",
        "ColorBlock": 246,
        "IconHint": "error",
        "Selected": false,
        "LastChanged": "2018-09-28T10:18:00.9731148+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "nesciunt",
        "StyleHint": "eaque",
        "Hidden": true,
        "FullName": "Harvey Yundt"
      }
    ],
    "ExtraInfo": "quo",
    "StyleHint": "quod",
    "Hidden": false,
    "FullName": "Bernie Ferry"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 448,
    "Name": "Gleichner, Armstrong and Wiegand",
    "ToolTip": "Sunt eum voluptas velit.",
    "Deleted": true,
    "Rank": 423,
    "Type": "eos",
    "ColorBlock": 535,
    "IconHint": "fugit",
    "Selected": false,
    "LastChanged": "2014-11-10T10:18:00.9731148+01:00",
    "ChildItems": [
      {
        "Id": 945,
        "Name": "Glover-Reinger",
        "ToolTip": "Sunt facilis iusto eum optio id doloremque eveniet.",
        "Deleted": true,
        "Rank": 696,
        "Type": "illum",
        "ColorBlock": 452,
        "IconHint": "et",
        "Selected": true,
        "LastChanged": "2000-12-16T10:18:00.9731148+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "nisi",
        "StyleHint": "suscipit",
        "Hidden": false,
        "FullName": "Leonie Mosciski",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 256
          }
        }
      }
    ],
    "ExtraInfo": "voluptates",
    "StyleHint": "est",
    "Hidden": false,
    "FullName": "Hillary Abbott MD",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 779
      }
    }
  }
]
```