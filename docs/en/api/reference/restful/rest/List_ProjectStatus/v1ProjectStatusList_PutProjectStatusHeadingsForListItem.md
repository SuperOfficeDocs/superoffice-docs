---
title: PUT List/ProjectStatus/Items/{id}/Headings
uid: v1ProjectStatusList_PutProjectStatusHeadingsForListItem
generated: true
---

# PUT List/ProjectStatus/Items/{id}/Headings

```http
PUT /api/v1/List/ProjectStatus/Items/{itemId}/Headings
```

Saves headings for the ProjectStatus list's item.


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
PUT /api/v1/List/ProjectStatus/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 839,
    "Name": "Orn-Marvin",
    "ToolTip": "Consequuntur est nesciunt aut qui.",
    "Deleted": false,
    "Rank": 584,
    "Type": "et",
    "ColorBlock": 667,
    "IconHint": "id",
    "Selected": false,
    "LastChanged": "2020-10-15T10:30:33.131835+02:00",
    "ChildItems": [
      {
        "Id": 450,
        "Name": "Leannon LLC",
        "ToolTip": "Ut eum facilis rerum eum dolor et.",
        "Deleted": true,
        "Rank": 807,
        "Type": "porro",
        "ColorBlock": 111,
        "IconHint": "est",
        "Selected": false,
        "LastChanged": "2020-06-23T10:30:33.131835+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "assumenda",
        "StyleHint": "quia",
        "Hidden": false,
        "FullName": "Ena Cummerata"
      }
    ],
    "ExtraInfo": "nesciunt",
    "StyleHint": "distinctio",
    "Hidden": false,
    "FullName": "Ms. Aron Marisa Jast"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 663,
    "Name": "Treutel-Reilly",
    "ToolTip": "Delectus itaque voluptatem optio adipisci optio amet.",
    "Deleted": true,
    "Rank": 784,
    "Type": "vitae",
    "ColorBlock": 636,
    "IconHint": "dignissimos",
    "Selected": true,
    "LastChanged": "2017-10-11T10:30:33.131835+02:00",
    "ChildItems": [
      {
        "Id": 940,
        "Name": "Hilll LLC",
        "ToolTip": "Voluptates ut aut itaque itaque ducimus.",
        "Deleted": true,
        "Rank": 712,
        "Type": "architecto",
        "ColorBlock": 32,
        "IconHint": "porro",
        "Selected": true,
        "LastChanged": "2018-06-25T10:30:33.131835+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quia",
        "StyleHint": "voluptas",
        "Hidden": false,
        "FullName": "Ethan Kovacek",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 708
          }
        }
      }
    ],
    "ExtraInfo": "eaque",
    "StyleHint": "natus",
    "Hidden": true,
    "FullName": "Emile Hyatt",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 734
      }
    }
  }
]
```