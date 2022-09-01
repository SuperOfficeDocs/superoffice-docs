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
| ProjectId | int32 | Primary key |
| Name | string | Project name |
| ProjectNumber | string | Automatically generated number |
| ProjectMembers | array | The persons which are members of the project |
| Urls | array | The project's internet adresses |
| CreatedDate | date-time | Registered date  in UTC. |
| UpdatedDate | date-time | Last updated date  in UTC. |
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| Postit | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| CreatedBy |  | The person that created the project |
| UpdatedBy |  | The person that last updated the project |
| Associate |  | The person that created the project  <para>Use MDO List name "associate" to get list items.</para> |
| ProjectStatus |  | Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on  <para>Use MDO List name "projectstatus" to get list items.</para> |
| ProjectType |  | Project type is a list defined by the database admin. for example: 'Large', 'Small', 'Party'...  <para>Use MDO List name "projecttype" to get list items.</para> |
| HasImage | bool | True if the project has an image. (This is the image that is displayed in the CRM client) |
| ImageDescription | string | Description of the project image if it exists. (This is the image that is displayed in the CRM client) |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for project |
| Links | array | List of all elements linked to the project |
| ActiveLinks | int32 | Number of active links to documents, other appointments, and such |
| Completed | bool | Done (0=false, 1=true). Status implies changes in which fields are shown in GUI, as well as which fields can be updated |
| NextMilestoneDate | date-time | Calculated date, reflects date of closest non-complete future milestone activity |
| NmdAppointmentId | int32 | ID of appointment that "caused" the nextMilestoneDate, can be 0 |
| EndDate | date-time | Planned end date for project, inhertied from type and later editable |
| ActiveErpLinks | int32 | The number of active erp links |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ProjectEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ProjectEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ProjectEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ProjectEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| PublishEventDate | date-time | Publish event date |
| PublishTo | date-time | Publication valid to (inclusive) |
| PublishFrom | date-time | Publication valid from (inclusive) |
| IsPublished | bool | Publication is published |


## Response: object

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object


## Sample request

```http!
POST /api/v1/Project/Validate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 777,
  "Name": "Abshire, Heathcote and Marquardt",
  "ProjectNumber": "1471109",
  "ProjectMembers": [
    {
      "ProjectmemberId": 445,
      "ContactId": 857,
      "ProjectId": 153,
      "ContactName": "Hansen Group",
      "ContactDepartment": "",
      "ProjectName": "Hane Group",
      "EmailId": 375,
      "EmailAddress": "monica@labadiehauck.ca",
      "CountryId": 813,
      "Firstname": "Joany",
      "MiddleName": "Shields, Von and Fay",
      "Lastname": "Reichert",
      "PersonId": 491,
      "Mrmrs": "praesentium",
      "ProjectMemberTypeName": "Brown LLC",
      "Phone": "286-205-8010",
      "PhoneId": 713,
      "ProjectMemberTypeId": 776,
      "EmailAddressName": "jennings_green@feil.biz",
      "Comment": "quia",
      "FullName": "Prof. Vernon Toy"
    }
  ],
  "Urls": [
    {
      "Value": "soluta",
      "StrippedValue": "molestiae",
      "Description": "Business-focused multi-state neural-net"
    },
    {
      "Value": "soluta",
      "StrippedValue": "molestiae",
      "Description": "Business-focused multi-state neural-net"
    }
  ],
  "CreatedDate": "2006-11-19T11:10:53.3171456+01:00",
  "UpdatedDate": "2008-04-06T11:10:53.3171456+02:00",
  "Description": "Up-sized zero tolerance data-warehouse",
  "Postit": "quidem",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Monitored attitude-oriented circuit",
  "ActiveStatusMonitorId": 338,
  "Links": [
    {
      "EntityName": "Pouros, Dickinson and Lubowitz",
      "Id": 115,
      "Description": "Stand-alone systematic artificial intelligence",
      "ExtraInfo": "similique",
      "LinkId": 387
    },
    {
      "EntityName": "Pouros, Dickinson and Lubowitz",
      "Id": 115,
      "Description": "Stand-alone systematic artificial intelligence",
      "ExtraInfo": "similique",
      "LinkId": 387
    }
  ],
  "ActiveLinks": 245,
  "Completed": true,
  "NextMilestoneDate": "2001-05-23T11:10:53.3181438+02:00",
  "NmdAppointmentId": 627,
  "EndDate": "2019-02-07T11:10:53.3181438+01:00",
  "ActiveErpLinks": 280,
  "UserDefinedFields": {
    "SuperOffice:1": "1254974940",
    "SuperOffice:2": "Mrs. Katrine Jasmin Hickle Sr."
  },
  "ExtraFields": {
    "ExtraFields1": "sunt",
    "ExtraFields2": "voluptas"
  },
  "CustomFields": {
    "CustomFields1": "quod",
    "CustomFields2": "veniam"
  },
  "PublishEventDate": "2017-02-11T11:10:53.3181438+01:00",
  "PublishTo": "1998-05-17T11:10:53.3181438+02:00",
  "PublishFrom": "1998-10-29T11:10:53.3181438+01:00",
  "IsPublished": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "libero",
  "2": "velit"
}
```