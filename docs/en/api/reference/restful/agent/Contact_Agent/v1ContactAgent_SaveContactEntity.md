---
title: POST Agents/Contact/SaveContactEntity
uid: v1ContactAgent_SaveContactEntity
---

# POST Agents/Contact/SaveContactEntity

```http
POST /api/v1/Agents/Contact/SaveContactEntity
```

Updates the existing ContactEntity or creates a new ContactEntity if the id parameter is empty








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

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ContactEntity

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
| Interests | array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Contact/SaveContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 209,
  "Name": "Kerluke, Bosco and Flatley",
  "Department": "",
  "OrgNr": "1764668",
  "Number1": "1079991",
  "Number2": "1303571",
  "UpdatedDate": "2001-08-08T11:22:37.6336208+02:00",
  "CreatedDate": "2002-09-22T11:22:37.6336208+02:00",
  "Emails": [
    {
      "Value": "sint",
      "StrippedValue": "iusto",
      "Description": "Re-engineered high-level concept"
    },
    {
      "Value": "sint",
      "StrippedValue": "iusto",
      "Description": "Re-engineered high-level concept"
    }
  ],
  "Interests": [
    {
      "Id": 194,
      "Name": "O'Hara, Mante and Dicki",
      "ToolTip": "Assumenda culpa iure minus.",
      "Deleted": true,
      "Rank": 803,
      "Type": "voluptatem",
      "ColorBlock": 562,
      "IconHint": "sed",
      "Selected": true,
      "LastChanged": "2014-04-22T11:22:37.6336208+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quae",
      "StyleHint": "eaque",
      "Hidden": false,
      "FullName": "Emilia Kshlerin"
    }
  ],
  "Urls": [
    {
      "Value": "nihil",
      "StrippedValue": "non",
      "Description": "Organized bandwidth-monitored portal"
    },
    {
      "Value": "nihil",
      "StrippedValue": "non",
      "Description": "Organized bandwidth-monitored portal"
    }
  ],
  "Phones": [
    {
      "Value": "quasi",
      "StrippedValue": "dicta",
      "Description": "Cross-platform tangible solution"
    },
    {
      "Value": "quasi",
      "StrippedValue": "dicta",
      "Description": "Cross-platform tangible solution"
    }
  ],
  "Faxes": [
    {
      "Value": "sint",
      "StrippedValue": "inventore",
      "Description": "Operative mission-critical definition"
    },
    {
      "Value": "sint",
      "StrippedValue": "inventore",
      "Description": "Operative mission-critical definition"
    }
  ],
  "Description": "Operative modular parallelism",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ut",
      "PersonId": 784,
      "Mrmrs": "explicabo",
      "Firstname": "Alvis",
      "Lastname": "Zieme",
      "MiddleName": "Ratke-Larson",
      "Title": "est",
      "Description": "Stand-alone 3rd generation forecast",
      "Email": "jeanne@mcculloughfahey.us",
      "FullName": "Mathias Greenholt",
      "DirectPhone": "183.490.4297 x479",
      "FormalName": "Satterfield Inc and Sons",
      "CountryId": 472,
      "ContactId": 567,
      "ContactName": "Keeling LLC",
      "Retired": 516,
      "Rank": 519,
      "ActiveInterests": 669,
      "ContactDepartment": "",
      "ContactCountryId": 846,
      "ContactOrgNr": "297413",
      "FaxPhone": "680-415-3873",
      "MobilePhone": "(905)196-9756",
      "ContactPhone": "120.427.4433 x36157",
      "AssociateName": "Hansen, Brekke and Pfannerstill",
      "AssociateId": 405,
      "UsePersonAddress": false,
      "ContactFax": "aut",
      "Kanafname": "soluta",
      "Kanalname": "nisi",
      "Post1": "nihil",
      "Post2": "possimus",
      "Post3": "labore",
      "EmailName": "theodora@doyleprohaska.uk",
      "ContactFullName": "Mrs. Eric Sigmund Schmitt",
      "ActiveErpLinks": 402,
      "TicketPriorityId": 640,
      "SupportLanguageId": 204,
      "SupportAssociateId": 569,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "recusandae",
  "Xstop": false,
  "ActiveInterests": 72,
  "GroupId": 860,
  "ActiveStatusMonitorId": 828,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 466,
  "DbiAgentId": 313,
  "DbiLastSyncronized": "2009-11-14T11:22:37.6336208+01:00",
  "DbiKey": "atque",
  "DbiLastModified": "2014-04-06T11:22:37.6336208+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 941,
  "ActiveErpLinks": 438,
  "BounceEmails": [
    "malcolm_mills@pacocha.biz",
    "tommie_batz@hahn.info"
  ],
  "Domains": [
    "dolores",
    "nesciunt"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "Prof. Imani Adele Okuneva DDS"
  },
  "ExtraFields": {
    "ExtraFields1": "eum",
    "ExtraFields2": "aliquam"
  },
  "CustomFields": {
    "CustomFields1": "aut",
    "CustomFields2": "et"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 111,
  "Name": "Doyle-Howe",
  "Department": "",
  "OrgNr": "844220",
  "Number1": "1035068",
  "Number2": "1714951",
  "UpdatedDate": "2022-09-11T11:22:37.6492429+02:00",
  "CreatedDate": "2020-05-09T11:22:37.6492429+02:00",
  "Emails": [
    {
      "Value": "dolorum",
      "StrippedValue": "eveniet",
      "Description": "Expanded cohesive implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 35
        }
      }
    },
    {
      "Value": "dolorum",
      "StrippedValue": "eveniet",
      "Description": "Expanded cohesive implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 35
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 762,
      "Name": "Haley-Strosin",
      "ToolTip": "Molestias dolor tenetur dolor quia soluta.",
      "Deleted": false,
      "Rank": 487,
      "Type": "rerum",
      "ColorBlock": 974,
      "IconHint": "nostrum",
      "Selected": true,
      "LastChanged": "2021-08-05T11:22:37.6492429+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "doloremque",
      "StyleHint": "fugit",
      "Hidden": false,
      "FullName": "Aidan O'Keefe",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 882
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "est",
      "StrippedValue": "vel",
      "Description": "Programmable stable task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 656
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "vel",
      "Description": "Programmable stable task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 656
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "reprehenderit",
      "StrippedValue": "vitae",
      "Description": "Cross-group web-enabled project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 520
        }
      }
    },
    {
      "Value": "reprehenderit",
      "StrippedValue": "vitae",
      "Description": "Cross-group web-enabled project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 520
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "minus",
      "StrippedValue": "officia",
      "Description": "Devolved asynchronous customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 314
        }
      }
    },
    {
      "Value": "minus",
      "StrippedValue": "officia",
      "Description": "Devolved asynchronous customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 314
        }
      }
    }
  ],
  "Description": "Reduced multi-tasking budgetary management",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "delectus",
      "PersonId": 279,
      "Mrmrs": "molestiae",
      "Firstname": "Jo",
      "Lastname": "Bartoletti",
      "MiddleName": "Medhurst-Bergstrom",
      "Title": "magnam",
      "Description": "Diverse directional orchestration",
      "Email": "paul_dicki@daugherty.co.uk",
      "FullName": "Sadie Quinn Kertzmann I",
      "DirectPhone": "011-514-7512",
      "FormalName": "Mertz Inc and Sons",
      "CountryId": 551,
      "ContactId": 355,
      "ContactName": "Stracke Group",
      "Retired": 203,
      "Rank": 949,
      "ActiveInterests": 523,
      "ContactDepartment": "",
      "ContactCountryId": 320,
      "ContactOrgNr": "1602989",
      "FaxPhone": "1-883-210-2219",
      "MobilePhone": "1-748-383-1574 x81269",
      "ContactPhone": "1-771-628-5539 x08899",
      "AssociateName": "Kertzmann-Bernhard",
      "AssociateId": 400,
      "UsePersonAddress": false,
      "ContactFax": "veritatis",
      "Kanafname": "aut",
      "Kanalname": "ut",
      "Post1": "voluptates",
      "Post2": "fugiat",
      "Post3": "sint",
      "EmailName": "jermaine_huel@streich.name",
      "ContactFullName": "Barney Florencio Reichert DDS",
      "ActiveErpLinks": 274,
      "TicketPriorityId": 875,
      "SupportLanguageId": 832,
      "SupportAssociateId": 656,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 954
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "voluptas",
  "Xstop": false,
  "ActiveInterests": 478,
  "GroupId": 609,
  "ActiveStatusMonitorId": 653,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 862,
  "DbiAgentId": 670,
  "DbiLastSyncronized": "2008-05-01T11:22:37.6492429+02:00",
  "DbiKey": "est",
  "DbiLastModified": "2001-09-16T11:22:37.6492429+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 630,
  "ActiveErpLinks": 12,
  "BounceEmails": [
    "ceasar@daniel.info",
    "kameron@labadie.biz"
  ],
  "Domains": [
    "quia",
    "omnis"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Raleigh Sauer",
    "SuperOffice:2": "Beulah Paucek"
  },
  "ExtraFields": {
    "ExtraFields1": "nesciunt",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "unde",
    "CustomFields2": "et"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 740
    }
  }
}
```