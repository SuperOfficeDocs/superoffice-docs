---
uid: help-sv-manage-status-monitors
title: Administrera statusövervakning
description: Administrera statusövervakning
keywords: SAINT, statusövervakning
author: SuperOffice RnD
date: 02.22.2023
version: 9
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: sv
---

# Administrera statusövervakning

[!include[Requirement](../includes/note-saint-req.md)]

När du ställer in flera statusövervakningar och olika perioder/räknare, är det viktigt att regelbundet kontrollera dem för att se till att räknare och statusar återskapas och uppdateras och att [kriterierna][1] är korrekta för de olika statusarna.

Avsnitten nedan innehåller information om hur du aktiverar och inaktiverar statusövervakningar och hur du återskapar statusar och räknare. [!include[Define counter](../includes/def-counter.md)]

## Allmän information om hur du uppdaterar och återskapar statusar och räknare

Längst ned på fliken **Statusövervakning** visas indikatorer (text som visar datumet för den senaste generationen, om den valda statusen eller räknaren aldrig har genererats eller om den valda statusen ska återskapas på grund av ändringar) för återskapande av statusar eller räknare.

Du bör återskapa statusar och/eller räknare om indikatorerna visar att den senaste generationen var för länge sedan, eller att statusarna och/eller räknarna aldrig har genererats. Detsamma gäller om statusar ändras. Statusar och räknare som inte uppdateras kommer fortfarande att vara aktiverade och användbara i SuperOffice CRM, men de datum som returneras är inte nödvändigtvis korrekta. I avsnitten nedan beskriver vi hur du återskapar statusar och räknare.

### Hur man avgör om den är uppdaterad

Om en post inte är uppdaterad, visas den som ![ikon][img1] (statusar) och ![ikon][img3] / ![ikon][img4] / ![ikon][img5] (räknare) i SuperOffice CRM.

## Återskapa statusar

När du har [lagt till, redigerat eller tagit bort ett kriterium][2], eller om du till exempel har redigerat ett syfte för en uppgift i SuperOffice CRM, visas ett rött kryss i statuslistan till vänster om statusen/statusarna i fråga. Statusar markerade med ett rött kryss är inte aktiverade.

Du måste då återskapa dessa statusar genom att klicka på någon av dessa knappar:

| Ikon | Namn | Beskrivning | Plats |
|---|---|---|---|
| ![ikon][img2] | Återskapa vald statusövervakning | Välj för att återskapa den valda statusen | Längst ned på fliken **Företag**, **Kontakt** eller **Projekt** |
| ![ikon][img2] | Återskapa all statusövervakning | Välj för att återskapa alla statusar | Längst ned på fliken **Status** |

## Återskapa räknarvärden

| Ikon | Namn | Beskrivning |
|---|---|---|
| ![ikon][img2] | Återskapa alla räknare | Välj för att återskapa alla räknare |

<!-- Referenced links -->
[1]: ../../search-options/learn/search-criteria.md
[2]: select-status-criteria.md

<!-- Referenced images -->
[img1]: ../../../media/icons/admin/status-inactive.png
[img2]: ../../../media/icons/arrow-right.png
[img3]: ../../../media/icons/admin/saint-counter-company-dis.png
[img4]: ../../../media/icons/admin/saint-counter-project-dis.png
[img5]: ../../../media/icons/admin/saint-counter-sale-disabled.png
