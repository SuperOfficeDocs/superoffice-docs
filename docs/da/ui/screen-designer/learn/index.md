---
uid: help-da-screen-designer
title: Skærmdesigner
description: "Få mere at vide om, hvordan du konfigurerer dine skærmbilleder i denne vejledning."
author: SuperOffice RnD
date: 01.02.2024
version: 10.2.11
keywords: skærmdesigner
topic: concept
language: da
audience: settings
audience_tooltip: Settings and maintenance
---

# Skærmdesigner ![icon][img1]

**Skærmdesigneren** i SuperOffice CRM giver dig mulighed for at tilpasse layoutet af nøgleskærme inden for applikationen, så grænsefladen opfylder de specifikke behov hos forskellige brugergrupper i din organisation. Denne funktion erstatter det gamle [PageBuilder][9]-værktøj og tilbyder en mere strømlinet og fleksibel måde at konfigurere skærme på – uden behov for kodning.

![Skærmdesigner, virksomhedskort, standard feltlayout -screenshot][img5]

> [!NOTE]
> Denne funktion kræver licensen Developer Tools og rettigheden "Feltadministrator".

## Hvorfor bruge Skærmdesigneren?

SuperOffice CRM leveres med standardlayouts for kontakt-, virksomheds-, salgs-, projekt- og anmodningsskærme og opfølgningsdialogen. Dog har forskellige teams ofte forskellige informationsbehov. Ved at bruge skærmdesigneren kan du:

* Oprette brugerdefinerede layouts, der er skræddersyet til arbejdsprocesserne og prioriteterne for specifikke brugergrupper (såsom salg, support, ledelse).
* Forbedre effektiviteten ved at give dine teams hurtig adgang til den information, der er vigtigst for dem.
* Fjerne unødvendige felter, tilføje nye og omorganisere information i logiske grupper ved hjælp af faner, kolonner og etiketter.

For eksempel, hvis dit salgsteam fokuserer på kundeinteraktioner, kan du sikre, at kontaktoplysninger vises fremtrædende, mens mindre relevante felter flyttes til sekundære faner.

## Hvad kan jeg tilpasse?

Med Skærmdesigneren kan du:

* Ændre standardlayoutet for skærme for alle brugere eller oprette brugerdefinerede layouts for specifikke brugergrupper.
* Designe layouts optimeret til specifikke projekttyper, salgstyper og anmodningstyper.
* Skjule felter, der aldrig bruges.
* Fremhæve nøgledata ved at formatere felter (f.eks. fed eller stor skrift).
* Tilføje brugerdefinerede knapper og links til at udløse automatiserede processer (CRMScript) eller eksterne opslag.
* Organisere brugerdefinerede felter under fanen **Mere** eller andre brugerdefinerede faner.
* Tilføje, omarrangere eller fjerne faner efter behov.

## Hvilke skærme kan jeg konfigurere?

Du kan tilpasse følgende skærme og dialoger:

* Virksomhed
* Kontakt
* Salg
* Projekt
* Anmodning
* Opfølgningsdialog

## Hvordan fungerer layouts?

Layouts i SuperOffice CRM styrer, hvordan information præsenteres for brugerne. Standardlayouts (system) anvendes på alle brugere, medmindre et brugerdefineret layout er oprettet og tildelt en specifik brugergruppe.

* **Brugerdefinerede layouts**: Opret layouts, der er specifikt skræddersyet til behovene hos brugergrupper.
* **Layouttildeling**: Layouts for salgs-, projekt- og anmodningsskærme kan yderligere tilpasses ved at tildele dem specifikke salgstyper, projekttyper og anmodningstyper.
* **Layoutstatus**: Layouts kan være i en *kladde* eller *udgivet* tilstand. Udgivne layouts er markeret med de tildelte brugergrupper.

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
* **Fanebladslayout:** Giver muligheder for at arrangere felter og elementer i kolonner.
* **Faner:** Kan tilføjes, omarrangeres eller slettes for at organisere information logisk.

> [!NOTE]
> Efter at et layout er blevet udgivet, skal brugerne i de tildelte grupper logge ud og logge ind igen for at se ændringerne.

## Hvad hvis jeg ikke bruger Skærmdesigneren?

Hvis du ikke har en licens til udviklingsværktøjer, organiserer fanen **Mere** automatisk alle brugerdefinerede felter i to kolonner. Denne standardopsætning giver stadig en funktionel grænseflade, men uden de avancerede tilpasningsmuligheder, der er tilgængelige gennem skærmdesigneren.

## Resumé

