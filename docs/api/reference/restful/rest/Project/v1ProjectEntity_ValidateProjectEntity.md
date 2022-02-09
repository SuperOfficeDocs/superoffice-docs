---
title: POST Project/Validate
id: v1ProjectEntity_ValidateProjectEntity
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



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object


## Sample Request

```http!
POST /api/v1/Project/Validate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 785,
  "Name": "Langosh LLC",
  "ProjectNumber": "1029397",
  "ProjectMembers": [
    {
      "ProjectmemberId": 646,
      "ContactId": 785,
      "ProjectId": 529,
      "ContactName": "Torphy, Effertz and Stroman",
      "ContactDepartment": "morph clicks-and-mortar relationships",
      "ProjectName": "Fadel-Kling",
      "EmailId": 91,
      "EmailAddress": "isabel.wuckert@heller.uk",
      "CountryId": 976,
      "Firstname": "Marquis",
      "MiddleName": "Durgan Inc and Sons",
      "Lastname": "O'Keefe",
      "PersonId": 468,
      "Mrmrs": "quasi",
      "ProjectMemberTypeName": "Zemlak Group",
      "Phone": "1-521-566-2742 x28106",
      "PhoneId": 203,
      "ProjectMemberTypeId": 549,
      "EmailAddressName": "raul_hegmann@funkpredovic.co.uk",
      "Comment": "ducimus",
      "FullName": "Wallace Koelpin"
    }
  ],
  "Urls": [
    {
      "Value": "incidunt",
      "StrippedValue": "nesciunt",
      "Description": "Cross-group composite benchmark"
    },
    {
      "Value": "incidunt",
      "StrippedValue": "nesciunt",
      "Description": "Cross-group composite benchmark"
    }
  ],
  "CreatedDate": "2012-10-28T18:25:50.8388853+01:00",
  "UpdatedDate": "2007-07-07T18:25:50.8388853+02:00",
  "Description": "Progressive human-resource local area network",
  "Postit": "qui",
  "CreatedBy": {
    "AssociateId": 939,
    "Name": "Bailey LLC",
    "PersonId": 698,
    "Rank": 832,
    "Tooltip": "impedit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 88,
    "FullName": "Amira Wolf",
    "FormalName": "Nitzsche-Bashirian",
    "Deleted": true,
    "EjUserId": 454,
    "UserName": "Bechtelar, Treutel and Bahringer"
  },
  "UpdatedBy": {
    "AssociateId": 531,
    "Name": "Wilderman, Lueilwitz and Bernhard",
    "PersonId": 218,
    "Rank": 69,
    "Tooltip": "esse",
    "Type": "AnonymousAssociate",
    "GroupIdx": 96,
    "FullName": "Noah Schimmel",
    "FormalName": "Stokes, Braun and Connelly",
    "Deleted": false,
    "EjUserId": 630,
    "UserName": "Hoeger LLC"
  },
  "Associate": {
    "AssociateId": 60,
    "Name": "O'Connell Group",
    "PersonId": 489,
    "Rank": 441,
    "Tooltip": "nobis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 553,
    "FullName": "Marion Bayer",
    "FormalName": "Conroy-Ruecker",
    "Deleted": true,
    "EjUserId": 643,
    "UserName": "Orn Group"
  },
  "ProjectStatus": {
    "Id": 961,
    "Value": "est",
    "Tooltip": "ex"
  },
  "ProjectType": {
    "Id": 374,
    "Value": "placeat",
    "Tooltip": "enim"
  },
  "HasImage": false,
  "ImageDescription": "Customizable foreground success",
  "ActiveStatusMonitorId": 318,
  "Links": [
    {
      "EntityName": "Leffler-McClure",
      "Id": 707,
      "Description": "Innovative assymetric open architecture",
      "ExtraInfo": "voluptas",
      "LinkId": 115
    },
    {
      "EntityName": "Leffler-McClure",
      "Id": 707,
      "Description": "Innovative assymetric open architecture",
      "ExtraInfo": "voluptas",
      "LinkId": 115
    }
  ],
  "ActiveLinks": 639,
  "Completed": true,
  "NextMilestoneDate": "1995-07-15T18:25:50.8418851+02:00",
  "NmdAppointmentId": 380,
  "EndDate": "2004-06-23T18:25:50.8418851+02:00",
  "ActiveErpLinks": 988,
  "UserDefinedFields": {
    "SuperOffice:1": "Aylin Bergstrom",
    "SuperOffice:2": "Annabell Pfannerstill DVM"
  },
  "ExtraFields": {
    "ExtraFields1": "veniam",
    "ExtraFields2": "provident"
  },
  "CustomFields": {
    "CustomFields1": "maxime",
    "CustomFields2": "nisi"
  },
  "PublishEventDate": "2000-08-10T18:25:50.8418851+02:00",
  "PublishTo": "2020-03-16T18:25:50.8418851+01:00",
  "PublishFrom": "2012-12-02T18:25:50.8418851+01:00",
  "IsPublished": true
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "porro",
  "2": "eum"
}
```