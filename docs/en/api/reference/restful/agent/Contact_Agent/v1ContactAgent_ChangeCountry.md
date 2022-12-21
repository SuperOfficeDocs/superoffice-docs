---
title: POST Agents/Contact/ChangeCountry
uid: v1ContactAgent_ChangeCountry
---

# POST Agents/Contact/ChangeCountry

```http
POST /api/v1/Agents/Contact/ChangeCountry
```

Change country regenerates the default values and localized information such as phone number and address format







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/ChangeCountry?$select=name,department,category/id
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

ContactEntity, ToCountryId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactEntity |  | The Contact Service. The service implements all services working with the Contact object <para /> Carrier object for ContactEntity. Services for the ContactEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IContactAgent">Contact Agent</see>. |
| ToCountryId | int32 |  |


## Response: 

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: 

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
| UpdatedBy |  | The user that last updated the contact |
| CreatedBy |  | The user that created the contact |
| Associate |  | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business |  | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category |  | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country |  | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate |  | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority |  | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage |  | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson |  | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address |  | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Contact/ChangeCountry
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactEntity": null,
  "ToCountryId": 236
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 159,
  "Name": "Hickle Group",
  "Department": "",
  "OrgNr": "324304",
  "Number1": "1386538",
  "Number2": "655104",
  "UpdatedDate": "2001-08-12T02:49:43.9660328+02:00",
  "CreatedDate": "2020-01-04T02:49:43.9660328+01:00",
  "Emails": [
    {
      "Value": "est",
      "StrippedValue": "doloremque",
      "Description": "Focused multi-state support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 620
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "doloremque",
      "Description": "Focused multi-state support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 620
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 738,
      "Name": "Gleichner-Abernathy",
      "ToolTip": "Quia quae possimus dolores deleniti.",
      "Deleted": true,
      "Rank": 962,
      "Type": "libero",
      "ColorBlock": 530,
      "IconHint": "impedit",
      "Selected": false,
      "LastChanged": "2021-04-12T02:49:43.9660328+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "reiciendis",
      "StyleHint": "id",
      "Hidden": false,
      "FullName": "Miss Sylvia Hoeger",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 474
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "et",
      "StrippedValue": "vel",
      "Description": "Expanded 4th generation local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 911
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "vel",
      "Description": "Expanded 4th generation local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 911
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "dicta",
      "StrippedValue": "quam",
      "Description": "Decentralized uniform archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 420
        }
      }
    },
    {
      "Value": "dicta",
      "StrippedValue": "quam",
      "Description": "Decentralized uniform archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 420
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "in",
      "StrippedValue": "eveniet",
      "Description": "Business-focused composite Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 695
        }
      }
    },
    {
      "Value": "in",
      "StrippedValue": "eveniet",
      "Description": "Business-focused composite Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 695
        }
      }
    }
  ],
  "Description": "Upgradable client-driven groupware",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "aut",
      "PersonId": 93,
      "Mrmrs": "sunt",
      "Firstname": "Manuel",
      "Lastname": "Farrell",
      "MiddleName": "Gerhold LLC",
      "Title": "vel",
      "Description": "Up-sized attitude-oriented website",
      "Email": "monique@wilkinsoncollins.name",
      "FullName": "Pete Roel Kertzmann DVM",
      "DirectPhone": "956-179-0263 x5799",
      "FormalName": "Daniel, Bradtke and Lind",
      "CountryId": 586,
      "ContactId": 201,
      "ContactName": "Abernathy Inc and Sons",
      "Retired": 677,
      "Rank": 516,
      "ActiveInterests": 538,
      "ContactDepartment": "",
      "ContactCountryId": 11,
      "ContactOrgNr": "1030832",
      "FaxPhone": "(421)309-9743 x038",
      "MobilePhone": "1-992-453-6279",
      "ContactPhone": "(410)977-2771 x6347",
      "AssociateName": "Ritchie, Runolfsdottir and Spinka",
      "AssociateId": 621,
      "UsePersonAddress": true,
      "ContactFax": "numquam",
      "Kanafname": "nihil",
      "Kanalname": "et",
      "Post1": "eveniet",
      "Post2": "occaecati",
      "Post3": "cupiditate",
      "EmailName": "wilford.considine@wisozk.uk",
      "ContactFullName": "Mckenzie Bednar",
      "ActiveErpLinks": 414,
      "TicketPriorityId": 283,
      "SupportLanguageId": 410,
      "SupportAssociateId": 564,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 923
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "voluptas",
  "Xstop": false,
  "ActiveInterests": 652,
  "GroupId": 446,
  "ActiveStatusMonitorId": 585,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 548,
  "DbiAgentId": 612,
  "DbiLastSyncronized": "2002-01-06T02:49:43.9660328+01:00",
  "DbiKey": "sed",
  "DbiLastModified": "2014-02-18T02:49:43.9660328+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 756,
  "ActiveErpLinks": 445,
  "BounceEmails": [
    "claudine@schuppe.uk",
    "whitney.kirlin@russel.us"
  ],
  "Domains": [
    "quis",
    "molestiae"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Noemie Braun",
    "SuperOffice:2": "Nathen Towne"
  },
  "ExtraFields": {
    "ExtraFields1": "autem",
    "ExtraFields2": "voluptatem"
  },
  "CustomFields": {
    "CustomFields1": "dolorum",
    "CustomFields2": "sunt"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 857
    }
  }
}
```