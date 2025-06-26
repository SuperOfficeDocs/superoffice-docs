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
  "ContactId": 830,
  "Name": "Fahey-Larson",
  "Department": "",
  "OrgNr": "1280188",
  "Number1": "512053",
  "Number2": "1068145",
  "UpdatedDate": "2017-06-13T03:45:28.1703207+02:00",
  "CreatedDate": "2000-12-05T03:45:28.1703207+01:00",
  "Emails": [
    {
      "Value": "eius",
      "StrippedValue": "qui",
      "Description": "Reduced transitional circuit"
    },
    {
      "Value": "eius",
      "StrippedValue": "qui",
      "Description": "Reduced transitional circuit"
    }
  ],
  "Interests": [
    {
      "Id": 748,
      "Name": "Casper Inc and Sons",
      "ToolTip": "Doloribus incidunt voluptatem enim illo velit.",
      "Deleted": false,
      "Rank": 440,
      "Type": "tenetur",
      "ColorBlock": 353,
      "IconHint": "soluta",
      "Selected": false,
      "LastChanged": "2016-06-06T03:45:28.1703207+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "labore",
      "StyleHint": "corporis",
      "Hidden": false,
      "FullName": "Verdie Champlin"
    }
  ],
  "Urls": [
    {
      "Value": "eos",
      "StrippedValue": "culpa",
      "Description": "Stand-alone mobile customer loyalty"
    },
    {
      "Value": "eos",
      "StrippedValue": "culpa",
      "Description": "Stand-alone mobile customer loyalty"
    }
  ],
  "Phones": [
    {
      "Value": "inventore",
      "StrippedValue": "quae",
      "Description": "Phased composite middleware"
    },
    {
      "Value": "inventore",
      "StrippedValue": "quae",
      "Description": "Phased composite middleware"
    }
  ],
  "Faxes": [
    {
      "Value": "quod",
      "StrippedValue": "id",
      "Description": "Stand-alone upward-trending project"
    },
    {
      "Value": "quod",
      "StrippedValue": "id",
      "Description": "Stand-alone upward-trending project"
    }
  ],
  "Description": "User-centric zero defect focus group",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "dolores",
      "PersonId": 615,
      "Mrmrs": "consectetur",
      "Firstname": "Gordon",
      "Lastname": "Ruecker",
      "MiddleName": "Hyatt, Jacobson and Howell",
      "Title": "quae",
      "Description": "Enhanced reciprocal matrices",
      "Email": "lane@bins.co.uk",
      "FullName": "Prof. Domenica Cummings PhD",
      "DirectPhone": "346-035-5406",
      "FormalName": "Davis-Friesen",
      "CountryId": 190,
      "ContactId": 547,
      "ContactName": "Spencer, Rowe and Gleason",
      "Retired": 6,
      "Rank": 999,
      "ActiveInterests": 527,
      "ContactDepartment": "",
      "ContactCountryId": 501,
      "ContactOrgNr": "1636516",
      "FaxPhone": "1-534-826-9465 x39066",
      "MobilePhone": "(336)279-6698",
      "ContactPhone": "919.713.7873 x60621",
      "AssociateName": "Beatty-Stark",
      "AssociateId": 260,
      "UsePersonAddress": true,
      "ContactFax": "id",
      "Kanafname": "maxime",
      "Kanalname": "maxime",
      "Post1": "alias",
      "Post2": "in",
      "Post3": "aperiam",
      "EmailName": "madge@nikolaus.info",
      "ContactFullName": "Kaitlin Lehner",
      "ActiveErpLinks": 103,
      "TicketPriorityId": 543,
      "SupportLanguageId": 860,
      "SupportAssociateId": 513,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1222432"
    }
  ],
  "NoMailing": true,
  "Kananame": "deleniti",
  "Xstop": true,
  "ActiveInterests": 799,
  "GroupId": 202,
  "ActiveStatusMonitorId": 151,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 689,
  "DbiAgentId": 112,
  "DbiLastSyncronized": "2016-10-17T03:45:28.1703207+02:00",
  "DbiKey": "adipisci",
  "DbiLastModified": "2010-06-28T03:45:28.1703207+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 9,
  "ActiveErpLinks": 498,
  "BounceEmails": [
    "eladio@harberwindler.ca",
    "libbie@hane.us"
  ],
  "Domains": [
    "placeat",
    "iste"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Miss Reanna O'Hara",
    "SuperOffice:2": "Fredrick Rice"
  },
  "ExtraFields": {
    "ExtraFields1": "molestias",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "pariatur",
    "CustomFields2": "aut"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 360,
  "Name": "Trantow-Oberbrunner",
  "Department": "",
  "OrgNr": "1284969",
  "Number1": "299875",
  "Number2": "1007577",
  "UpdatedDate": "1998-08-30T03:45:28.1859455+02:00",
  "CreatedDate": "2016-11-04T03:45:28.1859455+01:00",
  "Emails": [
    {
      "Value": "nam",
      "StrippedValue": "sunt",
      "Description": "Expanded dedicated solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 769
        }
      }
    },
    {
      "Value": "nam",
      "StrippedValue": "sunt",
      "Description": "Expanded dedicated solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 769
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 629,
      "Name": "Nitzsche, Zemlak and Carroll",
      "ToolTip": "Hic aperiam rerum id sed.",
      "Deleted": false,
      "Rank": 524,
      "Type": "non",
      "ColorBlock": 184,
      "IconHint": "molestias",
      "Selected": true,
      "LastChanged": "2009-11-08T03:45:28.1859455+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "autem",
      "StyleHint": "sapiente",
      "Hidden": false,
      "FullName": "Vance Schroeder",
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
  "Urls": [
    {
      "Value": "et",
      "StrippedValue": "ut",
      "Description": "Synergized human-resource pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 158
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "ut",
      "Description": "Synergized human-resource pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 158
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "reprehenderit",
      "StrippedValue": "iure",
      "Description": "Customer-focused non-volatile installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 766
        }
      }
    },
    {
      "Value": "reprehenderit",
      "StrippedValue": "iure",
      "Description": "Customer-focused non-volatile installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 766
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "eaque",
      "StrippedValue": "esse",
      "Description": "Monitored heuristic circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 814
        }
      }
    },
    {
      "Value": "eaque",
      "StrippedValue": "esse",
      "Description": "Monitored heuristic circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 814
        }
      }
    }
  ],
  "Description": "Diverse fault-tolerant approach",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ut",
      "PersonId": 284,
      "Mrmrs": "tenetur",
      "Firstname": "Tressa",
      "Lastname": "Bernier",
      "MiddleName": "Spinka, Wisozk and Jerde",
      "Title": "est",
      "Description": "Compatible needs-based emulation",
      "Email": "nyah@runolfsson.biz",
      "FullName": "Prof. Ervin Orlo Schmeler",
      "DirectPhone": "(136)437-4685 x94782",
      "FormalName": "Ondricka Inc and Sons",
      "CountryId": 632,
      "ContactId": 683,
      "ContactName": "Orn, Torp and Stracke",
      "Retired": 135,
      "Rank": 897,
      "ActiveInterests": 326,
      "ContactDepartment": "",
      "ContactCountryId": 733,
      "ContactOrgNr": "814985",
      "FaxPhone": "1-366-059-7069 x505",
      "MobilePhone": "(192)220-7020 x739",
      "ContactPhone": "(979)612-0170 x173",
      "AssociateName": "Windler LLC",
      "AssociateId": 619,
      "UsePersonAddress": true,
      "ContactFax": "illo",
      "Kanafname": "ut",
      "Kanalname": "amet",
      "Post1": "qui",
      "Post2": "dolore",
      "Post3": "eaque",
      "EmailName": "davonte@metz.info",
      "ContactFullName": "Dr. Meagan Lockman",
      "ActiveErpLinks": 282,
      "TicketPriorityId": 704,
      "SupportLanguageId": 708,
      "SupportAssociateId": 164,
      "CategoryName": "VIP Customer",
      "PersonNumber": "420249",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 198
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "et",
  "Xstop": true,
  "ActiveInterests": 66,
  "GroupId": 584,
  "ActiveStatusMonitorId": 11,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 360,
  "DbiAgentId": 332,
  "DbiLastSyncronized": "2019-05-20T03:45:28.1859455+02:00",
  "DbiKey": "consequuntur",
  "DbiLastModified": "2008-04-08T03:45:28.1859455+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 961,
  "ActiveErpLinks": 183,
  "BounceEmails": [
    "dillan@waelchiwitting.ca",
    "coy_crist@christiansen.name"
  ],
  "Domains": [
    "sed",
    "ratione"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1990342206",
    "SuperOffice:2": "Milton Will"
  },
  "ExtraFields": {
    "ExtraFields1": "reiciendis",
    "ExtraFields2": "eaque"
  },
  "CustomFields": {
    "CustomFields1": "ab",
    "CustomFields2": "qui"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 687
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```