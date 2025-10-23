---
uid: help-no-users
title: Brukere
description: Finn ut hvordan du legger til nye brukere, hvordan du tilordner de riktige brukerrollene og -gruppene, og hvordan du hjelper brukerne med oppsett og WebTools.
keywords: Skjermbildet Brukere, bruker, medarbeider, våre firmaer
author: SuperOffice Product and Engineering
date: 02.21.2023
version: 10.5
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
language: no
redirect_from: /no/admin/user-management/learn/screen/index
---

# Brukere

Som administrator har du ansvaret for å legge til og administrere brukerne. I denne seksjonen lærer du hvordan du legger til nye brukere, hvordan du tilordner de riktige brukerrollene og -gruppene, og hvordan du hjelper brukerne med oppsett og WebTools.

## Brukertyper

* **Medarbeidere**: SuperOffice CRM-brukere (i ditt firma)

* **Andre brukere**: Anonyme brukere og systembrukere (kun Onsite)

* **Anonyme brukere**: Brukere med begrensede rettigheter definert av [rollen for anonyme brukere][4]. Anonyme brukere kan for eksempel brukes til å gi tilgang til websider. Slik kan for eksempel selgere gjøre relevant informasjon fra SuperOffice CRM tilgjengelig på en webside som ikke krever pålogging, slik at kunder lett kan få tilgang til denne informasjonen.

* **Systembrukere**: [!include[Access rights](includes/def-system-user.md)]

    Systembrukeren er ment for integrasjon og kan brukes til for eksempel å gi prosesser full tilgang til SuperOffice-databasen for replikering av dagbøker.

## Medarbeidere

**Medarbeidere** er SuperOffice-brukere i firmaet ditt (eller et tilknyttet firma, for eksempel et datterselskap).

I fanen **Medarbeidere** i Brukere-bildet kan du blant annet legge til brukere av typen **Medarbeider** og tildele dem roller, grupper og lisenser, redigere eksisterende brukere og slette brukere.

For at en person skal kunne defineres som SuperOffice CRM-bruker, må vedkommende være registrert hos et firma som vises i listeboksen **Firma** i Brukere-bildet. Og for at et firma skal kunne vises i listeboksen **Firma** i Brukere-bildet, må firmaet vises på firmalisten i fanen **Våre firmaer**.

> [!NOTE]
> I Brukere-bildet angir du hvilke lisenser de ulike brukerne skal ha. For å legge til nye systemlisenser eller øke/redusere antall lisenser for én eller flere moduler må du kontakte SuperOffice for å [oppdatere lisensinformasjonen][6].

## <a id="screen"></a>Skjermbildet Brukere

I Brukere-bildet kan du legge til og redigere ulike typer brukere.

![En oversikt over Brukere-bildet i Innstillinger og vedlikehold -screenshot][img3]

[**Våre firmaer:**][2] For at en person skal kunne defineres som SuperOffice CRM-bruker, må vedkommende være registrert hos et firma som vises i listen **Firma** i Brukere-bildet. Og for at et firma skal kunne vises i listen **Firma** i Brukere-bildet, må firmaet vises på firmalisten i fanen **Våre firmaer**.

> [!NOTE]
> Eventuelle endringer du gjør i Brukere-bildet, trer ikke i kraft før du klikker på **Lagre** nederst i bildet, eller bekrefter at du vil lagre endringen(e), i dialogboksen som vises. Hvis du klikker på **Avbryt**, mister du alt du har gjort i bildet siden sist du lagret.

### <a id="associates"></a>Medarbeider-listen

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

#### Brukerinformasjon

På høyre side av vinduet finner du detaljinformasjon om brukeren som er valgt i medarbeiderlisten.

Fullt navn, e-postadresse og eierfirma vises øverst. Nederst i denne delen kan du aktivere/deaktivere brukeren i SuperOffice ved hjelp av knappen **Kan logge inn**. Klikk på **Oppgave**-knappen for å få tilgang til funksjoner som **Flytt bruker**, og for å sende velkomst-e-post og e-post for tilbakestilling av passord.

Det er forskjellige faner i brukeroversikten:

* **Detaljer** – hovedoversikt over brukerinformasjon som **Bruker-ID**, **Rolle**, **Brukerplan**, **Primærgruppe** og **SuperOffice Service-kategorier**.
* **Lisen** – ekstra lisensinformasjon, for eksempel **Konfidensielle aktiviteter**, som gir brukeren muligheten til å velge **synlig for** for oppfølginger, dokumenter og utvalg.
* **Mer** – fanen viser om det finnes ekstrafelt for personen.

### <a id="other-users"></a>Andre brukere (Onsite)

I fanen **Andre brukere** i Brukere-bildet kan du redigere påloggingsrettigheter for og legge til anonyme brukere og systembrukere.

### <a id="our-companies"></a>Våre firmaer

Hensikten med firmalisten i fanen **Våre firmaer** i Brukere-bildet er å angi:

* Hvem som kan defineres som brukere av SuperOffice CRM. For at en person skal kunne defineres som SuperOffice CRM-bruker, må vedkommende være registrert hos et firma som vises i listeboksen **Firma** i Brukere-bildet. Og for at et firma skal kunne vises i listeboksen **Firma** i Brukere-bildet, må firmaet vises på firmalisten i fanen **Våre firmaer**.

* Hvilke firmaer som kan defineres som eiere av en satellitt.

#### Kolonner i firmalisten

| Kolonner | Beskrivelse |
|---|---|
| Firmanavn | Firmaets navn. |
| Avdeling | Navnet på avdelingen i firmaet. |
| Sted | Hvor firmaet holder til. |
| Medarbeidere | Hvor mange medarbeidere som er opprettet for firmaet. |
| Aktiv satellitt | Om firmaet er registrert som en aktiv satellitt. |

### Brukerlisenser

I fanen **Brukerlisenser** i Bruker-bildet kan du få oversikt over hvor mange brukerlisenser som er i bruk, og hvilke brukere som bruker de forskjellige lisensene.

* Klikk på en lisens i listen **Brukerlisenser** for å vise en liste over brukerne som for tiden bruker denne lisensen.

* Hold musepekeren over et lisensnavn for å vise detaljert informasjon om lisensen.

### Brukergrupper

På fanen **Brukergrupper** i Brukere-bildet kan du få en oversikt over brukere og brukergrupper. Klikk på et gruppenavn i listen **Tilgjengelige grupper** for å vise en liste over brukerne som for tiden er tilordnet til denne gruppen.

## Aktuelt innhold

* [Administrere rollene dine][1]
* [Legge til en ny bruker][2]
* [Endre brukerplaner for aktive brukere][3]
* [Installere WebTools for brukerne dine][7]

<!-- Referenced links -->
[1]: role/index.md
[2]: add-associate.md
[3]: ../../license/change-user-plan.md
[4]: role/edit-rights-for-anonymous-users.md
[6]: ../../license/learn/activate.md
[7]: ../../../../../integrations/webtools/install.md

<!-- Referenced images -->
[img3]: ../../../../media/loc/en/admin/admin-users-overview.png
