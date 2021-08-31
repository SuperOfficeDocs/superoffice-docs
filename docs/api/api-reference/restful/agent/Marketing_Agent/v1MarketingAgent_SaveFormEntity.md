---
title: SaveFormEntity
id: v1MarketingAgent_SaveFormEntity
---

# SaveFormEntity

```http
POST /api/v1/Agents/Marketing/SaveFormEntity
```

Updates the existing FormEntity or creates a new FormEntity if the id parameter is empty








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

## Request Body: entity  

The FormEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| FormId | int32 | Primary key |
| FormKey | string | A short string used as unique id to access this form |
| Name | string | The name of this form |
| Description | string | Detailed description |
| Config | string | The JSON-formatted config of this form |
| FolderId | int32 | The folder which this form belongs to. -1 indicates that the shipment is on the root |
| ScriptId | int32 | The CRMScript Macro which will be run when the form is submitted. |
| ResponseShipmentId | int32 | The id of the s_shipment that is used to send the response mails |
| Active | bool | Indicates if this form is active or not |
| Expires | date-time | After this datetime, the form will become inactive |
| MaxSubmits | int32 | After this number of submits, the form will become inactive |
| Type | string | What kind of form is this? Indicates if this is a normal form or a template |
| Recipe | string | The JSON-formatted recipe of this form |
| GroupId | int32 | The group which this form belongs to. |
| NewTicket | bool | Indicates if this form creates a ticket or not |
| RecaptchaMode | string | What is the state of the recaptcha configuration? This is a read-only member |
| Registered | date-time | Registered when  in UTC. |
| RegisteredAssociateId | int32 | Registered by whom |
| Updated | date-time | Last updated when  in UTC. |
| UpdatedAssociateId | int32 | Last updated by whom |
| UpdatedCount | int32 | Number of updates made to this record |
| FolderName | string | The name of the folder for this form |


## Response: object

Definition and configuration of a Form



Carrier object for FormEntity.
Services for the FormEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IMarketingAgent">Marketing Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| FormId | int32 | Primary key |
| FormKey | string | A short string used as unique id to access this form |
| Name | string | The name of this form |
| Description | string | Detailed description |
| Config | string | The JSON-formatted config of this form |
| FolderId | int32 | The folder which this form belongs to. -1 indicates that the shipment is on the root |
| ScriptId | int32 | The CRMScript Macro which will be run when the form is submitted. |
| ResponseShipmentId | int32 | The id of the s_shipment that is used to send the response mails |
| Active | bool | Indicates if this form is active or not |
| Expires | date-time | After this datetime, the form will become inactive |
| MaxSubmits | int32 | After this number of submits, the form will become inactive |
| Type | string | What kind of form is this? Indicates if this is a normal form or a template |
| Recipe | string | The JSON-formatted recipe of this form |
| GroupId | int32 | The group which this form belongs to. |
| NewTicket | bool | Indicates if this form creates a ticket or not |
| RecaptchaMode | string | What is the state of the recaptcha configuration? This is a read-only member |
| Registered | date-time | Registered when  in UTC. |
| RegisteredAssociateId | int32 | Registered by whom |
| Updated | date-time | Last updated when  in UTC. |
| UpdatedAssociateId | int32 | Last updated by whom |
| UpdatedCount | int32 | Number of updates made to this record |
| FolderName | string | The name of the folder for this form |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Marketing/SaveFormEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "FormId": 782,
  "FormKey": "modi",
  "Name": "Bernhard-Champlin",
  "Description": "Multi-layered system-worthy artificial intelligence",
  "Config": "placeat",
  "FolderId": 118,
  "ScriptId": 508,
  "ResponseShipmentId": 158,
  "Active": false,
  "Expires": "2003-01-21T14:58:04.491465+01:00",
  "MaxSubmits": 54,
  "Type": "Normal",
  "Recipe": "explicabo",
  "GroupId": 655,
  "NewTicket": true,
  "RecaptchaMode": "GlobalKeysExist",
  "Registered": "1998-03-29T14:58:04.491465+02:00",
  "RegisteredAssociateId": 170,
  "Updated": "2012-03-23T14:58:04.491465+01:00",
  "UpdatedAssociateId": 630,
  "UpdatedCount": 242,
  "FolderName": "Lebsack-Will"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "FormId": 675,
  "FormKey": "debitis",
  "Name": "Lehner LLC",
  "Description": "Managed intangible methodology",
  "Config": "esse",
  "FolderId": 559,
  "ScriptId": 720,
  "ResponseShipmentId": 300,
  "Active": true,
  "Expires": "2000-10-23T14:58:04.491465+02:00",
  "MaxSubmits": 636,
  "Type": "Normal",
  "Recipe": "voluptatem",
  "GroupId": 157,
  "NewTicket": true,
  "RecaptchaMode": "GlobalKeysExist",
  "Registered": "1996-05-07T14:58:04.491465+02:00",
  "RegisteredAssociateId": 642,
  "Updated": "2014-07-27T14:58:04.491465+02:00",
  "UpdatedAssociateId": 272,
  "UpdatedCount": 768,
  "FolderName": "DuBuque Group",
  "TableRight": {
    "Mask": "Delete",
    "Reason": "grow global web-readiness"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 516
    }
  }
}
```