---
uid: help-da-request-relations
title: Sagsrelationer
description: Lær hvordan du kan sammenkæde relaterede sager ved hjælp af overordnede, underordnede og relaterede relationer for bedre at spore og administrere forbundne problemer i SuperOffice Service.
keywords: sagsrelationer, sammenkæde sager, overordnet sag, underordnet sag, relaterede sager
author: digitaldiina
date: 02.17.2026
version: 11.10
content_type: howto
category: service
topic: request
license: serviceessentials
audience: person
audience_tooltip: SuperOffice Service
language: da
---

# Sagsrelationer

Sagsrelationer giver dig mulighed for at sammenkæde sager for at vise forbindelser mellem problemer. Dette er nyttigt, når flere sager er relateret til det samme problem, når en sag er afhængig af en anden, eller når du har brug for at spore hierarkiske forbindelser mellem sager.

> [!NOTE]
> Sagsrelationer bruges til at sammenkæde sager med andre sager. For at definere forbindelser mellem firmaer og personer, se [Firma- og personrelationer][4].

## Relationstyper

Der er tre typer sagsrelationer:

* **Relateret:** En ikke-hierarkisk forbindelse mellem sager.

* **Overordnet:** En sag, der har en eller flere underordnede sager.

* **Underordnet:** En sag, der er knyttet til en overord net sag. Hver sag kan kun have én overordnet sag.

## Anvendelsestilfælde

Brug **relateret**, når sager er forbundet, men ikke har et hierarki.

**Flere kunder rapporterer det samme problem**
Når forskellige kunder uafhængigt rapporterer det samme problem, skal du sammenkæde sagerne som relaterede. Dette giver et fladtoverblik over alle berørte kunder og hjælper med at sikre konsistent kommunikation.

**Sager med flere spørgsmål**
Hvis en sag indeholder urelaterede spørgsmål, skal du dele den i separate sager for hver afdeling. Sammenkæd dem derefter som relaterede for at vise, at de stammer fra samme kontekst.

Brug **overordnet og underordnet**, når sager har et hierarkisk eller afhængighedsforhold.

**Hændelsesstyring med årsagssporing**
Opret en overordnet sag for at spore det underliggende problem. Sammenkæd hver kunderapport som en underordnet sag. En overordnet sag kan have flere underordnede sager, men hver sag kan kun have én overordnet sag.

**Håndtering af afhængigheder**
Når en sag skal løses, før en anden kan afsluttes, skal du sammenkæde dem ved hjælp af en overordnet-underordnet-relation for klart at vise afhængigheden.

## Vis sagsrelationer

Når en sag har en eller flere relationer, kan du se dem i fanen **Relationer** på sagsskærmbilledet.

### Arkivvisning

Standardvisningen viser relationer som en liste med følgende kolonner:

* Sags-id
* Titel
* Sidst ændret
* Ejer
* Status
* Relationstype

![Sagsrelationer i listevisning -screenshot][img1]

### Trævisning

Klik på **Trævisning** for at vise relationer i en hierarkisk struktur, så overordnede og underordnede relationer bliver lettere at visualisere:

![Sagsrelationer i trævisning -screenshot][img2]

> [!TIP]
> Fanen **Relationer** viser en orange indikator, når sagen har en eller flere relationer, så det er nemt at identificere linkede sager med et blik.

### Forskellige perspektiver

Relationer er tovejs. Begge sager i relationen viser forbindelsen:

* Hvis Sag A er **overordnet** for Sag B, vil Sag B vise Sag A som sin overordnede
* Hvis Sag A er **relateret** til Sag B, vil Sag B vise, at den er relateret til Sag A

![Den samme relation set fra den relaterede sag -screenshot][img3]

## <a id="add"></a>Tilføj sagsrelation

Du kan tilføje en relation fra følgende placeringer:

### Fra sagssknærmbilledet

1. Åbn den sag, du vil sammenkæde.

1. Vælg fanen **Relationer**.

1. Klik på **Ny relation**.

1. I feltet **Relationstype** skal du vælge **Relateret**, **Overordnet** eller **Underordnet**.

1. I sektionen **Link til** skal du vælge **Link til eksisterende** (standard).

1. Begynd at skrive i søgefeltet for at finde den sag, du vil sammenkæde. Du kan søge efter sags-id, titel, firma eller person.

1. Vælg sagen fra listen. Du kan holde markøren over en sag i listen for at få vist en forhåndsvisning af dens detaljer.

1. Tilføj eventuelt en kommentar, der forklarer relationen.

1. Klik på **Tilknyt** for at oprette sammenkædningen.

### Fra detaljekort for Sager

1. Gå til et Firma-, Person-, Salg- eller Projektskærmbillede.

1. Vælg detaljekort **Sager**.

1. Højreklik på den sag, du vil oprette en relation fra.

1. Vælg **Relationer** fra kontekstmenuen.

1. Følg trin 4-9 ovenfor for at fuldføre relationen.

![Kontekstmenu med tilvalg for Relationer -screenshot][img4]

## Opret ny sag som relation

I stedet for at sammenkæde til en eksisterende sag kan du oprette en ny sag, mens du etablerer relationen:

1. Følg trinnene ovenfor for at åbne dialogboksen **Relationer**.

1. I sektionen **Link til** skal du vælge **Opret ny sag**.

1. Udfyld sagsdetaljerne.

1. Klik på **Tilknyt** for at oprette både den nye sag og sammenkædningen samtidig.

## <a id="delete"></a>Fjern sagsrelation

1. Åbn sagen og vælg fanen **Relationer**.

1. Find den relation, du vil fjerne.

1. Klik på <i class="ph ph-x-circle" aria-label="Fjern ikon"></i> **Fjern relation** nederst i dialogboksen, eller højreklik på relationen og vælg **Fjern relation**.

1. Bekræft sletningen.

Fjernelse af en relation sletter kun linket. Sagerne forbliver uændrede.

## Fejlfinding

### Knappen Fjern relation kan ikke klikkes

Knappen **Fjern relation** er kun aktiv, når du har valgt nøjagtigt én relation. Sørg for, at du har:

* Valgt en enkelt relation på listen
* Ikke valgt flere relationer

### Kan ikke tilføje overordnet eller underordnet relation

**Årsag:** En sag kan kun have én overordnet. Hvis sagen allerede har en overordnet, kan du ikke tildele en anden overordnet relation.

**Løsning:** Fjern den eksisterende overordnede relation først, eller brug en **Relateret** relationstype i stedet, som tillader flere forbindelser.

### Kan ikke oprette relation

**Mulige årsager:**

* **Duplikat relation:** De to sager er allerede sammenkædet. Kontroller fanen Relationer for at se, om relationen allerede eksisterer.
* **Cirkulært hierarki:** Du kan ikke oprette en overordnet-underordnet relation, der vil resultere i en cirkulær reference (f.eks. Sag A er overordnet for Sag B, og Sag B er overordnet for Sag A).

**Løsning:** Kontroller eksisterende relationer og juster din hierarkistruktur for at undgå cirkulære afhængigheder.

## Relateret indhold

* [Del sag][2]
* [Slå sammen sager][1]
* [Detaljekort for Sager][3]
* [Firma- og personrelationer][4]

<!-- Referenced links -->
[1]: merge.md
[2]: split-request.md
[3]: ../../learn/section-tabs/requests-tab.md
[4]: ../../learn/basics/relations.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/request/request-relations-archive.png
[img2]: ../../../media/loc/en/request/request-relations-tree.png
[img3]: ../../../media/loc/en/request/request-relations-perspective.png
[img4]: ../../../media/loc/en/request/request-relations-context-menu.png
