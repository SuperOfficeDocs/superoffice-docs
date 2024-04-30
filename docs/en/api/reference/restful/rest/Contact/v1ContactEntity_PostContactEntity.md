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
  "ContactId": 770,
  "Name": "O'Kon Inc and Sons",
  "Department": "",
  "OrgNr": "1521065",
  "Number1": "1806689",
  "Number2": "388144",
  "UpdatedDate": "2000-11-04T11:44:41.7577798+01:00",
  "CreatedDate": "1999-02-07T11:44:41.7577798+01:00",
  "Emails": [
    {
      "Value": "dolores",
      "StrippedValue": "ex",
      "Description": "Extended next generation migration"
    },
    {
      "Value": "dolores",
      "StrippedValue": "ex",
      "Description": "Extended next generation migration"
    }
  ],
  "Interests": [
    {
      "Id": 785,
      "Name": "Ullrich LLC",
      "ToolTip": "Voluptates amet magnam molestias id perspiciatis.",
      "Deleted": false,
      "Rank": 281,
      "Type": "eaque",
      "ColorBlock": 13,
      "IconHint": "consequuntur",
      "Selected": false,
      "LastChanged": "2008-03-31T11:44:41.7577798+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sapiente",
      "StyleHint": "voluptas",
      "Hidden": false,
      "FullName": "Miss Nya Alda Sauer V"
    }
  ],
  "Urls": [
    {
      "Value": "voluptatibus",
      "StrippedValue": "officia",
      "Description": "Customizable composite benchmark"
    },
    {
      "Value": "voluptatibus",
      "StrippedValue": "officia",
      "Description": "Customizable composite benchmark"
    }
  ],
  "Phones": [
    {
      "Value": "occaecati",
      "StrippedValue": "animi",
      "Description": "Seamless assymetric flexibility"
    },
    {
      "Value": "occaecati",
      "StrippedValue": "animi",
      "Description": "Seamless assymetric flexibility"
    }
  ],
  "Faxes": [
    {
      "Value": "ad",
      "StrippedValue": "at",
      "Description": "Enhanced system-worthy contingency"
    },
    {
      "Value": "ad",
      "StrippedValue": "at",
      "Description": "Enhanced system-worthy contingency"
    }
  ],
  "Description": "Distributed even-keeled approach",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "illo",
      "PersonId": 251,
      "Mrmrs": "corrupti",
      "Firstname": "Estevan",
      "Lastname": "Koepp",
      "MiddleName": "Runolfsson Inc and Sons",
      "Title": "ut",
      "Description": "Virtual optimizing Graphic Interface",
      "Email": "nichole.gerlach@ratkebrekke.info",
      "FullName": "Mrs. Bartholome Rau",
      "DirectPhone": "1-220-440-0014",
      "FormalName": "Pagac-Kessler",
      "CountryId": 480,
      "ContactId": 69,
      "ContactName": "Ondricka-Hintz",
      "Retired": 571,
      "Rank": 234,
      "ActiveInterests": 70,
      "ContactDepartment": "",
      "ContactCountryId": 276,
      "ContactOrgNr": "552559",
      "FaxPhone": "1-671-819-9316 x3014",
      "MobilePhone": "229.527.2594",
      "ContactPhone": "093.530.9949 x66541",
      "AssociateName": "Hermann Inc and Sons",
      "AssociateId": 529,
      "UsePersonAddress": false,
      "ContactFax": "amet",
      "Kanafname": "et",
      "Kanalname": "ut",
      "Post1": "sapiente",
      "Post2": "ut",
      "Post3": "quas",
      "EmailName": "trudie_hilpert@schmeler.com",
      "ContactFullName": "Ellen Runte",
      "ActiveErpLinks": 51,
      "TicketPriorityId": 335,
      "SupportLanguageId": 721,
      "SupportAssociateId": 659,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "rerum",
  "Xstop": false,
  "ActiveInterests": 273,
  "GroupId": 456,
  "ActiveStatusMonitorId": 148,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 165,
  "DbiAgentId": 600,
  "DbiLastSyncronized": "2010-09-05T11:44:41.7577798+02:00",
  "DbiKey": "eligendi",
  "DbiLastModified": "2005-12-14T11:44:41.7577798+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 315,
  "ActiveErpLinks": 482,
  "BounceEmails": [
    "jared@wolf.co.uk",
    "tia_little@hauckkuphal.info"
  ],
  "Domains": [
    "quasi",
    "quidem"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Skylar Hayes",
    "SuperOffice:2": "Daisha Leuschke"
  },
  "ExtraFields": {
    "ExtraFields1": "quod",
    "ExtraFields2": "quisquam"
  },
  "CustomFields": {
    "CustomFields1": "aut",
    "CustomFields2": "veniam"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 227,
  "Name": "Ernser Group",
  "Department": "",
  "OrgNr": "1103047",
  "Number1": "503945",
  "Number2": "880409",
  "UpdatedDate": "2015-01-09T11:44:41.7734006+01:00",
  "CreatedDate": "2015-05-27T11:44:41.7734006+02:00",
  "Emails": [
    {
      "Value": "nobis",
      "StrippedValue": "eveniet",
      "Description": "Open-source foreground access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 327
        }
      }
    },
    {
      "Value": "nobis",
      "StrippedValue": "eveniet",
      "Description": "Open-source foreground access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 327
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 729,
      "Name": "Price LLC",
      "ToolTip": "Ipsa tempora ullam laudantium temporibus velit consequatur.",
      "Deleted": false,
      "Rank": 586,
      "Type": "suscipit",
      "ColorBlock": 83,
      "IconHint": "velit",
      "Selected": true,
      "LastChanged": "2023-03-23T11:44:41.7734006+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quasi",
      "StyleHint": "non",
      "Hidden": false,
      "FullName": "Ms. Emie Jerald Medhurst",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 741
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "qui",
      "StrippedValue": "veniam",
      "Description": "Mandatory web-enabled algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 621
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "veniam",
      "Description": "Mandatory web-enabled algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 621
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "eligendi",
      "StrippedValue": "fuga",
      "Description": "Operative mission-critical synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 409
        }
      }
    },
    {
      "Value": "eligendi",
      "StrippedValue": "fuga",
      "Description": "Operative mission-critical synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 409
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "qui",
      "StrippedValue": "et",
      "Description": "Automated context-sensitive moratorium",
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
      "Value": "qui",
      "StrippedValue": "et",
      "Description": "Automated context-sensitive moratorium",
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
  "Description": "Advanced neutral pricing structure",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "aut",
      "PersonId": 426,
      "Mrmrs": "sed",
      "Firstname": "Kennith",
      "Lastname": "Schneider",
      "MiddleName": "Hintz-Pfeffer",
      "Title": "vel",
      "Description": "Innovative fresh-thinking circuit",
      "Email": "tremaine_brekke@feestdare.co.uk",
      "FullName": "Reginald Bruen",
      "DirectPhone": "(394)536-0726",
      "FormalName": "Nitzsche, Schinner and Muller",
      "CountryId": 236,
      "ContactId": 530,
      "ContactName": "Schulist LLC",
      "Retired": 657,
      "Rank": 696,
      "ActiveInterests": 529,
      "ContactDepartment": "",
      "ContactCountryId": 363,
      "ContactOrgNr": "419238",
      "FaxPhone": "(778)740-8345",
      "MobilePhone": "440.837.7786 x32074",
      "ContactPhone": "1-428-062-9707 x30041",
      "AssociateName": "Runte, Deckow and Emmerich",
      "AssociateId": 240,
      "UsePersonAddress": false,
      "ContactFax": "quia",
      "Kanafname": "natus",
      "Kanalname": "aspernatur",
      "Post1": "sed",
      "Post2": "nihil",
      "Post3": "perferendis",
      "EmailName": "osborne@schulist.name",
      "ContactFullName": "Ebony Kunze",
      "ActiveErpLinks": 777,
      "TicketPriorityId": 694,
      "SupportLanguageId": 704,
      "SupportAssociateId": 623,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 333
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "dolores",
  "Xstop": true,
  "ActiveInterests": 625,
  "GroupId": 49,
  "ActiveStatusMonitorId": 896,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 4,
  "DbiAgentId": 733,
  "DbiLastSyncronized": "2003-12-01T11:44:41.7734006+01:00",
  "DbiKey": "a",
  "DbiLastModified": "1999-10-25T11:44:41.7734006+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 113,
  "ActiveErpLinks": 984,
  "BounceEmails": [
    "freddy@greenfelder.co.uk",
    "annamarie@schowalterleffler.name"
  ],
  "Domains": [
    "animi",
    "nihil"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Miss Kallie Hilll V",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "optio",
    "CustomFields2": "dolorem"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 185
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```