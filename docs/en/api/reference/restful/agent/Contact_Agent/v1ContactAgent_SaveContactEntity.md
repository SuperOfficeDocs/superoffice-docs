---
title: POST Agents/Contact/SaveContactEntity
uid: v1ContactAgent_SaveContactEntity
generated: true
content_type: reference
---

# POST Agents/Contact/SaveContactEntity

```http
POST /api/v1/Agents/Contact/SaveContactEntity
```

Updates the existing ContactEntity or creates a new ContactEntity if the id parameter is 0.








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

## Request Body: contactEntity 

The ContactEntity that is saved 

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
| InitialUtmParameters | InitalUtmParameters | Initial utm parameters when creating first person, readonly field |
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
| InitialUtmParameters | InitalUtmParameters | Initial utm parameters when creating first person, readonly field |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Contact/SaveContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 923,
  "Name": "Lockman Inc and Sons",
  "Department": "",
  "OrgNr": "1829062",
  "Number1": "963331",
  "Number2": "363404",
  "UpdatedDate": "2013-06-20T03:46:54.4726424+02:00",
  "CreatedDate": "2008-12-31T03:46:54.4726424+01:00",
  "Emails": [
    {
      "Value": "id",
      "StrippedValue": "dolores",
      "Description": "Advanced non-volatile moratorium"
    },
    {
      "Value": "id",
      "StrippedValue": "dolores",
      "Description": "Advanced non-volatile moratorium"
    }
  ],
  "Interests": [
    {
      "Id": 194,
      "Name": "Kub-Moore",
      "ToolTip": "Beatae explicabo vero.",
      "Deleted": false,
      "Rank": 385,
      "Type": "ullam",
      "ColorBlock": 940,
      "IconHint": "sunt",
      "Selected": false,
      "LastChanged": "2014-04-12T03:46:54.4726424+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ipsa",
      "StyleHint": "illum",
      "Hidden": true,
      "FullName": "Eliezer Ward"
    }
  ],
  "Urls": [
    {
      "Value": "consectetur",
      "StrippedValue": "consequatur",
      "Description": "Decentralized local success"
    },
    {
      "Value": "consectetur",
      "StrippedValue": "consequatur",
      "Description": "Decentralized local success"
    }
  ],
  "Phones": [
    {
      "Value": "cum",
      "StrippedValue": "sequi",
      "Description": "Expanded 24 hour artificial intelligence"
    },
    {
      "Value": "cum",
      "StrippedValue": "sequi",
      "Description": "Expanded 24 hour artificial intelligence"
    }
  ],
  "Faxes": [
    {
      "Value": "modi",
      "StrippedValue": "eos",
      "Description": "Realigned 24 hour initiative"
    },
    {
      "Value": "modi",
      "StrippedValue": "eos",
      "Description": "Realigned 24 hour initiative"
    }
  ],
  "Description": "Assimilated empowering throughput",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "sed",
      "PersonId": 134,
      "Mrmrs": "unde",
      "Firstname": "Emerson",
      "Lastname": "Mitchell",
      "MiddleName": "Hessel Inc and Sons",
      "Title": "repudiandae",
      "Description": "Quality-focused dynamic challenge",
      "Email": "elda@mayer.uk",
      "FullName": "Dr. Arnulfo Valentine Ward",
      "DirectPhone": "359.113.7400 x31356",
      "FormalName": "O'Reilly Inc and Sons",
      "CountryId": 759,
      "ContactId": 178,
      "ContactName": "Kovacek-Kunze",
      "Retired": 684,
      "Rank": 392,
      "ActiveInterests": 668,
      "ContactDepartment": "",
      "ContactCountryId": 485,
      "ContactOrgNr": "927711",
      "FaxPhone": "(114)248-1794 x485",
      "MobilePhone": "(131)939-2521 x176",
      "ContactPhone": "348-517-3991 x6261",
      "AssociateName": "Hintz, O'Reilly and Larson",
      "AssociateId": 792,
      "UsePersonAddress": true,
      "ContactFax": "ea",
      "Kanafname": "aut",
      "Kanalname": "doloremque",
      "Post1": "libero",
      "Post2": "quam",
      "Post3": "perspiciatis",
      "EmailName": "erika@kemmer.info",
      "ContactFullName": "Orrin Aufderhar",
      "ActiveErpLinks": 701,
      "TicketPriorityId": 227,
      "SupportLanguageId": 868,
      "SupportAssociateId": 355,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1166449"
    }
  ],
  "NoMailing": false,
  "Kananame": "amet",
  "Xstop": false,
  "ActiveInterests": 706,
  "GroupId": 794,
  "ActiveStatusMonitorId": 196,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 557,
  "DbiAgentId": 77,
  "DbiLastSyncronized": "2017-04-05T03:46:54.4882666+02:00",
  "DbiKey": "voluptas",
  "DbiLastModified": "2010-11-02T03:46:54.4882666+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 520,
  "ActiveErpLinks": 906,
  "BounceEmails": [
    "pascale@jaskolskipredovic.biz",
    "imani.turcotte@vonrueden.ca"
  ],
  "Domains": [
    "sed",
    "harum"
  ],
  "InitialUtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Vivian Reichert",
    "SuperOffice:2": "Mrs. Albin Brakus DVM"
  },
  "ExtraFields": {
    "ExtraFields1": "ex",
    "ExtraFields2": "modi"
  },
  "CustomFields": {
    "CustomFields1": "debitis",
    "CustomFields2": "dolorem"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 827,
  "Name": "Mante Group",
  "Department": "",
  "OrgNr": "869410",
  "Number1": "519995",
  "Number2": "641662",
  "UpdatedDate": "1999-08-18T03:46:54.4882666+02:00",
  "CreatedDate": "2021-01-25T03:46:54.4882666+01:00",
  "Emails": [
    {
      "Value": "eligendi",
      "StrippedValue": "velit",
      "Description": "Customizable web-enabled array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 255
        }
      }
    },
    {
      "Value": "eligendi",
      "StrippedValue": "velit",
      "Description": "Customizable web-enabled array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 255
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 735,
      "Name": "Stehr Group",
      "ToolTip": "Maiores rerum nihil.",
      "Deleted": true,
      "Rank": 121,
      "Type": "harum",
      "ColorBlock": 66,
      "IconHint": "inventore",
      "Selected": false,
      "LastChanged": "2005-03-20T03:46:54.4882666+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quia",
      "StyleHint": "alias",
      "Hidden": false,
      "FullName": "Mrs. Franco Huels III",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 357
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "quis",
      "StrippedValue": "porro",
      "Description": "Phased context-sensitive matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 289
        }
      }
    },
    {
      "Value": "quis",
      "StrippedValue": "porro",
      "Description": "Phased context-sensitive matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 289
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "pariatur",
      "StrippedValue": "sunt",
      "Description": "Synergistic 5th generation service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 388
        }
      }
    },
    {
      "Value": "pariatur",
      "StrippedValue": "sunt",
      "Description": "Synergistic 5th generation service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 388
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "ea",
      "StrippedValue": "ipsum",
      "Description": "Customer-focused bi-directional complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 211
        }
      }
    },
    {
      "Value": "ea",
      "StrippedValue": "ipsum",
      "Description": "Customer-focused bi-directional complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 211
        }
      }
    }
  ],
  "Description": "Function-based web-enabled challenge",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "vel",
      "PersonId": 962,
      "Mrmrs": "suscipit",
      "Firstname": "Hattie",
      "Lastname": "Hane",
      "MiddleName": "Mann-Gislason",
      "Title": "facere",
      "Description": "Multi-layered background encryption",
      "Email": "meagan@ebert.info",
      "FullName": "Ms. Berta Waters",
      "DirectPhone": "940.679.2572 x4687",
      "FormalName": "Bergstrom-Stoltenberg",
      "CountryId": 189,
      "ContactId": 594,
      "ContactName": "Flatley-Pfeffer",
      "Retired": 294,
      "Rank": 95,
      "ActiveInterests": 588,
      "ContactDepartment": "",
      "ContactCountryId": 187,
      "ContactOrgNr": "362605",
      "FaxPhone": "1-273-305-3145 x329",
      "MobilePhone": "(615)270-6173",
      "ContactPhone": "905-710-6253",
      "AssociateName": "Kuhlman LLC",
      "AssociateId": 578,
      "UsePersonAddress": true,
      "ContactFax": "ea",
      "Kanafname": "et",
      "Kanalname": "velit",
      "Post1": "sapiente",
      "Post2": "alias",
      "Post3": "at",
      "EmailName": "myrtle@mccullough.us",
      "ContactFullName": "Ms. Robb Nakia McGlynn",
      "ActiveErpLinks": 781,
      "TicketPriorityId": 550,
      "SupportLanguageId": 811,
      "SupportAssociateId": 688,
      "CategoryName": "VIP Customer",
      "PersonNumber": "392824",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 810
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "iure",
  "Xstop": false,
  "ActiveInterests": 417,
  "GroupId": 456,
  "ActiveStatusMonitorId": 138,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 394,
  "DbiAgentId": 730,
  "DbiLastSyncronized": "2002-01-23T03:46:54.4882666+01:00",
  "DbiKey": "aliquam",
  "DbiLastModified": "2013-09-13T03:46:54.4882666+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 731,
  "ActiveErpLinks": 235,
  "BounceEmails": [
    "romaine@watsica.info",
    "marisol@reingerullrich.biz"
  ],
  "Domains": [
    "quaerat",
    "amet"
  ],
  "InitialUtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "1865766294",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "fugit",
    "ExtraFields2": "minima"
  },
  "CustomFields": {
    "CustomFields1": "earum",
    "CustomFields2": "ut"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 251
    }
  }
}
```