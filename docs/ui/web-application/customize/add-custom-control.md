---
title: webapp_add_custom_control
description: How to add a custom control to an existing view
author: Tony Yates
so.date: 06.24.2016
keywords: gui
so.topic: howto
so.client: web
so.envir: onsite
---

# Adding a custom control to an existing view

**Custom controls** are controls that have been made using tools provided by Visual Studio, such as SoTextBox, SoLable, SoCheckBox, and SoRadioButton.

In this example, we will make changes to the **Contact** main in a way that it displays the contact’s **Interests** information as well. To do this, we must modify the *SoMainviewView.config* file since the *SoContactPanel.config* file calls it to display the **Contact** view. The reason for using a separate config file for the Contact view is that the view is used in multiple places and this reduces the number of redundant code.

```XML
<view id="MainView" type="SoView" soprotocol="main" current="contact">
  <caption>[SR_COMMON_CONTACT]</caption>
  <tooltip>The main one</tooltip>
  <controlgroups>
    <!--Some other Code -->
    <!--Our Code Begins here -->
    <!--First controlgroup -->
    <controlgroup id="newInterestHeadergroup" type="SoControlGroup" position="absolute" top="205px" left="5px" right="20px">
      <controls>
        <control id="newContactInterestHeaderControl" type="ContactHeader">
          <datasource>ContactEntityDataHandler.ContactEntity</datasource>
          <config>
          </config>
        </control>
      </controls>
    </controlgroup>
    <!--Seconds controlgroup -->
    <controlgroup id="newMaininterestgroup" type="SoControlGroup" position="absolute" top="229px" left="5px" right="20px">
      <controls>
        <control id="newContactInterestCommonHead" type="ContactCommonHeaderView">
          <datasource>ContactEntityDataHandler.ContactEntity</datasource>
        </control>
       </controls>
    </controlgroup>>
  </controlgroups>
  <!--Our Code Ends here -->
  <!--Some other Code -->
</view>
```

Here we have added several `controlgroup`, `controls`, and `control` elements, which include the code segments that affect a certain part of GUI.

The first group determines where the contact name and country flag should be displayed. The `control` element inside of `controls` gives the control a unique ID and tells what type of control it is. The `datasource` element tells where to retrieve the relevant data from.

The second control group determines where the interest data should be shown on the screen.

![04][img1]

<!-- Referenced links -->
[1]:

<!-- Referenced images -->
[img1]: media/image004.jpg
