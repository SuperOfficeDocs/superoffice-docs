---
title: POST Agents/Project/ValidateProjectEntity
id: v1ProjectAgent_ValidateProjectEntity
---

# POST Agents/Project/ValidateProjectEntity

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
    "ProjectId": 881,
    "Name": "Kassulke, Rempel and Bins",
    "ProjectNumber": "512681",
    "ProjectMembers": [
      {},
      {}
    ],
    "Urls": [
      {},
      {}
    ],
    "CreatedDate": "2001-12-16T18:28:49.9001085+01:00",
    "UpdatedDate": "2009-04-24T18:28:49.9001085+02:00",
    "Description": "Multi-lateral motivating hardware",
    "Postit": "fugit",
    "CreatedBy": {},
    "UpdatedBy": {},
    "Associate": {},
    "ProjectStatus": {},
    "ProjectType": {},
    "HasImage": true,
    "ImageDescription": "Grass-roots stable contingency",
    "ActiveStatusMonitorId": 822,
    "Links": [
      {},
      {}
    ],
    "ActiveLinks": 347,
    "Completed": false,
    "NextMilestoneDate": "1998-01-08T18:28:49.9001085+01:00",
    "NmdAppointmentId": 785,
    "EndDate": "1996-12-28T18:28:49.9001085+01:00",
    "ActiveErpLinks": 115,
    "UserDefinedFields": {
      "SuperOffice:1": "312186990",
      "SuperOffice:2": "Pierre Cassin"
    },
    "ExtraFields": {
      "ExtraFields1": "nobis",
      "ExtraFields2": "eligendi"
    },
    "CustomFields": {
      "CustomFields1": "impedit",
      "CustomFields2": "quisquam"
    },
    "PublishEventDate": "2004-07-09T18:28:49.9001085+02:00",
    "PublishTo": "2000-04-12T18:28:49.9001085+02:00",
    "PublishFrom": "2004-03-05T18:28:49.9001085+01:00",
    "IsPublished": true
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "doloribus",
  "2": "quo"
}
```