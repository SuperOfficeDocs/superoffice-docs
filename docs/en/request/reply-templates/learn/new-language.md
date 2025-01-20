---
uid: help-en-reply-template-language
title: Create new language version of reply template
description: Create new language version of reply template
keywords: translate reply template, new language version, reply template, request
author: Bergfrid Dias
date: 01.13.2025
version: 10.5
topic: howto
license: serviceessentials
functional_right: knowledge-base
audience: person
audience_tooltip: SuperOffice Service
language: en
---

# Create new language version of reply template

It may be appropriate to have the same reply template in several languages, for example, if you need to send the same reply to customers in several countries.

## Add languages to reply template

1. Go to <i class="ph ph-list" aria-label="Main menu"></i> in the top bar and select **Knowledge base** > **Reply templates**.

2. Go to the folder where the reply template is located.

3. Click the reply template. This takes you to the **View reply templates** screen.

4. Click **Edit reply template**. This takes you to the **Reply template properties** screen.

5. Click the **New language version** button at the bottom of the screen. A new tab is added, named **(Unspecified language)**.

6. **Language**: In this list, select the language for the current language version of the reply template. The list contains registered [customer languages][2].

7. Enter the texts in the relevant language in the other tabs and make the necessary changes in this language version of the reply template. Find out more about this in [Create reply templates][1].

8. Click **OK**. The changes are saved. The **(Unspecified language)** tab changes to the selected language.

> [!TIP]
> Click the **Delete selected language version** to delete the active language version (the selected language tab).

## Troubleshooting

### Why is the "New language version" button not visible in the footer?

If the **New language version** button is not visible, it means no customer languages are currently defined in the system. To resolve this, an administrator needs to [add customer languages][3] in **Settings and maintenance** under **Options** > **Customer languages**.

### Why is a specific language not available in the list?

If a specific language is missing from the **Language** dropdown, it has not been added to the list of customer languages. Ask your administrator to include the missing language in **Settings and maintenance**.

<!-- Referenced links -->
[1]: create.md
[2]: ../../../admin/options/learn/custlang/index.md
[3]: ../../../admin/options/learn/custlang/update.md
