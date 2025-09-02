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
| InitialUtmParameters | InitalUtmParameters | Initial utm parameters when creating first person, readonly field |
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
| InitialUtmParameters | InitalUtmParameters | Initial utm parameters when creating first person, readonly field |
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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 904,
  "Name": "Wiegand, Witting and Hahn",
  "Department": "",
  "OrgNr": "743605",
  "Number1": "1767310",
  "Number2": "644486",
  "UpdatedDate": "2015-03-18T03:46:59.8318192+01:00",
  "CreatedDate": "2019-07-15T03:46:59.8318192+02:00",
  "Emails": [
    {
      "Value": "consequatur",
      "StrippedValue": "corporis",
      "Description": "Horizontal actuating frame"
    },
    {
      "Value": "consequatur",
      "StrippedValue": "corporis",
      "Description": "Horizontal actuating frame"
    }
  ],
  "Interests": [
    {
      "Id": 268,
      "Name": "Maggio Inc and Sons",
      "ToolTip": "Facere qui ratione quas molestias quas sunt.",
      "Deleted": false,
      "Rank": 538,
      "Type": "voluptatem",
      "ColorBlock": 494,
      "IconHint": "nostrum",
      "Selected": false,
      "LastChanged": "2013-01-24T03:46:59.8318192+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "est",
      "StyleHint": "et",
      "Hidden": false,
      "FullName": "Kelly O'Kon"
    }
  ],
  "Urls": [
    {
      "Value": "reprehenderit",
      "StrippedValue": "aut",
      "Description": "Open-source well-modulated budgetary management"
    },
    {
      "Value": "reprehenderit",
      "StrippedValue": "aut",
      "Description": "Open-source well-modulated budgetary management"
    }
  ],
  "Phones": [
    {
      "Value": "voluptatem",
      "StrippedValue": "quo",
      "Description": "Enterprise-wide zero defect data-warehouse"
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "quo",
      "Description": "Enterprise-wide zero defect data-warehouse"
    }
  ],
  "Faxes": [
    {
      "Value": "corrupti",
      "StrippedValue": "alias",
      "Description": "Persistent zero administration alliance"
    },
    {
      "Value": "corrupti",
      "StrippedValue": "alias",
      "Description": "Persistent zero administration alliance"
    }
  ],
  "Description": "Quality-focused 24/7 definition",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "placeat",
      "PersonId": 177,
      "Mrmrs": "et",
      "Firstname": "Valentina",
      "Lastname": "Schmitt",
      "MiddleName": "Cremin, Labadie and Upton",
      "Title": "possimus",
      "Description": "Open-source directional complexity",
      "Email": "maryjane@bernier.co.uk",
      "FullName": "Minnie Leffler",
      "DirectPhone": "(564)248-7918 x823",
      "FormalName": "Mosciski Group",
      "CountryId": 619,
      "ContactId": 207,
      "ContactName": "Dach, Daugherty and Hand",
      "Retired": 660,
      "Rank": 801,
      "ActiveInterests": 394,
      "ContactDepartment": "",
      "ContactCountryId": 416,
      "ContactOrgNr": "604628",
      "FaxPhone": "053.198.5510",
      "MobilePhone": "026-405-3423 x67722",
      "ContactPhone": "358-486-1394 x5533",
      "AssociateName": "Hodkiewicz, Kihn and Lindgren",
      "AssociateId": 57,
      "UsePersonAddress": true,
      "ContactFax": "porro",
      "Kanafname": "iste",
      "Kanalname": "unde",
      "Post1": "et",
      "Post2": "necessitatibus",
      "Post3": "aut",
      "EmailName": "emanuel@west.info",
      "ContactFullName": "Carli Abernathy",
      "ActiveErpLinks": 983,
      "TicketPriorityId": 940,
      "SupportLanguageId": 180,
      "SupportAssociateId": 100,
      "CategoryName": "VIP Customer",
      "PersonNumber": "818665"
    }
  ],
  "NoMailing": false,
  "Kananame": "ut",
  "Xstop": false,
  "ActiveInterests": 48,
  "GroupId": 882,
  "ActiveStatusMonitorId": 307,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 942,
  "DbiAgentId": 53,
  "DbiLastSyncronized": "2010-04-01T03:46:59.8318192+02:00",
  "DbiKey": "voluptates",
  "DbiLastModified": "2020-12-05T03:46:59.8318192+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 125,
  "ActiveErpLinks": 667,
  "BounceEmails": [
    "van.lind@hoppe.us",
    "lamar@wilkinson.co.uk"
  ],
  "Domains": [
    "qui",
    "earum"
  ],
  "InitialUtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Cedrick Gleason",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "officia",
    "ExtraFields2": "nostrum"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "dolores"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 351,
  "Name": "Heller LLC",
  "Department": "",
  "OrgNr": "933264",
  "Number1": "1287595",
  "Number2": "1898822",
  "UpdatedDate": "2009-07-09T03:46:59.8318192+02:00",
  "CreatedDate": "2006-06-13T03:46:59.8318192+02:00",
  "Emails": [
    {
      "Value": "perspiciatis",
      "StrippedValue": "tempore",
      "Description": "Horizontal multi-state algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 973
        }
      }
    },
    {
      "Value": "perspiciatis",
      "StrippedValue": "tempore",
      "Description": "Horizontal multi-state algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 973
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 150,
      "Name": "Rosenbaum-Lang",
      "ToolTip": "Est nulla.",
      "Deleted": true,
      "Rank": 463,
      "Type": "delectus",
      "ColorBlock": 953,
      "IconHint": "ad",
      "Selected": false,
      "LastChanged": "2018-09-28T03:46:59.8318192+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "perspiciatis",
      "StyleHint": "voluptates",
      "Hidden": true,
      "FullName": "Mr. Gia VonRueden PhD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 294
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "rerum",
      "StrippedValue": "ut",
      "Description": "Total motivating open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 69
        }
      }
    },
    {
      "Value": "rerum",
      "StrippedValue": "ut",
      "Description": "Total motivating open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 69
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "laborum",
      "StrippedValue": "qui",
      "Description": "Compatible directional open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 276
        }
      }
    },
    {
      "Value": "laborum",
      "StrippedValue": "qui",
      "Description": "Compatible directional open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 276
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "et",
      "StrippedValue": "eos",
      "Description": "Switchable intangible installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 542
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "eos",
      "Description": "Switchable intangible installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 542
        }
      }
    }
  ],
  "Description": "Universal intangible artificial intelligence",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ut",
      "PersonId": 406,
      "Mrmrs": "unde",
      "Firstname": "Emory",
      "Lastname": "Davis",
      "MiddleName": "Deckow Inc and Sons",
      "Title": "reprehenderit",
      "Description": "Profound intangible instruction set",
      "Email": "amalia@wisozk.us",
      "FullName": "Consuelo Bradtke",
      "DirectPhone": "009.213.0794 x143",
      "FormalName": "O'Reilly Group",
      "CountryId": 502,
      "ContactId": 545,
      "ContactName": "Bashirian Inc and Sons",
      "Retired": 181,
      "Rank": 277,
      "ActiveInterests": 211,
      "ContactDepartment": "",
      "ContactCountryId": 12,
      "ContactOrgNr": "1246450",
      "FaxPhone": "(693)584-5328 x0266",
      "MobilePhone": "125.338.7553 x353",
      "ContactPhone": "070-911-1444 x76219",
      "AssociateName": "Murazik, Jakubowski and Wiegand",
      "AssociateId": 405,
      "UsePersonAddress": false,
      "ContactFax": "corporis",
      "Kanafname": "modi",
      "Kanalname": "occaecati",
      "Post1": "sunt",
      "Post2": "optio",
      "Post3": "accusamus",
      "EmailName": "brain.howell@beckermorar.com",
      "ContactFullName": "Ms. Alexane Lawson Botsford IV",
      "ActiveErpLinks": 678,
      "TicketPriorityId": 410,
      "SupportLanguageId": 155,
      "SupportAssociateId": 936,
      "CategoryName": "VIP Customer",
      "PersonNumber": "957271",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 562
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "quam",
  "Xstop": true,
  "ActiveInterests": 718,
  "GroupId": 391,
  "ActiveStatusMonitorId": 821,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 897,
  "DbiAgentId": 86,
  "DbiLastSyncronized": "2016-03-05T03:46:59.8318192+01:00",
  "DbiKey": "qui",
  "DbiLastModified": "2003-02-08T03:46:59.8318192+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 168,
  "ActiveErpLinks": 503,
  "BounceEmails": [
    "kareem_greenholt@mrazcrist.com",
    "erick@marquardt.biz"
  ],
  "Domains": [
    "omnis",
    "ex"
  ],
  "InitialUtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Eleazar Thompson",
    "SuperOffice:2": "Mr. Kacey Brekke"
  },
  "ExtraFields": {
    "ExtraFields1": "illum",
    "ExtraFields2": "molestiae"
  },
  "CustomFields": {
    "CustomFields1": "adipisci",
    "CustomFields2": "qui"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 517
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```