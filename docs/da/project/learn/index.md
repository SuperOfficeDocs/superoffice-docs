---
uid: help-da-project
title: Projekt
description: "Denne vejledning viser dig, hvordan du opretter og bruger projekter til at holde styr på dit arbejde."
author: SuperOffice RnD
so.date: 02.10.2023
keywords: projekt
so.topic: concept
language: da
---

# Projekt

Du kan knytte enhver aktivitet til et eksternt firma og til et projekt. Du kan også arbejde med en projektguide, som guider dig gennem alle trin i projektet, hvis der er oprettet en projektguide for den projekttype, du har valgt. Et projekt kan være rettet mod mange personer, og en person kan deltage i mange projekter.

![Projektskærmbillede -screenshot][img1]

Projekter hjælper dig med at holde styr på dit arbejde og dokumentere på ét sted, så du og dit team kan opleve mere kontrol og forbedret samarbejde.

Du kan tilknytte alle kontakter, firmaer, opfølginger, projektdeltagere og endda salgsmuligheder til ét projekt i SuperOffice CRM. Du kan også oprette eller overføre dokumenter og filer til projektet.

Alle de informationer, du gemmer i projektet, mærkes med en dato og en ejer, hvilket gør det nemmere at sortere og filtrere informationer, når det er nødvendigt.

Skærmbilledet Projekt indeholder informationer om de projekter, der er indtastet i SuperOffice CRM. Hvert projekt vises som et indekskort, der viser alle informationer om det pågældende projekt.

Hvis du vil gå frem og tilbage mellem projekter, skal du klikke på ![ikon][img2] ![ikon][img3] forrige/næste nederst til højre på kortene

Hvis du vælger en projekttype, der er defineret en [projektguide][1] for, vises fanen **Projektguide** på detaljekortet.

## <a id="more-tab" />Fanen Mere

![Fanen Mere (projekt) -screenshot][img4]

Fanen **Mere** viser brugerdefinerede felter for projektet. Hvis din organisation har brug for flere felter end standardfelterne under fanen **Projekt**, kan du under Indstillinger og vedligeholdelse angive, at disse felter skal indsættes her.

Klik på **Rediger** for at redigere projektoplysningerne under fanen **Mere**.

Tre af de brugerdefinerede felter fra fanen **Mere** kan også vises under fanen **Projekt**.

## Fanen Bemærkning

[!include[About the Note tab](../../learn/includes/about-note-tab.md)]

## <a id="event-tab" />Fanen Arrangement

Denne funktion kræver en separat licens.

Under fanen **Arrangement** kan du angive indstillinger for publicering af Arrangementer.

| Felt | Beskrivelse |
|---|---|
| Hændelse | Her kontrollerer du, at det aktuelle projekt er et arrangement. |
| Dato for arrangement | Dette felt viser datoen for arrangementet. Klik på pilen for at vælge en dato for arrangementet. |
| Udgivet (Fra dato og Til dato) | Her kan du angive en præcis tidsperiode, som arrangementet er synligt for Audience-brugere (kræver en separat licens). Klik på pilen ud for hvert af datofelterne for at vælge en start- og slutdato for udgivelsen. Hvis du ikke indtaster datoer i disse felter, [er projektet udgivet][2], indtil det enten ikke-udgives eller slettes fra SuperOffice CRM. |
| Synlig for kategori | Markér her, hvis arrangementet kun skal være synligt for bestemte kategorier. Klik på knappen (![ikon][img5]) til højre for feltet for at vælge de kategorier, som arrangementet er synligt for. |
| Synligt for personinteresse | Markér her, hvis arrangementet kun skal være synligt for personer med bestemte interesser. Klik på knappen (![ikon][img5]) til højre for feltet for at vælge de interesser, som arrangementet er synligt for. |
| Synligt for projektdeltagere | Hvis afkrydsningsfeltet er markeret, er arrangementet kun synligt i Audience for de [projektdeltagere][8], der er angivet under fanen **Projektmedlemmer**. |
| Tilmelding | Markér her, hvis du ønsker, at det skal være muligt at tilmelde sig arrangementet via Audience. |
| Afmelding | Markér her, hvis du ønsker, at det skal være muligt at afmelde sig arrangementet via Audience. |
| Log som aktivitet | Hvis du også markerer **Log som aktivitet** ud for **Tilmelding** eller **Afmelding**, oprettes der en aktivitet for dig, når en Audience-bruger tilmelder eller afmelder sig arrangementet. |

> [!TIP]
> Hvis du klikker på knappen (![ikon][img5]) til højre for **Bekræftelse**, kan du indtaste en bekræftelsestekst, der skal vises i en dialogboks, når en Audience-bruger tilmelder eller afmelder sig arrangementet. Brugeren skal klikke på **Ja** eller **Nej** i denne dialogboks for at fortsætte.

## Føj projekt til favoritter

[!include[ALT](../../learn/includes/howto-add-favorite.md)]

## Udskriv projektinformationer

1. [!include[Go to project](includes/goto-project.md)]
2. Klik på knappen **Opgave**, og vælg **Udskriv**.
3. I vinduet, som viser indhold, der skal udskrives, klikker du på **Udskriv**.

## Hvad vil du foretage dig nu?

* [Opret et projekt][2]
* [Rediger et projekt][3]
* [Flet projekter][4]
* [Slet et projekt][5]
* [Send et dokument til projektdeltagere][7]
* [Projektvejledning][1]

<!-- Referenced links -->
[1]: project-guide/index.md
[2]: create.md
[3]: edit.md
[4]: merge-projects.md
[5]: delete.md
[7]: project-members/create-mailing.md
[8]: project-guide/create.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/project/projects.png
[img2]: ../../../media/icons/arrow-left.png
[img3]: ../../../media/icons/arrow-right.png
[img4]: ../../../media/loc/en/project/project-more.png
[img5]: ../../../media/icons/select.png
