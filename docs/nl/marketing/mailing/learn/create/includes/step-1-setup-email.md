<!-- markdownlint-disable-file MD041 -->
De eerste stap bij het maken van een mailing per e-mail is **Instellingen**. Hier kan de koptekst van de e-mail worden ingesteld met informatie zoals afzender, antwoordadres en onderwerp. U kunt ook bijlagen toevoegen, archiveringsopties instellen voor de mailing en volgopties selecteren.

1. Voer een naam in het veld **Naam van mailing**.

1. Voer het onderwerp van de e-mail in het veld **Onderwerp van e-mail** in.

1. Selecteer in de lijst **Van** **Gebruik altijd** en voer het e-mailadres van de afzender in het veld eronder in om dezelfde afzender te gebruiken voor alle mailings. U kunt ook een verkoop- of ondersteuningscontactpersoon als de afzender kiezen indien er een is gedefinieerd voor deze ontvanger. Voer een e-mailadres in dat moet worden gebruikt als er geen verkoop- of ondersteuningscontactpersoon beschikbaar is. Als uw beheerder de [algemene e-mailvalidatievoorkeur][2], heeft geactiveerd, selecteert u het domein van waaruit u wilt verzenden in de vervolgkeuzelijst.

    [!include[Note](spf-look-up.md)]

1. In de lijst **Antwoorden aan** hebt u dezelfde opties tot uw beschikking als hierboven. Daarnaast kunt u **"Van" gebruiken als antwoordadres** selecteren. Alle antwoorden worden dan verzonden aan de afzender.

1. Selecteer een map waarin u de mailing wilt plaatsen in de lijst **Mappen**.

    [Hoe maak ik een mailingmap?][4]

1. In de velden **Selectie** en **Project** kunt u de mailing koppelen aan een selectie en/of een project. Als u een selectie toevoegt, worden in de mailing alle personen in de selectie toegevoegd als ontvangers.

    [!include[Start typing to search](type-to-search.md)]

1. Selecteer in de lijst **Type** het type mailing dat u gaat maken. Selecteer **(Alles)** als de mailing overeenkomt met twee of meer van de beschikbare typen. Gebruik**(Alles)** nadat u meerdere ontvangers hebt toegevoegd met meerdere abonnementen en u de mailing naar allen wilt verzenden.

1. **Bijlagen**: Als u een of meer bijlagen wilt toevoegen aan de mailing, gebruikt u een van de volgende methoden:

    * Klik op **Bestand uploaden (of hierheen slepen)** om naar een bestand op een schijf of server te bladeren en het toe te voegen.
    * Sleep een bestand vanuit Windows Explorer naar het veld voor de bijlagen.
    * Klik op **Een CRM-document kiezen** om een document te selecteren in SuperOffice CRM.

1. Bij **Traceren** hebt u de volgende opties ter beschikking:

    [!include[Tracking options for mailing](mailing-tracking-options.md)]

1. Klik op **Volgende** om naar de volgende stap te gaan.

### E-maildomeinvalidatie (ALLEEN ONLINE)

Als uw beheerder de [algemene voorkeur][2] **Alleen goedgekeurde e-maildomeinen gebruiken** heeft geactiveerd, wordt het veld **Van - adres** gesplitst en moet u het domein van waaruit u wilt verzenden selecteren in de vervolgkeuzelijst met goedgekeurde domeinen.
Als u probeert te verzenden vanuit een domein dat geen geldige SPF-record heeft, wordt er een waarschuwing weergegeven en kunt u niet verzenden vanuit dat domein. Dit geldt voor alle e-maildomeinen, zelfs als de validatievoorkeur niet is geactiveerd.

> [!NOTE]
> Als **Ons contactadres** een e-maildomein heeft dat niet is gevalideerd, wordt de mailing automatisch verzonden vanaf het adres dat is opgegeven in de vervolgkeuzelijst **Anders gebruiken**.

<!-- Referenced links -->
[2]: ../../../../../admin/lists/learn/add-items-to-mailing-domain.md
[4]: ../../../../learn/create-folder.md

<!-- Referenced images -->
