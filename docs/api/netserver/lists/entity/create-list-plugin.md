---
title: Create your own list plugin
uid: create_list_plugin
description: Create a plugin list provider
author: {github-id}
keywords:
so.topic: howto
# so.envir:
# so.client:
---

# Create your own list plugin

A plugin is an enhancement or a manipulation that you can develop to an existing NetServer feature. There are many types of plugins that you can develop. Here, we look at plugins you can develop for the various lists in SuperOffice to give your own functionality to those lists.

In SuperOffice the lists can be of mainly 2 types: lists that are constructed from a table in the database and lists that have been hard-coded.

First, let’s show you how you can develop a plugin for a list that is constructed from a table in the SuperOffice database.

This example shows how you can manipulate the country list that is constructed from the `country` table of the SuperOffice database.

[!code-csharp[CS](includes/demolist-plugin.cs)]

## MDOProviderPlugin attribute

Notice that the class is preceded by an attribute. This tells NetServer that this is a plugin and we give a specific attribute since we want to tell NetServer that this is a plugin of type MDO list provider and the name `MDOProviderPlugin` is the name that is given by NetServer for it to identify this is an MDO list plugin. The `MDOProviderPlugin` attribute must be provided with what is the list that you’re trying to enhance or manipulate as a parameter in the above example it is the country list.

> [!NOTE]
> It is paramount that we give only one list name as the parameter and that should be the exact name of the table that holds the data and it must be known at compile time.

## MDOProviderBase class

Next, we tell NetServer that we have developed a plugin to enhance or manipulate the functionality of the country list. We do this by inheriting the `MDOProviderBase` class and overriding its methods. This is the same class that NetServer uses to implement its own list. So when we override its methods, we supersede the NetServer functionality of the particular list.

When you inherit from the `MDOProviderBase` class, you have to implement the `Construct` method and the `HistoryInfo` method. Why? Because you have to specify from which table you are going to pull the Root data and from which table you are going to pull the History data. In the above example, the `Construct` method is overridden to say that the data for the list will be pulled out of the `country` table. We have also inserted a list item called Default country and likewise, you can implement the `Construct` method to suit your application purpose. So now you have enhanced the country list by adding an item to the list.

Many methods can be overridden in the `MDOProviderBase` class. For example, you can add some text to the tooltip of the list items:

```csharp
protected override string GetItemTooltip(ListTableRow row)
{
//check for the country name
  if (row.GetValue("name").ToString()  == "Norway")
  {
    //add the additional tool tip word to the already
    //existing tool tip
    return row.Tooltip + " " + "Home Country";
  }
  else
  {
    //if the another country return the default tool tip
    return row.Tooltip;
  }
}
```

## Change the data coming to the list

Now let’s look at how you can manipulate the actual data that is coming to the list. Let’s write some OSQL ([Objectified SQL][1]).

In this example, we are going to override the `GetSimpleListQuery` method of the `MDOProviderBase` class since it is where we have to define our query if we want to get some data that we want.

```csharp
private TableInfo tableInfo = null;
private ListInfo listInfo = null;
protected override ListTableRows.CustomSearch GetSimpleListQuery()
{
  //get the table info
  tableInfo = TablesInfo.GetTableInfo("country");
  //get the list info
  listInfo = tableInfo.Definition.MDOListInfo;
  //declare a query of type ListTableRows.CustomSearch
  ListTableRows.CustomSearch query = new ListTableRows.CustomSearch(tableInfo);
  //we have to set a common alias for the list item ID
  tableInfo.Definition.MDOListInfo.PrimaryKey.Alias = new Alias("ListItemId");
  //we are retrieving all the fields in the list table
  query.AdditionalReturnFields.Add(listInfo.ListTable.All);
  //lets distinct the results
  query.IsDistinct = true;
  //lets not take the deleted ones
  query.Restriction = listInfo.Deleted.Equal(S.Parameter(0));
  //order the list by the rank of each item
  query.OrderBy.Add (listInfo.Rank);
  //lets take only the countries that starts with A
  query.Restriction =
  query.Restriction.And(listInfo.Name.Like("A%"));
  //return query

  return query;
}
```

Here we filter out only the countries that start with A. See [In depth OSQL][1].

## Use plugin

Now that we have developed our plugin, let's discuss how we can use it.

### Config

How do we inform NetServer that we have developed a plugin? We have to specify in our *app.config* file that NetServer should use our new plugin instead.

Below is an example of how we have to configure our plugin in the *app.config* file.

```XML
<Factory>
  <DynamicLoad>
    <add key="PluginDemos"
    value="C:\\TestApps\\Pulgin\\Pulgin\\bin\\Debug\\Pulgin.dll" />
  </DynamicLoad>
</Factory>
```

When you declare your *plugin.dll* in the `DynamicLoad` section of the `Factory` section group of your *app.config* file, NetServer will load your DLL along with its other DLLs.

### Example

Now let’s see how we can use the developed plugin in a normal Windows forms-based application.

Here we will use the plugin that we developed to extend the functionality of the country list.

```csharp
using SuperOffice.CRM.Services;
using SuperOffice.CRM.Lists;
using SuperOffice;
using(SoSession session = SoSession.Authenticate("SAL0", ""))
{
  //get the country list. Notice that even though you have not written
  //a plugin to the country list this is the method that you will call
  //to get the country list since we have written a plugin NetServer
  //will execute our plugin instead of the NetServer one
  ISoListProvider testList = SoLists.GetCountryList();
  if (testList.RootItems.Count > 0)
  {
    listView1.View = View.List;
    listView1.ShowItemToolTips = true;
    int i = 0;
    //add the root items of the list to the list view
    foreach (SoListItem item in testList.RootItems)
    {
      listView1.Items.Add(item.Name);
      listView1.Items[i].ToolTipText =
      testList.RootItems[i].Tooltip;
      i++;
    }
  }
}
```

In the above example when we get the country list using the `GetCountryList` method of the `SoLists` class, it will create the list using the methods we overrode and it will revert to the original implementation of the methods that we did not override. So here we will only get the countries that start with the letter A.

<!-- Referenced links -->
[1]: ../../osql/index.md
