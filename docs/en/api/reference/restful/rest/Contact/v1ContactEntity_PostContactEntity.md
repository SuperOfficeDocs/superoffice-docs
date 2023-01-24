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
  "ContactId": 33,
  "Name": "Stamm, Blanda and Bradtke",
  "Department": "",
  "OrgNr": "1445651",
  "Number1": "1675627",
  "Number2": "158767",
  "UpdatedDate": "2019-09-12T11:22:44.4601431+02:00",
  "CreatedDate": "2003-05-10T11:22:44.4601431+02:00",
  "Emails": [
    {
      "Value": "et",
      "StrippedValue": "ut",
      "Description": "Customer-focused neutral pricing structure"
    },
    {
      "Value": "et",
      "StrippedValue": "ut",
      "Description": "Customer-focused neutral pricing structure"
    }
  ],
  "Interests": [
    {
      "Id": 31,
      "Name": "Crist-Mills",
      "ToolTip": "Blanditiis enim fugit sequi magnam.",
      "Deleted": true,
      "Rank": 96,
      "Type": "ut",
      "ColorBlock": 988,
      "IconHint": "laborum",
      "Selected": false,
      "LastChanged": "1999-08-04T11:22:44.4601431+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "autem",
      "StyleHint": "neque",
      "Hidden": false,
      "FullName": "Hilbert Schamberger"
    }
  ],
  "Urls": [
    {
      "Value": "neque",
      "StrippedValue": "laborum",
      "Description": "Progressive tangible concept"
    },
    {
      "Value": "neque",
      "StrippedValue": "laborum",
      "Description": "Progressive tangible concept"
    }
  ],
  "Phones": [
    {
      "Value": "veritatis",
      "StrippedValue": "rerum",
      "Description": "Profound high-level superstructure"
    },
    {
      "Value": "veritatis",
      "StrippedValue": "rerum",
      "Description": "Profound high-level superstructure"
    }
  ],
  "Faxes": [
    {
      "Value": "impedit",
      "StrippedValue": "aut",
      "Description": "Down-sized real-time framework"
    },
    {
      "Value": "impedit",
      "StrippedValue": "aut",
      "Description": "Down-sized real-time framework"
    }
  ],
  "Description": "Versatile impactful implementation",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quia",
      "PersonId": 825,
      "Mrmrs": "itaque",
      "Firstname": "Violet",
      "Lastname": "Reinger",
      "MiddleName": "Bins, Moen and Jast",
      "Title": "voluptatem",
      "Description": "Diverse fault-tolerant artificial intelligence",
      "Email": "lilian.cronin@cummerata.biz",
      "FullName": "Mrs. Jayda Geovany Prosacco",
      "DirectPhone": "(875)218-0040 x44578",
      "FormalName": "Murazik Group",
      "CountryId": 321,
      "ContactId": 868,
      "ContactName": "Halvorson Group",
      "Retired": 183,
      "Rank": 927,
      "ActiveInterests": 787,
      "ContactDepartment": "",
      "ContactCountryId": 610,
      "ContactOrgNr": "952528",
      "FaxPhone": "1-281-079-5296 x73469",
      "MobilePhone": "744.693.2401",
      "ContactPhone": "717.797.3670 x0382",
      "AssociateName": "Spencer, Wisozk and Senger",
      "AssociateId": 924,
      "UsePersonAddress": true,
      "ContactFax": "velit",
      "Kanafname": "sequi",
      "Kanalname": "sed",
      "Post1": "adipisci",
      "Post2": "debitis",
      "Post3": "aut",
      "EmailName": "dillon@dickens.co.uk",
      "ContactFullName": "Anahi Ziemann",
      "ActiveErpLinks": 659,
      "TicketPriorityId": 316,
      "SupportLanguageId": 142,
      "SupportAssociateId": 213,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": true,
  "Kananame": "illo",
  "Xstop": false,
  "ActiveInterests": 854,
  "GroupId": 775,
  "ActiveStatusMonitorId": 805,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 475,
  "DbiAgentId": 639,
  "DbiLastSyncronized": "2001-02-09T11:22:44.4757675+01:00",
  "DbiKey": "enim",
  "DbiLastModified": "2006-02-18T11:22:44.4757675+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 135,
  "ActiveErpLinks": 296,
  "BounceEmails": [
    "gerard_dare@harvey.co.uk",
    "roberto@nienow.name"
  ],
  "Domains": [
    "accusamus",
    "id"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "in",
    "ExtraFields2": "consequatur"
  },
  "CustomFields": {
    "CustomFields1": "quam",
    "CustomFields2": "voluptas"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 548,
  "Name": "Mohr Inc and Sons",
  "Department": "",
  "OrgNr": "1231396",
  "Number1": "1314582",
  "Number2": "1226801",
  "UpdatedDate": "1999-02-13T11:22:44.4757675+01:00",
  "CreatedDate": "1998-01-06T11:22:44.4757675+01:00",
  "Emails": [
    {
      "Value": "fuga",
      "StrippedValue": "a",
      "Description": "Organized disintermediate toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 381
        }
      }
    },
    {
      "Value": "fuga",
      "StrippedValue": "a",
      "Description": "Organized disintermediate toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 381
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 776,
      "Name": "Cummings-Christiansen",
      "ToolTip": "Hic alias officia mollitia.",
      "Deleted": false,
      "Rank": 722,
      "Type": "impedit",
      "ColorBlock": 262,
      "IconHint": "est",
      "Selected": true,
      "LastChanged": "2017-09-16T11:22:44.4757675+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eos",
      "StyleHint": "voluptas",
      "Hidden": true,
      "FullName": "Catharine Okuneva",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 558
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "qui",
      "StrippedValue": "porro",
      "Description": "Optional bifurcated matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 688
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "porro",
      "Description": "Optional bifurcated matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 688
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "animi",
      "StrippedValue": "in",
      "Description": "Compatible bottom-line capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 944
        }
      }
    },
    {
      "Value": "animi",
      "StrippedValue": "in",
      "Description": "Compatible bottom-line capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 944
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quia",
      "StrippedValue": "expedita",
      "Description": "Fundamental background access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 335
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "expedita",
      "Description": "Fundamental background access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 335
        }
      }
    }
  ],
  "Description": "Inverse client-driven infrastructure",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ea",
      "PersonId": 250,
      "Mrmrs": "et",
      "Firstname": "Giovani",
      "Lastname": "Luettgen",
      "MiddleName": "Ruecker LLC",
      "Title": "molestiae",
      "Description": "Self-enabling user-facing concept",
      "Email": "marielle_walker@damorefeil.com",
      "FullName": "Franz Hoeger",
      "DirectPhone": "189-207-2068",
      "FormalName": "Volkman Inc and Sons",
      "CountryId": 741,
      "ContactId": 218,
      "ContactName": "Leuschke-Dooley",
      "Retired": 41,
      "Rank": 480,
      "ActiveInterests": 6,
      "ContactDepartment": "",
      "ContactCountryId": 742,
      "ContactOrgNr": "954330",
      "FaxPhone": "473.095.5946 x1346",
      "MobilePhone": "1-208-558-6924 x99593",
      "ContactPhone": "324.782.2083",
      "AssociateName": "White, Denesik and McLaughlin",
      "AssociateId": 744,
      "UsePersonAddress": false,
      "ContactFax": "asperiores",
      "Kanafname": "eos",
      "Kanalname": "distinctio",
      "Post1": "totam",
      "Post2": "cumque",
      "Post3": "possimus",
      "EmailName": "ulises@schambergerschaden.ca",
      "ContactFullName": "Heber Brekke",
      "ActiveErpLinks": 821,
      "TicketPriorityId": 439,
      "SupportLanguageId": 815,
      "SupportAssociateId": 784,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 831
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "velit",
  "Xstop": false,
  "ActiveInterests": 671,
  "GroupId": 465,
  "ActiveStatusMonitorId": 299,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 713,
  "DbiAgentId": 664,
  "DbiLastSyncronized": "2019-08-12T11:22:44.4757675+02:00",
  "DbiKey": "qui",
  "DbiLastModified": "2017-06-27T11:22:44.4757675+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 590,
  "ActiveErpLinks": 758,
  "BounceEmails": [
    "harry.murphy@skiles.uk",
    "miles@bednar.us"
  ],
  "Domains": [
    "aut",
    "et"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Miss Rasheed Daron Wolf",
    "SuperOffice:2": "2096109500"
  },
  "ExtraFields": {
    "ExtraFields1": "quos",
    "ExtraFields2": "nesciunt"
  },
  "CustomFields": {
    "CustomFields1": "libero",
    "CustomFields2": "pariatur"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 951
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```