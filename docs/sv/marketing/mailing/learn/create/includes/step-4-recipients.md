<!-- markdownlint-disable-file MD041 MD034 -->
När du skapar ett utskick måste du välja mottagare för utskicket. Du kan lägga till mottagare från flera källor. Du kan dessutom ställa in olika utskicksalternativ här och även förhandsgranska utskicket.

Din mållista är den grupp människor du tror kommer att svara bäst på ditt meddelande. Om du skräddarsyr ditt marknadsföringsbudskap specifikt för den gruppen ökar du chanserna att nå framgång och undviker att slösa tid och arbete på människor som inte är intresserade.

Du kan använda urval, projekt eller lägga till enskilda kontakter i SuperOffice CRM.

På grund av GDPR-lagstiftningen kan endast de kontakter som har uttryckt samtycke till att sparas lagligt i SuperOffice CRM-databasen och ta emot information läggas till som mottagare.

![Du kan lägga till mottagarna från antingen urval, projekt, en enskild kontakt eller en extern lista som du måste importera -screenshot][img3]

### Lägga till mottagare från urval och projekt

Du kan lägga till mottagare från urval (från både SuperOffice CRM och SuperOffice Service) och projekt (från SuperOffice CRM).

1. Under **Lägg till mottagare**, klicka på **Urval** eller **Projekt**.

2. Klicka på fältet nedanför och börja att skriva namnet på det urval eller projekt som du vill lägga till. Träffarna visas i en dynamisk lista medan du skriver.

3. Klicka på ett urval eller projekt i listan.

4. Klicka på **+**. Urvalet eller projektet läggs till i listan **Mottagarkällor** och listan **Mottagare** uppdateras.

5. Upprepa steg 1–4 om du vill lägga till fler urval eller projekt.

> [!NOTE]
> Om du valde ett urval under **Arkivera utskick** i **Konfiguration** (steg 1) visas detta urval under **Mottagarkällor**. Du kan ta bort detta urval om det behövs.

### Lägga till kontakter från SuperOffice

Du kan lägga till enskilda kontakter från SuperOffice.

1. Under **Lägg till mottagare**, klicka på **Kontakt**.

2. Klicka i fältet nedan och börja skriva namnet på kontakten som du vill lägga till, i fältet nedan. Du kan också ange ett företagsnamn om du vill visa alla kontakter i ett företag.

3. Välj önskad kontakt i listan som visas.

4. Klicka på **+**. Kontakten läggs till i listan **Mottagarkällor** och listan **Mottagare** uppdateras.

5. Upprepa steg 2-5 om du vill lägga till fler kontakter. Ytterligare kontakter läggs till i samma rad i listan **Mottagarkällor** och antalet kontakter visas i kolumnen **Namn**.

### Importera en lista över mottagare (kontakter) från en extern fil

Du kan lägga till mottagare till ett utskick genom att importera dem från en extern kommaavgränsad fil (t.ex. en txt-fil skapad i Notepad eller en csv-fil skapad i Excel).

När du importerar en lista med namn och e-postadresser kommer SuperOffice Marknadsföring att försöka lokalisera de importerade mottagarna i SuperOffice-databasen. Om någon träff hittas listas mottagarnas företag i kolumnen **Företag** i listan **Mottagare**. Namn eller e-postadresser som **inte** finns i SuperOffice filtreras bort och inkluderas inte i utskicket. Detta beror på GDPR-regelverket.

#### Steg

1. Klicka på **Välj fil**.

2. Lokalisera relevant fil (.txt, .csv eller liknande textformat).

3. Klicka på **+**. Listan läggs till i listan **Mottagarkällor** och listan **Mottagare** uppdateras.

4. Upprepa steg 2-4 om du vill lägga till fler mottagare. Ytterligare mottagare läggs till i samma rad i listan **Mottagarkällor**. Det totala antalet mottagare visas i kolumnen **Namn**.

> [!NOTE]
> Import är inte tillgängligt för dokumentutskick.

#### Importera filformat

* Varje mottagare ska stå på en separat rad.

* Varje mottagare (rad) ska innehålla mottagarens fullständiga namn och e-postadress.

    Exempel: "John Smith, john@company.com"

    > [!NOTE]
    > Du kan även ange endast e-postadressen. Namnet kommer då inte att finnas tillgängligt som mallvariabel.

