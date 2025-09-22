---
uid: help-en-ui-extra-menu-navigator
title: Add navigator group and extra menu
description: Add navigator group and extra menu
author: SuperOffice RnD
date: 04.24.2023
keywords: navigator group
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: en
---

# Add navigator group and extra menu

[!include[Legacy](../includes/legacy-extra-menus.md)]

To illustrate this functionality, we will add a new navigator group in the navigator to the left in SuperOffice. We will add an extra menu in the new navigator group. In our example, we will add the navigator group "Websites" with some useful websites.

1. Select <i class="ph ph-list" aria-label="Main menu"></i> **System settings** > **System design** > **Extra menus**.

2. Hold the mouse pointer over the **Navigator** folder and click **+**.

3. Enter "Websites" in the **Label** field (maximum 14 characters).

4. Optional: Click the button **Choose** to the right of the **URL to icon** field to select an icon for the navigator group. You can select an image that is already available in the database or upload an image. The image should have a size of 36x36 pixels, so that it is correctly shown in the navigator. You select the image and change the size in the same dialog.

5. Click **Position** to choose where the new navigator group should be positioned (0 = top).

6. Click **OK**. The new navigator group is shown on the left. The navigator group is empty, so we must add website. In this case, we add Google.

7. Hold the mouse pointer over the navigator group you have just created and click **+**. The **Menu properties** screen appears.

8. Enter "Google" in the **Label** field (maximum 20 characters).

9. Check **Use URL** and enter `http://www.google.com` in the **URL** field.

10. DO NOT check **Append ID** or **Append &lt;usec&gt;**, or values will be added behind the URL you defined.

    [!include[Usec Forbidden Online](../../../../includes/usec-forbidden-online.md)]

11. DO NOT check **Return to same screen**. If checked, external URLs do not work. See [Menu properties][1].

12. In the **Target** field, enter "\_blank", so that the website opens in a new tab in the browser.

13. Click **OK**.

14. Click the navigator group and the new extra menu and check that the website opens correctly.

<!-- Referenced links -->
[1]: properties.md
