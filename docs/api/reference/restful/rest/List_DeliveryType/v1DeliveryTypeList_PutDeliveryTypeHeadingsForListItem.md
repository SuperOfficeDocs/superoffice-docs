---
title: PUT List/DeliveryType/Items/{id}/Headings
id: v1DeliveryTypeList_PutDeliveryTypeHeadingsForListItem
---

# PUT List/DeliveryType/Items/{id}/Headings

```http
PUT /api/v1/List/DeliveryType/Items/{itemId}/Headings
```

Saves headings for the DeliveryType list's item.

Calls the List agent service SaveHeadingsForListItemFromListDefinition.

| Path Part | Type | Description |
|-----------|------|-------------|
| itemId | int32 | The ID of the headings to be saved. **Required** |

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

## Response: array

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
PUT /api/v1/List/DeliveryType/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 811,
    "Name": "Yost, Kassulke and Wisozk",
    "ToolTip": "Quis deserunt.",
    "Deleted": true,
    "Rank": 988,
    "Type": "qui",
    "ColorBlock": 159,
    "IconHint": "ut",
    "Selected": false,
    "LastChanged": "1998-06-12T18:25:51.8193272+02:00",
    "ChildItems": [
      {
        "Id": 922,
        "Name": "Ratke, Heller and Schamberger",
        "ToolTip": "Enim minus blanditiis voluptatibus eum harum soluta.",
        "Deleted": true,
        "Rank": 133,
        "Type": "reprehenderit",
        "ColorBlock": 611,
        "IconHint": "odio",
        "Selected": true,
        "LastChanged": "2006-07-17T18:25:51.8193272+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "itaque",
        "StyleHint": "magni",
        "Hidden": true,
        "FullName": "Bert Harvey"
      }
    ],
    "ExtraInfo": "animi",
    "StyleHint": "fuga",
    "Hidden": false,
    "FullName": "Cecelia Gutmann Jr."
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 314,
    "Name": "Hirthe Inc and Sons",
    "ToolTip": "Et quidem.",
    "Deleted": false,
    "Rank": 550,
    "Type": "rerum",
    "ColorBlock": 70,
    "IconHint": "saepe",
    "Selected": false,
    "LastChanged": "1998-10-11T18:25:51.8213272+02:00",
    "ChildItems": [
      {
        "Id": 62,
        "Name": "Gusikowski Group",
        "ToolTip": "Et ipsum dicta illum velit.",
        "Deleted": true,
        "Rank": 37,
        "Type": "necessitatibus",
        "ColorBlock": 968,
        "IconHint": "itaque",
        "Selected": true,
        "LastChanged": "2014-11-07T18:25:51.8213272+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "sit",
        "StyleHint": "laboriosam",
        "Hidden": false,
        "FullName": "Georgianna Stamm Jr.",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 240
          }
        }
      }
    ],
    "ExtraInfo": "sunt",
    "StyleHint": "est",
    "Hidden": true,
    "FullName": "Cleta Okuneva",
    "TableRight": {
      "Mask": "Delete",
      "Reason": ""
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 601
      }
    }
  }
]
```
