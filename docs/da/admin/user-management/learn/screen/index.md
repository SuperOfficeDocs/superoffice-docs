---
uid: help-da-users-screen
title: Skærmbilledet Brugere
description: Skærmbilledet Brugere
author: Bergfrid Dias
so.date: 03.27.2023
keywords: user, medarbejder, vores virksomheder
so.topic: reference
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: da
---

# Skærmbilledet Brugere

I skærmbilledet Brugere kan du tilføje og redigere forskellige brugertyper.

![En oversigt over brugerskærmen i Indstillinger og vedligeholdelse -screenshot][img1]

[**vores virksomheder:**][2] For at en person skal kunne defineres som SuperOffice CRM-bruger, skal den pågældende være registreret hos et firma, som vises på listen **Firma** i skærmbilledet Brugere. Og for at et firma skal kunne vises på listen **Firma** i skærmbilledet Brugere, skal firmaet vises på firmalisten på fanen **Vores firmaer**.

> [!NOTE]
> Eventuelle ændringer, du foretager i skærmbilledet Brugere, træder ikke i kraft, før du klikker på **Gem** nederst i skærmbilledet, eller bekræfter, at du vil gemme ændringen/ændringerne, i dialogboksen som vises. Hvis du klikker på **Afbryd**, mister du alt det, du har foretaget i skærmbilledet, siden du gemte sidst.

## <a id="associates" />Medarbejderlisten

Listen under fanen **Medarbejdere** består som standard af følgende kolonner:

| Kolonne | Beskrivelse |
|---|---|
| Bruger-id | Brugernavnet, som er tildelt medarbejderen. |
| Fornavn | Brugerens fornavn. |
| Efternavn | Brugerens efternavn. |
| Primærgruppe | Brugerens primære gruppe. |
| Rolle | [Rollen][7], som er angivet for brugeren. Rollen definerer, hvilke adgangsrettigheder brugeren har til data i SuperOffice CRM. |
| Brugerplan | Brugerplanen, som er tildelt brugeren. |
| Ejerfirma | Navnet på den organisation, brugeren tilhører (defineret som databaseejer). |

> [!TIP]
> Du kan vælge, hvilke kolonner der skal vises på listen. Højreklik på en kolonneoverskrift, og vælg de relevante kolonner på kolonnelisten. Hvis du vil ændre rækkefølgen af kolonnerne, skal du klikke og trække i en kolonneoverskrift.

### Brugeroplysninger

Yderst til højre i vinduet finder du detaljerede oplysninger om den bruger, der er markeret på listen over medarbejdere.

Det fulde navn, e-mailadresse og ejerfirma vises øverst. Nederst i dette afsnit kan du aktivere/deaktivere brugeren i SuperOffice ved hjælp af knappen **Kan logge på**. Klik på knappen **Opgave** for at få adgang til funktioner som **Flyt bruger** og for at sende velkomst-e-mails og e-mails til nulstilling af adgangskoder.

Der er forskellige faner i brugeroversigten:

* **Detaljer** - hovedoversigt over brugeroplysninger som **Bruger-ID**, **Rolle**, **Brugerplan**, **Primær gruppe** og **Service-kategorier**.
* **Licenser** - ekstra licensoplysninger som **Fortrolige aktiviteter**, som vil give brugeren mulighed for at angive **synlig for** på opfølgingerr, dokumenter og valg.
* **Mere** - fanen viser, om der er ekstra felter på personen.

## <a id="other-users" />Andre brugere (Onsite)

På fanen **Andre brugere** på skærmen Brugere kan du redigere logonrettigheder for og tilføje anonyme brugere og systembrugere.

## <a id="our-companies" />Vores virksomheder

Formålet med virksomhedslisten på fanen **Vores virksomheder**på skærmbilledet Brugere er at angive:

* Hvem kan defineres som brugere af SuperOffice CRM. For at en person skal kunne defineres som SuperOffice CRM-bruger, skal den pågældende være registreret hos et firma, som vises på listen **Firma** i skærmbilledet Brugere. Og for at et firma skal kunne vises på listen **Firma** i skærmbilledet Brugere, skal firmaet vises på firmalisten på fanen **Vores firmaer**.

* Hvilke virksomheder kan defineres som ejere af en satellit.

### Kolonner på virksomhedslisten

| Kolonne | Beskrivelse |
|---|---|
| Firmanavn | Firmaets navn. |
| Afdeling | Navnet på afdelingen i virksomheden. |
| By | Hvor virksomheden er beliggende. |
| Medarbejdere | Hvor mange medarbejdere der er oprettet til virksomheden. |
| Aktiv satellit | Om virksomheden er optaget som en aktiv satellit. |

## Brugerlicenser

På fanen **Brugerlicenser** på Brugerskærmen kan du se, hvor mange brugerlicenser der er i brug, og hvilke brugere der bruger de forskellige licenser.

* Klik på en licens på listen **Brugerlicenser** for at få vist en liste over de brugere, der aktuelt bruger denne licens.

* Hold musemarkøren over et licensnavn for at se detaljerede oplysninger om licensen.

## Brugergrupper

På fanen **Brugergrupper** på skærmbilledet Brugere kan du få et overblik over brugere og brugergrupper. Klik på et gruppenavn på **listen Tilgængelige grupper** for at få vist en liste over de brugere, der aktuelt er tildelt denne gruppe.

## Hvad vil du foretage dig nu?

* [Tilføjelse af brugere][2]
* [Flyt brugere][3]
* [Sletning af brugere][1]
* [Import af brugere][4]
* [Læs om brugertyper][5]
* [Administrer anonyme brugere og systembrugere (onsite)][11]
* [Tilføj og fjern firmaer fra fanen Vores firmaer][8]
* [Filtrer og gruppér brugere][6]

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
