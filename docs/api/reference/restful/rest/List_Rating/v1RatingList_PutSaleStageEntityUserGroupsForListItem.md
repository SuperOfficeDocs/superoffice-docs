---
title: PUT List/Rating/Items/{id}/UserGroups
uid: v1RatingList_PutSaleStageEntityUserGroupsForListItem
---

# PUT List/Rating/Items/{id}/UserGroups

```http
PUT /api/v1/List/Rating/Items/{itemId}/UserGroups
```

Saves user groups visible for the SaleStageEntity list's item.


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

OK

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

## Sample request

```http!
PUT /api/v1/List/Rating/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 799,
    "Name": "Wilkinson-Bernier",
    "ToolTip": "Ab aut accusantium illo.",
    "Deleted": false,
    "Rank": 697,
    "Type": "rerum",
    "ColorBlock": 156,
    "IconHint": "ut",
    "Selected": true,
    "LastChanged": "2019-03-28T11:10:54.5349296+01:00",
    "ChildItems": [
      {
        "Id": 429,
        "Name": "Dickinson-Wisozk",
        "ToolTip": "Sed quia.",
        "Deleted": false,
        "Rank": 424,
        "Type": "voluptatem",
        "ColorBlock": 404,
        "IconHint": "et",
        "Selected": true,
        "LastChanged": "2013-11-27T11:10:54.5349296+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "natus",
        "StyleHint": "dolor",
        "Hidden": false,
        "FullName": "Gaston Wehner"
      }
    ],
    "ExtraInfo": "commodi",
    "StyleHint": "facere",
    "Hidden": false,
    "FullName": "Philip Maggio"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 786,
    "Name": "Stark, Johns and Hackett",
    "ToolTip": "Culpa molestias perspiciatis dicta enim.",
    "Deleted": true,
    "Rank": 573,
    "Type": "numquam",
    "ColorBlock": 286,
    "IconHint": "sint",
    "Selected": false,
    "LastChanged": "2021-02-19T11:10:54.5359304+01:00",
    "ChildItems": [
      {
        "Id": 378,
        "Name": "Hettinger Inc and Sons",
        "ToolTip": "Deserunt dolores ab fuga nam voluptas deleniti.",
        "Deleted": true,
        "Rank": 840,
        "Type": "qui",
        "ColorBlock": 236,
        "IconHint": "voluptatibus",
        "Selected": false,
        "LastChanged": "2008-06-07T11:10:54.5359304+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quasi",
        "StyleHint": "est",
        "Hidden": false,
        "FullName": "Clinton Grady",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 999
          }
        }
      }
    ],
    "ExtraInfo": "vel",
    "StyleHint": "minus",
    "Hidden": false,
    "FullName": "Prof. Lysanne Pierce Wyman II",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 187
      }
    }
  }
]
```