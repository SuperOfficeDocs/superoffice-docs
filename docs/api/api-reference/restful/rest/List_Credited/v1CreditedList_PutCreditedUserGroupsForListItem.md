---
title: PUT List/Credited/Items/{id}/UserGroups
id: v1CreditedList_PutCreditedUserGroupsForListItem
---

# PUT List/Credited/Items/{id}/UserGroups

```http
PUT /api/v1/List/Credited/Items/{itemId}/UserGroups
```

Saves user groups visible for the Credited list's item.

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
PUT /api/v1/List/Credited/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 166,
    "Name": "Schowalter LLC",
    "ToolTip": "Nulla repudiandae.",
    "Deleted": false,
    "Rank": 374,
    "Type": "tempora",
    "ColorBlock": 915,
    "IconHint": "ea",
    "Selected": true,
    "LastChanged": "2009-12-21T18:25:51.7673263+01:00",
    "ChildItems": [
      {
        "Id": 707,
        "Name": "Goldner, Roob and Rippin",
        "ToolTip": "Quas velit et asperiores optio facilis.",
        "Deleted": true,
        "Rank": 61,
        "Type": "maiores",
        "ColorBlock": 601,
        "IconHint": "deserunt",
        "Selected": false,
        "LastChanged": "2021-07-23T18:25:51.7673263+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "consequatur",
        "StyleHint": "sit",
        "Hidden": false,
        "FullName": "Makenzie Raynor"
      }
    ],
    "ExtraInfo": "dolorem",
    "StyleHint": "ducimus",
    "Hidden": false,
    "FullName": "Samanta Tremblay"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 211,
    "Name": "Roberts Inc and Sons",
    "ToolTip": "Voluptatem cupiditate.",
    "Deleted": false,
    "Rank": 624,
    "Type": "consequatur",
    "ColorBlock": 946,
    "IconHint": "repudiandae",
    "Selected": false,
    "LastChanged": "2008-04-09T18:25:51.7683267+02:00",
    "ChildItems": [
      {
        "Id": 676,
        "Name": "Emard LLC",
        "ToolTip": "Itaque laudantium non necessitatibus.",
        "Deleted": true,
        "Rank": 718,
        "Type": "ipsam",
        "ColorBlock": 735,
        "IconHint": "voluptates",
        "Selected": true,
        "LastChanged": "2012-05-05T18:25:51.7683267+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "nulla",
        "StyleHint": "neque",
        "Hidden": false,
        "FullName": "Ruby Schumm",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": "scale B2B e-commerce"
            },
            "FieldType": "System.Int32",
            "FieldLength": 574
          }
        }
      }
    ],
    "ExtraInfo": "id",
    "StyleHint": "corrupti",
    "Hidden": true,
    "FullName": "Donny Mitchell",
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
        "FieldLength": 322
      }
    }
  }
]
```