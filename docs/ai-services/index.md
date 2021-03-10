---
title: AI Services       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description:                    # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: AnthonyYates             # Your GitHub alias.
keywords: AI
so.topic: guide,howto   # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
so.client: online                # online, web, win, pocket, or mobile
---

# How to setup and configure Categorization AI Service

Categorization uses Machine learning for learning which category a request in SuperOffice Service should have, to automate more of the manual processing our users spend time on today.

For the system to form an opinion on/learn how to automatically categorize between the selected categories the system needs to be trained. This trains the system into understanding how to categorize the selected request . 

When the machine has learned how to categorize and the user navigates to a request, there will be a link in the request footer with the text: Suggested category: "category/name". When user clicks the link, the request will be updated with the suggested category, and the suggestion link disappears.

![x][img1]

Pre-requisites
--------------

*   Use CRM Online and have [signed up for the SuperOffice AI Pilot Program](https://community.superoffice.com/en/customer/news/pilot-programs/sign-up-pilot-programs/?action=formFrame&formId=F-MITXUrxp)
*   Complete or Service user plan

Configure SuperOffice
---------------------

To be able to take advantage of these services, SuperOffice Service must be in use.

For the system to form an opinion on/learn how to automatically categorize between the selected categories the system needs to be trained. This trains the system into understanding how to categorize the selected tickets. 

> [!NOTE]
> To be able to choose a selection of requests to teach the system how to categorize requests, you must first create a selection of requests in SuperOffice Sales.

The Machine learning categorization service is enabled in Settings and Maintenance:

### 1. Create a selection of request to use for analyzis

*   Open Sales client
*   Create a selection of request to use for analyzis
    *   Click either Find or New -> Selection
*   Creat a Selection type: Request
    *   Either click "Find Request" or choose a selection from "Typical searches"
*   Update criteria
    *   Select your criteria to match the selection for request you want to use for analyzis
    *   Click \[Find\]
*   Save selection
    *   Click \[Save as selection\]
    *   select "Static selection" or "Dynamic selection"
    *   Input a name
    *   Click \[Save\]

> [!NOTE] 
> There is a limit on 5000 requests. If the selection is larger, we only do the analysis for the first 5000 requests.

![x][img2]

![x][img3]

![x][img4]

![x][img5]

![x][img6]

![x][img7]

![x][img8]

### 2. Choose the selection of request to use for analyzis

*   Open Settings and Maintenance
*   Click "AI services" in the menu
*   Under "Categorization": choose the selection of requests to teach the system
*   Click the dropdown to select item
*   Search for the selction-name to choose it.
    *   Note: you need to have created a selection of request in the Sales client. See step # 1 above.

![x][img9]

![x][img10] 
  
### 3. Analyze requests

*   Click \[Analyze Requests\] button to start the analyzis.

When a request selection has been chosen, the \[Analyze Requests\] button is enabled.  
  
\[Analyze Requests\] button sends the selection to the analyze service.  
  
**This analysis will take time!** Large selection can take days.  
  
When the "Latest training" say 'successfully trained model', the "Use AI to suggest categories" checkbox is enabled.:  

![x][img11]
  
\- if you get an error here, you will need to train the dataset again based upon the feedback in the error message.  
Here are some examples of the different feedback you can get of the latest training:  
  
![x][img12]

In case of errors and other experiences - we would like to get your input and feedback. Please post your experiences on the Pilot Forum.

### 4. Select options

*   Click the checkbox "Use AI to suggest categories" if you want the system to suggest categories

![x][img13] 

### 5. Done

*   The setup is complete. New requests will be analyzed to indentify if there is a suggested category for it.
*   When the users navigates to a request, there will be a link if there is a suggested category, in the request footer with the text: Suggested category: "category/name". When user clicks the link, the request will be updated with the suggested category, and the suggestion link disappears.
    *   if there is no suggested category by the AI - there wil not be a suggestion link.

## Re-Configure

*   Open Settings and Maintenance
*   Click AI services in the menu
*   Under "Categorization", click the dropdown for "select item"
*   Search for the selction-name to choose it
*   Click \[Analyze Requests\] button to start the analyzis.

<!-- Referenced images -->
[img1]: media/suggested-category-demo.png
[img2]: media/selection-option.png
[img3]: media/find-request-menu.png
[img4]: media/find-request-search-criteria.png
[img5]: media/save-as-selection-buttons.png
[img6]: media/select-selection-type-dialog.png
[img7]: media/name-selection-input.png
[img8]: media/save-button.png
[img9]: media/admin-nagigator-buttons.png
[img10]: media/select-category-menu.png
[img11]: media/categorization-analysis.png
[img12]: media/categorization-summary.png
[img13]: media/use-ai-suggested-categories-checkbox.png