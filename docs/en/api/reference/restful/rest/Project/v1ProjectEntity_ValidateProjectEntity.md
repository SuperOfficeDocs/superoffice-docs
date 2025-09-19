---
title: POST Project/Validate
uid: v1ProjectEntity_ValidateProjectEntity
generated: true
content_type: reference
---

# POST Project/Validate

```http
POST /api/v1/Project/Validate
```

Check that entity is ready for saving, return error messages by field.








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

## Request Body: projectEntity 

Entity to be checked for errors. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProjectId | Integer | Primary key |
| Name | String | Project name |
| ProjectNumber | String | Automatically generated number |
| ProjectMembers | Array | The persons which are members of the project |
| Urls | Array | The project's internet adresses |
| CreatedDate | String | Registered date  in UTC. |
| UpdatedDate | String | Last updated date  in UTC. |
| Description | String | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| Postit | String | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| CreatedBy | Associate | The person that created the project |
| UpdatedBy | Associate | The person that last updated the project |
| Associate | Associate | The person that created the project  <para>Use MDO List name "associate" to get list items.</para> |
| ProjectStatus | ProjectStatus | Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on  <para>Use MDO List name "projectstatus" to get list items.</para> |
| ProjectType | ProjectType | Project type is a list defined by the database admin. for example: 'Large', 'Small', 'Party'...  <para>Use MDO List name "projecttype" to get list items.</para> |
| HasImage | Boolean | True if the project has an image. (This is the image that is displayed in the CRM client) |
| ImageDescription | String | Description of the project image if it exists. (This is the image that is displayed in the CRM client) |
| ActiveStatusMonitorId | Integer | Active status monitor identity with the lowest rank for project |
| Links | Array | List of all elements linked to the project |
| ActiveLinks | Integer | Number of active links to documents, other appointments, and such |
| Completed | Boolean | Done (0=false, 1=true). Status implies changes in which fields are shown in GUI, as well as which fields can be updated |
| NextMilestoneDate | String | Calculated date, reflects date of closest non-complete future milestone activity |
| NmdAppointmentId | Integer | ID of appointment that "caused" the nextMilestoneDate, can be 0 |
| EndDate | String | Planned end date for project, inhertied from type and later editable |
| ActiveErpLinks | Integer | The number of active erp links |
| UserDefinedFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ProjectEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ProjectEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ProjectEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ProjectEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| PublishEventDate | String | Publish event date |
| PublishTo | String | Publication valid to (inclusive) |
| PublishFrom | String | Publication valid from (inclusive) |
| IsPublished | Boolean | Publication is published |

## Response:object

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: object


## Sample request

```http!
POST /api/v1/Project/Validate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 75,
  "Name": "Goodwin, Cronin and Davis",
  "ProjectNumber": "1851680",
  "ProjectMembers": [
    {
      "ProjectmemberId": 433,
      "ContactId": 69,
      "ProjectId": 710,
      "ContactName": "Murphy Inc and Sons",
      "ContactDepartment": "",
      "ProjectName": "Windler-Vandervort",
      "EmailId": 630,
      "EmailAddress": "estefania@schultzdibbert.name",
      "CountryId": 240,
      "Firstname": "Wyman",
      "MiddleName": "Baumbach, Kreiger and Kub",
      "Lastname": "Howell",
      "PersonId": 733,
      "Mrmrs": "est",
      "ProjectMemberTypeName": "Collins LLC",
      "Phone": "(960)721-9249",
      "PhoneId": 924,
      "ProjectMemberTypeId": 789,
      "EmailAddressName": "elva.klocko@muller.us",
      "Comment": "dolor",
      "FullName": "Shaun Emard",
      "Registered": "2025-09-18T03:41:58.9336467+02:00",
      "Updated": "2019-02-28T03:41:58.9336467+01:00"
    }
  ],
  "Urls": [
    {
      "Value": "quidem",
      "StrippedValue": "est",
      "Description": "Triple-buffered leading edge analyzer"
    },
    {
      "Value": "quidem",
      "StrippedValue": "est",
      "Description": "Triple-buffered leading edge analyzer"
    }
  ],
  "CreatedDate": "2023-12-08T03:41:58.9336467+01:00",
  "UpdatedDate": "2022-11-16T03:41:58.9336467+01:00",
  "Description": "Right-sized exuding knowledge base",
  "Postit": "explicabo",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Fundamental dedicated help-desk",
  "ActiveStatusMonitorId": 941,
  "Links": [
    {
      "EntityName": "Wunsch-Bradtke",
      "Id": 75,
      "Description": "Optional 4th generation approach",
      "ExtraInfo": "quod",
      "LinkId": 243
    },
    {
      "EntityName": "Wunsch-Bradtke",
      "Id": 75,
      "Description": "Optional 4th generation approach",
      "ExtraInfo": "quod",
      "LinkId": 243
    }
  ],
  "ActiveLinks": 937,
  "Completed": false,
  "NextMilestoneDate": "2007-05-15T03:41:58.9336467+02:00",
  "NmdAppointmentId": 461,
  "EndDate": "2002-11-01T03:41:58.9336467+01:00",
  "ActiveErpLinks": 31,
  "UserDefinedFields": {
    "SuperOffice:1": "200210712",
    "SuperOffice:2": "Rylan Rippin"
  },
  "ExtraFields": {
    "ExtraFields1": "deserunt",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "quidem",
    "CustomFields2": "excepturi"
  },
  "PublishEventDate": "2024-02-27T03:41:58.9336467+01:00",
  "PublishTo": "2008-02-14T03:41:58.9336467+01:00",
  "PublishFrom": "2014-01-03T03:41:58.9336467+01:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "in",
  "2": "veritatis"
}
```