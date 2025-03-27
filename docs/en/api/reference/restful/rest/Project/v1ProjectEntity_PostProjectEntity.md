---
title: POST Project
uid: v1ProjectEntity_PostProjectEntity
generated: true
---

# POST Project

```http
POST /api/v1/Project
```

Creates a new ProjectEntity


Calls the Project agent service SaveProjectEntity.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/Project?$select=name,department,category/id
```


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

## Request Body: newEntity 

The ProjectEntity to be saved. 

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

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ProjectEntityWithLinks

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
| CreatedBy | Associate | The person that created the project |
| UpdatedBy | Associate | The person that last updated the project |
| Associate | Associate | The person that created the project  Use MDO List name "associate" to get list items. |
| ProjectStatus | ProjectStatus | Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on  Use MDO List name "projectstatus" to get list items. |
| ProjectType | ProjectType | Project type is a list defined by the database admin. for example: 'Large', 'Small', 'Party'...  Use MDO List name "projecttype" to get list items. |
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
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ProjectEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| PublishEventDate | date-time | Publish event date |
| PublishTo | date-time | Publication valid to (inclusive) |
| PublishFrom | date-time | Publication valid from (inclusive) |
| IsPublished | bool | Publication is published |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
POST /api/v1/Project
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 288,
  "Name": "Mueller Inc and Sons",
  "ProjectNumber": "687526",
  "ProjectMembers": [
    {
      "ProjectmemberId": 215,
      "ContactId": 564,
      "ProjectId": 592,
      "ContactName": "Gibson LLC",
      "ContactDepartment": "",
      "ProjectName": "Harris-Boyer",
      "EmailId": 288,
      "EmailAddress": "bessie.klocko@hand.us",
      "CountryId": 358,
      "Firstname": "Alanna",
      "MiddleName": "Johnson, Tromp and Berge",
      "Lastname": "Kessler",
      "PersonId": 493,
      "Mrmrs": "assumenda",
      "ProjectMemberTypeName": "Heller, Kunde and Upton",
      "Phone": "615.653.8939",
      "PhoneId": 639,
      "ProjectMemberTypeId": 981,
      "EmailAddressName": "zella@mcdermottcummerata.uk",
      "Comment": "corporis",
      "FullName": "Hardy Koch"
    }
  ],
  "Urls": [
    {
      "Value": "fuga",
      "StrippedValue": "ipsum",
      "Description": "Phased bottom-line encoding"
    },
    {
      "Value": "fuga",
      "StrippedValue": "ipsum",
      "Description": "Phased bottom-line encoding"
    }
  ],
  "CreatedDate": "2019-07-07T02:38:26.1985521+02:00",
  "UpdatedDate": "2015-06-10T02:38:26.1985521+02:00",
  "Description": "User-friendly encompassing forecast",
  "Postit": "in",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Balanced uniform internet solution",
  "ActiveStatusMonitorId": 510,
  "Links": [
    {
      "EntityName": "Kilback LLC",
      "Id": 841,
      "Description": "Down-sized object-oriented service-desk",
      "ExtraInfo": "vero",
      "LinkId": 860
    },
    {
      "EntityName": "Kilback LLC",
      "Id": 841,
      "Description": "Down-sized object-oriented service-desk",
      "ExtraInfo": "vero",
      "LinkId": 860
    }
  ],
  "ActiveLinks": 225,
  "Completed": false,
  "NextMilestoneDate": "2016-02-19T02:38:26.1985521+01:00",
  "NmdAppointmentId": 266,
  "EndDate": "2009-04-18T02:38:26.1985521+02:00",
  "ActiveErpLinks": 201,
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "Sandra Kemmer"
  },
  "ExtraFields": {
    "ExtraFields1": "aspernatur",
    "ExtraFields2": "est"
  },
  "CustomFields": {
    "CustomFields1": "nisi",
    "CustomFields2": "necessitatibus"
  },
  "PublishEventDate": "2011-03-14T02:38:26.1985521+01:00",
  "PublishTo": "2014-10-31T02:38:26.1985521+01:00",
  "PublishFrom": "1998-06-20T02:38:26.1985521+02:00",
  "IsPublished": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 478,
  "Name": "Erdman, McDermott and Yost",
  "ProjectNumber": "1398645",
  "ProjectMembers": [
    {
      "ProjectmemberId": 423,
      "ContactId": 63,
      "ProjectId": 810,
      "ContactName": "Langosh-Luettgen",
      "ContactDepartment": "",
      "ProjectName": "Rohan Group",
      "EmailId": 18,
      "EmailAddress": "ashtyn@vandervortstanton.ca",
      "CountryId": 382,
      "Firstname": "Pauline",
      "MiddleName": "Corwin-Krajcik",
      "Lastname": "Wunsch",
      "PersonId": 736,
      "Mrmrs": "ab",
      "ProjectMemberTypeName": "Bernhard-Cruickshank",
      "Phone": "202-792-1288 x260",
      "PhoneId": 690,
      "ProjectMemberTypeId": 410,
      "EmailAddressName": "reggie@runolfssonmurazik.com",
      "Comment": "dolorum",
      "FullName": "Citlalli Aufderhar",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 478
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "iusto",
      "StrippedValue": "sed",
      "Description": "Streamlined maximized Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 50
        }
      }
    },
    {
      "Value": "iusto",
      "StrippedValue": "sed",
      "Description": "Streamlined maximized Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 50
        }
      }
    }
  ],
  "CreatedDate": "2009-09-22T02:38:26.1985521+02:00",
  "UpdatedDate": "2014-04-13T02:38:26.1985521+02:00",
  "Description": "Face to face 24/7 synergy",
  "Postit": "nostrum",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Optional 6th generation forecast",
  "ActiveStatusMonitorId": 770,
  "Links": [
    {
      "EntityName": "Corwin-Emard",
      "Id": 67,
      "Description": "Cross-group impactful analyzer",
      "ExtraInfo": "et",
      "LinkId": 908,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 731
        }
      }
    }
  ],
  "ActiveLinks": 99,
  "Completed": false,
  "NextMilestoneDate": "2021-09-25T02:38:26.2141814+02:00",
  "NmdAppointmentId": 310,
  "EndDate": "2021-11-24T02:38:26.2141814+01:00",
  "ActiveErpLinks": 703,
  "UserDefinedFields": {
    "SuperOffice:1": "Jeremy Lockman",
    "SuperOffice:2": "Ms. Maud Renner V"
  },
  "ExtraFields": {
    "ExtraFields1": "ut",
    "ExtraFields2": "nihil"
  },
  "CustomFields": {
    "CustomFields1": "mollitia",
    "CustomFields2": "libero"
  },
  "PublishEventDate": "2011-12-07T02:38:26.2141814+01:00",
  "PublishTo": "2018-07-02T02:38:26.2141814+02:00",
  "PublishFrom": "2021-01-08T02:38:26.2141814+01:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 663
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```