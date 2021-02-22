---
title: custom_fields       
description: Custom fields
author: {github-id}             # Your GitHub alias.
keywords:
so.topic:
---

# Custom fields

## What are Udef fields?

You are allowed to add your own fields to contact, project, person, sale, appointment, and documents tables. These fields are known as user-defined fields. In the application, user-defined fields are visible in the corresponding main cards.

> [!NOTE]
> Only an administrator can add a user-defined field. You can **update** the data stored in a user-defined field.

User-defined fields are stored in special database tables. For example, for contact, user-defined fields are stored in `udcontactsmall` and `udcontactlarge`. These 2 tables have lots of fields such as `long02` and `string04`, which barely describe their function to the user.

When the user-defined fields are defined for a contact, the system controls which field of udcontactsmall or udcontactlarge they are assigned. The `Udcontactsmall` table contains short fields such as int and floats, while the `udcontactlarge` table contains large text fields such as  `varchar[255]`.
