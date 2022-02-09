---
title: PUT List/Credited/Items/{id}/Headings
id: v1CreditedList_PutCreditedHeadingsForListItem
---

# PUT List/Credited/Items/{id}/Headings

```http
PUT /api/v1/List/Credited/Items/{itemId}/Headings
```

Saves headings for the Credited list's item.

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
PUT /api/v1/List/Credited/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 766,
    "Name": "Keebler Inc and Sons",
    "ToolTip": "Nobis dolor voluptatem et iure omnis.",
    "Deleted": false,
    "Rank": 158,
    "Type": "atque",
    "ColorBlock": 13,
    "IconHint": "molestias",
    "Selected": false,
    "LastChanged": "2005-10-31T18:25:51.7713253+01:00",
    "ChildItems": [
      {
        "Id": 601,
        "Name": "Barrows Group",
        "ToolTip": "Quaerat et nesciunt.",
        "Deleted": false,
        "Rank": 272,
        "Type": "illum",
        "ColorBlock": 129,
        "IconHint": "doloribus",
        "Selected": false,
        "LastChanged": "1996-07-21T18:25:51.7713253+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "dicta",
        "StyleHint": "adipisci",
        "Hidden": true,
        "FullName": "Bruce Beahan"
      }
    ],
    "ExtraInfo": "omnis",
    "StyleHint": "asperiores",
    "Hidden": true,
    "FullName": "Chris Blanda"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 953,
    "Name": "Ritchie, Price and Rogahn",
    "ToolTip": "Qui expedita.",
    "Deleted": true,
    "Rank": 68,
    "Type": "amet",
    "ColorBlock": 598,
    "IconHint": "facere",
    "Selected": true,
    "LastChanged": "1996-03-16T18:25:51.7733267+01:00",
    "ChildItems": [
      {
        "Id": 123,
        "Name": "Doyle-Brakus",
        "ToolTip": "In sunt sunt ut id aut voluptas.",
        "Deleted": false,
        "Rank": 383,
        "Type": "delectus",
        "ColorBlock": 935,
        "IconHint": "non",
        "Selected": true,
        "LastChanged": "2012-09-03T18:25:51.7733267+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "magni",
        "StyleHint": "excepturi",
        "Hidden": true,
        "FullName": "Antwan Schmidt Sr.",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 882
          }
        }
      }
    ],
    "ExtraInfo": "id",
    "StyleHint": "architecto",
    "Hidden": false,
    "FullName": "Casimer Champlin",
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
        "FieldType": "System.String",
        "FieldLength": 687
      }
    }
  }
]
```