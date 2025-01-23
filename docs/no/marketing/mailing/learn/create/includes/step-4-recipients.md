<!-- markdownlint-disable-file MD041 MD034 -->
Når du oppretter en utsendelse, må du velge mottakerne av utsendelsen. Du kan legge til mottakere fra flere kilder. I tillegg kan du her angi ulike utsendelsesalternativer og forhåndsvise utsendelsen.

Mållisten er gruppen med personer du tror vil reagere best på meldingen din. Hvis du skreddersyr markedsføringsmeldingen din spesifikt til den gruppen, får du en større sjanse til å lykkes og unngår å kaste bort tid og krefter på folk som ikke er interessert.

Du kan bruke utvalg, prosjekter eller legge til enkeltpersoner i SuperOffice CRM.

På grunn av GDPR-lovgivningen er det bare personene som har gitt samtykke til å bli lovlig lagret i SuperOffice CRM-databasen og motta informasjon, som kan legges til som mottakere.

![Du kan legge til mottakere fra utvalg, prosjekt, én enkelt person eller en ekstern liste som du må importere -screenshot][img3]

## Legge til mottakere fra utvalg og prosjekter

Du kan legge til mottakere fra utvalg (fra både SuperOffice CRM og SuperOffice Service) og prosjekter (fra SuperOffice CRM).

1. Under **Legg til mottakere** klikker du på **Utvalg** eller **Prosjekt**.

2. Klikk i feltet nedenfor og begynn å skrive inn navnet på utvalget eller prosjektet du vil legge til. Mens du skriver, viser en dynamisk liste de ulike treffene.

3. Velg et utvalg eller et prosjekt i listen.

4. Klikk på **+**. Utvalget eller prosjektet legges til i listen **Mottakerkilder**, og listen **Mottakere** oppdateres.

5. Gjenta trinn 1 til 4 for å legge til flere utvalg eller prosjekter.

> [!NOTE]
> Hvis du gjorde et utvalg under **Arkiver utsendelse** i **Oppsett** (trinn 1), står dette utvalget oppført under **Mottakerkilder**. Du kan slette dette utvalget om nødvendig.

## Legge til personer fra SuperOffice

Du kan legge til enkeltpersoner fra SuperOffice.

1. Under **Legg til mottakere** klikker du på **Person**.

2. Klikk i feltet under og begynn å skrive inn navnet på personen du vil legge til. Du kan også angi et firmanavn for å vise alle personer tilknyttet et firma.

3. Velg personen fra listen som vises.

4. Klikk på **+**. Personen legges til i listen **Mottakerkilder**, og listen **Mottakere** oppdateres.

5. Gjenta trinn 2-5 for å legge til flere personer. Ytterligere personer vil bli lagt til i samme rad i listen **Mottakerkilder**, og antall personer vises i kolonnen **Navn**.

## Importere en liste over mottakere (personer) fra en ekstern fil

Du kan legge til mottakere i en utsendelse ved å importere dem fra en ekstern kommadelt fil (for eksempel en TXT-fil opprettet i Notepad eller en CSV-fil opprettet i Excel).

Når du importerer en liste med navn og e-postadresser, prøver SuperOffice Marketing å finne de importerte mottakerne i SuperOffice-databasen. Ved eventuelle treff vil mottakernes firmaer stå oppført i **Firma**-kolonnen i listen **Mottakere**. Eventuelle navn/e-postadresser som **ikke** finnes i SuperOfffice, filtreres ut og inkluderes ikke i utsendelsen. Dette skyldes GDPR-bestemmelser.

### Trinn

1. Klikk på **Velg fil**.

2. Finn den relevante filen (txt, csv eller tilsvarende tekstformat).

3. Klikk på **+**. Listen legges til i **Mottakerkilder**-listen, og **Mottakere**-listen oppdateres.

4. Gjenta trinn 2-4 for å legge til flere mottakere. Ytterligere mottakere vil bli lagt til i samme rad i listen **Mottakerkilder**. Det totale antall mottakere vises i kolonnen **Navn**.

> [!NOTE]
> Import er ikke tilgjengelig for utsendelse av dokumenter.

### Importere filformat

* Hver mottaker må stå på en egen linje (rad).

* Hver mottaker (rad) består av hele navnet og e-postadressen.

    Eksempel: "Jon Sørensen, john@company.com"

    > [!NOTE]
    >Du kan også angi bare e-postadressen. Navnet vil deretter ikke være tilgjengelig som malvariabel.

