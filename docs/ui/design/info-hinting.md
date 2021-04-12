---
title: Information hinting
description: Information hinting
author: Christian Mogensen
so.date: 12.09.2011
keywords: design,ui
so.topic: concept
so.envir:                     # cloud or onsite
so.client:                    # online, web, win, pocket, or mobile
---

# Information hinting

If you have taken all sorts of information away from the display, you need to show the user that more information is available, and ideally, also present a mechanism for getting at it.

**Progressive disclosure** means that the interface shows you first a little bit, then a bit more when the user asks for more detail.

The MORE button (the 2 triangles button) is an example of this. When you first start using SuperOffice CRM 5 you see the simple version of a dialog.

Clicking the triangle will display more of the dialog. This gives the user access to the more sophisticated fields like the file name which the beginner does not need to know about.

To make the user’s life easier we remember the state of the more button, so the next time the user opens the dialog, we display it in the MORE state. This way we save the user one click.

![Person list][img1]

Another example is in the person list. Here we display an icon if the person has interests registered, and another icon if the user has information text written about him.

The icons will provide details with a tooltip if the user parks the mouse pointer there.

The user can see which people have interests without having to open each person in a dialog. The information is available at a glance.

## Examples

![Information hinting][img2]

Another example is the interest tab on the contact card. Here the tab changes color when there are interests present. The user can then tell if the interest tab is worth looking at without having to look at it. We save the user a click, and they avoid disappointment.

Status information like this is also common in a browser window. The padlock icon tells the user that the connection is secure without the user having to ask.

 Imagine if this information was only available in the File Properties dialog. It would be frustrating to have to go to this dialog every time you wanted to know the security status.

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: media/person-list.gif
[img2]: media/information-hinting.gif
