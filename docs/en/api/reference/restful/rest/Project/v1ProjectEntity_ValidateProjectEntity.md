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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 366,
  "Name": "Treutel-Barrows",
  "ProjectNumber": "659347",
  "ProjectMembers": [
    {
      "ProjectmemberId": 656,
      "ContactId": 517,
      "ProjectId": 695,
      "ContactName": "Friesen-Schmitt",
      "ContactDepartment": "expedite revolutionary methodologies",
      "ProjectName": "Legros, Crona and Harvey",
      "EmailId": 635,
      "EmailAddress": "chesley.walker@faheycremin.com",
      "CountryId": 30,
      "Firstname": "Vincenza",
      "MiddleName": "Gottlieb LLC",
      "Lastname": "Botsford",
      "PersonId": 372,
      "Mrmrs": "ut",
      "ProjectMemberTypeName": "Crona LLC",
      "Phone": "870.999.2353 x3203",
      "PhoneId": 487,
      "ProjectMemberTypeId": 600,
      "EmailAddressName": "bryce@strosin.com",
      "Comment": "neque",
      "FullName": "Maureen Merl Flatley Sr."
    }
  ],
  "Urls": [
    {
      "Value": "sed",
      "StrippedValue": "optio",
      "Description": "Open-source mission-critical portal"
    },
    {
      "Value": "sed",
      "StrippedValue": "optio",
      "Description": "Open-source mission-critical portal"
    }
  ],
  "CreatedDate": "2003-02-02T12:19:53.7742043+01:00",
  "UpdatedDate": "2000-10-09T12:19:53.7742043+02:00",
  "Description": "Ergonomic exuding service-desk",
  "Postit": "velit",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Networked 4th generation contingency",
  "ActiveStatusMonitorId": 301,
  "Links": [
    {
      "EntityName": "Veum Group",
      "Id": 872,
      "Description": "Future-proofed analyzing analyzer",
      "ExtraInfo": "consequatur",
      "LinkId": 535
    },
    {
      "EntityName": "Veum Group",
      "Id": 872,
      "Description": "Future-proofed analyzing analyzer",
      "ExtraInfo": "consequatur",
      "LinkId": 535
    }
  ],
  "ActiveLinks": 291,
  "Completed": true,
  "NextMilestoneDate": "2008-03-11T12:19:53.7742043+01:00",
  "NmdAppointmentId": 69,
  "EndDate": "2019-05-11T12:19:53.7742043+02:00",
  "ActiveErpLinks": 803,
  "UserDefinedFields": {
    "SuperOffice:1": "Genesis Conroy",
    "SuperOffice:2": "Dr. Martin Enoch Jacobi Jr."
  },
  "ExtraFields": {
    "ExtraFields1": "deleniti",
    "ExtraFields2": "nulla"
  },
  "CustomFields": {
    "CustomFields1": "ratione",
    "CustomFields2": "eos"
  },
  "PublishEventDate": "2013-05-26T12:19:53.7742043+02:00",
  "PublishTo": "1998-08-01T12:19:53.7742043+02:00",
  "PublishFrom": "2015-01-14T12:19:53.7742043+01:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "quidem",
  "2": "eveniet"
}
```