Ved at tilpasse skærmlayouts med skærmdesigneren kan du eliminere unødvendige oplysninger, hvilket gør grænsefladen mere ryddelig og effektiv for dine teams. For eksempel, hvis dit supportteam ikke har brug for at få vist virksomhedens adresse fremtrædende, kan du flytte den til en sekundær fane, hvilket frigør plads til mere relevante felter.

## Relateret indhold

* [Tilføj layout][2]
* [Rediger layout - Hovedkort][1]
* [Arbejde med felter][4]
* [Arbejde med arkiver (afsnitsfaner)][3]

## original

Funktionen Skærmdesigner giver dig mulighed for at konfigurere dine primære skærmbilleder i SuperOffice CRM. Du kan oprette forskellige skærmlayouts til forskellige brugergrupper, afhængigt af deres informationsbehov og workflows. Dette vil hjælpe din organisation til at være mere effektiv og fokusere på det, der betyder mest.

> [!NOTE]
> Skærmdesigner (konfigurerbare skærmbilleder) kræver licensen Developer Tools. Brugen af denne funktion kræver funktionsretten "Feltadministrator".

Person- og firmakortene/skærmbillederne i SuperOffice CRM leveres med et standardlayout, men du kan redigere dem eller oprette dine egne layouts. Da forskellige brugergrupper ofte bruger person- og firmakortene forskelligt, kan det være en god idé at oprette forskellige layouts for hver brugergruppe.

Skærmdesigner gør det muligt for dig at fjerne unødvendige felter og/eller oprette nye, mere relevante felter. Du kan også gruppere felterne i faner eller kolonner og tilføje dine egne overskrifter (kaldet "ledetekster"). Hvis du finder nogle af fanerne unødvendige, kan du nemt fjerne dem eller erstatte dem med de faner, der passer bedre til din organisation.

Dit salgsteam, supportteam og ledelsesteam har ikke nødvendigvis samme fokus og krav vedrørende de data, de som oftest skal have adgang i SuperOffice. Løsningen er at oprette brugerdefinerede skærme til hvert team. Din organisation sparer tid ved at give dine teams mulighed for hurtigere at finde relevante oplysninger. Konfigurer layoutet på dine hovedskærme og arkiver (detaljekort), og definer hvilke informationstyper hvert team (brugergruppe) kan få adgang til og se på skærmene for Firma, Person, Salg, Projekt, og Sag og **Opfølgning**-dialogen.

* Flyt de vigtigste felter til den første fane.
* Brug kolonner, etiketter/titler og skilleelementer til at organisere oplysninger i logiske grupper.
* Formatér felter til at fremhæve nøgledata (for eksempel fed og stor skrifttype) for bedre synlighed.
* Flyt mindre vigtige felter til sekundære faner.
* Fjern felter, der aldrig bruges.
* Tilføj links/knapper til at finde oplysninger på andre websteder eller manuelt udløse en automatiseret proces baseret på CRMScript.

> [!NOTE]
> Når denne funktion er aktiveret, ændres felterne på din aktuelle fane **Mere** for skærmbillederne Firma, Person, Salg, Projekt og Sag, så de danner to kolonner. Du kan [redigere disse faner][1] i skærmdesigneren.

Du kan oprette tilpassede skærmlayout til kortene for firma, person, salg, projekt, og sag og **Opfølgning**-dialogen. Listen **Layout** viser alle eksisterende skærmlayout (normalt standardlayoutet) med en forhåndsvisningsskærm til højre.

Layouterne er markeret med status (udgivet eller kladde) og de tildelte brugergrupper.

Et tilpasset layout til skærmbillederne Person og Firma gør det muligt for dine teams og din organisation at arbejde mere effektivt, da det eliminerer den distraherende "informationsstøj".

Hvis dit supportteam for eksempel sjældent bruger firmaadressen, når de kommunikerer med firmaer og personer, vil du gerne gøre plads til andre felter, der er vigtigere på den første side (fanen Firma). Flyt den ved at klikke på bjælkerne i venstre side af feltet og trække den over til fanen **Mere**.

## Hvad ønsker du at foretage dig nu?

* [Tilføj nyt layout][2]
* [Rediger layout – Hovedkort][1]
* [Rediger layout – Arkiver (detaljekort)][3]

<!-- Referenced links -->
[1]: edit-layout.md
[2]: add-layout.md
[3]: working-with-archives.md
[4]: learn/working-with-fields.md
[9]: ../web-app/pagebuilder/index.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/nav-admin-confscreen-active-h32.png
[img2]: ../../../../media/icons/btn-menu.png
[img3]: ../../../../media/loc/en/ui/status-draft.png
[img4]: ../../../../media/loc/en/ui/status-published.png
[img5]: ../../../../media/loc/en/ui/edit-card-layout-fields.png
