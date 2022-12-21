---
title: PUT List/Position/Items/{id}/Headings
uid: v1PositionList_PutPositionHeadingsForListItem
---

# PUT List/Position/Items/{id}/Headings

```http
PUT /api/v1/List/Position/Items/{itemId}/Headings
```

Saves headings for the Position list's item.


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
PUT /api/v1/List/Position/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 831,
    "Name": "Buckridge, Hansen and Donnelly",
    "ToolTip": "Libero voluptatem repellendus debitis quae fuga et voluptas.",
    "Deleted": false,
    "Rank": 443,
    "Type": "est",
    "ColorBlock": 63,
    "IconHint": "natus",
    "Selected": true,
    "LastChanged": "2005-03-07T02:49:52.3284476+01:00",
    "ChildItems": [
      {
        "Id": 142,
        "Name": "Kub, D'Amore and Rohan",
        "ToolTip": "Officia nihil porro ea labore.",
        "Deleted": true,
        "Rank": 779,
        "Type": "vero",
        "ColorBlock": 890,
        "IconHint": "distinctio",
        "Selected": false,
        "LastChanged": "2002-05-16T02:49:52.3284476+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "aperiam",
        "StyleHint": "possimus",
        "Hidden": true,
        "FullName": "Mr. Jordi Morissette"
      }
    ],
    "ExtraInfo": "nihil",
    "StyleHint": "non",
    "Hidden": true,
    "FullName": "Prof. Assunta Littel"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 124,
    "Name": "Maggio-Kautzer",
    "ToolTip": "Necessitatibus accusamus omnis beatae dolores voluptate.",
    "Deleted": true,
    "Rank": 36,
    "Type": "ducimus",
    "ColorBlock": 955,
    "IconHint": "et",
    "Selected": false,
    "LastChanged": "1998-07-10T02:49:52.3284476+02:00",
    "ChildItems": [
      {
        "Id": 660,
        "Name": "Heidenreich LLC",
        "ToolTip": "Repudiandae voluptates iusto numquam et doloremque.",
        "Deleted": false,
        "Rank": 272,
        "Type": "iusto",
        "ColorBlock": 939,
        "IconHint": "id",
        "Selected": false,
        "LastChanged": "2010-10-25T02:49:52.3284476+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "iusto",
        "StyleHint": "tempore",
        "Hidden": false,
        "FullName": "Madelynn Estelle Dibbert DVM",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 283
          }
        }
      }
    ],
    "ExtraInfo": "quo",
    "StyleHint": "quaerat",
    "Hidden": false,
    "FullName": "Prof. Sabrina Gonzalo Balistreri",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 480
      }
    }
  }
]
```