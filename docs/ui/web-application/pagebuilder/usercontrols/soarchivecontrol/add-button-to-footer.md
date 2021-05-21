---
title: How to add a button
uid: pb_usercontrol_archive_footer
description: How to add a button to the archive footer
author: Tony Yates
so.date: 06.24.2016
keywords:
so.topic: howto
so.client: web
so.envir: onsite
---

# How to add a button to the archive footer

In this example, we will add a new button called **Delete** to the project archive view. To do this, we need to make changes to the *SoContactPanel.config* file.

The code segment below shows how a new button has been added to the project archive view of the **Company** page.

[!code-xml[XML](includes/footer-button.xml)]

Out of the above code segment, the area related to our button can be found between the *our Button…* comments.

[!code-xml[XML](includes/footer-button.xml?43-52)]

Here we have created a button and assigned properties such as the caption, tooltip hint, and different images that the button could have. The data rights require that the selected row contains the corresponding rights in its table-right property. If the rows do not have the deleted data rights, then the button should be disabled.

`nav=deleteProject` is the name of the **linkhint**, which is used to delete the project. All link info is recorded in the *SoArchiveControlLinkInfoTypes.config* file and contains information about which JavaScript to use and what should be passed into it.

**Before:**

![04][img1]

**After:**

![05][img2]

<!-- Referenced links -->
[1]:

<!-- Referenced images -->
[img1]: media/image004.jpg
[img2]: media/image005.jpg
