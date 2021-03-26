---
title: PUT List/{id}/Items/{id}/Headings
id: v1ListItemEntity_SaveHeadingsForListItemFromListDefinition
---

# PUT List/{id}/Items/{id}/Headings

```http
PUT /api/v1/List/{udListDefinitionId}/Items/{listItemId}/Headings
```

Saves the active headings for the list item.






| Path Part | Type | Description |
|-----------|------|-------------|
| udListDefinitionId | int32 | The id of the list definition, indicating which list to delete the items from. Negative numbers indicate TableNumber value instead of UDListDefId. e.g. -64 = category. **Required** |
| listItemId | int32 | The identity of the list item to delete **Required** |



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

## Request Body: headings  

The headings to save. 

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
PUT /api/v1/List/{udListDefinitionId}/Items/{listItemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 792,
    "Name": "Lakin, Rempel and Grant",
    "ToolTip": "Quae at odit reprehenderit quos.",
    "Deleted": false,
    "Rank": 677,
    "Type": "molestiae",
    "ColorBlock": 399,
    "IconHint": "unde",
    "Selected": true,
    "LastChanged": "2004-02-05T09:41:00.1393622+01:00",
    "ChildItems": [
      {
        "Id": 657,
        "Name": "Bernier, Cremin and Rolfson",
        "ToolTip": "Voluptatibus veritatis.",
        "Deleted": true,
        "Rank": 519,
        "Type": "totam",
        "ColorBlock": 942,
        "IconHint": "qui",
        "Selected": false,
        "LastChanged": "2012-06-27T09:41:00.1393622+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "provident",
        "StyleHint": "in",
        "Hidden": false,
        "FullName": "Ms. Dolores Johnson"
      }
    ],
    "ExtraInfo": "quia",
    "StyleHint": "ut",
    "Hidden": false,
    "FullName": "Avery Kuhlman"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 288,
    "Name": "Carroll, Harvey and Mraz",
    "ToolTip": "Praesentium et enim.",
    "Deleted": false,
    "Rank": 640,
    "Type": "modi",
    "ColorBlock": 18,
    "IconHint": "quas",
    "Selected": true,
    "LastChanged": "2005-07-23T09:41:00.1413617+02:00",
    "ChildItems": [
      {
        "Id": 341,
        "Name": "Mraz Inc and Sons",
        "ToolTip": "Corrupti distinctio consequuntur aperiam.",
        "Deleted": true,
        "Rank": 196,
        "Type": "ullam",
        "ColorBlock": 596,
        "IconHint": "repudiandae",
        "Selected": false,
        "LastChanged": "2005-11-23T09:41:00.1413617+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "asperiores",
        "StyleHint": "cumque",
        "Hidden": false,
        "FullName": "Margarette Kling",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 687
          }
        }
      }
    ],
    "ExtraInfo": "ducimus",
    "StyleHint": "recusandae",
    "Hidden": true,
    "FullName": "Beau Gottlieb",
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
        "FieldLength": 411
      }
    }
  }
]
```