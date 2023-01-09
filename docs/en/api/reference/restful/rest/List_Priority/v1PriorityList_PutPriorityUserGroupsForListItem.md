---
title: PUT List/Priority/Items/{id}/UserGroups
uid: v1PriorityList_PutPriorityUserGroupsForListItem
---

# PUT List/Priority/Items/{id}/UserGroups

```http
PUT /api/v1/List/Priority/Items/{itemId}/UserGroups
```

Saves user groups visible for the Priority list's item.


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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |

## Sample request

```http!
PUT /api/v1/List/Priority/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 619,
    "Name": "Gutkowski Group",
    "ToolTip": "Similique saepe.",
    "Deleted": true,
    "Rank": 73,
    "Type": "repellat",
    "ColorBlock": 714,
    "IconHint": "deleniti",
    "Selected": false,
    "LastChanged": "2016-09-19T17:37:40.1284959+02:00",
    "ChildItems": [
      {
        "Id": 718,
        "Name": "Dibbert Group",
        "ToolTip": "Libero adipisci sequi.",
        "Deleted": false,
        "Rank": 795,
        "Type": "vel",
        "ColorBlock": 668,
        "IconHint": "molestiae",
        "Selected": true,
        "LastChanged": "2007-05-15T17:37:40.1284959+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "ex",
        "StyleHint": "modi",
        "Hidden": false,
        "FullName": "Bella Aufderhar"
      }
    ],
    "ExtraInfo": "quaerat",
    "StyleHint": "quaerat",
    "Hidden": false,
    "FullName": "Sven Bailey"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 288,
    "Name": "Stehr-Nikolaus",
    "ToolTip": "Consequatur qui nesciunt voluptate explicabo reprehenderit.",
    "Deleted": false,
    "Rank": 163,
    "Type": "placeat",
    "ColorBlock": 819,
    "IconHint": "dicta",
    "Selected": false,
    "LastChanged": "1998-05-26T17:37:40.1295011+02:00",
    "ChildItems": [
      {
        "Id": 309,
        "Name": "Monahan-Stokes",
        "ToolTip": "Aperiam libero hic.",
        "Deleted": true,
        "Rank": 278,
        "Type": "et",
        "ColorBlock": 68,
        "IconHint": "vitae",
        "Selected": false,
        "LastChanged": "2012-06-22T17:37:40.1295011+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "asperiores",
        "StyleHint": "nesciunt",
        "Hidden": false,
        "FullName": "Yadira Brakus Sr.",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 824
          }
        }
      }
    ],
    "ExtraInfo": "et",
    "StyleHint": "quaerat",
    "Hidden": true,
    "FullName": "Scotty Koepp",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 633
      }
    }
  }
]
```