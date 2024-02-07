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
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 479,
    "Name": "DuBuque Group",
    "ToolTip": "Iure aspernatur vitae.",
    "Deleted": true,
    "Rank": 106,
    "Type": "et",
    "ColorBlock": 315,
    "IconHint": "dolor",
    "Selected": true,
    "LastChanged": "1999-02-15T16:55:30.8388284+01:00",
    "ChildItems": [
      {
        "Id": 458,
        "Name": "Carroll Group",
        "ToolTip": "Ea rerum voluptas ratione amet voluptatem voluptas perspiciatis.",
        "Deleted": true,
        "Rank": 751,
        "Type": "in",
        "ColorBlock": 653,
        "IconHint": "ea",
        "Selected": false,
        "LastChanged": "2019-11-16T16:55:30.8388284+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "illum",
        "StyleHint": "laboriosam",
        "Hidden": false,
        "FullName": "Reva Bechtelar"
      }
    ],
    "ExtraInfo": "eaque",
    "StyleHint": "minima",
    "Hidden": false,
    "FullName": "Mr. Sandrine Destany Klein"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 951,
    "Name": "Kirlin-Weimann",
    "ToolTip": "Qui mollitia aut dolorem placeat sapiente ut.",
    "Deleted": false,
    "Rank": 613,
    "Type": "qui",
    "ColorBlock": 156,
    "IconHint": "quidem",
    "Selected": false,
    "LastChanged": "2017-09-01T16:55:30.8398113+02:00",
    "ChildItems": [
      {
        "Id": 985,
        "Name": "Kling, Stracke and Mann",
        "ToolTip": "At vitae qui sapiente id necessitatibus harum.",
        "Deleted": true,
        "Rank": 603,
        "Type": "dolorem",
        "ColorBlock": 968,
        "IconHint": "impedit",
        "Selected": false,
        "LastChanged": "2021-04-22T16:55:30.8398113+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "illum",
        "StyleHint": "autem",
        "Hidden": false,
        "FullName": "Talon Geo Steuber DDS",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 584
          }
        }
      }
    ],
    "ExtraInfo": "distinctio",
    "StyleHint": "consequatur",
    "Hidden": true,
    "FullName": "Ms. Jermaine Abshire IV",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 228
      }
    }
  }
]
```