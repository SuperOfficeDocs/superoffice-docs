---
title: POST Agents/Contact/EnrichContactEntity
uid: v1ContactAgent_EnrichContactEntity
generated: true
content_type: reference
---

# POST Agents/Contact/EnrichContactEntity

```http
POST /api/v1/Agents/Contact/EnrichContactEntity
```

Enrich a contact with data from the AI Enrichment service.


This will update the contact with address, phone number, and email.
NsApiSlow threshold: 2000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/EnrichContactEntity?$select=name,department,category/id
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

## Request Body: request 

ContactEntity, EnrichId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactEntity | ContactEntity | The Contact Service. The service implements all services working with the Contact object <para /> Carrier object for ContactEntity. Services for the ContactEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IContactAgent">Contact Agent</see>. |
| EnrichId | String |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ContactEntity

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

## Sample request

```http!
POST /api/v1/Agents/Contact/EnrichContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactEntity": null,
  "EnrichId": "sint"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 913,
  "Name": "Boyer, Thiel and Crist",
  "Department": "",
  "OrgNr": "794871",
  "Number1": "873900",
  "Number2": "578248",
  "UpdatedDate": "2022-10-27T03:40:46.4993718+02:00",
  "CreatedDate": "2016-07-11T03:40:46.4993718+02:00",
  "Emails": [
    {
      "Value": "veritatis",
      "StrippedValue": "et",
      "Description": "Intuitive holistic analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 96
        }
      }
    },
    {
      "Value": "veritatis",
      "StrippedValue": "et",
      "Description": "Intuitive holistic analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 96
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 120,
      "Name": "Russel, Daugherty and Ondricka",
      "ToolTip": "Distinctio iste ut omnis ad architecto ut.",
      "Deleted": false,
      "Rank": 267,
      "Type": "iusto",
      "ColorBlock": 696,
      "IconHint": "consequuntur",
      "Selected": false,
      "LastChanged": "2016-07-09T03:40:46.4993718+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "consequatur",
      "StyleHint": "nesciunt",
      "Hidden": true,
      "FullName": "Ms. Reilly King",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 866
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "laborum",
      "StrippedValue": "quas",
      "Description": "Assimilated dynamic application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 42
        }
      }
    },
    {
      "Value": "laborum",
      "StrippedValue": "quas",
      "Description": "Assimilated dynamic application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 42
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "libero",
      "StrippedValue": "sunt",
      "Description": "Triple-buffered high-level secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 689
        }
      }
    },
    {
      "Value": "libero",
      "StrippedValue": "sunt",
      "Description": "Triple-buffered high-level secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 689
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "nemo",
      "StrippedValue": "quia",
      "Description": "Future-proofed disintermediate task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 444
        }
      }
    },
    {
      "Value": "nemo",
      "StrippedValue": "quia",
      "Description": "Future-proofed disintermediate task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 444
        }
      }
    }
  ],
  "Description": "Reduced human-resource concept",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "natus",
      "PersonId": 816,
      "Mrmrs": "quos",
      "Firstname": "Roosevelt",
      "Lastname": "Marks",
      "MiddleName": "White, Johnston and Jenkins",
      "Title": "rem",
      "Description": "Integrated incremental analyzer",
      "Email": "kasey@herman.us",
      "FullName": "Hattie Parker",
      "DirectPhone": "738.071.5963",
      "FormalName": "Lang, Keebler and Spinka",
      "CountryId": 796,
      "ContactId": 696,
      "ContactName": "Ebert-Windler",
      "Retired": 734,
      "Rank": 930,
      "ActiveInterests": 646,
      "ContactDepartment": "",
      "ContactCountryId": 952,
      "ContactOrgNr": "878280",
      "FaxPhone": "097.065.2544",
      "MobilePhone": "(509)273-7847 x789",
      "ContactPhone": "(063)504-3696 x120",
      "AssociateName": "Kutch-Schiller",
      "AssociateId": 885,
      "UsePersonAddress": true,
      "ContactFax": "at",
      "Kanafname": "molestiae",
      "Kanalname": "consequuntur",
      "Post1": "ipsam",
      "Post2": "et",
      "Post3": "fuga",
      "EmailName": "bryce@macejkoviccarter.info",
      "ContactFullName": "Prof. Emma Lexi Huels",
      "ActiveErpLinks": 975,
      "TicketPriorityId": 248,
      "SupportLanguageId": 507,
      "SupportAssociateId": 751,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1266325",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 591
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "sunt",
  "Xstop": true,
  "ActiveInterests": 443,
  "GroupId": 626,
  "ActiveStatusMonitorId": 381,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 765,
  "DbiAgentId": 332,
  "DbiLastSyncronized": "2013-01-14T03:40:46.4993718+01:00",
  "DbiKey": "et",
  "DbiLastModified": "2011-09-23T03:40:46.4993718+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 742,
  "ActiveErpLinks": 308,
  "BounceEmails": [
    "florence@rippinschumm.uk",
    "carson@wilderman.com"
  ],
  "Domains": [
    "ducimus",
    "quis"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Guillermo Glover",
    "SuperOffice:2": "Juliet Schaefer"
  },
  "ExtraFields": {
    "ExtraFields1": "vero",
    "ExtraFields2": "quasi"
  },
  "CustomFields": {
    "CustomFields1": "laboriosam",
    "CustomFields2": "et"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 17
    }
  }
}
```