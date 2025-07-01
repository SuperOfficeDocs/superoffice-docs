---
uid: help-nl-import-routines
title: Importroutines
description: Importroutines
author: SuperOffice RnD
date: 06.29.2022
keywords: Windows Client-instellingen
content_type: concept
language: nl
platform: win
deployment: onsite
---

# Importroutines

U moet rekening houden met de volgende twee belangrijke punten voordat u gegevens importeert:

* Als u een bestaande SuperOffice-database hebt waarin u gegevens wilt importeren, moet u een reservekopie maken voordat u begint. Als er iets fout gaat tijdens het importeren, kunt u beter opnieuw beginnen met het oorspronkelijke databasebestand. (Zie[Routines voor het maken van reservekopieën][8].)

* Het gegevensbestand dat u importeert, moet een tekstbestand zijn, en wel een Windows [ANSI-bestand][1]. Dat betekent dat u een klantenindex, die bijvoorbeeld is opgeslagen in een Excel-werkblad, moet opslaan als een tekstbestand voordat u de gegevens ervan kunt importeren in de SuperOffice-database. U kunt de bestandsindeling controleren door het bestand te openen in Excel. Het bestand moet de extensie **TXT** hebben (bijvoorbeeld **IMPORT.TXT**) en u moet weten in welke map het bestand staat.

> [!NOTE]
> U kunt geen bestanden met velden met een vaste lengte in de SuperOffice-database importeren als er geen scheidingstekens tussen de velden staan.

## Verwante onderwerpen

* [ANSI-bestanden][1]
* [Bestanden importeren][2]
* [Veldtoewijzing][3]
* [Geavanceerde importinstellingen opgeven][4]
* [Duplicaten][5]
* [Importbeschrijvingen][6]
* [Informatie in de database bijwerken][7]

<!-- Referenced links -->
[1]: ansi-files.md
[2]: importing-files.md
[3]: field-mapping.md
[4]: specifying-advanced-import-settings.md
[5]: duplicates-import.md
[6]: import-descriptions.md
[7]: ../update-database.md
[8]: ../backup-routines.md

<!-- Referenced images -->
