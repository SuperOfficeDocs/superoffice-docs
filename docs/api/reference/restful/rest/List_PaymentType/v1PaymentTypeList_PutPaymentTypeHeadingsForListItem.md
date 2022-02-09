---
title: PUT List/PaymentType/Items/{id}/Headings
id: v1PaymentTypeList_PutPaymentTypeHeadingsForListItem
---

# PUT List/PaymentType/Items/{id}/Headings

```http
PUT /api/v1/List/PaymentType/Items/{itemId}/Headings
```

Saves headings for the PaymentType list's item.

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
PUT /api/v1/List/PaymentType/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 653,
    "Name": "Trantow LLC",
    "ToolTip": "Itaque facere officiis placeat sint qui qui.",
    "Deleted": false,
    "Rank": 298,
    "Type": "vel",
    "ColorBlock": 945,
    "IconHint": "aut",
    "Selected": false,
    "LastChanged": "2011-12-29T18:25:51.9472108+01:00",
    "ChildItems": [
      {
        "Id": 292,
        "Name": "Swaniawski Inc and Sons",
        "ToolTip": "Fugit architecto.",
        "Deleted": true,
        "Rank": 876,
        "Type": "possimus",
        "ColorBlock": 615,
        "IconHint": "officiis",
        "Selected": false,
        "LastChanged": "2008-05-10T18:25:51.9472108+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "maxime",
        "StyleHint": "incidunt",
        "Hidden": false,
        "FullName": "Elyse Streich"
      }
    ],
    "ExtraInfo": "rerum",
    "StyleHint": "commodi",
    "Hidden": true,
    "FullName": "Alford Nikolaus"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 966,
    "Name": "Mayert LLC",
    "ToolTip": "At ut voluptates earum velit.",
    "Deleted": false,
    "Rank": 801,
    "Type": "velit",
    "ColorBlock": 857,
    "IconHint": "sint",
    "Selected": false,
    "LastChanged": "2011-04-21T18:25:51.9492458+02:00",
    "ChildItems": [
      {
        "Id": 247,
        "Name": "Yost, Cartwright and Hills",
        "ToolTip": "Neque quis similique sunt magnam.",
        "Deleted": true,
        "Rank": 566,
        "Type": "ea",
        "ColorBlock": 591,
        "IconHint": "esse",
        "Selected": true,
        "LastChanged": "2002-09-08T18:25:51.9502479+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "est",
        "StyleHint": "repellendus",
        "Hidden": true,
        "FullName": "Jeanie Nikolaus",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 526
          }
        }
      }
    ],
    "ExtraInfo": "ipsa",
    "StyleHint": "dicta",
    "Hidden": false,
    "FullName": "Cordell Weber",
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
        "FieldLength": 949
      }
    }
  }
]
```