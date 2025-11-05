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


NsApiSlow threshold: 2000 ms.







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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 778,
  "Name": "Turcotte LLC",
  "Department": "",
  "OrgNr": "1165905",
  "Number1": "842965",
  "Number2": "1219876",
  "UpdatedDate": "2006-02-13T02:30:46.9444678+01:00",
  "CreatedDate": "2008-06-09T02:30:46.9444678+02:00",
  "Emails": [
    {
      "Value": "quisquam",
      "StrippedValue": "nisi",
      "Description": "Optional 6th generation standardization"
    },
    {
      "Value": "quisquam",
      "StrippedValue": "nisi",
      "Description": "Optional 6th generation standardization"
    }
  ],
  "Interests": [
    {
      "Id": 673,
      "Name": "Yundt-Kunze",
      "ToolTip": "Aspernatur cumque at autem voluptatum accusantium numquam.",
      "Deleted": true,
      "Rank": 557,
      "Type": "voluptates",
      "ColorBlock": 132,
      "IconHint": "quis",
      "Selected": true,
      "LastChanged": "2016-10-01T02:30:46.9444678+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "incidunt",
      "StyleHint": "at",
      "Hidden": true,
      "FullName": "Kyler Else Littel V"
    }
  ],
  "Urls": [
    {
      "Value": "iste",
      "StrippedValue": "odio",
      "Description": "Distributed discrete contingency"
    },
    {
      "Value": "iste",
      "StrippedValue": "odio",
      "Description": "Distributed discrete contingency"
    }
  ],
  "Phones": [
    {
      "Value": "nesciunt",
      "StrippedValue": "vel",
      "Description": "Customer-focused real-time utilisation"
    },
    {
      "Value": "nesciunt",
      "StrippedValue": "vel",
      "Description": "Customer-focused real-time utilisation"
    }
  ],
  "Faxes": [
    {
      "Value": "ullam",
      "StrippedValue": "animi",
      "Description": "Re-contextualized optimizing website"
    },
    {
      "Value": "ullam",
      "StrippedValue": "animi",
      "Description": "Re-contextualized optimizing website"
    }
  ],
  "Description": "Public-key 6th generation collaboration",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "beatae",
      "PersonId": 541,
      "Mrmrs": "accusamus",
      "Firstname": "Jade",
      "Lastname": "Kohler",
      "MiddleName": "Walter-Corwin",
      "Title": "atque",
      "Description": "Digitized neutral solution",
      "Email": "cristopher@gerhold.name",
      "FullName": "Malachi Schiller",
      "DirectPhone": "1-303-271-6781 x7146",
      "FormalName": "O'Conner Inc and Sons",
      "CountryId": 452,
      "ContactId": 697,
      "ContactName": "West, Powlowski and Hand",
      "Retired": 672,
      "Rank": 824,
      "ActiveInterests": 147,
      "ContactDepartment": "",
      "ContactCountryId": 405,
      "ContactOrgNr": "1100929",
      "FaxPhone": "(219)035-8465 x962",
      "MobilePhone": "1-988-078-4696 x7093",
      "ContactPhone": "(683)920-5024 x2745",
      "AssociateName": "Macejkovic, VonRueden and Aufderhar",
      "AssociateId": 807,
      "UsePersonAddress": false,
      "ContactFax": "facere",
      "Kanafname": "nihil",
      "Kanalname": "ratione",
      "Post1": "adipisci",
      "Post2": "nihil",
      "Post3": "repudiandae",
      "EmailName": "anais@leffler.uk",
      "ContactFullName": "Ms. Jadon Lowell Nader V",
      "ActiveErpLinks": 815,
      "TicketPriorityId": 601,
      "SupportLanguageId": 747,
      "SupportAssociateId": 583,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1909426"
    }
  ],
  "NoMailing": true,
  "Kananame": "debitis",
  "Xstop": false,
  "ActiveInterests": 47,
  "GroupId": 864,
  "ActiveStatusMonitorId": 696,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 514,
  "DbiAgentId": 996,
  "DbiLastSyncronized": "2023-10-17T02:30:46.9444678+02:00",
  "DbiKey": "et",
  "DbiLastModified": "1999-09-02T02:30:46.9444678+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 138,
  "ActiveErpLinks": 105,
  "BounceEmails": [
    "elenor.spencer@wilderman.biz",
    "raymond@kutch.ca"
  ],
  "Domains": [
    "qui",
    "voluptatibus"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Adele Jakubowski",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "aliquam",
    "ExtraFields2": "qui"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "sed"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 86,
  "Name": "Considine-Lemke",
  "Department": "",
  "OrgNr": "1375285",
  "Number1": "736995",
  "Number2": "1289429",
  "UpdatedDate": "2008-09-16T02:30:46.9600922+02:00",
  "CreatedDate": "2020-12-02T02:30:46.9600922+01:00",
  "Emails": [
    {
      "Value": "a",
      "StrippedValue": "placeat",
      "Description": "Advanced cohesive ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 196
        }
      }
    },
    {
      "Value": "a",
      "StrippedValue": "placeat",
      "Description": "Advanced cohesive ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 196
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 862,
      "Name": "Schamberger LLC",
      "ToolTip": "Quia qui excepturi minima velit eligendi veritatis.",
      "Deleted": false,
      "Rank": 641,
      "Type": "modi",
      "ColorBlock": 474,
      "IconHint": "deleniti",
      "Selected": false,
      "LastChanged": "2014-07-14T02:30:46.9600922+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "molestiae",
      "StyleHint": "voluptatibus",
      "Hidden": false,
      "FullName": "Kelton Robel",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 745
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "molestias",
      "StrippedValue": "magni",
      "Description": "Integrated didactic software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 459
        }
      }
    },
    {
      "Value": "molestias",
      "StrippedValue": "magni",
      "Description": "Integrated didactic software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 459
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "illo",
      "StrippedValue": "veniam",
      "Description": "Reverse-engineered 24 hour portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 941
        }
      }
    },
    {
      "Value": "illo",
      "StrippedValue": "veniam",
      "Description": "Reverse-engineered 24 hour portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 941
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "eligendi",
      "StrippedValue": "est",
      "Description": "Face to face asynchronous structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 491
        }
      }
    },
    {
      "Value": "eligendi",
      "StrippedValue": "est",
      "Description": "Face to face asynchronous structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 491
        }
      }
    }
  ],
  "Description": "Re-engineered 24/7 hub",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quia",
      "PersonId": 382,
      "Mrmrs": "et",
      "Firstname": "Antwon",
      "Lastname": "Davis",
      "MiddleName": "O'Connell-Murray",
      "Title": "ea",
      "Description": "Managed bottom-line methodology",
      "Email": "lionel_jones@carter.info",
      "FullName": "Karli Erdman",
      "DirectPhone": "204.060.9462",
      "FormalName": "Stoltenberg, Stiedemann and Buckridge",
      "CountryId": 559,
      "ContactId": 18,
      "ContactName": "Littel, Ernser and Ernser",
      "Retired": 21,
      "Rank": 738,
      "ActiveInterests": 190,
      "ContactDepartment": "",
      "ContactCountryId": 603,
      "ContactOrgNr": "1548562",
      "FaxPhone": "1-907-461-1006 x365",
      "MobilePhone": "998-225-8362 x30792",
      "ContactPhone": "1-754-662-1266 x75626",
      "AssociateName": "Mayer-Rodriguez",
      "AssociateId": 626,
      "UsePersonAddress": false,
      "ContactFax": "qui",
      "Kanafname": "esse",
      "Kanalname": "in",
      "Post1": "eius",
      "Post2": "magnam",
      "Post3": "et",
      "EmailName": "ila@blockgutkowski.us",
      "ContactFullName": "Ashley Lowe",
      "ActiveErpLinks": 533,
      "TicketPriorityId": 133,
      "SupportLanguageId": 782,
      "SupportAssociateId": 514,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1194451",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 699
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "eos",
  "Xstop": false,
  "ActiveInterests": 482,
  "GroupId": 13,
  "ActiveStatusMonitorId": 472,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 411,
  "DbiAgentId": 204,
  "DbiLastSyncronized": "2017-11-11T02:30:46.9600922+01:00",
  "DbiKey": "harum",
  "DbiLastModified": "2006-10-08T02:30:46.9600922+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 722,
  "ActiveErpLinks": 765,
  "BounceEmails": [
    "alayna.schoen@mueller.uk",
    "ila@ebert.info"
  ],
  "Domains": [
    "voluptatibus",
    "praesentium"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "791192318",
    "SuperOffice:2": "Willard Bogan IV"
  },
  "ExtraFields": {
    "ExtraFields1": "cumque",
    "ExtraFields2": "cum"
  },
  "CustomFields": {
    "CustomFields1": "eius",
    "CustomFields2": "autem"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 190
    }
  }
}
```