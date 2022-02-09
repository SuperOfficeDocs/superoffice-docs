---
title: PUT List/ConsentSource/Items/{id}/UserGroups
id: v1ConsentSourceList_PutConsentSourceUserGroupsForListItem
---

# PUT List/ConsentSource/Items/{id}/UserGroups

```http
PUT /api/v1/List/ConsentSource/Items/{itemId}/UserGroups
```

Saves user groups visible for the ConsentSource list's item.

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


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
PUT /api/v1/List/ConsentSource/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 545,
    "Name": "Marquardt, Walker and Reichert",
    "ToolTip": "Officiis in fugit veritatis quisquam omnis mollitia.",
    "Deleted": true,
    "Rank": 458,
    "Type": "delectus",
    "ColorBlock": 620,
    "IconHint": "nam",
    "Selected": true,
    "LastChanged": "2016-09-06T18:25:51.7333204+02:00",
    "ChildItems": [
      {
        "Id": 490,
        "Name": "Wilderman Group",
        "ToolTip": "Saepe sit eveniet culpa velit qui dolore.",
        "Deleted": false,
        "Rank": 235,
        "Type": "ad",
        "ColorBlock": 442,
        "IconHint": "officia",
        "Selected": true,
        "LastChanged": "2013-10-15T18:25:51.7333204+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "reiciendis",
        "StyleHint": "dolore",
        "Hidden": false,
        "FullName": "Mallory Klocko"
      }
    ],
    "ExtraInfo": "eum",
    "StyleHint": "amet",
    "Hidden": true,
    "FullName": "Elwyn Witting"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 395,
    "Name": "Howell, Lind and Parker",
    "ToolTip": "Similique illum tenetur dolorem.",
    "Deleted": true,
    "Rank": 773,
    "Type": "dignissimos",
    "ColorBlock": 236,
    "IconHint": "voluptatem",
    "Selected": true,
    "LastChanged": "2005-08-16T18:25:51.7353178+02:00",
    "ChildItems": [
      {
        "Id": 617,
        "Name": "Turner, Eichmann and Ward",
        "ToolTip": "Consequatur nobis mollitia exercitationem facere.",
        "Deleted": true,
        "Rank": 648,
        "Type": "ad",
        "ColorBlock": 222,
        "IconHint": "vel",
        "Selected": true,
        "LastChanged": "2016-04-28T18:25:51.7353178+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "aut",
        "StyleHint": "ut",
        "Hidden": true,
        "FullName": "Floyd Hammes IV",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": "scale open-source initiatives"
            },
            "FieldType": "System.String",
            "FieldLength": 380
          }
        }
      }
    ],
    "ExtraInfo": "est",
    "StyleHint": "aperiam",
    "Hidden": true,
    "FullName": "Walter Larson",
    "TableRight": {
      "Mask": "Delete",
      "Reason": ""
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "empower one-to-one users"
        },
        "FieldType": "System.Int32",
        "FieldLength": 876
      }
    }
  }
]
```