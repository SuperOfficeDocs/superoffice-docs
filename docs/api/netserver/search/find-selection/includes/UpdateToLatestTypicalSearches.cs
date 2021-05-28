public void UpdateToLatestTypicalSearches()
{
    int currentVersion = GetHeighestVersionNumberFromDatabase();
    bool currentIsOld = AreThereNewerTypicalSearches(currentVersion);

    if (!currentIsOld)
        return;

    var importedData = GetTypicalSearchDataFromFile("C:\filepathOfJsonFile");

    List<TypicalSearchRow> toBeAdded = GetTypicalSearchRowsFromData(importedData);

    List<TypicalSearchRow> toBeDeleted = GetTypicalRowsFromDatabase();

    List<TypicalSearchRow> toBeUpdated = new List<TypicalSearchRow>();

    foreach (TypicalSearchRow newRow in toBeAdded)
    {
        foreach (TypicalSearchRow oldRow in toBeDeleted)
        {
            if (oldRow.Title ==  newRow.Title &&
                oldRow.Entity == newRow.Entity)
            {
                toBeAdded.Remove(newRow);
                toBeDeleted.Remove(oldRow);

                if (oldRow.VersionNumber != newRow.VersionNumber)
                {
                    TypicalSearchRow updatedRow = UpdateOldRowWithNewData(oldRow,newRow);

                    toBeUpdated.Add(updatedRow);
                }
                break;
            }
        }
    }
    Database.Add(toBeAdded);
    Database.Remove(toBeDeleted);
    Database.Update(toBeUpdated);
}