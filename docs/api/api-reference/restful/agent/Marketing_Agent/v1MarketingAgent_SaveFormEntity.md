---
title: POST Agents/Marketing/SaveFormEntity
id: v1MarketingAgent_SaveFormEntity
---

# POST Agents/Marketing/SaveFormEntity

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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "FormId": 563,
  "FormKey": "voluptatem",
  "Name": "Lind Group",
  "Description": "Diverse bi-directional conglomeration",
  "Config": "dicta",
  "FolderId": 353,
  "ScriptId": 387,
  "ResponseShipmentId": 406,
  "Active": true,
  "Expires": "2006-02-02T16:48:29.9499248+01:00",
  "MaxSubmits": 378,
  "Type": "Normal",
  "Recipe": "laboriosam",
  "GroupId": 539,
  "NewTicket": false,
  "RecaptchaMode": "GlobalKeysExist",
  "Registered": "2012-01-01T16:48:29.9499248+01:00",
  "RegisteredAssociateId": 519,
  "Updated": "2005-10-13T16:48:29.9499248+02:00",
  "UpdatedAssociateId": 138,
  "UpdatedCount": 156,
  "FolderName": "Hoeger, Ledner and Jenkins"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "FormId": 894,
  "FormKey": "eum",
  "Name": "Legros-Christiansen",
  "Description": "Multi-channelled uniform capacity",
  "Config": "et",
  "FolderId": 799,
  "ScriptId": 991,
  "ResponseShipmentId": 495,
  "Active": true,
  "Expires": "2006-03-22T16:48:29.9509251+01:00",
  "MaxSubmits": 991,
  "Type": "Normal",
  "Recipe": "quis",
  "GroupId": 646,
  "NewTicket": false,
  "RecaptchaMode": "GlobalKeysExist",
  "Registered": "2019-08-20T16:48:29.9509251+02:00",
  "RegisteredAssociateId": 316,
  "Updated": "2000-06-25T16:48:29.9509251+02:00",
  "UpdatedAssociateId": 34,
  "UpdatedCount": 556,
  "FolderName": "Kuvalis-Little",
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
      "FieldType": "System.String",
      "FieldLength": 597
    }
  }
}
```