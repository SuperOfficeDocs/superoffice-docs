---
title: POST Contact
uid: v1ContactEntity_PostContactEntity
---

# POST Contact

```http
POST /api/v1/Contact
```

Creates a new ContactEntity


Calls the Contact agent service SaveContactEntity.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/Contact?$select=name,department,category/id
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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample request

```http!
POST /api/v1/Contact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 312,
  "Name": "Marks-Harber",
  "Department": "",
  "OrgNr": "1192498",
  "Number1": "1756208",
  "Number2": "1738154",
  "UpdatedDate": "2011-12-24T14:19:10.1467247+01:00",
  "CreatedDate": "1996-10-25T14:19:10.1467247+02:00",
  "Emails": [
    {
      "Value": "quasi",
      "StrippedValue": "aut",
      "Description": "Ameliorated high-level strategy"
    },
    {
      "Value": "quasi",
      "StrippedValue": "aut",
      "Description": "Ameliorated high-level strategy"
    }
  ],
  "Interests": [
    {
      "Id": 829,
      "Name": "Breitenberg, Weimann and Torphy",
      "ToolTip": "Accusamus sunt nisi placeat non voluptatem molestiae.",
      "Deleted": false,
      "Rank": 350,
      "Type": "saepe",
      "ColorBlock": 442,
      "IconHint": "earum",
      "Selected": false,
      "LastChanged": "2020-07-02T14:19:10.1467247+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aut",
      "StyleHint": "voluptas",
      "Hidden": false,
      "FullName": "Jena Tremblay"
    }
  ],
  "Urls": [
    {
      "Value": "molestias",
      "StrippedValue": "sit",
      "Description": "Digitized methodical archive"
    },
    {
      "Value": "molestias",
      "StrippedValue": "sit",
      "Description": "Digitized methodical archive"
    }
  ],
  "Phones": [
    {
      "Value": "aut",
      "StrippedValue": "dolorem",
      "Description": "Balanced static throughput"
    },
    {
      "Value": "aut",
      "StrippedValue": "dolorem",
      "Description": "Balanced static throughput"
    }
  ],
  "Faxes": [
    {
      "Value": "dolores",
      "StrippedValue": "ex",
      "Description": "Distributed national productivity"
    },
    {
      "Value": "dolores",
      "StrippedValue": "ex",
      "Description": "Distributed national productivity"
    }
  ],
  "Description": "Fully-configurable grid-enabled software",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "nemo",
      "PersonId": 41,
      "Mrmrs": "in",
      "Firstname": "Elody",
      "Lastname": "Roob",
      "MiddleName": "Wuckert Inc and Sons",
      "Title": "voluptas",
      "Description": "Visionary cohesive complexity",
      "Email": "ardith.simonis@eichmann.info",
      "FullName": "Florine Kunze",
      "DirectPhone": "905.985.3747",
      "FormalName": "Bashirian, Beer and Rice",
      "CountryId": 136,
      "ContactId": 387,
      "ContactName": "Powlowski, Kemmer and Botsford",
      "Retired": 830,
      "Rank": 125,
      "ActiveInterests": 461,
      "ContactDepartment": "",
      "ContactCountryId": 986,
      "ContactOrgNr": "1329480",
      "FaxPhone": "853-711-8460 x73527",
      "MobilePhone": "1-505-162-6679",
      "ContactPhone": "(324)333-8550 x85122",
      "AssociateName": "D'Amore Inc and Sons",
      "AssociateId": 578,
      "UsePersonAddress": false,
      "ContactFax": "laborum",
      "Kanafname": "vitae",
      "Kanalname": "ut",
      "Post1": "et",
      "Post2": "nesciunt",
      "Post3": "et",
      "EmailName": "daniella.schiller@walternikolaus.co.uk",
      "ContactFullName": "Devante Abigayle Ziemann IV",
      "ActiveErpLinks": 165,
      "TicketPriorityId": 530,
      "SupportLanguageId": 333,
      "SupportAssociateId": 777,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "iure",
  "Xstop": false,
  "ActiveInterests": 931,
  "GroupId": 716,
  "ActiveStatusMonitorId": 483,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 918,
  "DbiAgentId": 826,
  "DbiLastSyncronized": "2017-07-10T14:19:10.1467247+02:00",
  "DbiKey": "et",
  "DbiLastModified": "2005-01-12T14:19:10.1467247+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 925,
  "ActiveErpLinks": 489,
  "BounceEmails": [
    "carlotta@gottliebfeeney.ca",
    "payton@gusikowski.biz"
  ],
  "Domains": [
    "ut",
    "maxime"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1001129217",
    "SuperOffice:2": "Fabian McClure"
  },
  "ExtraFields": {
    "ExtraFields1": "in",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "quia",
    "CustomFields2": "et"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 835,
  "Name": "Swift-Bruen",
  "Department": "",
  "OrgNr": "963222",
  "Number1": "816530",
  "Number2": "608668",
  "UpdatedDate": "2005-10-05T14:19:10.1623498+02:00",
  "CreatedDate": "2008-10-29T14:19:10.1623498+01:00",
  "Emails": [
    {
      "Value": "est",
      "StrippedValue": "earum",
      "Description": "Sharable explicit matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 254
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "earum",
      "Description": "Sharable explicit matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 254
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 874,
      "Name": "Mante-Flatley",
      "ToolTip": "Et illo tempora deserunt assumenda qui adipisci.",
      "Deleted": false,
      "Rank": 677,
      "Type": "est",
      "ColorBlock": 746,
      "IconHint": "eaque",
      "Selected": true,
      "LastChanged": "1997-11-15T14:19:10.1623498+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "iusto",
      "StyleHint": "non",
      "Hidden": false,
      "FullName": "Ariel Lakin",
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
  "Urls": [
    {
      "Value": "qui",
      "StrippedValue": "magni",
      "Description": "Upgradable leading edge structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 952
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "magni",
      "Description": "Upgradable leading edge structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 952
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "minima",
      "StrippedValue": "laboriosam",
      "Description": "Open-source dedicated monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 574
        }
      }
    },
    {
      "Value": "minima",
      "StrippedValue": "laboriosam",
      "Description": "Open-source dedicated monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 574
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "rerum",
      "StrippedValue": "officiis",
      "Description": "User-centric interactive collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 158
        }
      }
    },
    {
      "Value": "rerum",
      "StrippedValue": "officiis",
      "Description": "User-centric interactive collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 158
        }
      }
    }
  ],
  "Description": "Intuitive fault-tolerant info-mediaries",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "nam",
      "PersonId": 11,
      "Mrmrs": "totam",
      "Firstname": "Bennett",
      "Lastname": "Conroy",
      "MiddleName": "Klein-Kautzer",
      "Title": "explicabo",
      "Description": "Open-architected secondary data-warehouse",
      "Email": "dagmar@medhurst.com",
      "FullName": "Mr. Sigmund Landen Romaguera I",
      "DirectPhone": "1-931-865-3580",
      "FormalName": "Murazik Group",
      "CountryId": 783,
      "ContactId": 944,
      "ContactName": "Pacocha-Franecki",
      "Retired": 507,
      "Rank": 313,
      "ActiveInterests": 389,
      "ContactDepartment": "",
      "ContactCountryId": 205,
      "ContactOrgNr": "923951",
      "FaxPhone": "(650)040-3398",
      "MobilePhone": "713-601-4987",
      "ContactPhone": "596.288.8040 x79842",
      "AssociateName": "Blick-Bogisich",
      "AssociateId": 59,
      "UsePersonAddress": false,
      "ContactFax": "assumenda",
      "Kanafname": "facilis",
      "Kanalname": "odio",
      "Post1": "itaque",
      "Post2": "in",
      "Post3": "sequi",
      "EmailName": "wiley.reinger@kerlukekohler.us",
      "ContactFullName": "Mrs. Rodrigo Lebsack",
      "ActiveErpLinks": 832,
      "TicketPriorityId": 757,
      "SupportLanguageId": 161,
      "SupportAssociateId": 721,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 9
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "commodi",
  "Xstop": true,
  "ActiveInterests": 872,
  "GroupId": 707,
  "ActiveStatusMonitorId": 332,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 155,
  "DbiAgentId": 10,
  "DbiLastSyncronized": "2021-07-10T14:19:10.1623498+02:00",
  "DbiKey": "eligendi",
  "DbiLastModified": "2001-03-14T14:19:10.1623498+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 168,
  "ActiveErpLinks": 516,
  "BounceEmails": [
    "zelda@daugherty.name",
    "leopoldo@lindbashirian.us"
  ],
  "Domains": [
    "nihil",
    "aut"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Miss Meta West Jr.",
    "SuperOffice:2": "132994609"
  },
  "ExtraFields": {
    "ExtraFields1": "sint",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "voluptatem",
    "CustomFields2": "sed"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 211
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```