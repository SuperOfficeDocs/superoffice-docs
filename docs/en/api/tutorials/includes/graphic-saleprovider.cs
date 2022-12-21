//Setting the Parameters that needs to be passed to Agent method 
//Parameter - providerName - The name of the archive provider to use
IArchiveProvider newSalePro = new SaleProvider();

//Parameter - columns - An array of the names of the columns wanted.
string[] columns = new string[] { "project/name", "amount", "earningPercent" };
newSalePro.SetDesiredColumns(columns);

//Parameter - entities - Which entities to include
string[] entities = new string[] { "sale", "contact" };
newSalePro.SetDesiredEntities(entities);

//Parameter - restriction - Archive restrictions
ArchiveRestrictionInfo[] archiveRest = new ArchiveRestrictionInfo[1];
archiveRest[0] = new ArchiveRestrictionInfo("contactid", "=", "113");
newSalePro.SetRestriction(archiveRest);

//Parameter - page - Page number, page 0 is the first page
//Parameter - pageSize - Page size 
int page = 1;
int pageSize = 10;
newSalePro.SetPagingInfo(pageSize, page);

//Parameter - sortOrder - Sort order for the archive
ArchiveOrderByInfo[] archiveSrtOrd = new ArchiveOrderByInfo[1];
archiveSrtOrd[0] = new ArchiveOrderByInfo("project/name",
SuperOffice.Util.OrderBySortType.DESC);
newSalePro.SetOrderBy(archiveSrtOrd);