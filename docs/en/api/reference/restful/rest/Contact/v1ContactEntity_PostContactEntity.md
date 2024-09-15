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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 816,
  "Name": "Gaylord Inc and Sons",
  "Department": "",
  "OrgNr": "598647",
  "Number1": "1410310",
  "Number2": "1283628",
  "UpdatedDate": "2002-05-04T04:02:06.384293+02:00",
  "CreatedDate": "2009-02-01T04:02:06.384293+01:00",
  "Emails": [
    {
      "Value": "recusandae",
      "StrippedValue": "voluptate",
      "Description": "Synergistic leading edge initiative"
    },
    {
      "Value": "recusandae",
      "StrippedValue": "voluptate",
      "Description": "Synergistic leading edge initiative"
    }
  ],
  "Interests": [
    {
      "Id": 539,
      "Name": "Wintheiser, Runolfsdottir and Hammes",
      "ToolTip": "Ex sit.",
      "Deleted": true,
      "Rank": 65,
      "Type": "officia",
      "ColorBlock": 969,
      "IconHint": "aut",
      "Selected": false,
      "LastChanged": "2016-09-28T04:02:06.384293+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nihil",
      "StyleHint": "quis",
      "Hidden": true,
      "FullName": "Shanna Mohr"
    }
  ],
  "Urls": [
    {
      "Value": "eius",
      "StrippedValue": "similique",
      "Description": "Vision-oriented local focus group"
    },
    {
      "Value": "eius",
      "StrippedValue": "similique",
      "Description": "Vision-oriented local focus group"
    }
  ],
  "Phones": [
    {
      "Value": "delectus",
      "StrippedValue": "dicta",
      "Description": "Open-source scalable emulation"
    },
    {
      "Value": "delectus",
      "StrippedValue": "dicta",
      "Description": "Open-source scalable emulation"
    }
  ],
  "Faxes": [
    {
      "Value": "ratione",
      "StrippedValue": "minus",
      "Description": "Realigned foreground matrix"
    },
    {
      "Value": "ratione",
      "StrippedValue": "minus",
      "Description": "Realigned foreground matrix"
    }
  ],
  "Description": "Assimilated composite methodology",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "veniam",
      "PersonId": 72,
      "Mrmrs": "aut",
      "Firstname": "Orland",
      "Lastname": "Leuschke",
      "MiddleName": "McKenzie Inc and Sons",
      "Title": "beatae",
      "Description": "Polarised multi-tasking neural-net",
      "Email": "cicero@yundtcummings.ca",
      "FullName": "Eddie Schumm DDS",
      "DirectPhone": "1-492-693-8047 x03497",
      "FormalName": "Stamm, Bogan and Johnson",
      "CountryId": 461,
      "ContactId": 389,
      "ContactName": "Legros Inc and Sons",
      "Retired": 470,
      "Rank": 587,
      "ActiveInterests": 523,
      "ContactDepartment": "",
      "ContactCountryId": 919,
      "ContactOrgNr": "898791",
      "FaxPhone": "1-181-920-1324 x9416",
      "MobilePhone": "414-232-8934 x99919",
      "ContactPhone": "575-091-9424 x782",
      "AssociateName": "Ledner-Purdy",
      "AssociateId": 135,
      "UsePersonAddress": true,
      "ContactFax": "id",
      "Kanafname": "doloremque",
      "Kanalname": "omnis",
      "Post1": "rerum",
      "Post2": "eum",
      "Post3": "suscipit",
      "EmailName": "edna@hirthe.name",
      "ContactFullName": "Sanford Ritchie",
      "ActiveErpLinks": 976,
      "TicketPriorityId": 719,
      "SupportLanguageId": 727,
      "SupportAssociateId": 847,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "excepturi",
  "Xstop": true,
  "ActiveInterests": 744,
  "GroupId": 630,
  "ActiveStatusMonitorId": 972,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 284,
  "DbiAgentId": 791,
  "DbiLastSyncronized": "2019-02-23T04:02:06.384293+01:00",
  "DbiKey": "sapiente",
  "DbiLastModified": "2009-08-26T04:02:06.384293+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 362,
  "ActiveErpLinks": 488,
  "BounceEmails": [
    "philip@kutchlang.biz",
    "maritza.koelpin@schinner.uk"
  ],
  "Domains": [
    "assumenda",
    "eum"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Pansy Hyatt",
    "SuperOffice:2": "Evelyn Price"
  },
  "ExtraFields": {
    "ExtraFields1": "ea",
    "ExtraFields2": "hic"
  },
  "CustomFields": {
    "CustomFields1": "consectetur",
    "CustomFields2": "ipsum"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 141,
  "Name": "Harvey, Langworth and Veum",
  "Department": "",
  "OrgNr": "485152",
  "Number1": "1085684",
  "Number2": "423959",
  "UpdatedDate": "2002-06-21T04:02:06.384293+02:00",
  "CreatedDate": "2011-09-27T04:02:06.384293+02:00",
  "Emails": [
    {
      "Value": "laudantium",
      "StrippedValue": "inventore",
      "Description": "Synergized assymetric monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 953
        }
      }
    },
    {
      "Value": "laudantium",
      "StrippedValue": "inventore",
      "Description": "Synergized assymetric monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 953
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 49,
      "Name": "Cruickshank Inc and Sons",
      "ToolTip": "Consequatur est adipisci.",
      "Deleted": false,
      "Rank": 145,
      "Type": "laudantium",
      "ColorBlock": 83,
      "IconHint": "est",
      "Selected": true,
      "LastChanged": "2013-12-09T04:02:06.384293+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "quasi",
      "Hidden": false,
      "FullName": "Gladyce Toy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 450
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "et",
      "StrippedValue": "iste",
      "Description": "Compatible assymetric standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 319
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "iste",
      "Description": "Compatible assymetric standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 319
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "nam",
      "StrippedValue": "natus",
      "Description": "Devolved motivating policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 13
        }
      }
    },
    {
      "Value": "nam",
      "StrippedValue": "natus",
      "Description": "Devolved motivating policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 13
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "veniam",
      "StrippedValue": "nihil",
      "Description": "Automated mission-critical strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 148
        }
      }
    },
    {
      "Value": "veniam",
      "StrippedValue": "nihil",
      "Description": "Automated mission-critical strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 148
        }
      }
    }
  ],
  "Description": "Mandatory real-time utilisation",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "occaecati",
      "PersonId": 858,
      "Mrmrs": "reprehenderit",
      "Firstname": "Jolie",
      "Lastname": "Keebler",
      "MiddleName": "Kassulke, Shanahan and Roob",
      "Title": "ea",
      "Description": "Operative exuding functionalities",
      "Email": "gaylord.will@fadel.biz",
      "FullName": "Kacie Hirthe II",
      "DirectPhone": "705.156.7160 x24794",
      "FormalName": "Ward, Crist and Corwin",
      "CountryId": 200,
      "ContactId": 200,
      "ContactName": "Mohr Group",
      "Retired": 434,
      "Rank": 668,
      "ActiveInterests": 521,
      "ContactDepartment": "",
      "ContactCountryId": 451,
      "ContactOrgNr": "535369",
      "FaxPhone": "1-297-295-6853 x36044",
      "MobilePhone": "(901)744-2685 x675",
      "ContactPhone": "692-247-1488 x16873",
      "AssociateName": "Rath-Gutkowski",
      "AssociateId": 873,
      "UsePersonAddress": true,
      "ContactFax": "numquam",
      "Kanafname": "eos",
      "Kanalname": "in",
      "Post1": "at",
      "Post2": "provident",
      "Post3": "voluptatem",
      "EmailName": "judd.goyette@howell.ca",
      "ContactFullName": "Brain Swift",
      "ActiveErpLinks": 261,
      "TicketPriorityId": 19,
      "SupportLanguageId": 651,
      "SupportAssociateId": 829,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 257
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "quos",
  "Xstop": false,
  "ActiveInterests": 528,
  "GroupId": 663,
  "ActiveStatusMonitorId": 228,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 822,
  "DbiAgentId": 59,
  "DbiLastSyncronized": "2011-01-16T04:02:06.384293+01:00",
  "DbiKey": "dolor",
  "DbiLastModified": "2008-05-31T04:02:06.384293+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 858,
  "ActiveErpLinks": 262,
  "BounceEmails": [
    "justen_pacocha@torpklocko.info",
    "kayden@morissette.co.uk"
  ],
  "Domains": [
    "quas",
    "ab"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Prof. Quinn Green Ortiz"
  },
  "ExtraFields": {
    "ExtraFields1": "numquam",
    "ExtraFields2": "nostrum"
  },
  "CustomFields": {
    "CustomFields1": "non",
    "CustomFields2": "harum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 847
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```