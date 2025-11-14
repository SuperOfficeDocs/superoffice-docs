---
uid: help-da-users
title: Brugere
description: Lær hvordan du tilføjer nye brugere, hvordan du tildeler de rette brugerroller og grupper og hjælper brugerne med opsætning og WebTools.
keywords: Skærmbilledet Brugere, Brugere, medarbejder, vores virksomheder
author: SuperOffice Product and Engineering
date: 02.21.2023
version: 10.5
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
language: da
redirect_from: /da/admin/user-management/learn/screen/index
---

# Brugere

Som administrator har du ansvaret for at tilføje og administrere dine brugere. I dette afsnit kan du lære, hvordan du tilføjer nye brugere, hvordan du tildeler de rette brugerroller og grupper og hjælper brugerne med opsætning og WebTools.

## Brugertyper

* **Medarbejdere**: SuperOffice CRM-brugere (i dit firma)

* **Andre brugere**: Anonyme brugere og systembrugere (kun onsite)

* **Anonyme brugere**: Brugere med begrænsede rettigheder, defineret af [rollen for anonyme brugere][4]. Anonyme brugere kan f.eks. bruges til at give adgang til websider. På den måde kan sælgere gøre relevante oplysninger fra SuperOffice CRM tilgængelige på et websted, som ikke kræver logon, sådan at kunder let kan få adgang til dem.

* **Systembrugere**: [!include[Access rights](includes/def-system-user.md)]

    Systembrugeren er beregnet til integration og kan f.eks. bruges til at give processer fuld adgang til SuperOffice-databasen ved replikering af kalendere.

## Medarbejdere

**Medarbejdere** er SuperOffice-brugere i dit firma (eller et tilknyttet firma, for eksempel et datterselskab).

Under fanen **Medarbejdere** i skærmbilledet Brugere kan du blandt andet tilføje brugere af typen **Medarbejder**, og tildele dem roller, grupper og licenser, redigere eksisterende brugere og slette brugere.

For at en person skal kunne defineres som SuperOffice CRM-bruger, skal den pågældende være registreret hos et firma, som vises på listen **Firma** i skærmbilledet Brugere. Og for at et firma skal kunne vises på listen **Firma** i skærmbilledet Brugere, skal firmaet vises på firmalisten på fanen **Vores firmaer**.

> [!NOTE]
> I skærmbilledet Brugere angiver du, hvilke licenser de forskellige brugere skal have. Hvis du vil tilføje nye systemlicenser eller øge/reducere antallet af licenser for et eller flere moduler, skal du kontakte SuperOffice for at [opdatere licensoplysningerne][6].

## <a id="screen"></a>Skærmbilledet Brugere

I skærmbilledet Brugere kan du tilføje og redigere forskellige brugertyper.

![En oversigt over brugerskærmen i Indstillinger og vedligeholdelse -screenshot][img3]

[**vores virksomheder:**][2] For at en person skal kunne defineres som SuperOffice CRM-bruger, skal den pågældende være registreret hos et firma, som vises på listen **Firma** i skærmbilledet Brugere. Og for at et firma skal kunne vises på listen **Firma** i skærmbilledet Brugere, skal firmaet vises på firmalisten på fanen **Vores firmaer**.

> [!NOTE]
> Eventuelle ændringer, du foretager i skærmbilledet Brugere, træder ikke i kraft, før du klikker på **Gem** nederst i skærmbilledet, eller bekræfter, at du vil gemme ændringen/ændringerne, i dialogboksen som vises. Hvis du klikker på **Afbryd**, mister du alt det, du har foretaget i skærmbilledet, siden du gemte sidst.

### <a id="associates"></a>Medarbejderlisten

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

#### Brugeroplysninger

Yderst til højre i vinduet finder du detaljerede oplysninger om den bruger, der er markeret på listen over medarbejdere.

Det fulde navn, e-mailadresse og ejerfirma vises øverst. Nederst i dette afsnit kan du aktivere/deaktivere brugeren i SuperOffice ved hjælp af knappen **Kan logge på**. Klik på knappen **Opgave** for at få adgang til funktioner som **Flyt bruger** og for at sende velkomst-e-mails og e-mails til nulstilling af adgangskoder.

Der er forskellige faner i brugeroversigten:

* **Detaljer** - hovedoversigt over brugeroplysninger som **Bruger-ID**, **Rolle**, **Brugerplan**, **Primær gruppe** og **Service-kategorier**.
* **Licenser** - ekstra licensoplysninger som **Fortrolige aktiviteter**, som vil give brugeren mulighed for at angive **synlig for** på opfølgingerr, dokumenter og valg.
* **Mere** - fanen viser, om der er ekstra felter på personen.

### <a id="other-users"></a>Andre brugere (Onsite)

På fanen **Andre brugere** på skærmen Brugere kan du redigere logonrettigheder for og tilføje anonyme brugere og systembrugere.

### <a id="our-companies"></a>Vores virksomheder

Formålet med virksomhedslisten på fanen **Vores virksomheder**på skærmbilledet Brugere er at angive:

* Hvem kan defineres som brugere af SuperOffice CRM. For at en person skal kunne defineres som SuperOffice CRM-bruger, skal den pågældende være registreret hos et firma, som vises på listen **Firma** i skærmbilledet Brugere. Og for at et firma skal kunne vises på listen **Firma** i skærmbilledet Brugere, skal firmaet vises på firmalisten på fanen **Vores firmaer**.

* Hvilke virksomheder kan defineres som ejere af en satellit.

#### Kolonner på virksomhedslisten

| Kolonne | Beskrivelse |
|---|---|
| Firmanavn | Firmaets navn. |
| Afdeling | Navnet på afdelingen i virksomheden. |
| By | Hvor virksomheden er beliggende. |
| Medarbejdere | Hvor mange medarbejdere der er oprettet til virksomheden. |
| Aktiv satellit | Om virksomheden er optaget som en aktiv satellit. |

### Brugerlicenser

På fanen **Brugerlicenser** på Brugerskærmen kan du se, hvor mange brugerlicenser der er i brug, og hvilke brugere der bruger de forskellige licenser.

* Klik på en licens på listen **Brugerlicenser** for at få vist en liste over de brugere, der aktuelt bruger denne licens.

* Hold musemarkøren over et licensnavn for at se detaljerede oplysninger om licensen.

### Brugergrupper

På fanen **Brugergrupper** på skærmbilledet Brugere kan du få et overblik over brugere og brugergrupper. Klik på et gruppenavn på **listen Tilgængelige grupper** for at få vist en liste over de brugere, der aktuelt er tildelt denne gruppe.

## Relateret indhold

* [Administration af dine roller][1]
* [Tilføjelse af en ny bruger][2]
* [Ændring af brugerplaner for aktive brugere][3]
* [Installation af WebTools til dine brugere][7]

<!-- Referenced links -->
[1]: role/index.md
[2]: add-associate.md
[3]: change-user-plan.md
[4]: role/edit-rights-for-anonymous-users.md
[6]: ../../license/learn/activate.md
[7]: https://docs.superoffice.com/integrations/webtools/install.html

<!-- Referenced images -->
[img3]: ../../../../media/loc/en/admin/admin-users-overview.png
