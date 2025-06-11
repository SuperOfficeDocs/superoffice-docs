---
title: POST Project/Validate
uid: v1ProjectEntity_ValidateProjectEntity
generated: true
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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 910,
  "Name": "Haley, Franecki and Gislason",
  "ProjectNumber": "1023235",
  "ProjectMembers": [
    {
      "ProjectmemberId": 460,
      "ContactId": 376,
      "ProjectId": 903,
      "ContactName": "Jones, Abshire and Huels",
      "ContactDepartment": "",
      "ProjectName": "Mueller LLC",
      "EmailId": 933,
      "EmailAddress": "raphael@leannonjacobs.ca",
      "CountryId": 218,
      "Firstname": "Derek",
      "MiddleName": "Ruecker Group",
      "Lastname": "Cummings",
      "PersonId": 629,
      "Mrmrs": "molestiae",
      "ProjectMemberTypeName": "Tillman, Bartell and Gerlach",
      "Phone": "147.960.9941",
      "PhoneId": 631,
      "ProjectMemberTypeId": 24,
      "EmailAddressName": "chanel@hayespurdy.us",
      "Comment": "et",
      "FullName": "Abby Schiller"
    }
  ],
  "Urls": [
    {
      "Value": "vel",
      "StrippedValue": "sit",
      "Description": "Expanded actuating collaboration"
    },
    {
      "Value": "vel",
      "StrippedValue": "sit",
      "Description": "Expanded actuating collaboration"
    }
  ],
  "CreatedDate": "2021-08-12T17:54:08.3980739+02:00",
  "UpdatedDate": "2009-04-12T17:54:08.3980739+02:00",
  "Description": "Organized empowering encoding",
  "Postit": "nobis",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Business-focused next generation task-force",
  "ActiveStatusMonitorId": 366,
  "Links": [
    {
      "EntityName": "Schinner, Lueilwitz and Runolfsson",
      "Id": 527,
      "Description": "Implemented clear-thinking methodology",
      "ExtraInfo": "tempore",
      "LinkId": 354
    },
    {
      "EntityName": "Schinner, Lueilwitz and Runolfsson",
      "Id": 527,
      "Description": "Implemented clear-thinking methodology",
      "ExtraInfo": "tempore",
      "LinkId": 354
    }
  ],
  "ActiveLinks": 898,
  "Completed": false,
  "NextMilestoneDate": "2013-01-28T17:54:08.3980739+01:00",
  "NmdAppointmentId": 996,
  "EndDate": "1999-09-10T17:54:08.3980739+02:00",
  "ActiveErpLinks": 340,
  "UserDefinedFields": {
    "SuperOffice:1": "Prof. Gunnar Ryan",
    "SuperOffice:2": "Owen Mitchell"
  },
  "ExtraFields": {
    "ExtraFields1": "deleniti",
    "ExtraFields2": "ratione"
  },
  "CustomFields": {
    "CustomFields1": "corrupti",
    "CustomFields2": "deserunt"
  },
  "PublishEventDate": "2011-02-05T17:54:08.3980739+01:00",
  "PublishTo": "2017-06-09T17:54:08.3980739+02:00",
  "PublishFrom": "1999-06-14T17:54:08.3980739+02:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "et",
  "2": "culpa"
}
```