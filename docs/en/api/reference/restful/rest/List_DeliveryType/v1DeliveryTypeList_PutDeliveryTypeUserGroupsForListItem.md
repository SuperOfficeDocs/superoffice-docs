---
title: PUT List/DeliveryType/Items/{id}/UserGroups
uid: v1DeliveryTypeList_PutDeliveryTypeUserGroupsForListItem
generated: true
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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 669,
    "Name": "Windler, Parisian and King",
    "ToolTip": "Dolorum nisi.",
    "Deleted": false,
    "Rank": 104,
    "Type": "in",
    "ColorBlock": 965,
    "IconHint": "corporis",
    "Selected": true,
    "LastChanged": "2013-11-09T23:04:05.4575026+01:00",
    "ChildItems": [
      {
        "Id": 524,
        "Name": "Ferry LLC",
        "ToolTip": "Totam atque accusantium quasi est et iusto magni.",
        "Deleted": false,
        "Rank": 543,
        "Type": "doloribus",
        "ColorBlock": 731,
        "IconHint": "quibusdam",
        "Selected": true,
        "LastChanged": "2022-03-30T23:04:05.4579997+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "velit",
        "StyleHint": "iusto",
        "Hidden": false,
        "FullName": "Bo Tierra Kirlin PhD"
      }
    ],
    "ExtraInfo": "explicabo",
    "StyleHint": "et",
    "Hidden": false,
    "FullName": "Mr. Violet Waino Beer I"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 5,
    "Name": "Effertz Group",
    "ToolTip": "Amet laboriosam voluptas.",
    "Deleted": true,
    "Rank": 689,
    "Type": "adipisci",
    "ColorBlock": 86,
    "IconHint": "doloremque",
    "Selected": true,
    "LastChanged": "2008-04-07T23:04:05.4594998+02:00",
    "ChildItems": [
      {
        "Id": 826,
        "Name": "Trantow-Abbott",
        "ToolTip": "Cum maxime quisquam id.",
        "Deleted": true,
        "Rank": 833,
        "Type": "sint",
        "ColorBlock": 186,
        "IconHint": "qui",
        "Selected": false,
        "LastChanged": "2009-05-08T23:04:05.4594998+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "ipsam",
        "StyleHint": "eos",
        "Hidden": false,
        "FullName": "Maybell Bernice Kuhic Sr.",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 525
          }
        }
      }
    ],
    "ExtraInfo": "ut",
    "StyleHint": "asperiores",
    "Hidden": false,
    "FullName": "Tevin Lakin",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 383
      }
    }
  }
]
```