* Lokalt: Varje mottagare (rad) kan även innehålla ett mobiltelefonnummer (efter e-postadressen) om du skapar SMS-utskick. Till exempel: "John Smith, john@company.com, 99999999". Kräver SMS-licens för marknadsföring.

> [!NOTE]
> Om du bara har mobiltelefonnumret och vill skicka SMS-utskick kan du skriva så här: " , , 99887766".

### Mottagaralternativ

Under **Alternativ** i den nedre delen av skärmen **Mottagare** kan du välja alternativ för utskicket baserat på dess typ.

**Tillgänglighet per utskickstyp:**

| Alternativ | Dokument | E-post | SMS |
|---|:-:|:-:|:-:|
| Åsidosätt medgivande och prenumeration | x | x | x |
| Endast ett meddelande per e-postadress | | x | x |
| Uppdatera mottagarlistan när du skickar | | x | x |
| Inkludera företag | x | x | |
| Föredrar företag | x | x | |

* **Åsidosätt medgivande och prenumeration**: Välj även det här alternativet om du vill skicka utskick till kontakter som inte vill få e-marknadsföring eller inte prenumererar på den här utskickstypen. De här kontakterna visas med statusen **Inget medgivande** i listan **Mottagare**.

* **Endast ett meddelande per e-postadress**: Välj det här alternativet om du vill ta bort dubbla e-postadresser i mottagarlistan (anges med **Dubblett** i kolumnen **Status**). Listan **Mottagare** uppdateras då.

* **Uppdatera mottagarlistan när du skickar**: Välj detta alternativ om du vill uppdatera mottagarlistan automatiskt innan du skickar utskicket. Se **Uppdatera mottagarlistan** nedan.

* **Inkludera företag**: Välj det här alternativet om du vill inkludera företag som mottagare.

    > [!NOTE]
    > Om ett företag inte har en e-postadress, kommer utskicket istället att skickas till alla relaterade kontakter på listan över mottagare.

* **Föredrar företag**: Välj detta alternativ om du bara vill skicka utskicket till företagen på mottagarlistan (och inte relaterade kontakter). Varje företag kommer endast att få ett utskick. Kontakter som inte tillhör ett företag kommer fortfarande att få utskicket.

    > [!NOTE]
    > Alternativet **Föredra företag** är endast tillgängligt om du har valt **Inkludera företag** ovan.

### Förhandsgranska utskicket

Efter att ha lagt till mottagare i listan **Mottagare** kan du förhandsgranska utskicket och se hur det kommer att se ut för en av mottagarna. Förhandsgranskning är inte tillgängligt för dokument- och SMS-utskick.

> [!NOTE]
> Utskicket kommer **inte** att skickas till mottagaren vid förhandsgranskning.

1. Klicka på en mottagare i listan **Mottagare**.

2. Klicka på knappen **Förhandsgranska**. I fönstret **Förhandsgranska** visas då utskicket på det sätt som det kommer att se ut för den valda mottagaren. Alla mallvariabler (exempelvis namn och företag) har ersatts av mottagarens faktiska kontaktuppgifter.

3. Klicka på länkar för att kontrollera om de fungerar, men kom ihåg att nollställa dem efteråt om de är spårade.

4. Klicka på X när du vill stänga fönstret **Förhandsgranska**.

### Granska och uppdatera listan Mottagare

När du lägger till urval, projekt eller kontakter och importerar listor uppdateras listan **Mottagare** automatiskt. Om du markerat **Uppdatera mottagarlistan när du skickar** kontrolleras projekten och urvalen innan utskicket skickas om kontakter har lagts till, tagits bort eller redigerats.

Dessutom kan du klicka på knappen **Uppdatera lista** under listan **Mottagare** om du vill uppdatera listan manuellt. En del av kontakterna på listan kan ha ändrat sitt medgivande efter att du lade till dem.

> [!NOTE]
> Listan visar bara de 50 första mottagarna. Klicka på **Ladda alla** längst ned i listan om du vill visa alla mottagare.

Klicka på **Nästa** för att gå till Steg 5: Bekräfta. Du kan fortfarande gå till steget **Mottagare** igen om du vill redigera mottagarlistan.

<!-- Referenced images -->
[img3]: ../../../../../../media/loc/en/marketing/add-target-list.png
