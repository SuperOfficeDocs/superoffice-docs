---
title: POST Agents/Contact/GetMyActiveContacts
uid: v1ContactAgent_GetMyActiveContacts
generated: true
content_type: reference
---

# POST Agents/Contact/GetMyActiveContacts

```http
POST /api/v1/Agents/Contact/GetMyActiveContacts
```

Returns the contacts where there has been activity since activityStartTime.


If activityStartTime is larger than the current date, all contacts with activity since last log-out are returned. The result set can be filtered by category and action type.
NsApiSlow threshold: 5000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetMyActiveContacts?$select=name,department,category/id
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

ActivityStartTime, ContactCategories, ActionType 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ActivityStartTime | String |  |
| ContactCategories | Array |  |
| ActionType | String |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 | Primary key |
| Department | string | Department |
| OrgNr | string | VAT number or similar |
| Name | string | Contact name |
| URL | string | URL address |
| AssociateFullName | string | The contact's owner |
| Action | string | The activity that has occured on this contact. |
| ActionTime | date-time | The time of the activity. If more than one activity has occured on the contact, the last activity time is shown. |
| Category | string | The contact category. |
| ActivityPersonName | string | The person that carried out the activity on the contact. |
| ActionId | int32 | Id of the last element an activity was found on. I.e. AppointmentId, ContactId, or PersonId |
| PersonId | int32 | The person id |
| ActivityPersonId | int32 | Id of the person causing the activity. |
| AssociateId | int32 | Our contact |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

[!include[sample request](../../samples/agent/request/v1ContactAgent_GetMyActiveContacts.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1ContactAgent_GetMyActiveContacts.md)]