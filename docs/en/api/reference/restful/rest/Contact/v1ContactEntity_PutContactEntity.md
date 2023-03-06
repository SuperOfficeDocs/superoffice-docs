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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/Contact/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ContactId": 572,
  "Name": "Heathcote Group",
  "Department": "",
  "OrgNr": "1232379",
  "Number1": "255497",
  "Number2": "1315923",
  "UpdatedDate": "2017-05-09T14:19:10.1779741+02:00",
  "CreatedDate": "2017-02-23T14:19:10.1779741+01:00",
  "Emails": [
    {
      "Value": "dolorem",
      "StrippedValue": "at",
      "Description": "Right-sized maximized array"
    },
    {
      "Value": "dolorem",
      "StrippedValue": "at",
      "Description": "Right-sized maximized array"
    }
  ],
  "Interests": [
    {
      "Id": 893,
      "Name": "Corwin, Dietrich and Hermiston",
      "ToolTip": "Cumque dolor consectetur deserunt ullam.",
      "Deleted": false,
      "Rank": 101,
      "Type": "qui",
      "ColorBlock": 858,
      "IconHint": "maiores",
      "Selected": false,
      "LastChanged": "2007-06-06T14:19:10.1779741+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "esse",
      "StyleHint": "atque",
      "Hidden": false,
      "FullName": "Michele Franecki"
    }
  ],
  "Urls": [
    {
      "Value": "et",
      "StrippedValue": "animi",
      "Description": "Versatile bifurcated protocol"
    },
    {
      "Value": "et",
      "StrippedValue": "animi",
      "Description": "Versatile bifurcated protocol"
    }
  ],
  "Phones": [
    {
      "Value": "molestias",
      "StrippedValue": "incidunt",
      "Description": "Virtual 5th generation website"
    },
    {
      "Value": "molestias",
      "StrippedValue": "incidunt",
      "Description": "Virtual 5th generation website"
    }
  ],
  "Faxes": [
    {
      "Value": "praesentium",
      "StrippedValue": "vero",
      "Description": "Business-focused bottom-line structure"
    },
    {
      "Value": "praesentium",
      "StrippedValue": "vero",
      "Description": "Business-focused bottom-line structure"
    }
  ],
  "Description": "Vision-oriented composite intranet",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "beatae",
      "PersonId": 949,
      "Mrmrs": "animi",
      "Firstname": "Roberta",
      "Lastname": "Kub",
      "MiddleName": "Reichert, Brekke and Fahey",
      "Title": "dignissimos",
      "Description": "Ameliorated object-oriented array",
      "Email": "lia@sengerfahey.com",
      "FullName": "Ms. Shaina Lucy Boyer DDS",
      "DirectPhone": "1-692-862-9767",
      "FormalName": "Spinka-Oberbrunner",
      "CountryId": 56,
      "ContactId": 562,
      "ContactName": "Bayer, Huels and Rohan",
      "Retired": 54,
      "Rank": 183,
      "ActiveInterests": 762,
      "ContactDepartment": "",
      "ContactCountryId": 181,
      "ContactOrgNr": "654520",
      "FaxPhone": "981.066.6726",
      "MobilePhone": "(464)310-5023 x5139",
      "ContactPhone": "965.093.8969 x176",
      "AssociateName": "Paucek, Erdman and Hansen",
      "AssociateId": 825,
      "UsePersonAddress": true,
      "ContactFax": "animi",
      "Kanafname": "inventore",
      "Kanalname": "hic",
      "Post1": "recusandae",
      "Post2": "similique",
      "Post3": "ut",
      "EmailName": "dario_sipes@denesik.us",
      "ContactFullName": "Assunta Streich",
      "ActiveErpLinks": 458,
      "TicketPriorityId": 718,
      "SupportLanguageId": 854,
      "SupportAssociateId": 185,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": true,
  "Kananame": "temporibus",
  "Xstop": true,
  "ActiveInterests": 644,
  "GroupId": 328,
  "ActiveStatusMonitorId": 265,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 767,
  "DbiAgentId": 554,
  "DbiLastSyncronized": "2007-11-09T14:19:10.1779741+01:00",
  "DbiKey": "explicabo",
  "DbiLastModified": "2001-12-20T14:19:10.1779741+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 399,
  "ActiveErpLinks": 616,
  "BounceEmails": [
    "amir_greenfelder@kertzmann.ca",
    "rossie@bailey.uk"
  ],
  "Domains": [
    "ut",
    "dolorem"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Mr. Howard Schiller",
    "SuperOffice:2": "Antonio Kunze I"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "adipisci"
  },
  "CustomFields": {
    "CustomFields1": "quia",
    "CustomFields2": "accusamus"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 359,
  "Name": "Greenholt-Lemke",
  "Department": "",
  "OrgNr": "1354809",
  "Number1": "59014",
  "Number2": "367144",
  "UpdatedDate": "2022-07-06T14:19:10.1935974+02:00",
  "CreatedDate": "2010-01-10T14:19:10.1935974+01:00",
  "Emails": [
    {
      "Value": "minus",
      "StrippedValue": "at",
      "Description": "Total high-level middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 189
        }
      }
    },
    {
      "Value": "minus",
      "StrippedValue": "at",
      "Description": "Total high-level middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 189
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 777,
      "Name": "Glover-Baumbach",
      "ToolTip": "Nisi error quod veniam quasi numquam.",
      "Deleted": false,
      "Rank": 361,
      "Type": "quae",
      "ColorBlock": 563,
      "IconHint": "numquam",
      "Selected": false,
      "LastChanged": "2015-06-27T14:19:10.1935974+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quaerat",
      "StyleHint": "voluptatem",
      "Hidden": false,
      "FullName": "Mrs. Amos Damion Kassulke",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 227
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "voluptatem",
      "StrippedValue": "aut",
      "Description": "Function-based bottom-line open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 483
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "aut",
      "Description": "Function-based bottom-line open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 483
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "totam",
      "StrippedValue": "dolore",
      "Description": "User-friendly full-range service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 958
        }
      }
    },
    {
      "Value": "totam",
      "StrippedValue": "dolore",
      "Description": "User-friendly full-range service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 958
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "eos",
      "StrippedValue": "dolores",
      "Description": "Enterprise-wide well-modulated leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 816
        }
      }
    },
    {
      "Value": "eos",
      "StrippedValue": "dolores",
      "Description": "Enterprise-wide well-modulated leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 816
        }
      }
    }
  ],
  "Description": "Adaptive system-worthy help-desk",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "soluta",
      "PersonId": 592,
      "Mrmrs": "cupiditate",
      "Firstname": "Ulises",
      "Lastname": "Stamm",
      "MiddleName": "Okuneva-Emmerich",
      "Title": "nam",
      "Description": "Persevering systemic data-warehouse",
      "Email": "braulio_stiedemann@blockullrich.name",
      "FullName": "Chesley Keeling",
      "DirectPhone": "(829)489-7705",
      "FormalName": "Jones, Botsford and Schmidt",
      "CountryId": 270,
      "ContactId": 874,
      "ContactName": "Harber-Aufderhar",
      "Retired": 224,
      "Rank": 627,
      "ActiveInterests": 317,
      "ContactDepartment": "",
      "ContactCountryId": 130,
      "ContactOrgNr": "1430416",
      "FaxPhone": "243.944.8196",
      "MobilePhone": "710.750.9471 x656",
      "ContactPhone": "1-863-016-8243",
      "AssociateName": "Aufderhar LLC",
      "AssociateId": 617,
      "UsePersonAddress": true,
      "ContactFax": "ipsam",
      "Kanafname": "enim",
      "Kanalname": "commodi",
      "Post1": "dignissimos",
      "Post2": "possimus",
      "Post3": "provident",
      "EmailName": "callie@colekreiger.us",
      "ContactFullName": "Mr. Kaycee Mason Jones",
      "ActiveErpLinks": 537,
      "TicketPriorityId": 868,
      "SupportLanguageId": 203,
      "SupportAssociateId": 564,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 565
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "aut",
  "Xstop": false,
  "ActiveInterests": 968,
  "GroupId": 605,
  "ActiveStatusMonitorId": 837,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 388,
  "DbiAgentId": 588,
  "DbiLastSyncronized": "2022-07-21T14:19:10.1935974+02:00",
  "DbiKey": "nihil",
  "DbiLastModified": "1998-05-14T14:19:10.1935974+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 882,
  "ActiveErpLinks": 962,
  "BounceEmails": [
    "brady.zieme@blick.name",
    "lucie_morissette@hahn.uk"
  ],
  "Domains": [
    "qui",
    "aspernatur"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Paige Koss"
  },
  "ExtraFields": {
    "ExtraFields1": "vel",
    "ExtraFields2": "qui"
  },
  "CustomFields": {
    "CustomFields1": "molestiae",
    "CustomFields2": "reprehenderit"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 853
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```