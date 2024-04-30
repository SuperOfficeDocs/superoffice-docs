---
title: PUT List/LegalBase/Items/{id}/Headings
uid: v1LegalBaseList_PutLegalBaseHeadingsForListItem
generated: true
---

# PUT List/LegalBase/Items/{id}/Headings

```http
PUT /api/v1/List/LegalBase/Items/{itemId}/Headings
```

Saves headings for the LegalBase list's item.


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
PUT /api/v1/List/LegalBase/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 535,
    "Name": "Little-Schuppe",
    "ToolTip": "Quibusdam sed.",
    "Deleted": false,
    "Rank": 857,
    "Type": "magni",
    "ColorBlock": 163,
    "IconHint": "aliquid",
    "Selected": true,
    "LastChanged": "2006-07-13T11:16:14.5901626+02:00",
    "ChildItems": [
      {
        "Id": 910,
        "Name": "Hermann Inc and Sons",
        "ToolTip": "Eius dicta.",
        "Deleted": false,
        "Rank": 908,
        "Type": "eligendi",
        "ColorBlock": 92,
        "IconHint": "est",
        "Selected": true,
        "LastChanged": "1999-07-31T11:16:14.5901626+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quisquam",
        "StyleHint": "eius",
        "Hidden": false,
        "FullName": "Thad Kohler"
      }
    ],
    "ExtraInfo": "voluptatum",
    "StyleHint": "iure",
    "Hidden": true,
    "FullName": "Prof. Icie Williamson"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 824,
    "Name": "Kub Inc and Sons",
    "ToolTip": "Amet ut explicabo est cupiditate.",
    "Deleted": true,
    "Rank": 595,
    "Type": "aut",
    "ColorBlock": 718,
    "IconHint": "est",
    "Selected": false,
    "LastChanged": "2012-06-17T11:16:14.5901626+02:00",
    "ChildItems": [
      {
        "Id": 722,
        "Name": "Schmeler-Christiansen",
        "ToolTip": "Ipsa saepe.",
        "Deleted": false,
        "Rank": 960,
        "Type": "maxime",
        "ColorBlock": 475,
        "IconHint": "officia",
        "Selected": false,
        "LastChanged": "2005-03-09T11:16:14.5901626+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "sunt",
        "StyleHint": "alias",
        "Hidden": false,
        "FullName": "Tierra Ratke",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 387
          }
        }
      }
    ],
    "ExtraInfo": "voluptas",
    "StyleHint": "quam",
    "Hidden": false,
    "FullName": "Kenton Major Bernier PhD",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 889
      }
    }
  }
]
```