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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ProjectEntity": {
    "ProjectId": 333,
    "Name": "Rodriguez, Paucek and Zboncak",
    "ProjectNumber": "964323",
    "ProjectMembers": [
      {},
      {}
    ],
    "Urls": [
      {},
      {}
    ],
    "CreatedDate": "2016-05-27T16:48:30.3569335+02:00",
    "UpdatedDate": "1998-12-06T16:48:30.3569335+01:00",
    "Description": "Synergistic foreground adapter",
    "Postit": "porro",
    "CreatedBy": {},
    "UpdatedBy": {},
    "Associate": {},
    "ProjectStatus": {},
    "ProjectType": {},
    "HasImage": false,
    "ImageDescription": "Pre-emptive transitional infrastructure",
    "ActiveStatusMonitorId": 799,
    "Links": [
      {},
      {}
    ],
    "ActiveLinks": 236,
    "Completed": true,
    "NextMilestoneDate": "2004-01-23T16:48:30.3569335+01:00",
    "NmdAppointmentId": 246,
    "EndDate": "2014-12-24T16:48:30.3569335+01:00",
    "ActiveErpLinks": 661,
    "UserDefinedFields": {
      "SuperOffice:1": "False",
      "SuperOffice:2": "Talia Balistreri"
    },
    "ExtraFields": {
      "ExtraFields1": "dolorem",
      "ExtraFields2": "consequatur"
    },
    "CustomFields": {
      "CustomFields1": "neque",
      "CustomFields2": "ducimus"
    },
    "PublishEventDate": "2009-09-23T16:48:30.3569335+02:00",
    "PublishTo": "2008-11-23T16:48:30.3569335+01:00",
    "PublishFrom": "2009-08-30T16:48:30.3569335+02:00",
    "IsPublished": false
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "facilis",
  "2": "aperiam"
}
```