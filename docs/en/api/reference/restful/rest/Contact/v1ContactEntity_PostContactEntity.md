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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 873,
  "Name": "Schmeler, Willms and Mante",
  "Department": "",
  "OrgNr": "963448",
  "Number1": "571025",
  "Number2": "1081851",
  "UpdatedDate": "2017-03-22T16:32:47.2902636+01:00",
  "CreatedDate": "2015-04-04T16:32:47.2902636+02:00",
  "Emails": [
    {
      "Value": "velit",
      "StrippedValue": "aut",
      "Description": "Open-architected upward-trending policy"
    },
    {
      "Value": "velit",
      "StrippedValue": "aut",
      "Description": "Open-architected upward-trending policy"
    }
  ],
  "Interests": [
    {
      "Id": 860,
      "Name": "Grimes, Reichert and Homenick",
      "ToolTip": "Hic id aliquam omnis fuga.",
      "Deleted": false,
      "Rank": 149,
      "Type": "illo",
      "ColorBlock": 604,
      "IconHint": "reprehenderit",
      "Selected": false,
      "LastChanged": "2018-03-08T16:32:47.2902636+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aperiam",
      "StyleHint": "exercitationem",
      "Hidden": false,
      "FullName": "Doris Greenholt"
    }
  ],
  "Urls": [
    {
      "Value": "aut",
      "StrippedValue": "sequi",
      "Description": "Reduced zero administration moderator"
    },
    {
      "Value": "aut",
      "StrippedValue": "sequi",
      "Description": "Reduced zero administration moderator"
    }
  ],
  "Phones": [
    {
      "Value": "qui",
      "StrippedValue": "odit",
      "Description": "Multi-tiered mobile neural-net"
    },
    {
      "Value": "qui",
      "StrippedValue": "odit",
      "Description": "Multi-tiered mobile neural-net"
    }
  ],
  "Faxes": [
    {
      "Value": "placeat",
      "StrippedValue": "et",
      "Description": "Versatile composite projection"
    },
    {
      "Value": "placeat",
      "StrippedValue": "et",
      "Description": "Versatile composite projection"
    }
  ],
  "Description": "Cross-platform discrete database",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "optio",
      "PersonId": 472,
      "Mrmrs": "ut",
      "Firstname": "Darby",
      "Lastname": "Kunde",
      "MiddleName": "Wiza-Wiegand",
      "Title": "unde",
      "Description": "Function-based scalable toolset",
      "Email": "madaline@sporer.co.uk",
      "FullName": "Alta Kulas",
      "DirectPhone": "113.686.1240 x404",
      "FormalName": "Bogisich-Leffler",
      "CountryId": 892,
      "ContactId": 405,
      "ContactName": "Feest Inc and Sons",
      "Retired": 140,
      "Rank": 692,
      "ActiveInterests": 389,
      "ContactDepartment": "",
      "ContactCountryId": 879,
      "ContactOrgNr": "117213",
      "FaxPhone": "378-890-5901 x7840",
      "MobilePhone": "241-817-4417 x700",
      "ContactPhone": "818.957.3857 x2837",
      "AssociateName": "Lemke Inc and Sons",
      "AssociateId": 880,
      "UsePersonAddress": true,
      "ContactFax": "cum",
      "Kanafname": "et",
      "Kanalname": "et",
      "Post1": "quasi",
      "Post2": "tempora",
      "Post3": "et",
      "EmailName": "lawson@handmarvin.com",
      "ContactFullName": "Friedrich Mueller",
      "ActiveErpLinks": 519,
      "TicketPriorityId": 807,
      "SupportLanguageId": 827,
      "SupportAssociateId": 662,
      "CategoryName": "VIP Customer",
      "PersonNumber": "177649"
    }
  ],
  "NoMailing": false,
  "Kananame": "quaerat",
  "Xstop": false,
  "ActiveInterests": 1001,
  "GroupId": 34,
  "ActiveStatusMonitorId": 146,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 716,
  "DbiAgentId": 757,
  "DbiLastSyncronized": "1999-05-12T16:32:47.3058822+02:00",
  "DbiKey": "rerum",
  "DbiLastModified": "2002-10-09T16:32:47.3058822+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 528,
  "ActiveErpLinks": 684,
  "BounceEmails": [
    "laron_larson@rice.com",
    "haley.wuckert@hirtheweissnat.us"
  ],
  "Domains": [
    "sunt",
    "mollitia"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "723139479",
    "SuperOffice:2": "Mavis Grimes"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptatem",
    "ExtraFields2": "quae"
  },
  "CustomFields": {
    "CustomFields1": "eum",
    "CustomFields2": "architecto"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 426,
  "Name": "Monahan, Ritchie and Kozey",
  "Department": "",
  "OrgNr": "1466698",
  "Number1": "810089",
  "Number2": "1400772",
  "UpdatedDate": "2018-02-25T16:32:47.3058822+01:00",
  "CreatedDate": "1999-02-08T16:32:47.3058822+01:00",
  "Emails": [
    {
      "Value": "recusandae",
      "StrippedValue": "qui",
      "Description": "Switchable logistical focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 985
        }
      }
    },
    {
      "Value": "recusandae",
      "StrippedValue": "qui",
      "Description": "Switchable logistical focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 985
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 242,
      "Name": "Gutmann-Schoen",
      "ToolTip": "Quibusdam natus.",
      "Deleted": false,
      "Rank": 395,
      "Type": "dolor",
      "ColorBlock": 231,
      "IconHint": "reprehenderit",
      "Selected": true,
      "LastChanged": "2004-01-01T16:32:47.3058822+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptate",
      "StyleHint": "est",
      "Hidden": false,
      "FullName": "Leola Collier",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 961
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "quia",
      "StrippedValue": "quia",
      "Description": "Business-focused modular knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 850
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "quia",
      "Description": "Business-focused modular knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 850
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "quia",
      "StrippedValue": "vero",
      "Description": "Focused clear-thinking complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 676
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "vero",
      "Description": "Focused clear-thinking complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 676
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "dolorem",
      "StrippedValue": "nisi",
      "Description": "Exclusive radical policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 606
        }
      }
    },
    {
      "Value": "dolorem",
      "StrippedValue": "nisi",
      "Description": "Exclusive radical policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 606
        }
      }
    }
  ],
  "Description": "User-centric zero defect approach",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "architecto",
      "PersonId": 12,
      "Mrmrs": "quibusdam",
      "Firstname": "Shaina",
      "Lastname": "Gerhold",
      "MiddleName": "Casper-Glover",
      "Title": "fugit",
      "Description": "Down-sized incremental pricing structure",
      "Email": "stuart.zieme@hudson.name",
      "FullName": "Ali McCullough",
      "DirectPhone": "193.995.8862",
      "FormalName": "Kuhlman-O'Hara",
      "CountryId": 27,
      "ContactId": 477,
      "ContactName": "Fadel, Beahan and Huel",
      "Retired": 645,
      "Rank": 539,
      "ActiveInterests": 917,
      "ContactDepartment": "",
      "ContactCountryId": 758,
      "ContactOrgNr": "296703",
      "FaxPhone": "1-389-478-4140 x779",
      "MobilePhone": "1-883-839-2513 x89506",
      "ContactPhone": "848-027-8545 x93162",
      "AssociateName": "Lueilwitz-Russel",
      "AssociateId": 399,
      "UsePersonAddress": false,
      "ContactFax": "quidem",
      "Kanafname": "sit",
      "Kanalname": "et",
      "Post1": "doloribus",
      "Post2": "vitae",
      "Post3": "ex",
      "EmailName": "camryn_gottlieb@mcglynnturner.info",
      "ContactFullName": "Quentin Kassulke",
      "ActiveErpLinks": 304,
      "TicketPriorityId": 926,
      "SupportLanguageId": 868,
      "SupportAssociateId": 160,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1029962",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 315
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "officia",
  "Xstop": false,
  "ActiveInterests": 893,
  "GroupId": 35,
  "ActiveStatusMonitorId": 65,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 25,
  "DbiAgentId": 314,
  "DbiLastSyncronized": "2002-11-05T16:32:47.3058822+01:00",
  "DbiKey": "atque",
  "DbiLastModified": "2011-12-19T16:32:47.3058822+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 842,
  "ActiveErpLinks": 780,
  "BounceEmails": [
    "shyann.witting@rutherford.com",
    "zaria@walter.biz"
  ],
  "Domains": [
    "non",
    "consectetur"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Gretchen White",
    "SuperOffice:2": "Jayden Bruen"
  },
  "ExtraFields": {
    "ExtraFields1": "veritatis",
    "ExtraFields2": "non"
  },
  "CustomFields": {
    "CustomFields1": "maiores",
    "CustomFields2": "laborum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 833
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```