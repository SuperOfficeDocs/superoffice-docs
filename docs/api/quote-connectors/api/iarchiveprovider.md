---
title: i_archive_provider
description: IArchiveProvider
author: {github-id}       
so.date:
keywords: quote
so.topic: howto
---

# IArchiveProvider

![24][img1]

The archive provider and its associated interfaces are used to implement multi-column lists all over the SuperOffice GUI.

## GetAvailableColumns

Get the list of columns handled by this provider

## GetAvailableEntities

Get the list of entities supported by this provider

## GetReader( string )

Start the reader and return an `IDataReader` (which, as we remember, also inherits `IDataRecord` for access to individual data fields). This provides an alternative, more generic, and more standards-based interface to data. Use either `GetRows` or `GetReader` on any particular archive provider instance.

## GetResultInformation( )

Get additional information about the result, such as row count or other optional items. This method should be called after `GetRows` but before `Close`.

## GetRows( string )

Start the query and return an iterator. The `.Current` property will be a valid `ArchiveRow` containing one row, as long as a previous call to `.MoveNext` returned true. This is the standard semantics for an iterator.

## SetDesiredColumns( string[] )

Set which columns should be returned, must be a subset of the GetAvailableColumns result

## SetDesiredEntities( string[] )

## SetOrderBy( ArchiveOrderByInfo[] )

Set the sort order. Which columns should rows be ordered by.

## SetPagingInfo( int, int )

Set the paging properties of the provider. The default is to fetch page zero, of one thousand (1000) rows. A more reasonable page-size is probably around 100.

> [!NOTE]
> The query processing strategy may change for very large pages (more than 1000) and give significantly longer response times.

## SetRestriction( ArchiveRestrictionInfo[] )

Set restrictions on which rows should be returned.

## Close()

Call this method after the last desired row has been read; this gives the provider the chance to close and free any underlying queries

<!-- Referenced images -->
[img1]: media/image024.jpg
