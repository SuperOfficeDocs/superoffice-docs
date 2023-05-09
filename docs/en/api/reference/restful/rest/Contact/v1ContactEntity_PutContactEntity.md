---
title: PUT Contact/{id}
uid: v1ContactEntity_PutContactEntity
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
  "ContactId": 714,
  "Name": "Emmerich-Larson",
  "Department": "",
  "OrgNr": "1055369",
  "Number1": "926624",
  "Number2": "1188286",
  "UpdatedDate": "2010-01-20T03:51:33.3960245+01:00",
  "CreatedDate": "2000-08-01T03:51:33.3960245+02:00",
  "Emails": [
    {
      "Value": "maiores",
      "StrippedValue": "voluptas",
      "Description": "Balanced next generation focus group"
    },
    {
      "Value": "maiores",
      "StrippedValue": "voluptas",
      "Description": "Balanced next generation focus group"
    }
  ],
  "Interests": [
    {
      "Id": 44,
      "Name": "Osinski, Maggio and Rodriguez",
      "ToolTip": "Sed ab omnis temporibus.",
      "Deleted": false,
      "Rank": 613,
      "Type": "in",
      "ColorBlock": 610,
      "IconHint": "facere",
      "Selected": false,
      "LastChanged": "2004-02-24T03:51:33.3960245+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "est",
      "StyleHint": "eligendi",
      "Hidden": false,
      "FullName": "Andreanne Ortiz PhD"
    }
  ],
  "Urls": [
    {
      "Value": "ea",
      "StrippedValue": "eos",
      "Description": "Ergonomic upward-trending artificial intelligence"
    },
    {
      "Value": "ea",
      "StrippedValue": "eos",
      "Description": "Ergonomic upward-trending artificial intelligence"
    }
  ],
  "Phones": [
    {
      "Value": "repudiandae",
      "StrippedValue": "corrupti",
      "Description": "Customizable real-time projection"
    },
    {
      "Value": "repudiandae",
      "StrippedValue": "corrupti",
      "Description": "Customizable real-time projection"
    }
  ],
  "Faxes": [
    {
      "Value": "voluptates",
      "StrippedValue": "facere",
      "Description": "Focused holistic capacity"
    },
    {
      "Value": "voluptates",
      "StrippedValue": "facere",
      "Description": "Focused holistic capacity"
    }
  ],
  "Description": "Advanced didactic attitude",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quas",
      "PersonId": 987,
      "Mrmrs": "et",
      "Firstname": "Freddy",
      "Lastname": "Wiegand",
      "MiddleName": "Runolfsdottir-Beier",
      "Title": "dolores",
      "Description": "Polarised well-modulated monitoring",
      "Email": "arden.hirthe@halvorson.ca",
      "FullName": "Furman Smith",
      "DirectPhone": "1-640-965-5618",
      "FormalName": "Barton-Harris",
      "CountryId": 837,
      "ContactId": 38,
      "ContactName": "Steuber-Osinski",
      "Retired": 321,
      "Rank": 485,
      "ActiveInterests": 619,
      "ContactDepartment": "",
      "ContactCountryId": 558,
      "ContactOrgNr": "332356",
      "FaxPhone": "(800)138-0797 x4744",
      "MobilePhone": "(083)233-8893",
      "ContactPhone": "890.402.6111 x8216",
      "AssociateName": "Corwin-O'Kon",
      "AssociateId": 245,
      "UsePersonAddress": false,
      "ContactFax": "natus",
      "Kanafname": "ullam",
      "Kanalname": "consequatur",
      "Post1": "iusto",
      "Post2": "ab",
      "Post3": "debitis",
      "EmailName": "woodrow@towne.biz",
      "ContactFullName": "Gaylord Wilderman",
      "ActiveErpLinks": 861,
      "TicketPriorityId": 955,
      "SupportLanguageId": 411,
      "SupportAssociateId": 603,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": true,
  "Kananame": "facilis",
  "Xstop": false,
  "ActiveInterests": 312,
  "GroupId": 419,
  "ActiveStatusMonitorId": 670,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 374,
  "DbiAgentId": 296,
  "DbiLastSyncronized": "2004-12-13T03:51:33.4585118+01:00",
  "DbiKey": "cum",
  "DbiLastModified": "2015-10-12T03:51:33.4585118+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 85,
  "ActiveErpLinks": 725,
  "BounceEmails": [
    "marjolaine.koepp@goodwinbruen.name",
    "rosie.morissette@corwin.ca"
  ],
  "Domains": [
    "cum",
    "eum"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Dwight Ferry",
    "SuperOffice:2": "1160915693"
  },
  "ExtraFields": {
    "ExtraFields1": "autem",
    "ExtraFields2": "fuga"
  },
  "CustomFields": {
    "CustomFields1": "doloremque",
    "CustomFields2": "distinctio"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 878,
  "Name": "Miller-Schimmel",
  "Department": "",
  "OrgNr": "905313",
  "Number1": "900711",
  "Number2": "1581558",
  "UpdatedDate": "2017-01-19T03:51:33.4897518+01:00",
  "CreatedDate": "2010-11-16T03:51:33.4897518+01:00",
  "Emails": [
    {
      "Value": "libero",
      "StrippedValue": "distinctio",
      "Description": "Reverse-engineered discrete protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 432
        }
      }
    },
    {
      "Value": "libero",
      "StrippedValue": "distinctio",
      "Description": "Reverse-engineered discrete protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 432
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 30,
      "Name": "Donnelly-Mraz",
      "ToolTip": "Odit vitae.",
      "Deleted": false,
      "Rank": 667,
      "Type": "magni",
      "ColorBlock": 653,
      "IconHint": "quia",
      "Selected": false,
      "LastChanged": "2007-05-16T03:51:33.4897518+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolorem",
      "StyleHint": "ipsa",
      "Hidden": false,
      "FullName": "Carli Kovacek III",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 373
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "qui",
      "StrippedValue": "explicabo",
      "Description": "Down-sized transitional encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 663
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "explicabo",
      "Description": "Down-sized transitional encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 663
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "reiciendis",
      "StrippedValue": "autem",
      "Description": "Function-based discrete analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 38
        }
      }
    },
    {
      "Value": "reiciendis",
      "StrippedValue": "autem",
      "Description": "Function-based discrete analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 38
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "expedita",
      "StrippedValue": "doloremque",
      "Description": "Proactive zero administration framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 222
        }
      }
    },
    {
      "Value": "expedita",
      "StrippedValue": "doloremque",
      "Description": "Proactive zero administration framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 222
        }
      }
    }
  ],
  "Description": "Seamless empowering data-warehouse",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "nobis",
      "PersonId": 913,
      "Mrmrs": "ea",
      "Firstname": "Kody",
      "Lastname": "Kautzer",
      "MiddleName": "Shields-Osinski",
      "Title": "natus",
      "Description": "Persevering optimizing matrix",
      "Email": "jeffrey@stokes.co.uk",
      "FullName": "Mrs. Robin Columbus Bernhard IV",
      "DirectPhone": "890.485.7447 x73241",
      "FormalName": "Mayer Inc and Sons",
      "CountryId": 425,
      "ContactId": 16,
      "ContactName": "Nitzsche-Stiedemann",
      "Retired": 805,
      "Rank": 659,
      "ActiveInterests": 965,
      "ContactDepartment": "",
      "ContactCountryId": 926,
      "ContactOrgNr": "1790228",
      "FaxPhone": "1-417-721-6625 x6029",
      "MobilePhone": "(510)542-8228 x29359",
      "ContactPhone": "(310)258-1164 x89144",
      "AssociateName": "Tromp, Little and Zieme",
      "AssociateId": 332,
      "UsePersonAddress": false,
      "ContactFax": "hic",
      "Kanafname": "voluptatem",
      "Kanalname": "aspernatur",
      "Post1": "magni",
      "Post2": "doloribus",
      "Post3": "magni",
      "EmailName": "miguel_schmitt@schumm.co.uk",
      "ContactFullName": "Marilou Schowalter Sr.",
      "ActiveErpLinks": 502,
      "TicketPriorityId": 690,
      "SupportLanguageId": 935,
      "SupportAssociateId": 438,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 128
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "alias",
  "Xstop": true,
  "ActiveInterests": 479,
  "GroupId": 702,
  "ActiveStatusMonitorId": 610,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 300,
  "DbiAgentId": 962,
  "DbiLastSyncronized": "2006-10-31T03:51:33.5053748+01:00",
  "DbiKey": "quo",
  "DbiLastModified": "2004-09-22T03:51:33.5053748+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 951,
  "ActiveErpLinks": 166,
  "BounceEmails": [
    "philip@greenholt.us",
    "buddy@okon.ca"
  ],
  "Domains": [
    "atque",
    "illum"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Kris Griffin Dietrich II",
    "SuperOffice:2": "334946744"
  },
  "ExtraFields": {
    "ExtraFields1": "qui",
    "ExtraFields2": "eligendi"
  },
  "CustomFields": {
    "CustomFields1": "sequi",
    "CustomFields2": "aspernatur"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 487
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```