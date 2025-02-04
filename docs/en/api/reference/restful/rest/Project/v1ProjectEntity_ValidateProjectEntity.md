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
  "ProjectId": 386,
  "Name": "Rau Inc and Sons",
  "ProjectNumber": "744698",
  "ProjectMembers": [
    {
      "ProjectmemberId": 198,
      "ContactId": 916,
      "ProjectId": 662,
      "ContactName": "Stracke Inc and Sons",
      "ContactDepartment": "",
      "ProjectName": "Nader-Schaefer",
      "EmailId": 536,
      "EmailAddress": "eldon.roberts@wintheiser.ca",
      "CountryId": 634,
      "Firstname": "Jammie",
      "MiddleName": "Durgan, Stehr and Daugherty",
      "Lastname": "Schimmel",
      "PersonId": 884,
      "Mrmrs": "quia",
      "ProjectMemberTypeName": "Beer Group",
      "Phone": "899-532-9414 x9012",
      "PhoneId": 936,
      "ProjectMemberTypeId": 665,
      "EmailAddressName": "yvonne_lesch@pagac.us",
      "Comment": "aut",
      "FullName": "Berenice Aniyah Pfeffer IV"
    }
  ],
  "Urls": [
    {
      "Value": "nulla",
      "StrippedValue": "iure",
      "Description": "Function-based holistic approach"
    },
    {
      "Value": "nulla",
      "StrippedValue": "iure",
      "Description": "Function-based holistic approach"
    }
  ],
  "CreatedDate": "2000-04-22T13:13:31.9488068+02:00",
  "UpdatedDate": "2016-04-05T13:13:31.9488068+02:00",
  "Description": "Up-sized client-server local area network",
  "Postit": "perspiciatis",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Persistent didactic functionalities",
  "ActiveStatusMonitorId": 471,
  "Links": [
    {
      "EntityName": "Breitenberg LLC",
      "Id": 584,
      "Description": "Re-contextualized value-added Graphic Interface",
      "ExtraInfo": "reprehenderit",
      "LinkId": 377
    },
    {
      "EntityName": "Breitenberg LLC",
      "Id": 584,
      "Description": "Re-contextualized value-added Graphic Interface",
      "ExtraInfo": "reprehenderit",
      "LinkId": 377
    }
  ],
  "ActiveLinks": 626,
  "Completed": false,
  "NextMilestoneDate": "2004-09-08T13:13:31.9488068+02:00",
  "NmdAppointmentId": 35,
  "EndDate": "2010-05-19T13:13:31.9488068+02:00",
  "ActiveErpLinks": 135,
  "UserDefinedFields": {
    "SuperOffice:1": "646900903",
    "SuperOffice:2": "Clarissa Swaniawski"
  },
  "ExtraFields": {
    "ExtraFields1": "nemo",
    "ExtraFields2": "expedita"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "hic"
  },
  "PublishEventDate": "2005-03-14T13:13:31.9488068+01:00",
  "PublishTo": "2009-08-21T13:13:31.9488068+02:00",
  "PublishFrom": "2007-09-03T13:13:31.9488068+02:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "officiis",
  "2": "nemo"
}
```