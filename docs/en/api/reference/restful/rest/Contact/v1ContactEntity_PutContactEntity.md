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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 927,
  "Name": "Ward, Crooks and Hegmann",
  "Department": "",
  "OrgNr": "1482239",
  "Number1": "20299",
  "Number2": "552388",
  "UpdatedDate": "2017-06-17T02:38:25.979826+02:00",
  "CreatedDate": "2006-03-15T02:38:25.979826+01:00",
  "Emails": [
    {
      "Value": "aliquam",
      "StrippedValue": "nemo",
      "Description": "Up-sized dedicated protocol"
    },
    {
      "Value": "aliquam",
      "StrippedValue": "nemo",
      "Description": "Up-sized dedicated protocol"
    }
  ],
  "Interests": [
    {
      "Id": 235,
      "Name": "O'Keefe, Waters and Beahan",
      "ToolTip": "Doloremque adipisci et quas fugit et.",
      "Deleted": false,
      "Rank": 245,
      "Type": "facere",
      "ColorBlock": 732,
      "IconHint": "occaecati",
      "Selected": true,
      "LastChanged": "1997-12-02T02:38:25.979826+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "illum",
      "StyleHint": "omnis",
      "Hidden": false,
      "FullName": "Sidney Bailey"
    }
  ],
  "Urls": [
    {
      "Value": "dolorum",
      "StrippedValue": "in",
      "Description": "Secured methodical approach"
    },
    {
      "Value": "dolorum",
      "StrippedValue": "in",
      "Description": "Secured methodical approach"
    }
  ],
  "Phones": [
    {
      "Value": "repellendus",
      "StrippedValue": "quis",
      "Description": "Synchronised holistic knowledge user"
    },
    {
      "Value": "repellendus",
      "StrippedValue": "quis",
      "Description": "Synchronised holistic knowledge user"
    }
  ],
  "Faxes": [
    {
      "Value": "aliquid",
      "StrippedValue": "ex",
      "Description": "Assimilated value-added synergy"
    },
    {
      "Value": "aliquid",
      "StrippedValue": "ex",
      "Description": "Assimilated value-added synergy"
    }
  ],
  "Description": "Visionary fault-tolerant projection",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "distinctio",
      "PersonId": 735,
      "Mrmrs": "quia",
      "Firstname": "Elvie",
      "Lastname": "Flatley",
      "MiddleName": "Borer LLC",
      "Title": "voluptatum",
      "Description": "Grass-roots modular strategy",
      "Email": "julie@emard.info",
      "FullName": "Prof. Shane Lizzie Turcotte Sr.",
      "DirectPhone": "(495)468-9583 x312",
      "FormalName": "Larson, Kuvalis and Roob",
      "CountryId": 744,
      "ContactId": 935,
      "ContactName": "Brakus Inc and Sons",
      "Retired": 672,
      "Rank": 580,
      "ActiveInterests": 384,
      "ContactDepartment": "",
      "ContactCountryId": 345,
      "ContactOrgNr": "985599",
      "FaxPhone": "248.520.1756",
      "MobilePhone": "1-346-812-7333",
      "ContactPhone": "(533)319-5267 x6993",
      "AssociateName": "West-O'Kon",
      "AssociateId": 617,
      "UsePersonAddress": false,
      "ContactFax": "quas",
      "Kanafname": "dolorem",
      "Kanalname": "in",
      "Post1": "omnis",
      "Post2": "et",
      "Post3": "impedit",
      "EmailName": "margie@dibbert.name",
      "ContactFullName": "Gerson Bashirian",
      "ActiveErpLinks": 893,
      "TicketPriorityId": 401,
      "SupportLanguageId": 141,
      "SupportAssociateId": 682,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1175671"
    }
  ],
  "NoMailing": true,
  "Kananame": "nihil",
  "Xstop": false,
  "ActiveInterests": 366,
  "GroupId": 793,
  "ActiveStatusMonitorId": 754,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 431,
  "DbiAgentId": 886,
  "DbiLastSyncronized": "2013-08-02T02:38:25.995452+02:00",
  "DbiKey": "ut",
  "DbiLastModified": "2006-11-01T02:38:25.995452+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 299,
  "ActiveErpLinks": 356,
  "BounceEmails": [
    "delmer.fay@willdare.name",
    "anabelle.emmerich@reillycole.ca"
  ],
  "Domains": [
    "quidem",
    "omnis"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Mrs. Marianna Will",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "incidunt",
    "ExtraFields2": "harum"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "est"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 366,
  "Name": "Rowe, Adams and Thompson",
  "Department": "",
  "OrgNr": "1058721",
  "Number1": "1067431",
  "Number2": "547872",
  "UpdatedDate": "2001-04-16T02:38:25.995452+02:00",
  "CreatedDate": "2003-06-19T02:38:25.995452+02:00",
  "Emails": [
    {
      "Value": "et",
      "StrippedValue": "optio",
      "Description": "Compatible uniform analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 256
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "optio",
      "Description": "Compatible uniform analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 256
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 90,
      "Name": "Dietrich-Walker",
      "ToolTip": "Est natus eligendi consequatur deserunt.",
      "Deleted": false,
      "Rank": 900,
      "Type": "ut",
      "ColorBlock": 79,
      "IconHint": "fuga",
      "Selected": false,
      "LastChanged": "2012-01-01T02:38:25.995452+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "odio",
      "StyleHint": "aut",
      "Hidden": false,
      "FullName": "Jewel Moen",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 3
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "possimus",
      "StrippedValue": "ducimus",
      "Description": "Enterprise-wide cohesive forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 184
        }
      }
    },
    {
      "Value": "possimus",
      "StrippedValue": "ducimus",
      "Description": "Enterprise-wide cohesive forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 184
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "ut",
      "StrippedValue": "nihil",
      "Description": "Operative demand-driven firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 250
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "nihil",
      "Description": "Operative demand-driven firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 250
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "eum",
      "StrippedValue": "debitis",
      "Description": "Open-architected encompassing time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 532
        }
      }
    },
    {
      "Value": "eum",
      "StrippedValue": "debitis",
      "Description": "Open-architected encompassing time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 532
        }
      }
    }
  ],
  "Description": "Optional leading edge hardware",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "cupiditate",
      "PersonId": 343,
      "Mrmrs": "tempore",
      "Firstname": "Brandy",
      "Lastname": "Jacobs",
      "MiddleName": "Romaguera, Quitzon and Durgan",
      "Title": "esse",
      "Description": "Distributed radical alliance",
      "Email": "sammy.quigley@schoen.info",
      "FullName": "Titus Beahan",
      "DirectPhone": "1-480-188-9404",
      "FormalName": "Kutch Group",
      "CountryId": 449,
      "ContactId": 274,
      "ContactName": "McCullough, Satterfield and Deckow",
      "Retired": 792,
      "Rank": 226,
      "ActiveInterests": 29,
      "ContactDepartment": "",
      "ContactCountryId": 961,
      "ContactOrgNr": "917200",
      "FaxPhone": "1-831-701-9034",
      "MobilePhone": "(838)239-8602 x509",
      "ContactPhone": "768.817.4483 x0321",
      "AssociateName": "Turcotte, Jaskolski and Parisian",
      "AssociateId": 245,
      "UsePersonAddress": false,
      "ContactFax": "rerum",
      "Kanafname": "architecto",
      "Kanalname": "et",
      "Post1": "quia",
      "Post2": "qui",
      "Post3": "facere",
      "EmailName": "lilliana_dubuque@kochkub.biz",
      "ContactFullName": "Aisha Kirlin",
      "ActiveErpLinks": 514,
      "TicketPriorityId": 858,
      "SupportLanguageId": 803,
      "SupportAssociateId": 206,
      "CategoryName": "VIP Customer",
      "PersonNumber": "850974",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 205
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "quam",
  "Xstop": true,
  "ActiveInterests": 907,
  "GroupId": 117,
  "ActiveStatusMonitorId": 539,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 618,
  "DbiAgentId": 833,
  "DbiLastSyncronized": "2024-08-23T02:38:25.995452+02:00",
  "DbiKey": "blanditiis",
  "DbiLastModified": "2003-03-13T02:38:25.995452+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 974,
  "ActiveErpLinks": 139,
  "BounceEmails": [
    "libbie@hilpertfeil.ca",
    "charley_rutherford@moore.us"
  ],
  "Domains": [
    "rerum",
    "exercitationem"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Prof. Keeley Dickens II",
    "SuperOffice:2": "1646798525"
  },
  "ExtraFields": {
    "ExtraFields1": "magnam",
    "ExtraFields2": "velit"
  },
  "CustomFields": {
    "CustomFields1": "consectetur",
    "CustomFields2": "qui"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 194
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```