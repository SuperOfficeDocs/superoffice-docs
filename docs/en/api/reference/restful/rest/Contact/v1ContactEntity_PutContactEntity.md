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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 274,
  "Name": "Tromp-Batz",
  "Department": "",
  "OrgNr": "1018404",
  "Number1": "695464",
  "Number2": "1142121",
  "UpdatedDate": "2022-01-04T12:01:32.8081791+01:00",
  "CreatedDate": "1998-12-03T12:01:32.8081791+01:00",
  "Emails": [
    {
      "Value": "sint",
      "StrippedValue": "sed",
      "Description": "Assimilated transitional secured line"
    },
    {
      "Value": "sint",
      "StrippedValue": "sed",
      "Description": "Assimilated transitional secured line"
    }
  ],
  "Interests": [
    {
      "Id": 797,
      "Name": "Weber, Aufderhar and O'Reilly",
      "ToolTip": "Doloremque eaque cum aut.",
      "Deleted": true,
      "Rank": 685,
      "Type": "nisi",
      "ColorBlock": 87,
      "IconHint": "reiciendis",
      "Selected": false,
      "LastChanged": "2003-06-05T12:01:32.8081791+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "minima",
      "StyleHint": "voluptatem",
      "Hidden": true,
      "FullName": "Mr. Felicity Brakus"
    }
  ],
  "Urls": [
    {
      "Value": "sed",
      "StrippedValue": "pariatur",
      "Description": "Exclusive dynamic paradigm"
    },
    {
      "Value": "sed",
      "StrippedValue": "pariatur",
      "Description": "Exclusive dynamic paradigm"
    }
  ],
  "Phones": [
    {
      "Value": "vel",
      "StrippedValue": "similique",
      "Description": "Optimized holistic toolset"
    },
    {
      "Value": "vel",
      "StrippedValue": "similique",
      "Description": "Optimized holistic toolset"
    }
  ],
  "Faxes": [
    {
      "Value": "ut",
      "StrippedValue": "fugiat",
      "Description": "Monitored responsive circuit"
    },
    {
      "Value": "ut",
      "StrippedValue": "fugiat",
      "Description": "Monitored responsive circuit"
    }
  ],
  "Description": "Enhanced mobile hub",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "modi",
      "PersonId": 745,
      "Mrmrs": "quam",
      "Firstname": "Brennon",
      "Lastname": "Morissette",
      "MiddleName": "West, Balistreri and Mraz",
      "Title": "rerum",
      "Description": "Optional executive implementation",
      "Email": "norris.oconner@nader.ca",
      "FullName": "Jackson Rowe",
      "DirectPhone": "638-466-8284",
      "FormalName": "Nader-Bartoletti",
      "CountryId": 382,
      "ContactId": 983,
      "ContactName": "Borer, Eichmann and Keebler",
      "Retired": 972,
      "Rank": 639,
      "ActiveInterests": 332,
      "ContactDepartment": "",
      "ContactCountryId": 225,
      "ContactOrgNr": "695135",
      "FaxPhone": "291-734-4820",
      "MobilePhone": "(345)845-9267",
      "ContactPhone": "683-097-7080",
      "AssociateName": "Greenholt Inc and Sons",
      "AssociateId": 654,
      "UsePersonAddress": false,
      "ContactFax": "ut",
      "Kanafname": "dolore",
      "Kanalname": "officiis",
      "Post1": "rerum",
      "Post2": "quisquam",
      "Post3": "quis",
      "EmailName": "susana@terry.name",
      "ContactFullName": "Miss Brennon Lynch",
      "ActiveErpLinks": 70,
      "TicketPriorityId": 732,
      "SupportLanguageId": 315,
      "SupportAssociateId": 387,
      "CategoryName": "VIP Customer",
      "PersonNumber": "920438"
    }
  ],
  "NoMailing": true,
  "Kananame": "aspernatur",
  "Xstop": false,
  "ActiveInterests": 241,
  "GroupId": 637,
  "ActiveStatusMonitorId": 489,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 908,
  "DbiAgentId": 886,
  "DbiLastSyncronized": "2016-09-05T12:01:32.8081791+02:00",
  "DbiKey": "adipisci",
  "DbiLastModified": "2016-01-30T12:01:32.8081791+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 800,
  "ActiveErpLinks": 799,
  "BounceEmails": [
    "shawna_runte@wisozk.uk",
    "ola.windler@daugherty.biz"
  ],
  "Domains": [
    "sint",
    "aliquid"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Bridgette Balistreri",
    "SuperOffice:2": "Prof. Lina Quigley"
  },
  "ExtraFields": {
    "ExtraFields1": "dolorem",
    "ExtraFields2": "veritatis"
  },
  "CustomFields": {
    "CustomFields1": "impedit",
    "CustomFields2": "quae"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 917,
  "Name": "Schulist, Hansen and Dicki",
  "Department": "",
  "OrgNr": "815860",
  "Number1": "1068127",
  "Number2": "1912851",
  "UpdatedDate": "2010-12-20T12:01:32.8081791+01:00",
  "CreatedDate": "2000-05-24T12:01:32.8081791+02:00",
  "Emails": [
    {
      "Value": "mollitia",
      "StrippedValue": "illum",
      "Description": "Implemented homogeneous leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 647
        }
      }
    },
    {
      "Value": "mollitia",
      "StrippedValue": "illum",
      "Description": "Implemented homogeneous leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 647
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 938,
      "Name": "Oberbrunner, Kris and Leffler",
      "ToolTip": "Temporibus laudantium iste asperiores nihil quo modi doloribus.",
      "Deleted": true,
      "Rank": 155,
      "Type": "velit",
      "ColorBlock": 32,
      "IconHint": "expedita",
      "Selected": false,
      "LastChanged": "2021-12-01T12:01:32.8081791+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "vero",
      "StyleHint": "saepe",
      "Hidden": false,
      "FullName": "Ms. Ross Shawn Kihn",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 35
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "eos",
      "StrippedValue": "facere",
      "Description": "Quality-focused impactful productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 140
        }
      }
    },
    {
      "Value": "eos",
      "StrippedValue": "facere",
      "Description": "Quality-focused impactful productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 140
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "laborum",
      "StrippedValue": "commodi",
      "Description": "Persistent homogeneous neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 983
        }
      }
    },
    {
      "Value": "laborum",
      "StrippedValue": "commodi",
      "Description": "Persistent homogeneous neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 983
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "non",
      "StrippedValue": "qui",
      "Description": "Ergonomic secondary circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 54
        }
      }
    },
    {
      "Value": "non",
      "StrippedValue": "qui",
      "Description": "Ergonomic secondary circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 54
        }
      }
    }
  ],
  "Description": "Multi-layered hybrid monitoring",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quia",
      "PersonId": 150,
      "Mrmrs": "architecto",
      "Firstname": "Grant",
      "Lastname": "Braun",
      "MiddleName": "Bechtelar Inc and Sons",
      "Title": "distinctio",
      "Description": "Balanced discrete framework",
      "Email": "rubye@oconnell.co.uk",
      "FullName": "Miss Mossie Jacey Huel",
      "DirectPhone": "1-769-473-7488",
      "FormalName": "Hane Inc and Sons",
      "CountryId": 23,
      "ContactId": 563,
      "ContactName": "Dach-Hoeger",
      "Retired": 422,
      "Rank": 813,
      "ActiveInterests": 900,
      "ContactDepartment": "",
      "ContactCountryId": 450,
      "ContactOrgNr": "1131229",
      "FaxPhone": "1-904-666-2898",
      "MobilePhone": "783-910-2108 x8904",
      "ContactPhone": "1-468-087-6039",
      "AssociateName": "Kihn, Medhurst and D'Amore",
      "AssociateId": 123,
      "UsePersonAddress": false,
      "ContactFax": "eum",
      "Kanafname": "odit",
      "Kanalname": "odit",
      "Post1": "dolorum",
      "Post2": "quasi",
      "Post3": "aperiam",
      "EmailName": "gina@moenwilliamson.info",
      "ContactFullName": "Dr. Heber Simonis",
      "ActiveErpLinks": 976,
      "TicketPriorityId": 82,
      "SupportLanguageId": 617,
      "SupportAssociateId": 871,
      "CategoryName": "VIP Customer",
      "PersonNumber": "913009",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 103
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "eius",
  "Xstop": false,
  "ActiveInterests": 1000,
  "GroupId": 410,
  "ActiveStatusMonitorId": 387,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 169,
  "DbiAgentId": 495,
  "DbiLastSyncronized": "2002-10-19T12:01:32.8081791+02:00",
  "DbiKey": "modi",
  "DbiLastModified": "2010-11-12T12:01:32.8081791+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 852,
  "ActiveErpLinks": 617,
  "BounceEmails": [
    "sydni.brown@vandervortzieme.com",
    "paul@cristcorwin.name"
  ],
  "Domains": [
    "velit",
    "dolores"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Mrs. Deanna Viva Casper DDS"
  },
  "ExtraFields": {
    "ExtraFields1": "illum",
    "ExtraFields2": "eveniet"
  },
  "CustomFields": {
    "CustomFields1": "non",
    "CustomFields2": "voluptatibus"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 14
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```