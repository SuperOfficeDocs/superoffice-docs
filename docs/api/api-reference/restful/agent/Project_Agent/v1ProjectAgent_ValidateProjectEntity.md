---
title: ValidateProjectEntity
id: v1ProjectAgent_ValidateProjectEntity
---

# ValidateProjectEntity

```http
POST /api/v1/Agents/Project/ValidateProjectEntity
```

Check that entity is ready for saving, return error messages by field.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Project/ValidateProjectEntity?$select=name,department,category/id
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

ProjectEntity 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProjectEntity |  | The Project Service. The service implements all services working with the Project object <para /> Carrier object for ProjectEntity. Services for the ProjectEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IProjectAgent">Project Agent</see>. |


## Response: object



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object


## Sample Request

```http!
POST /api/v1/Agents/Project/ValidateProjectEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProjectEntity": {
    "ProjectId": 69,
    "Name": "Maggio-Gottlieb",
    "ProjectNumber": "268642",
    "ProjectMembers": [
      {},
      {}
    ],
    "Urls": [
      {},
      {}
    ],
    "CreatedDate": "2006-11-08T14:58:04.9184647+01:00",
    "UpdatedDate": "2019-03-10T14:58:04.9184647+01:00",
    "Description": "Compatible background initiative",
    "Postit": "corporis",
    "CreatedBy": {},
    "UpdatedBy": {},
    "Associate": {},
    "ProjectStatus": {},
    "ProjectType": {},
    "HasImage": false,
    "ImageDescription": "Organized contextually-based service-desk",
    "ActiveStatusMonitorId": 261,
    "Links": [
      {},
      {}
    ],
    "ActiveLinks": 152,
    "Completed": true,
    "NextMilestoneDate": "2008-05-26T14:58:04.9184647+02:00",
    "NmdAppointmentId": 101,
    "EndDate": "2003-10-25T14:58:04.9184647+02:00",
    "ActiveErpLinks": 60,
    "UserDefinedFields": {
      "SuperOffice:1": "Lia Haley",
      "SuperOffice:2": "True"
    },
    "ExtraFields": {
      "ExtraFields1": "voluptatem",
      "ExtraFields2": "nihil"
    },
    "CustomFields": {
      "CustomFields1": "cupiditate",
      "CustomFields2": "provident"
    },
    "PublishEventDate": "2005-08-11T14:58:04.9184647+02:00",
    "PublishTo": "2004-02-01T14:58:04.9184647+01:00",
    "PublishFrom": "2004-08-24T14:58:04.9184647+02:00",
    "IsPublished": false
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "quis",
  "2": "soluta"
}
```