---
title: PUT Contact/{id}
uid: v1ContactEntity_PutContactEntity
generated: true
---

# PUT Contact/{id}

```http
PUT /api/v1/Contact/{id}
```

Updates the existing ContactEntity






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ContactEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/Contact/{id}?$select=name,department,category/id
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

The ContactEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer | Primary key |
| Name | String | Contact name |
| Department | String | Department |
| OrgNr | String | VAT number or similar |
| Number1 | String | Alphanumeric user field |
| Number2 | String | Alphanumeric user field |
| UpdatedDate | String | Date last updated  in UTC. |
| CreatedDate | String | Date registered  in UTC. |
| Emails | Array | The contact's email |
| Interests | Array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | Array | The contact's internet adresses |
| Phones | Array | The contact's phone numbers |
| Faxes | Array | The contact's fax numbers |
| Description | String | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | Array | The persons belonging to the contact. |
| NoMailing | Boolean | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | String | Contact kana name, used in Japanese versions only |
| Xstop | Boolean | STOP flag |
| ActiveInterests | Integer | The number of active interests. |
| GroupId | Integer | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | Integer | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | Integer | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | Integer | Integration agent (eJournal) |
| DbiLastSyncronized | String | Last external syncronization. |
| DbiKey | String | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | String | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | Integer | How did we get this contact? For future integration needs |
| ActiveErpLinks | Integer | The number of active erp links |
| BounceEmails | Array | Email addresses with a positive bounce counter. |
| Domains | Array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |

## Response:

ContactEntity updated.

| Response | Description |
|----------------|-------------|
| 200 | ContactEntity updated. |
| 412 | Update stopped because ContactEntity has changed since the requested If-Unmodified-Since timestamp. |
| 400 | Bad request. Entity to save is not in request body. |

