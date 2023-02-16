---
title: PUT List/ProductType/Items/{id}/Headings
uid: v1ProductTypeList_PutProductTypeHeadingsForListItem
---

# PUT List/ProductType/Items/{id}/Headings

```http
PUT /api/v1/List/ProductType/Items/{itemId}/Headings
```

Saves headings for the ProductType list's item.


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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |

## Sample request

```http!
PUT /api/v1/List/ProductType/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 313,
    "Name": "Connelly, Lehner and Gorczany",
    "ToolTip": "Ad ut neque rem et fugit.",
    "Deleted": false,
    "Rank": 29,
    "Type": "omnis",
    "ColorBlock": 131,
    "IconHint": "corrupti",
    "Selected": true,
    "LastChanged": "2001-11-06T14:19:11.3836521+01:00",
    "ChildItems": [
      {
        "Id": 464,
        "Name": "Lockman, Dare and Abbott",
        "ToolTip": "Est soluta officia exercitationem ea officiis quidem ut.",
        "Deleted": false,
        "Rank": 317,
        "Type": "quos",
        "ColorBlock": 642,
        "IconHint": "cupiditate",
        "Selected": true,
        "LastChanged": "1999-07-08T14:19:11.3836521+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "dolores",
        "StyleHint": "iste",
        "Hidden": false,
        "FullName": "Destiny Sanford"
      }
    ],
    "ExtraInfo": "et",
    "StyleHint": "vitae",
    "Hidden": true,
    "FullName": "Geovanny Gleason"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 95,
    "Name": "Schinner Inc and Sons",
    "ToolTip": "Nihil quia dolor.",
    "Deleted": false,
    "Rank": 994,
    "Type": "accusamus",
    "ColorBlock": 495,
    "IconHint": "id",
    "Selected": true,
    "LastChanged": "2018-12-18T14:19:11.3836521+01:00",
    "ChildItems": [
      {
        "Id": 772,
        "Name": "Walsh Inc and Sons",
        "ToolTip": "Est ut amet.",
        "Deleted": false,
        "Rank": 310,
        "Type": "est",
        "ColorBlock": 31,
        "IconHint": "eos",
        "Selected": false,
        "LastChanged": "2020-03-21T14:19:11.3836521+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "omnis",
        "StyleHint": "aut",
        "Hidden": false,
        "FullName": "Mr. Clyde Reece O'Connell V",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 988
          }
        }
      }
    ],
    "ExtraInfo": "nesciunt",
    "StyleHint": "doloribus",
    "Hidden": false,
    "FullName": "Cody Johnson",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 255
      }
    }
  }
]
```