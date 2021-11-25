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
    "Id": 655,
    "Name": "Lowe LLC",
    "ToolTip": "Quaerat optio est.",
    "Deleted": false,
    "Rank": 462,
    "Type": "ut",
    "ColorBlock": 189,
    "IconHint": "porro",
    "Selected": false,
    "LastChanged": "2020-08-22T18:25:51.8043219+02:00",
    "ChildItems": [
      {
        "Id": 670,
        "Name": "Waelchi-Purdy",
        "ToolTip": "Vero voluptatem voluptatum quia maxime quaerat.",
        "Deleted": false,
        "Rank": 658,
        "Type": "totam",
        "ColorBlock": 207,
        "IconHint": "sed",
        "Selected": true,
        "LastChanged": "1995-07-31T18:25:51.8043219+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "unde",
        "StyleHint": "est",
        "Hidden": true,
        "FullName": "Therese Kuphal"
      }
    ],
    "ExtraInfo": "cupiditate",
    "StyleHint": "unde",
    "Hidden": false,
    "FullName": "Ebba Crist"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 732,
    "Name": "Dibbert, Considine and Sauer",
    "ToolTip": "Non qui veritatis et amet et adipisci.",
    "Deleted": false,
    "Rank": 903,
    "Type": "tempore",
    "ColorBlock": 409,
    "IconHint": "sint",
    "Selected": true,
    "LastChanged": "1997-12-25T18:25:51.8063305+01:00",
    "ChildItems": [
      {
        "Id": 545,
        "Name": "Herman, Rodriguez and Larkin",
        "ToolTip": "Et ut enim velit qui odit.",
        "Deleted": false,
        "Rank": 517,
        "Type": "sed",
        "ColorBlock": 629,
        "IconHint": "a",
        "Selected": false,
        "LastChanged": "2000-09-05T18:25:51.8063305+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "est",
        "StyleHint": "quis",
        "Hidden": false,
        "FullName": "Benny Roberts",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 198
          }
        }
      }
    ],
    "ExtraInfo": "voluptate",
    "StyleHint": "temporibus",
    "Hidden": true,
    "FullName": "Gay Nolan",
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
        "FieldLength": 217
      }
    }
  }
]
```