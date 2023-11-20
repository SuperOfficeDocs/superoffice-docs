---
title: POST Agents/Selection/CreateDefaultMailMergeTask
uid: v1SelectionAgent_CreateDefaultMailMergeTask
generated: true
---

# POST Agents/Selection/CreateDefaultMailMergeTask

```http
POST /api/v1/Agents/Selection/CreateDefaultMailMergeTask
```

Set default values into a new MailMergeTask.


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

### Response body: MailMergeTask

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProjectId | int32 | Project identity to set on task |
| TypeId | int32 | Type identity to set on task |
| StartDate | date-time | When the task should start |
| Duration | int32 | Duration of task |
| Description | string | Text describing task |
| PriorityId | int32 | Priority of task |
| VisibleFor | VisibleFor | Who the task should be visible for |
| Completed | string | Completed status for task |
| OwnerAssociateId | int32 | Associate identity of who should be set as owner of the task.  If value is 0, the recipient owner(our contact) will be used. |
| SingleEntryOnEachCompany | bool | Should we only create one task on each company? If false, separate tasks will be created for all persons from the same company. |
| SaleId | int32 | Sale identity to set on task |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Selection/CreateDefaultMailMergeTask
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 21,
  "TypeId": 360,
  "StartDate": "2012-07-17T13:38:14.1084486+02:00",
  "Duration": 340,
  "Description": "Balanced demand-driven flexibility",
  "PriorityId": 905,
  "VisibleFor": null,
  "Completed": "Completed",
  "OwnerAssociateId": 860,
  "SingleEntryOnEachCompany": true,
  "SaleId": 387,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 666
    }
  }
}
```