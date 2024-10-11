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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactId": 152,
  "Name": "Hahn-Bechtelar",
  "Department": "",
  "OrgNr": "445693",
  "Number1": "1096801",
  "Number2": "814310",
  "UpdatedDate": "2024-03-14T03:44:57.1246527+01:00",
  "CreatedDate": "2018-01-12T03:44:57.1246527+01:00",
  "Emails": [
    {
      "Value": "autem",
      "StrippedValue": "reiciendis",
      "Description": "Synchronised modular time-frame"
    },
    {
      "Value": "autem",
      "StrippedValue": "reiciendis",
      "Description": "Synchronised modular time-frame"
    }
  ],
  "Interests": [
    {
      "Id": 902,
      "Name": "Ledner-Mertz",
      "ToolTip": "Doloremque sed dolor officiis pariatur velit.",
      "Deleted": true,
      "Rank": 376,
      "Type": "id",
      "ColorBlock": 254,
      "IconHint": "molestiae",
      "Selected": false,
      "LastChanged": "2011-09-03T03:44:57.1246527+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "illum",
      "StyleHint": "doloribus",
      "Hidden": false,
      "FullName": "Marco Lubowitz"
    }
  ],
  "Urls": [
    {
      "Value": "reiciendis",
      "StrippedValue": "aut",
      "Description": "Operative bifurcated framework"
    },
    {
      "Value": "reiciendis",
      "StrippedValue": "aut",
      "Description": "Operative bifurcated framework"
    }
  ],
  "Phones": [
    {
      "Value": "animi",
      "StrippedValue": "numquam",
      "Description": "Monitored client-driven open architecture"
    },
    {
      "Value": "animi",
      "StrippedValue": "numquam",
      "Description": "Monitored client-driven open architecture"
    }
  ],
  "Faxes": [
    {
      "Value": "reprehenderit",
      "StrippedValue": "nulla",
      "Description": "Right-sized explicit solution"
    },
    {
      "Value": "reprehenderit",
      "StrippedValue": "nulla",
      "Description": "Right-sized explicit solution"
    }
  ],
  "Description": "Vision-oriented eco-centric product",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "sunt",
      "PersonId": 314,
      "Mrmrs": "architecto",
      "Firstname": "Junior",
      "Lastname": "Okuneva",
      "MiddleName": "O'Connell, Sanford and Wolff",
      "Title": "architecto",
      "Description": "Balanced background throughput",
      "Email": "rebekah_langworth@kuhicnader.biz",
      "FullName": "Anika Thiel",
      "DirectPhone": "055-718-2511 x2355",
      "FormalName": "Lakin Inc and Sons",
      "CountryId": 690,
      "ContactId": 815,
      "ContactName": "Reinger, Hermiston and Pagac",
      "Retired": 302,
      "Rank": 650,
      "ActiveInterests": 270,
      "ContactDepartment": "",
      "ContactCountryId": 536,
      "ContactOrgNr": "968719",
      "FaxPhone": "087-753-3456 x507",
      "MobilePhone": "(046)432-4675",
      "ContactPhone": "357-353-0575 x186",
      "AssociateName": "Wilderman Inc and Sons",
      "AssociateId": 785,
      "UsePersonAddress": false,
      "ContactFax": "et",
      "Kanafname": "incidunt",
      "Kanalname": "non",
      "Post1": "aut",
      "Post2": "eos",
      "Post3": "explicabo",
      "EmailName": "emiliano@farrell.com",
      "ContactFullName": "Eldridge Tromp",
      "ActiveErpLinks": 927,
      "TicketPriorityId": 498,
      "SupportLanguageId": 506,
      "SupportAssociateId": 132,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "expedita",
  "Xstop": false,
  "ActiveInterests": 418,
  "GroupId": 914,
  "ActiveStatusMonitorId": 377,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 899,
  "DbiAgentId": 419,
  "DbiLastSyncronized": "1998-05-08T03:44:57.1246527+02:00",
  "DbiKey": "qui",
  "DbiLastModified": "2022-07-20T03:44:57.1246527+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 391,
  "ActiveErpLinks": 536,
  "BounceEmails": [
    "sabrina@schaefer.com",
    "jovany_legros@steuber.name"
  ],
  "Domains": [
    "asperiores",
    "ut"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "281445215",
    "SuperOffice:2": "Collin Veum"
  },
  "ExtraFields": {
    "ExtraFields1": "dicta",
    "ExtraFields2": "eaque"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "reiciendis"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 242,
  "Name": "Schmitt, Wilderman and Senger",
  "Department": "",
  "OrgNr": "1258090",
  "Number1": "328999",
  "Number2": "747921",
  "UpdatedDate": "2000-03-15T03:44:57.1402759+01:00",
  "CreatedDate": "2010-07-05T03:44:57.1402759+02:00",
  "Emails": [
    {
      "Value": "corrupti",
      "StrippedValue": "quo",
      "Description": "Profound responsive matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 980
        }
      }
    },
    {
      "Value": "corrupti",
      "StrippedValue": "quo",
      "Description": "Profound responsive matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 980
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 298,
      "Name": "Nikolaus-Paucek",
      "ToolTip": "Sit eum libero sint sit est expedita.",
      "Deleted": false,
      "Rank": 115,
      "Type": "quod",
      "ColorBlock": 864,
      "IconHint": "tempore",
      "Selected": false,
      "LastChanged": "2008-05-18T03:44:57.1402759+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ea",
      "StyleHint": "voluptatem",
      "Hidden": true,
      "FullName": "Dr. Maximillian Purdy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 419
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "corrupti",
      "StrippedValue": "alias",
      "Description": "Reduced background knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 982
        }
      }
    },
    {
      "Value": "corrupti",
      "StrippedValue": "alias",
      "Description": "Reduced background knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 982
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "ipsa",
      "StrippedValue": "totam",
      "Description": "Secured logistical workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 805
        }
      }
    },
    {
      "Value": "ipsa",
      "StrippedValue": "totam",
      "Description": "Secured logistical workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 805
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "suscipit",
      "StrippedValue": "voluptatem",
      "Description": "Triple-buffered next generation secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 16
        }
      }
    },
    {
      "Value": "suscipit",
      "StrippedValue": "voluptatem",
      "Description": "Triple-buffered next generation secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 16
        }
      }
    }
  ],
  "Description": "Sharable dynamic workforce",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "dicta",
      "PersonId": 197,
      "Mrmrs": "rerum",
      "Firstname": "Tania",
      "Lastname": "Spinka",
      "MiddleName": "Torphy LLC",
      "Title": "dolorem",
      "Description": "Integrated multi-state support",
      "Email": "audrey_conn@pfannerstill.ca",
      "FullName": "Kenya Kris",
      "DirectPhone": "(436)396-8550 x08177",
      "FormalName": "Klocko LLC",
      "CountryId": 202,
      "ContactId": 289,
      "ContactName": "Spinka, Schiller and Anderson",
      "Retired": 284,
      "Rank": 23,
      "ActiveInterests": 9,
      "ContactDepartment": "",
      "ContactCountryId": 888,
      "ContactOrgNr": "783191",
      "FaxPhone": "217-704-9429 x463",
      "MobilePhone": "524-433-8637",
      "ContactPhone": "045.916.1284 x713",
      "AssociateName": "Reichel LLC",
      "AssociateId": 432,
      "UsePersonAddress": false,
      "ContactFax": "qui",
      "Kanafname": "ullam",
      "Kanalname": "sit",
      "Post1": "corrupti",
      "Post2": "architecto",
      "Post3": "ipsa",
      "EmailName": "bessie@kuvalis.biz",
      "ContactFullName": "Mr. Rickie Hattie Abshire",
      "ActiveErpLinks": 941,
      "TicketPriorityId": 545,
      "SupportLanguageId": 447,
      "SupportAssociateId": 309,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 891
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "eligendi",
  "Xstop": false,
  "ActiveInterests": 124,
  "GroupId": 55,
  "ActiveStatusMonitorId": 126,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 770,
  "DbiAgentId": 394,
  "DbiLastSyncronized": "2012-07-11T03:44:57.1402759+02:00",
  "DbiKey": "adipisci",
  "DbiLastModified": "2019-08-19T03:44:57.1402759+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 443,
  "ActiveErpLinks": 738,
  "BounceEmails": [
    "merritt@herman.com",
    "susan_kozey@ferry.com"
  ],
  "Domains": [
    "temporibus",
    "eaque"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "805981857",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "repudiandae",
    "ExtraFields2": "harum"
  },
  "CustomFields": {
    "CustomFields1": "corrupti",
    "CustomFields2": "velit"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 61
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```