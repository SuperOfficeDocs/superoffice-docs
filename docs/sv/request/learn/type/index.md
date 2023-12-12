---
uid: help-sv-request-type
title: Ärendetyp
description: Ärendetyp
author: Bergfrid Dias
so.date: 12.12.2023
so.version: 10.2.11
keywords: ärende, typ
so.topic: concept
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: sv
---

# Ärendetyp

Alla ärenden som är registrerade i SuperOffice har en typ. Standardtypen är "Request". För att se, lägga till, uppdatera och ta bort ärendetyper, gå till **Inställningar och underhåll**.

> [!NOTE]
> Den här funktionen kräver en Service Premium användarplan (för att skapa och uppdatera ärendetyper) och en Development Tools licens för att definiera skärmlayouter baserat på ärendetyper i Screen Designer. (Endast tillgängligt i pilot.)

## Varför använda ärendetyper?

Den huvudsakliga fördelen med ärendetyper är effektiv support. En specifik ärendetyp riktar in sig på en uppsättning attribut som behövs för en specifik process.

## Exempel

Finansteamet använder ärenden för att hantera inkommande fakturakrav och kräver synlighet av fakturanumret som ett angivet fält. Å andra sidan använder säljteamet ärender för att hantera inkommande leads. I fall där en ärende gäller ett lead har fakturanumret ingen relevans och bör helt uteslutas från synfältet.

## Var hittar jag ärendetyperna?

* I **Inställningar och underhåll**, välj **Ärenden** i navigatören och sedan fliken **Ärendetyper**.

[!include[Restricted access](../../../learn/includes/note-insufficient-rights.md)]

## Inställningar

| Inställning | Beskrivning |
|---|---|
| Namn | Namnet på ärendetypen. |
| Beskrivning | Förklarar syftet med ärendetypen.|
| Ikon | Används som en visuell etikett för att visa typen. Välj från en uppsättning fördefinierade alternativ. Standard: biljettikon.|
| Använd som standard | Indikerar om detta är standardtypen för nya ärender. |
| Tillgängliga statusar | En delmängd av ärendestatusar som är relevanta för denna typ. Används för att filtrera rullgardinslistan i användargränssnittet. Tomt fält innebär att alla statusar är tillgängliga. |
| Standardstatus | Den [statusen][4] som ställs in när en agent skapar ett nytt ärende. Har företräde framför andra preferenser. Obligatorisk om **Tillgängliga statusar** är inställda. |
| Tillgängliga prioriteringar | En delmängd av ärendeprioriteringar som är relevanta för denna typ. Används för att filtrera rullgardinslistan i användargränssnittet. Tomt fält innebär att alla prioriteringar är tillgängliga. |
| Standardprioritet | Den [prioriteten][3] som ställs in när en agent skapar ett nytt ärende. Har företräde framför andra preferenser. Obligatorisk om **Tillgängliga prioriteringar** är inställda. |
| Svarsmall | Den [svarsmall][5] som kommer att användas när en agent svarar på entt ärende av denna typ. |

## Relaterat innehåll

* [Skapa ärendetype][1]
* [Ta bort ärendetype][2]

<!-- Referenced links -->
[1]: create.md
[2]: delete.md
[3]: ../priority/index.md
[4]: ../status/index.md
[5]: ../../reply-templates/learn/index.md

<!-- Referenced images -->
