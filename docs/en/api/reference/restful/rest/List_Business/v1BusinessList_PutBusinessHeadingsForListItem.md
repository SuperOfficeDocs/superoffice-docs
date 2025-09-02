---
title: PUT List/Business/Items/{id}/Headings
uid: v1BusinessList_PutBusinessHeadingsForListItem
generated: true
content_type: reference
---

# PUT List/Business/Items/{id}/Headings

```http
PUT /api/v1/List/Business/Items/{itemId}/Headings
```

Saves headings for the Business list's item.


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
PUT /api/v1/List/Business/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 883,
    "Name": "Wisoky Group",
    "ToolTip": "Minus repellat.",
    "Deleted": true,
    "Rank": 1001,
    "Type": "et",
    "ColorBlock": 199,
    "IconHint": "impedit",
    "Selected": true,
    "LastChanged": "2011-05-03T03:47:00.5818006+02:00",
    "ChildItems": [
      {
        "Id": 325,
        "Name": "Bogisich, Vandervort and McGlynn",
        "ToolTip": "Molestiae est placeat similique reprehenderit vel blanditiis eveniet.",
        "Deleted": false,
        "Rank": 262,
        "Type": "et",
        "ColorBlock": 364,
        "IconHint": "quae",
        "Selected": false,
        "LastChanged": "2004-02-04T03:47:00.5818006+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quos",
        "StyleHint": "error",
        "Hidden": false,
        "FullName": "Dr. Brain Bahringer IV"
      }
    ],
    "ExtraInfo": "possimus",
    "StyleHint": "et",
    "Hidden": false,
    "FullName": "Jayda Geovanny Runolfsdottir DDS"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 812,
    "Name": "Gorczany, Bergnaum and Bernier",
    "ToolTip": "Iste similique dolor qui.",
    "Deleted": true,
    "Rank": 610,
    "Type": "rerum",
    "ColorBlock": 970,
    "IconHint": "ratione",
    "Selected": true,
    "LastChanged": "2021-04-03T03:47:00.5818006+02:00",
    "ChildItems": [
      {
        "Id": 506,
        "Name": "Hermiston, Crist and Ferry",
        "ToolTip": "Nostrum architecto dolor odit corrupti excepturi facere assumenda.",
        "Deleted": true,
        "Rank": 867,
        "Type": "alias",
        "ColorBlock": 948,
        "IconHint": "eos",
        "Selected": true,
        "LastChanged": "2009-09-11T03:47:00.5818006+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "eligendi",
        "StyleHint": "quos",
        "Hidden": false,
        "FullName": "Mr. Angelina Bauch",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 695
          }
        }
      }
    ],
    "ExtraInfo": "sit",
    "StyleHint": "sint",
    "Hidden": true,
    "FullName": "Stanford Welch",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 757
      }
    }
  }
]
```