### Response body: ContactEntityWithLinks

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 | Primary key |
| Name | string | Contact name |
| Department | string | Department |
| OrgNr | string | VAT number or similar |
| Number1 | string | Alphanumeric user field |
| Number2 | string | Alphanumeric user field |
| UpdatedDate | date-time | Date last updated  in UTC. |
| CreatedDate | date-time | Date registered  in UTC. |
| Emails | array | The contact's email |
| Interests | array | The contact's available and selected interests.  Use MDO List name "contint" to get list items. |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  Use MDO List name "associate" to get list items. |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  Use MDO List name "business" to get list items. |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  Use MDO List name "category" to get list items. |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  Use MDO List name "country" to get list items. |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | Use MDO List name "associate" to get list items. |
| TicketPriority | TicketPriority | Use MDO List name "ticketpriority" to get list items. |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the Person Agent. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered.  Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/Contact/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 277,
  "Name": "Lubowitz LLC",
  "Department": "",
  "OrgNr": "1374370",
  "Number1": "1890105",
  "Number2": "915384",
  "UpdatedDate": "2007-06-06T04:22:34.796505+02:00",
  "CreatedDate": "1998-06-12T04:22:34.796505+02:00",
  "Emails": [
    {
      "Value": "molestiae",
      "StrippedValue": "dolorum",
      "Description": "Innovative maximized parallelism"
    },
    {
      "Value": "molestiae",
      "StrippedValue": "dolorum",
      "Description": "Innovative maximized parallelism"
    }
  ],
  "Interests": [
    {
      "Id": 949,
      "Name": "Jakubowski, Lebsack and Mitchell",
      "ToolTip": "Iure dolore facere esse nemo sed.",
      "Deleted": false,
      "Rank": 899,
      "Type": "explicabo",
      "ColorBlock": 475,
      "IconHint": "quis",
      "Selected": true,
      "LastChanged": "2003-10-12T04:22:34.796505+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eveniet",
      "StyleHint": "qui",
      "Hidden": false,
      "FullName": "Justine Pagac"
    }
  ],
  "Urls": [
    {
      "Value": "quisquam",
      "StrippedValue": "sed",
      "Description": "Extended optimal neural-net"
    },
    {
      "Value": "quisquam",
      "StrippedValue": "sed",
      "Description": "Extended optimal neural-net"
    }
  ],
  "Phones": [
    {
      "Value": "est",
      "StrippedValue": "maiores",
      "Description": "Fundamental global extranet"
    },
    {
      "Value": "est",
      "StrippedValue": "maiores",
      "Description": "Fundamental global extranet"
    }
  ],
  "Faxes": [
    {
      "Value": "sed",
      "StrippedValue": "aut",
      "Description": "Object-based heuristic installation"
    },
    {
      "Value": "sed",
      "StrippedValue": "aut",
      "Description": "Object-based heuristic installation"
    }
  ],
  "Description": "Progressive 24/7 interface",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "nihil",
      "PersonId": 771,
      "Mrmrs": "aut",
      "Firstname": "Marge",
      "Lastname": "Herman",
      "MiddleName": "McGlynn, Bernhard and Emmerich",
      "Title": "distinctio",
      "Description": "Versatile optimal neural-net",
      "Email": "robbie@schowalter.uk",
      "FullName": "Myrna Boehm",
      "DirectPhone": "1-213-183-6287 x725",
      "FormalName": "Turcotte Group",
      "CountryId": 55,
      "ContactId": 223,
      "ContactName": "Schmeler, Torphy and Dooley",
      "Retired": 156,
      "Rank": 272,
      "ActiveInterests": 472,
      "ContactDepartment": "",
      "ContactCountryId": 672,
      "ContactOrgNr": "819582",
      "FaxPhone": "972.980.8909 x07876",
      "MobilePhone": "(380)956-5244 x99350",
      "ContactPhone": "702-330-8034",
      "AssociateName": "Stanton Group",
      "AssociateId": 132,
      "UsePersonAddress": true,
      "ContactFax": "consequatur",
      "Kanafname": "reiciendis",
      "Kanalname": "vel",
      "Post1": "adipisci",
      "Post2": "quasi",
      "Post3": "dolores",
      "EmailName": "fleta@kunze.uk",
      "ContactFullName": "Ephraim Schroeder",
      "ActiveErpLinks": 158,
      "TicketPriorityId": 335,
      "SupportLanguageId": 154,
      "SupportAssociateId": 253,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "consequatur",
  "Xstop": true,
  "ActiveInterests": 196,
  "GroupId": 567,
  "ActiveStatusMonitorId": 152,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 568,
  "DbiAgentId": 232,
  "DbiLastSyncronized": "1998-06-18T04:22:34.796505+02:00",
  "DbiKey": "atque",
  "DbiLastModified": "2006-10-12T04:22:34.796505+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 92,
  "ActiveErpLinks": 913,
  "BounceEmails": [
    "stacey@lakinondricka.co.uk",
    "walker.schiller@harber.com"
  ],
  "Domains": [
    "ut",
    "autem"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Darby Donnelly",
    "SuperOffice:2": "1157478520"
  },
  "ExtraFields": {
    "ExtraFields1": "qui",
    "ExtraFields2": "adipisci"
  },
  "CustomFields": {
    "CustomFields1": "dolore",
    "CustomFields2": "nam"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 95,
  "Name": "Effertz, Koelpin and Lehner",
  "Department": "",
  "OrgNr": "1176737",
  "Number1": "1090518",
  "Number2": "746823",
  "UpdatedDate": "2007-03-19T04:22:34.8121261+01:00",
  "CreatedDate": "1998-09-05T04:22:34.8121261+02:00",
  "Emails": [
    {
      "Value": "officiis",
      "StrippedValue": "in",
      "Description": "Open-architected 24 hour solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 382
        }
      }
    },
    {
      "Value": "officiis",
      "StrippedValue": "in",
      "Description": "Open-architected 24 hour solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 382
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 480,
      "Name": "Weimann, Osinski and Davis",
      "ToolTip": "Qui excepturi dolorem sequi.",
      "Deleted": false,
      "Rank": 484,
      "Type": "et",
      "ColorBlock": 300,
      "IconHint": "neque",
      "Selected": true,
      "LastChanged": "2002-05-02T04:22:34.8121261+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "placeat",
      "StyleHint": "quas",
      "Hidden": false,
      "FullName": "Jaquan Williamson",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 981
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "minus",
      "StrippedValue": "aliquid",
      "Description": "Configurable incremental adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 124
        }
      }
    },
    {
      "Value": "minus",
      "StrippedValue": "aliquid",
      "Description": "Configurable incremental adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 124
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "quasi",
      "StrippedValue": "rem",
      "Description": "Realigned full-range throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 926
        }
      }
    },
    {
      "Value": "quasi",
      "StrippedValue": "rem",
      "Description": "Realigned full-range throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 926
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "voluptatem",
      "StrippedValue": "nobis",
      "Description": "Secured radical flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 178
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "nobis",
      "Description": "Secured radical flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 178
        }
      }
    }
  ],
  "Description": "Multi-channelled high-level throughput",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "alias",
      "PersonId": 819,
      "Mrmrs": "et",
      "Firstname": "Domenica",
      "Lastname": "Schaden",
      "MiddleName": "Schuster-Dietrich",
      "Title": "beatae",
      "Description": "Front-line eco-centric adapter",
      "Email": "jacquelyn.bosco@glover.info",
      "FullName": "Bryon Dicki",
      "DirectPhone": "(971)813-4496 x584",
      "FormalName": "Swift Inc and Sons",
      "CountryId": 425,
      "ContactId": 622,
      "ContactName": "Kuvalis-Walter",
      "Retired": 374,
      "Rank": 82,
      "ActiveInterests": 420,
      "ContactDepartment": "",
      "ContactCountryId": 515,
      "ContactOrgNr": "1095195",
      "FaxPhone": "1-754-355-9839 x32302",
      "MobilePhone": "376-751-5755",
      "ContactPhone": "549.638.5296 x93301",
      "AssociateName": "Howell, Hickle and King",
      "AssociateId": 605,
      "UsePersonAddress": false,
      "ContactFax": "nihil",
      "Kanafname": "voluptas",
      "Kanalname": "enim",
      "Post1": "dolorem",
      "Post2": "adipisci",
      "Post3": "suscipit",
      "EmailName": "jarrett_jerde@mcdermott.name",
      "ContactFullName": "Edward Ferry",
      "ActiveErpLinks": 648,
      "TicketPriorityId": 844,
      "SupportLanguageId": 914,
      "SupportAssociateId": 650,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 404
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "asperiores",
  "Xstop": false,
  "ActiveInterests": 383,
  "GroupId": 986,
  "ActiveStatusMonitorId": 712,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 873,
  "DbiAgentId": 147,
  "DbiLastSyncronized": "2015-03-07T04:22:34.8121261+01:00",
  "DbiKey": "dolores",
  "DbiLastModified": "2006-11-06T04:22:34.8121261+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 678,
  "ActiveErpLinks": 561,
  "BounceEmails": [
    "sonya@schimmel.biz",
    "harmony.barton@strackerowe.uk"
  ],
  "Domains": [
    "aut",
    "porro"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1389435078",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "ex",
    "ExtraFields2": "saepe"
  },
  "CustomFields": {
    "CustomFields1": "nesciunt",
    "CustomFields2": "ut"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 410
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```