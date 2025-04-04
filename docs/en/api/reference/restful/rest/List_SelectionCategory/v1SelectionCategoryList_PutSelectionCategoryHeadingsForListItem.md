---
title: PUT List/SelectionCategory/Items/{id}/Headings
uid: v1SelectionCategoryList_PutSelectionCategoryHeadingsForListItem
generated: true
---

# PUT List/SelectionCategory/Items/{id}/Headings

```http
PUT /api/v1/List/SelectionCategory/Items/{itemId}/Headings
```

Saves headings for the SelectionCategory list's item.


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
PUT /api/v1/List/SelectionCategory/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 862,
    "Name": "Nitzsche LLC",
    "ToolTip": "Autem et exercitationem voluptatum quia excepturi velit ut.",
    "Deleted": false,
    "Rank": 440,
    "Type": "placeat",
    "ColorBlock": 215,
    "IconHint": "quod",
    "Selected": true,
    "LastChanged": "2011-08-06T13:14:10.0879174+02:00",
    "ChildItems": [
      {
        "Id": 833,
        "Name": "Hand-Lang",
        "ToolTip": "Sit ut dolorem et est id assumenda nesciunt.",
        "Deleted": false,
        "Rank": 634,
        "Type": "vel",
        "ColorBlock": 614,
        "IconHint": "qui",
        "Selected": false,
        "LastChanged": "2007-05-29T13:14:10.0879174+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "reiciendis",
        "StyleHint": "ut",
        "Hidden": false,
        "FullName": "Dr. Claudie Layne Dickens DVM"
      }
    ],
    "ExtraInfo": "magnam",
    "StyleHint": "quia",
    "Hidden": true,
    "FullName": "Ms. Derick Will MD"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 936,
    "Name": "Spinka-Rath",
    "ToolTip": "At hic sapiente porro.",
    "Deleted": true,
    "Rank": 860,
    "Type": "aut",
    "ColorBlock": 687,
    "IconHint": "quia",
    "Selected": false,
    "LastChanged": "2012-10-09T13:14:10.0879174+02:00",
    "ChildItems": [
      {
        "Id": 57,
        "Name": "Senger, Sawayn and Skiles",
        "ToolTip": "Id eius impedit et.",
        "Deleted": false,
        "Rank": 879,
        "Type": "tempore",
        "ColorBlock": 999,
        "IconHint": "nulla",
        "Selected": true,
        "LastChanged": "2006-03-18T13:14:10.0879174+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "impedit",
        "StyleHint": "repellat",
        "Hidden": false,
        "FullName": "Dr. Suzanne Crooks",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 926
          }
        }
      }
    ],
    "ExtraInfo": "tenetur",
    "StyleHint": "est",
    "Hidden": true,
    "FullName": "Reynold Bergstrom",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 279
      }
    }
  }
]
```