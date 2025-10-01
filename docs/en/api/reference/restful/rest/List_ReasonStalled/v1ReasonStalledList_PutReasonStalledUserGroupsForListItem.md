---
title: PUT List/ReasonStalled/Items/{id}/UserGroups
uid: v1ReasonStalledList_PutReasonStalledUserGroupsForListItem
generated: true
---

# PUT List/ReasonStalled/Items/{id}/UserGroups

```http
PUT /api/v1/List/ReasonStalled/Items/{itemId}/UserGroups
```

Saves user groups visible for the ReasonStalled list's item.


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
PUT /api/v1/List/ReasonStalled/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 596,
    "Name": "Frami-Reinger",
    "ToolTip": "Et aut.",
    "Deleted": false,
    "Rank": 12,
    "Type": "quasi",
    "ColorBlock": 69,
    "IconHint": "odit",
    "Selected": false,
    "LastChanged": "2024-07-30T03:45:29.2171623+02:00",
    "ChildItems": [
      {
        "Id": 977,
        "Name": "Hyatt, Dickens and Fahey",
        "ToolTip": "Soluta cumque molestias nihil nam sequi corporis.",
        "Deleted": true,
        "Rank": 589,
        "Type": "et",
        "ColorBlock": 928,
        "IconHint": "voluptatem",
        "Selected": false,
        "LastChanged": "2025-02-28T03:45:29.2171623+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "a",
        "StyleHint": "fuga",
        "Hidden": false,
        "FullName": "Chelsey Crona"
      }
    ],
    "ExtraInfo": "delectus",
    "StyleHint": "et",
    "Hidden": true,
    "FullName": "Brian Borer"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 291,
    "Name": "Grady LLC",
    "ToolTip": "Excepturi est error ipsam quasi.",
    "Deleted": false,
    "Rank": 322,
    "Type": "quaerat",
    "ColorBlock": 26,
    "IconHint": "repellendus",
    "Selected": false,
    "LastChanged": "2003-10-18T03:45:29.2171623+02:00",
    "ChildItems": [
      {
        "Id": 400,
        "Name": "Stiedemann, Langworth and Dach",
        "ToolTip": "Ut neque nemo sequi quas praesentium dolor et.",
        "Deleted": false,
        "Rank": 893,
        "Type": "enim",
        "ColorBlock": 633,
        "IconHint": "sunt",
        "Selected": false,
        "LastChanged": "2010-09-10T03:45:29.2171623+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "hic",
        "StyleHint": "culpa",
        "Hidden": false,
        "FullName": "Dr. Jessyca Flo Lemke Sr.",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 807
          }
        }
      }
    ],
    "ExtraInfo": "et",
    "StyleHint": "perferendis",
    "Hidden": true,
    "FullName": "Marlon Eugenia Stark DVM",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 715
      }
    }
  }
]
```