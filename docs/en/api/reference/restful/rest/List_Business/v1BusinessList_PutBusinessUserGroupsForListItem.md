---
title: PUT List/Business/Items/{id}/UserGroups
uid: v1BusinessList_PutBusinessUserGroupsForListItem
generated: true
---

# PUT List/Business/Items/{id}/UserGroups

```http
PUT /api/v1/List/Business/Items/{itemId}/UserGroups
```

Saves user groups visible for the Business list's item.


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
PUT /api/v1/List/Business/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 271,
    "Name": "Blick, Collier and Yost",
    "ToolTip": "Qui consequatur dolore distinctio.",
    "Deleted": false,
    "Rank": 237,
    "Type": "aliquam",
    "ColorBlock": 570,
    "IconHint": "aut",
    "Selected": false,
    "LastChanged": "2024-04-22T12:01:33.4332226+02:00",
    "ChildItems": [
      {
        "Id": 115,
        "Name": "Jaskolski-Daniel",
        "ToolTip": "Aspernatur sit quia magnam.",
        "Deleted": false,
        "Rank": 433,
        "Type": "commodi",
        "ColorBlock": 738,
        "IconHint": "doloribus",
        "Selected": true,
        "LastChanged": "2008-10-09T12:01:33.4332226+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "veniam",
        "StyleHint": "consequatur",
        "Hidden": true,
        "FullName": "Deshaun Ed Fadel II"
      }
    ],
    "ExtraInfo": "in",
    "StyleHint": "error",
    "Hidden": false,
    "FullName": "Dr. Corene Autumn Bosco IV"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 979,
    "Name": "Grant-Purdy",
    "ToolTip": "Eos id fugiat commodi nihil.",
    "Deleted": true,
    "Rank": 535,
    "Type": "eum",
    "ColorBlock": 525,
    "IconHint": "dolor",
    "Selected": true,
    "LastChanged": "2018-06-14T12:01:33.4332226+02:00",
    "ChildItems": [
      {
        "Id": 431,
        "Name": "Trantow-Ferry",
        "ToolTip": "Facilis et.",
        "Deleted": true,
        "Rank": 688,
        "Type": "accusantium",
        "ColorBlock": 755,
        "IconHint": "dolores",
        "Selected": false,
        "LastChanged": "2002-05-08T12:01:33.4332226+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "autem",
        "StyleHint": "id",
        "Hidden": false,
        "FullName": "Wilton Hintz",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 218
          }
        }
      }
    ],
    "ExtraInfo": "et",
    "StyleHint": "et",
    "Hidden": false,
    "FullName": "Vincent Dooley DDS",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 601
      }
    }
  }
]
```