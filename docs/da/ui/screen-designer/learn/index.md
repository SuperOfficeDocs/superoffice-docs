---
uid: help-da-screen-designer
title: Skærmdesigner
description: Få mere at vide om, hvordan du konfigurerer dine skærmbilleder i denne vejledning.
keywords: Skærmdesigner, layout, skærmbillede, tilpasningsmulighed
author: Bergfrid Dias
date: 10.29.2024
version: 10.3.11
topic: concept
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Skærmdesigner <i class="ph ph-squares-four" aria-hidden="true"></i>

**Skærmdesigneren** i SuperOffice CRM giver dig mulighed for at tilpasse layoutet af dine primære skærmbilleder inden for applikationen, så udseende opfylder de specifikke behov hos forskellige brugergrupper i din organisation. Denne funktion erstatter det gamle [PageBuilder][9]-værktøj og tilbyder en mere strømlinet og fleksibel måde at konfigurere skærme på – uden behov for kodning.

![Skærmdesigner, virksomhedskort, standard feltlayout -screenshot][img5]

> [!NOTE]
> Denne funktion kræver licensen Developer Tools og funktionsretten "Feltadministrator".

## Hvorfor bruge Skærmdesigneren?

SuperOffice CRM leveres med standardlayouts for person-, virksomheds-, salgs-, projekt- og sagsskærme og opfølgningsdialogen. Dog har forskellige teams ofte forskellige informationsbehov. Ved at bruge skærmdesigneren kan du:

* Oprette egne layouts, der er skræddersyet til arbejdsprocesserne og prioriteterne for specifikke brugergrupper (såsom salg, support, ledelse).

* Forbedre effektiviteten ved at give dine teams hurtig adgang til den information, der er vigtigst for dem.

* Fjerne unødvendige felter, tilføje nye og omorganisere information i logiske grupper ved hjælp af faner, kolonner og etiketter.

For eksempel, hvis dit salgsteam fokuserer på kundeinteraktioner, kan du sikre, at kontaktoplysninger vises fremtrædende, mens mindre relevante felter flyttes til sekundære faner.

## Hvad kan jeg tilpasse?

Med Skærmdesigneren kan du:

* Ændre standardlayoutet for skærme for alle brugere eller oprette egne layouts for specifikke brugergrupper.

* Designe layouts optimeret til specifikke projekttyper, salgstyper, sagstyper, opfølgningstyper og dokumentskabeloner.

* Skjule felter, der aldrig bruges.

* Fremhæve nøgledata ved at formatere felter (f.eks. fed eller stor skrift).

* Tilføje knapper og links til at udløse automatiserede processer (CRMScript) eller eksterne opslag.

* Organisere brugerdefinerede felter under fanen **Mere** eller andre brugerdefinerede faner.

* Tilføje, omarrangere eller fjerne faner efter behov.

## Hvilke skærme kan jeg konfigurere?

Du kan tilpasse følgende skærme og dialoger:

* Virksomhed
* Person
* Salg
* Projekt
* Sag
* Opfølgningsdialog
* Dokumentdialog

## Hvordan fungerer layouts?

Layouts i SuperOffice CRM styrer, hvordan information præsenteres for brugerne. Standardlayouts (system) anvendes på alle brugere, medmindre et brugerdefineret layout er oprettet og tildelt en specifik brugergruppe.

* **Egne layouts:** Opret layouts, der er specifikt skræddersyet til behovene hos brugergrupper.

* **Layouttildeling:** Layouts for salgs-, projekt- og sagsskærme kan yderligere tilpasses ved at tildele dem specifikke salgstyper, projekttyper og sagstyper. Tilsvarende kan Opfølgningsdialogen tildeles opfølgningstyper, og Dokumentdialogen kan tildeles dokumentskabeloner.

* **Layoutstatus:** Layouts kan være i en *kladde* eller *udgivet* tilstand. Udgivne layouts er markeret med de tildelte brugergrupper/typer.

![Skærmdesigner kladdelayout -screenshot][img3]

![Skærmdesigner udgivet layout -screenshot][img4]

Listen **Layouts** viser alle eksisterende layouts, inklusive en forhåndsvisning af skærmen.

## Arbejde med Skærmdesigneren

For at begynde at tilpasse skærme:

1. Åbn skærmdesigneren ved at klikke på ![icon][img2], vælge **Indstillinger og vedligeholdelse** og derefter vælge **Skærmdesigner** fra navigatoren.

2. Træk og slip felter i editoren for at tilføje dem til dit layout.

3. Klik på et felt for at flytte det eller opdatere dets indstillinger. De tilgængelige indstillinger afhænger af den valgte felttype.

### Layoutkomponenter

* **Felter:** Viser alle datafelter, der er tilgængelige for det valgte skærmlayout. Brug filtre til hurtigt at finde specifikke felter.

* **Elementer:** Indeholder ikke-databaserede elementer som etiketter, delere, links og knapper.

* **Indstillinger:** Giver mulighed for at tilpasse udseendet og opførslen af det valgte felt.

* **Fanelayout:** Giver muligheder for at arrangere felter og elementer i kolonner.

* **Faner:** Kan tilføjes, omarrangeres eller slettes for at organisere information logisk.

> [!NOTE]
> Efter at et layout er blevet udgivet, skal brugerne i de tildelte grupper logge ud og logge ind igen for at se ændringerne.

## Hvad hvis jeg ikke bruger Skærmdesigneren?

Hvis du ikke har en licens til udviklingsværktøjer, organiserer fanen **Mere** automatisk alle brugerdefinerede felter i to kolonner. Denne standardopsætning giver stadig et funktionelt udseende, men uden de avancerede tilpasningsmuligheder, der er tilgængelige gennem skærmdesigneren.

## Resumé

Ved at tilpasse skærmlayouts med skærmdesigneren kan du eliminere unødvendige oplysninger, hvilket gør skærmen mere ryddelig og effektiv for dine teams. For eksempel, hvis dit supportteam ikke har brug for at få vist virksomhedens adresse fremtrædende, kan du flytte den til en sekundær fane, hvilket frigør plads til mere relevante felter.

## Relateret indhold

* [Tilføj layout][2]
* [Rediger layout][1]
* [Arbejde med felter][4]
* [Arbeode med arkiver (detaljekort)][3]

<!-- Referenced links -->
[1]: edit-layout.md
[2]: add-layout.md
[3]: working-with-archives.md
[4]: working-with-fields.md
[9]: ../../../../en/ui/web-app/pagebuilder/index.md

<!-- Referenced images -->
[img2]: ../../../../media/icons/btn-menu.png
[img3]: ../../../../media/loc/en/ui/status-draft.png
[img4]: ../../../../media/loc/en/ui/status-published.png
[img5]: ../../../../media/loc/en/ui/edit-card-layout-fields.png
