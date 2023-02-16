---
title: PUT List/Country/Items/{id}/UserGroups
uid: v1CountryList_PutCountryUserGroupsForListItem
---

# PUT List/Country/Items/{id}/UserGroups

```http
PUT /api/v1/List/Country/Items/{itemId}/UserGroups
```

Saves user groups visible for the Country list's item.


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
PUT /api/v1/List/Country/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 889,
    "Name": "Langosh-Maggio",
    "ToolTip": "Earum repellendus.",
    "Deleted": true,
    "Rank": 81,
    "Type": "iure",
    "ColorBlock": 304,
    "IconHint": "omnis",
    "Selected": false,
    "LastChanged": "2000-04-29T14:19:11.1949684+02:00",
    "ChildItems": [
      {
        "Id": 840,
        "Name": "Frami-Jenkins",
        "ToolTip": "Quam repellat.",
        "Deleted": false,
        "Rank": 948,
        "Type": "laudantium",
        "ColorBlock": 966,
        "IconHint": "ipsum",
        "Selected": false,
        "LastChanged": "2007-09-21T14:19:11.1949684+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "molestiae",
        "StyleHint": "totam",
        "Hidden": false,
        "FullName": "Mrs. Dejuan Stamm"
      }
    ],
    "ExtraInfo": "et",
    "StyleHint": "officiis",
    "Hidden": false,
    "FullName": "Prof. Javonte Cole II"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 588,
    "Name": "Lynch, Wiegand and Bechtelar",
    "ToolTip": "Vel fuga voluptas.",
    "Deleted": false,
    "Rank": 335,
    "Type": "incidunt",
    "ColorBlock": 639,
    "IconHint": "facilis",
    "Selected": true,
    "LastChanged": "2005-01-24T14:19:11.1949684+01:00",
    "ChildItems": [
      {
        "Id": 885,
        "Name": "Hyatt, Corkery and Brown",
        "ToolTip": "Sit est.",
        "Deleted": false,
        "Rank": 332,
        "Type": "rerum",
        "ColorBlock": 979,
        "IconHint": "ut",
        "Selected": false,
        "LastChanged": "2005-03-25T14:19:11.1949684+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "non",
        "StyleHint": "quaerat",
        "Hidden": true,
        "FullName": "Amara Cassin",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 371
          }
        }
      }
    ],
    "ExtraInfo": "a",
    "StyleHint": "eum",
    "Hidden": true,
    "FullName": "Prof. Greyson Rutherford PhD",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 413
      }
    }
  }
]
```