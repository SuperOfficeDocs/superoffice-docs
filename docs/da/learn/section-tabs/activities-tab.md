---
uid: help-da-section-tab-activities
title: Aktivitetsfanen
description: Lær hvordan du bruger aktivitetsdetaljekortet i SuperOffice CRM til at se, administrere og følge op på aktiviteter, opgaver og dokumenter for firmaer, personer, projekter og salg – alt samlet ét sted.
keywords: Aktivitets-fanen, Aktivitetsfanen, Fanen Aktiviteter, detaljekortet Aktiviteter, detaljekort, aktivitetsarkiv
author: Bergfrid Skaara Dias
date: 02.25.2025
version: 10.5.2
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: da
---

# Aktivitetsfanen

Der findes forskellige typer [aktiviteter][1] i SuperOffice CRM, herunder opfølgninger, forsendelser, formularindsendelser og chatposter.

Detaljekortet **Aktiviteter** i SuperOffice CRM giver en omfattende oversigt over opfølgninger, dokumenter og e-mails knyttet til en bestemt enhed (firma, person, projekt eller salg). Dette gør det muligt at følge op på og administrere interaktioner effektivt, så alle relevante aktiviteter er let tilgængelige.

![Detaljekortet Aktiviteter (Dagbog) -screenshot][img2]

## Tilgængelighed for Aktivitetsfanen

Detaljekortet **Aktiviteter** er tilgængeligt for:

| Enhed   | Beskrivelse af detaljekortet |
|---------|---------------------------------------|
| [Firma][9] | Viser alle aktiviteter, der er relateret til firmaet. |
| [Person][10] | Viser alle aktiviteter, der involverer personen, inklusive aktiviteter forbundet med personens tilknyttede firma. |
| [Dagbog][11] | En opgaveliste, der viser ufuldendte aktiviteter, herunder de der endnu ikke er allokeret til et bestemt tidspunkt eller dato. |
| [Salg][12] | Viser alle aktiviteter, der er knyttet til salget, giver en oversigt over fremdrift og interaktioner. |
| [Projekt][13] | Viser alle aktiviteter, der er knyttet til projektet. |

## <a id="columns"></a>Kolonneoversigt i Aktivitetsfanen

Detaljekortet **Aktiviteter** indeholder følgende kolonner til at vise vigtig information om hver aktivitet:

| Kolonne | Beskrivelse |
|---------|-------------|
| Udført | Afkrydsningsfelt, der angiver, om aktiviteten er fuldført. Et afkrydset felt (<i class="ph ph-check" aria-hidden="true"></i>) betyder udført, mens et tomt felt betyder, at aktiviteten er i gang. |
| Kategpri-ikon | Viser [aktivitetstypen][1] (som møde, opkald, dokument). Matcher teksten i **Type**-kolonnen. |
| Dato | Viser, hvornår dokumentet blev oprettet, eller hvornår opfølgningen finder sted. |
| Type | Aktivitetstypen, såsom møde, opgave eller e-mail. |
| Beskrivelse | En kort beskrivelse af aktiviteten. |
| Firma | Tilknyttet firma, hvis relevant. |
| Person | Personen knyttet til aktiviteten, hvis relevant. |
| Bruger-ID | Brugeren, der oprettede aktiviteten. |

[!include[Conf. columns](../includes/tip-configure-columns.md)]

## Se aktiviteter

1. Gå til den relevante skærm, såsom Firma, Person, Projekt eller Salg.

1. Klik på detaljekortet **Aktiviteter** for at se alle aktiviteter knyttet til enheden.

1. Dobbeltklik på en aktivitetslinje for at åbne og se eller redigere detaljerne for den aktivitet.

### Filtrer aktiviteter

Du kan [filtrere listen][8] over aktiviteter ved at bruge afkrydsningsfelterne eller filtrene nederst i detaljekortet. Dette hjælper dig med at fokusere på specifikke aktivitetstyper eller tidsrammer.

### Inkluder fuldførte aktiviteter

For at inkludere fuldførte aktiviteter i listen, skal du sørge for, at afkrydsningsfeltet **Udføret** er markeret. Dette giver dig et fuldt overblik over både igangværende og afsluttede aktiviteter.

## Administrere aktiviteter i Aktivitetsfanen

* **Tilføj aktivitet:** Klik på **Tilføj**, udfyld detaljerne, og klik på **Gem**.

* **Åbn aktiviteter:** Dobbeltklik på en aktivitet i listen. Hvis du dobbeltklikker på et dokument, åbnes selve dokumentet.

* **Bevæg mellem aktiviteter:** Brug pilene til at navigere gennem aktiviteter. Brug **Forhåndsvisning** i [sidepanelet][2] for hurtigt at se detaljer.

* **Besvar eller videresend e-mails:** Find den gemte e-mail, højreklik, og vælg **Svar** eller **Videresend**.

## Yderligere tips

* **Hurtig navigation:** Brug [Navigatoren][7] til hurtigt at skifte mellem forskellige enheder og deres tilsvarende **Aktiviteter**-faner.

* **Markering af fuldførelse:** For at ændre **Udført**-status for en aktivitet, skal du blot klikke på boksen.

* **Værktøjstip til fuld tekst:** Hvis ikke al tekst i et felt er synlig, hold musen over feltet for at vise det i en infoboks.

## Relateret indhold

* [Introduktion til aktiviteter][1]
* [Opret opfølgninger][6]
* [Besvar eller videresend e-mail fra detaljekortet Aktiviteter][3] (Aktivitetsfanen)
* [Ændre Udført-status for en aktivitet][4]
* [Slet aktiviteter i aktivitetslisten][1]
* [Filtrer aktiviteter][8]
* [Gruppér kolonner og opsummér][5]

<!-- Referenced links -->
[1]: ../basics/activity.md
[2]: ../getting-started/main-screen/side-panel.md
[3]: send-email.md
[4]: ../../diary/learn/change-completed-status.md
[5]: configure-columns.md#calculate
[6]: ../../diary/learn/create-follow-up.md
[7]: ../getting-started/main-screen/navigator.md
[8]: filter.md
[9]: ../../company/learn/index.md#section-tabs
[10]: ../../contact/learn/index.md#section-tabs
[11]: ../../diary/learn/index.md#section-tabs
[12]: ../../sale/learn/index.md#section-tabs
[13]: ../../project/learn/index.md#section-tabs

<!-- Referenced images -->
[img2]: ../../../media/loc/en/diary/activities-detail.png
