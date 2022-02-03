---
title: PUT List/ProjectStatus/Items/{id}/Headings
id: v1ProjectStatusList_PutProjectStatusHeadingsForListItem
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
PUT /api/v1/List/ProjectStatus/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 678,
    "Name": "Gusikowski LLC",
    "ToolTip": "Sit qui natus.",
    "Deleted": true,
    "Rank": 801,
    "Type": "sed",
    "ColorBlock": 816,
    "IconHint": "commodi",
    "Selected": true,
    "LastChanged": "2004-07-23T18:25:52.0930209+02:00",
    "ChildItems": [
      {
        "Id": 371,
        "Name": "Lynch, Luettgen and Stiedemann",
        "ToolTip": "Omnis dolor id facere quis quam.",
        "Deleted": true,
        "Rank": 539,
        "Type": "facere",
        "ColorBlock": 176,
        "IconHint": "voluptas",
        "Selected": true,
        "LastChanged": "2014-12-30T18:25:52.0930209+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quibusdam",
        "StyleHint": "in",
        "Hidden": false,
        "FullName": "Jalyn Haag IV"
      }
    ],
    "ExtraInfo": "debitis",
    "StyleHint": "fuga",
    "Hidden": true,
    "FullName": "Maximillian Trantow"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 735,
    "Name": "Ward-Kertzmann",
    "ToolTip": "Commodi quis.",
    "Deleted": false,
    "Rank": 424,
    "Type": "mollitia",
    "ColorBlock": 580,
    "IconHint": "aliquid",
    "Selected": true,
    "LastChanged": "2017-02-18T18:25:52.0950201+01:00",
    "ChildItems": [
      {
        "Id": 212,
        "Name": "Homenick-Bauch",
        "ToolTip": "Praesentium consequatur sit inventore atque expedita.",
        "Deleted": true,
        "Rank": 446,
        "Type": "necessitatibus",
        "ColorBlock": 189,
        "IconHint": "tempore",
        "Selected": false,
        "LastChanged": "2007-05-18T18:25:52.0950201+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "voluptas",
        "StyleHint": "aut",
        "Hidden": false,
        "FullName": "Celia Hickle",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 11
          }
        }
      }
    ],
    "ExtraInfo": "repudiandae",
    "StyleHint": "alias",
    "Hidden": true,
    "FullName": "Pattie Goodwin",
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
        "FieldLength": 282
      }
    }
  }
]
```