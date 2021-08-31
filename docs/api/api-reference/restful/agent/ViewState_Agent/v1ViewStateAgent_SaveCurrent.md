---
title: SaveCurrent
id: v1ViewStateAgent_SaveCurrent
---

# SaveCurrent

```http
POST /api/v1/Agents/ViewState/SaveCurrent
```

Saving the current history item.

This history item is saved with Rank = 1, and all the remaining elements rank values are shifted one down. The list is maintained with the max lenght of the History list length preference.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/ViewState/SaveCurrent?$select=name,department,category/id
```


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

## Request Body: request  

Current 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Current |  | The usage history of the currently logged in user is represented as History objects. <para /> Carrier object for History. Services for the History Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IViewStateAgent">ViewState Agent</see>. |


## Response: object

The usage history of the currently logged in user is represented as History objects.



Carrier object for History.
Services for the History Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IViewStateAgent">ViewState Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| Rank | int32 | Sort order, indexed so it can used for sorting in the query |
| Id | int32 | Id of the history item, for instance a contact id. Represents the history table's RecordId field, if the item is based on a history table record |
| HistoryName | string | The name of the history list, for instance contact. Represents the history table's TableId field |
| HistoryId | int32 | Primary key |
| AssociateId | int32 | Owner of history list |
| Name | string | Name of the history item, for instance contact name |
| ItemInfo | string | Extra information on the history item, e.g. The Associate Type for an associate or other relevant info. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/ViewState/SaveCurrent
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "Current": {
    "Rank": 995,
    "Id": 536,
    "HistoryName": "Mohr-Rutherford",
    "HistoryId": 303,
    "AssociateId": 341,
    "Name": "Carter-Kautzer",
    "ItemInfo": "dicta"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Rank": 249,
  "Id": 426,
  "HistoryName": "Skiles, Stroman and Schneider",
  "HistoryId": 273,
  "AssociateId": 545,
  "Name": "Collins, Reilly and Marquardt",
  "ItemInfo": "explicabo",
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 759
    }
  }
}
```