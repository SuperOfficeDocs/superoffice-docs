---
title: POST Project/Validate
uid: v1ProjectEntity_ValidateProjectEntity
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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 520,
  "Name": "Keebler Inc and Sons",
  "ProjectNumber": "1574970",
  "ProjectMembers": [
    {
      "ProjectmemberId": 258,
      "ContactId": 774,
      "ProjectId": 951,
      "ContactName": "Legros Group",
      "ContactDepartment": "matrix magnetic ROI",
      "ProjectName": "Wolff-Schultz",
      "EmailId": 768,
      "EmailAddress": "nia_gorczany@harberwalter.co.uk",
      "CountryId": 738,
      "Firstname": "Ella",
      "MiddleName": "Hackett LLC",
      "Lastname": "Collier",
      "PersonId": 274,
      "Mrmrs": "dicta",
      "ProjectMemberTypeName": "Wiza-Johnston",
      "Phone": "(227)377-8547",
      "PhoneId": 348,
      "ProjectMemberTypeId": 984,
      "EmailAddressName": "enos_gaylord@steuber.biz",
      "Comment": "aut",
      "FullName": "Bernita Wyman"
    }
  ],
  "Urls": [
    {
      "Value": "consequatur",
      "StrippedValue": "placeat",
      "Description": "Visionary multi-state internet solution"
    },
    {
      "Value": "consequatur",
      "StrippedValue": "placeat",
      "Description": "Visionary multi-state internet solution"
    }
  ],
  "CreatedDate": "2001-05-22T17:37:39.0213038+02:00",
  "UpdatedDate": "2014-06-06T17:37:39.0213038+02:00",
  "Description": "Self-enabling solution-oriented superstructure",
  "Postit": "eos",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Decentralized contextually-based pricing structure",
  "ActiveStatusMonitorId": 335,
  "Links": [
    {
      "EntityName": "Stoltenberg, Quitzon and Doyle",
      "Id": 650,
      "Description": "Face to face static Graphic Interface",
      "ExtraInfo": "culpa",
      "LinkId": 531
    },
    {
      "EntityName": "Stoltenberg, Quitzon and Doyle",
      "Id": 650,
      "Description": "Face to face static Graphic Interface",
      "ExtraInfo": "culpa",
      "LinkId": 531
    }
  ],
  "ActiveLinks": 313,
  "Completed": false,
  "NextMilestoneDate": "2000-08-09T17:37:39.0223034+02:00",
  "NmdAppointmentId": 194,
  "EndDate": "2000-04-05T17:37:39.0223034+02:00",
  "ActiveErpLinks": 533,
  "UserDefinedFields": {
    "SuperOffice:1": "Don Stark",
    "SuperOffice:2": "Ms. Kris Erdman DDS"
  },
  "ExtraFields": {
    "ExtraFields1": "earum",
    "ExtraFields2": "quasi"
  },
  "CustomFields": {
    "CustomFields1": "minus",
    "CustomFields2": "placeat"
  },
  "PublishEventDate": "2020-11-25T17:37:39.0223034+01:00",
  "PublishTo": "2003-12-05T17:37:39.0223034+01:00",
  "PublishFrom": "1997-11-04T17:37:39.0223034+01:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "quo",
  "2": "delectus"
}
```