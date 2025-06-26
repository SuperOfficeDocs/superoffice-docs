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
  "ProjectId": 799,
  "Name": "Carroll Inc and Sons",
  "ProjectNumber": "845638",
  "ProjectMembers": [
    {
      "ProjectmemberId": 571,
      "ContactId": 372,
      "ProjectId": 12,
      "ContactName": "Parisian, Labadie and Kozey",
      "ContactDepartment": "",
      "ProjectName": "Wiza-Raynor",
      "EmailId": 156,
      "EmailAddress": "drew.hammes@rohan.uk",
      "CountryId": 381,
      "Firstname": "Chaim",
      "MiddleName": "Stokes Inc and Sons",
      "Lastname": "Zemlak",
      "PersonId": 945,
      "Mrmrs": "voluptatem",
      "ProjectMemberTypeName": "Schuster-Leuschke",
      "Phone": "(804)245-3931 x3143",
      "PhoneId": 144,
      "ProjectMemberTypeId": 367,
      "EmailAddressName": "katlyn_kautzer@lemke.us",
      "Comment": "unde",
      "FullName": "Sean Brekke PhD"
    }
  ],
  "Urls": [
    {
      "Value": "mollitia",
      "StrippedValue": "sit",
      "Description": "Ergonomic web-enabled knowledge base"
    },
    {
      "Value": "mollitia",
      "StrippedValue": "sit",
      "Description": "Ergonomic web-enabled knowledge base"
    }
  ],
  "CreatedDate": "1999-02-27T03:45:28.5296817+01:00",
  "UpdatedDate": "2001-12-09T03:45:28.5296817+01:00",
  "Description": "User-centric national matrices",
  "Postit": "porro",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Sharable uniform neural-net",
  "ActiveStatusMonitorId": 881,
  "Links": [
    {
      "EntityName": "Kessler, Thompson and Conn",
      "Id": 832,
      "Description": "Front-line systematic customer loyalty",
      "ExtraInfo": "deserunt",
      "LinkId": 436
    },
    {
      "EntityName": "Kessler, Thompson and Conn",
      "Id": 832,
      "Description": "Front-line systematic customer loyalty",
      "ExtraInfo": "deserunt",
      "LinkId": 436
    }
  ],
  "ActiveLinks": 228,
  "Completed": false,
  "NextMilestoneDate": "2010-10-22T03:45:28.5296817+02:00",
  "NmdAppointmentId": 804,
  "EndDate": "2005-02-26T03:45:28.5296817+01:00",
  "ActiveErpLinks": 488,
  "UserDefinedFields": {
    "SuperOffice:1": "Darius Swaniawski",
    "SuperOffice:2": "1268121234"
  },
  "ExtraFields": {
    "ExtraFields1": "esse",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "reiciendis",
    "CustomFields2": "animi"
  },
  "PublishEventDate": "2004-05-17T03:45:28.5296817+02:00",
  "PublishTo": "2003-03-18T03:45:28.5296817+01:00",
  "PublishFrom": "2015-01-30T03:45:28.5296817+01:00",
  "IsPublished": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "perferendis",
  "2": "odio"
}
```