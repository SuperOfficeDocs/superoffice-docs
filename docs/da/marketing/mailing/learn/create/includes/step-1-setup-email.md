<!-- markdownlint-disable-file MD041 -->
Det første trin i oprettelse af en e-mailudsendelse kaldes **Opsætning**. Her kan du angive oplysninger i e-mailens meddelelseshoved som f.eks. afsender, svar-til-adresse samt emne. Du kan også tilføje vedhæftninger, indstille arkiveringsvalg for udsendelsen og vælge sporingsindstillinger.

1. Skriv et navn i feltet **Udsendelsens navn**.

1. Skriv emnet for e-mailen ind i feltet **E-mailens emne**.

1. På listen **Fra** skal du vælge **Brug altid** og skrive afsenderens e-mailadresse ind i feltet nedenfor for at angive samme afsender for alle udsendelser. Du kan også vælge, at salgskontakt eller supportkontakt skal stå som afsender, hvis de er angivet for den aktuelle modtager. Indtast en e-mailadresse, der skal anvendes, hvis der ikke er en tilgængelig salgs- eller supportkontakt. Hvis din administrator har aktiveret den [generelle præference for e-mailvalidering][2], skal du vælge det domæne, du vil sende fra, på rullelisten.

    [!include[Note](spf-look-up.md)]

1. I listen **Svar til** har du samme valg som ovenfor. Samtidig kan du også vælge **Brug "Fra" som svaradresse**. Alle svar vil så blive sendt til afsenderen.

1. Vælg en mappe fra listen **Mappe**, som du vil lægge udsendelsen i.

    [Hvordan opretter jeg en mappe til udsendelser?][4]

1. I felterne **Udvalg** og **Projekt** kan du knytte udsendelsen til et udvalg og/eller et projekt. Hvis du markerer et udvalg, tilføjes alle personer i udvalget som modtagere i udsendelsen.

    [!include[Start typing to search](type-to-search.md)]

1. På listen **Type** vælger du hvilken type udsendelse, du opretter. Vælg **(Hvilken som helst)**, hvis udsendelsen matcher to eller flere af de tilgængelige typer. Anvend **(Hvilken som helst)**, når du har tilføjet flere modtagere med flere abonnementer, og du vil sende ud til dem alle.

1. **Vedhæftning**: Du kan tilføje en vedhæftning til udsendelsen med en af de følgende metoder:

    * Klik på **Upload filer (eller træk her)** for at gennemse og tilføje en fil fra en disk eller en server.
    * Træk og slip en fil fra Windows Stifinder til vedhæftningsfeltet.
    * Klik på **Vælg et CRM-dokument** for at vælge et dokument i SuperOffice CRM.

1. Under **Sporing** finder du følgende valgmuligheder:

    [!include[Tracking options for mailing](mailing-tracking-options.md)]

1. Klik på **Næste** for at gå til det næste trin.

## Validering af e-mail-domæne (KUN ONLINE)

Hvis din administrator har aktiveret [generelle indstillinger][2] i form af **Brug kun godkendte e-mail-domæner**, vil feltet **Fra-adresse** blive delt op, og du skal vælge det domæne, du vil sende fra, i rullelisten over godkendte domæner.
Hvis du forsøger at sende fra et domæne, der ikke har en gyldig SPF-registrering, får du vist en advarsel, og du kan ikke sende fra det domæne. Det gælder for alle e-maildomæner, også selvom valideringspræferencen ikke er aktiveret.

> [!NOTE]
> Hvis **Vores kontaktadresse** har et e-maildomæne, der ikke er valideret, sendes mailudsendelsen automatisk fra den adresse, der er angivet i rullelisten **Ellers brug**.

<!-- Referenced links -->
[2]: ../../../../../admin/lists/learn/add-items-to-mailing-domain.md
[4]: ../../../../learn/create-folder.md

<!-- Referenced images -->
