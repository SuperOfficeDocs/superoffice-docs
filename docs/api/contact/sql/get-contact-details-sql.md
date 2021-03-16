---
title: get_contact_details
description: Get contact details from the SuperOffice database
author:
so.date:
keywords:
so.topic: howto
---

# Get contact details

At its most basic, we just search the contact table:

```SQL
SELECT * FROM contact WHERE name = 'Client System AS'
```

Which gives us the name, the code and number, and a bunch of list item IDs.

![x][img1]

## List items: category and business

These are straightforward inner-joins against the corresponding list item tables.

```SQL
SELECT * FROM contact, category, business 
WHERE name = 'Client System AS'
AND contact.category_idx = category.category_id
AND contact.business_idx = business.business_id
```

Now we get the category name and description, as well as the category name.

![x][img2]

## Phone numbers

There may be several phone numbers on a contact. We will pick out the first one.

```SQL
SELECT * FROM contact, category, business, phone 
WHERE name = 'Client System AS'
AND contact.category_idx = category.category_id
AND contact.business_idx = business.business_id
AND contact.contact_id = phone.owner_id
AND phone.ptype_idx = 1
AND phone.rank = 1
```

Phones come in [several different types][1]. Type 1 = direct phone.

This inner join assumes that the contact has at least one phone number.

If we want to handle contacts that have no phone numbers, we need to use an outer-join:

```SQL
SELECT c.name, cat.name, bus.name, p.* FROM CRM.contact c
LEFT OUTER JOIN CRM.phone p ON c.contact_id = p.owner_id
INNER JOIN CRM.category cat ON c.category_idx = cat.category_id
INNER JOIN CRM.business bus ON c.business_idx = bus.business_id
WHERE c.name = 'Client System AS'
AND p.ptype_idx = 1
AND p.rank = 1
```

![x][img3]

## Address: street or postal

There is only one address record of each type per contact. However, if no address has been entered there will not be an address record, so we need to use an outer join again.

We can use an inner join to get the country ID. The list item should always be set.

```SQL
SELECT c.name, cat.name, bus.name, p.phone, cou.name, a.*
FROM CRM.contact c
LEFT OUTER JOIN CRM.address a ON c.contact_id = a.owner_id
LEFT OUTER JOIN CRM.phone p ON c.contact_id = p.owner_id
INNER JOIN CRM.category cat ON c.category_idx = cat.category_id
INNER JOIN CRM.business bus ON c.business_idx = bus.business_id
INNER JOIN CRM.country cou ON c.country_id = cou.country_id
WHERE c.name = 'Client System AS'
AND p.ptype_idx = 1
AND p.rank = 1
AND a.atype_idx = 2
```

[Address type][2]: 2 = street address

![x][img4]

<!-- Referenced links -->
[1]: https://github.com/SuperOfficeDocs/database/blob/main/docs/tables/phone.md
[2]: https://github.com/SuperOfficeDocs/database/blob/main/docs/tables/address.md

<!-- Referenced images -->
[img1]: media/select-contact2.gif
[img2]: media/select-contact3.gif
[img3]: media/select-contact4.gif
[img4]: media/select-contact5.gif
