---
title: POST Contact
uid: v1ContactEntity_PostContactEntity
generated: true
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
POST /api/v1/Contact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactId": 40,
  "Name": "Dicki, Murphy and McLaughlin",
  "Department": "",
  "OrgNr": "909176",
  "Number1": "56480",
  "Number2": "1480097",
  "UpdatedDate": "2004-06-22T04:22:34.7652204+02:00",
  "CreatedDate": "2018-03-02T04:22:34.7652204+01:00",
  "Emails": [
    {
      "Value": "earum",
      "StrippedValue": "eveniet",
      "Description": "Stand-alone modular array"
    },
    {
      "Value": "earum",
      "StrippedValue": "eveniet",
      "Description": "Stand-alone modular array"
    }
  ],
  "Interests": [
    {
      "Id": 143,
      "Name": "Kuhlman-Ondricka",
      "ToolTip": "Culpa a voluptates asperiores dolore beatae.",
      "Deleted": true,
      "Rank": 787,
      "Type": "ut",
      "ColorBlock": 668,
      "IconHint": "aut",
      "Selected": false,
      "LastChanged": "2010-07-27T04:22:34.7652204+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "est",
      "Hidden": false,
      "FullName": "Dr. Allan Raquel Dickens IV"
    }
  ],
  "Urls": [
    {
      "Value": "impedit",
      "StrippedValue": "dolores",
      "Description": "Right-sized content-based conglomeration"
    },
    {
      "Value": "impedit",
      "StrippedValue": "dolores",
      "Description": "Right-sized content-based conglomeration"
    }
  ],
  "Phones": [
    {
      "Value": "distinctio",
      "StrippedValue": "et",
      "Description": "Future-proofed object-oriented benchmark"
    },
    {
      "Value": "distinctio",
      "StrippedValue": "et",
      "Description": "Future-proofed object-oriented benchmark"
    }
  ],
  "Faxes": [
    {
      "Value": "atque",
      "StrippedValue": "veritatis",
      "Description": "Horizontal neutral open system"
    },
    {
      "Value": "atque",
      "StrippedValue": "veritatis",
      "Description": "Horizontal neutral open system"
    }
  ],
  "Description": "Visionary optimal matrices",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "eum",
      "PersonId": 587,
      "Mrmrs": "et",
      "Firstname": "Payton",
      "Lastname": "Zieme",
      "MiddleName": "Hilpert-Boyle",
      "Title": "sed",
      "Description": "Polarised dedicated pricing structure",
      "Email": "lexie.brown@goldner.name",
      "FullName": "Cydney Ziemann",
      "DirectPhone": "(021)746-0623",
      "FormalName": "Doyle Inc and Sons",
      "CountryId": 694,
      "ContactId": 724,
      "ContactName": "Rau-Ward",
      "Retired": 906,
      "Rank": 10,
      "ActiveInterests": 345,
      "ContactDepartment": "",
      "ContactCountryId": 46,
      "ContactOrgNr": "1224722",
      "FaxPhone": "1-832-373-5653 x6455",
      "MobilePhone": "(279)579-7374 x971",
      "ContactPhone": "382-192-8681",
      "AssociateName": "Blick-Jerde",
      "AssociateId": 773,
      "UsePersonAddress": true,
      "ContactFax": "repellat",
      "Kanafname": "quia",
      "Kanalname": "atque",
      "Post1": "rerum",
      "Post2": "dolore",
      "Post3": "quaerat",
      "EmailName": "lisa@fritsch.info",
      "ContactFullName": "Donna Emmy Predovic Jr.",
      "ActiveErpLinks": 562,
      "TicketPriorityId": 91,
      "SupportLanguageId": 389,
      "SupportAssociateId": 235,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "iusto",
  "Xstop": false,
  "ActiveInterests": 786,
  "GroupId": 977,
  "ActiveStatusMonitorId": 234,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 233,
  "DbiAgentId": 674,
  "DbiLastSyncronized": "2010-01-30T04:22:34.7652204+01:00",
  "DbiKey": "qui",
  "DbiLastModified": "2016-05-06T04:22:34.7652204+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 630,
  "ActiveErpLinks": 412,
  "BounceEmails": [
    "maude.ohara@nicolas.name",
    "electa_nienow@goyette.uk"
  ],
  "Domains": [
    "deserunt",
    "est"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "751416868",
    "SuperOffice:2": "Torey Stehr"
  },
  "ExtraFields": {
    "ExtraFields1": "vel",
    "ExtraFields2": "eius"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "deserunt"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 841,
  "Name": "Kautzer, Marvin and Rogahn",
  "Department": "",
  "OrgNr": "1048480",
  "Number1": "672282",
  "Number2": "943108",
  "UpdatedDate": "2005-11-21T04:22:34.7808781+01:00",
  "CreatedDate": "2013-01-21T04:22:34.7808781+01:00",
  "Emails": [
    {
      "Value": "quo",
      "StrippedValue": "temporibus",
      "Description": "Proactive analyzing migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 930
        }
      }
    },
    {
      "Value": "quo",
      "StrippedValue": "temporibus",
      "Description": "Proactive analyzing migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 930
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 334,
      "Name": "Schmeler-Wilderman",
      "ToolTip": "Nihil in modi occaecati nemo enim.",
      "Deleted": true,
      "Rank": 913,
      "Type": "ea",
      "ColorBlock": 202,
      "IconHint": "sint",
      "Selected": true,
      "LastChanged": "2014-10-20T04:22:34.7808781+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quia",
      "StyleHint": "ratione",
      "Hidden": true,
      "FullName": "Rodger Homenick",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 518
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "reprehenderit",
      "StrippedValue": "totam",
      "Description": "Digitized explicit leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 610
        }
      }
    },
    {
      "Value": "reprehenderit",
      "StrippedValue": "totam",
      "Description": "Digitized explicit leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 610
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "quia",
      "StrippedValue": "blanditiis",
      "Description": "Down-sized didactic firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 979
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "blanditiis",
      "Description": "Down-sized didactic firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 979
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "eum",
      "StrippedValue": "itaque",
      "Description": "Synergistic encompassing access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 123
        }
      }
    },
    {
      "Value": "eum",
      "StrippedValue": "itaque",
      "Description": "Synergistic encompassing access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 123
        }
      }
    }
  ],
  "Description": "Cross-platform interactive neural-net",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "sed",
      "PersonId": 128,
      "Mrmrs": "sit",
      "Firstname": "Daron",
      "Lastname": "Harber",
      "MiddleName": "Grimes Group",
      "Title": "sunt",
      "Description": "Future-proofed radical definition",
      "Email": "margret@goyette.info",
      "FullName": "Dennis O'Connell",
      "DirectPhone": "1-476-428-7386",
      "FormalName": "Schulist Inc and Sons",
      "CountryId": 426,
      "ContactId": 607,
      "ContactName": "Grady, Rutherford and Schumm",
      "Retired": 639,
      "Rank": 42,
      "ActiveInterests": 356,
      "ContactDepartment": "",
      "ContactCountryId": 410,
      "ContactOrgNr": "519801",
      "FaxPhone": "1-904-057-1075",
      "MobilePhone": "689-244-4710 x683",
      "ContactPhone": "690-120-6578 x30571",
      "AssociateName": "Jacobi Inc and Sons",
      "AssociateId": 541,
      "UsePersonAddress": false,
      "ContactFax": "dolor",
      "Kanafname": "vel",
      "Kanalname": "quo",
      "Post1": "ea",
      "Post2": "sed",
      "Post3": "dignissimos",
      "EmailName": "lester_stamm@trantow.info",
      "ContactFullName": "Garnett Zemlak",
      "ActiveErpLinks": 605,
      "TicketPriorityId": 257,
      "SupportLanguageId": 998,
      "SupportAssociateId": 21,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 231
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "sapiente",
  "Xstop": true,
  "ActiveInterests": 550,
  "GroupId": 145,
  "ActiveStatusMonitorId": 418,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 759,
  "DbiAgentId": 902,
  "DbiLastSyncronized": "2006-07-18T04:22:34.7808781+02:00",
  "DbiKey": "accusamus",
  "DbiLastModified": "2002-12-08T04:22:34.7808781+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 441,
  "ActiveErpLinks": 64,
  "BounceEmails": [
    "nicholaus_torp@goodwin.name",
    "hulda@konopelski.ca"
  ],
  "Domains": [
    "cumque",
    "non"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Burnice Pollich I",
    "SuperOffice:2": "Viviane Ruecker"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptatem",
    "ExtraFields2": "nulla"
  },
  "CustomFields": {
    "CustomFields1": "est",
    "CustomFields2": "recusandae"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 936
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```