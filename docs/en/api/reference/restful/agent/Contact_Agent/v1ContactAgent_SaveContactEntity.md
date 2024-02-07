---
title: POST Agents/Contact/SaveContactEntity
uid: v1ContactAgent_SaveContactEntity
generated: true
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

## Sample request

```http!
POST /api/v1/Agents/Contact/SaveContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 568,
  "Name": "Beer, Gerhold and Klocko",
  "Department": "",
  "OrgNr": "802523",
  "Number1": "511930",
  "Number2": "417208",
  "UpdatedDate": "1998-03-16T16:54:54.9142793+01:00",
  "CreatedDate": "1997-06-28T16:54:54.9142793+02:00",
  "Emails": [
    {
      "Value": "amet",
      "StrippedValue": "non",
      "Description": "Versatile 5th generation alliance"
    },
    {
      "Value": "amet",
      "StrippedValue": "non",
      "Description": "Versatile 5th generation alliance"
    }
  ],
  "Interests": [
    {
      "Id": 538,
      "Name": "Stiedemann-Grimes",
      "ToolTip": "Autem rem dolor nemo sit minus.",
      "Deleted": false,
      "Rank": 191,
      "Type": "dolor",
      "ColorBlock": 88,
      "IconHint": "corrupti",
      "Selected": false,
      "LastChanged": "2018-04-06T16:54:54.9142793+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "error",
      "StyleHint": "voluptatem",
      "Hidden": false,
      "FullName": "Miss Veda Abernathy"
    }
  ],
  "Urls": [
    {
      "Value": "animi",
      "StrippedValue": "velit",
      "Description": "Digitized systemic flexibility"
    },
    {
      "Value": "animi",
      "StrippedValue": "velit",
      "Description": "Digitized systemic flexibility"
    }
  ],
  "Phones": [
    {
      "Value": "explicabo",
      "StrippedValue": "ut",
      "Description": "Persevering full-range help-desk"
    },
    {
      "Value": "explicabo",
      "StrippedValue": "ut",
      "Description": "Persevering full-range help-desk"
    }
  ],
  "Faxes": [
    {
      "Value": "aut",
      "StrippedValue": "maiores",
      "Description": "Fully-configurable responsive projection"
    },
    {
      "Value": "aut",
      "StrippedValue": "maiores",
      "Description": "Fully-configurable responsive projection"
    }
  ],
  "Description": "Phased content-based algorithm",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quis",
      "PersonId": 599,
      "Mrmrs": "ut",
      "Firstname": "Kristian",
      "Lastname": "VonRueden",
      "MiddleName": "Hilll LLC",
      "Title": "odit",
      "Description": "Integrated content-based capacity",
      "Email": "yesenia@crooks.info",
      "FullName": "Al Smith",
      "DirectPhone": "1-262-572-3935 x830",
      "FormalName": "Kling-Stokes",
      "CountryId": 704,
      "ContactId": 351,
      "ContactName": "Little LLC",
      "Retired": 700,
      "Rank": 519,
      "ActiveInterests": 229,
      "ContactDepartment": "",
      "ContactCountryId": 543,
      "ContactOrgNr": "711006",
      "FaxPhone": "424-292-3553 x7312",
      "MobilePhone": "1-955-004-8892 x43279",
      "ContactPhone": "1-505-808-5589 x846",
      "AssociateName": "Weimann, Towne and Lindgren",
      "AssociateId": 752,
      "UsePersonAddress": false,
      "ContactFax": "provident",
      "Kanafname": "nesciunt",
      "Kanalname": "iste",
      "Post1": "eveniet",
      "Post2": "qui",
      "Post3": "odit",
      "EmailName": "annabell.abshire@lemke.uk",
      "ContactFullName": "Mia Mraz",
      "ActiveErpLinks": 36,
      "TicketPriorityId": 801,
      "SupportLanguageId": 275,
      "SupportAssociateId": 385,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "aut",
  "Xstop": true,
  "ActiveInterests": 957,
  "GroupId": 356,
  "ActiveStatusMonitorId": 743,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 165,
  "DbiAgentId": 633,
  "DbiLastSyncronized": "1996-12-28T16:54:54.9182602+01:00",
  "DbiKey": "sed",
  "DbiLastModified": "2009-01-02T16:54:54.9182602+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 412,
  "ActiveErpLinks": 311,
  "BounceEmails": [
    "grant@starkaufderhar.name",
    "buddy.dare@schultz.biz"
  ],
  "Domains": [
    "voluptas",
    "et"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1801121240",
    "SuperOffice:2": "Miss Mittie Kreiger III"
  },
  "ExtraFields": {
    "ExtraFields1": "in",
    "ExtraFields2": "cumque"
  },
  "CustomFields": {
    "CustomFields1": "omnis",
    "CustomFields2": "officiis"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 265,
  "Name": "Mante, Bailey and Gulgowski",
  "Department": "",
  "OrgNr": "1231901",
  "Number1": "583799",
  "Number2": "1655051",
  "UpdatedDate": "2017-10-15T16:54:54.9261706+02:00",
  "CreatedDate": "2009-08-01T16:54:54.9261706+02:00",
  "Emails": [
    {
      "Value": "repudiandae",
      "StrippedValue": "consectetur",
      "Description": "Monitored reciprocal projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 121
        }
      }
    },
    {
      "Value": "repudiandae",
      "StrippedValue": "consectetur",
      "Description": "Monitored reciprocal projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 121
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 425,
      "Name": "Batz Group",
      "ToolTip": "Architecto praesentium repellendus temporibus error eligendi deserunt.",
      "Deleted": false,
      "Rank": 228,
      "Type": "quo",
      "ColorBlock": 160,
      "IconHint": "voluptatem",
      "Selected": false,
      "LastChanged": "2015-10-03T16:54:54.9261706+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "at",
      "StyleHint": "ut",
      "Hidden": false,
      "FullName": "Prof. Vicky Lukas Spinka IV",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 316
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "quo",
      "StrippedValue": "et",
      "Description": "Sharable tangible core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 232
        }
      }
    },
    {
      "Value": "quo",
      "StrippedValue": "et",
      "Description": "Sharable tangible core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 232
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "et",
      "StrippedValue": "ab",
      "Description": "Reactive mobile pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 415
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "ab",
      "Description": "Reactive mobile pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 415
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "aut",
      "StrippedValue": "qui",
      "Description": "Innovative tertiary implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 129
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "qui",
      "Description": "Innovative tertiary implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 129
        }
      }
    }
  ],
  "Description": "Programmable global internet solution",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "numquam",
      "PersonId": 124,
      "Mrmrs": "doloremque",
      "Firstname": "Mylene",
      "Lastname": "Halvorson",
      "MiddleName": "Carter Inc and Sons",
      "Title": "eum",
      "Description": "Synergistic logistical approach",
      "Email": "mattie.dietrich@little.name",
      "FullName": "Drew Fritsch",
      "DirectPhone": "1-979-304-3628 x70181",
      "FormalName": "Hartmann-Fadel",
      "CountryId": 878,
      "ContactId": 884,
      "ContactName": "Quitzon-Lemke",
      "Retired": 779,
      "Rank": 394,
      "ActiveInterests": 174,
      "ContactDepartment": "",
      "ContactCountryId": 470,
      "ContactOrgNr": "573232",
      "FaxPhone": "521.400.7792 x3846",
      "MobilePhone": "621.958.5591",
      "ContactPhone": "832-033-0837 x86773",
      "AssociateName": "Gorczany, Maggio and Brekke",
      "AssociateId": 979,
      "UsePersonAddress": true,
      "ContactFax": "aperiam",
      "Kanafname": "et",
      "Kanalname": "sed",
      "Post1": "et",
      "Post2": "voluptatem",
      "Post3": "reiciendis",
      "EmailName": "friedrich@johnston.name",
      "ContactFullName": "Doyle Lakin",
      "ActiveErpLinks": 204,
      "TicketPriorityId": 620,
      "SupportLanguageId": 964,
      "SupportAssociateId": 386,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 693
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "repudiandae",
  "Xstop": false,
  "ActiveInterests": 377,
  "GroupId": 414,
  "ActiveStatusMonitorId": 36,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 730,
  "DbiAgentId": 293,
  "DbiLastSyncronized": "2013-10-07T16:54:54.9291705+02:00",
  "DbiKey": "in",
  "DbiLastModified": "2016-04-28T16:54:54.9291705+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 481,
  "ActiveErpLinks": 174,
  "BounceEmails": [
    "norbert_heaney@breitenberglangworth.ca",
    "dannie@thompson.us"
  ],
  "Domains": [
    "cumque",
    "provident"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "60961414",
    "SuperOffice:2": "Miss Kurt Weimann DDS"
  },
  "ExtraFields": {
    "ExtraFields1": "exercitationem",
    "ExtraFields2": "exercitationem"
  },
  "CustomFields": {
    "CustomFields1": "iusto",
    "CustomFields2": "veniam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 17
    }
  }
}
```