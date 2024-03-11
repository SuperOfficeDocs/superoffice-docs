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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ContactId": 913,
  "Name": "Bashirian Group",
  "Department": "",
  "OrgNr": "1789791",
  "Number1": "158094",
  "Number2": "294509",
  "UpdatedDate": "2007-05-25T14:23:54.9446537+02:00",
  "CreatedDate": "2019-01-25T14:23:54.9446537+01:00",
  "Emails": [
    {
      "Value": "voluptatem",
      "StrippedValue": "libero",
      "Description": "Programmable maximized ability"
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "libero",
      "Description": "Programmable maximized ability"
    }
  ],
  "Interests": [
    {
      "Id": 753,
      "Name": "McCullough, Bogan and Kuhn",
      "ToolTip": "Molestias omnis voluptatem cum recusandae.",
      "Deleted": false,
      "Rank": 250,
      "Type": "ab",
      "ColorBlock": 493,
      "IconHint": "esse",
      "Selected": false,
      "LastChanged": "2006-03-16T14:23:54.9446537+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eos",
      "StyleHint": "sint",
      "Hidden": false,
      "FullName": "Matt Kenneth Buckridge PhD"
    }
  ],
  "Urls": [
    {
      "Value": "consequatur",
      "StrippedValue": "voluptas",
      "Description": "Total reciprocal adapter"
    },
    {
      "Value": "consequatur",
      "StrippedValue": "voluptas",
      "Description": "Total reciprocal adapter"
    }
  ],
  "Phones": [
    {
      "Value": "voluptatibus",
      "StrippedValue": "rerum",
      "Description": "Fully-configurable systemic superstructure"
    },
    {
      "Value": "voluptatibus",
      "StrippedValue": "rerum",
      "Description": "Fully-configurable systemic superstructure"
    }
  ],
  "Faxes": [
    {
      "Value": "unde",
      "StrippedValue": "voluptatum",
      "Description": "Face to face zero administration definition"
    },
    {
      "Value": "unde",
      "StrippedValue": "voluptatum",
      "Description": "Face to face zero administration definition"
    }
  ],
  "Description": "Object-based methodical utilisation",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "totam",
      "PersonId": 126,
      "Mrmrs": "ut",
      "Firstname": "Monique",
      "Lastname": "Johnson",
      "MiddleName": "Ritchie, Osinski and Lang",
      "Title": "repellat",
      "Description": "De-engineered upward-trending collaboration",
      "Email": "demario@cummerata.com",
      "FullName": "Ms. Jayne Kenyon Purdy MD",
      "DirectPhone": "620-902-0253 x57888",
      "FormalName": "Wiegand LLC",
      "CountryId": 622,
      "ContactId": 477,
      "ContactName": "Baumbach-Conroy",
      "Retired": 123,
      "Rank": 303,
      "ActiveInterests": 762,
      "ContactDepartment": "",
      "ContactCountryId": 904,
      "ContactOrgNr": "1283434",
      "FaxPhone": "031.767.9661",
      "MobilePhone": "590.164.8551 x62347",
      "ContactPhone": "1-483-089-4693",
      "AssociateName": "Bogisich-Harris",
      "AssociateId": 92,
      "UsePersonAddress": false,
      "ContactFax": "tempore",
      "Kanafname": "est",
      "Kanalname": "exercitationem",
      "Post1": "qui",
      "Post2": "nisi",
      "Post3": "et",
      "EmailName": "audreanne_lehner@willcrona.biz",
      "ContactFullName": "Chanelle Rogahn",
      "ActiveErpLinks": 302,
      "TicketPriorityId": 75,
      "SupportLanguageId": 145,
      "SupportAssociateId": 280,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "optio",
  "Xstop": false,
  "ActiveInterests": 81,
  "GroupId": 206,
  "ActiveStatusMonitorId": 572,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 393,
  "DbiAgentId": 876,
  "DbiLastSyncronized": "2013-03-27T14:23:54.9446537+01:00",
  "DbiKey": "molestias",
  "DbiLastModified": "2002-12-12T14:23:54.9446537+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 110,
  "ActiveErpLinks": 402,
  "BounceEmails": [
    "bernice@conroy.name",
    "ezekiel@aufderhar.us"
  ],
  "Domains": [
    "enim",
    "id"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Geovanny Witting",
    "SuperOffice:2": "Edythe Medhurst"
  },
  "ExtraFields": {
    "ExtraFields1": "in",
    "ExtraFields2": "quos"
  },
  "CustomFields": {
    "CustomFields1": "cumque",
    "CustomFields2": "a"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 94,
  "Name": "Fay Group",
  "Department": "",
  "OrgNr": "1079694",
  "Number1": "1141712",
  "Number2": "1750842",
  "UpdatedDate": "2011-05-24T14:23:54.9446537+02:00",
  "CreatedDate": "2012-02-26T14:23:54.9446537+01:00",
  "Emails": [
    {
      "Value": "odio",
      "StrippedValue": "et",
      "Description": "Compatible bottom-line budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 272
        }
      }
    },
    {
      "Value": "odio",
      "StrippedValue": "et",
      "Description": "Compatible bottom-line budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 272
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 245,
      "Name": "Klocko-Franecki",
      "ToolTip": "Cumque quod natus.",
      "Deleted": true,
      "Rank": 644,
      "Type": "facere",
      "ColorBlock": 40,
      "IconHint": "voluptatem",
      "Selected": false,
      "LastChanged": "1999-02-03T14:23:54.9446537+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "velit",
      "StyleHint": "dolorum",
      "Hidden": false,
      "FullName": "Forest Fahey",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 76
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "laudantium",
      "StrippedValue": "optio",
      "Description": "Progressive clear-thinking core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 229
        }
      }
    },
    {
      "Value": "laudantium",
      "StrippedValue": "optio",
      "Description": "Progressive clear-thinking core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 229
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "doloribus",
      "StrippedValue": "inventore",
      "Description": "Enhanced multi-state application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 276
        }
      }
    },
    {
      "Value": "doloribus",
      "StrippedValue": "inventore",
      "Description": "Enhanced multi-state application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 276
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "facere",
      "StrippedValue": "voluptatem",
      "Description": "Open-source contextually-based superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 447
        }
      }
    },
    {
      "Value": "facere",
      "StrippedValue": "voluptatem",
      "Description": "Open-source contextually-based superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 447
        }
      }
    }
  ],
  "Description": "Programmable contextually-based alliance",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "voluptatem",
      "PersonId": 197,
      "Mrmrs": "velit",
      "Firstname": "Myrtie",
      "Lastname": "Doyle",
      "MiddleName": "Harris Group",
      "Title": "animi",
      "Description": "Total content-based benchmark",
      "Email": "damien@kris.co.uk",
      "FullName": "Keven Baumbach",
      "DirectPhone": "418-472-4949 x343",
      "FormalName": "Lockman-Eichmann",
      "CountryId": 32,
      "ContactId": 497,
      "ContactName": "Pagac LLC",
      "Retired": 15,
      "Rank": 923,
      "ActiveInterests": 752,
      "ContactDepartment": "",
      "ContactCountryId": 436,
      "ContactOrgNr": "1102711",
      "FaxPhone": "287-545-3431 x7405",
      "MobilePhone": "935.264.7247",
      "ContactPhone": "(920)011-9774",
      "AssociateName": "Parisian-Bernhard",
      "AssociateId": 149,
      "UsePersonAddress": false,
      "ContactFax": "rerum",
      "Kanafname": "corrupti",
      "Kanalname": "temporibus",
      "Post1": "numquam",
      "Post2": "expedita",
      "Post3": "voluptas",
      "EmailName": "napoleon@keebler.info",
      "ContactFullName": "Prof. Nathanael Bruen",
      "ActiveErpLinks": 892,
      "TicketPriorityId": 30,
      "SupportLanguageId": 980,
      "SupportAssociateId": 872,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 133
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "reprehenderit",
  "Xstop": false,
  "ActiveInterests": 856,
  "GroupId": 631,
  "ActiveStatusMonitorId": 996,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 859,
  "DbiAgentId": 298,
  "DbiLastSyncronized": "2010-09-10T14:23:54.9602774+02:00",
  "DbiKey": "consequatur",
  "DbiLastModified": "2020-09-16T14:23:54.9602774+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 163,
  "ActiveErpLinks": 513,
  "BounceEmails": [
    "will@greenholttreutel.name",
    "keeley@emard.info"
  ],
  "Domains": [
    "animi",
    "debitis"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Mr. Melyssa Avery Harris DDS",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "exercitationem",
    "ExtraFields2": "distinctio"
  },
  "CustomFields": {
    "CustomFields1": "est",
    "CustomFields2": "occaecati"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 946
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```