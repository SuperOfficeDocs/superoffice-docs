---
title: PUT List/Competitor/Items/{id}/UserGroups
uid: v1CompetitorList_PutCompetitorUserGroupsForListItem
generated: true
---

# PUT List/Competitor/Items/{id}/UserGroups

```http
PUT /api/v1/List/Competitor/Items/{itemId}/UserGroups
```

Saves user groups visible for the Competitor list's item.


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
PUT /api/v1/List/Competitor/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 370,
    "Name": "Hilpert, Cummerata and Bechtelar",
    "ToolTip": "Reprehenderit quia porro consequatur qui debitis reprehenderit nostrum.",
    "Deleted": false,
    "Rank": 783,
    "Type": "dolorem",
    "ColorBlock": 435,
    "IconHint": "maxime",
    "Selected": true,
    "LastChanged": "2001-07-13T10:30:32.8805387+02:00",
    "ChildItems": [
      {
        "Id": 803,
        "Name": "Waelchi-Kunde",
        "ToolTip": "Laboriosam et id quo praesentium consequatur.",
        "Deleted": false,
        "Rank": 887,
        "Type": "magni",
        "ColorBlock": 154,
        "IconHint": "nihil",
        "Selected": false,
        "LastChanged": "2015-04-30T10:30:32.8805387+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "aliquid",
        "StyleHint": "ducimus",
        "Hidden": false,
        "FullName": "Stephen Andre Barton IV"
      }
    ],
    "ExtraInfo": "ut",
    "StyleHint": "ut",
    "Hidden": false,
    "FullName": "Mr. Felicita Tina Wyman Jr."
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 953,
    "Name": "Goodwin LLC",
    "ToolTip": "Repellat aut architecto.",
    "Deleted": false,
    "Rank": 289,
    "Type": "iure",
    "ColorBlock": 377,
    "IconHint": "molestiae",
    "Selected": false,
    "LastChanged": "2000-03-14T10:30:32.8962093+01:00",
    "ChildItems": [
      {
        "Id": 725,
        "Name": "Metz LLC",
        "ToolTip": "Labore voluptates quia.",
        "Deleted": true,
        "Rank": 642,
        "Type": "repellat",
        "ColorBlock": 388,
        "IconHint": "quis",
        "Selected": false,
        "LastChanged": "2005-07-04T10:30:32.8962093+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "qui",
        "StyleHint": "delectus",
        "Hidden": false,
        "FullName": "Ms. London Nader I",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 346
          }
        }
      }
    ],
    "ExtraInfo": "est",
    "StyleHint": "culpa",
    "Hidden": false,
    "FullName": "Adrain Lorna Kiehn IV",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 547
      }
    }
  }
]
```