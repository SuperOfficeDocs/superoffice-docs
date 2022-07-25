---
title: PUT List/ProjectType/Items/{id}/Headings
id: v1ProjectTypeList_PutProjectTypeHeadingsForListItem
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
PUT /api/v1/List/ProjectType/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 276,
    "Name": "Torp Group",
    "ToolTip": "Et ullam vel.",
    "Deleted": true,
    "Rank": 614,
    "Type": "esse",
    "ColorBlock": 252,
    "IconHint": "et",
    "Selected": true,
    "LastChanged": "2002-11-07T18:25:52.1080185+01:00",
    "ChildItems": [
      {
        "Id": 466,
        "Name": "Schultz-Boyer",
        "ToolTip": "Iure ut facere voluptate quod.",
        "Deleted": false,
        "Rank": 649,
        "Type": "in",
        "ColorBlock": 253,
        "IconHint": "quisquam",
        "Selected": true,
        "LastChanged": "2004-03-26T18:25:52.1080185+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "rerum",
        "StyleHint": "quia",
        "Hidden": false,
        "FullName": "Mrs. Lon Balistreri"
      }
    ],
    "ExtraInfo": "quia",
    "StyleHint": "tempore",
    "Hidden": true,
    "FullName": "Hillard Reilly"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 599,
    "Name": "Prosacco, Flatley and Rau",
    "ToolTip": "Vero est.",
    "Deleted": false,
    "Rank": 396,
    "Type": "fuga",
    "ColorBlock": 662,
    "IconHint": "fugit",
    "Selected": false,
    "LastChanged": "2012-08-26T18:25:52.1090197+02:00",
    "ChildItems": [
      {
        "Id": 460,
        "Name": "Pollich-Denesik",
        "ToolTip": "Non molestiae sit.",
        "Deleted": true,
        "Rank": 857,
        "Type": "quis",
        "ColorBlock": 963,
        "IconHint": "dolorum",
        "Selected": true,
        "LastChanged": "2002-12-15T18:25:52.1100188+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "sit",
        "StyleHint": "quia",
        "Hidden": true,
        "FullName": "Myah Hagenes",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 164
          }
        }
      }
    ],
    "ExtraInfo": "est",
    "StyleHint": "molestias",
    "Hidden": false,
    "FullName": "Justine Sipes",
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
        "FieldLength": 456
      }
    }
  }
]
```
