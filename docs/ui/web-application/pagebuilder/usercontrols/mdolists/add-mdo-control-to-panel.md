---
title: add_mod_control
description: How to add an MDO control to an existing panel of a page
author: Tony Yates
so.date: 06.24.2016
keywords: usercontrol, MDO, list
so.topic: howto
so.client: web
so.envir: onsite
---

# How to add an MDO control to an existing panel of a page

We are going to add a new MDO control to the **Find** dialog.

## Before

![01][img1]

There is a large number of controls in the first section of the page. When there is a control group like this, SuperOffice has grouped them into rows and columns. So when we are adding a control to a page, we must add our control according to these configurations.

**SoFindProjectDialogViewView.config before adding the control:**

```XML
<control id="newLabel" type="SoLabel" context-style="Normal" row="5" column="2">
  <caption>New Control</caption>
</control>

<control id="projtemp5_5" type="SoMDOControl" column="3" row="5" width="200px" >
  <caption></caption>
  <datasource>FindDataHandler.categoryId.Values[0]</datasource>
  <config>
    <displaytext-datasource>FindDataHandler.categoryId.DisplayValues[0]<displaytext-datasource>
    <listname>Category</listname>
  </config>
</control>
```

Above, both `control` elements specify the row and column number. So in a case like this, if we are inserting a control, we **pay attention to simple things like this to avoid overlap**.

## After

![02][img2]

Here we have added 2 controls: an SoLabel and an MDO control. Since we have given the proper column and row numbers for each control, the controls have appeared at the correct location without overlapping the existing controls.

Important settings:

* The control should have a unique ID.
* The controls should appear in a control group section of the main control groups section. You can use an existing section or a new one.
* Respect `column` and `row` elements if present.
* Consider config settings native to each control. For example, an MDO control will not have a caption but an SoLabel will.
* Follow normal XML rules as well. For example, if we open a tag it must be closed.

**SoFindProjectDialogViewView.config after adding the control:**

[!code-xml[xml](includes/sofindprojectdialogviewview.xml)]

We can observe that we have adhered to all the rules given above and the controls appear smoothly on the page.

<!-- Referenced links -->
[1]:

<!-- Referenced images -->
[img1]: media/image001.jpg
[img2]: media/image002.jpg
