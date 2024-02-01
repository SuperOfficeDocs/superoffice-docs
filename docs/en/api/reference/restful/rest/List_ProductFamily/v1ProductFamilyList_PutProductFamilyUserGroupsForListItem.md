---
title: PUT List/ProductFamily/Items/{id}/UserGroups
uid: v1ProductFamilyList_PutProductFamilyUserGroupsForListItem
generated: true
---

# PUT List/ProductFamily/Items/{id}/UserGroups

```http
PUT /api/v1/List/ProductFamily/Items/{itemId}/UserGroups
```

Saves user groups visible for the ProductFamily list's item.


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
PUT /api/v1/List/ProductFamily/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 639,
    "Name": "DuBuque, Braun and Russel",
    "ToolTip": "Occaecati ex explicabo iste rem doloribus voluptatem.",
    "Deleted": false,
    "Rank": 379,
    "Type": "tempore",
    "ColorBlock": 353,
    "IconHint": "libero",
    "Selected": false,
    "LastChanged": "2017-10-01T23:04:05.6279954+02:00",
    "ChildItems": [
      {
        "Id": 774,
        "Name": "Becker Inc and Sons",
        "ToolTip": "Iste sapiente.",
        "Deleted": false,
        "Rank": 688,
        "Type": "laboriosam",
        "ColorBlock": 392,
        "IconHint": "sed",
        "Selected": false,
        "LastChanged": "2013-04-28T23:04:05.6284977+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "et",
        "StyleHint": "doloribus",
        "Hidden": true,
        "FullName": "Evalyn Kulas"
      }
    ],
    "ExtraInfo": "alias",
    "StyleHint": "rerum",
    "Hidden": true,
    "FullName": "Dr. Joy Kaitlyn Hammes"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 613,
    "Name": "Keeling, Powlowski and Dare",
    "ToolTip": "Et a et et animi ut suscipit.",
    "Deleted": false,
    "Rank": 278,
    "Type": "similique",
    "ColorBlock": 577,
    "IconHint": "cum",
    "Selected": false,
    "LastChanged": "2000-08-12T23:04:05.6300006+02:00",
    "ChildItems": [
      {
        "Id": 967,
        "Name": "Hackett Group",
        "ToolTip": "Omnis ea sequi et.",
        "Deleted": true,
        "Rank": 638,
        "Type": "veniam",
        "ColorBlock": 77,
        "IconHint": "autem",
        "Selected": false,
        "LastChanged": "2019-05-31T23:04:05.6300006+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "qui",
        "StyleHint": "assumenda",
        "Hidden": false,
        "FullName": "Miss Kiara Turcotte",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 834
          }
        }
      }
    ],
    "ExtraInfo": "et",
    "StyleHint": "vero",
    "Hidden": false,
    "FullName": "Collin Rosenbaum Jr.",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 650
      }
    }
  }
]
```