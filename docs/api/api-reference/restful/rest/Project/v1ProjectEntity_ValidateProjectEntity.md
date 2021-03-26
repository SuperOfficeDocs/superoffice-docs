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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 954,
  "Name": "Legros Inc and Sons",
  "ProjectNumber": "1316338",
  "ProjectMembers": [
    {
      "ProjectmemberId": 509,
      "ContactId": 366,
      "ProjectId": 876,
      "ContactName": "Runte Group",
      "ContactDepartment": "",
      "ProjectName": "Kuvalis LLC",
      "EmailId": 930,
      "EmailAddress": "bessie@smitham.us",
      "CountryId": 725,
      "Firstname": "Anika",
      "MiddleName": "Crooks, Brown and Will",
      "Lastname": "Upton",
      "PersonId": 686,
      "Mrmrs": "totam",
      "ProjectMemberTypeName": "Macejkovic Inc and Sons",
      "Phone": "(867)300-4871",
      "PhoneId": 158,
      "ProjectMemberTypeId": 219,
      "EmailAddressName": "pierce_heathcote@ferry.us",
      "Comment": "natus",
      "FullName": "Fae Fritsch"
    }
  ],
  "Urls": [
    {
      "Value": "nostrum",
      "StrippedValue": "iure",
      "Description": "Vision-oriented bi-directional throughput"
    },
    {
      "Value": "nostrum",
      "StrippedValue": "iure",
      "Description": "Vision-oriented bi-directional throughput"
    }
  ],
  "CreatedDate": "2007-12-30T09:40:59.4876632+01:00",
  "UpdatedDate": "1997-06-04T09:40:59.4876632+02:00",
  "Description": "Ergonomic explicit ability",
  "Postit": "soluta",
  "CreatedBy": {
    "AssociateId": 850,
    "Name": "Reinger, Goyette and Stoltenberg",
    "PersonId": 6,
    "Rank": 895,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 99,
    "FullName": "Ruth Hahn",
    "FormalName": "Olson, Heidenreich and Bailey",
    "Deleted": false,
    "EjUserId": 87,
    "UserName": "Rosenbaum LLC"
  },
  "UpdatedBy": {
    "AssociateId": 609,
    "Name": "Wiza, Effertz and Rice",
    "PersonId": 961,
    "Rank": 556,
    "Tooltip": "nisi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 558,
    "FullName": "Jessy Osinski",
    "FormalName": "Stehr LLC",
    "Deleted": true,
    "EjUserId": 794,
    "UserName": "Walter Inc and Sons"
  },
  "Associate": {
    "AssociateId": 697,
    "Name": "Murphy LLC",
    "PersonId": 210,
    "Rank": 895,
    "Tooltip": "laudantium",
    "Type": "AnonymousAssociate",
    "GroupIdx": 571,
    "FullName": "Mrs. Billy Kuhlman",
    "FormalName": "Schiller, Cronin and Cummings",
    "Deleted": false,
    "EjUserId": 4,
    "UserName": "Mueller, Gusikowski and Volkman"
  },
  "ProjectStatus": {
    "Id": 368,
    "Value": "quasi",
    "Tooltip": "adipisci"
  },
  "ProjectType": {
    "Id": 729,
    "Value": "culpa",
    "Tooltip": "ipsam"
  },
  "HasImage": true,
  "ImageDescription": "Quality-focused logistical attitude",
  "ActiveStatusMonitorId": 753,
  "Links": [
    {
      "EntityName": "Schoen-Thompson",
      "Id": 259,
      "Description": "Visionary dynamic artificial intelligence",
      "ExtraInfo": "temporibus",
      "LinkId": 968
    },
    {
      "EntityName": "Schoen-Thompson",
      "Id": 259,
      "Description": "Visionary dynamic artificial intelligence",
      "ExtraInfo": "temporibus",
      "LinkId": 968
    }
  ],
  "ActiveLinks": 551,
  "Completed": true,
  "NextMilestoneDate": "2004-02-05T09:40:59.4886628+01:00",
  "NmdAppointmentId": 625,
  "EndDate": "1995-11-17T09:40:59.4886628+01:00",
  "ActiveErpLinks": 540,
  "UserDefinedFields": {
    "SuperOffice:1": "Demarco Emmerich",
    "SuperOffice:2": "Marshall Friesen"
  },
  "ExtraFields": {
    "ExtraFields1": "itaque",
    "ExtraFields2": "qui"
  },
  "CustomFields": {
    "CustomFields1": "non",
    "CustomFields2": "esse"
  },
  "PublishEventDate": "1996-09-10T09:40:59.4896629+02:00",
  "PublishTo": "2015-11-17T09:40:59.4896629+01:00",
  "PublishFrom": "1997-05-01T09:40:59.4896629+02:00",
  "IsPublished": true
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "sed",
  "2": "non"
}
```