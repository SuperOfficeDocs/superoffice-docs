---
uid: help-no-role
title: Rolle
description: Rolle
author: Kirsti Aakerholt
date: 04.19.2023
keywords: rolle, dataobjekt, brukernivå
topic: concept
audience: admin
audience_tooltip: Settings and maintenance
language: no
---

# Roller

[!include[Requirement](../includes/note-anon-req.md)]

Ved hjelp av rollebasert sikkerhet i SuperOffice CRM kan du skreddersy roller for ulike tilgangsnivåer i firmaet. Rollene styrer tilgangsrettighetene de ulike brukerne har i SuperOffice CRM-modulene.

En rolle beskriver to ting:

* Hvilke **dataobjekter** (firma, person, prosjekt, prosjektdeltakere, utvalg, salg, interessent, oppfølging, dokument, relasjon, dashbord og mål) skal gjøres tilgjengelig for brukerne som har denne rollen.

    Tilgjengeligheten angis ved hjelp av rettigheter: ingen, lese, opprette, oppdatere og slette.

* Hvilke **funksjoner** (for eksempel administratortilgang i Innstillinger og vedlikehold / Innstillinger for Windows-klient, brevfletting, eksport av utvalg og publisering) som skal være tilgjengelige for brukerne som har denne rollen.

## Forhåndsdefinerte roller

Forhåndsdefinerte roller er inkludert i SuperOffice CRM. Rollene **Brukernivå 0–5** tilsvarer brukernivåene fra tidligere SuperOffice-versjoner, der brukernivå 0 er administrator. Du kan redigere disse rollene slik du ønsker.

| Rolle | Forklaring |
|---|---|
| Brukernivå 0 | Administrator: Har full tilgang til alle data. Kan vedlikeholde alle deler av systemet. |
| Brukernivå 1 | Superbruker: Har full tilgang til informasjon, men kan ikke vedlikeholde systemet. |
| Brukernivå 2 | Har full tilgang innenfor egen brukergruppe, men begrenset tilgang utenfor brukergruppen. |
| Brukernivå 3 | Har full tilgang til egne data og kan lese data innenfor egen brukergruppe, men har begrenset tilgang utenfor brukergruppen. |
| Brukernivå 4 | Har full tilgang til egne data, men begrenset tilgang innenfor egen brukergruppe og utenfor brukergruppen. |
| Brukernivå 5 | Har lesetilgang til det meste av informasjon, men begrenset tilgang til andres informasjon. Kan opprette aktiviteter. |
| Listeadministrator | Har full tilgang til informasjon i SuperOffice CRM-klienten. Kan bruke Innstillinger og vedlikehold til å redigere listene i systemet (for eksempel lister med dokumentmaler og kategorier). |
| Brukeradministrator | Har full tilgang til data. Kan bruke Innstillinger og vedlikehold til å opprette og redigere brukere i systemet. |
| Lokal bruker | Har full tilgang til egne data, men har ingen tilgang til data som tilhører brukere tilknyttet andre firmaer. |
| Ekstern bruker | Konsulent eller partner som har begrenset tilgang til firma- og prosjektinformasjon. Har bare tilgang til publiserte data. |
| Anonym bruker | Anonym bruker |
| Systembruker | Systemintegrasjonsbruker. Overstyrer all sikkerhetskontroll. Denne rollen vises ikke, og kan heller ikke redigeres. |

### Bruker- eller administratorrolle

Når du gir tilgang til nye personer, må du angi rollen deres – enten bruker eller administrator.

Administratorer har tilgang til delen Innstillinger og vedlikehold. Her kan man opprette brukere, tilpasse tilgangsrettigheter og tilpasse CRM-løsningen. Hvis du vil at en bruker skal ha denne tilgangen, gir du vedkommende brukernivå 0.

Hvis du ikke vil at brukerne skal ha tilgang til Innstillinger og vedlikehold, gir du dem brukernivå 1 eller høyere, avhengig av tilgangen de trenger.

## Administrere rollene dine

I Roller-delen kan du [bestemme hvilken type tilgang][3] brukerne skal ha til de forskjellige delene av SuperOffice CRM. Du kan også tilpasse hvert brukernivå ved å endre Datarettigheter og/eller de forskjellige [funksjonelle rettighetene][6].

![I Roller-delen bestemmer du hvilken type tilgang brukerne skal ha til de forskjellige delene av SuperOffice CRM. -screenshot][img1]

Du kan for eksempel bestemme om en person skal kunne slette, oppdatere, opprette eller lese informasjon, på fanen Datarettigheter. På fanen Funksjonelle rettigheter kan du tillate ulike funksjonelle rettigheter for de forskjellige rollene, som Kan masseredigere eller Listeadministrator, ved å flytte dem til den høyre kolonnen for Denne rollen kan.

| Rolle | Forklaring | Ingen | Les | Opprett | Oppdater | Slett |
|---|---|:-:|:-:|:-:|:-:|:-:|
| Ingen | Ingen rettigheter og kan ikke se | X |  |  |  |  |
| Les | Kan lese |  | X |  |  |  |
| Opprett | Kan opprette |  | X | X |  |  |
| Oppdater | Kan oppdatere |  | X | X | X |  |
| Slett | Kan slette |  | X | X | X | X |

## Hva vil du gjøre nå?

* [Opprett en rolle][1]
* [Redigere en rolle][2]
* [Angi datarettigheter for rolle][3]
* [Redigere rettigheter for anonyme brukere][4]
* [Slette en rolle][5]
* [Funksjonelle rettighetene][6]

<!-- Referenced links -->
[1]: create-role.md
[2]: editing-role.md
[3]: set-data-rights-for-role.md
[4]: edit-rights-for-anonymous-users.md
[5]: deleting-role.md
[6]: functional-rights.md

<!-- Referenced images -->
[img1]: ../../../../../media/loc/en/admin/manage-user-levels.png
