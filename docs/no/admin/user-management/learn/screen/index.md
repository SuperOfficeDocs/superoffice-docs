---
uid: help-no-users-screen
title: Skjermbildet Brukere
description: Skjermbildet Brukere
author: Bergfrid Dias
so.date: 03.27.2023
keywords: bruker, medarbeider, våre firmaer
so.topic: reference
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: no
---

# Skjermbildet Brukere

I Brukere-bildet kan du legge til og redigere ulike typer brukere.

![En oversikt over Brukere-bildet i Innstillinger og vedlikehold -screenshot][img1]

[**Våre firmaer:**][2] For at en person skal kunne defineres som SuperOffice CRM-bruker, må vedkommende være registrert hos et firma som vises i listen **Firma** i Brukere-bildet. Og for at et firma skal kunne vises i listen **Firma** i Brukere-bildet, må firmaet vises på firmalisten i fanen **Våre firmaer**.

> [!NOTE]
> Eventuelle endringer du gjør i Brukere-bildet, trer ikke i kraft før du klikker på **Lagre** nederst i bildet, eller bekrefter at du vil lagre endringen(e), i dialogboksen som vises. Hvis du klikker på **Avbryt**, mister du alt du har gjort i bildet siden sist du lagret.

## <a id="associates" />Medarbeider-listen

Listen i fanen **Medarbeidere** består som standard av følgende kolonner:

| Kolonner | Beskrivelse |
|---|---|
| Bruker-ID | Brukernavnet som er tilordnet medarbeideren. |
| Fornavn | Fornavnet til brukeren. |
| Etternavn | Etternavnet til brukeren. |
| Primærgruppe | Primærgruppen til brukeren. |
| Rolle | [Rollen][7] som er angitt for brukeren. Rollen definerer hvilke tilgangsrettigheter brukeren har til data i SuperOffice CRM. |
| Brukerplan | Brukerplanen som er angitt for brukeren. |
| Eierfirma | Navnet på organisasjon brukeren tilhører (definert som databaseeier). |

> [!TIP]
> Du kan velge hvilke kolonner som vises i oversikten. Bare høyreklikk på en kolonneoverskrift, og velg de relevante kolonnene i kolonnelisten. Hvis du vil endre rekkefølgen på kolonnene, kan du klikke på en kolonneoverskrift og dra den til en ny plassering.

### Brukerinformasjon

På høyre side av vinduet finner du detaljinformasjon om brukeren som er valgt i medarbeiderlisten.

Fullt navn, e-postadresse og eierfirma vises øverst. Nederst i denne delen kan du aktivere/deaktivere brukeren i SuperOffice ved hjelp av knappen **Kan logge inn**. Klikk på **Oppgave**-knappen for å få tilgang til funksjoner som **Flytt bruker**, og for å sende velkomst-e-post og e-post for tilbakestilling av passord.

Det er forskjellige faner i brukeroversikten:

* **Detaljer** – hovedoversikt over brukerinformasjon som **Bruker-ID**, **Rolle**, **Brukerplan**, **Primærgruppe** og **SuperOffice Service-kategorier**.
* **Lisen** – ekstra lisensinformasjon, for eksempel **Konfidensielle aktiviteter**, som gir brukeren muligheten til å velge **synlig for** for oppfølginger, dokumenter og utvalg.
* **Mer** – fanen viser om det finnes ekstrafelt for personen.

## <a id="other-users" />Andre brukere (Onsite)

I fanen **Andre brukere** i Brukere-bildet kan du redigere påloggingsrettigheter for og legge til anonyme brukere og systembrukere.

## <a id="our-companies" />Våre firmaer

Hensikten med firmalisten i fanen **Våre firmaer** i Brukere-bildet er å angi:

* Hvem som kan defineres som brukere av SuperOffice CRM. For at en person skal kunne defineres som SuperOffice CRM-bruker, må vedkommende være registrert hos et firma som vises i listeboksen **Firma** i Brukere-bildet. Og for at et firma skal kunne vises i listeboksen **Firma** i Brukere-bildet, må firmaet vises på firmalisten i fanen **Våre firmaer**.

* Hvilke firmaer som kan defineres som eiere av en satellitt.

### Kolonner i firmalisten

| Kolonner | Beskrivelse |
|---|---|
| Firmanavn | Firmaets navn. |
| Avdeling | Navnet på avdelingen i firmaet. |
| Sted | Hvor firmaet holder til. |
| Medarbeidere | Hvor mange medarbeidere som er opprettet for firmaet. |
| Aktiv satellitt | Om firmaet er registrert som en aktiv satellitt. |

## Brukerlisenser

I fanen **Brukerlisenser** i Bruker-bildet kan du få oversikt over hvor mange brukerlisenser som er i bruk, og hvilke brukere som bruker de forskjellige lisensene.

* Klikk på en lisens i listen **Brukerlisenser** for å vise en liste over brukerne som for tiden bruker denne lisensen.

* Hold musepekeren over et lisensnavn for å vise detaljert informasjon om lisensen.

## Brukergrupper

På fanen **Brukergrupper** i Brukere-bildet kan du få en oversikt over brukere og brukergrupper. Klikk på et gruppenavn i listen **Tilgjengelige grupper** for å vise en liste over brukerne som for tiden er tilordnet til denne gruppen.

## Hva vil du gjøre nå?

* [Legge til brukere][2]
* [Flytte brukere][3]
* [Slette brukere][1]
* [Importere brukere][4]
* [Les om brukertyper][5]
* [Administrere anonyme brukere og systembrukere (onsite)][11]
* [Legge til og fjerne firmaer i fanen Våre firmaer][8]
* [Filtrere og gruppere brukere][6]

<!-- Referenced links -->
[1]: ../delete-user.md
[2]: ../add-associate.md
[3]: ../move-user.md
[4]: ../import-users.md
[5]: ../index.md
[6]: ../associates-filter-group.md
[7]: ../role/index.md
[8]: ../our-companies.md
[11]: ../other-users.md

<!-- Referenced images -->
[img1]: ../../../../../media/loc/en/admin/admin-users-overview.png
