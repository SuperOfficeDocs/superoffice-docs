---
title: PUT List/ProductFamily/Items/{id}/UserGroups
id: v1ProductFamilyList_PutProductFamilyUserGroupsForListItem
---

# PUT List/ProductFamily/Items/{id}/UserGroups

```http
PUT /api/v1/List/ProductFamily/Items/{itemId}/UserGroups
```

Saves user groups visible for the ProductFamily list's item.

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
PUT /api/v1/List/ProductFamily/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 891,
    "Name": "Powlowski Inc and Sons",
    "ToolTip": "Beatae molestiae aut dolorem facere.",
    "Deleted": true,
    "Rank": 57,
    "Type": "cupiditate",
    "ColorBlock": 659,
    "IconHint": "modi",
    "Selected": false,
    "LastChanged": "1998-04-18T15:05:43.6290797+02:00",
    "ChildItems": [
      {
        "Id": 619,
        "Name": "Schmitt, Hettinger and Johnson",
        "ToolTip": "Odit molestiae in tempora numquam.",
        "Deleted": false,
        "Rank": 303,
        "Type": "a",
        "ColorBlock": 422,
        "IconHint": "alias",
        "Selected": false,
        "LastChanged": "2011-10-10T15:05:43.6290797+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "officia",
        "StyleHint": "quos",
        "Hidden": true,
        "FullName": "Tanya Rau"
      }
    ],
    "ExtraInfo": "nulla",
    "StyleHint": "quia",
    "Hidden": false,
    "FullName": "Ken Gutkowski"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 196,
    "Name": "Kemmer-Runte",
    "ToolTip": "Est ipsam et ipsa autem maiores et.",
    "Deleted": true,
    "Rank": 605,
    "Type": "voluptas",
    "ColorBlock": 297,
    "IconHint": "odit",
    "Selected": true,
    "LastChanged": "2013-03-02T15:05:43.6300795+01:00",
    "ChildItems": [
      {
        "Id": 599,
        "Name": "Treutel, Luettgen and Toy",
        "ToolTip": "Totam rerum ut et nam nesciunt placeat.",
        "Deleted": false,
        "Rank": 445,
        "Type": "maxime",
        "ColorBlock": 440,
        "IconHint": "blanditiis",
        "Selected": false,
        "LastChanged": "2014-12-01T15:05:43.6300795+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "est",
        "StyleHint": "ex",
        "Hidden": true,
        "FullName": "Mrs. Kassandra Hahn",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 598
          }
        }
      }
    ],
    "ExtraInfo": "ut",
    "StyleHint": "explicabo",
    "Hidden": false,
    "FullName": "Margarita Schowalter",
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
        "FieldLength": 296
      }
    }
  }
]
```