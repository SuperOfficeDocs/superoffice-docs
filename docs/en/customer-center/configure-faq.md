---
title: Configure FAQ entries
uid: faq-config
description: Configure FAQ entries
author: SuperOffice Product and Engineering
keywords: FAQ, CEP, Customer Center, registry, comment
content_type: howto
audience: settings
index: true
---

# Configure FAQ entries

To enable the comment field inside the Customer Center for your FAQ entries, you need to change the REGISTRY table in the SuperOffice CRM database.

> [!NOTE]
> It is not recommended to make changes directly on the database without a backup available. If you make a mistake, this backup must be restored.

To enable comments:

1. Run the following query first: `select * from crm7.registry where reg_id in (198, 199)`
If nothing is returned by this query, first go to your Customer center and FAQs and the registry keys will be populated.

    ![Configure FAQ entries -screenshot][img1]

1. Now you can change comment field access. Below are possible options:
    * 0 = none
    * 1 = customer (these are people that are logged in to the customer portal)
    * 2 = all - also anonymous users

1. After you enable these settings you will see the comments show up.

![x -screenshot][img2]

> [!NOTE]
> If you use SuperOffice Online you need to contact [support][1].

## More access control on FAQ entries

By default, you may specify that a FAQ or a folder of FAQs may be accessed by everyone, registered customers, internal users, or private.

You may also control access to a FAQ folder by adding a small script that is evaluated in the "Access Control" under Setup FAQ folder. This script has access to all data for the logged-in contact, and contact person's name and must return the value "1" for access to be granted to the folder.

**To return a value in the scripting language as used syntax:**

`% RETURN: "1"%`

### Available fields

**For contact:**'

* customer.id
* customer.name
* customer.bestName
* customer.firstname
* customer.lastname
* customer.phone
* customer.cellphone
* customer.note
* customer.username
* customer.password
* customer.email

**For company:**

* company.id
* company.name
* company.note
* company.domain
* company.phone
* company.fax
* company.adr

In addition, all extra fields for contact person are available via "customer." plus the name of the extra field, for example, `customer.MyExtraField`, and similarly for the company: "company.ExtraField". Boolean field has the value "1" when they are true.

For example, a boolean field is created on the customer, called `x_access`. When tick, the user will get access:

```text
%IF:customer.x_access="1"%
%RETURN:"1"%
%ENDIF%
```

<!-- Referenced links -->
[1]: http://support.superoffice.com/

<!-- Referenced images -->
[img1]: media/regid-198-199.png
[img2]: media/comments.png
