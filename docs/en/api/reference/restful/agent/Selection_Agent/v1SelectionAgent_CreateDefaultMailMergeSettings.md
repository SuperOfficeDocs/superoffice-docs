---
title: POST Agents/Selection/CreateDefaultMailMergeSettings
uid: v1SelectionAgent_CreateDefaultMailMergeSettings
---

# POST Agents/Selection/CreateDefaultMailMergeSettings

```http
POST /api/v1/Agents/Selection/CreateDefaultMailMergeSettings
```

Set default values into a new MailMergeSettings.


NetServer calculates default values on the entity, which is required when creating/storing a new instance







## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: MailMergeSettings

| Property Name | Type |  Description |
|----------------|------|--------------|
| SelectionId | int32 | Identity of selection to use as source for recipients. |
| DocumentId | int32 | Identity of document to be used as merge draft. |
| MailMergeDeliveryType | string | How the merged document is delivered to the recipients. |
| CustomAttention | string | Custom value for attention. |
| AlwaysUseCustomAttention | bool | Should custom attention always be used? If false, only use custom attention where there is no default. |
| SaveDocument | bool | Should we save a reference to the merge document on each recipient. |
| CustomMailBody | string | If specified, use this value as default mail body. |
| TaskEntity | MailMergeTask | If specified, register a task on recipients using properties from this object. |
| AddCompanyInterest | int32 | Add this company interest to each company recipient. |
| AddPersonInterest | int32 | Add this person interest to each person recipient. |
| RemoveCompanyInterest | int32 | Remove this company interest on each company recipient. |
| RemovePersonInterest | int32 | Remove this person interest on each person recipient. |
| IncludeNoMailingsRecipient | bool | Include recipients that are marked with NoMailings |
| TestOnly | bool | If true, do the merge task, but use current user as target, instead of selection members |
| ProjectId | int32 | Identity of project to use as source for recipients. |
| IncludeRetiredRecipients | bool | Include recipients that are marked as retired |
| IncludeStoppedRecipients | bool | Include recipients that are marked with stop |
| CustomMailSubject | string | If specified, use this value as default mail subject. |
| ExtraInfo | string | Used to store additional information for the delivery systems. |
| Synchronous | bool |  |
| IsTemporarySelection | bool | If true, the selection is a temporary selection that can be deleted later. |
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Selection/CreateDefaultMailMergeSettings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SelectionId": 870,
  "DocumentId": 734,
  "MailMergeDeliveryType": "BestFit",
  "CustomAttention": "rerum",
  "AlwaysUseCustomAttention": false,
  "SaveDocument": true,
  "CustomMailBody": "sint",
  "TaskEntity": null,
  "AddCompanyInterest": 140,
  "AddPersonInterest": 960,
  "RemoveCompanyInterest": 324,
  "RemovePersonInterest": 67,
  "IncludeNoMailingsRecipient": false,
  "TestOnly": true,
  "ProjectId": 743,
  "IncludeRetiredRecipients": true,
  "IncludeStoppedRecipients": false,
  "CustomMailSubject": "et",
  "ExtraInfo": "ex",
  "Synchronous": false,
  "IsTemporarySelection": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 624
    }
  }
}
```