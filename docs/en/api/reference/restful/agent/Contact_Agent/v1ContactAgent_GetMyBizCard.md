---
title: POST Agents/Contact/GetMyBizCard
uid: v1ContactAgent_GetMyBizCard
---

# POST Agents/Contact/GetMyBizCard

```http
POST /api/v1/Agents/Contact/GetMyBizCard
```

Returns all data needed to display the logged on person's business card.


That is company, person, and company interest data.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetMyBizCard?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


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

## Sample request

```http!
POST /api/v1/Agents/Contact/GetMyBizCard
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 456,
  "Name": "Reichert, Sauer and Wolff",
  "Department": "",
  "OrgNr": "1668086",
  "Number1": "1468299",
  "Number2": "289204",
  "UpdatedDate": "2019-04-16T03:51:26.8811711+02:00",
  "CreatedDate": "2000-12-28T03:51:26.8811711+01:00",
  "Emails": [
    {
      "Value": "dolores",
      "StrippedValue": "consequatur",
      "Description": "Open-source non-volatile architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 705
        }
      }
    },
    {
      "Value": "dolores",
      "StrippedValue": "consequatur",
      "Description": "Open-source non-volatile architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 705
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 727,
      "Name": "Prosacco Group",
      "ToolTip": "Asperiores voluptate ad ea rerum odio a.",
      "Deleted": false,
      "Rank": 535,
      "Type": "sit",
      "ColorBlock": 797,
      "IconHint": "vel",
      "Selected": false,
      "LastChanged": "2008-02-29T03:51:26.8811711+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eum",
      "StyleHint": "unde",
      "Hidden": true,
      "FullName": "Ms. Jewell Cassin",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 572
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "in",
      "StrippedValue": "voluptate",
      "Description": "Phased cohesive matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 124
        }
      }
    },
    {
      "Value": "in",
      "StrippedValue": "voluptate",
      "Description": "Phased cohesive matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 124
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "ea",
      "StrippedValue": "inventore",
      "Description": "Centralized logistical functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 693
        }
      }
    },
    {
      "Value": "ea",
      "StrippedValue": "inventore",
      "Description": "Centralized logistical functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 693
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "est",
      "StrippedValue": "ducimus",
      "Description": "Universal directional leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 349
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "ducimus",
      "Description": "Universal directional leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 349
        }
      }
    }
  ],
  "Description": "Implemented systemic contingency",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quis",
      "PersonId": 180,
      "Mrmrs": "quia",
      "Firstname": "Kamren",
      "Lastname": "Ankunding",
      "MiddleName": "Lang-Ratke",
      "Title": "qui",
      "Description": "Adaptive client-driven software",
      "Email": "jayne@schiller.uk",
      "FullName": "Anahi Zieme",
      "DirectPhone": "633.229.4951",
      "FormalName": "Tillman, Beer and Borer",
      "CountryId": 733,
      "ContactId": 646,
      "ContactName": "Fisher LLC",
      "Retired": 840,
      "Rank": 752,
      "ActiveInterests": 108,
      "ContactDepartment": "",
      "ContactCountryId": 335,
      "ContactOrgNr": "317302",
      "FaxPhone": "1-245-637-1625",
      "MobilePhone": "917-126-0464 x36550",
      "ContactPhone": "1-567-167-3094 x8994",
      "AssociateName": "Goldner-Eichmann",
      "AssociateId": 861,
      "UsePersonAddress": false,
      "ContactFax": "corrupti",
      "Kanafname": "dolorum",
      "Kanalname": "dolorem",
      "Post1": "molestias",
      "Post2": "quas",
      "Post3": "quia",
      "EmailName": "edmond.skiles@hintzreilly.info",
      "ContactFullName": "Deshawn Medhurst Sr.",
      "ActiveErpLinks": 528,
      "TicketPriorityId": 840,
      "SupportLanguageId": 768,
      "SupportAssociateId": 82,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 131
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "blanditiis",
  "Xstop": false,
  "ActiveInterests": 341,
  "GroupId": 703,
  "ActiveStatusMonitorId": 508,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 868,
  "DbiAgentId": 298,
  "DbiLastSyncronized": "2012-07-05T03:51:26.8811711+02:00",
  "DbiKey": "quos",
  "DbiLastModified": "1999-08-11T03:51:26.8811711+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 298,
  "ActiveErpLinks": 260,
  "BounceEmails": [
    "priscilla@jewessrosenbaum.us",
    "shanna@paucek.us"
  ],
  "Domains": [
    "vel",
    "omnis"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Alysha Lubowitz"
  },
  "ExtraFields": {
    "ExtraFields1": "numquam",
    "ExtraFields2": "cumque"
  },
  "CustomFields": {
    "CustomFields1": "recusandae",
    "CustomFields2": "facere"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 114
    }
  }
}
```