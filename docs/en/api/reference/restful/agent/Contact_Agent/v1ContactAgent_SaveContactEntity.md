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
| UtmParameters | SavedUtmParameters | Utm parameters when creating first person and contact, readonly field |
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
| UtmParameters | SavedUtmParameters | Utm parameters when creating first person and contact, readonly field |
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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactId": 962,
  "Name": "Walker, Waters and Lakin",
  "Department": "",
  "OrgNr": "1079949",
  "Number1": "877976",
  "Number2": "497026",
  "UpdatedDate": "2017-10-18T03:41:53.2463712+02:00",
  "CreatedDate": "2012-07-15T03:41:53.2463712+02:00",
  "Emails": [
    {
      "Value": "non",
      "StrippedValue": "et",
      "Description": "Versatile methodical initiative"
    },
    {
      "Value": "non",
      "StrippedValue": "et",
      "Description": "Versatile methodical initiative"
    }
  ],
  "Interests": [
    {
      "Id": 913,
      "Name": "Herman-Zemlak",
      "ToolTip": "Dolores quis id sed cumque.",
      "Deleted": false,
      "Rank": 564,
      "Type": "numquam",
      "ColorBlock": 291,
      "IconHint": "deserunt",
      "Selected": true,
      "LastChanged": "2022-06-03T03:41:53.2463712+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptatem",
      "StyleHint": "voluptas",
      "Hidden": false,
      "FullName": "Nicola Purdy"
    }
  ],
  "Urls": [
    {
      "Value": "nulla",
      "StrippedValue": "voluptate",
      "Description": "Innovative neutral initiative"
    },
    {
      "Value": "nulla",
      "StrippedValue": "voluptate",
      "Description": "Innovative neutral initiative"
    }
  ],
  "Phones": [
    {
      "Value": "quia",
      "StrippedValue": "deleniti",
      "Description": "Virtual solution-oriented function"
    },
    {
      "Value": "quia",
      "StrippedValue": "deleniti",
      "Description": "Virtual solution-oriented function"
    }
  ],
  "Faxes": [
    {
      "Value": "sunt",
      "StrippedValue": "dolorem",
      "Description": "Ameliorated impactful local area network"
    },
    {
      "Value": "sunt",
      "StrippedValue": "dolorem",
      "Description": "Ameliorated impactful local area network"
    }
  ],
  "Description": "Extended dynamic local area network",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quod",
      "PersonId": 356,
      "Mrmrs": "quo",
      "Firstname": "Mabel",
      "Lastname": "Wolff",
      "MiddleName": "Stroman, Hamill and Konopelski",
      "Title": "rem",
      "Description": "Open-architected attitude-oriented throughput",
      "Email": "ramiro_nolan@gaylord.co.uk",
      "FullName": "Ms. Eloy Gabrielle Harris",
      "DirectPhone": "(332)971-5945",
      "FormalName": "Luettgen-Harvey",
      "CountryId": 764,
      "ContactId": 623,
      "ContactName": "Ankunding Group",
      "Retired": 556,
      "Rank": 538,
      "ActiveInterests": 691,
      "ContactDepartment": "",
      "ContactCountryId": 492,
      "ContactOrgNr": "398582",
      "FaxPhone": "566.881.7575",
      "MobilePhone": "366.045.4145 x997",
      "ContactPhone": "(479)483-9436",
      "AssociateName": "Kunde LLC",
      "AssociateId": 822,
      "UsePersonAddress": true,
      "ContactFax": "libero",
      "Kanafname": "incidunt",
      "Kanalname": "quis",
      "Post1": "aperiam",
      "Post2": "assumenda",
      "Post3": "eaque",
      "EmailName": "lukas.gutkowski@spencer.name",
      "ContactFullName": "Jefferey Noble Wyman Jr.",
      "ActiveErpLinks": 235,
      "TicketPriorityId": 670,
      "SupportLanguageId": 801,
      "SupportAssociateId": 235,
      "CategoryName": "VIP Customer",
      "PersonNumber": "654914"
    }
  ],
  "NoMailing": false,
  "Kananame": "ea",
  "Xstop": false,
  "ActiveInterests": 182,
  "GroupId": 263,
  "ActiveStatusMonitorId": 990,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 364,
  "DbiAgentId": 58,
  "DbiLastSyncronized": "2013-03-18T03:41:53.2463712+01:00",
  "DbiKey": "consequatur",
  "DbiLastModified": "2006-09-16T03:41:53.2463712+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 806,
  "ActiveErpLinks": 83,
  "BounceEmails": [
    "colleen@bins.info",
    "jaylin@torphy.info"
  ],
  "Domains": [
    "quia",
    "eum"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "548257462",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "itaque",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "incidunt",
    "CustomFields2": "consequatur"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 610,
  "Name": "Krajcik-Marvin",
  "Department": "",
  "OrgNr": "1243107",
  "Number1": "1219466",
  "Number2": "1259198",
  "UpdatedDate": "1999-04-21T03:41:53.2463712+02:00",
  "CreatedDate": "2015-11-08T03:41:53.2463712+01:00",
  "Emails": [
    {
      "Value": "quidem",
      "StrippedValue": "debitis",
      "Description": "Polarised tertiary analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 171
        }
      }
    },
    {
      "Value": "quidem",
      "StrippedValue": "debitis",
      "Description": "Polarised tertiary analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 171
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 38,
      "Name": "Doyle LLC",
      "ToolTip": "Atque in ullam distinctio dolorem at.",
      "Deleted": false,
      "Rank": 578,
      "Type": "culpa",
      "ColorBlock": 607,
      "IconHint": "suscipit",
      "Selected": false,
      "LastChanged": "2011-04-02T03:41:53.2619943+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sunt",
      "StyleHint": "numquam",
      "Hidden": false,
      "FullName": "Lennie Ullrich",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 982
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "reprehenderit",
      "StrippedValue": "dolorem",
      "Description": "Intuitive empowering productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 679
        }
      }
    },
    {
      "Value": "reprehenderit",
      "StrippedValue": "dolorem",
      "Description": "Intuitive empowering productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 679
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "quae",
      "StrippedValue": "non",
      "Description": "Ergonomic actuating infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 400
        }
      }
    },
    {
      "Value": "quae",
      "StrippedValue": "non",
      "Description": "Ergonomic actuating infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 400
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "illo",
      "StrippedValue": "rem",
      "Description": "Advanced real-time protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 508
        }
      }
    },
    {
      "Value": "illo",
      "StrippedValue": "rem",
      "Description": "Advanced real-time protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 508
        }
      }
    }
  ],
  "Description": "Decentralized grid-enabled contingency",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "excepturi",
      "PersonId": 349,
      "Mrmrs": "pariatur",
      "Firstname": "Marion",
      "Lastname": "Bosco",
      "MiddleName": "Kautzer-Glover",
      "Title": "ducimus",
      "Description": "Integrated bifurcated customer loyalty",
      "Email": "antonina.ernser@collinsgibson.info",
      "FullName": "Zetta Bogan",
      "DirectPhone": "1-150-587-9730",
      "FormalName": "Kessler LLC",
      "CountryId": 838,
      "ContactId": 600,
      "ContactName": "Bergstrom Inc and Sons",
      "Retired": 448,
      "Rank": 825,
      "ActiveInterests": 61,
      "ContactDepartment": "",
      "ContactCountryId": 705,
      "ContactOrgNr": "1411075",
      "FaxPhone": "1-177-004-6483 x9573",
      "MobilePhone": "672.382.1186 x86448",
      "ContactPhone": "(519)340-5743 x143",
      "AssociateName": "Wolff, Ankunding and Langworth",
      "AssociateId": 597,
      "UsePersonAddress": true,
      "ContactFax": "est",
      "Kanafname": "unde",
      "Kanalname": "ex",
      "Post1": "illum",
      "Post2": "deserunt",
      "Post3": "eos",
      "EmailName": "sid@wilkinson.info",
      "ContactFullName": "Ursula Stokes",
      "ActiveErpLinks": 89,
      "TicketPriorityId": 157,
      "SupportLanguageId": 945,
      "SupportAssociateId": 453,
      "CategoryName": "VIP Customer",
      "PersonNumber": "573568",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 939
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "cumque",
  "Xstop": true,
  "ActiveInterests": 258,
  "GroupId": 740,
  "ActiveStatusMonitorId": 616,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 542,
  "DbiAgentId": 900,
  "DbiLastSyncronized": "2024-08-30T03:41:53.2619943+02:00",
  "DbiKey": "praesentium",
  "DbiLastModified": "2013-05-31T03:41:53.2619943+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 526,
  "ActiveErpLinks": 719,
  "BounceEmails": [
    "marc@pouros.info",
    "hollie@eichmann.uk"
  ],
  "Domains": [
    "reprehenderit",
    "qui"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Andrew Kub",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "corrupti",
    "ExtraFields2": "error"
  },
  "CustomFields": {
    "CustomFields1": "nulla",
    "CustomFields2": "qui"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 351
    }
  }
}
```