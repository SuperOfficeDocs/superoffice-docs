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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |

## Sample request

```http!
PUT /api/v1/List/LegalBase/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 957,
    "Name": "Stanton-Botsford",
    "ToolTip": "Eius omnis similique esse impedit aliquam.",
    "Deleted": false,
    "Rank": 580,
    "Type": "ipsam",
    "ColorBlock": 404,
    "IconHint": "iste",
    "Selected": true,
    "LastChanged": "2021-11-10T17:37:40.0375003+01:00",
    "ChildItems": [
      {
        "Id": 956,
        "Name": "Vandervort Inc and Sons",
        "ToolTip": "Maiores quia ea magni ipsam.",
        "Deleted": true,
        "Rank": 168,
        "Type": "et",
        "ColorBlock": 995,
        "IconHint": "mollitia",
        "Selected": false,
        "LastChanged": "1997-02-07T17:37:40.0375003+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "fuga",
        "StyleHint": "qui",
        "Hidden": false,
        "FullName": "Mr. Curtis Buckridge IV"
      }
    ],
    "ExtraInfo": "illum",
    "StyleHint": "et",
    "Hidden": false,
    "FullName": "Yasmine Hessel"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 180,
    "Name": "Jacobi-Leuschke",
    "ToolTip": "Et quos.",
    "Deleted": true,
    "Rank": 474,
    "Type": "ea",
    "ColorBlock": 1001,
    "IconHint": "odit",
    "Selected": false,
    "LastChanged": "2021-11-23T17:37:40.0385033+01:00",
    "ChildItems": [
      {
        "Id": 222,
        "Name": "Pollich Inc and Sons",
        "ToolTip": "Enim enim et exercitationem delectus eos.",
        "Deleted": false,
        "Rank": 871,
        "Type": "cum",
        "ColorBlock": 368,
        "IconHint": "in",
        "Selected": false,
        "LastChanged": "2011-05-23T17:37:40.0395012+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "est",
        "StyleHint": "vitae",
        "Hidden": true,
        "FullName": "Prof. Alayna Maybelle Schinner",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 416
          }
        }
      }
    ],
    "ExtraInfo": "iste",
    "StyleHint": "fuga",
    "Hidden": false,
    "FullName": "Mrs. Jeramy Doyle Kessler V",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 961
      }
    }
  }
]
```