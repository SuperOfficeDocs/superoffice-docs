---
uid: add-mod-control
title: How to add an MDO control
description: How to add an MDO control to an existing panel of a page
keywords: usercontrol, MDO, list
author: Tony Yates
date: 06.24.2016
content_type: howto
category: customization
topic: Pagebuilder
platform: web
deployment: onsite
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

```xml
<view id="FindProjectDialogView" type="SoDialogView" soprotocol="findproject" current="" >
  <caption>[SR_SINGULAR_PROJECT]</caption>
  <tooltip></tooltip>
  <controlgroups>
    <controlgroup id="FindProjectGroup" type="SoControlGroup" position="absolute" left="15px" top="0px" width="100%" >
      <controls>
        <!--Some other Code-->
        <control id="projtemp5_1" type="SoCheckBox" column="0" row="4">
          <caption>[SR_PROJECT_CARD_RESPONSIBLE]</caption>
          <datasource>FindDataHandler.associateId.IsActive</datasource>
        </control>
        <control id="projtemp5_3" type="SoMDOControl" column="2" row="4" width="120px">
          <caption></caption>
          <datasource>FindDataHandler.associateId.Operator</datasource>
          <config>
            <list-datasource>OperatorListDataHandler.staticassociate</list-datasource>
            <propertykey>Type</propertykey>
          </config>
        </control>
        <control id="projtemp5_4" type="SoMDOControl" column="3" row="4" width="200px" >
          <caption></caption>
          <datasource>FindDataHandler.associateId.Values[0]</datasource>
          <config>
            <displaytext-datasource>FindDataHandler.associateId.DisplayValues[0]</displaytext-datasource>
            <listname>Associate</listname>
          </config>
        </control>

        <!-- Our Code Starts Here -->
        <control id="newLabel" type="SoLabel" context-style="Normal" row="5" column="2">
          <caption>New Control</caption>
        </control>
        <control id="projtemp5_5" type="SoMDOControl" column="3" row="5" width="200px" >
          <caption></caption>
          <datasource>FindDataHandler.categoryId.Values[0]</datasource>
          <config>
            <displaytext-datasource>FindDataHandler.categoryId.DisplayValues[0]</displaytext-datasource>
            <listname>Category</listname>
          </config>
        </control>
         <!-- Our Code Ends Here --> 

         <!--Some other Code -->
        <control id="ProjectListLabel" type="SoLabel" column="0" row="6">
          <caption>[SR_FIND_MATCH]</caption>
        </control>
      </controls>
      <config>
        <grouptype>grid</grouptype>
        <cellheight>5</cellheight>
        <cellwidths>
          <cellwidth>120px</cellwidth>
          <cellwidth>10px</cellwidth>
          <cellwidth>140px</cellwidth>
          <cellwidth>70%</cellwidth>
        </cellwidths>
      </config>
    </controlgroup>
  </controlgroups>
</view>
```

We can observe that we have adhered to all the rules given above and the controls appear smoothly on the page.

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: media/image001.jpg
[img2]: media/image002.jpg
