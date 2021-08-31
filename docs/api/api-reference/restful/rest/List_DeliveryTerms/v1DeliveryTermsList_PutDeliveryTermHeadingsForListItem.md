---
title: PUT List/DeliveryTerm/Items/{id}/Headings
id: v1DeliveryTermsList_PutDeliveryTermHeadingsForListItem
---

# PUT List/DeliveryTerm/Items/{id}/Headings

```http
PUT /api/v1/List/DeliveryTerm/Items/{itemId}/Headings
```

Saves headings for the DeliveryTerm list's item.

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
PUT /api/v1/List/DeliveryTerm/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 333,
    "Name": "Rosenbaum Inc and Sons",
    "ToolTip": "Sed quod.",
    "Deleted": true,
    "Rank": 467,
    "Type": "quod",
    "ColorBlock": 699,
    "IconHint": "voluptas",
    "Selected": false,
    "LastChanged": "2011-12-19T15:05:43.42251+01:00",
    "ChildItems": [
      {
        "Id": 633,
        "Name": "Runolfsdottir-Johnston",
        "ToolTip": "Laudantium voluptas exercitationem atque beatae deleniti deleniti.",
        "Deleted": true,
        "Rank": 949,
        "Type": "repellat",
        "ColorBlock": 909,
        "IconHint": "sequi",
        "Selected": false,
        "LastChanged": "1996-10-11T15:05:43.42251+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "aliquid",
        "StyleHint": "ut",
        "Hidden": false,
        "FullName": "Mya Effertz"
      }
    ],
    "ExtraInfo": "autem",
    "StyleHint": "odio",
    "Hidden": false,
    "FullName": "Aron Christiansen"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 402,
    "Name": "Zulauf Group",
    "ToolTip": "Ex non ipsum ea accusantium et quaerat.",
    "Deleted": true,
    "Rank": 385,
    "Type": "id",
    "ColorBlock": 731,
    "IconHint": "recusandae",
    "Selected": true,
    "LastChanged": "1997-11-18T15:05:43.4245097+01:00",
    "ChildItems": [
      {
        "Id": 73,
        "Name": "Bernhard-Walker",
        "ToolTip": "Impedit omnis.",
        "Deleted": false,
        "Rank": 106,
        "Type": "mollitia",
        "ColorBlock": 296,
        "IconHint": "aut",
        "Selected": true,
        "LastChanged": "2016-12-02T15:05:43.4245097+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "recusandae",
        "StyleHint": "rerum",
        "Hidden": true,
        "FullName": "Damien Runolfsdottir",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 708
          }
        }
      }
    ],
    "ExtraInfo": "praesentium",
    "StyleHint": "itaque",
    "Hidden": false,
    "FullName": "Ernestina Wunsch",
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
        "FieldLength": 519
      }
    }
  }
]
```