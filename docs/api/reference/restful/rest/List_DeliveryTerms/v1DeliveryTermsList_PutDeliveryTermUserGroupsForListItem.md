---
title: PUT List/DeliveryTerm/Items/{id}/UserGroups
uid: v1DeliveryTermsList_PutDeliveryTermUserGroupsForListItem
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

OK

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

## Sample request

```http!
PUT /api/v1/List/DeliveryTerm/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 302,
    "Name": "Torp, Hand and Waelchi",
    "ToolTip": "Ipsa at.",
    "Deleted": true,
    "Rank": 878,
    "Type": "quibusdam",
    "ColorBlock": 878,
    "IconHint": "est",
    "Selected": true,
    "LastChanged": "2000-02-25T11:10:54.2498932+01:00",
    "ChildItems": [
      {
        "Id": 964,
        "Name": "Skiles, Stoltenberg and Morar",
        "ToolTip": "A assumenda deleniti.",
        "Deleted": false,
        "Rank": 175,
        "Type": "tempora",
        "ColorBlock": 840,
        "IconHint": "quas",
        "Selected": false,
        "LastChanged": "2003-10-11T11:10:54.2498932+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quas",
        "StyleHint": "sapiente",
        "Hidden": true,
        "FullName": "Prof. Mittie Deckow Sr."
      }
    ],
    "ExtraInfo": "aut",
    "StyleHint": "omnis",
    "Hidden": false,
    "FullName": "Halie Reichert"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 851,
    "Name": "Bernhard-Ritchie",
    "ToolTip": "Incidunt et eos illo tempora.",
    "Deleted": false,
    "Rank": 119,
    "Type": "inventore",
    "ColorBlock": 106,
    "IconHint": "est",
    "Selected": true,
    "LastChanged": "2010-04-17T11:10:54.2508911+02:00",
    "ChildItems": [
      {
        "Id": 197,
        "Name": "Corkery, Sauer and Johnson",
        "ToolTip": "Voluptates nihil dicta debitis totam.",
        "Deleted": true,
        "Rank": 10,
        "Type": "est",
        "ColorBlock": 146,
        "IconHint": "exercitationem",
        "Selected": true,
        "LastChanged": "2018-06-18T11:10:54.2508911+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "minus",
        "StyleHint": "enim",
        "Hidden": false,
        "FullName": "Joyce O'Conner",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 808
          }
        }
      }
    ],
    "ExtraInfo": "sint",
    "StyleHint": "velit",
    "Hidden": false,
    "FullName": "Onie Gutkowski",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 377
      }
    }
  }
]
```
