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
  "FormId": 357,
  "FormKey": "excepturi",
  "Name": "Rice, Brakus and Ritchie",
  "Description": "Enhanced zero tolerance utilisation",
  "Config": "et",
  "FolderId": 52,
  "ScriptId": 472,
  "ResponseShipmentId": 843,
  "Active": true,
  "Expires": "2000-05-20T18:28:49.4590874+02:00",
  "MaxSubmits": 275,
  "Type": "Normal",
  "Recipe": "ad",
  "GroupId": 15,
  "NewTicket": false,
  "RecaptchaMode": "GlobalKeysExist",
  "Registered": "2011-10-14T18:28:49.4590874+02:00",
  "RegisteredAssociateId": 378,
  "Updated": "1996-11-19T18:28:49.4590874+01:00",
  "UpdatedAssociateId": 906,
  "UpdatedCount": 731,
  "FolderName": "Hermiston LLC"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "FormId": 788,
  "FormKey": "quasi",
  "Name": "Bergstrom LLC",
  "Description": "Visionary bifurcated firmware",
  "Config": "repudiandae",
  "FolderId": 679,
  "ScriptId": 251,
  "ResponseShipmentId": 177,
  "Active": true,
  "Expires": "2004-04-04T18:28:49.4590874+02:00",
  "MaxSubmits": 691,
  "Type": "Normal",
  "Recipe": "voluptatibus",
  "GroupId": 622,
  "NewTicket": false,
  "RecaptchaMode": "GlobalKeysExist",
  "Registered": "2011-02-11T18:28:49.4590874+01:00",
  "RegisteredAssociateId": 771,
  "Updated": "1997-12-10T18:28:49.4590874+01:00",
  "UpdatedAssociateId": 554,
  "UpdatedCount": 795,
  "FolderName": "Bahringer, Leffler and Cole",
  "TableRight": {
    "Mask": "Delete",
    "Reason": "matrix cutting-edge portals"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 598
    }
  }
}
```