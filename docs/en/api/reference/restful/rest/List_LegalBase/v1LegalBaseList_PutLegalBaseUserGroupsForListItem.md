---
title: PUT List/LegalBase/Items/{id}/UserGroups
uid: v1LegalBaseList_PutLegalBaseUserGroupsForListItem
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
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 733,
    "Name": "Jenkins-Jacobson",
    "ToolTip": "Autem eum vel earum labore rerum ratione.",
    "Deleted": false,
    "Rank": 123,
    "Type": "omnis",
    "ColorBlock": 511,
    "IconHint": "enim",
    "Selected": false,
    "LastChanged": "2006-02-21T15:29:31.2834822+01:00",
    "ChildItems": [
      {
        "Id": 500,
        "Name": "Smitham, Sauer and Rempel",
        "ToolTip": "Optio sunt maiores itaque.",
        "Deleted": false,
        "Rank": 644,
        "Type": "magni",
        "ColorBlock": 557,
        "IconHint": "maxime",
        "Selected": false,
        "LastChanged": "2002-10-06T15:29:31.2834822+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "exercitationem",
        "StyleHint": "molestiae",
        "Hidden": true,
        "FullName": "Juston Breitenberg"
      }
    ],
    "ExtraInfo": "eveniet",
    "StyleHint": "aspernatur",
    "Hidden": true,
    "FullName": "Kayleigh Hegmann"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 128,
    "Name": "Mueller, Heidenreich and Dibbert",
    "ToolTip": "Nostrum aut exercitationem ut corporis quos numquam.",
    "Deleted": false,
    "Rank": 181,
    "Type": "dolore",
    "ColorBlock": 477,
    "IconHint": "occaecati",
    "Selected": true,
    "LastChanged": "2012-12-26T15:29:31.2849868+01:00",
    "ChildItems": [
      {
        "Id": 301,
        "Name": "Nolan, Lang and Emmerich",
        "ToolTip": "Et consequatur at aut expedita.",
        "Deleted": false,
        "Rank": 314,
        "Type": "soluta",
        "ColorBlock": 800,
        "IconHint": "et",
        "Selected": false,
        "LastChanged": "2002-09-23T15:29:31.2849868+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "alias",
        "StyleHint": "et",
        "Hidden": false,
        "FullName": "Johnpaul Foster Davis III",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 285
          }
        }
      }
    ],
    "ExtraInfo": "nostrum",
    "StyleHint": "vitae",
    "Hidden": true,
    "FullName": "Ms. Jensen Rupert Rohan MD",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 702
      }
    }
  }
]
```