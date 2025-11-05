---
title: PUT List/ReasonStalled/Items/{id}/UserGroups
uid: v1ReasonStalledList_PutReasonStalledUserGroupsForListItem
generated: true
content_type: reference
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
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 985,
    "Name": "Ortiz-Lind",
    "ToolTip": "Aliquam rem voluptatem enim nisi.",
    "Deleted": false,
    "Rank": 28,
    "Type": "neque",
    "ColorBlock": 544,
    "IconHint": "deserunt",
    "Selected": false,
    "LastChanged": "2005-01-05T02:30:53.4286352+01:00",
    "ChildItems": [
      {
        "Id": 76,
        "Name": "Lynch, Cormier and Ruecker",
        "ToolTip": "Totam eum ut.",
        "Deleted": false,
        "Rank": 149,
        "Type": "quas",
        "ColorBlock": 416,
        "IconHint": "dolor",
        "Selected": false,
        "LastChanged": "2006-07-03T02:30:53.4286352+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "odio",
        "StyleHint": "officiis",
        "Hidden": false,
        "FullName": "Miss Lucinda Satterfield V"
      }
    ],
    "ExtraInfo": "voluptatem",
    "StyleHint": "perspiciatis",
    "Hidden": false,
    "FullName": "Lue Hammes"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 561,
    "Name": "Labadie, Rice and Kerluke",
    "ToolTip": "Aliquam vel.",
    "Deleted": true,
    "Rank": 731,
    "Type": "ea",
    "ColorBlock": 752,
    "IconHint": "ipsam",
    "Selected": false,
    "LastChanged": "2023-06-22T02:30:53.4286352+02:00",
    "ChildItems": [
      {
        "Id": 459,
        "Name": "Lehner, Huels and Smitham",
        "ToolTip": "Mollitia ut alias ipsam reiciendis est atque sint.",
        "Deleted": true,
        "Rank": 237,
        "Type": "sit",
        "ColorBlock": 975,
        "IconHint": "consequatur",
        "Selected": false,
        "LastChanged": "2008-12-31T02:30:53.4286352+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quis",
        "StyleHint": "et",
        "Hidden": false,
        "FullName": "Mr. Lilliana Calista Paucek IV",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 385
          }
        }
      }
    ],
    "ExtraInfo": "vitae",
    "StyleHint": "veniam",
    "Hidden": false,
    "FullName": "Precious Hailee Armstrong MD",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 179
      }
    }
  }
]
```