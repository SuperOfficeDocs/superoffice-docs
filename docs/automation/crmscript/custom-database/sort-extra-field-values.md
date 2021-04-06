---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
uid: sort_extra_field_values       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
title: Sorting CS extra fields list values # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: David Hollegien
so.date: 06.19.2018
keywords:
so.topic: howto               # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir:           # cloud or onsite
so.client:               # online, web, win, pocket, or mobile
---

# Sorting CS extra fields list values

We have had multiple requests from customers to sort the list values of an customer service extra field alphabetically.

Since Customer Service doesn't have the same udlist system as sales, this is a bit more work to do by hand, so why not automate it?

We have developed a small script which automatically sorts all list option values alphabetically:

```crmscript
#setLanguageLevel 3;

// alphabetically sort the list values of an text field
// domain = domain of the extra_field, 4 = ticket, can be set to 0 to disable criteria
// extraTableId = Id of the extra table that the field is from,  can be set to 0 to disable criteria
// fieldName = name of the field, without the table prefix, example : x_product
// returns false when field not found, otherwise true
Bool sortExtraFieldOptions(Integer domain, Integer extraTableId, String fieldName){
  // Get current field params
  SearchEngine extraFieldParamSearch;

  extraFieldParamSearch.addField("extra_fields.id");
  extraFieldParamSearch.addField("extra_fields.params");

  if (domain > 0) {
    extraFieldParamSearch.addCriteria("extra_fields.domain", "OperatorEquals", domain.toString());
  }

  if (extraTableId > 0) {
    extraFieldParamSearch.addCriteria("extra_fields.target_extra_table", "OperatorEquals", extraTableId.toString());
  }

  extraFieldParamSearch.addCriteria("extra_fields.field_name", "OperatorEquals", fieldName);

  extraFieldParamSearch.setLimit(1);
  extraFieldParamSearch.execute();
  if (!extraFieldParamSearch.eof()) {
    // params are split by \n
    String[] parameters = extraFieldParamSearch.getField("extra_fields.params").split("\n");
    // use map since the keys are automatically sorted alphabetically on insert
    Map sortedOptions;
    // string array of the existing parameters that aren't list options + the options now sorted alphabetically
    String[] newParameters;
    for (Integer i = 0; i < parameters.length(); i++) {
      // get the parameter value, make sure we don't have an \n in it since it the \n is used as parameter delimiter
      String parameter = parameters[i].stripLeadingAndTrailing("\n");
      // if parameters starts with 'option=' it means this is a list option parameter
      if (parameter.beginsWith("option=")) {
        // get the list option value
        String option = parameter.after("option=");
        sortedOptions.insert(option, "");
      }
      else // none list option parameter, add directly to new parameters array {
        newParameters.pushBack(parameter + "\n");
      }
    }
    // add the now sorted list values back as option parameter
    for (sortedOptions.first(); !sortedOptions.eof(); sortedOptions.next()) {
      newParameters.pushBack("option=" + sortedOptions.getKey() + "\n");
    }
    String newParametersString;
    // concat the new parameters back to a single string
    for (Integer i = 0; i < newParameters.length(); i++) {
      newParametersString += newParameters[i];
      print(newParameters[i]);
    }
    // update params in the database
    SearchEngine extraFieldParamUpdate;
    extraFieldParamUpdate.addData("extra_fields.params", newParametersString);
    extraFieldParamUpdate.addCriteria("extra_fields.id", "OperatorEquals", extraFieldParamSearch.getField("extra_fields.id";     
  
    extraFieldParamUpdate.update();
  
    return true;
  } 
  return false;
}
```

Example usage:

```crmscript
sortExtraFieldOptions(4, 0, "x_area");
```

> [!NOTE]
> Use the flush cache option in `rms.fcgi?action=debug` if you don't see the changes reflected in CS.

Hope this is useful for others!
