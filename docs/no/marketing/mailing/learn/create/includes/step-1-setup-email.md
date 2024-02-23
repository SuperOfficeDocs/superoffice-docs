<!-- markdownlint-disable-file MD041 -->
Det første trinnet når du skal lage en utsendelse for e-post, kalles **Oppsett**. Her kan du angi informasjonen i meldingshodet, slik som avsender, svaradresse og emne. Du kan også legge til vedlegg, angi arkiveringsalternativer for utsendelsen og velge sporingsalternativer.

1. Skriv inn et navn i feltet **Navn på utsendelse**.

1. Skriv inn emnet på e-posten i feltet **E-postemne**.

1. I **Fra**-listen velger du **Bruk alltid** og skriver inn avsenders e-postadresse i feltet nedenfor for å bruke samme avsender for alle utsendelser. Du kan også velge at en salgsperson eller supportperson skal stå som avsender, hvis de er angitt for den aktuelle mottakeren. Skriv inn en e-postadresse som skal brukes hvis ingen salgsperson eller supportperson er tilgjengelig. Hvis administratoren har aktivert [preferansen e-postvarsel for global][2], velger du domenet du vil sende fra, i nedtrekksmenyen.

    [!include[Note](spf-look-up.md)]

1. I listen **Svar til** har du de samme alternativene som over. I tillegg kan du velge **Bruk "Fra" som avsenderadresse**. Alle svar vil deretter bli sendt til avsenderen.

1. I listen **Mappe** velger du en mappe du vil plassere utsendelsen i.

    [Hvordan oppretter jeg en utsendelsesmappe?][4]

1. I feltene **Utvalg** og **Prosjekt** kan du knytte utsendelsen til et utvalg og/eller et prosjekt. Hvis du legger til et utvalg, legges eventuelle personer i utvalget til som mottakere i utsendelsen.

    [!include[Start typing to search](type-to-search.md)]

1. I listen **Type** velger du typen utsendelse du oppretter. Velg **(Noen)** hvis utsendelsen samsvarer med to eller flere av de tilgjengelige typene. Bruk **(Noen)** etter at du har lagt til flere mottakere med flere abonnementer og vil sende utsendelsen til alle.

1. **Vedlegg**: Hvis du vil legge til ett eller flere vedlegg i utsendelsen, velger du en av følgende metoder:

    * Klikk på **Last opp filer (eller dra og slipp her)** for å bla til og legge til en fil fra en disk eller server.
    * Dra og slipp en fil fra Windows Utforsker til feltet for vedlegg.
    * Klikk på **Velg et CRM-dokument** for å velge et dokument i SuperOffice CRM.

1. Under **Sporing** finner du følgende alternativer:

    [!include[Tracking options for mailing](mailing-tracking-options.md)]

1. Klikk på **Neste** for å gå til neste trinn.

## Validering av e-postdomene (KUN PÅ NETT)

Hvis administratoren har aktivert **[global preferanse][2]** Du må bare bruke godkjente e-postdomener**, **Fra-adresse**-feltet vil være delt, og du må velge domenet du vil sende fra, i nedtrekksmenyen med godkjente domener.
Forsøk på å sende fra et domene som ikke har en gyldig SPF-oppføring, vil utløse en advarsel, og du vil ikke kunne sende fra det domenet. Dette gjelder for alle e-postdomener, selv om valideringspreferansen ikke er aktivert.

> [!NOTE]
> Hvis **Vår kontaktadresse** har et e-postdomene som ikke er validert, sendes utsendelsen automatisk fra adressen som er angitt i alternativene **Ellers bruk** i nedtrekksmenyen.

<!-- Referenced links -->
[2]: ../../../../../admin/lists/learn/add-items-to-mailing-domain.md
[4]: ../../../../learn/create-folder.md

<!-- Referenced images -->
