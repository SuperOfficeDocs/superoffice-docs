<!-- markdownlint-disable-file MD041 -->
Det första steget för att skapa ett e-postutskick är att **konfigurera** utskicket. Här kan du ställa in uppgifter för e-posthuvudet som t.ex. avsändare, svarsadress och ämne. Du kan även bifoga filer, ställa in arkiveringsalternativ för utskicket och välja spårningsalternativ.

1. Ange ett namn i fältet **Namn för utskick**.

1. Ange ämnesraden för e-postmeddelandet i fältet **Ämnesrad för e-post**.

1. I listan **Från**, välj **Använd alltid** och ange sedan avsändarens e-postadress i fältet nedanför om du vill använda samma avsändare i alla utskick. Du kan även sätta en försäljningskontakt eller supportkontakt som avsändare om en sådan kontakt finns definierad för den aktuella mottagaren. Ange den e-postadress som ska användas om ingen försäljningskontakt eller supportkontakt finns tillgänglig. Om administratören har aktiverat inställningen för [global e-postvalidering][2] väljer du den domän du vill skicka från i listrutan.

    [!include[Note](spf-look-up.md)]

1. I listan **Svar till** har du samma alternativ att välja mellan som ovan. Dessutom kan du välja alternativet **Använd "Från" som svarsadress**. Eventuella svar kommer då att skickas till avsändaren.

1. Välj en mapp som du vill placera utskicket i från listan **Mapp**.

    [Hur skapar jag en utskicksmapp?][4]

1. I fälten **Urval** och **Projekt** kan du associera utskicket med ett urval och/eller ett projekt. Om du lägger till ett urval läggs alla kontakter i urvalet till som mottagare i utskicket.

    [!include[Start typing to search](type-to-search.md)]

1. I listan **Typ** väljer du vilken typ av utskick du vill skapa. Välj **(någon)** om utskicket matchar två eller fler av de tillgängliga typerna. Använd **(någon)** när du har lagt till flera mottagare med flera prenumerationer och vill skicka utskicket till alla.

1. **Bilaga**: Om du vill lägga till en eller flera bilagor till utskicket använder du någon av följande metoder:

    * Klicka på **Ladda upp filer (eller dra dem hit)** och bläddra och lägg till en fil från en disk eller server.
    * Dra och släpp en fil från Windows Utforskaren till bilagefältet.
    * Klicka på **Välj ett CRM-dokument** och välj ett dokument i SuperOffice CRM.

1. Under **Spårning** finns följande alternativ:

    [!include[Tracking options for mailing](mailing-tracking-options.md)]

1. Klicka på **Nästa** när du vill gå vidare till nästa steg.

### Validering av e-postdomän (ENDAST ONLINE)

Om administratören har aktiverat den [globala inställningen][2] **Använd endast godkända e-postdomäner** delas fältet **Från adress** upp och du måste välja den domän du vill skicka från i listrutan över godkända domäner.
Om du försöker skicka från en domän som inte har en giltig SPF-post visas en varning och du kan inte skicka från den domänen. Detta gäller för alla e-postdomäner även om valideringsinställningen inte är aktiverad.

> [!NOTE]
> Om **Vår kontaktadress** har en e-postdomän som inte har validerats skickas utskicket automatiskt från den adress som anges i listrutan **Använd annars**.

<!-- Referenced links -->
[2]: ../../../../../admin/lists/learn/add-items-to-mailing-domain.md
[4]: ../../../../learn/create-folder.md

<!-- Referenced images -->
