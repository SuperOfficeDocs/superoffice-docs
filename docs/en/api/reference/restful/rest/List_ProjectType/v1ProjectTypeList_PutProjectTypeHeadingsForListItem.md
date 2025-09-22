---
title: PUT List/ProjectType/Items/{id}/Headings
uid: v1ProjectTypeList_PutProjectTypeHeadingsForListItem
generated: true
content_type: reference
---

# PUT List/ProjectType/Items/{id}/Headings

```http
PUT /api/v1/List/ProjectType/Items/{itemId}/Headings
```

Saves headings for the ProjectType list's item.


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
| Id | Integer | The Id of the ListItem |
| Name | String | The name of the ListItem |
| ToolTip | String | The tooltip of the ListItem |
| Deleted | Boolean | The deleted status of the ListItem |
| Rank | Integer | The rank of the ListItem |
| Type | String | The type of the ListItem. Custom field. |
| ColorBlock | Integer | The color indicator of the ListItem color block |
| IconHint | String | The Icon hint of the ListItem. Custom field. |
| Selected | Boolean | True if the ListItem is selected |
| LastChanged | String | Time of last change. |
| ChildItems | Array | The child items of the SelectableMDOListItem |
| ExtraInfo | String | Extra information added to the ListItem. Could be information such as sort order etc or other meta data. Custom field. |
| StyleHint | String | Style hint indicating, information such as background color etc. Custom field. |
| Hidden | Boolean | True if the ListItem is hidden |
| FullName | String | The name of the ListItem in its context |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
PUT /api/v1/List/ProjectType/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 296,
    "Name": "Abernathy Group",
    "ToolTip": "Vel minus velit adipisci ut est.",
    "Deleted": true,
    "Rank": 385,
    "Type": "et",
    "ColorBlock": 485,
    "IconHint": "et",
    "Selected": false,
    "LastChanged": "2024-10-28T11:24:54.0311654+01:00",
    "ChildItems": [
      {
        "Id": 161,
        "Name": "Botsford-Greenfelder",
        "ToolTip": "Repellendus nulla libero atque libero.",
        "Deleted": false,
        "Rank": 872,
        "Type": "expedita",
        "ColorBlock": 733,
        "IconHint": "ducimus",
        "Selected": false,
        "LastChanged": "2022-01-12T11:24:54.0311654+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "laudantium",
        "StyleHint": "saepe",
        "Hidden": false,
        "FullName": "Maymie Aufderhar"
      }
    ],
    "ExtraInfo": "earum",
    "StyleHint": "nostrum",
    "Hidden": true,
    "FullName": "Anissa Ernser"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 665,
    "Name": "Flatley-Stanton",
    "ToolTip": "Molestias labore alias omnis in quam.",
    "Deleted": false,
    "Rank": 972,
    "Type": "doloremque",
    "ColorBlock": 99,
    "IconHint": "sunt",
    "Selected": false,
    "LastChanged": "2003-04-04T11:24:54.0311654+02:00",
    "ChildItems": [
      {
        "Id": 430,
        "Name": "Schuster-Treutel",
        "ToolTip": "Qui numquam iusto natus ex cupiditate.",
        "Deleted": false,
        "Rank": 645,
        "Type": "odit",
        "ColorBlock": 638,
        "IconHint": "excepturi",
        "Selected": false,
        "LastChanged": "2007-06-29T11:24:54.0311654+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "itaque",
        "StyleHint": "incidunt",
        "Hidden": true,
        "FullName": "Prof. Makenna Hayes DDS",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 647
          }
        }
      }
    ],
    "ExtraInfo": "dolores",
    "StyleHint": "maiores",
    "Hidden": false,
    "FullName": "Earlene Nolan",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 131
      }
    }
  }
]
```