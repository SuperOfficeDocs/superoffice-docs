---
title: PUT List/MrMrs/Items/{id}/UserGroups
uid: v1MrMrsList_PutMrMrsUserGroupsForListItem
generated: true
---

# PUT List/MrMrs/Items/{id}/UserGroups

```http
PUT /api/v1/List/MrMrs/Items/{itemId}/UserGroups
```

Saves user groups visible for the MrMrs list's item.


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
PUT /api/v1/List/MrMrs/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 955,
    "Name": "Lowe LLC",
    "ToolTip": "Vel maiores ducimus deserunt quia quia eos.",
    "Deleted": false,
    "Rank": 862,
    "Type": "repellendus",
    "ColorBlock": 422,
    "IconHint": "fuga",
    "Selected": false,
    "LastChanged": "1998-09-17T11:16:14.5901626+02:00",
    "ChildItems": [
      {
        "Id": 119,
        "Name": "Fisher, Crist and Schaden",
        "ToolTip": "Voluptate sed.",
        "Deleted": false,
        "Rank": 85,
        "Type": "et",
        "ColorBlock": 684,
        "IconHint": "sed",
        "Selected": false,
        "LastChanged": "1997-07-17T11:16:14.5901626+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "consequatur",
        "StyleHint": "eveniet",
        "Hidden": true,
        "FullName": "Neoma Trantow"
      }
    ],
    "ExtraInfo": "eos",
    "StyleHint": "vel",
    "Hidden": true,
    "FullName": "Ms. Quinn Pouros Jr."
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 831,
    "Name": "Osinski LLC",
    "ToolTip": "Aspernatur nihil vel autem nulla optio ex accusantium.",
    "Deleted": false,
    "Rank": 651,
    "Type": "dolor",
    "ColorBlock": 797,
    "IconHint": "odit",
    "Selected": false,
    "LastChanged": "2015-09-16T11:16:14.5901626+02:00",
    "ChildItems": [
      {
        "Id": 706,
        "Name": "Walker-O'Conner",
        "ToolTip": "Sapiente tempore recusandae provident deserunt totam velit labore.",
        "Deleted": true,
        "Rank": 312,
        "Type": "numquam",
        "ColorBlock": 976,
        "IconHint": "tempora",
        "Selected": false,
        "LastChanged": "2018-03-26T11:16:14.5901626+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "ut",
        "StyleHint": "voluptatem",
        "Hidden": false,
        "FullName": "Liliane Nicola Senger Sr.",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 205
          }
        }
      }
    ],
    "ExtraInfo": "recusandae",
    "StyleHint": "et",
    "Hidden": true,
    "FullName": "Maudie Schowalter",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 675
      }
    }
  }
]
```