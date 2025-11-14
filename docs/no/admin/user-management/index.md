---
uid: help-no-users
title: Brukere
description: Finn ut hvordan du legger til nye brukere, hvordan du tilordner de riktige brukerrollene og -gruppene, og hvordan du hjelper brukerne med oppsett og WebTools.
keywords: Skjermbildet Brukere, bruker, medarbeider, våre firmaer, synlighet, tilgjengelig
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
  - /no/admin/user-management/learn/index
  - /no/admin/user-management/learn/screen/index
  - /no/admin/user-management/learn/visibility
  - /no/admin/user-management/learn/associates-filter-group
language: no
---

# Brukere

Som administrator har du ansvar for å legge til og administrere brukere.

SuperOffice CRM benytter et rolle‑ og gruppebasert tilgangsrettighetssystem. Det betyr at **hver SuperOffice‑bruker har en rolle og tilhører en primær gruppe** (disse er obligatoriske innstillinger).

Følgende diagram viser en modell for hvordan tilgangsrettighetssystemet fungerer i SuperOffice CRM.

![Diagram som viser tilgangsrettighetssystemet][img1]

En [rolle][6] har et sett med data‑ og [funksjonelle rettigheter][7], og en gruppeattribusjon gir tilgang til dataobjekter, ulike SuperOffice‑lister og hjelper deg å sette systempreferanser mer effektivt.

Systemet gjør det mulig å konfigurere tilgang til bedrifter, kontakter, prosjekter, prosjektmedlemmer, utvalg, salg, interessenter (i salg), oppfølginger, dokumenter (inkludert e‑post og utsendelser), relasjoner (kontakt og bedrift) og dashboards. Alle disse ulike typer poster kalles **dataobjekter**.

Hvert dataobjekt tilhører en bruker som kan være deg selv (a), brukere i din primære gruppe (b), brukere som tilhører dine andre grupper (c), andre medarbeidere som du ikke er koblet til via noen av dine grupper (d), eksterne brukere (e), og anonyme brukere (f).

![Roller ‑ Medarbeidere‑skjerm, datarettigheter‑fane ‑screenshot][img2]

Eierskapet til forskjellige dataobjekter settes i ulike felt. For eksempel angir feltet **Vår kontakt** i bedriftskortet eieren av posten. For oppfølginger er det feltet **Eier**, i prosjektet **Ansvarlig**, og så videre.

## <a id="visible"></a>Synlighet

Om du kan vise spesifikke dokumenter, salg, oppfølginger og utvalg, avhenger ikke bare på rollen du er tildelt. Det kan også skyldes at den aktuelle informasjonen ikke er tilgjengelig for deg. I dialogboksene for dokumenter og oppfølginger og i Salg- og Utvalg- bildene finner du en listeboks som heter **Synlig for**. I Salg-bildet kan du for eksempel velge om salget skal være synlig for alle, synlig bare for primærgruppen som eieren tilhører eller synlig bare for eieren.

Dette krever lisensen **Konfidensielle aktiviteter**.

For å angi denne lisensen finner du ønsket bruker, klikker på fanen **Lisenser**, og deretter klikker du på avmerkingsboksen for **Konfidensielle aktiviteter**.

## Brukertyper

* **Medarbeidere**: SuperOffice CRM-brukere (i ditt firma)

* **Andre brukere**: Anonyme brukere og systembrukere (kun Onsite)

* **Anonyme brukere**: Brukere med begrensede rettigheter definert av [rollen for anonyme brukere][4]. Anonyme brukere kan for eksempel brukes til å gi tilgang til websider. Slik kan for eksempel selgere gjøre relevant informasjon fra SuperOffice CRM tilgjengelig på en webside som ikke krever pålogging, slik at kunder lett kan få tilgang til denne informasjonen.

* **Systembrukere**: Systembrukeren er ment for integrasjon og kan brukes til for eksempel å gi prosesser full tilgang til SuperOffice-databasen for replikering av dagbøker.

## Medarbeidere

**Medarbeidere** er SuperOffice-brukere i firmaet ditt (eller et tilknyttet firma, for eksempel et datterselskap).

I fanen **Medarbeidere** i Brukere-bildet kan du blant annet legge til brukere av typen **Medarbeider** og tildele dem roller, grupper og lisenser, redigere eksisterende brukere og slette brukere.

For at en person skal kunne defineres som SuperOffice CRM-bruker, må vedkommende være registrert hos et firma som vises i listeboksen **Firma** i Brukere-bildet. Og for at et firma skal kunne vises i listeboksen **Firma** i Brukere-bildet, må firmaet vises på firmalisten i fanen **Våre firmaer**.

> [!NOTE]
> I Brukere-bildet angir du hvilke lisenser de ulike brukerne skal ha. For å legge til nye systemlisenser eller øke/redusere antall lisenser for én eller flere moduler må du kontakte SuperOffice for å [oppdatere lisensinformasjonen][16].

## Brukergrupper

En **gruppe** blir tildelt brukeren og gir tilgang til dataobjekter (4 i forrige diagram). En bruker må ha en **primær gruppe** og kan ha flere **andre grupper**.

![Diagram for gruppetilhørighet][img5]

