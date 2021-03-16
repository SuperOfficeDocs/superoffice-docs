---
title: pb_page_fragments
description: PageBuilder page fragments
author: Tony Yates
so.date: 06.24.2016
keywords:
so.topic:
so.client: web
so.envir: onsite
---

# Page fragments

As seen on the company page, **panel** elements use a `reference` attribute to indicate the panel contents reside in a file that follows the standard naming convention. With that knowledge, the following files must also exist and contain their respective parts, which they do:

* SoMenuPanelPanel.config
* SoButtonBarPanel.config
* SoNavigatorPanel.config
* SoContactPanel.config

Each one of these files exists under the root or a sub-folder in *App\*Data\WebClient\Web*.

Expanding on a slimmed-down copy of *SoContactPanel.config* reveals the following structure. As expected, the root element is `panel` followed by a card collection, which contains views and so on.

The file declares even more element fragments that reference other files. The first example is a **view** with `id` value MainView. The `reference` attribute is *MainView*, which means that the content of this view must be in a file named *SoMainViewView.config*. *SoMainViewView.config* does exist and contains the content that declares the top left view of the company card.

[!code-xml[XML](includes/somainviewview.xml)]

Looking further down in the file, there are more fragments declared using both `reference` and `referenceWithIdUpdate` attribute.

The difference between the 2 is that `reference` is used when the element id is unique and the contents of the element reside in the file that follows the naming convention *So[id][Element].config*.

Because no elements of the same type can have the same id, The attribute *referenceWithIdUpdate*, is used when more than one element of the same type wants to reference the same content. To avoid creating duplicate content in files *SoMoreMainHeaderGroupControlGroup.config* and *SoInterestMainHeaderGroupControlGroup.config*, using *referenceWithIdUpdate* means reference this file instead of using my id as the link.

Using the following image to illustrate the point, no matter what tab is selected in the main card, the contents of the MainHeaderGroup *controlgroup* and ContactButtonBar *controlgroup* are shown in all views.

![web-client-company-main-card][img1]

Therefore, the best way to avoid creating two files with the same content named:

* SoMoreMainHeaderGroupControlGroup.config
* SoInterestMainHeaderGroupControlGroup.config

Is to use *referenceWithIdUpdate* and reference one file named:

* *SoMainHeaderGroupControlGroup.config*

<!-- Referenced links -->
[1]:

<!-- Referenced images -->
[img1]: media/web-client-company-main-card.png
