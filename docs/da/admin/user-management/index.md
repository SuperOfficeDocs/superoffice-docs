---
uid: help-da-users
title: Brugere
description: Lær hvordan du tilføjer nye brugere, hvordan du tildeler de rette brugerroller og grupper og hjælper brugerne med opsætning og WebTools.
keywords: Skærmbilledet Brugere, Brugere, medarbejder, vores virksomheder, synlighed, tilgængelig
author: digitaldiina
date: 10.24.2025
version: 10.4
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
category: identity management
topic: user
index: true
redirect_from: 
  - /da/admin/user-management/learn/index
  - /da/admin/user-management/learn/screen/index
  - /da/admin/user-management/learn/visibility
  - /da/admin/user-management/learn/associates-filter-group
language: da
---

# Brugere

Som administrator har du ansvaret for at tilføje og administrere dine brugere.

SuperOffice CRM anvender et rolle‑ og gruppebaseret adgangsrettighedssystem. Det betyder, at **hver SuperOffice‑bruger har en rolle og tilhører en primær gruppe** (disse indstillinger er obligatoriske).

Følgende diagram viser en model af, hvordan adgangsrettighedssystemet fungerer i SuperOffice CRM.

![Diagram viser adgangsrettighedssystemet][img1]

En [rolle][6] har et sæt data‑ og [funktionelle rettigheder][7], og en gruppetildeling giver adgang til dataobjekter, forskellige SuperOffice‑lister og hjælper med at indstille systempræferencer effektivere.

Systemet giver dig mulighed for at konfigurere adgang til firmaer, personer, projekter, projektmedlemmer, udvalg, salg, interessenter (af salg), opfølgninger, dokumenter (inklusive e‑mails og udsendelser), relationer (person og firma), og dashboards. Alle disse forskellige typer poster kaldes **dataobjekter**.

Hvert dataobjekt tilhører en bruger som kan være dig selv (a), brugere i din primære gruppe (b), brugere der tilhører dine øvrige grupper (c), andre medarbejdere som du ikke er forbundet med via nogen af dine grupper (d), eksterne brugere (e), og anonyme brugere (f).

![Rollen ‑ Ansatte‑skærm, fanen datarettigheder ‑screenshot][img2]

Ejerskabet af forskellige dataobjekter er sat i forskellige felter. For eksempel angiver feltet **Vores kontakt** i firma‑kortet ejeren af posten. For opfølgninger er det feltet **Ejer**, i projektet **Ansvarlig**, og så videre.

## <a id="visible"></a>Synlig for

Hvis du kan se specifikke dokumenter, afhænger salg, opfølgning og valg ikke udelukkende af den rolle du er tildelt. Visse individuelle oplysninger er muligvis ikke tilgængelige for dig. I dokumenter og opfølgningsdialogerne og på skærmene Salg og Udvalg er der et felt ved navn **Synlig for**. På skærmen Salg kan du f.eks. vælge at gøre salget synligt for alle, kun synligt for den primære gruppe, som ejeren tilhører, eller kun synligt for ejeren.

Dette kræver licensen **Fortrolige aktiviteter**.

For at indstille denne licens skal du finde den ønskede bruger, klikke på fanen **Licenser** og derefter klikke på afkrydsningsfeltet for **Fortrolige aktiviteter**.

## Brugertyper

* **Medarbejdere**: SuperOffice CRM-brugere (i dit firma)

* **Andre brugere**: Anonyme brugere og systembrugere (kun onsite)

* **Anonyme brugere**: Brugere med begrænsede rettigheder, defineret af [rollen for anonyme brugere][4]. Anonyme brugere kan f.eks. bruges til at give adgang til websider. På den måde kan sælgere gøre relevante oplysninger fra SuperOffice CRM tilgængelige på et websted, som ikke kræver logon, sådan at kunder let kan få adgang til dem.

* **Systembrugere**: Systembrugeren er beregnet til integration og kan f.eks. bruges til at give processer fuld adgang til SuperOffice-databasen ved replikering af kalendere.

## Medarbejdere

**Medarbejdere** er SuperOffice-brugere i dit firma (eller et tilknyttet firma, for eksempel et datterselskab).

Under fanen **Medarbejdere** i skærmbilledet Brugere kan du blandt andet tilføje brugere af typen **Medarbejder**, og tildele dem roller, grupper og licenser, redigere eksisterende brugere og slette brugere.

For at en person skal kunne defineres som SuperOffice CRM-bruger, skal den pågældende være registreret hos et firma, som vises på listen **Firma** i skærmbilledet Brugere. Og for at et firma skal kunne vises på listen **Firma** i skærmbilledet Brugere, skal firmaet vises på firmalisten på fanen **Vores firmaer**.

> [!NOTE]
> I skærmbilledet Brugere angiver du, hvilke licenser de forskellige brugere skal have. Hvis du vil tilføje nye systemlicenser eller øge/reducere antallet af licenser for et eller flere moduler, skal du kontakte SuperOffice for at [opdatere licensoplysningerne][16].

## Brugergrupper

En **gruppe** tildeles brugeren og giver adgang til dataobjekter (4 i forrige diagram). En bruger skal have en **primær gruppe** og kan have flere **andre grupper**.

![Diagram for gruppemedlemskab][img5]

I dette eksempel har bruger A Marketing som anden gruppe og bruger B har Marketing som primær gruppe. I dette tilfælde, hvis bruger A vil se data oprettet af bruger B, skal bruger A’s rolle have rettigheden "Læs" ud for alle dataobjekter i kolonnen *Anden gruppe*. Det skyldes, at Marketing‑gruppen er anden gruppe for bruger A og forbinder dem til de poster, bruger B opretter.

