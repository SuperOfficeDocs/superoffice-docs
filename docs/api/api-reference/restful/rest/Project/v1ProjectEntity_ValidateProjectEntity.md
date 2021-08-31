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
  "ProjectId": 735,
  "Name": "Jenkins-Donnelly",
  "ProjectNumber": "1248602",
  "ProjectMembers": [
    {
      "ProjectmemberId": 891,
      "ContactId": 168,
      "ProjectId": 164,
      "ContactName": "Feeney Group",
      "ContactDepartment": "",
      "ProjectName": "Ritchie-Lemke",
      "EmailId": 16,
      "EmailAddress": "kiera@stokes.co.uk",
      "CountryId": 164,
      "Firstname": "Rusty",
      "MiddleName": "Borer-Waelchi",
      "Lastname": "Rolfson",
      "PersonId": 274,
      "Mrmrs": "nostrum",
      "ProjectMemberTypeName": "Hayes-Orn",
      "Phone": "762-755-0225 x267",
      "PhoneId": 256,
      "ProjectMemberTypeId": 143,
      "EmailAddressName": "elvera@yundtfriesen.uk",
      "Comment": "animi",
      "FullName": "Precious Flatley"
    }
  ],
  "Urls": [
    {
      "Value": "qui",
      "StrippedValue": "unde",
      "Description": "Customizable client-driven approach"
    },
    {
      "Value": "qui",
      "StrippedValue": "unde",
      "Description": "Customizable client-driven approach"
    }
  ],
  "CreatedDate": "2018-08-13T15:05:42.4896743+02:00",
  "UpdatedDate": "2016-12-19T15:05:42.4896743+01:00",
  "Description": "Object-based discrete system engine",
  "Postit": "qui",
  "CreatedBy": {
    "AssociateId": 143,
    "Name": "Walsh, Gislason and Bergnaum",
    "PersonId": 350,
    "Rank": 106,
    "Tooltip": "magni",
    "Type": "AnonymousAssociate",
    "GroupIdx": 982,
    "FullName": "Ferne Johns Jr.",
    "FormalName": "Connelly, Smitham and Beer",
    "Deleted": true,
    "EjUserId": 195,
    "UserName": "Blick-Pollich"
  },
  "UpdatedBy": {
    "AssociateId": 446,
    "Name": "Ortiz Group",
    "PersonId": 85,
    "Rank": 637,
    "Tooltip": "iure",
    "Type": "AnonymousAssociate",
    "GroupIdx": 847,
    "FullName": "Miss Berniece Hauck",
    "FormalName": "Kirlin-Connelly",
    "Deleted": false,
    "EjUserId": 600,
    "UserName": "Mann Group"
  },
  "Associate": {
    "AssociateId": 821,
    "Name": "Bosco-Hettinger",
    "PersonId": 367,
    "Rank": 458,
    "Tooltip": "dolorem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 788,
    "FullName": "Darron Schuppe",
    "FormalName": "Pagac, Jacobi and Jerde",
    "Deleted": true,
    "EjUserId": 62,
    "UserName": "Anderson-Labadie"
  },
  "ProjectStatus": {
    "Id": 312,
    "Value": "optio",
    "Tooltip": "laudantium"
  },
  "ProjectType": {
    "Id": 607,
    "Value": "veniam",
    "Tooltip": "possimus"
  },
  "HasImage": true,
  "ImageDescription": "Open-architected discrete access",
  "ActiveStatusMonitorId": 615,
  "Links": [
    {
      "EntityName": "Glover, Hirthe and Larson",
      "Id": 380,
      "Description": "Total eco-centric alliance",
      "ExtraInfo": "sint",
      "LinkId": 424
    },
    {
      "EntityName": "Glover, Hirthe and Larson",
      "Id": 380,
      "Description": "Total eco-centric alliance",
      "ExtraInfo": "sint",
      "LinkId": 424
    }
  ],
  "ActiveLinks": 774,
  "Completed": false,
  "NextMilestoneDate": "2008-01-28T15:05:42.4996679+01:00",
  "NmdAppointmentId": 106,
  "EndDate": "2014-07-16T15:05:42.4996679+02:00",
  "ActiveErpLinks": 975,
  "UserDefinedFields": {
    "SuperOffice:1": "Nina Orn",
    "SuperOffice:2": "2133708080"
  },
  "ExtraFields": {
    "ExtraFields1": "sunt",
    "ExtraFields2": "doloremque"
  },
  "CustomFields": {
    "CustomFields1": "aut",
    "CustomFields2": "distinctio"
  },
  "PublishEventDate": "2003-07-31T15:05:42.5006349+02:00",
  "PublishTo": "2000-03-03T15:05:42.5006349+01:00",
  "PublishFrom": "2002-08-06T15:05:42.5006349+02:00",
  "IsPublished": true
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "quis",
  "2": "veniam"
}
```