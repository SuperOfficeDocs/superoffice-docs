<!-- markdownlint-disable-file MD041 -->
> [!NOTE]
> Registry propagation does not work for Office 2013 in SuperOffice versions below 7.5.

The requirement to get the ribbon components, a user needs to have the AddIns registered in the `HKEY_CURRENT_USER` hive of the registry. Since we don’t know who will log in (and new users can be added later on), there is no way for us to write anything to these areas in the registry when we install SuperOffice.

The way we’ve solved this is to register the necessary keys under the `HKEY_LOCAL_MACHINE` hive in the registry (64-bit machine).

These keys contain the values that will be copied to the `HKEY_CURRENT_USER` keys for a user when he/she starts Microsoft Office programs. **These keys will be written AFTER any login scripts have been run, so it is impossible to remove them using such a script**.

The problem with the above solution is that for every user that logs in and starts any of the Microsoft Office programs, these registry keys will be copied to their local `HKEY_CURRENT_USER` registry hive and they will get a question asking them if they want to install SuperOffice Ribbons/MailLink.
