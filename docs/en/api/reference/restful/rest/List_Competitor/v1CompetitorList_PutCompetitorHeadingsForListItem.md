---
title: PUT List/Competitor/Items/{id}/Headings
uid: v1CompetitorList_PutCompetitorHeadingsForListItem
generated: true
---

# PUT List/Competitor/Items/{id}/Headings

```http
PUT /api/v1/List/Competitor/Items/{itemId}/Headings
```

Saves headings for the Competitor list's item.


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
PUT /api/v1/List/Competitor/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 713,
    "Name": "Keebler-Hettinger",
    "ToolTip": "Debitis mollitia fuga illum iste sunt et.",
    "Deleted": true,
    "Rank": 950,
    "Type": "est",
    "ColorBlock": 999,
    "IconHint": "cumque",
    "Selected": false,
    "LastChanged": "2000-10-26T16:00:48.8989756+02:00",
    "ChildItems": [
      {
        "Id": 938,
        "Name": "Quigley LLC",
        "ToolTip": "Quam perferendis cumque repellat earum quasi nam et.",
        "Deleted": false,
        "Rank": 274,
        "Type": "sunt",
        "ColorBlock": 404,
        "IconHint": "pariatur",
        "Selected": true,
        "LastChanged": "2003-12-29T16:00:48.8989756+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "totam",
        "StyleHint": "deleniti",
        "Hidden": true,
        "FullName": "Dr. Ricardo Rippin Sr."
      }
    ],
    "ExtraInfo": "quis",
    "StyleHint": "neque",
    "Hidden": true,
    "FullName": "Kurtis Cristian Kihn V"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 552,
    "Name": "Robel-Dickens",
    "ToolTip": "Vero magni illum vel.",
    "Deleted": false,
    "Rank": 307,
    "Type": "ad",
    "ColorBlock": 113,
    "IconHint": "laborum",
    "Selected": false,
    "LastChanged": "2019-04-22T16:00:48.8989756+02:00",
    "ChildItems": [
      {
        "Id": 206,
        "Name": "Reynolds Group",
        "ToolTip": "Quis enim voluptas.",
        "Deleted": false,
        "Rank": 932,
        "Type": "aut",
        "ColorBlock": 990,
        "IconHint": "nihil",
        "Selected": false,
        "LastChanged": "2001-01-18T16:00:48.8989756+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "voluptas",
        "StyleHint": "et",
        "Hidden": false,
        "FullName": "Isabel Walsh",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 367
          }
        }
      }
    ],
    "ExtraInfo": "cum",
    "StyleHint": "laboriosam",
    "Hidden": true,
    "FullName": "Coralie Fahey",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 736
      }
    }
  }
]
```