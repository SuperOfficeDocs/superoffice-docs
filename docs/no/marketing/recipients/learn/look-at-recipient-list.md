---
uid: help-no-mailing-recipient-list
title: Arbeide med mottakerlisten i etterkant av utsendelsen
description: Arbeide med mottakerlisten i etterkant av utsendelsen
keywords: Markedsføring, mottaker
author: SuperOffice RnD
date: 02.09.2024
version: 10
topic: howto
language: no
audience: person
audience_tooltip: SuperOffice Marketing
---

# Se på mottakerlisten i etterkant av utsendelsen

Etter at utsendelsen er sendt, er det alltid spennende å se hvor godt den har gjort det. Det er også en flott mulighet til å kontrollere og forbedre kvaliteten på informasjonen som er registrert i databasen. Spesielt er antallet returnerte e-poster en nøkkelindikator. I denne veiledningen kan du finne ut hvordan du filtrerer mottakerlisten.

SuperOffice Marketing samler inn data om statusen for hver sendte e-post. I fanen Mottakere kan du vise status for alle mottakerne av utsendelsen. Du kan også filtrere listen og eksportere resultatene til utvalgene og prosjektene i SuperOffice CRM for videre behandling.

![Du kan se statusen for utsendelsen i Status-feltet -screenshot][img4]

## Trinn

1. Klikk på utsendelsen i fanen **Utsendelser**.

2. I bildet **Vis utsendelse** klikker du på fanen **Mottakere**.

    Listen viser de 100 første mottakerne. Klikk på <i class="ph ph-arrow-right" aria-label="Arrow right"></i> for å vise de neste 100.

3. [Filtrer listen](#filters) ved å bruke avmerkingsboksene nederst i listen.

    Alle filtre er som standard aktive for å vise alle mottakere. Fjern merket for en filteravmerkingsboks for å deaktivere filteret. Flere filtre kan kombineres.

4. Bruk avmerkingsboksene i venstre kolonne for å velge alle eller bestemte mottakere.

5. Klikk på menyknappen **Handlinger**. Her har du følgende alternativer:
    * Eksporter de valgte mottakerne til en Excel-, HTML- eller tekstfil.
    * [Legg de valgte mottakerne til i et nytt eller eksisterende utvalg eller prosjekt.](#add-recipients)
    * Send utsendelsen på nytt til de valgte mottakerne.

6. Klikk på **Lukk** for å lukke bildet **Vis utsendelse**.

Hvis statusen er **Klar til å sende**, trenger du ikke å gjøre noe. SuperOffice sender utsendelsene til mottakerne. Statusen endres til **Sendt** etter at dette er gjort.

## <a id="filters"></a>Filtre

* **Sendt**: Aktiver dette filteret for å vise alle mottakere som utsendelsen er sendt til.

* **Returnert**: Aktiver dette filteret for å vise alle mottakere av [utsendelser som har kommet i retur][3]. Dette kan skyldes feil i e-postadresser, søppelpost-/spamfiltre, Internett-problemer eller fulle innbokser.

* **Lest av mottaker**: Aktiver dette filteret for å vise alle mottakere som åpnet/leste utsendelsen.

* **Klar til å sendes**: Aktiver dette filteret for å vise alle mottakere som ennå ikke har fått tilsendt utsendelsen.

* **Blokkert**: Aktiver dette filteret for å vise følgende mottakere:

* Mottakere som ikke har samtykket i å bli kontaktet
* Dupliserte mottakere
* [Mottakere uten abonnement][5]

**Mottaker klaget**: Aktiver dette filteret for å vise mottakere som rapporterte utsendelsen som [spam/søppelpost][4].

Hvis statusen er **Klar til å sendes**, trenger du ikke å gjøre noe. SuperOffice sender utsendelsene til mottakerne. Statusen endres til **Sendt** når dette er gjort.

## <a id="add-recipients"></a>Legge til mottakere i utvalg eller prosjekter

Ved å bruke menyknappen **Handlinger** kan du legge til mottakere eller klikkere i et utvalg eller prosjekt.

> [!NOTE]
> Bare personer som allerede er registrert i SuperOffice-databasen, vil bli lagt til i utvalget eller prosjektet. Et personikon (<i class="ph ph-user-circle" aria-hidden="true"></i>) i **Type**-kolonnen indikerer at en person er registrert i SuperOffice-databasen. Mottakere som er importert fra eksterne lister, vil vanligvis ikke bli registrert.

### Legge til klikkere i et nytt utvalg eller prosjekt

1. Velg de aktuelle personene i listen.
2. Klikk på **Handlinger**.
3. Klikk på **Legg til i eksisterende utvalg** eller **Legg til i eksisterende prosjekt**.
4. Begynn med å skrive inn navnet på utvalget eller prosjektet for å søke.
5. Klikk på utvalget eller prosjektet i listen.
6. Klikk på **OK**.

### Legge til klikkere i et eksisterende utvalg eller prosjekt

1. Velg de aktuelle personene i listen.
2. Klikk på **Handlinger**.
3. Klikk på **Legg til i nytt utvalg** eller **Legg til i nytt prosjekt**.
4. Skriv inn navnet på det nye utvalget eller prosjektet.
5. Klikk på **OK**.

Åpne utvalget eller prosjektet for å bekrefte at personene ble lagt til.

## Aktuelle emner

* [Arbeide med sporede koblinger i etterkant av utsendelsen][1]

<!-- Referenced links -->
[1]: ../../tracked-links/learn/explore-clicks.md
[3]: manage-bounces.md
[4]: spam-complaints.md
[5]: manage-email-subscriptions.md

<!-- Referenced images -->
[img4]: ../../../../media/loc/en/marketing/recipients-tab-status.png
