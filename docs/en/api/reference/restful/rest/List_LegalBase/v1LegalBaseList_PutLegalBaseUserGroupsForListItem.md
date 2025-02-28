---
title: PUT List/LegalBase/Items/{id}/UserGroups
uid: v1LegalBaseList_PutLegalBaseUserGroupsForListItem
generated: true
---

# PUT List/LegalBase/Items/{id}/UserGroups

```http
PUT /api/v1/List/LegalBase/Items/{itemId}/UserGroups
```

Saves user groups visible for the LegalBase list's item.


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
PUT /api/v1/List/LegalBase/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 818,
    "Name": "Goodwin Group",
    "ToolTip": "Voluptatum qui eaque modi ad aut iure.",
    "Deleted": true,
    "Rank": 815,
    "Type": "qui",
    "ColorBlock": 88,
    "IconHint": "ut",
    "Selected": false,
    "LastChanged": "1999-01-08T12:01:33.5269792+01:00",
    "ChildItems": [
      {
        "Id": 750,
        "Name": "Wyman, Hintz and Brakus",
        "ToolTip": "Ipsum omnis dolore placeat distinctio accusamus.",
        "Deleted": false,
        "Rank": 261,
        "Type": "eligendi",
        "ColorBlock": 668,
        "IconHint": "dicta",
        "Selected": true,
        "LastChanged": "1999-03-16T12:01:33.5269792+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "sapiente",
        "StyleHint": "occaecati",
        "Hidden": false,
        "FullName": "Mr. Novella Sean Haley PhD"
      }
    ],
    "ExtraInfo": "sint",
    "StyleHint": "neque",
    "Hidden": false,
    "FullName": "Mr. Clay Fay Maggio II"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 317,
    "Name": "Bayer Inc and Sons",
    "ToolTip": "Quidem itaque dicta sapiente quis ut.",
    "Deleted": false,
    "Rank": 918,
    "Type": "tempore",
    "ColorBlock": 704,
    "IconHint": "voluptatibus",
    "Selected": false,
    "LastChanged": "2003-12-22T12:01:33.5269792+01:00",
    "ChildItems": [
      {
        "Id": 726,
        "Name": "Huels-Reynolds",
        "ToolTip": "Porro facere eum et.",
        "Deleted": false,
        "Rank": 661,
        "Type": "ut",
        "ColorBlock": 666,
        "IconHint": "exercitationem",
        "Selected": false,
        "LastChanged": "2018-04-03T12:01:33.5269792+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "natus",
        "StyleHint": "eum",
        "Hidden": false,
        "FullName": "Bailey Pollich PhD",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 319
          }
        }
      }
    ],
    "ExtraInfo": "exercitationem",
    "StyleHint": "quo",
    "Hidden": true,
    "FullName": "Bailee Strosin",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 566
      }
    }
  }
]
```