En gruppe kan også give adgang til listeelementer (5 i diagrammet) i SuperOffice CRM. Dette gælder kun, hvis du bruger indstillingen **Gruppering og filtrering** (a) på dine lister. Hvis denne indstilling ikke er oprettet, har alle brugere adgang til alle lister i SuperOffice CRM. Gruppering og filtrering er særligt nyttig, når mange brugere med forskellige ansvarsområder kan tilgå systemet. På denne måde kan du undgå, at visse brugere får adgang til information, de ikke bør se.

![Gruppering og filtrering efter brugergruppe for dokument­skabelon­lister –screenshot][img6]

For eksempel, hvis du ønsker at gøre et bestemt listeelement synligt kun for nogle brugere, skal du gå til den liste, der gemmer disse elementer (a), vælge elementet (b) og i boksen kaldet "Synlig for brugergrupper", sætte et hak ved de brugergrupper, der skal se listeelementet (c).

![Vælg præference­niveau gruppe for opfølgning –screenshot][img7]

At organisere dine brugere i grupper er også praktisk, når du ønsker at personalisere SuperOffice‑indstillinger, som vi kalder [præferencer][15] (6). Hver præference kan sættes for én bruger, brugergruppe eller for hele systemet.

![Præferencer for Salgs‑gruppe –screenshot][img8]

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
| Rolle | [Rollen][6], som er angivet for brugeren. Rollen definerer, hvilke adgangsrettigheder brugeren har til data i SuperOffice CRM. |
| Brugerplan | Brugerplanen, som er tildelt brugeren. |
| Ejerfirma | Navnet på den organisation, brugeren tilhører (defineret som databaseejer). |

> [!TIP]
> Du kan vælge, hvilke kolonner der skal vises på listen. Højreklik på en kolonneoverskrift, og vælg de relevante kolonner på kolonnelisten. Hvis du vil ændre rækkefølgen af kolonnerne, skal du klikke og trække i en kolonneoverskrift.

* **Søg efter brugere:** Brug denne dynamiske søgefunktion til hurtigt at finde bestemte brugere efter navn eller bruger-ID eller til at finde alle brugere, der tilhører bestemte roller, grupper eller brugerplaner. Du skal blot indtaste tekst i søgefeltet for at opdatere listen med tilsvarende brugere.

* **Vis kun brugere, der kan logge på:** Vælg denne indstilling for kun at få vist brugere, der er aktive (dvs. ikke er blevet deaktiveret).

#### Filtrering af listen <i class="ph ph-funnel" aria-hidden="true"></i>

Du kan filtrere listen over brugere efter en hvilken som helst af kolonneoverskrifterne.

> [!NOTE]
> Højreklik på en kolonne for at tilføje eventuelle yderligere kolonner, du vil filtrere efter.

1. Gå til fanen **Medarbejdere**.
1. Højreklik på en kolonneoverskrift, eller klik på <i class="ph ph-gear" aria-label="Gear"></i> i øverste højre hjørne af listen.
1. Vælg **Aktivér filter**.
1. Klik på **OK**. Filterknapper føjes til hver kolonneoverskrift.
1. Klik på <i class="ph ph-funnel" aria-label="Filter icon"></i> i den kolonne, du vil filtrere.
1. Vælg de relevante værdier på listen. Brug søgefunktionen, hvis listen er lang.
1. Klik på **Filtrer**.
1. Gentag trin 5-7 for at filtrere på yderligere kolonner.

#### Gruppering af listen

Du kan gruppere listen over brugere efter rolle, brugerplan, primær gruppe og lignende. Derudover kan du gruppere på flere niveauer.

> [!NOTE]
> Højreklik på en kolonne for at tilføje eventuelle yderligere kolonner, du vil filtrere efter (se også [Juster visninger][14]).

1. Gå til fanen **Medarbejdere**.
1. Højreklik på en kolonneoverskrift, eller klik på <i class="ph ph-gear" aria-label="Gear"></i> i øverste højre hjørne af listen.
1. Vælg **Aktivér gruppering**.
1. Klik på **OK**.
1. Klik på kolonneoverskriften for den værdi, du vil gruppere, og træk den til området over kolonnerne ("Træk en kolonneoverskrift og ..."). Listen grupperes nu efter den værdi.
1. Hvis du vil gruppere efter yderligere værdier, skal du klikke på og trække en anden kolonneoverskrift til det samme område.
1. Klik på og træk i gruppeværdierne for at ændre rækkefølgen af grupperingsniveauerne.
1. Klik på en gruppeværdi for at ændre sorteringsrækkefølgen.

> [!NOTE]
> Hvis du navigerer til en anden fane, nulstilles grupperingen.

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

* [Administration af dine roller][6]
* [Tilføj en ny bruger][2]
* [Opret brugergruppe][3]
* [Ændre brugerplaner for aktive brugere][17]

<!-- Referenced links -->
[2]: add-associate.md
[3]: user-groups.md
[4]: onsite/other-users.md#rights
[6]: role/index.md
[7]: role/functional-rights.md
[14]: ../adjusting-views.md
[15]: ../preferences/index.md
[16]: ../license/activate.md
[17]: ../license/change-user-plan.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/admin/access-right-system.png
[img2]: ../../../media/loc/en/admin/user-access-level.png
[img3]: ../../../media/loc/en/admin/admin-users-overview.png
[img5]: ../../../media/loc/en/admin/groups.png
[img6]: ../../../media/loc/en/admin/lists-grouping.png
[img7]: ../../../media/loc/en/admin/follow-up-type.png
[img8]: ../../../media/loc/en/admin/sales-group.png
