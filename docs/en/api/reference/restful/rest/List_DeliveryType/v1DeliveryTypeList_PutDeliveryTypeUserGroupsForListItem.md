---
title: PUT List/DeliveryType/Items/{id}/UserGroups
uid: v1DeliveryTypeList_PutDeliveryTypeUserGroupsForListItem
generated: true
content_type: reference
---

# PUT List/DeliveryType/Items/{id}/UserGroups

```http
PUT /api/v1/List/DeliveryType/Items/{itemId}/UserGroups
```

Saves user groups visible for the DeliveryType list's item.


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
PUT /api/v1/List/DeliveryType/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 524,
    "Name": "Lockman-Auer",
    "ToolTip": "Unde velit sequi tenetur quia assumenda placeat.",
    "Deleted": true,
    "Rank": 741,
    "Type": "ea",
    "ColorBlock": 608,
    "IconHint": "dolor",
    "Selected": true,
    "LastChanged": "2016-08-23T03:41:59.4023618+02:00",
    "ChildItems": [
      {
        "Id": 674,
        "Name": "Lesch, Boehm and Becker",
        "ToolTip": "Ratione ducimus perferendis ut nostrum officiis voluptas rerum.",
        "Deleted": true,
        "Rank": 62,
        "Type": "totam",
        "ColorBlock": 887,
        "IconHint": "quod",
        "Selected": true,
        "LastChanged": "2009-04-15T03:41:59.4023618+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "debitis",
        "StyleHint": "quibusdam",
        "Hidden": false,
        "FullName": "Esperanza Schoen"
      }
    ],
    "ExtraInfo": "quis",
    "StyleHint": "laudantium",
    "Hidden": false,
    "FullName": "Alfreda Eichmann"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 794,
    "Name": "Lind Group",
    "ToolTip": "Quia molestiae est libero autem sunt.",
    "Deleted": false,
    "Rank": 961,
    "Type": "voluptatem",
    "ColorBlock": 78,
    "IconHint": "repellendus",
    "Selected": true,
    "LastChanged": "2019-07-28T03:41:59.4023618+02:00",
    "ChildItems": [
      {
        "Id": 511,
        "Name": "Nolan LLC",
        "ToolTip": "Eveniet rerum qui est tempora laboriosam impedit hic.",
        "Deleted": false,
        "Rank": 558,
        "Type": "voluptatem",
        "ColorBlock": 790,
        "IconHint": "eos",
        "Selected": false,
        "LastChanged": "2007-01-26T03:41:59.4023618+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "neque",
        "StyleHint": "vel",
        "Hidden": false,
        "FullName": "Brittany Klein",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 517
          }
        }
      }
    ],
    "ExtraInfo": "quasi",
    "StyleHint": "laboriosam",
    "Hidden": true,
    "FullName": "Prof. Richie Chesley Brown",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 60
      }
    }
  }
]
```