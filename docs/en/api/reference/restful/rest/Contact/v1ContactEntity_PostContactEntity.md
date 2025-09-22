---
title: POST Contact
uid: v1ContactEntity_PostContactEntity
generated: true
content_type: reference
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
| UtmParameters | SavedUtmParameters | Utm parameters when creating first person and contact, readonly field |
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
| UtmParameters | SavedUtmParameters | Utm parameters when creating first person and contact, readonly field |
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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ContactId": 559,
  "Name": "Ritchie-Moore",
  "Department": "",
  "OrgNr": "1610849",
  "Number1": "1281632",
  "Number2": "1895432",
  "UpdatedDate": "2021-01-08T11:24:53.0780792+01:00",
  "CreatedDate": "2009-02-06T11:24:53.0780792+01:00",
  "Emails": [
    {
      "Value": "nobis",
      "StrippedValue": "consequatur",
      "Description": "Universal bifurcated moderator"
    },
    {
      "Value": "nobis",
      "StrippedValue": "consequatur",
      "Description": "Universal bifurcated moderator"
    }
  ],
  "Interests": [
    {
      "Id": 127,
      "Name": "Goyette LLC",
      "ToolTip": "Voluptatibus quia omnis odit ea id.",
      "Deleted": true,
      "Rank": 70,
      "Type": "atque",
      "ColorBlock": 725,
      "IconHint": "tempore",
      "Selected": false,
      "LastChanged": "2000-11-23T11:24:53.0780792+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "autem",
      "StyleHint": "nesciunt",
      "Hidden": false,
      "FullName": "Hunter Greenholt"
    }
  ],
  "Urls": [
    {
      "Value": "non",
      "StrippedValue": "inventore",
      "Description": "Object-based hybrid frame"
    },
    {
      "Value": "non",
      "StrippedValue": "inventore",
      "Description": "Object-based hybrid frame"
    }
  ],
  "Phones": [
    {
      "Value": "voluptates",
      "StrippedValue": "accusamus",
      "Description": "Progressive intangible knowledge base"
    },
    {
      "Value": "voluptates",
      "StrippedValue": "accusamus",
      "Description": "Progressive intangible knowledge base"
    }
  ],
  "Faxes": [
    {
      "Value": "dolorum",
      "StrippedValue": "laborum",
      "Description": "Persistent maximized attitude"
    },
    {
      "Value": "dolorum",
      "StrippedValue": "laborum",
      "Description": "Persistent maximized attitude"
    }
  ],
  "Description": "Multi-layered multi-tasking implementation",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "qui",
      "PersonId": 713,
      "Mrmrs": "voluptas",
      "Firstname": "Luis",
      "Lastname": "Green",
      "MiddleName": "Reinger Group",
      "Title": "voluptatem",
      "Description": "Organic coherent model",
      "Email": "nola.bayer@friesen.ca",
      "FullName": "Kayley Heaney",
      "DirectPhone": "656-735-2868",
      "FormalName": "Torphy, Schimmel and Beer",
      "CountryId": 867,
      "ContactId": 182,
      "ContactName": "Simonis Inc and Sons",
      "Retired": 665,
      "Rank": 847,
      "ActiveInterests": 524,
      "ContactDepartment": "",
      "ContactCountryId": 89,
      "ContactOrgNr": "835337",
      "FaxPhone": "(002)615-3034 x6513",
      "MobilePhone": "(780)279-4076",
      "ContactPhone": "1-521-834-4662 x562",
      "AssociateName": "Nicolas, Daugherty and Anderson",
      "AssociateId": 99,
      "UsePersonAddress": false,
      "ContactFax": "et",
      "Kanafname": "neque",
      "Kanalname": "eos",
      "Post1": "sint",
      "Post2": "voluptas",
      "Post3": "non",
      "EmailName": "krystel@hegmann.name",
      "ContactFullName": "Delilah Dibbert DVM",
      "ActiveErpLinks": 319,
      "TicketPriorityId": 381,
      "SupportLanguageId": 625,
      "SupportAssociateId": 909,
      "CategoryName": "VIP Customer",
      "PersonNumber": "823583"
    }
  ],
  "NoMailing": true,
  "Kananame": "cupiditate",
  "Xstop": false,
  "ActiveInterests": 580,
  "GroupId": 918,
  "ActiveStatusMonitorId": 636,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 285,
  "DbiAgentId": 33,
  "DbiLastSyncronized": "2002-05-23T11:24:53.0937035+02:00",
  "DbiKey": "nisi",
  "DbiLastModified": "2024-06-19T11:24:53.0937035+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 28,
  "ActiveErpLinks": 906,
  "BounceEmails": [
    "dorthy@reinger.info",
    "kory.kihn@swift.uk"
  ],
  "Domains": [
    "minus",
    "et"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Theodore Hudson",
    "SuperOffice:2": "Clemens Kohler"
  },
  "ExtraFields": {
    "ExtraFields1": "sint",
    "ExtraFields2": "dolorem"
  },
  "CustomFields": {
    "CustomFields1": "magni",
    "CustomFields2": "dignissimos"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 23,
  "Name": "Hackett-Kuhlman",
  "Department": "",
  "OrgNr": "409749",
  "Number1": "956769",
  "Number2": "1622745",
  "UpdatedDate": "2019-03-24T11:24:53.0937035+01:00",
  "CreatedDate": "2009-06-13T11:24:53.0937035+02:00",
  "Emails": [
    {
      "Value": "excepturi",
      "StrippedValue": "rerum",
      "Description": "Automated transitional success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 518
        }
      }
    },
    {
      "Value": "excepturi",
      "StrippedValue": "rerum",
      "Description": "Automated transitional success",
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
  "Interests": [
    {
      "Id": 538,
      "Name": "Spencer-Mitchell",
      "ToolTip": "Minima asperiores dolore iusto aperiam et totam.",
      "Deleted": false,
      "Rank": 972,
      "Type": "aut",
      "ColorBlock": 828,
      "IconHint": "accusantium",
      "Selected": false,
      "LastChanged": "2022-09-01T11:24:53.0937035+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nesciunt",
      "StyleHint": "ut",
      "Hidden": true,
      "FullName": "Angie Padberg",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 749
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "natus",
      "StrippedValue": "labore",
      "Description": "Realigned transitional open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 814
        }
      }
    },
    {
      "Value": "natus",
      "StrippedValue": "labore",
      "Description": "Realigned transitional open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 814
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "iste",
      "StrippedValue": "veniam",
      "Description": "Optional grid-enabled concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 891
        }
      }
    },
    {
      "Value": "iste",
      "StrippedValue": "veniam",
      "Description": "Optional grid-enabled concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 891
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "rerum",
      "StrippedValue": "rerum",
      "Description": "Synergized maximized complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 750
        }
      }
    },
    {
      "Value": "rerum",
      "StrippedValue": "rerum",
      "Description": "Synergized maximized complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 750
        }
      }
    }
  ],
  "Description": "Upgradable uniform secured line",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "autem",
      "PersonId": 494,
      "Mrmrs": "et",
      "Firstname": "Rolando",
      "Lastname": "Dickens",
      "MiddleName": "Adams-Quitzon",
      "Title": "iste",
      "Description": "Implemented foreground task-force",
      "Email": "madyson@hoeger.us",
      "FullName": "Mrs. Idella Ashley Klocko",
      "DirectPhone": "(187)036-5550",
      "FormalName": "Murphy-Marks",
      "CountryId": 920,
      "ContactId": 53,
      "ContactName": "Kulas-Daugherty",
      "Retired": 23,
      "Rank": 762,
      "ActiveInterests": 8,
      "ContactDepartment": "",
      "ContactCountryId": 859,
      "ContactOrgNr": "1617204",
      "FaxPhone": "1-745-790-2034",
      "MobilePhone": "729.825.3077 x088",
      "ContactPhone": "544.008.0458 x7996",
      "AssociateName": "Rolfson, Tremblay and Pollich",
      "AssociateId": 631,
      "UsePersonAddress": false,
      "ContactFax": "sed",
      "Kanafname": "quo",
      "Kanalname": "nulla",
      "Post1": "sequi",
      "Post2": "rerum",
      "Post3": "perferendis",
      "EmailName": "abigayle_kshlerin@kihn.com",
      "ContactFullName": "Allie Jacobson",
      "ActiveErpLinks": 670,
      "TicketPriorityId": 977,
      "SupportLanguageId": 996,
      "SupportAssociateId": 805,
      "CategoryName": "VIP Customer",
      "PersonNumber": "828476",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 606
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "deleniti",
  "Xstop": false,
  "ActiveInterests": 318,
  "GroupId": 34,
  "ActiveStatusMonitorId": 526,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 419,
  "DbiAgentId": 483,
  "DbiLastSyncronized": "2017-10-10T11:24:53.0937035+02:00",
  "DbiKey": "ut",
  "DbiLastModified": "2015-03-08T11:24:53.0937035+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 258,
  "ActiveErpLinks": 993,
  "BounceEmails": [
    "otha_rosenbaum@quitzon.info",
    "garry_dietrich@kunde.com"
  ],
  "Domains": [
    "repellat",
    "esse"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Miss Jonatan Mertz DDS",
    "SuperOffice:2": "1846542765"
  },
  "ExtraFields": {
    "ExtraFields1": "asperiores",
    "ExtraFields2": "sunt"
  },
  "CustomFields": {
    "CustomFields1": "adipisci",
    "CustomFields2": "quibusdam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 871
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```