<!-- markdownlint-disable-file MD041 -->
> [!TIP]
> Om du vill visa och skriva ut ett befintligt dokumentutskick stänger du steget **Konfiguration** (klicka på **Avbryt** eller **Spara + stäng**). Välj fliken **Utskick**, leta rätt på dokumentet, klicka på ![ikon][img1] och välj **Visning**. Klicka på knappen under **Hämta genererat dokument**. Dokumentet hämtas då till webbläsaren. Öppna och skriv ut dokumentet.

Med arbetsflödet för dokumentutskick kan du generera ett PDF-dokument som ska skrivas ut och skicka det till dina kunder. Det första steget för att skapa ett dokumentutskick är att **konfigurera** utskicket. Här kan du ställa in utskickets namn, ange rubriken och Obs!-texten i dokumentet och ställa in olika arkiveringsalternativ för utskicket.

Du kan koppla dokumentutskicket till ett specifikt projekt. Det kan vara relevant om du skapar utskick till mottagare som deltar i ett projekt i SuperOffice CRM. Genom att använda mallvariabler i mallen kan du infoga projektuppgifter i utskicket.

Du kan koppla dokumentutskicket till en specifik försäljning. Det kan vara relevant om du skapar utskick till mottagare som är intressenter i en försäljning i SuperOffice CRM. Genom att använda mallvariabler i mallen kan du infoga försäljningsdata i utskicket.

**Steg:**

1. Ange ett namn i fältet **Namn för utskick**.

2. I fältet **Rubrik** anger du dokumentets titel.

3. I fältet **Riktat till** ska du välja vem utskicket ska rikta sig till. Välj ett av följande alternativ:

    * **Om ingen definierats**: Välj det här alternativet om du vill använda mottagarnas namn som standard, eller, om inget mottagarnamn hittas, använd mottagaren som du anger i textfältet. Om du vill göra ett utskick till IT-teknikerna vid ett företag kan du t.ex. skriva "IT-avdelningen" eller liknande.

    * **Använd alltid**: Välj det här alternativet om du vill åsidosätta mottagarnamnen och bara använda mottagaren som du anger i textfältet.

4. Tillval: Börja skriva i fältet **Projekt** om du vill söka efter ett projekt i SuperOffice CRM.

5. Tillval: Börja skriva i fältet **Försäljning** om du vill söka efter en försäljning i SuperOffice CRM.

6. I fältet **Vår ref** ska du ange det namn som ska anges som "vår referens" i dokumentet. Du kan använda [mallvariablerna][1] från SuperOffice CRM i det här fältet.

    > [!NOTE]
    > För att variabler som försäljnings-ID och projekt-ID ska fungera måste du koppla dokumentutskicket till en försäljning eller ett projekt.

7. Välj en mapp som du vill placera utskicket i från listan **Mapp**.

    [Hur skapar jag en utskicksmapp?][19]

8. I fälten **Urval** och **Projekt** kan du associera utskicket med ett urval och/eller ett projekt.

    [!include[Start typing to search](type-to-search.md)]

9. Klicka på **Nästa** när du vill gå vidare till nästa steg.

> [!TIP]
> Klicka på knappen **Spara + stäng** om du vill spara och stänga utskicket. Du kan fortsätta att arbeta på utskicket senare.

<!-- Referenced links -->
[1]:https://docs.superoffice.com/en/document/templates/variables/index.html
[19]: ../../../../learn/create-folder.md

<!-- Referenced images -->
[img1]: ../../../../../../media/icons/btn-menu.png
