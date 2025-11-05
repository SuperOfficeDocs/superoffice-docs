---
title: PUT List/DeliveryTerm/Items/{id}/UserGroups
uid: v1DeliveryTermsList_PutDeliveryTermUserGroupsForListItem
generated: true
content_type: reference
---

# PUT List/DeliveryTerm/Items/{id}/UserGroups

```http
PUT /api/v1/List/DeliveryTerm/Items/{itemId}/UserGroups
```

Saves user groups visible for the DeliveryTerm list's item.


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
PUT /api/v1/List/DeliveryTerm/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 111,
    "Name": "Skiles Inc and Sons",
    "ToolTip": "Tempora velit.",
    "Deleted": true,
    "Rank": 424,
    "Type": "est",
    "ColorBlock": 646,
    "IconHint": "consequuntur",
    "Selected": true,
    "LastChanged": "2023-08-06T02:30:53.2723907+02:00",
    "ChildItems": [
      {
        "Id": 9,
        "Name": "Gottlieb Inc and Sons",
        "ToolTip": "Illum animi voluptatum nulla.",
        "Deleted": true,
        "Rank": 748,
        "Type": "iusto",
        "ColorBlock": 986,
        "IconHint": "omnis",
        "Selected": false,
        "LastChanged": "2017-10-22T02:30:53.2723907+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "tempore",
        "StyleHint": "nam",
        "Hidden": false,
        "FullName": "Dr. Arlie Jamel Cassin PhD"
      }
    ],
    "ExtraInfo": "architecto",
    "StyleHint": "enim",
    "Hidden": true,
    "FullName": "Jewell Stehr I"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 648,
    "Name": "Weissnat Inc and Sons",
    "ToolTip": "Fuga reiciendis error ipsa expedita.",
    "Deleted": false,
    "Rank": 626,
    "Type": "occaecati",
    "ColorBlock": 580,
    "IconHint": "at",
    "Selected": false,
    "LastChanged": "2014-02-06T02:30:53.2723907+01:00",
    "ChildItems": [
      {
        "Id": 850,
        "Name": "Rempel LLC",
        "ToolTip": "Veritatis corporis voluptatum optio ab minus.",
        "Deleted": false,
        "Rank": 537,
        "Type": "debitis",
        "ColorBlock": 513,
        "IconHint": "eum",
        "Selected": true,
        "LastChanged": "2003-05-07T02:30:53.2723907+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "est",
        "StyleHint": "delectus",
        "Hidden": false,
        "FullName": "Marjorie Torp III",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 368
          }
        }
      }
    ],
    "ExtraInfo": "est",
    "StyleHint": "iste",
    "Hidden": false,
    "FullName": "Kyra Muller",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 538
      }
    }
  }
]
```