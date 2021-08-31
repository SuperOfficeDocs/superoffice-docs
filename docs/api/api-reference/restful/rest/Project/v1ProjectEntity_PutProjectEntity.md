---
title: PUT Project/{id}
id: v1ProjectEntity_PutProjectEntity
---

# PUT Project/{id}

```http
PUT /api/v1/Project/{id}
```

Updates the existing ProjectEntity






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ProjectEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/Project/{id}?$select=name,department,category/id
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

## Request Body: entity  

The ProjectEntity to be saved. 

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

The Project Service. The service implements all services working with the Project object



ProjectEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | ProjectEntity updated. |
| 412 | Update stopped because ProjectEntity has changed since the requested If-Unmodified-Since timestamp. |
| 400 | Bad request. Entity to save is not in request body. |

Response body: object

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
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
PUT /api/v1/Project/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 866,
  "Name": "Block LLC",
  "ProjectNumber": "418572",
  "ProjectMembers": [
    {
      "ProjectmemberId": 179,
      "ContactId": 738,
      "ProjectId": 785,
      "ContactName": "Mayert, Robel and Feeney",
      "ContactDepartment": "",
      "ProjectName": "Fritsch LLC",
      "EmailId": 568,
      "EmailAddress": "fernando_hoppe@langschaden.info",
      "CountryId": 773,
      "Firstname": "Eldred",
      "MiddleName": "Senger-Kiehn",
      "Lastname": "Brown",
      "PersonId": 991,
      "Mrmrs": "dolor",
      "ProjectMemberTypeName": "Greenholt, McGlynn and Armstrong",
      "Phone": "811.563.5625 x3344",
      "PhoneId": 847,
      "ProjectMemberTypeId": 481,
      "EmailAddressName": "kenya_cummerata@tillmanernser.name",
      "Comment": "totam",
      "FullName": "Alana Koelpin"
    }
  ],
  "Urls": [
    {
      "Value": "a",
      "StrippedValue": "omnis",
      "Description": "Digitized global Graphical User Interface"
    },
    {
      "Value": "a",
      "StrippedValue": "omnis",
      "Description": "Digitized global Graphical User Interface"
    }
  ],
  "CreatedDate": "2015-01-06T15:05:42.4626673+01:00",
  "UpdatedDate": "1999-10-21T15:05:42.4626673+02:00",
  "Description": "Right-sized grid-enabled conglomeration",
  "Postit": "perferendis",
  "CreatedBy": {
    "AssociateId": 902,
    "Name": "Bins-Marquardt",
    "PersonId": 489,
    "Rank": 368,
    "Tooltip": "voluptatem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 984,
    "FullName": "Cassandre Barton",
    "FormalName": "Denesik, Fay and Gorczany",
    "Deleted": false,
    "EjUserId": 628,
    "UserName": "Skiles LLC"
  },
  "UpdatedBy": {
    "AssociateId": 364,
    "Name": "Heller, Bernhard and Johnston",
    "PersonId": 238,
    "Rank": 976,
    "Tooltip": "neque",
    "Type": "AnonymousAssociate",
    "GroupIdx": 521,
    "FullName": "Enoch Kunde",
    "FormalName": "Tremblay Inc and Sons",
    "Deleted": false,
    "EjUserId": 766,
    "UserName": "Farrell-Auer"
  },
  "Associate": {
    "AssociateId": 702,
    "Name": "Jacobi LLC",
    "PersonId": 61,
    "Rank": 568,
    "Tooltip": "pariatur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 891,
    "FullName": "Dedrick Boyle I",
    "FormalName": "Johns Group",
    "Deleted": true,
    "EjUserId": 50,
    "UserName": "Schuppe, Turcotte and Oberbrunner"
  },
  "ProjectStatus": {
    "Id": 166,
    "Value": "est",
    "Tooltip": "vel"
  },
  "ProjectType": {
    "Id": 331,
    "Value": "dignissimos",
    "Tooltip": "molestiae"
  },
  "HasImage": true,
  "ImageDescription": "Cross-platform empowering moratorium",
  "ActiveStatusMonitorId": 972,
  "Links": [
    {
      "EntityName": "Jaskolski Inc and Sons",
      "Id": 315,
      "Description": "Grass-roots modular open system",
      "ExtraInfo": "in",
      "LinkId": 29
    },
    {
      "EntityName": "Jaskolski Inc and Sons",
      "Id": 315,
      "Description": "Grass-roots modular open system",
      "ExtraInfo": "in",
      "LinkId": 29
    }
  ],
  "ActiveLinks": 675,
  "Completed": false,
  "NextMilestoneDate": "2002-03-05T15:05:42.4656676+01:00",
  "NmdAppointmentId": 304,
  "EndDate": "2011-05-11T15:05:42.4656676+02:00",
  "ActiveErpLinks": 303,
  "UserDefinedFields": {
    "SuperOffice:1": "Darrion Schneider",
    "SuperOffice:2": "1316830864"
  },
  "ExtraFields": {
    "ExtraFields1": "occaecati",
    "ExtraFields2": "dignissimos"
  },
  "CustomFields": {
    "CustomFields1": "illum",
    "CustomFields2": "magni"
  },
  "PublishEventDate": "1997-03-15T15:05:42.4666694+01:00",
  "PublishTo": "2001-02-15T15:05:42.4666694+01:00",
  "PublishFrom": "1995-01-09T15:05:42.4666694+01:00",
  "IsPublished": true
}
```

```http_
HTTP/1.1 200 ProjectEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 150,
  "Name": "Ankunding LLC",
  "ProjectNumber": "749426",
  "ProjectMembers": [
    {
      "ProjectmemberId": 547,
      "ContactId": 584,
      "ProjectId": 330,
      "ContactName": "Schimmel, Wisoky and Nitzsche",
      "ContactDepartment": "",
      "ProjectName": "Bergstrom Inc and Sons",
      "EmailId": 304,
      "EmailAddress": "issac_ebert@nienowmann.biz",
      "CountryId": 391,
      "Firstname": "Zelma",
      "MiddleName": "Greenfelder LLC",
      "Lastname": "Dickinson",
      "PersonId": 983,
      "Mrmrs": "et",
      "ProjectMemberTypeName": "Block LLC",
      "Phone": "210.783.5682 x21037",
      "PhoneId": 864,
      "ProjectMemberTypeId": 939,
      "EmailAddressName": "garrett_terry@lockman.ca",
      "Comment": "maiores",
      "FullName": "Nick Bayer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 653
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "unde",
      "StrippedValue": "nihil",
      "Description": "Face to face 24 hour website",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 103
        }
      }
    },
    {
      "Value": "unde",
      "StrippedValue": "nihil",
      "Description": "Face to face 24 hour website",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 103
        }
      }
    }
  ],
  "CreatedDate": "2013-05-07T15:05:42.4706357+02:00",
  "UpdatedDate": "1999-06-18T15:05:42.4706357+02:00",
  "Description": "Devolved directional paradigm",
  "Postit": "nihil",
  "CreatedBy": {
    "AssociateId": 850,
    "Name": "Kunde LLC",
    "PersonId": 753,
    "Rank": 765,
    "Tooltip": "placeat",
    "Type": "AnonymousAssociate",
    "GroupIdx": 251,
    "FullName": "Charlie Harris IV",
    "FormalName": "Rempel, Lockman and Hahn",
    "Deleted": false,
    "EjUserId": 535,
    "UserName": "Schiller Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 935
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 245,
    "Name": "Schoen, Emmerich and Bauch",
    "PersonId": 725,
    "Rank": 286,
    "Tooltip": "enim",
    "Type": "AnonymousAssociate",
    "GroupIdx": 606,
    "FullName": "Lynn Bahringer",
    "FormalName": "Kautzer-Reynolds",
    "Deleted": true,
    "EjUserId": 598,
    "UserName": "Mann, Mann and Bode",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 790
      }
    }
  },
  "Associate": {
    "AssociateId": 618,
    "Name": "Denesik Inc and Sons",
    "PersonId": 874,
    "Rank": 496,
    "Tooltip": "nesciunt",
    "Type": "AnonymousAssociate",
    "GroupIdx": 771,
    "FullName": "Mr. Jacey Beahan",
    "FormalName": "Koelpin, Marvin and West",
    "Deleted": false,
    "EjUserId": 878,
    "UserName": "Littel-Hessel",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 587
      }
    }
  },
  "ProjectStatus": {
    "Id": 369,
    "Value": "impedit",
    "Tooltip": "magnam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 753
      }
    }
  },
  "ProjectType": {
    "Id": 90,
    "Value": "minus",
    "Tooltip": "qui",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 703
      }
    }
  },
  "HasImage": false,
  "ImageDescription": "Customizable mobile software",
  "ActiveStatusMonitorId": 105,
  "Links": [
    {
      "EntityName": "Paucek-King",
      "Id": 313,
      "Description": "Extended analyzing open system",
      "ExtraInfo": "rerum",
      "LinkId": 694,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 249
        }
      }
    }
  ],
  "ActiveLinks": 594,
  "Completed": false,
  "NextMilestoneDate": "2012-03-19T15:05:42.4716372+01:00",
  "NmdAppointmentId": 521,
  "EndDate": "2011-04-09T15:05:42.4716372+02:00",
  "ActiveErpLinks": 978,
  "UserDefinedFields": {
    "SuperOffice:1": "1206888148",
    "SuperOffice:2": "Miss Victoria Prohaska"
  },
  "ExtraFields": {
    "ExtraFields1": "ut",
    "ExtraFields2": "sapiente"
  },
  "CustomFields": {
    "CustomFields1": "sunt",
    "CustomFields2": "quos"
  },
  "PublishEventDate": "1999-09-15T15:05:42.4726355+02:00",
  "PublishTo": "2006-11-14T15:05:42.4726355+01:00",
  "PublishFrom": "2003-09-01T15:05:42.4726355+02:00",
  "IsPublished": false,
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 359
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```