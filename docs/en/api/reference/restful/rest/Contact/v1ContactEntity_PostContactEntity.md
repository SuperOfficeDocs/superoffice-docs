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
  "ContactId": 523,
  "Name": "Schneider Group",
  "Department": "",
  "OrgNr": "254143",
  "Number1": "679631",
  "Number2": "447469",
  "UpdatedDate": "2011-02-05T03:41:58.5742886+01:00",
  "CreatedDate": "2000-02-05T03:41:58.5742886+01:00",
  "Emails": [
    {
      "Value": "omnis",
      "StrippedValue": "quis",
      "Description": "User-friendly zero defect success"
    },
    {
      "Value": "omnis",
      "StrippedValue": "quis",
      "Description": "User-friendly zero defect success"
    }
  ],
  "Interests": [
    {
      "Id": 99,
      "Name": "Moore, Homenick and Donnelly",
      "ToolTip": "Hic accusamus.",
      "Deleted": false,
      "Rank": 163,
      "Type": "veniam",
      "ColorBlock": 119,
      "IconHint": "quasi",
      "Selected": false,
      "LastChanged": "2007-06-05T03:41:58.5742886+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "odio",
      "StyleHint": "qui",
      "Hidden": false,
      "FullName": "Dr. Maeve Shields Sr."
    }
  ],
  "Urls": [
    {
      "Value": "nulla",
      "StrippedValue": "aut",
      "Description": "Digitized motivating intranet"
    },
    {
      "Value": "nulla",
      "StrippedValue": "aut",
      "Description": "Digitized motivating intranet"
    }
  ],
  "Phones": [
    {
      "Value": "architecto",
      "StrippedValue": "molestiae",
      "Description": "Customizable grid-enabled moratorium"
    },
    {
      "Value": "architecto",
      "StrippedValue": "molestiae",
      "Description": "Customizable grid-enabled moratorium"
    }
  ],
  "Faxes": [
    {
      "Value": "aut",
      "StrippedValue": "aut",
      "Description": "Right-sized transitional moratorium"
    },
    {
      "Value": "aut",
      "StrippedValue": "aut",
      "Description": "Right-sized transitional moratorium"
    }
  ],
  "Description": "Polarised system-worthy data-warehouse",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "sint",
      "PersonId": 512,
      "Mrmrs": "commodi",
      "Firstname": "Verlie",
      "Lastname": "Toy",
      "MiddleName": "Oberbrunner, Zboncak and Marks",
      "Title": "aut",
      "Description": "Synergistic content-based superstructure",
      "Email": "jazmyn_lynch@greenholt.ca",
      "FullName": "Sedrick Green",
      "DirectPhone": "(543)387-6251 x97728",
      "FormalName": "Stracke-Hessel",
      "CountryId": 602,
      "ContactId": 531,
      "ContactName": "Lueilwitz, Little and McKenzie",
      "Retired": 392,
      "Rank": 626,
      "ActiveInterests": 672,
      "ContactDepartment": "",
      "ContactCountryId": 130,
      "ContactOrgNr": "1015977",
      "FaxPhone": "512.867.4043 x06697",
      "MobilePhone": "442.006.8527 x25704",
      "ContactPhone": "(100)532-6198 x248",
      "AssociateName": "Hudson-Corwin",
      "AssociateId": 22,
      "UsePersonAddress": false,
      "ContactFax": "nesciunt",
      "Kanafname": "optio",
      "Kanalname": "rerum",
      "Post1": "iure",
      "Post2": "aperiam",
      "Post3": "quam",
      "EmailName": "mavis.stehr@metzwillms.biz",
      "ContactFullName": "Miss Kayla Bert Schaefer II",
      "ActiveErpLinks": 709,
      "TicketPriorityId": 428,
      "SupportLanguageId": 37,
      "SupportAssociateId": 661,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1309235"
    }
  ],
  "NoMailing": false,
  "Kananame": "exercitationem",
  "Xstop": false,
  "ActiveInterests": 53,
  "GroupId": 96,
  "ActiveStatusMonitorId": 864,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 413,
  "DbiAgentId": 579,
  "DbiLastSyncronized": "2018-03-01T03:41:58.5742886+01:00",
  "DbiKey": "beatae",
  "DbiLastModified": "2023-09-15T03:41:58.5742886+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 639,
  "ActiveErpLinks": 987,
  "BounceEmails": [
    "leonora@keelingfeest.ca",
    "fabian_rice@mooreziemann.ca"
  ],
  "Domains": [
    "dicta",
    "laborum"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "1191858161",
    "SuperOffice:2": "1042717747"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "impedit"
  },
  "CustomFields": {
    "CustomFields1": "eaque",
    "CustomFields2": "a"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 423,
  "Name": "Bradtke, Schaden and Hahn",
  "Department": "",
  "OrgNr": "1752838",
  "Number1": "1306010",
  "Number2": "178773",
  "UpdatedDate": "2020-07-01T03:41:58.5742886+02:00",
  "CreatedDate": "2005-06-24T03:41:58.5742886+02:00",
  "Emails": [
    {
      "Value": "alias",
      "StrippedValue": "quo",
      "Description": "Progressive mobile monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 704
        }
      }
    },
    {
      "Value": "alias",
      "StrippedValue": "quo",
      "Description": "Progressive mobile monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 704
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 73,
      "Name": "Monahan, Gerlach and Kunde",
      "ToolTip": "Dolores excepturi et.",
      "Deleted": false,
      "Rank": 416,
      "Type": "aut",
      "ColorBlock": 59,
      "IconHint": "quia",
      "Selected": false,
      "LastChanged": "2008-03-28T03:41:58.5742886+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolorum",
      "StyleHint": "quam",
      "Hidden": false,
      "FullName": "Darion Bernier",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 589
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "velit",
      "StrippedValue": "voluptas",
      "Description": "Intuitive tertiary architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 365
        }
      }
    },
    {
      "Value": "velit",
      "StrippedValue": "voluptas",
      "Description": "Intuitive tertiary architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 365
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "asperiores",
      "StrippedValue": "sit",
      "Description": "Realigned multimedia conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 810
        }
      }
    },
    {
      "Value": "asperiores",
      "StrippedValue": "sit",
      "Description": "Realigned multimedia conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 810
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "sint",
      "StrippedValue": "a",
      "Description": "Sharable next generation task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 601
        }
      }
    },
    {
      "Value": "sint",
      "StrippedValue": "a",
      "Description": "Sharable next generation task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 601
        }
      }
    }
  ],
  "Description": "Expanded demand-driven superstructure",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "nostrum",
      "PersonId": 626,
      "Mrmrs": "quasi",
      "Firstname": "Marshall",
      "Lastname": "Gutkowski",
      "MiddleName": "Mosciski Group",
      "Title": "qui",
      "Description": "Grass-roots didactic migration",
      "Email": "lucius_schaefer@mraz.us",
      "FullName": "Kristian Denesik Jr.",
      "DirectPhone": "1-707-434-4532 x76158",
      "FormalName": "Kohler, Beer and Grimes",
      "CountryId": 300,
      "ContactId": 415,
      "ContactName": "O'Conner, Ernser and Upton",
      "Retired": 704,
      "Rank": 954,
      "ActiveInterests": 43,
      "ContactDepartment": "",
      "ContactCountryId": 221,
      "ContactOrgNr": "738234",
      "FaxPhone": "908.916.6087 x4172",
      "MobilePhone": "455-946-0052 x5595",
      "ContactPhone": "308.271.8841 x285",
      "AssociateName": "Cremin-Hayes",
      "AssociateId": 70,
      "UsePersonAddress": false,
      "ContactFax": "deleniti",
      "Kanafname": "blanditiis",
      "Kanalname": "voluptas",
      "Post1": "eum",
      "Post2": "doloribus",
      "Post3": "quasi",
      "EmailName": "floy.oconner@pollichblock.ca",
      "ContactFullName": "Duane Ryan",
      "ActiveErpLinks": 707,
      "TicketPriorityId": 141,
      "SupportLanguageId": 362,
      "SupportAssociateId": 618,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1702063",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 24
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "nisi",
  "Xstop": true,
  "ActiveInterests": 771,
  "GroupId": 876,
  "ActiveStatusMonitorId": 99,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 595,
  "DbiAgentId": 523,
  "DbiLastSyncronized": "2021-05-09T03:41:58.5742886+02:00",
  "DbiKey": "voluptatibus",
  "DbiLastModified": "2010-12-23T03:41:58.5742886+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 76,
  "ActiveErpLinks": 46,
  "BounceEmails": [
    "deion@feilblanda.co.uk",
    "deven_buckridge@robeltillman.ca"
  ],
  "Domains": [
    "aperiam",
    "veritatis"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Prof. Mylene Demarco Casper"
  },
  "ExtraFields": {
    "ExtraFields1": "velit",
    "ExtraFields2": "quia"
  },
  "CustomFields": {
    "CustomFields1": "aut",
    "CustomFields2": "placeat"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 773
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```