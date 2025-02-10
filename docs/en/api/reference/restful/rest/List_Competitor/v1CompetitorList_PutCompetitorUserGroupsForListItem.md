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
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 614,
    "Name": "Herzog, Volkman and Mosciski",
    "ToolTip": "Occaecati ex unde illo officia quia nisi distinctio.",
    "Deleted": false,
    "Rank": 514,
    "Type": "sint",
    "ColorBlock": 702,
    "IconHint": "impedit",
    "Selected": false,
    "LastChanged": "2002-10-09T12:01:33.448849+02:00",
    "ChildItems": [
      {
        "Id": 823,
        "Name": "Thompson, Grant and Douglas",
        "ToolTip": "Quia ab quo omnis sit aut.",
        "Deleted": false,
        "Rank": 74,
        "Type": "accusamus",
        "ColorBlock": 739,
        "IconHint": "delectus",
        "Selected": false,
        "LastChanged": "2010-11-28T12:01:33.448849+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "possimus",
        "StyleHint": "dolore",
        "Hidden": false,
        "FullName": "Malika Flatley"
      }
    ],
    "ExtraInfo": "id",
    "StyleHint": "quos",
    "Hidden": false,
    "FullName": "Skylar Evangeline Kilback I"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 669,
    "Name": "Oberbrunner-Simonis",
    "ToolTip": "Ipsum eveniet sed.",
    "Deleted": false,
    "Rank": 855,
    "Type": "rerum",
    "ColorBlock": 98,
    "IconHint": "ut",
    "Selected": false,
    "LastChanged": "2019-01-06T12:01:33.448849+01:00",
    "ChildItems": [
      {
        "Id": 283,
        "Name": "Rohan-Kirlin",
        "ToolTip": "Earum quia.",
        "Deleted": false,
        "Rank": 957,
        "Type": "molestias",
        "ColorBlock": 682,
        "IconHint": "odio",
        "Selected": false,
        "LastChanged": "2012-03-09T12:01:33.448849+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "vel",
        "StyleHint": "ut",
        "Hidden": false,
        "FullName": "Emil Sipes",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 813
          }
        }
      }
    ],
    "ExtraInfo": "qui",
    "StyleHint": "enim",
    "Hidden": false,
    "FullName": "Prof. Cole Ferry",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 424
      }
    }
  }
]
```