* Onsite: Hver mottaker (rad) kan også inneholde et mobiltelefonnummer (etter e-postadressen) hvis du oppretter SMS-utsendelser. For eksempel: "Jon Sørensen, john@company.com, 99999999". Krever markedsføringslisens for SMS.

> [!NOTE]
> Hvis du bare har mobiltelefonnummeret og skal sende SMS, kan du angi følgende: " , , 99887766".

## Alternativer for mottakere

Under **Alternativer** i den nedre delen av bildet **Mottakere** kan du velge alternativer for utsendelsen basert på typen.

**Tilgjengelighet per utsendelsestype:**

| Alternativ | Dokument | E-post | SMS |
|---|:-:|:-:|:-:|
| Overstyr samtykke og abonnement | x | x | x |
| Bare én melding per e-postadresse | | x | x |
| Oppdater mottakerliste ved sending | | x | x |
| Ta med firmaer | x | x | |
| Bruk helst firma | x | x | |

* **Overstyr samtykke og abonnement**: Velg dette alternativet hvis du vil sende utsendelsen også til personer som ikke har gitt sitt samtykke til å motta e-markedsføring, eller som ikke abonnerer på denne utsendelsestypen. Disse personene er oppført med statusen **Ikke samtykke** i listen **Mottakere**.

* **Bare én melding per e-postadresse**: Velg dette alternativet for å fjerne dupliserte e-postadresser i mottakerlisten (angitt av **Duplikat** i **Status-kolonnen** ). Dette oppdaterer listen **Mottakere**.

* **Oppdater mottakerliste ved utsendelse**: Velg dette alternativet for å oppdatere mottakerlisten automatisk før utsendelse. Se **Oppdatere mottakerliste** nedenfor.

* **Inkluder firmaer**: Velg dette alternativet for å ta med firmaer som mottakere.

    > [!NOTE]
    >Hvis et selskap ikke har noen e-postadresse, sendes i stedet utsendelsen til alle relaterte personer i mottakerlisten.

* **Foretrekk firma**: Velg dette alternativet for å sende utsendelsen bare til firmaene i mottakerlisten (og ikke de relaterte personene). Hvert firma vil bare motta én utsendelse. Personer som ikke tilhører et selskap, vil fortsatt motta utsendelsen.

    > [!NOTE]
    > Alternativet **Foretrekk firma** er bare tilgjengelig hvis du har valgt **Inkluder firmaer** ovenfor.

## Forhåndsvise utsendelsen

Når du har lagt til mottakere i listen **Mottakere**, kan du forhåndsvise utsendelsen slik den vil se ut for en av mottakerne. Forhåndsvisning er ikke tilgjengelig for utsendelse av dokumenter og SMS-er.

> [!NOTE]
> Utsendelsen sendes **ikke** til mottakeren ved forhåndsvisning.

1. Klikk på en mottaker i listen **Mottakere**.

2. Klikk på knappen **Forhåndsvis**. Vinduet **Forhåndsvis** viser utsendelsen slik den vil se ut for den valgte mottakeren. Alle malvariabler (for eksempel navn og firma) erstattes med faktiske data.

3. Klikk på koblinger for å kontrollere at de fungerer, men husk å nullstille dem hvis de spores.

4. Klikk på X for å lukke **visningsvinduet**.

## Gå gjennom og oppdatere mottakerlisten

Når du legger til utvalg, prosjekter, personer og importerer lister, oppdateres listen **Mottakere** automatisk. Hvis du har valgt **Oppdater mottakerliste ved utsendelse**, vil prosjektene og utvalgene kontrolleres før utsendelsen sendes, i tilfelle personer er lagt til, fjernet eller redigert.

I tillegg kan du klikke på knappen **Oppdater liste** nedenfor listen **Mottakere** for å oppdatere listen manuelt. Enkelte av personene på listen kan ha endret sitt samtykke etter at du la dem til.

> [!NOTE]
> Bare de første 50 mottakerne vises i listen. Klikk på **Last inn alle** nederst i listen for å vise alle mottakere.

Klikk på **Neste** for å gå til trinn 5: Bekreft. Du kan fortsatt gå tilbake til trinnet **Mottakere** for å redigere mottakerlisten.

<!-- Referenced images -->
[img3]: ../../../../../../media/loc/en/marketing/add-target-list.png
