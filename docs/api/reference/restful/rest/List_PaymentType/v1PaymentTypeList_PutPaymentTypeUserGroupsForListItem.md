---
title: PUT List/PaymentType/Items/{id}/UserGroups
id: v1PaymentTypeList_PutPaymentTypeUserGroupsForListItem
---

# PUT List/PaymentType/Items/{id}/UserGroups

```http
PUT /api/v1/List/PaymentType/Items/{itemId}/UserGroups
```

Saves user groups visible for the PaymentType list's item.

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
PUT /api/v1/List/PaymentType/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 130,
    "Name": "O'Kon-Brekke",
    "ToolTip": "Accusamus odit repudiandae reprehenderit minima alias illo.",
    "Deleted": true,
    "Rank": 139,
    "Type": "fugit",
    "ColorBlock": 495,
    "IconHint": "maiores",
    "Selected": false,
    "LastChanged": "2011-10-22T18:25:51.9422413+02:00",
    "ChildItems": [
      {
        "Id": 525,
        "Name": "Crist-Ebert",
        "ToolTip": "Cum accusantium nihil voluptatem repellendus omnis.",
        "Deleted": false,
        "Rank": 49,
        "Type": "facilis",
        "ColorBlock": 273,
        "IconHint": "iste",
        "Selected": true,
        "LastChanged": "2009-11-28T18:25:51.9432418+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "molestias",
        "StyleHint": "quo",
        "Hidden": true,
        "FullName": "Vita Conroy"
      }
    ],
    "ExtraInfo": "quae",
    "StyleHint": "rerum",
    "Hidden": true,
    "FullName": "Leila Strosin"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 426,
    "Name": "Kulas, Tromp and Towne",
    "ToolTip": "Similique recusandae aut eos ut est.",
    "Deleted": false,
    "Rank": 70,
    "Type": "nihil",
    "ColorBlock": 906,
    "IconHint": "repellendus",
    "Selected": false,
    "LastChanged": "2005-10-23T18:25:51.9442101+02:00",
    "ChildItems": [
      {
        "Id": 627,
        "Name": "Okuneva-Cronin",
        "ToolTip": "Magni aliquid animi commodi et voluptatem.",
        "Deleted": true,
        "Rank": 285,
        "Type": "molestiae",
        "ColorBlock": 748,
        "IconHint": "est",
        "Selected": false,
        "LastChanged": "2007-05-21T18:25:51.9452091+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "maiores",
        "StyleHint": "qui",
        "Hidden": false,
        "FullName": "Annamae Bergnaum",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 3
          }
        }
      }
    ],
    "ExtraInfo": "atque",
    "StyleHint": "quam",
    "Hidden": false,
    "FullName": "Carlos Morar",
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
        "FieldLength": 553
      }
    }
  }
]
```