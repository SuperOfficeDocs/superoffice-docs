---
uid: help-no-preferences
title: Preferanser
description: "Administratorer kan angi preferanser for ulike funksjoner i systemet for bestemte brukere, brukergrupper eller for hele SuperOffice CRM (globale preferanser)."
author: Bergfrid Dias
so.date: 03.21.2023
keywords: innstillinger, preferanser
so.topic: concept
so.audience: settings
so.audience.tooltip: Settings and maintenance

language: no
---

# Preferanser

I bildet Preferanser kan du angi preferanser for hele systemet (globalt), én database, én brukergruppe eller én bruker. Preferanser som bare kan angis på globalt nivå (system), er plassert i fanen **[Globale preferanser][1]**.

Brukere kan redigere innstillingene for [individuelle preferanser][4] for å tilpasse dem til sin egen bruk, ved å gå til **Personlige innstillinger** > **Preferanser** i topplinjen. Preferansene som er tilgjengelige for brukeren, avhenger av hva som er angitt i Innstillinger og vedlikehold.

I tillegg kan du konfigurere videomøter i fanen [Videomøter][8] og dokumentbibliotek i fanen [Dokumentbibliotek][9].

## <a id="levels" />Nivåer for innstillinger av preferanser

Preferanseinnstillinger kan angis for fire ulike nivåer:

| Nivå | Beskrivelse |
|---|---|
| System | Globale preferanser som gjelder for alle brukerne i systemet, inkludert alle satellitter, grupper og enkeltbrukere. |
| Database | Preferanser som gjelder for én bestemt database, og alle grupper og brukere som er tilknyttet denne databasen. |
| Gruppe | Preferanser som gjelder for alle brukerne i en bestemt gruppe. |
| Bruker | Preferanser som er tilknyttet hver enkelt bruker. |

Du kan angi ulike verdier for ulike nivåer, slik at du for eksempel kan ha én innstilling for en bruker og en annen innstilling for brukergruppen som personen tilhører. Det er alltid det laveste nivået som gjelder.

> [!NOTE]
> Ikke alle nivåer er tilgjengelige for alle preferanser. Hvis ett eller flere av alternativene er deaktivert, kan du ikke velge dette for denne preferansen.

I feltet **Aktive innstillinger** kan du velge hvilke innstillinger som skal vises i listen, basert på nivået de er angitt for. Nivåene som vises, avhenger av hvilke nivåer du merker av nederst i feltet. Du kan merke av for å vise ett nivå, to nivåer eller alle nivåer.

> [!NOTE]
> Innstillinger på systemnivå vises alltid.

## <a id="global" />Globale preferanser (for hele systemet)

Noen [preferanser][1] kan bare angis på et globalt nivå:

* Statistikk
* Funksjoner
* E-post
* Grupperte lister
* Markedsføring
* Mobile CRM
* Salg
* Systeminnstillinger for SuperOffice Service
* System
* SMS-konfigurasjon
* Passordregler for kundesenter

### Endre globale preferanser

Hvis du vil redigere disse innstillingene, går du til ![ikon][img1] **Preferanser**-bildet og velger fanen **Globale preferanser**.

* Preferansene er delt inn i seksjoner.
* Hold musepekeren over en preferanse for å vise tilleggsinformasjon.
* Klikk på **Lagre** for å ta i bruk endringene.

## <a id="preferences-tab" />Preferanser-fane

I fanen **Preferanser** kan du angi innstillinger for ulike deler av SuperOffice CRM, for eksempel antall elementer som skal vises i historikklisten, standardtype for nye møter, og standardvaluta i Salg-bildet.

Øverst i **Preferanser**fanen kan du velge ønsket preferansegruppe. Resten av fanen **Preferanser** er delt inn i tre hoveddeler: en liste med alle preferanser, et beskrivelsesfelt som forklarer beskrivelsen av preferansen som er valgt, og et felt som viser innstillingene for den aktuelle preferansen.

### Preferanseliste

Til venstre finner du **Preferanser**-listen, som inneholder alle preferansene som er definert for den aktuelle preferansegruppen.

**Grupper av preferanser:**

* Person
* Standardverdier
* Dagbok
* E-post
* Dialogboksen Filter
* Fritekstsøk
* Funksjoner
* Grupperte lister
* Kommunikasjon i appen
* Markedsføring
* Varslinger via e-post + popup + SMS
* Sak
* Salg
* Sortering
* System
* Infoboks
* Visuelle effekter
* Webserver
* Webtjenester

> [!NOTE]
> Preferanser med aktive individuelle innstillinger vises i fet skrift.

### Aktive innstillinger

Feltet **Aktive innstillinger** viser innstillingene som er angitt for preferansen som er valgt i listen **Preferanser**, og nivåene og verdiene for hver av dem. Her kan du endre og slette eksisterende innstillinger og legge til nye.

Feltet består av tre kolonner:

| Kolonner | Beskrivelse |
|---|---|
| Hvem | Viser hvem innstillingen gjelder for (navnet på systemet, databasen, gruppen eller brukeren). Hvis dette er en enkeltbruker, vises en infoboks for denne brukeren når du holder musepekeren over brukerens initialer i denne kolonnen. |
| Nivå | Viser hvilket [nivå innstillingen gjelder for](#levels) (system, database, gruppe eller bruker). |
| Verdi | Viser hvilken verdi som er angitt for innstillingen. |

Innholdet i disse kolonnene defineres i dialogboksen **Innstilling**. [Slik legger du til preferanseinnstillinger][3].

Du kan sortere radene i kolonnene ved å klikke på ønsket kolonneoverskrift. Klikk på kolonneoverskriften én gang hvis du vil sortere i omvendt rekkefølge.

<!-- Referenced links -->
[1]: global-preferences/system.md
[3]: update-preferences.md
[4]: update-preferences.md#personal
[8]: video-meetings/index.md
[9]: document-library/index.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/nav-admin-preferences-active.png