I dette eksemplet har bruker A Marketing som annen gruppe og bruker B har Marketing som primær gruppe. I dette tilfellet, hvis bruker A ønsker å se data opprettet av bruker B, må bruker A sin rolle ha retten "Les" ved siden av alle dataobjekter i kolonnen *Annen gruppe*. Dette er fordi Marketing‑gruppen er andre gruppe for bruker A og forbinder dem med postene som bruker B oppretter.

En gruppe kan også gi tilgang til listeelementer (5 i diagrammet) i SuperOffice CRM. Dette gjelder kun hvis du bruker innstillingen **Gruppering og filtrering** (a) på listene dine. Hvis denne innstillingen ikke er aktivert, har alle brukere tilgang til alle lister i SuperOffice CRM. Gruppering og filtrering er spesielt nyttig når mange brukere med ulike ansvarsområder får tilgang til systemet. På denne måten kan du unngå at enkelte brukere får tilgang til informasjon de ikke bør se.

![Gruppering og filtrering etter brukergruppe for dokumentmal‑liste –screenshot][img6]

For eksempel, hvis du ønsker å gjøre et bestemt listeelement synlig kun for noen brukere, må du gå til listen som inneholder disse elementene (a), velge elementet (b) og i boksen "Synlig for brukergrupper", sette et kryss ved de brukergruppene som skal se listeelementet (c).

![Velg preferansenivå gruppe for oppfølging –screenshot][img7]

Å organisere brukerne dine i grupper er også praktisk når du ønsker å tilpasse SuperOffice‑innstillinger, som vi kaller [preferanser][15] (6). Hver preferanse kan settes for én bruker, brukergruppe eller hele systemet.

![Preferanser for Salgs‑gruppe –screenshot][img8]

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
| Rolle | [Rollen][6] som er angitt for brukeren. Rollen definerer hvilke tilgangsrettigheter brukeren har til data i SuperOffice CRM. |
| Brukerplan | Brukerplanen som er angitt for brukeren. |
| Eierfirma | Navnet på organisasjon brukeren tilhører (definert som databaseeier). |

> [!TIP]
> Du kan velge hvilke kolonner som vises i oversikten. Bare høyreklikk på en kolonneoverskrift, og velg de relevante kolonnene i kolonnelisten. Hvis du vil endre rekkefølgen på kolonnene, kan du klikke på en kolonneoverskrift og dra den til en ny plassering.

* **Søke etter brukere:** Med denne dynamiske søkefunksjonen kan du raskt finne bestemte brukere etter navn eller bruker-ID, eller til å finne alle brukere som tilhører bestemte roller, grupper eller brukerplaner. Bare skriv i søkefeltet for å oppdatere listen med brukere som samsvarer med søketeksten.

* **Vis bare brukere med påloggingsrettigheter:** Velg dette alternativet hvis du bare vil vise brukere som er aktive (altså som ikke er deaktivert).

#### Filtrere listen <i class="ph ph-funnel" aria-hidden="true"></i>

Du kan filtrere listen med brukere etter kolonneoverskrifter.

> [!NOTE]
> Høyreklikk på en kolonne for å legge til flere kolonner du vil filtrere etter.

1. Velg fanen **Medarbeidere**.
1. Høyreklikk på en kolonneoverskrift, eller klikk på <i class="ph ph-gear" aria-label="Gear"></i> øverst til høyre i listen.
1. Velg **Aktiver filter**.
1. Klikk på **OK**. Det legges til filterknapper til hver kolonneoverskrift.
1. Klikk på <i class="ph ph-funnel" aria-label="Filter icon"></i> på kolonnen du vil filtrere.
1. Velg ønskede verdier i listen. Bruk søkefunksjonen hvis listen er lang.
1. Klikk på **Filtrer**.
1. Gjenta trinn 5-7 for å filtrere på flere kolonner.

#### Gruppere listen

Du kan gruppere listen med brukere etter rolle, brukerplan, primærgruppe og lignende. I tillegg kan du gruppere på flere nivåer.

> [!NOTE]
> Høyreklikk på en kolonne for å legge til flere kolonner du vil gruppere på (se også [Tilpasse oversikter][14]).

1. Velg fanen **Medarbeidere**.
1. Høyreklikk på en kolonneoverskrift, eller klikk på <i class="ph ph-gear" aria-label="Gear"></i> øverst til høyre i listen.
1. Se **Aktiver gruppering**.
1. Klikk på **OK**.
1. Klikk på kolonneoverskriften for verdien du vil gruppere på, og dra den til området over kolonnene ("Dra en kolonneoverskrift og ..."). Listen er nå gruppert etter denne verdien.
1. Hvis du vil gruppere etter flere verdier, klikker og drar du en annen kolonneoverskrift til samme område.
1. Klikk og dra gruppeverdiene for å endre rekkefølgen på grupperingsnivåene.
1. Klikk på en gruppeverdi for å endre sorteringsrekkefølgen.

> [!NOTE]
> Hvis du navigerer til en annen fane, tilbakestilles grupperingen.

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

* [Administrere rollene dine][6]
* [Legge til en ny bruker][2]
* [Opprette brukergrupper][3]
* [Endre brukerplaner for aktive brukere][17]

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
