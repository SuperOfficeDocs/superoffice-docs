---
title: webapp_add_textbox
description: Adding a textbox that displays data from a data handler
author: Tony Yates
so.date: 06.24.2016
keywords: gui
so.topic: howto
so.client: web
so.envir: onsite
---

# Adding a textbox that displays data from a data handler

The difference between a textbox and a label is that the data displayed through the textbox can be edited by the user whereas data displayed through a label is un-editable.

This example illustrates how to shows the Contact Name below the data displayed in the **Interest** view of the **Contact** panel.

Since we plan to modify the Contact panel we need to make changes to the *SoContactPanel.config* file. The next step is to add a text box to the Interest view, which will be done using the `SoTextBox` control provided by SuperOffice.

```XML
<panel id="Contact" type="SplitterPanel" soprotocol="Contact" paneltype="Main" placeholderid="MainPlaceHolder">
  <caption>[SR_COMMON_CONTACT]: [current:contact_name]</caption>
  <cards>
    <card id="ContactMainCard" type="SoTabbedCard" placeholderid="leftpanel" cardtype="MainCard">
      <views>
        <view id="MainView" reference="MainView"></view>
        <!--Some other Code -->
        <view id="interests" type="SoView" soprotocol="interest" current="contact">
          <!--Some other Code -->
          <!--Our Code Begins here -->
          <controlgroup id="interestHeadergroup2" type="SoControlGroup" position="absolute" top="100px" left="15px" right="20px">
            <controls>
              <control id="newTextBox" type="SoTextBox" context-style="Heading" width="100%">
               <datasource>ContactEntityDataHandler.ContactEntity.Name</datasource>
              </control>
            </controls>
          </controlgroup>
          <!--Our Code Ends here -->
          <!--Some other Code -->
        </view>
      </views>
    </card>
  </cards>
</panel>
```

* We have used the `SoTextBox` user control above. For us to use the control, it should be included inside the `control` element which is inside `controls`.
* We use the `controlgroup` element to determine the position where the textbox to be placed.
* The `datasource` element inside the `control` tells us from where to retrieve the data (from the ContactEntityDataHandler).

> [!NOTE]
> A DataHandler to be used in a …Panel.Config file should be first identified in the relevant …Page.config file’s DataHandlers section.

Once the code segment is added to the *SoContactPanel.config* file, the **Interests** view would look like this:

![03][img1]

<!-- Referenced links -->
[1]:

<!-- Referenced images -->
[img1]: media/image003.jpg
