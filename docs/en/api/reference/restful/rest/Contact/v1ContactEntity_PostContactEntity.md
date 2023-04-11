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
  "ContactId": 972,
  "Name": "Beer-Eichmann",
  "Department": "",
  "OrgNr": "1330092",
  "Number1": "342104",
  "Number2": "1324260",
  "UpdatedDate": "2010-08-24T15:29:29.4892025+02:00",
  "CreatedDate": "1997-05-29T15:29:29.4892025+02:00",
  "Emails": [
    {
      "Value": "quisquam",
      "StrippedValue": "nesciunt",
      "Description": "Reverse-engineered discrete strategy"
    },
    {
      "Value": "quisquam",
      "StrippedValue": "nesciunt",
      "Description": "Reverse-engineered discrete strategy"
    }
  ],
  "Interests": [
    {
      "Id": 507,
      "Name": "Grady, Doyle and Walsh",
      "ToolTip": "Veritatis dolores repellat.",
      "Deleted": true,
      "Rank": 18,
      "Type": "ut",
      "ColorBlock": 996,
      "IconHint": "dolores",
      "Selected": true,
      "LastChanged": "2016-02-28T15:29:29.4892025+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "illum",
      "StyleHint": "ipsam",
      "Hidden": false,
      "FullName": "Prof. Isidro Larkin I"
    }
  ],
  "Urls": [
    {
      "Value": "atque",
      "StrippedValue": "adipisci",
      "Description": "Robust impactful policy"
    },
    {
      "Value": "atque",
      "StrippedValue": "adipisci",
      "Description": "Robust impactful policy"
    }
  ],
  "Phones": [
    {
      "Value": "ut",
      "StrippedValue": "numquam",
      "Description": "Grass-roots zero defect paradigm"
    },
    {
      "Value": "ut",
      "StrippedValue": "numquam",
      "Description": "Grass-roots zero defect paradigm"
    }
  ],
  "Faxes": [
    {
      "Value": "voluptatem",
      "StrippedValue": "dolores",
      "Description": "Versatile encompassing matrix"
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "dolores",
      "Description": "Versatile encompassing matrix"
    }
  ],
  "Description": "Networked multi-tasking capability",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "commodi",
      "PersonId": 751,
      "Mrmrs": "occaecati",
      "Firstname": "Kareem",
      "Lastname": "Schaden",
      "MiddleName": "Dickens-Smitham",
      "Title": "aliquam",
      "Description": "Reduced optimal workforce",
      "Email": "caden.anderson@oreilly.com",
      "FullName": "Davion Schaefer",
      "DirectPhone": "538-115-4237",
      "FormalName": "Mills, Weber and Dicki",
      "CountryId": 369,
      "ContactId": 374,
      "ContactName": "Pfeffer LLC",
      "Retired": 175,
      "Rank": 690,
      "ActiveInterests": 379,
      "ContactDepartment": "",
      "ContactCountryId": 882,
      "ContactOrgNr": "1109047",
      "FaxPhone": "863.456.7928 x2462",
      "MobilePhone": "487.697.6382",
      "ContactPhone": "826.050.0495 x99090",
      "AssociateName": "Ward, Mante and Emmerich",
      "AssociateId": 811,
      "UsePersonAddress": false,
      "ContactFax": "recusandae",
      "Kanafname": "eum",
      "Kanalname": "minus",
      "Post1": "aut",
      "Post2": "est",
      "Post3": "ducimus",
      "EmailName": "angie@yost.co.uk",
      "ContactFullName": "Prof. Whitney Rosenbaum III",
      "ActiveErpLinks": 250,
      "TicketPriorityId": 283,
      "SupportLanguageId": 355,
      "SupportAssociateId": 930,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "quia",
  "Xstop": false,
  "ActiveInterests": 476,
  "GroupId": 20,
  "ActiveStatusMonitorId": 184,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 846,
  "DbiAgentId": 497,
  "DbiLastSyncronized": "2016-07-27T15:29:29.4937027+02:00",
  "DbiKey": "ea",
  "DbiLastModified": "2020-07-10T15:29:29.4942006+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 302,
  "ActiveErpLinks": 87,
  "BounceEmails": [
    "araceli_skiles@fay.name",
    "sid@murazik.info"
  ],
  "Domains": [
    "et",
    "et"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1759275330",
    "SuperOffice:2": "Taya Koepp"
  },
  "ExtraFields": {
    "ExtraFields1": "nesciunt",
    "ExtraFields2": "voluptas"
  },
  "CustomFields": {
    "CustomFields1": "vitae",
    "CustomFields2": "at"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 460,
  "Name": "Hermann-Lueilwitz",
  "Department": "",
  "OrgNr": "690978",
  "Number1": "325297",
  "Number2": "1103272",
  "UpdatedDate": "2000-05-20T15:29:29.5047023+02:00",
  "CreatedDate": "2000-01-13T15:29:29.5047023+01:00",
  "Emails": [
    {
      "Value": "eaque",
      "StrippedValue": "laudantium",
      "Description": "Visionary zero tolerance migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 823
        }
      }
    },
    {
      "Value": "eaque",
      "StrippedValue": "laudantium",
      "Description": "Visionary zero tolerance migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 823
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 84,
      "Name": "Dietrich-Beahan",
      "ToolTip": "Recusandae sed sit.",
      "Deleted": true,
      "Rank": 638,
      "Type": "quas",
      "ColorBlock": 50,
      "IconHint": "temporibus",
      "Selected": false,
      "LastChanged": "2018-08-31T15:29:29.5047023+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "vero",
      "StyleHint": "officia",
      "Hidden": false,
      "FullName": "Lavern Reilly",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 959
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "enim",
      "StrippedValue": "reprehenderit",
      "Description": "Public-key homogeneous toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 747
        }
      }
    },
    {
      "Value": "enim",
      "StrippedValue": "reprehenderit",
      "Description": "Public-key homogeneous toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 747
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "exercitationem",
      "StrippedValue": "harum",
      "Description": "Networked bifurcated strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 535
        }
      }
    },
    {
      "Value": "exercitationem",
      "StrippedValue": "harum",
      "Description": "Networked bifurcated strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 535
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quae",
      "StrippedValue": "velit",
      "Description": "Balanced background system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 377
        }
      }
    },
    {
      "Value": "quae",
      "StrippedValue": "velit",
      "Description": "Balanced background system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 377
        }
      }
    }
  ],
  "Description": "Vision-oriented discrete standardization",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "aut",
      "PersonId": 412,
      "Mrmrs": "qui",
      "Firstname": "Karlie",
      "Lastname": "Cormier",
      "MiddleName": "Christiansen Group",
      "Title": "magnam",
      "Description": "Multi-layered 24/7 infrastructure",
      "Email": "anabelle@cartwright.uk",
      "FullName": "Terrance Beahan",
      "DirectPhone": "723-994-4910",
      "FormalName": "Weimann-Stokes",
      "CountryId": 813,
      "ContactId": 687,
      "ContactName": "Hickle LLC",
      "Retired": 731,
      "Rank": 488,
      "ActiveInterests": 103,
      "ContactDepartment": "",
      "ContactCountryId": 493,
      "ContactOrgNr": "1029668",
      "FaxPhone": "814-364-2234 x30319",
      "MobilePhone": "176.931.1214 x1468",
      "ContactPhone": "(742)106-2888 x271",
      "AssociateName": "McDermott-Tillman",
      "AssociateId": 446,
      "UsePersonAddress": false,
      "ContactFax": "voluptatem",
      "Kanafname": "reiciendis",
      "Kanalname": "molestias",
      "Post1": "quas",
      "Post2": "nam",
      "Post3": "iusto",
      "EmailName": "erich@bednar.name",
      "ContactFullName": "Darien Rice",
      "ActiveErpLinks": 178,
      "TicketPriorityId": 35,
      "SupportLanguageId": 825,
      "SupportAssociateId": 314,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 236
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "quidem",
  "Xstop": false,
  "ActiveInterests": 404,
  "GroupId": 17,
  "ActiveStatusMonitorId": 151,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 873,
  "DbiAgentId": 383,
  "DbiLastSyncronized": "2011-01-19T15:29:29.5092027+01:00",
  "DbiKey": "aut",
  "DbiLastModified": "2007-09-21T15:29:29.5092027+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 440,
  "ActiveErpLinks": 705,
  "BounceEmails": [
    "noah.lehner@stracke.biz",
    "deshawn@baileytorphy.co.uk"
  ],
  "Domains": [
    "exercitationem",
    "minus"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "202229163",
    "SuperOffice:2": "Nico Wunsch"
  },
  "ExtraFields": {
    "ExtraFields1": "possimus",
    "ExtraFields2": "quidem"
  },
  "CustomFields": {
    "CustomFields1": "autem",
    "CustomFields2": "earum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 167
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```