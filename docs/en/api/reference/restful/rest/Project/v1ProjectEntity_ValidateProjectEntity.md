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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 771,
  "Name": "Kautzer-White",
  "ProjectNumber": "794540",
  "ProjectMembers": [
    {
      "ProjectmemberId": 225,
      "ContactId": 903,
      "ProjectId": 646,
      "ContactName": "Harris-Stark",
      "ContactDepartment": "",
      "ProjectName": "Muller Group",
      "EmailId": 187,
      "EmailAddress": "green.shields@gleichner.ca",
      "CountryId": 158,
      "Firstname": "Aleen",
      "MiddleName": "Keeling, Ortiz and Beier",
      "Lastname": "Wisoky",
      "PersonId": 525,
      "Mrmrs": "vel",
      "ProjectMemberTypeName": "Mitchell-Sporer",
      "Phone": "707-766-3679",
      "PhoneId": 22,
      "ProjectMemberTypeId": 179,
      "EmailAddressName": "elva@lowe.com",
      "Comment": "assumenda",
      "FullName": "Rigoberto Smith"
    }
  ],
  "Urls": [
    {
      "Value": "sed",
      "StrippedValue": "dicta",
      "Description": "Integrated intangible pricing structure"
    },
    {
      "Value": "sed",
      "StrippedValue": "dicta",
      "Description": "Integrated intangible pricing structure"
    }
  ],
  "CreatedDate": "2023-11-24T14:28:27.0551896+01:00",
  "UpdatedDate": "2013-11-18T14:28:27.0551896+01:00",
  "Description": "Organic disintermediate adapter",
  "Postit": "vel",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Proactive holistic flexibility",
  "ActiveStatusMonitorId": 801,
  "Links": [
    {
      "EntityName": "Kohler LLC",
      "Id": 12,
      "Description": "Programmable value-added solution",
      "ExtraInfo": "totam",
      "LinkId": 596
    },
    {
      "EntityName": "Kohler LLC",
      "Id": 12,
      "Description": "Programmable value-added solution",
      "ExtraInfo": "totam",
      "LinkId": 596
    }
  ],
  "ActiveLinks": 39,
  "Completed": true,
  "NextMilestoneDate": "2004-04-24T14:28:27.0551896+02:00",
  "NmdAppointmentId": 952,
  "EndDate": "2024-06-10T14:28:27.0551896+02:00",
  "ActiveErpLinks": 822,
  "UserDefinedFields": {
    "SuperOffice:1": "1337223933",
    "SuperOffice:2": "Miss Khalil Jaskolski Sr."
  },
  "ExtraFields": {
    "ExtraFields1": "libero",
    "ExtraFields2": "sed"
  },
  "CustomFields": {
    "CustomFields1": "necessitatibus",
    "CustomFields2": "nam"
  },
  "PublishEventDate": "2024-05-20T14:28:27.0551896+02:00",
  "PublishTo": "2005-04-17T14:28:27.0551896+02:00",
  "PublishFrom": "2025-03-21T14:28:27.0551896+01:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "commodi",
  "2": "perferendis"
}
```