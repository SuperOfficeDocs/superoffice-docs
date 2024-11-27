---
title: PUT Contact/{id}
uid: v1ContactEntity_PutContactEntity
generated: true
---

# PUT Contact/{id}

```http
PUT /api/v1/Contact/{id}
```

Updates the existing ContactEntity






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ContactEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/Contact/{id}?$select=name,department,category/id
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

ContactEntity updated.

| Response | Description |
|----------------|-------------|
| 200 | ContactEntity updated. |
| 412 | Update stopped because ContactEntity has changed since the requested If-Unmodified-Since timestamp. |
| 400 | Bad request. Entity to save is not in request body. |

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
PUT /api/v1/Contact/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ContactId": 629,
  "Name": "Waters, Witting and Swift",
  "Department": "",
  "OrgNr": "715437",
  "Number1": "605109",
  "Number2": "650741",
  "UpdatedDate": "2016-12-12T14:45:12.6619778+01:00",
  "CreatedDate": "2005-12-20T14:45:12.6619778+01:00",
  "Emails": [
    {
      "Value": "sed",
      "StrippedValue": "occaecati",
      "Description": "Programmable systematic application"
    },
    {
      "Value": "sed",
      "StrippedValue": "occaecati",
      "Description": "Programmable systematic application"
    }
  ],
  "Interests": [
    {
      "Id": 334,
      "Name": "Little LLC",
      "ToolTip": "Possimus ut veniam possimus et ut ut praesentium.",
      "Deleted": false,
      "Rank": 301,
      "Type": "magni",
      "ColorBlock": 405,
      "IconHint": "beatae",
      "Selected": false,
      "LastChanged": "2014-01-12T14:45:12.6619778+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "corporis",
      "StyleHint": "et",
      "Hidden": true,
      "FullName": "Mckenzie Ritchie"
    }
  ],
  "Urls": [
    {
      "Value": "nam",
      "StrippedValue": "magnam",
      "Description": "Organic foreground firmware"
    },
    {
      "Value": "nam",
      "StrippedValue": "magnam",
      "Description": "Organic foreground firmware"
    }
  ],
  "Phones": [
    {
      "Value": "nisi",
      "StrippedValue": "ut",
      "Description": "Triple-buffered bottom-line ability"
    },
    {
      "Value": "nisi",
      "StrippedValue": "ut",
      "Description": "Triple-buffered bottom-line ability"
    }
  ],
  "Faxes": [
    {
      "Value": "tempore",
      "StrippedValue": "at",
      "Description": "Function-based intangible portal"
    },
    {
      "Value": "tempore",
      "StrippedValue": "at",
      "Description": "Function-based intangible portal"
    }
  ],
  "Description": "Ergonomic contextually-based system engine",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "provident",
      "PersonId": 272,
      "Mrmrs": "exercitationem",
      "Firstname": "Lyla",
      "Lastname": "Spencer",
      "MiddleName": "Morissette, Nitzsche and Ryan",
      "Title": "maiores",
      "Description": "De-engineered 5th generation frame",
      "Email": "bernhard.rutherford@collins.uk",
      "FullName": "Dayne Dibbert",
      "DirectPhone": "126.734.8002 x7105",
      "FormalName": "Jast Group",
      "CountryId": 370,
      "ContactId": 102,
      "ContactName": "Windler, Roberts and Leannon",
      "Retired": 32,
      "Rank": 171,
      "ActiveInterests": 66,
      "ContactDepartment": "",
      "ContactCountryId": 789,
      "ContactOrgNr": "731769",
      "FaxPhone": "(186)086-7466 x878",
      "MobilePhone": "288.316.0761 x31663",
      "ContactPhone": "(242)141-5493 x28275",
      "AssociateName": "Maggio-Dooley",
      "AssociateId": 135,
      "UsePersonAddress": false,
      "ContactFax": "modi",
      "Kanafname": "sed",
      "Kanalname": "ea",
      "Post1": "voluptas",
      "Post2": "eum",
      "Post3": "velit",
      "EmailName": "hugh.bergstrom@lubowitz.ca",
      "ContactFullName": "Ms. Carson Delfina Cole",
      "ActiveErpLinks": 345,
      "TicketPriorityId": 821,
      "SupportLanguageId": 10,
      "SupportAssociateId": 105,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": true,
  "Kananame": "et",
  "Xstop": true,
  "ActiveInterests": 409,
  "GroupId": 725,
  "ActiveStatusMonitorId": 485,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 341,
  "DbiAgentId": 126,
  "DbiLastSyncronized": "2002-05-26T14:45:12.6619778+02:00",
  "DbiKey": "exercitationem",
  "DbiLastModified": "2016-05-15T14:45:12.6619778+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 281,
  "ActiveErpLinks": 709,
  "BounceEmails": [
    "kiarra_williamson@ziemefeeney.uk",
    "baylee@kuvalismccullough.us"
  ],
  "Domains": [
    "exercitationem",
    "rerum"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1546485548",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "quisquam",
    "ExtraFields2": "assumenda"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "sequi"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 225,
  "Name": "Watsica-Douglas",
  "Department": "",
  "OrgNr": "160439",
  "Number1": "1259811",
  "Number2": "643991",
  "UpdatedDate": "2006-02-28T14:45:12.6619778+01:00",
  "CreatedDate": "2007-11-25T14:45:12.6619778+01:00",
  "Emails": [
    {
      "Value": "voluptatem",
      "StrippedValue": "laudantium",
      "Description": "Centralized discrete methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 917
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "laudantium",
      "Description": "Centralized discrete methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 917
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 970,
      "Name": "King, Bruen and Kessler",
      "ToolTip": "Exercitationem et.",
      "Deleted": true,
      "Rank": 110,
      "Type": "inventore",
      "ColorBlock": 78,
      "IconHint": "commodi",
      "Selected": false,
      "LastChanged": "2000-01-31T14:45:12.6619778+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "minima",
      "StyleHint": "nobis",
      "Hidden": true,
      "FullName": "Brian Hobart Sauer II",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 741
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "est",
      "StrippedValue": "ullam",
      "Description": "Exclusive 3rd generation array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 23
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "ullam",
      "Description": "Exclusive 3rd generation array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 23
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "tempora",
      "StrippedValue": "autem",
      "Description": "Intuitive uniform application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 975
        }
      }
    },
    {
      "Value": "tempora",
      "StrippedValue": "autem",
      "Description": "Intuitive uniform application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 975
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "et",
      "StrippedValue": "consequuntur",
      "Description": "Grass-roots systematic leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 423
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "consequuntur",
      "Description": "Grass-roots systematic leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 423
        }
      }
    }
  ],
  "Description": "Sharable 6th generation artificial intelligence",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "dolorem",
      "PersonId": 879,
      "Mrmrs": "recusandae",
      "Firstname": "Nikita",
      "Lastname": "Gislason",
      "MiddleName": "Schowalter, Trantow and Nolan",
      "Title": "labore",
      "Description": "Fully-configurable foreground installation",
      "Email": "kendall@lemke.com",
      "FullName": "Doyle Roob II",
      "DirectPhone": "1-367-081-4681 x363",
      "FormalName": "Hoeger-Metz",
      "CountryId": 547,
      "ContactId": 387,
      "ContactName": "Jacobi-Murazik",
      "Retired": 814,
      "Rank": 416,
      "ActiveInterests": 327,
      "ContactDepartment": "",
      "ContactCountryId": 550,
      "ContactOrgNr": "518131",
      "FaxPhone": "(330)095-4097 x13223",
      "MobilePhone": "(772)881-7719 x1649",
      "ContactPhone": "1-421-490-0729",
      "AssociateName": "Considine Inc and Sons",
      "AssociateId": 643,
      "UsePersonAddress": true,
      "ContactFax": "animi",
      "Kanafname": "consequatur",
      "Kanalname": "occaecati",
      "Post1": "veritatis",
      "Post2": "ipsa",
      "Post3": "sit",
      "EmailName": "zechariah_parisian@upton.name",
      "ContactFullName": "Axel Borer",
      "ActiveErpLinks": 811,
      "TicketPriorityId": 129,
      "SupportLanguageId": 185,
      "SupportAssociateId": 694,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 993
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "voluptatibus",
  "Xstop": true,
  "ActiveInterests": 476,
  "GroupId": 350,
  "ActiveStatusMonitorId": 220,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 640,
  "DbiAgentId": 571,
  "DbiLastSyncronized": "2007-12-06T14:45:12.677599+01:00",
  "DbiKey": "ea",
  "DbiLastModified": "1999-04-12T14:45:12.677599+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 717,
  "ActiveErpLinks": 406,
  "BounceEmails": [
    "dorthy.hammes@abernathy.co.uk",
    "griffin.langosh@gottlieb.biz"
  ],
  "Domains": [
    "nihil",
    "nam"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Adrain Veum",
    "SuperOffice:2": "1238513197"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptas",
    "ExtraFields2": "officiis"
  },
  "CustomFields": {
    "CustomFields1": "fugit",
    "CustomFields2": "excepturi"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 146
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```