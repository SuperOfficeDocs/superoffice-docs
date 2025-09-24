---
uid: help-da-saint-admin
title: SAINT i Indstillinger og vedligeholdelse
description: Lær om nøglebegreberne i SuperOffice SAINT, herunder kriterier, billeder, tællere og standardopfølgninger.
keywords: SAINT, aktivitetsovervågning, statusovervågning
author: SuperOffice Product and Engineering
date: 09.23.2025
version: 10.5
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
language: da
index: true
redirect_from: /da/sale/saint/learn/admin/index
---

# SAINT i Indstillinger og vedligeholdelse

SAINT (Sales Intelligence) hjælper dig med at overvåge firmaer, personer og projekter, så du kan følge op på det rigtige tidspunkt. En **aktivitetsovervågning** (også kendt som statusovervågning) kombinerer kriterier, tællere og valgfrie egenskaber for at fremhæve poster, der kræver opmærksomhed.

Før du implementerer SAINT, er det vigtigt at vide, hvad du ønsker at forbedre, og hvordan du vil analysere det. Overvej derefter, hvilke proaktive handlinger dit firma kan tage for at forbedre den nuværende situation. For eksempel:

* Sende en gruppeudsendelse
* Ringe til alle kunder i SAINT-udvalget
* Følge op på alle sager

[!include[Requirement](../includes/note-saint-req.md)]

![SAINT-skærm med statusliste, beskrivelse, billede og kriterier -screenshot][img1]

## Statuslisten

Statuslisten på fanerne **Firma**, **Person** og **Projekt** viser aktive statusmonitorer for den post og – hvis **Vis slettede** er markeret – også slettede.

| Element | Beskrivelse |
|---|---|
| **Visualiser-ikon** <i class="ph ph-eye" aria-label="eye"></i> | Angiver, om der vises et statusbillede på firma-, person- eller projektkort. Ikonet vises kun, hvis afkrydsningsfeltet **Visualiser** er markeret. |
| **Rødt X** | Vises ved siden af statusser, der skal [regenereres][8]. Disse statusser opdateres ikke og returnerer ikke aktuelle data. |
| **Navnekolonne** | Viser navnene på statusserne. Slettede statusser vises med rødt, hvis **Vis slettede** er markeret under listen. |
| **Prioritetskolonne** | Bestemmer hvilket statusbillede der vises på kortet, når et firma, en person eller et projekt matcher kriterierne for flere statusser. Statussen med højeste prioritet vises, mens andre aktive statusser er tilgængelige som links i statusdialogen. |

## Statusegenskaber

En statusovervågning kombinerer flere egenskaber, der definerer, hvordan den fungerer:

* **Kriterier:** Hver status skal indeholde et eller flere kriterier. Disse betingelser bestemmer, hvilke firmaer, personer eller projekter statussen gælder for. Du kan f.eks. definere en status for kunder uden salg i de seneste 90 dage.

* **Statusbilleder:** Et valgfrit billede kan vises på firma-, person- eller projektkort, der opfylder kriterierne. F.eks. kan et spindelvæv indikere inaktivitet. Billeder vises som lyse vandmærker og kan klikkes for flere detaljer.

* **Standardopfølgning:** Når en bruger klikker på statussen, kan de oprette en opfølgning. Typen og beskrivelsen kan være foruddefineret, så opfølgningen tydeligt angiver, hvilken handling der kræves.

## Tællere og perioder

Tællere [sporer aktivitet over tid][5], såsom salg, sager eller gennemførte opfølgninger.
Du kan bruge tællere i søgninger og udvalg til at identificere poster, der opfylder eller ikke opfylder bestemte tærskler.

Du kan definere op til tre forskellige perioder (f.eks. 30, 60 og 90 dage).
Dette lader dig anvende den samme tæller, såsom "Antal salg", på forskellige tidsintervaller.

## <a id="database"></a>Hvordan SAINT gemmer tællere og statusser

SAINT-tællere gemmes i [countervalue][13]-tabellen og opdateres automatisk, når du gør ting:

* Når SAINT er aktiveret, oprettes der en række tællerlinjer, hver gang en person eller et projekt oprettes.

* Når en opfølgning, et dokument eller et salg oprettes, opdateres de tilsvarende tællerlinjer.

SAINT-**værdier** er simple binære værdier (til eller fra), der bestemmer udseendet af firma- og projektkortene. Disse værdier gemmes i [statusvalue][14]-tabellen.

## Relateret indhold

* [Opsæt en ny statusovervågning][1]
* [Visualiser statusser med billeder][2]
* [Tællere og tællerindstillinger][5]
* [Opdater, slet og gendan statusovervågninger][7]
* [Regenerer statusovervågninger og tællere][8]

<!-- Referenced links -->
[1]: set-up.md
[2]: set-up.md#image
[5]: counter-settings.md
[7]: update.md
[8]: update.md#regen
[13]: ../../../en/database/tables/countervalue.md
[14]: ../../../en/database/tables/statusvalue.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/saint/status-monitors-company-tab.png
