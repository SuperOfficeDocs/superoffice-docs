---
uid: help-sv-request-type
title: Ärendetyp
description: Lär dig mer om ärendetyper i SuperOffice Service.
keywords: ärendetyp, ärendetyper, fliken Ärendetyper, typ, ärende
author: Bergfrid Dias
date: 02.25.2025
version: 10.5.2
content_type: concept
license: servicepremium
audience: settings
audience_tooltip: Inställningar och underhåll
language: sv
redirect_from: /sv/request/learn/type/index
index: true
---

# Ärendetyp

Alla ärenden som registreras i SuperOffice har en typ. Standardtypen är "Request". För att se, lägga till, uppdatera och ta bort ärendetyper, gå till **Inställningar och underhåll**.

> [!NOTE]
> Den här funktionen kräver en Service Premium-användarplan (för att skapa och uppdatera ärendetyper) och en Development Tools-licens för att definiera skärmlayouter baserat på ärendetyper i Screen Designer.

## Varför använda ärendetyper?

Huvudfördelen med ärendetyper är att de möjliggör effektiv support. En specifik ärendetyp riktar sig mot en uppsättning egenskaper som behövs för en specifik process.

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

* [Skapa ärendetyp][1]
* [Ta bort ärendetyp][2]

<!-- Referenced links -->
[1]: create.md
[2]: delete.md
[3]: ../priority/index.md
[4]: ../status/index.md
[5]: ../../../knowledge-base/learn/reply-templates/index.md
