---
title: PUT Contact/{id}
uid: v1ContactEntity_PutContactEntity
generated: true
content_type: reference
---

# PUT Contact/{id}

```http
PUT /api/v1/Contact/{id}
```

Updates the existing ContactEntity


NsApiSlow threshold: 2000 ms.





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
| UtmParameters | SavedUtmParameters | Utm parameters when creating first person and contact, readonly field |
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
| UtmParameters | SavedUtmParameters | Utm parameters when creating first person and contact, readonly field |
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
  "ContactId": 639,
  "Name": "Hand Group",
  "Department": "",
  "OrgNr": "831582",
  "Number1": "1838939",
  "Number2": "1403516",
  "UpdatedDate": "2008-11-11T03:40:55.5380785+01:00",
  "CreatedDate": "2023-04-16T03:40:55.5380785+02:00",
  "Emails": [
    {
      "Value": "dignissimos",
      "StrippedValue": "numquam",
      "Description": "Proactive needs-based initiative"
    },
    {
      "Value": "dignissimos",
      "StrippedValue": "numquam",
      "Description": "Proactive needs-based initiative"
    }
  ],
  "Interests": [
    {
      "Id": 58,
      "Name": "Tremblay-Yost",
      "ToolTip": "Doloremque fugiat excepturi ea itaque est.",
      "Deleted": false,
      "Rank": 147,
      "Type": "alias",
      "ColorBlock": 385,
      "IconHint": "rerum",
      "Selected": true,
      "LastChanged": "2002-09-16T03:40:55.5380785+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quidem",
      "StyleHint": "dolores",
      "Hidden": false,
      "FullName": "Marjorie Brekke"
    }
  ],
  "Urls": [
    {
      "Value": "aut",
      "StrippedValue": "rerum",
      "Description": "Persistent tangible functionalities"
    },
    {
      "Value": "aut",
      "StrippedValue": "rerum",
      "Description": "Persistent tangible functionalities"
    }
  ],
  "Phones": [
    {
      "Value": "et",
      "StrippedValue": "eaque",
      "Description": "Distributed encompassing capacity"
    },
    {
      "Value": "et",
      "StrippedValue": "eaque",
      "Description": "Distributed encompassing capacity"
    }
  ],
  "Faxes": [
    {
      "Value": "nulla",
      "StrippedValue": "qui",
      "Description": "Networked explicit middleware"
    },
    {
      "Value": "nulla",
      "StrippedValue": "qui",
      "Description": "Networked explicit middleware"
    }
  ],
  "Description": "Innovative full-range solution",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ab",
      "PersonId": 935,
      "Mrmrs": "voluptatem",
      "Firstname": "Kendrick",
      "Lastname": "McCullough",
      "MiddleName": "McDermott, Smith and Grant",
      "Title": "vel",
      "Description": "Synergized responsive infrastructure",
      "Email": "florine@yostschroeder.co.uk",
      "FullName": "Ms. Ansley Willie Schaden",
      "DirectPhone": "426.401.3540 x179",
      "FormalName": "Bartell, Abbott and Casper",
      "CountryId": 386,
      "ContactId": 213,
      "ContactName": "Bahringer, Hills and Schneider",
      "Retired": 771,
      "Rank": 713,
      "ActiveInterests": 985,
      "ContactDepartment": "",
      "ContactCountryId": 404,
      "ContactOrgNr": "1088136",
      "FaxPhone": "1-005-792-3043 x7986",
      "MobilePhone": "(321)495-2350 x587",
      "ContactPhone": "238.095.9787",
      "AssociateName": "Stroman-Carroll",
      "AssociateId": 201,
      "UsePersonAddress": false,
      "ContactFax": "perferendis",
      "Kanafname": "distinctio",
      "Kanalname": "tenetur",
      "Post1": "tempore",
      "Post2": "aliquid",
      "Post3": "recusandae",
      "EmailName": "ross@kuhnmckenzie.biz",
      "ContactFullName": "Ms. Stacey Talia Blick DDS",
      "ActiveErpLinks": 449,
      "TicketPriorityId": 576,
      "SupportLanguageId": 413,
      "SupportAssociateId": 754,
      "CategoryName": "VIP Customer",
      "PersonNumber": "701043"
    }
  ],
  "NoMailing": true,
  "Kananame": "rerum",
  "Xstop": false,
  "ActiveInterests": 544,
  "GroupId": 259,
  "ActiveStatusMonitorId": 891,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 4,
  "DbiAgentId": 781,
  "DbiLastSyncronized": "2008-05-18T03:40:55.5380785+02:00",
  "DbiKey": "rem",
  "DbiLastModified": "2018-12-03T03:40:55.5380785+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 688,
  "ActiveErpLinks": 742,
  "BounceEmails": [
    "ena_harris@shields.name",
    "eric.von@heaney.com"
  ],
  "Domains": [
    "rerum",
    "quo"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Mafalda Kertzmann",
    "SuperOffice:2": "538820164"
  },
  "ExtraFields": {
    "ExtraFields1": "placeat",
    "ExtraFields2": "quos"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "voluptatem"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 476,
  "Name": "Kuhlman Inc and Sons",
  "Department": "",
  "OrgNr": "490145",
  "Number1": "1069746",
  "Number2": "1262400",
  "UpdatedDate": "2024-08-31T03:40:55.5380785+02:00",
  "CreatedDate": "1998-05-29T03:40:55.5380785+02:00",
  "Emails": [
    {
      "Value": "voluptas",
      "StrippedValue": "libero",
      "Description": "Implemented coherent encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 154
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "libero",
      "Description": "Implemented coherent encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 154
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 14,
      "Name": "Bailey-Reilly",
      "ToolTip": "Neque omnis eos ducimus.",
      "Deleted": false,
      "Rank": 804,
      "Type": "est",
      "ColorBlock": 384,
      "IconHint": "unde",
      "Selected": true,
      "LastChanged": "2004-09-03T03:40:55.5380785+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nam",
      "StyleHint": "nulla",
      "Hidden": false,
      "FullName": "Dr. Trisha Larson",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 137
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "maxime",
      "StrippedValue": "aut",
      "Description": "Triple-buffered composite concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 657
        }
      }
    },
    {
      "Value": "maxime",
      "StrippedValue": "aut",
      "Description": "Triple-buffered composite concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 657
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "repellendus",
      "StrippedValue": "modi",
      "Description": "Multi-layered zero defect ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 354
        }
      }
    },
    {
      "Value": "repellendus",
      "StrippedValue": "modi",
      "Description": "Multi-layered zero defect ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 354
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "iure",
      "StrippedValue": "maxime",
      "Description": "Triple-buffered cohesive system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 681
        }
      }
    },
    {
      "Value": "iure",
      "StrippedValue": "maxime",
      "Description": "Triple-buffered cohesive system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 681
        }
      }
    }
  ],
  "Description": "Customer-focused 3rd generation interface",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "dolorem",
      "PersonId": 16,
      "Mrmrs": "corporis",
      "Firstname": "Nigel",
      "Lastname": "Kemmer",
      "MiddleName": "Moore LLC",
      "Title": "aut",
      "Description": "Polarised stable firmware",
      "Email": "john.stiedemann@howell.com",
      "FullName": "Dr. Anastacio Americo Brakus",
      "DirectPhone": "402.528.1086 x354",
      "FormalName": "Mayer Group",
      "CountryId": 276,
      "ContactId": 194,
      "ContactName": "Witting, Hintz and Muller",
      "Retired": 866,
      "Rank": 407,
      "ActiveInterests": 730,
      "ContactDepartment": "",
      "ContactCountryId": 58,
      "ContactOrgNr": "1061783",
      "FaxPhone": "109.516.8689",
      "MobilePhone": "1-832-765-9105 x5307",
      "ContactPhone": "594-841-8637",
      "AssociateName": "Collier-Ebert",
      "AssociateId": 745,
      "UsePersonAddress": true,
      "ContactFax": "magnam",
      "Kanafname": "non",
      "Kanalname": "optio",
      "Post1": "ratione",
      "Post2": "dolor",
      "Post3": "mollitia",
      "EmailName": "dangelo_kemmer@parkerpaucek.us",
      "ContactFullName": "Demond Harris",
      "ActiveErpLinks": 698,
      "TicketPriorityId": 526,
      "SupportLanguageId": 975,
      "SupportAssociateId": 660,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1170677",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 321
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "laudantium",
  "Xstop": false,
  "ActiveInterests": 88,
  "GroupId": 579,
  "ActiveStatusMonitorId": 210,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 499,
  "DbiAgentId": 839,
  "DbiLastSyncronized": "2013-10-22T03:40:55.5549004+02:00",
  "DbiKey": "pariatur",
  "DbiLastModified": "2005-07-12T03:40:55.5549004+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 323,
  "ActiveErpLinks": 980,
  "BounceEmails": [
    "joan_quigley@aufderhar.co.uk",
    "suzanne_stracke@cummingsboyer.info"
  ],
  "Domains": [
    "eveniet",
    "non"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Ms. Kris Javonte Lebsack",
    "SuperOffice:2": "Ofelia Stamm"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptatem",
    "ExtraFields2": "cum"
  },
  "CustomFields": {
    "CustomFields1": "iusto",
    "CustomFields2": "repellendus"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 951
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```